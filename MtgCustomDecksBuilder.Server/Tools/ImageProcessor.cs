using Microsoft.Extensions.Caching.Memory;
using Persistence.Schema;
using System.Drawing;
using System.Text.RegularExpressions;

namespace MtgCustomDecksBuilder.Server.Tools
{
    public class ImageProcessor
    {
        private readonly IMemoryCache _cache;

        public ImageProcessor(IMemoryCache cache)
        {
            _cache = cache;
        }

        public void ProcessImages()
        {
            var mtgCards = _cache.Get<List<MtgCard>>("MtgCardsCache");
            if (mtgCards != null)
            {
                Task.Run(() => ProcessImagesAsync(mtgCards));
            }
        }

        public async Task ProcessImagesAsync(List<MtgCard> mtgCards)
        {
            foreach (var card in mtgCards)
            {
                string imageUrl = card.ImageUrl;
                if (!string.IsNullOrEmpty(imageUrl) && !string.IsNullOrEmpty(ExtractMultiverseId(imageUrl)))
                {
                    await ProcessAndSaveImageAsync(imageUrl, ExtractMultiverseId(imageUrl).ToString());
                }
                else
                {

                }
            }
        }

        public string ExtractMultiverseId(string imageUrl)
        {
            var match = Regex.Match(imageUrl, @"multiverseid=(\d+)");
            return match.Success ? match.Groups[1].Value : string.Empty;
        }

        private async Task ProcessAndSaveImageAsync(string imageUrl, string cardId)
        {
            string savePath = $@"C:\temp\downloadedImage\mv_{cardId}.png";

            if (File.Exists(savePath))
            {
                return;
            }

            using (HttpClient client = new HttpClient())
            {
                byte[] imageBytes = await client.GetByteArrayAsync(imageUrl);

                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    Image originalImage = Image.FromStream(ms);
                    Image resizedImage = new Bitmap(originalImage, new Size(745, 1040));
                    int newWidth = 815;
                    int newHeight = 1110;

                    using (Bitmap newImage = new Bitmap(newWidth, newHeight))
                    {
                        using (Graphics graphics = Graphics.FromImage(newImage))
                        {
                            graphics.Clear(Color.Black); // Change the border color if needed
                            int x = (newWidth - resizedImage.Width) / 2;
                            int y = (newHeight - resizedImage.Height) / 2;
                            graphics.DrawImage(resizedImage, x, y, resizedImage.Width, resizedImage.Height);
                        }

                        Directory.CreateDirectory(Path.GetDirectoryName(savePath));
                        newImage.Save(savePath, System.Drawing.Imaging.ImageFormat.Png);
                    }
                }
            }
        }
    }
}
