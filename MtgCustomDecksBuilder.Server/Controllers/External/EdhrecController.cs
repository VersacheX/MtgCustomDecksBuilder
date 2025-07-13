using Bobj;
using BObj.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Persistence.Schema;
using static Bobj.EdhrecApi;

namespace MtgCustomDecksBuilder.Server.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    [Authorize]
    public class EdhrecController : BaseController
    {
        private readonly MtgCustomDecksBuilderContext _masterContext;
        private readonly IMemoryCache _cache;

        public EdhrecController(MtgCustomDecksBuilderContext masterContext, IMemoryCache cache)
        {
            _masterContext = masterContext;
            _cache = cache;
        }

        [HttpPost]
        public async Task<IActionResult> GetSuggestedCardsByCriteria(EdhrecSearchCriteria criteria)
        {
            EdhrecDto dto = await SourceEdhRecData(criteria, _cache);

            List<MtgCardDto> legalCards = new List<MtgCardDto>();
            foreach (var key in dto.MtgCardGroupLists.Keys)
            {
                foreach (MtgCard card in dto.MtgCardGroupLists[key])
                {
                    int index = dto.EdhrecCardGroupLists[key].FindIndex(x => x.ToLower() == card.Name.ToLower());
                    string value = dto.EdhrecPercentInUserDeckLists[key][index];

                    var suggestedCard = MtgCardDto.FromEntity(card, _cache);
                    suggestedCard.EdhrecIncludeStats = value.Replace("\n", "<br/>");
                    legalCards.Add(suggestedCard);
                }
            }

            return Ok(legalCards);
        }
    }
}