using BObj.Scryfall;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO.Compression;

namespace MtgCustomDecksBuilder.Server.Services
{
    public class BulkDataLoaderService
    {
        private readonly IMemoryCache _cache;
        private readonly IHttpClientFactory _httpClientFactory;

        public BulkDataLoaderService(IMemoryCache cache, IHttpClientFactory httpClientFactory)
        {
            _cache = cache;
            _httpClientFactory = httpClientFactory;
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

                    var defaultCardsData = bulkData["data"].FirstOrDefault(d => d["type"].ToString() == "default_cards");
                    if (defaultCardsData != null)
                    {
                        string downloadUrl = defaultCardsData["download_uri"].ToString();

                        HttpResponseMessage bulkDataResponse = await client.GetAsync(downloadUrl);
                        bulkDataResponse.EnsureSuccessStatusCode();

                        string bulkDataContent = await DecompressResponseAsync(bulkDataResponse.Content);
                        var cards = JsonConvert.DeserializeObject<List<ScryfallCardDto>>(bulkDataContent);

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
