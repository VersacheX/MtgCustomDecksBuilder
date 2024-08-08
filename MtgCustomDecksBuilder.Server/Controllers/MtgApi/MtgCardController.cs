using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using MtgCustomDecksBuilder.Server.Tools;
using System.Data;
using System.Data.Common;
using System.Net.Http.Headers;
using MtgApiManager.Lib.Service;
using MtgApiManager.Lib.Core;
using MtgApiManager.Lib.Model;
using Persistence.Schema;

namespace MtgCustomDecksBuilder.Server.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    [Authorize]
    public class MtgCardController : BaseController
    {
        private readonly MtgCustomDecksBuilderContext _masterContext;

        public MtgCardController(MtgCustomDecksBuilderContext masterContext)
        {
            _masterContext = masterContext;
        }

        [HttpPost]
        public async Task<IActionResult> GetMtgCardsByCriteria(MtgCardSearchCriteria criteria)
        {
            List<MtgCard> resultCards = new List<MtgCard>();


            resultCards = _masterContext.MtgCards
                .Where(x =>

                (!string.IsNullOrWhiteSpace(criteria.Name) ? x.Name.Contains(criteria.Name)  : true)
                && (!string.IsNullOrWhiteSpace(criteria.SetType) ? x.MtgCardSets.Any(y=>y.MtgSetFkNavigation.Type == criteria.SetType && y.MtgSetFkNavigation.Code == x.Set) : true )
                && (criteria.SetFromDate != null ? x.MtgCardSets.Any(y => y.MtgSetFkNavigation.ReleaseDate >= criteria.SetFromDate && y.MtgSetFkNavigation.Code == x.Set) : true)
                && (criteria.SetToDate != null ? x.MtgCardSets.Any(y=> y.MtgSetFkNavigation.ReleaseDate <= criteria.SetToDate && y.MtgSetFkNavigation.Code == x.Set) : true)
                )
                .GroupBy(x => x.Name)
                .Select(x=>x.FirstOrDefault())
                .Distinct()
                .Take(5000)
                .ToList();

            return Ok(resultCards);
        }
    }

    public class MtgCardSearchCriteria
    {
        public string? CmcTo { get; set; }
        public string? Name { get; set; }
        public string? SetCode { get; set; }
        public string? SetType { get; set; }

        public DateTime? SetFromDate { get; set; }
        public DateTime? SetToDate { get; set; }
    }

}
