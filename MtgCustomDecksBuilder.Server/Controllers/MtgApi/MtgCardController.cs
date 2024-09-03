using BObj.Dto;
using Dapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using Persistence.Schema;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace MtgCustomDecksBuilder.Server.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    [Authorize]
    public class MtgCardController : BaseController
    {
        private readonly MtgCustomDecksBuilderContext _masterContext;
        private readonly IMemoryCache _cache;

        public MtgCardController(MtgCustomDecksBuilderContext masterContext, IMemoryCache cache)
        {
            _masterContext = masterContext;
            _cache = cache;
        }

        [HttpPost]
        public async Task<IActionResult> GetMtgCardsByCriteria(MtgCardSearchCriteria criteria)
        {
            List<MtgCardDto> resultList = new List<MtgCardDto>();

            try
            {
                // Retrieve cached data
                if (!_cache.TryGetValue("MtgCardsCache", out List<MtgCard> cachedMtgCards))
                {
                    return BadRequest("Cache not found");
                }

                resultList = cachedMtgCards
                    //_masterContext.MtgCards
                .Where(x =>
                (!string.IsNullOrWhiteSpace(criteria.Name) ? x.Name.Contains(criteria.Name) : true)
                && (!string.IsNullOrWhiteSpace(criteria.SetType) ? x.MtgCardSets.Any(y => y.MtgSetFkNavigation.Type == criteria.SetType && y.MtgSetFkNavigation.Code == x.Set) : true)
                && (criteria.SetFromDate != null ? x.MtgCardSets.Any(y => y.MtgSetFkNavigation.ReleaseDate >= criteria.SetFromDate && y.MtgSetFkNavigation.Code == x.Set) : true)
                && (criteria.SetToDate != null ? x.MtgCardSets.Any(y => y.MtgSetFkNavigation.ReleaseDate <= criteria.SetToDate && y.MtgSetFkNavigation.Code == x.Set) : true)
                && (criteria.Legality != null ? x.MtgCardLegalities.Any(y => y.Format == criteria.Legality && (y.Legality == "Legal" || y.Legality == "Restricted")) : true)
                )
                .GroupBy(x => x.Name)
                .Select(x => x.FirstOrDefault())
                .Distinct()
                .Take(5000)
                .Select(MtgCardDto.FromEntity)
                .ToList();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok(resultList);
        }

        [HttpPost]

        public async Task<IActionResult> GetDropdownSuggestions(MtgCardDropDownSearchCriteria criteria)
        {
            List<MtgCardDto> resultList = new List<MtgCardDto>();

            try
            {
                // Retrieve cached data
                if (!_cache.TryGetValue("MtgCardsCache", out List<MtgCard> cachedMtgCards))
                {
                    return BadRequest("Cache not found");
                }

                // Filter the cached data based on criteria
                var query = cachedMtgCards.AsQueryable();

                if (criteria.Homebrew != null)
                {
                    query = query.Where(card => criteria.Homebrew.IsCardLegal(card));
                }

                if (!string.IsNullOrWhiteSpace(criteria.Query))
                {
                    query = query.Where(card => card.Name.Contains(criteria.Query));
                }

                var ignoredNames = criteria.IgnoredCardList?.Select(card => card.Name).ToList();
                if (ignoredNames != null && ignoredNames.Any())
                {
                    query = query.Where(card => !ignoredNames.Contains(card.Name));
                }

                if (!string.IsNullOrWhiteSpace(criteria.ColorIdentity))
                {
                    var legalIdentitiesSet = new HashSet<string>(criteria.ColorIdentity.Split(','));

                    // Preprocess the cards to create a list of sets for ColorIdentity
                    var preprocessedCards = query.ToList().Select(card => new
                    {
                        Card = card,
                        ColorIdentitySet = new HashSet<string>(card.ColorIdentity.Split(','))
                    }).ToList();

                    // Filter the preprocessed cards
                    var filteredCards = preprocessedCards
                        .Where(pc => pc.ColorIdentitySet.All(cardColor => legalIdentitiesSet.Contains(cardColor)))
                        .Select(pc => pc.Card);

                    query = filteredCards.AsQueryable();
                }
                else
                    query = query.Where(card => string.IsNullOrWhiteSpace(card.ColorIdentity));

                var top100Ids = query.Take(100).Select(card => card.MtgCardPk).ToList();

                var resultCards = query
                    .Where(card => top100Ids.Contains(card.MtgCardPk))
                    .ToList();

                resultList = resultCards
                    .GroupBy(card => card.Name)
                    .Select(group => group.First())
                    .Take(25)
                    .Select(MtgCardDto.FromEntity)
                    .ToList();

            }
            catch (Exception ex)
            {
                return BadRequest();
            }

            return Ok(resultList);
        }
        

        private bool FilterByColorIdentity(string cardColorIdentity, string[] legalIdentities)
        {
            if (legalIdentities.Length == 0)
            {
                return string.IsNullOrWhiteSpace(cardColorIdentity);
            }

            var identities = cardColorIdentity.Split(',');
            return identities.All(identity => legalIdentities.Contains(identity));
        }
    }


    public class MtgCardDropDownSearchCriteria
    {
        public HomebrewDto? Homebrew { get; set; }
        public List<MtgCardDto>? IgnoredCardList { get; set; }
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
