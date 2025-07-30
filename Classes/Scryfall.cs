using BObj.External;
using Persistence.Schema;

namespace BObj.Scryfall
{
    public class ScryfallCardDto
    {
        public ScryfallCardDto() { }
        public ScryfallCardDto(ScryfallCard schemaCard)
        {
            this.Object = schemaCard.Object;
            this.Id = schemaCard.Id;
            this.Oracle_Id = schemaCard.OracleId;
            this.Multiverse_Ids = schemaCard.MultiverseIds?
                                    .Split(',')
                                    .Where(s => !string.IsNullOrWhiteSpace(s))
                                    .Select(int.Parse)
                                    .ToArray();
            this.Mtgo_Id = schemaCard.MtgoId ?? 0;
            this.Arena_Id = schemaCard.ArenaId ?? 0;
            this.Tcgplayer_Id = schemaCard.TcgplayerId ?? 0;
            this.Name = schemaCard.Name;
            this.Lang = schemaCard.Lang;
            this.Released_At = schemaCard.ReleasedAt?.ToString("yyyy-MM-dd");
            this.Uri = schemaCard.Uri;
            this.Scryfall_Uri = schemaCard.ScryfallUri;
            this.Layout = schemaCard.Layout;
            this.Highres_Image = schemaCard.HighresImage ?? false;
            this.Image_Status = schemaCard.ImageStatus;
            this.Mana_Cost = schemaCard.ManaCost;
            this.Cmc = schemaCard.Cmc != null ? Convert.ToSingle(schemaCard.Cmc) : 0;
            this.Type_Line = schemaCard.TypeLine;
            this.Oracle_Text = schemaCard.OracleText;
            this.Colors = schemaCard.Colors?.Split(',').ToArray();
            if (this.Colors.Length == 1 && this.Colors[0] == "") this.Colors = new string[0];
            this.Color_Identity = schemaCard.ColorIdentity?.Split(',').ToArray();
            if (this.Color_Identity.Length == 1 && this.Color_Identity[0] == "") this.Color_Identity = new string[0];
            this.Produced_Mana = schemaCard.ProducedMana?.Split(',').ToArray();
            if (this.Produced_Mana.Length == 1 && this.Produced_Mana[0] == "") this.Produced_Mana = null;
            this.Games = schemaCard.Games?.Split(',').ToArray();
            this.Reserved = schemaCard.Reserved ?? false;
            this.Game_Changer = schemaCard.GameChanger ?? false;
            this.Foil = schemaCard.Foil ?? false;
            this.Nonfoil = schemaCard.Nonfoil ?? false;
            this.Finishes = schemaCard.Finishes?.Split(',').ToArray();
            if (this.Finishes.Length == 1 && this.Finishes[0] == "") this.Finishes = new string[0];
            this.Oversized = schemaCard.Oversized ?? false;
            this.Promo = schemaCard.Promo ?? false;
            this.Reprint = schemaCard.Reprint ?? false;
            this.Variation = schemaCard.Variation ?? false;
            this.Set_Id = schemaCard.SetId;
            this.Set = schemaCard.Set;
            this.Set_Name = schemaCard.SetName;
            this.Set_Type = schemaCard.SetType;
            this.Set_Uri = schemaCard.SetUri;
            this.Set_Search_Uri = schemaCard.SetSearchUri;
            this.Scryfall_Set_Uri = schemaCard.ScryfallSetUri;
            this.Rulings_Uri = schemaCard.RulingsUri;
            this.Prints_Search_Uri = schemaCard.PrintsSearchUri;
            this.Collector_Number = schemaCard.CollectorNumber;
            this.Digital = schemaCard.Digital ?? false;
            this.Rarity = schemaCard.Rarity;
            this.Card_Back_Id = schemaCard.CardBackId;
            this.Artist = schemaCard.Artist;
            this.Artist_Ids = schemaCard.ArtistIds?.Split(',').ToArray();
            if (this.Artist_Ids.Length == 1 && this.Artist_Ids[0] == "") this.Artist_Ids = new string[0];
            this.Illustration_Id = schemaCard.IllustrationId;
            this.Border_Color = schemaCard.BorderColor;
            this.Frame = schemaCard.Frame;
            this.Full_Art = schemaCard.FullArt ?? false;
            this.Textless = schemaCard.Textless ?? false;
            this.Booster = schemaCard.Booster ?? false;
            this.Story_Spotlight = schemaCard.StorySpotlight ?? false;

            // Related objects
            var image = schemaCard.ScryfallCardImageUris?.FirstOrDefault();
            if (image != null)
            {
                this.Image_Uris = new ScryfallCardImageUris
                {
                    Small = image.Small,
                    Normal = image.Normal,
                    Large = image.Large,
                    Png = image.Png,
                    Art_Crop = image.ArtCrop,
                    Border_Crop = image.BorderCrop
                };
            }

            var legality = schemaCard.ScryfallCardLegalities?.FirstOrDefault();
            if (legality != null)
            {
                this.Legalities = new ScryfallCardLegalities
                {
                    Standard = legality.Standard,
                    Future = legality.Future,
                    Historic = legality.Historic,
                    Timeless = legality.Timeless,
                    Gladiator = legality.Gladiator,
                    Pioneer = legality.Pioneer,
                    Explorer = legality.Explorer,
                    Modern = legality.Modern,
                    Legacy = legality.Legacy,
                    Pauper = legality.Pauper,
                    Vintage = legality.Vintage,
                    Penny = legality.Penny,
                    Commander = legality.Commander,
                    Oathbreaker = legality.Oathbreaker,
                    Standardbrawl = legality.Standardbrawl,
                    Brawl = legality.Brawl,
                    Alchemy = legality.Alchemy,
                    Paupercommander = legality.Paupercommander,
                    Duel = legality.Duel,
                    Oldschool = legality.Oldschool,
                    Premodern = legality.Premodern,
                    Predh = legality.Predh
                };
            }

            var prices = schemaCard.ScryfallCardPrices?.FirstOrDefault();
            if (prices != null)
            {
                this.Prices = new ScryfallCardPrices
                {
                    Usd = prices.Usd,
                    Usd_Foil = prices.UsdFoil,
                    Usd_Etched = prices.UsdEtched,
                    Eur = prices.Eur,
                    Eur_Foil = prices.EurFoil,
                    Tix = prices.Tix
                };
            }

            var related = schemaCard.ScryfallCardRelatedUris?.FirstOrDefault();
            if (related != null)
            {
                this.Related_Uris = new ScryfallCardRelatedUris
                {
                    Gatherer = related.Gatherer,
                    Tcgplayer_Infinite_Articles = related.TcgplayerInfiniteArticles,
                    Tcgplayer_Infinite_Decks = related.TcgplayerInfiniteDecks,
                    Edhrec = related.Edhrec
                };
            }

            var purchase = schemaCard.ScryfallCardPurchaseUris?.FirstOrDefault();
            if (purchase != null)
            {
                this.Purchase_Uris = new ScryfallCardPurchaseUris
                {
                    Tcgplayer = purchase.Tcgplayer,
                    Cardmarket = purchase.Cardmarket
                };
            }
        }

