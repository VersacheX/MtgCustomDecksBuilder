using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BObj.Scryfall
{
    public class ScryfallCardDto
    {
        public string Object { get; set; }
        public string Id { get; set; }
        public string OracleId { get; set; }
        public int[] MultiverseIds { get; set; }
        public int MtgoId { get; set; }
        public int ArenaId { get; set; }
        public int TcgplayerId { get; set; }
        public string Name { get; set; }
        public string Lang { get; set; }
        public string ReleasedAt { get; set; }
        public string Uri { get; set; }
        public string ScryfallUri { get; set; }
        public string Layout { get; set; }
        public bool HighresImage { get; set; }
        public string ImageStatus { get; set; }
        public ImageUris ImageUris { get; set; }
        public string ManaCost { get; set; }
        public float Cmc { get; set; }
        public string TypeLine { get; set; }
        public string OracleText { get; set; }
        public string[] Colors { get; set; }
        public string[] ColorIdentity { get; set; }
        public string[] ProducedMana { get; set; }
        public Legalities Legalities { get; set; }
        public string[] Games { get; set; }
        public bool Reserved { get; set; }
        public bool Foil { get; set; }
        public bool Nonfoil { get; set; }
        public string[] Finishes { get; set; }
        public bool Oversized { get; set; }
        public bool Promo { get; set; }
        public bool Reprint { get; set; }
        public bool Variation { get; set; }
        public string SetId { get; set; }
        public string Set { get; set; }
        public string SetName { get; set; }
        public string SetType { get; set; }
        public string SetUri { get; set; }
        public string SetSearchUri { get; set; }
        public string ScryfallSetUri { get; set; }
        public string RulingsUri { get; set; }
        public string PrintsSearchUri { get; set; }
        public string CollectorNumber { get; set; }
        public bool Digital { get; set; }
        public string Rarity { get; set; }
        public string CardBackId { get; set; }
        public string Artist { get; set; }
        public string[] ArtistIds { get; set; }
        public string IllustrationId { get; set; }
        public string BorderColor { get; set; }
        public string Frame { get; set; }
        public bool FullArt { get; set; }
        public bool Textless { get; set; }
        public bool Booster { get; set; }
        public bool StorySpotlight { get; set; }
        public Prices Prices { get; set; }
        public RelatedUris RelatedUris { get; set; }
        public PurchaseUris PurchaseUris { get; set; }
    }

    public class ImageUris
    {
        public string Small { get; set; }
        public string Normal { get; set; }
        public string Large { get; set; }
        public string Png { get; set; }
        public string ArtCrop { get; set; }
        public string BorderCrop { get; set; }
    }

    public class Legalities
    {
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

    public class Prices
    {
        public string Usd { get; set; }
        public string UsdFoil { get; set; }
        public string UsdEtched { get; set; }
        public string Eur { get; set; }
        public string EurFoil { get; set; }
        public string Tix { get; set; }
    }

    public class RelatedUris
    {
        public string Gatherer { get; set; }
        public string TcgplayerInfiniteArticles { get; set; }
        public string TcgplayerInfiniteDecks { get; set; }
        public string Edhrec { get; set; }
    }

    public class PurchaseUris
    {
        public string Tcgplayer { get; set; }
        public string Cardmarket { get; set; }
    }
}
