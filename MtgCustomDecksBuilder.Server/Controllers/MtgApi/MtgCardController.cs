using BObj.Dto;
using BObj.External;
using LinqKit;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Persistence.Schema;
using System.Data;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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

                var predicate = BuildPredicate(criteria);
                var query = cachedMtgCards.AsQueryable();
                query = query.Where(predicate);
                query = query.Where(x => (criteria.Homebrew != null ? criteria.Homebrew.IsCardLegal(x) : true));
                
                var ignoredNames = criteria.IgnoredCardList?.Select(card => card.Name.ToLower()).ToList();
                if (ignoredNames != null && ignoredNames.Any())
                {
                    query = query.Where(card => !ignoredNames.Contains(card.Name.ToLower()));
                }


                if (criteria.ColorIdentity?.Length > 0)
                {
                    var legalIdentitiesSet = new HashSet<string>(criteria.ColorIdentity);

                    // Preprocess the cards to create a list of sets for ColorIdentity
                    var preprocessedCards = query.ToList().Select(card => new
                    {
                        Card = card,
                        ColorIdentitySet = new HashSet<string>(card.ColorIdentity.Split(','))
                    }).ToList();

                    // Filter the preprocessed cards
                    var filteredCards = preprocessedCards
                        .Where(pc => pc.ColorIdentitySet.All(cardColor => cardColor == string.Empty || legalIdentitiesSet.Contains(cardColor)))
                        .Select(pc => pc.Card)
                        .ToList();

                    // Filter the original query based on the filtered cards
                    query = query.Where(card => filteredCards.Contains(card));
                }
                else
                    query = query.Where(card => string.IsNullOrWhiteSpace(card.ColorIdentity));


                resultList = query.GroupBy(x => x.Name)
                .Select(x => x.FirstOrDefault())
                .Distinct()
                .Take(5000)
                .Select(x => MtgCardDto.FromEntity(x, _cache))
                .ToList();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok(resultList);
        }

        private static Expression<Func<MtgCard, bool>> BuildPredicate(MtgCardSearchCriteria criteria)
        {
            var predicate = PredicateBuilder.New<MtgCard>(true);

            if (!string.IsNullOrWhiteSpace(criteria.Name))
            {
                predicate = predicate.And(x => x.Name.ToLower().Contains(criteria.Name.ToLower()));
            }

            if (!string.IsNullOrWhiteSpace(criteria.SetType))
            {
                predicate = predicate.And(x => x.MtgCardSets.Any(y => y.MtgSetFkNavigation.Type == criteria.SetType && y.MtgSetFkNavigation.Code == x.Set));
            }

            if (criteria.SetFromDate != null)
            {
                predicate = predicate.And(x => x.MtgCardSets.Any(y => y.MtgSetFkNavigation.ReleaseDate >= criteria.SetFromDate && y.MtgSetFkNavigation.Code == x.Set));
            }

            if (criteria.SetToDate != null)
            {
                predicate = predicate.And(x => x.MtgCardSets.Any(y => y.MtgSetFkNavigation.ReleaseDate <= criteria.SetToDate && y.MtgSetFkNavigation.Code == x.Set));
            }

            if (criteria.Legality != null)
            {
                predicate = predicate.And(x => x.MtgCardLegalities.Any(y => y.Format == criteria.Legality && (y.Legality == "Legal" || y.Legality == "Restricted")));
            }

            if (!string.IsNullOrWhiteSpace(criteria.Text))
            {
                var textQueries = Regex.Matches(criteria.Text, @"[\""].+?[\""]|[^ ]+")
                                       .Cast<Match>()
                                       .Select(m => m.Value.Replace("\"", "").ToLower())
                                       .ToArray();

                foreach (var query in textQueries)
                {
                    predicate = predicate.And(x => x.Text != null && x.Text.ToLower().Contains(query));
                }
            }

            if (!string.IsNullOrWhiteSpace(criteria.IgnoreText))
            {
                var textQueries = Regex.Matches(criteria.IgnoreText, @"[\""].+?[\""]|[^ ]+")
                                       .Cast<Match>()
                                       .Select(m => m.Value.Replace("\"", "").ToLower())
                                       .ToArray();

                foreach (var query in textQueries)
                {
                    predicate = predicate.And(x => string.IsNullOrWhiteSpace(x.Text) || (!string.IsNullOrWhiteSpace(x.Text) && !x.Text.ToLower().Contains(query)));
                }
            }

            if (!string.IsNullOrWhiteSpace(criteria.CardType))
            {
                var textQueries = Regex.Matches(criteria.CardType, @"[\""].+?[\""]|[^ ]+")
                                       .Cast<Match>()
                                       .Select(m => m.Value.Replace("\"", "").ToLower())
                                       .ToArray();

                foreach (var query in textQueries)
                {
                    predicate = predicate.And(x => x.Type != null && x.Type.ToLower().Contains(query));
                }
            }

            if (!string.IsNullOrWhiteSpace(criteria.CardSubType))
            {
                var textQueries = Regex.Matches(criteria.CardSubType, @"[\""].+?[\""]|[^ ]+")
                                       .Cast<Match>()
                                       .Select(m => m.Value.Replace("\"", "").ToLower())
                                       .ToArray();

                foreach (var query in textQueries)
                {
                    predicate = predicate.And(x => x.SubTypes != null && x.SubTypes.ToLower().Contains(query));
                }
            }

            if (!string.IsNullOrWhiteSpace(criteria.Color))
            {
                var textQueries = criteria.Color.Split(" ");

                foreach (var query in textQueries)
                {
                    predicate = predicate.And(x => x.ColorIdentity != null && x.ColorIdentity.ToLower().Contains(GetColorCode(query)));
                }
            }

            if (!string.IsNullOrWhiteSpace(criteria.IgnoreColor))
            {
                var textQueries = criteria.IgnoreColor.Split(" ");

                foreach (var query in textQueries)
                {
                    predicate = predicate.And(x => string.IsNullOrWhiteSpace(x.ColorIdentity) || (x.ColorIdentity != null && !x.ColorIdentity.ToLower().Contains(GetColorCode(query))));
                }
            }

            return predicate;
        }

        private static string GetColorCode(string value)
        {
            switch (value.ToLower())
            {
                case "r":
                case "red":
                case "{r}":
                    return "r";
                case "g":
                case "green":
                case "{g}":
                    return "g";
                case "b":
                case "black":
                case "{b}":
                    return "b";
                case "w":
                case "white":
                case "{w}":
                    return "w";
                case "u":
                case "blue":
                case "{u}":
                    return "u";
            }
            return "";
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
                    query = query.Where(card => card.Name.ToLower().Contains(criteria.Query.ToLower()));
                }

                var ignoredNames = criteria.IgnoredCardList?.Select(card => card.Name.ToLower()).ToList();
                if (ignoredNames != null && ignoredNames.Any())
                {
                    query = query.Where(card => !ignoredNames.Contains(card.Name.ToLower()));
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
                        .Where(pc => pc.ColorIdentitySet.All(cardColor => cardColor == string.Empty || legalIdentitiesSet.Contains(cardColor)))
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
                    .Select(x => MtgCardDto.FromEntity(x, _cache))
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
        public string? Text { get; set; }
        public string? CardType { get; set; }
        public string? CardSubType { get; set; }
        public string? IgnoreText { get; set; }
        public string? Color { get; set; }
        public string? IgnoreColor { get; set; }
        public string? SetCode { get; set; }
        public string? SetType { get; set; }
        public string[]? ColorIdentity { get; set; }

        public DateTime? SetFromDate { get; set; }
        public DateTime? SetToDate { get; set; }
        public string? Legality { get; set; }
        public HomebrewDto? Homebrew { get; set; }
        public List<MtgCardDto>? IgnoredCardList { get; set; }
    }

}
