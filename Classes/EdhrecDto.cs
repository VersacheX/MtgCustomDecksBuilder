using Persistence.Schema;

namespace Bobj
{
    public class EdhrecDto
    {
        public static string[] EDHREC_NODE_IDS = { "newcards", "highsynergycards", "topcards", "creatures", "instants", "sorceries", "utilityartifacts", "enchantments", "planeswalkers", "utilitylands", "manaartifacts", "lands" };

        public Dictionary<string, List<string>>? EdhrecCardGroupLists { get; set; }
        public Dictionary<string, List<MtgCard>>? MtgCardGroupLists { get; set; }
    }
}