        public int ScryfallCardPK { get; set; }
        public string Object { get; set; }
        public string Id { get; set; }
        public string Oracle_Id { get; set; }
        public int[] Multiverse_Ids { get; set; }
        public int Mtgo_Id { get; set; }
        public int Arena_Id { get; set; }
        public int Tcgplayer_Id { get; set; }
        public string Name { get; set; }
        public string Lang { get; set; }
        public string Released_At { get; set; }
        public string Uri { get; set; }
        public string Scryfall_Uri { get; set; }
        public string Layout { get; set; }
        public bool Highres_Image { get; set; }
        public string Image_Status { get; set; }
        public ScryfallCardImageUris Image_Uris { get; set; }
        public string Mana_Cost { get; set; }
        public float Cmc { get; set; }
        public string Type_Line { get; set; }
        public string Oracle_Text { get; set; }
        public string[] Colors { get; set; }
        public string[] Color_Identity { get; set; }
        public string[] Produced_Mana { get; set; }
        public ScryfallCardLegalities Legalities { get; set; }
        public string[] Games { get; set; }
        public bool Reserved { get; set; }
        public bool Game_Changer { get; set; }
        public bool Foil { get; set; }
        public bool Nonfoil { get; set; }
        public string[] Finishes { get; set; }
        public bool Oversized { get; set; }
        public bool Promo { get; set; }
        public bool Reprint { get; set; }
        public bool Variation { get; set; }
        public string Set_Id { get; set; }
        public string Set { get; set; }
        public string Set_Name { get; set; }
        public string Set_Type { get; set; }
        public string Set_Uri { get; set; }
        public string Set_Search_Uri { get; set; }
        public string Scryfall_Set_Uri { get; set; }
        public string Rulings_Uri { get; set; }
        public string Prints_Search_Uri { get; set; }
        public string Collector_Number { get; set; }
        public bool Digital { get; set; }
        public string Rarity { get; set; }
        public string Card_Back_Id { get; set; }
        public string Artist { get; set; }
        public string[] Artist_Ids { get; set; }
        public string Illustration_Id { get; set; }
        public string Border_Color { get; set; }
        public string Frame { get; set; }
        public bool Full_Art { get; set; }
        public bool Textless { get; set; }
        public bool Booster { get; set; }
        public bool Story_Spotlight { get; set; }
        public ScryfallCardPrices Prices { get; set; }
        public ScryfallCardRelatedUris Related_Uris { get; set; }
        public ScryfallCardPurchaseUris Purchase_Uris { get; set; }

