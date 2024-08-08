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
using System.Net;
using Persistence.Schema;

namespace MtgCustomDecksBuilder.Server.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    [Authorize]
    public class HomebrewController : BaseController
    {
        private readonly MtgCustomDecksBuilderContext _masterContext;

        public HomebrewController(MtgCustomDecksBuilderContext masterContext)
        {
            _masterContext = masterContext;
        }

        [HttpPost]
        public async Task<IActionResult> GetHomebrewsByCriteria(HomebrewSearchCriteria criteria)
        {
            List<DeckRuleCriterion> resultSet = new List<DeckRuleCriterion>();

            try
            {
                resultSet = _masterContext.DeckRuleCriteria.Where(x => true)
                    //.Include(x => x.GameFormatFkNavigation)
                    //.Include(x => x.MtgFormatFkNavigation)
                    //.Include(x => x.UserFkNavigation) //only include forward facing data
                    .ToList();
            } catch (Exception ex)
            {

            }

            //resultSet = _masterContext.MtgSets.Where(x =>

            //    (!string.IsNullOrWhiteSpace(criteria.Name) ? x.Name.Contains(criteria.Name) : true)
            //    && (criteria.FromDate != null ? x.ReleaseDate >= criteria.FromDate : true)
            //    && (criteria.ToDate != null ? x.ReleaseDate <= criteria.ToDate : true)
            //    && (criteria.PaperOnly == true ? x.OnlineOnly == false : true)
            //    && (!string.IsNullOrWhiteSpace(criteria.SetType) ? x.Type.Contains(criteria.SetType) : true)
            //    && (criteria.SetFromDate != null ? x.ReleaseDate >= criteria.SetFromDate : true)
            //    && (criteria.SetToDate != null ? x.ReleaseDate <= criteria.SetToDate : true)
            //    ).ToList();

            return Ok(resultSet);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetHomebrew(int id)
        {
            return Ok(_masterContext.MtgSetTypes.ToList());
        }
    }

    public class HomebrewSearchCriteria
    {
        public string? CmcTo { get; set; }
        public string? Name { get; set; }
        public string? SetCode { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string? SetType { get; set; }
        public bool? PaperOnly { get; set; }

        public DateTime? SetFromDate { get; set; }
        public DateTime? SetToDate { get; set; }
    }

}
