using System.Text.Json.Serialization;

namespace BObj.External
{
    public class Included
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("of")]
        public List<Of>? Of { get; set; }

        [JsonPropertyName("uses")]
        public List<Use>? Uses { get; set; }

        [JsonPropertyName("notes")]
        public string? Notes { get; set; }

        [JsonPropertyName("prices")]
        public Prices? Prices { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("spoiler")]
        public bool? Spoiler { get; set; }

        [JsonPropertyName("identity")]
        public string? Identity { get; set; }

        [JsonPropertyName("includes")]
        public List<Include>? Includes { get; set; }

        [JsonPropertyName("produces")]
        public List<Produce>? Produces { get; set; }

        [JsonPropertyName("requires")]
        public List<object>? Requires { get; set; }
    }

    public class Of
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }
    }

    public class Use
    {
        [JsonPropertyName("card")]
        public Card? Card { get; set; }

        [JsonPropertyName("quantity")]
        public int? Quantity { get; set; }

        [JsonPropertyName("zoneLocations")]
        public List<string>? ZoneLocations { get; set; }

        [JsonPropertyName("exileCardState")]
        public string? ExileCardState { get; set; }

        [JsonPropertyName("mustBeCommander")]
        public bool? MustBeCommander { get; set; }

        [JsonPropertyName("libraryCardState")]
        public string? LibraryCardState { get; set; }

        [JsonPropertyName("graveyardCardState")]
        public string? GraveyardCardState { get; set; }

        [JsonPropertyName("battlefieldCardState")]
        public string? BattlefieldCardState { get; set; }
    }

    public class Card
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("spoiler")]
        public bool? Spoiler { get; set; }

        [JsonPropertyName("oracleId")]
        public string? OracleId { get; set; }
    }

    public class Prices
    {
        [JsonPropertyName("tcgplayer")]
        public string? Tcgplayer { get; set; }

        [JsonPropertyName("cardmarket")]
        public string? Cardmarket { get; set; }

        [JsonPropertyName("cardkingdom")]
        public string? Cardkingdom { get; set; }
    }

    public class Include
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }
    }

    public class Produce
    {
        [JsonPropertyName("feature")]
        public Feature? Feature { get; set; }

        [JsonPropertyName("quantity")]
        public int? Quantity { get; set; }
    }

    public class Feature
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("uncountable")]
        public bool? Uncountable { get; set; }
    }
}
