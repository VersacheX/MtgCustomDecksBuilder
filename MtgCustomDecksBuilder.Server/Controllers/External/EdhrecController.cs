using Bobj;
using BObj.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        public EdhrecController(MtgCustomDecksBuilderContext masterContext)
        {
            _masterContext = masterContext;
        }

        [HttpPost]
        public async Task<IActionResult> GetSuggestedCardsByCriteria(EdhrecSearchCriteria criteria)
        {
            EdhrecDto dto = await EdhrecApi.SourceEdhRecData(criteria, _masterContext);

            List<MtgCardDto> legalCards = new List<MtgCardDto>();
            foreach (var key in dto.MtgCardGroupLists.Keys)
            {
                foreach (MtgCard card in dto.MtgCardGroupLists[key])
                {
                    legalCards.Add(MtgCardDto.FromEntity(card));
                }
            }

            return Ok(legalCards);
        }
        static HttpClient AddSpellbookHeaders(HttpClient client)
        {
            client.DefaultRequestHeaders.Add("accept", "application/json");
            client.DefaultRequestHeaders.Add("accept-language", "en-US,en;q=0.9");
            client.DefaultRequestHeaders.Add("origin", "https://commanderspellbook.com");
            client.DefaultRequestHeaders.Add("priority", "u=1, i");
            client.DefaultRequestHeaders.Add("referer", "https://commanderspellbook.com/");
            client.DefaultRequestHeaders.Add("sec-ch-ua", "\"Not)A;Brand\";v=\"99\", \"Microsoft Edge\";v=\"127\", \"Chromium\";v=\"127\"");
            client.DefaultRequestHeaders.Add("sec-ch-ua-mobile", "?0");
            client.DefaultRequestHeaders.Add("sec-ch-ua-platform", "\"Windows\"");
            client.DefaultRequestHeaders.Add("sec-fetch-dest", "empty");
            client.DefaultRequestHeaders.Add("sec-fetch-mode", "cors");
            client.DefaultRequestHeaders.Add("sec-fetch-site", "same-site");
            client.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/127.0.0.0 Safari/537.36 Edg/127.0.0.0");

            return client;
        }
    }
}