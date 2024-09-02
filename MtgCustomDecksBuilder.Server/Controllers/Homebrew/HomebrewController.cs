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
    public class HomebrewController : BaseController
    {
        private readonly MtgCustomDecksBuilderContext _masterContext;

        public HomebrewController(MtgCustomDecksBuilderContext masterContext)
        {
            _masterContext = masterContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllHomebrews()
        {
            List<DeckRuleCriterion> resultSet = new List<DeckRuleCriterion>();

            try
            {
                resultSet = _masterContext.DeckRuleCriteria
                    .Include(x => x.GameFormatFkNavigation)
                    .Include(x => x.MtgFormatFkNavigation)
                    .Include(x => x.DeckRuleCriteriaAllowedSets)
                        .ThenInclude(x=>x.MtgSetFkNavigation)
                    .Include(x => x.DeckRuleCriteriaSetTypes)
                        .ThenInclude(x => x.SetTypeFkNavigation)
                    .ToList();
            }
            catch (Exception ex)
            {

            }

            return Ok(resultSet);
        }

        [HttpPost]
        public async Task<IActionResult> GetHomebrewsByCriteria(HomebrewSearchCriteria criteria)
        {
            List<DeckRuleCriterion> resultSet = new List<DeckRuleCriterion>();

            try
            {
                resultSet = _masterContext.DeckRuleCriteria.Where(x => true)
                    .Include(x => x.GameFormatFkNavigation)
                    .Include(x => x.MtgFormatFkNavigation)
                    .Include(x=>x.DeckRuleCriteriaAllowedSets)
                    .Include(x=>x.DeckRuleCriteriaSetTypes)
                    //.Include(x => x.UserFkNavigation) //only include forward facing data
                    .ToList();
            } catch (Exception ex)
            {

            }

            return Ok(resultSet);
        }


        [HttpPost]
        public async Task<IActionResult> Save(HomebrewSearchCriteria criteria)
        {
            if (string.IsNullOrWhiteSpace(criteria.Name))
                return BadRequest("Expected homebrew name");

            List<MtgSetType> setTypes = new List<MtgSetType>();
            if(!string.IsNullOrWhiteSpace(criteria.SetType))
                setTypes = _masterContext.MtgSetTypes.Where(x => x.Name == criteria.SetType).ToList();

            List<MtgSet> legalSets = new List<MtgSet>();

            try
            {
                legalSets = _masterContext.MtgSets.Where(x =>
                    (!string.IsNullOrWhiteSpace(criteria.SetName) ? x.Name.Contains(criteria.SetName) : true)
                    && (criteria.FromDate != null ? x.ReleaseDate >= criteria.FromDate : true)
                    && (criteria.ToDate != null ? x.ReleaseDate <= criteria.ToDate : true)
                    && (criteria.PaperOnly == true ? x.OnlineOnly == false : true)
                    && (!string.IsNullOrWhiteSpace(criteria.SetType) ? x.Type.Contains(criteria.SetType) : true)
                    && (criteria.SetFromDate != null ? x.ReleaseDate >= criteria.SetFromDate : true)
                    && (criteria.SetToDate != null ? x.ReleaseDate <= criteria.SetToDate : true))
                    .AsEnumerable()
                    .Where(x => setTypes.Count() > 0 ? setTypes.Any(y => y.Name == x.Type) : true)
                    .ToList();


                //legalSets = legalSets.Where(x => setTypes.Any(y => y.Name == x.Type)).ToList();

                MtgFormat? format = null;
                if (!string.IsNullOrWhiteSpace(criteria.Legality))
                    format = _masterContext.MtgFormats.FirstOrDefault(x => x.Name == criteria.Legality);
                GameFormat? gameFormat = null;
                if (!string.IsNullOrWhiteSpace(criteria.Legality))
                    gameFormat = _masterContext.GameFormats.FirstOrDefault(x => x.Name == criteria.Legality);

                DeckRuleCriterion homebrew = new DeckRuleCriterion()
                {
                    Name = criteria.Name,
                    UserFk = Convert.ToInt16(User.Claims.FirstOrDefault(x => x.Type == "UserPK")?.Value.ToString()),
                    MtgFormatFk = format.MtgFormatPk,
                    GameFormatFk = gameFormat.GameFormatPk,
                    LibraryCardCount = criteria.LibraryCardCount ,
                    SideboardCount = criteria.SideboardCount,
                    CommanderAllowed = criteria.CommanderAllowed,
                    CompanionAllowed = criteria.CompanionAllowed
                };

                foreach (MtgSet set in legalSets)
                {
                    DeckRuleCriteriaAllowedSet allowedSet = new DeckRuleCriteriaAllowedSet()
                    {
                        MtgSetFk = set.MtgSetPk
                    };
                    homebrew.DeckRuleCriteriaAllowedSets.Add(allowedSet);
                }

                foreach (MtgSetType setType in setTypes)
                {
                    DeckRuleCriteriaSetType deckRuleCriteriaSetType = new DeckRuleCriteriaSetType()
                    {
                        SetTypeFk = setType.MtgSetTypePk
                    };
                    homebrew.DeckRuleCriteriaSetTypes.Add(deckRuleCriteriaSetType);
                }

                _masterContext.DeckRuleCriteria.Add(homebrew);
                _masterContext.SaveChanges();
            }
            catch (Exception ex)
            {

            }

            return Ok();
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
        public string? SetName { get; set; }
        public string? SetCode { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string? SetType { get; set; }
        public bool? PaperOnly { get; set; }

        public DateTime? SetFromDate { get; set; }
        public DateTime? SetToDate { get; set; }
        public string? Legality { get; set; }
        public int LibraryCardCount { get; set; }
        public int SideboardCount { get; set; }
        public bool CommanderAllowed { get; set; }
        public bool  CompanionAllowed { get; set; }
    }

}
