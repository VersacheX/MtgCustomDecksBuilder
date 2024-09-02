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
    public class MtgSetController : BaseController
    {
        private readonly MtgCustomDecksBuilderContext _masterContext;

        public MtgSetController(MtgCustomDecksBuilderContext masterContext)
        {
            _masterContext = masterContext;
        }

        [HttpPost]
        public async Task<IActionResult> GetMtgSetsByCriteria(MtgSetSearchCriteria criteria)
        {
            List<MtgSet> resultSet = new List<MtgSet>();


            resultSet = _masterContext.MtgSets.Where(x =>

                (!string.IsNullOrWhiteSpace(criteria.SetName) ? x.Name.Contains(criteria.SetName) : true)
                && (criteria.FromDate != null ? x.ReleaseDate >= criteria.FromDate : true)
                && (criteria.ToDate != null ? x.ReleaseDate <= criteria.ToDate : true)
                && (criteria.PaperOnly == true ? x.OnlineOnly == false : true)
                && (!string.IsNullOrWhiteSpace(criteria.SetType) ? x.Type.Contains(criteria.SetType) : true)
                && (criteria.SetFromDate != null ? x.ReleaseDate >= criteria.SetFromDate : true)
                && (criteria.SetToDate != null ? x.ReleaseDate <= criteria.SetToDate : true)
                ).ToList();

            return Ok(resultSet);
        }

        [HttpGet]
        public async Task<IActionResult> GetMtgSetTypes()
        {
            return Ok(_masterContext.MtgSetTypes.ToList());
        }
    }

    public class MtgSetSearchCriteria
    {
        public string? CmcTo { get; set; }
        public string? Name { get; set; }
        public string? SetName { get; set; }
        public string? SetCode { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string? SetType { get; set; }
        public bool? PaperOnly { get; set; }

        public DateTime? SetFromDate { get; set; }
        public DateTime? SetToDate { get; set; }
    }

}