        public ScryfallCard ToSchema(int? existId = null)
        {
            var card = new ScryfallCard
            {
                Object = this.Object,
                Id = this.Id,
                OracleId = this.Oracle_Id,
                MultiverseIds = string.Join(",", this.Multiverse_Ids ?? new int[0]),
                MtgoId = this.Mtgo_Id,
                ArenaId = this.Arena_Id,
                TcgplayerId = this.Tcgplayer_Id,
                Name = this.Name,
                Lang = this.Lang,
                ReleasedAt = DateTime.Parse(this.Released_At),
                Uri = this.Uri,
                ScryfallUri = this.Scryfall_Uri,
                Layout = this.Layout,
                HighresImage = this.Highres_Image,
                ImageStatus = this.Image_Status,
                ManaCost = this.Mana_Cost,
                Cmc = this.Cmc,
                TypeLine = this.Type_Line,
                OracleText = this.Oracle_Text,
                Colors = string.Join(",", this.Colors ?? new string[0]),
                ColorIdentity = string.Join(",", this.Color_Identity ?? new string[0]),
                ProducedMana = string.Join(",", this.Produced_Mana ?? new string[0]),
                Games = string.Join(",", this.Games ?? new string[0]),
                Reserved = this.Reserved,
                GameChanger = this.Game_Changer,
                Foil = this.Foil,
                Nonfoil = this.Nonfoil,
                Finishes = string.Join(",", this.Finishes ?? new string[0]),
                Oversized = this.Oversized,
                Promo = this.Promo,
                Reprint = this.Reprint,
                Variation = this.Variation,
                SetId = this.Set_Id,
                Set = this.Set,
                SetName = this.Set_Name,
                SetType = this.Set_Type,
                SetUri = this.Set_Uri,
                SetSearchUri = this.Set_Search_Uri,
                ScryfallSetUri = this.Scryfall_Set_Uri,
                RulingsUri = this.Rulings_Uri,
                PrintsSearchUri = this.Prints_Search_Uri,
                CollectorNumber = this.Collector_Number,
                Digital = this.Digital,
                Rarity = this.Rarity,
                CardBackId = this.Card_Back_Id,
                Artist = this.Artist,
                ArtistIds = string.Join(",", this.Artist_Ids ?? new string[0]),
                IllustrationId = this.Illustration_Id,
                BorderColor = this.Border_Color,
                Frame = this.Frame,
                FullArt = this.Full_Art,
                Textless = this.Textless,
                Booster = this.Booster,
                StorySpotlight = this.Story_Spotlight
            };

            ScryfallCardImageUri imageUris = new ScryfallCardImageUri
            {
                //ScryfallCardFK = card.ScryfallCardPK,
                Small = this.Image_Uris?.Small,
                Normal = this.Image_Uris?.Normal,
                Large = this.Image_Uris?.Large,
                Png = this.Image_Uris?.Png,
                ArtCrop = this.Image_Uris?.Art_Crop,
                BorderCrop = this.Image_Uris?.Border_Crop
            };
            ScryfallCardLegality legalities = new ScryfallCardLegality
            {
                Standard = this.Legalities?.Standard,
                Future = this.Legalities?.Future,
                Historic = this.Legalities?.Historic,
                Timeless = this.Legalities?.Timeless,
                Gladiator = this.Legalities?.Gladiator,
                Pioneer = this.Legalities?.Pioneer,
                Explorer = this.Legalities?.Explorer,
                Modern = this.Legalities?.Modern,
                Legacy = this.Legalities?.Legacy,
                Pauper = this.Legalities?.Pauper,
                Vintage = this.Legalities?.Vintage,
                Penny = this.Legalities?.Penny,
                Commander = this.Legalities?.Commander,
                Oathbreaker = this.Legalities?.Oathbreaker,
                Standardbrawl = this.Legalities?.Standardbrawl,
                Brawl = this.Legalities?.Brawl,
                Alchemy = this.Legalities?.Alchemy,
                Paupercommander = this.Legalities?.Paupercommander,
                Duel = this.Legalities?.Duel,
                Oldschool = this.Legalities?.Oldschool,
                Premodern = this.Legalities?.Premodern,
                Predh = this.Legalities?.Predh
            };
            ScryfallCardPrice prices = new ScryfallCardPrice
            {
                Usd = this.Prices?.Usd,
                UsdFoil = this.Prices?.Usd_Foil,
                UsdEtched = this.Prices?.Usd_Etched,
                Eur = this.Prices?.Eur,
                EurFoil = this.Prices?.Eur_Foil,
                Tix = this.Prices?.Tix
            };
            ScryfallCardRelatedUri relatedUri = new ScryfallCardRelatedUri
            {
                Gatherer = this.Related_Uris?.Gatherer,
                TcgplayerInfiniteArticles = this.Related_Uris?.Tcgplayer_Infinite_Articles,
                TcgplayerInfiniteDecks = this.Related_Uris?.Tcgplayer_Infinite_Decks,
                Edhrec = this.Related_Uris?.Edhrec
            };
            ScryfallCardPurchaseUri purchaseUri = new ScryfallCardPurchaseUri
            {
                Tcgplayer = this.Purchase_Uris?.Tcgplayer,
                Cardmarket = this.Purchase_Uris?.Cardmarket
            };
            if (existId.HasValue)
            {
                card.ScryfallCardPk = existId.Value;
                imageUris.ScryfallCardFk = existId.Value;
                legalities.ScryfallCardFk = existId.Value;
                prices.ScryfallCardFk = existId.Value;
                relatedUri.ScryfallCardFk = existId.Value;
                purchaseUri.ScryfallCardFk = existId.Value;
            }

            card.ScryfallCardImageUris = new List<ScryfallCardImageUri>() { imageUris };
            card.ScryfallCardLegalities = new List<ScryfallCardLegality>() { legalities };
            card.ScryfallCardPrices = new List<ScryfallCardPrice>() { prices };
            card.ScryfallCardPurchaseUris = new List<ScryfallCardPurchaseUri>() { purchaseUri };
            card.ScryfallCardRelatedUris = new List<ScryfallCardRelatedUri>() { relatedUri };

            return card;
        }

