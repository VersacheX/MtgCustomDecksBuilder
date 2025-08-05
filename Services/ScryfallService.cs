using Microsoft.Extensions.Logging;
using System.IO.Compression;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;

namespace Services
{
    public class ScryfallService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<ScryfallService> _logger;

        public ScryfallService(IHttpClientFactory httpClientFactory, ILogger<ScryfallService> logger)
        {
            _httpClientFactory = httpClientFactory;
            _logger = logger;
        }

        public async Task GetDumpAsync()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (...) Chrome/127.0.0.0 Safari/537.36");
            client.DefaultRequestHeaders.AcceptEncoding.ParseAdd("gzip");
            client.DefaultRequestHeaders.AcceptLanguage.ParseAdd("en-US,en;q=0.9");

            var response = await client.GetAsync("https://api.scryfall.com/bulk-data");
            var raw = await response.Content.ReadAsStreamAsync();

            //var gzipStream = await client.GetStreamAsync("https://api.scryfall.com/bulk-data"); 
            using var decompressedStream = new GZipStream(raw, CompressionMode.Decompress);
            using var reader = new StreamReader(decompressedStream);
            var json = await reader.ReadToEndAsync();

            using var doc = JsonDocument.Parse(json);
            var root = doc.RootElement;
            var dataArray = root.GetProperty("data").EnumerateArray();

            string? allCardsUri = null;
            foreach (var item in dataArray)
            {
                if (item.GetProperty("type").GetString() == "all_cards" &&
                    item.TryGetProperty("download_uri", out var uriProp))
                {
                    allCardsUri = uriProp.GetString();
                    break;
                }
            }

            if (string.IsNullOrEmpty(allCardsUri))
            {
                Console.WriteLine("No 'all_cards' bulk file found.");
                return;
            }

            Console.WriteLine($"Downloading from: {allCardsUri}");
            using var gzipStream = await client.GetStreamAsync(allCardsUri);
            using var decompressedStream2 = new GZipStream(gzipStream, CompressionMode.Decompress);

            // 👇 Parse directly from stream — avoids loading whole string into memory first
            //using var doc2 = await JsonDocument.ParseAsync(decompressedStream2);
            //var root2 = doc2.RootElement; // This will be the array of cards

            var filePath = $"C:\\temp\\scryfall_allcards_{DateTime.UtcNow:yyyyMMdd_HHmmss}.json";
            Directory.CreateDirectory(Path.GetDirectoryName(filePath)!);

            using var fileStream = File.Create(filePath);
            await decompressedStream2.CopyToAsync(fileStream);

            Console.WriteLine($"Card data saved to: {filePath}");

        }
    }
}
