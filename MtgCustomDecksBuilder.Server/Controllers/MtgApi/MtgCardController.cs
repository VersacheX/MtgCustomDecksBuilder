using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using MtgCustomDecksBuilder.Server.Schema.WNSMaster;
using MtgCustomDecksBuilder.Server.Tools;
using System.Data;
using System.Data.Common;
using System.Net.Http.Headers;
using MtgApiManager.Lib.Service;
using MtgApiManager.Lib.Core;
using MtgApiManager.Lib.Model;

namespace MtgCustomDecksBuilder.Server.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    [Authorize]
    public class MtgCardController : ProviderBaseController
    {
        private IConfiguration _config;
        private readonly IMtgServiceProvider _mtgServiceProvider;

        public MtgCardController(IConfiguration config, IMtgServiceProvider mtgServiceProvider)
        {
            _config = config;
            _mtgServiceProvider = mtgServiceProvider;
        }

        [HttpPost]
        public async Task<IActionResult> GetMtgCardsByCriteria(MtgCardSearchCriteria criteria)
        {
            ICardService cardService = _mtgServiceProvider.GetCardService();

            if (!string.IsNullOrWhiteSpace(criteria.Name))
                cardService.Where(x => x.Name, criteria.Name);

            if (!string.IsNullOrWhiteSpace(criteria.SetCode))
                cardService.Where(x => x.Set, criteria.SetCode);
            //IOperationResult<List<ICard>> cardList = await cardService.Where(x => x.Cmc, criteria.CmcTo).AllAsync();

            //IOperationResult<List<ICard>> cardList = await cardService.Where(x => x.Set, "ktk")
            //                                                          .Where(x => x.SubTypes, "warrior,human").AllAsync();

            IOperationResult<List<ICard>> cardList = await cardService.AllAsync();

            if (cardList.IsSuccess)                
                return Ok(cardList.Value);

            return BadRequest();
        }
    }

    public class MtgCardSearchCriteria
    {
        public string? CmcTo { get; set; }
        public string? Name { get; set; }
        public string? SetCode { get; set; }
    }

}