        public static CardChangeReport CompareChanges(ScryfallCardDto original, ScryfallCardDto updated)
        {
            var report = new CardChangeReport();

            // Compare core card fields
            var coreProps = typeof(ScryfallCardDto)
                .GetProperties()
                .Where(p => p.PropertyType != typeof(ScryfallCardImageUris)
                         && p.PropertyType != typeof(ScryfallCardLegalities)
                         && p.PropertyType != typeof(ScryfallCardPrices)
                         && p.PropertyType != typeof(ScryfallCardRelatedUris)
                         && p.PropertyType != typeof(ScryfallCardPurchaseUris));

            foreach (var prop in coreProps)
            {
                var origVal = prop.GetValue(original);
                var updateVal = prop.GetValue(updated);

                if (!ArePropertyValuesEqual(origVal, updateVal))
                {
                    if (origVal is Array && updateVal == null && ((Array)origVal).Length == 0)
                        break;
                    report.MainCardChanged = true;
                    report.FieldDifferences.Add(prop.Name);
                }
                //if (!Equals(origVal, updateVal))
                //{
                //    report.MainCardChanged = true;
                //    report.FieldDifferences.Add(prop.Name);
                //}
            }

            // Compare nested single objects
            report.ImageUrisChanged = updated.Image_Uris != null && !AreEqual(original.Image_Uris, updated.Image_Uris);
            report.LegalitiesChanged = updated.Legalities != null && !AreEqual(original.Legalities, updated.Legalities);
            report.PricesChanged = updated.Prices != null && !AreEqual(original.Prices, updated.Prices);
            report.RelatedUrisChanged = updated.Related_Uris != null && !AreEqual(original.Related_Uris, updated.Related_Uris);
            report.PurchaseUrisChanged = updated.Purchase_Uris != null && !AreEqual(original.Purchase_Uris, updated.Purchase_Uris);

            return report;
        }
        private static bool ArePropertyValuesEqual(object a, object b)
        {
            if (ReferenceEquals(a, b)) return true;
            if (a == null || b == null) return false;

            // Handle arrays
            if (a is Array arrA && b is Array arrB)
            {
                var elemType = arrA.GetType().GetElementType();
                if (arrA.Length != arrB.Length) return false;

                if (elemType == typeof(int))
                    return ((int[])arrA).SequenceEqual((int[])arrB);
                if (elemType == typeof(string))
                    return ((string[])arrA).SequenceEqual((string[])arrB);
            }


            // Default fallback
            return a.Equals(b);
        }

