using BObj.Scryfall;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Persistence.Schema;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Text;


namespace MtgDeckBuilderServices
{
    public class BulkDataLoaderService
    {
        private readonly IMemoryCache _cache;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly MtgCustomDecksBuilderContext _masterContext;

        public BulkDataLoaderService(IMemoryCache cache, IHttpClientFactory httpClientFactory, MtgCustomDecksBuilderContext masterContext)
        {
            _cache = cache;
            _httpClientFactory = httpClientFactory;
            _masterContext = masterContext;
        }
        public async Task LoadBulkDataAsync()
        {
            string bulkDataUrl = "https://api.scryfall.com/bulk-data";

            using (HttpClient client = _httpClientFactory.CreateClient())
            {
                SetDefaultRequestHeaders(client);

                try
                {
                    HttpResponseMessage response = await client.GetAsync(bulkDataUrl);
                    response.EnsureSuccessStatusCode();

                    string responseBody = await DecompressResponseAsync(response.Content);
                    JObject bulkData = JObject.Parse(responseBody);

                    var defaultCardsData = bulkData["data"].FirstOrDefault(d => d["type"].ToString() == "all_cards");
                    if (defaultCardsData != null)
                    {
                        string downloadUrl = defaultCardsData["download_uri"].ToString();

                        HttpResponseMessage bulkDataResponse = await client.GetAsync(downloadUrl);
                        bulkDataResponse.EnsureSuccessStatusCode();

                        using var decompressed = await GetDecompressedCardResponseStreamAsync(bulkDataResponse.Content);
                        using var reader = new StreamReader(decompressed);
                        using var jsonReader = new JsonTextReader(reader);

                        var cards = new List<ScryfallCardDto>();
                        var serializer = new JsonSerializer();
                        int currentCard = 0;
                        while (await jsonReader.ReadAsync())
                        {
                            currentCard++;
                            if (jsonReader.TokenType == JsonToken.StartObject)
                            {
                                var card = serializer.Deserialize<ScryfallCardDto>(jsonReader);
                                cards.Add(card);

                                var existCard = _masterContext.ScryfallCards
                                                        .Include(x => x.ScryfallCardImageUris)
                                                        .Include(x => x.ScryfallCardLegalities)
                                                        .Include(x => x.ScryfallCardPrices)
                                                        .Include(x => x.ScryfallCardPurchaseUris)
                                                        .Include(x => x.ScryfallCardRelatedUris)
                                                        .FirstOrDefault(x => x.Id == card.Id);


                                if (existCard == null)
                                {
                                    var dlCard = card.ToSchema();
                                    _masterContext.ScryfallCards.Add(dlCard);
                                    _masterContext.SaveChanges();
                                }
                                else
                                {
                                    var existDto = new ScryfallCardDto(existCard);
                                    string dlSerialized = JsonConvert.SerializeObject(card);
                                    string existSerialized = JsonConvert.SerializeObject(existDto);

                                    string dlHash = ComputeSha256Hash(dlSerialized);
                                    string existHash = ComputeSha256Hash(existSerialized);

                                    if (dlHash != existHash)
                                    {
                                        var updated = card.ToSchema(existCard.ScryfallCardPk);

                                        var cardChangeReport = ScryfallCardDto.CompareChanges(existDto, card);
                                        // 1. Main card
                                        if (cardChangeReport.MainCardChanged)
                                            ApplyChanges(existCard, updated, _masterContext);
                                            //_masterContext.Entry(existCard).CurrentValues.SetValues(updated);

                                        // 2. Child entities (single-item lists)
                                        if(cardChangeReport.ImageUrisChanged)
                                            ApplyChanges(existCard.ScryfallCardImageUris.First(), updated.ScryfallCardImageUris.First(), _masterContext);
                                            //_masterContext.Entry(existCard.ScryfallCardImageUris.FirstOrDefault()).CurrentValues.SetValues(updated.ScryfallCardImageUris.FirstOrDefault());
                                        if(cardChangeReport.LegalitiesChanged)
                                            ApplyChanges(existCard.ScryfallCardLegalities.First(), updated.ScryfallCardLegalities.First(), _masterContext);
                                            //_masterContext.Entry(existCard.ScryfallCardLegalities.FirstOrDefault()).CurrentValues.SetValues(updated.ScryfallCardLegalities.FirstOrDefault());
                                        //if(cardChangeReport.PricesChanged)
                                        //    _masterContext.Entry(existCard.ScryfallCardPrices.FirstOrDefault()).CurrentValues.SetValues(updated.ScryfallCardPrices.FirstOrDefault());
                                        if(cardChangeReport.PurchaseUrisChanged)
                                            ApplyChanges(existCard.ScryfallCardPurchaseUris.First(), updated.ScryfallCardPurchaseUris.First(), _masterContext);
                                            //_masterContext.Entry(existCard.ScryfallCardPurchaseUris.FirstOrDefault()).CurrentValues.SetValues(updated.ScryfallCardPurchaseUris.FirstOrDefault());
                                        if(cardChangeReport.RelatedUrisChanged)
                                            ApplyChanges(existCard.ScryfallCardRelatedUris.First(), updated.ScryfallCardRelatedUris.First(), _masterContext);
                                            //_masterContext.Entry(existCard.ScryfallCardRelatedUris.FirstOrDefault()).CurrentValues.SetValues(updated.ScryfallCardRelatedUris.FirstOrDefault());

                                        // 3. Save
                                        _masterContext.SaveChanges();

                                        //_masterContext.Entry(existCard).CurrentValues.SetValues(dlCard);
                                    }
                                }
                                // Process, cache, index, or buffer — without blowing memory
                            }
                        }

                        // Cache the card data
                        _cache.Set("CardData", cards);
                        Console.WriteLine("Bulk card data loaded into cache.");
                    }
                    else
                    {
                        Console.WriteLine("Default cards bulk data not found.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }

        private static void ApplyChanges<T>(T tracked, T updated, DbContext ctx) where T : class
        {
            var entry = ctx.Entry(tracked);
            var props = typeof(T).GetProperties();

            foreach (var prop in props)
            {
                if (!prop.CanRead || !prop.CanWrite)
                    continue;

                var propType = prop.PropertyType;
                var nameLower = prop.Name.ToLower();

                // Skip PK, FK, and navigation/collection properties
                if (nameLower.EndsWith("pk") || nameLower.EndsWith("fk"))
                    continue;
                if (typeof(IEnumerable<object>).IsAssignableFrom(propType) && propType != typeof(string))
                    continue;
                if (!IsSimpleType(propType))
                    continue;

                var updatedValue = prop.GetValue(updated);
                prop.SetValue(tracked, updatedValue);
                entry.Property(prop.Name).IsModified = true;
            }
        }

        /// <summary>
        /// Determines if a type is a basic scalar type safe for copying
        /// </summary>
        private static bool IsSimpleType(Type type)
        {
            var typeInfo = type.IsGenericType ? type.GetGenericTypeDefinition() : type;
            return
                type.IsPrimitive ||
                type == typeof(string) ||
                type == typeof(decimal) ||
                type == typeof(DateTime) ||
                type == typeof(Guid) ||
                type == typeof(DateTimeOffset) ||
                type == typeof(TimeSpan) ||
                type == typeof(byte[]) ||
                Convert.GetTypeCode(type) != TypeCode.Object;
        }



        private static string ComputeSha256Hash(string rawJson)
        {
            using var sha256 = SHA256.Create();
            var bytes = Encoding.UTF8.GetBytes(rawJson);
            var hashBytes = sha256.ComputeHash(bytes);
            return BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();
        }

        private async Task<Stream> GetDecompressedCardResponseStreamAsync(HttpContent content)
        {
            var stream = await content.ReadAsStreamAsync();
            var encoding = string.Join(",", content.Headers.ContentEncoding);

            return encoding.Contains("gzip") ? new GZipStream(stream, CompressionMode.Decompress)
                 : encoding.Contains("deflate") ? new DeflateStream(stream, CompressionMode.Decompress)
                 : encoding.Contains("br") ? new BrotliStream(stream, CompressionMode.Decompress)
                 : throw new NotSupportedException($"Encoding '{encoding}' is not supported.");
        }


        private async Task<string> DecompressResponseAsync(HttpContent content)
        {
            using (var stream = await content.ReadAsStreamAsync())
            {
                var encoding = content.Headers.ContentEncoding.ToString();
                Stream decompressedStream;

                if (encoding.Contains("gzip"))
                {
                    decompressedStream = new GZipStream(stream, CompressionMode.Decompress);
                }
                else if (encoding.Contains("deflate"))
                {
                    decompressedStream = new DeflateStream(stream, CompressionMode.Decompress);
                }
                else if (encoding.Contains("br"))
                {
                    decompressedStream = new BrotliStream(stream, CompressionMode.Decompress);
                }
                else
                {
                    throw new NotSupportedException($"Encoding '{encoding}' is not supported.");
                }

                using (decompressedStream)
                using (var reader = new StreamReader(decompressedStream))
                {
                    return await reader.ReadToEndAsync();
                }
            }
        }

        public void SetDefaultRequestHeaders(HttpClient client)
        {
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.7");
            client.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate, br, zstd");
            client.DefaultRequestHeaders.Add("Accept-Language", "en-US,en;q=0.9");
            client.DefaultRequestHeaders.Add("Cache-Control", "max-age=0");
            //client.DefaultRequestHeaders.Add("If-None-Match", "W/\"005556771afc5c004dcf8de24d31eea2\"");
            client.DefaultRequestHeaders.Add("Priority", "u=0, i");
            client.DefaultRequestHeaders.Add("sec-ch-ua", "\"Chromium\";v=\"128\", \"Not;A=Brand\";v=\"24\", \"Microsoft Edge\";v=\"128\"");
            client.DefaultRequestHeaders.Add("sec-ch-ua-mobile", "?0");
            client.DefaultRequestHeaders.Add("sec-ch-ua-platform", "\"Windows\"");
            client.DefaultRequestHeaders.Add("sec-fetch-dest", "document");
            client.DefaultRequestHeaders.Add("sec-fetch-mode", "navigate");
            client.DefaultRequestHeaders.Add("sec-fetch-site", "none");
            client.DefaultRequestHeaders.Add("sec-fetch-user", "?1");
            client.DefaultRequestHeaders.Add("Upgrade-Insecure-Requests", "1");
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/128.0.0.0 Safari/537.36 Edg/128.0.0.0");
        }
    }
}
