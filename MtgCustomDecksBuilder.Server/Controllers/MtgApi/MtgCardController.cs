using BObj.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence.Schema;
using System.Data;

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
                && (criteria.Legality != null ? x.MtgCardLegalities.Any(y => y.Format == criteria.Legality && (y.Legality == "Legal" || y.Legality == "Restricted")) : true)
                )
                .GroupBy(x => x.Name)
                .Select(x=>x.FirstOrDefault())
                .Distinct()
                .Take(5000)
                .ToList();

            return Ok(resultCards);
        }

        [HttpPost]
        public async Task<IActionResult> GetDropdownSuggestions(MtgCardDropDownSearchCriteria criteria)
        {
            var query = _masterContext.MtgCards.AsQueryable();

            if (!string.IsNullOrWhiteSpace(criteria.Query))
            {
                query = query.Where(card => card.Name.Contains(criteria.Query));
            }

            var resultCards = await query.ToListAsync();

            if (!string.IsNullOrWhiteSpace(criteria.ColorIdentity))
            {
                string[] legalIdentities = criteria.ColorIdentity.Split(',');

                resultCards = resultCards.Where(card =>
                    card.ColorIdentity.Split(',')
                    .All(identity => legalIdentities.Contains(identity))
                ).ToList();
            }

            resultCards = resultCards
                .GroupBy(card => card.Name)
                .Select(group => group.First())
                .Distinct()
                .Take(5000)
                .ToList();

            var resultDtos = resultCards.Select(MtgCardDto.FromEntity).ToList();

            return Ok(resultDtos);
        }
    }

    public class MtgCardDropDownSearchCriteria
    {
        public HomebrewDto? Homebrew { get; set; }
        public string? ColorIdentity { get; set; }
        public string? Query { get; set; }
    }
    public class MtgCardSearchCriteria
    {
        public string? CmcTo { get; set; }
        public string? Name { get; set; }
        public string? SetCode { get; set; }
        public string? SetType { get; set; }

        public DateTime? SetFromDate { get; set; }
        public DateTime? SetToDate { get; set; }
        public string? Legality { get; set; }
    }

}