        private static bool AreEqual<T>(T a, T b)
        {
            if (a == null && b == null) return true;
            if (a == null || b == null) return false;

            foreach (var prop in typeof(T).GetProperties())
            {
                if (prop.Name.ToLower().EndsWith("pk"))
                    continue;

                var valA = prop.GetValue(a);
                var valB = prop.GetValue(b);

                if (!Equals(valA, valB))
                    return false;
            }

            return true;
        }

    }

    public class ScryfallCardImageUris
    {
        public int ScryfallCardFK { get; set; }
        public string Small { get; set; }
        public string Normal { get; set; }
        public string Large { get; set; }
        public string Png { get; set; }
        public string Art_Crop { get; set; }
        public string Border_Crop { get; set; }
    }

    public class ScryfallCardLegalities
    {
        public int ScryfallCardFK { get; set; }
        public string Standard { get; set; }
        public string Future { get; set; }
        public string Historic { get; set; }
        public string Timeless { get; set; }
        public string Gladiator { get; set; }
        public string Pioneer { get; set; }
        public string Explorer { get; set; }
        public string Modern { get; set; }
        public string Legacy { get; set; }
        public string Pauper { get; set; }
        public string Vintage { get; set; }
        public string Penny { get; set; }
        public string Commander { get; set; }
        public string Oathbreaker { get; set; }
        public string Standardbrawl { get; set; }
        public string Brawl { get; set; }
        public string Alchemy { get; set; }
        public string Paupercommander { get; set; }
        public string Duel { get; set; }
        public string Oldschool { get; set; }
        public string Premodern { get; set; }
        public string Predh { get; set; }
    }

    public class ScryfallCardPrices
    {
        public int ScryfallCardFK { get; set; }
        public string Usd { get; set; }
        public string Usd_Foil { get; set; }
        public string Usd_Etched { get; set; }
        public string Eur { get; set; }
        public string Eur_Foil { get; set; }
        public string Tix { get; set; }
    }

    public class ScryfallCardRelatedUris
    {
        public int ScryfallCardFK { get; set; }
        public string Gatherer { get; set; }
        public string Tcgplayer_Infinite_Articles { get; set; }
        public string Tcgplayer_Infinite_Decks { get; set; }
        public string Edhrec { get; set; }
    }

    public class ScryfallCardPurchaseUris
    {
        public int ScryfallCardFK { get; set; }
        public string Tcgplayer { get; set; }
        public string Cardmarket { get; set; }
    }
    public class CardChangeReport
    {
        public bool MainCardChanged { get; set; }
        public bool ImageUrisChanged { get; set; }
        public bool LegalitiesChanged { get; set; }
        public bool PricesChanged { get; set; }
        public bool RelatedUrisChanged { get; set; }
        public bool PurchaseUrisChanged { get; set; }
        public List<string> FieldDifferences { get; set; } = new();
    }

}
