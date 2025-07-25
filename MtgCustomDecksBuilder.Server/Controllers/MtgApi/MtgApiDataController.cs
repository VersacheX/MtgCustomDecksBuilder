using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MtgApiManager.Lib.Core;
using MtgApiManager.Lib.Model;
using MtgApiManager.Lib.Service;
using Persistence.Schema;

namespace MtgCustomDecksBuilder.Server.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    [Authorize]
    public class MtgApiDataController : BaseController
    {
        private readonly IMtgServiceProvider _mtgServiceProvider;
        private readonly MtgCustomDecksBuilderContext _masterContext;

        public MtgApiDataController(IMtgServiceProvider mtgServiceProvider, MtgCustomDecksBuilderContext masterContext)
        {
            _mtgServiceProvider = mtgServiceProvider;
            _masterContext = masterContext;
        }

        [HttpPost]
        public async Task<IActionResult> DownloadMtgSets()
        {
            ISetService setService = _mtgServiceProvider.GetSetService();
            List<ISet> resultList = new List<ISet>();
            int currentCount = 0;
            int currentPage = 0;
            int pageSize = 500;
            setService.Where(x => x.PageSize, pageSize);

            do
            {
                currentPage++;
                setService.Where(x => x.Page, currentPage);

                IOperationResult<List<ISet>> setList = null;

                try
                {
                    setList = await setService.AllAsync();
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }

                if (setList?.IsSuccess == true)
                {
                    currentCount = setList.Value.Count();
                    resultList.AddRange(setList.Value);
                }
            } while (currentCount == pageSize);

            //Save Data Here
            foreach(ISet set in resultList)
            {
                DateTime releaseDate = new DateTime();
                DateTime.TryParse(set.ReleaseDate, out releaseDate);

                if(!_masterContext.MtgSets.Any(x=>x.Name == set.Name && x.Code == set.Code))
                    _masterContext.MtgSets.Add(new MtgSet()
                    {
                        Block = set.Block,
                        Code = set.Code,
                        Expansion = set.Expansion,
                        Name = set.Name,
                        OnlineOnly = set.OnlineOnly,
                        ReleaseDate = releaseDate,
                        Type = set.Type
                    });
            }

            if(resultList.Count> 0)
            {
                _masterContext.SaveChanges();
            }
            

            int totalCount = resultList.Count;

            return Ok(totalCount);
        }

        [HttpPost]
        public async Task<IActionResult> DownloadMtgCards()
        {
            ICardService cardService = _mtgServiceProvider.GetCardService();
            List<ICard> resultList = new List<ICard>();
            int currentCount = 0;
            int currentPage = 0;
            int pageSize = 100;
            int totalPages = 0;
            cardService.Where(x => x.PageSize, pageSize);

            do
            {
                currentPage++;
                cardService.Where(x => x.Page, currentPage);

                IOperationResult<List<ICard>> cardList = null;

                try
                {
                    cardList = await cardService.AllAsync();
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }

                if (cardList?.IsSuccess == true)
                {
                    currentCount = cardList.Value.Count();
                    resultList.AddRange(cardList.Value);
                }
                totalPages = cardList.PagingInfo.TotalPages;
            } while (currentPage < totalPages);

            //Save Data Here
            foreach (ICard card in resultList)
            {
                DateTime releaseDate = new DateTime(1955,11,5);
                if(card.ReleaseDate != null)
                    DateTime.TryParse(card.ReleaseDate, out releaseDate);

                MtgCard newMtgCard = new MtgCard()
                {
                    Cmc = Convert.ToDecimal(card.Cmc),
                    ReleaseDate = releaseDate,
                    Artist = card.Artist,
                    Border = card.Border,
                    ColorIdentity = (card.ColorIdentity != null && card.ColorIdentity.Length > 0) ? string.Join(",", card.ColorIdentity): string.Empty,
                    Colors = (card.Colors != null && card.Colors.Length > 0) ? string.Join(",", card.Colors) : string.Empty,
                    IsColorless = card.IsColorless,
                    IsMultiColor = card.IsMultiColor,
                    ManaCost = card.ManaCost,
                    Flavor = card.Flavor,
                    Hand = card.Hand,
                    Id = card.Id,
                    ImageUrl = card.ImageUrl?.OriginalString ?? string.Empty,
                    Layout = card.Layout,
                    Life = card.Life,
                    Loyalty = card.Loyalty,
                    MultiverseId = card.MultiverseId,
                    Name = card.Name,
                    Names = (card.Names != null && card.Names.Length > 0) ? string.Join(",", card.Names) : string.Empty,
                    Number = card.Number,
                    OriginalText = card.OriginalText,
                    OriginalType = card.OriginalType,
                    Power = card.Power,
                    Printings = (card.Printings != null && card.Printings.Length > 0) ? string.Join(",", card.Printings) : string.Empty,
                    Rarity = card.Rarity,
                    Reserved = card.Reserved,
                    Set = card.Set,
                    SetName = card.SetName,
                    Source = card.Source,
                    Starter = card.Starter,
                    SubTypes = (card.SubTypes != null && card.SubTypes.Length > 0) ? string.Join(",", card.SubTypes) : string.Empty,
                    SuperTypes = (card.SuperTypes != null && card.SuperTypes.Length > 0) ? string.Join(",", card.SuperTypes) : string.Empty,
                    Text = card.Text?.Length > 4000 ? card.Text.Substring(0, 4000) : card.Text,
                    Timeshifted = card.Timeshifted,
                    Toughness = card.Toughness,
                    Type = card.Type,
                    Types = (card.Types != null && card.Types.Length > 0) ? string.Join(",", card.Types) : string.Empty,
                    Watermark = card.Watermark
                };
                #region Populate Children
                if (card.ForeignNames != null)
                {
                    foreach(IForeignName foreignName in card.ForeignNames)
                    {
                        MtgCardForeignName mtgCardForeignName = new MtgCardForeignName()
                        {
                            Language = foreignName.Language,
                            Name = foreignName.Name,
                            MultiverseId = foreignName.MultiverseId
                        };

                        newMtgCard.MtgCardForeignNames.Add(mtgCardForeignName);
                    }
                }

                if(card.Legalities != null)
                {
                    foreach (ILegality legality in card.Legalities)
                    {
                        MtgCardLegality mtgCardLegality = new MtgCardLegality()
                        {
                            Format = legality.Format,
                            Legality = legality.LegalityName                           
                        };

                        newMtgCard.MtgCardLegalities.Add(mtgCardLegality);
                    }
                }

                if(card.Rulings != null)
                {
                    foreach(IRuling ruling in card.Rulings)
                    {
                        DateTime date = new DateTime(1955, 11, 5);
                        if(ruling.Date != null)
                            DateTime.TryParse(ruling.Date, out date);

                        MtgCardRuling mtgCardRuling = new MtgCardRuling()
                        {
                            Date = date,
                            Text = ruling.Text
                        };

                        newMtgCard.MtgCardRulings.Add(mtgCardRuling);
                    }
                }

                if(card.Variations != null)
                {
                    foreach(string  variation in card.Variations)
                    {
                        MtgCardVariation mtgCardVariation = new MtgCardVariation()
                        {
                            VariationId = variation
                        };

                        newMtgCard.MtgCardVariations.Add(mtgCardVariation);
                    }
                }
                #endregion

                if(!_masterContext.MtgCards.Any(card=>card.Name == newMtgCard.Name && card.Number == newMtgCard.Number && card.Set == newMtgCard.Set))
                    _masterContext.MtgCards.Add(newMtgCard);
                else
                {
                    //UPDATE
                    MtgCard existCard = _masterContext.MtgCards
                                            .Include(x=>x.MtgCardVariations)
                                            .Include(c => c.MtgCardRulings)  
                                            .Include(c=>c.MtgCardForeignNames)
                                            .Include(c => c.MtgCardLegalities)
                                            .Include(c => c.MtgCardSets)
                                                .ThenInclude(cardSet => cardSet.MtgSetFkNavigation)
                                            .FirstOrDefault(card => card.Name == newMtgCard.Name && card.Number == newMtgCard.Number && card.Set == newMtgCard.Set);

                    newMtgCard.MtgCardPk = existCard.MtgCardPk;
                    //Here we need to check for any updates to the cards legalities and sets in order to update that
                    if (newMtgCard.MtgCardVariations?.Count > 0)
                    {
                        int count = newMtgCard.MtgCardVariations.Count;
                        var variations = newMtgCard.MtgCardVariations.ToList();
                        for (int i = 0; i < count; i++)
                        {
                            MtgCardVariation variation = variations[i];

                            MtgCardVariation existVariation = _masterContext.MtgCardVariations.Where(x=>x.MtgCardFk == variation.MtgCardFk && x.VariationId == variation.VariationId).FirstOrDefault();
                            if(existVariation != null) { newMtgCard.MtgCardVariations.Remove(variation); }
                        }

                    }

                    if (newMtgCard.MtgCardRulings?.Count > 0)
                    {
                        var newRulingKeys = newMtgCard.MtgCardRulings.Select(r => new { newMtgCard.MtgCardPk, r.Text }).ToList();

                        var contextRulingsToRemove = new List<MtgCardRuling>();
                        var existRulings = _masterContext.MtgCardRulings.Where(x => x.MtgCardFk == newMtgCard.MtgCardPk).ToList();
                        foreach (var contextRuling in existRulings)
                        {
                            bool existsInNew = false;
                            foreach (var newRulingKey in newRulingKeys)
                            {
                                if (contextRuling.MtgCardFk == newMtgCard.MtgCardPk && contextRuling.Text == newRulingKey.Text)
                                {
                                    existsInNew = true;
                                    break;
                                }
                            }
                            if (!existsInNew)
                            {
                                contextRulingsToRemove.Add(contextRuling);
                            }
                        }

                        _masterContext.MtgCardRulings.RemoveRange(contextRulingsToRemove);

                        var contextRulings = new List<dynamic>();
                        existRulings = _masterContext.MtgCardRulings.Where(x => x.MtgCardFk == newMtgCard.MtgCardPk).ToList();
                        foreach (var contextRuling in existRulings)
                        {
                            foreach (var newRulingKey in newRulingKeys)
                            {
                                if (contextRuling.MtgCardFk == newMtgCard.MtgCardPk && contextRuling.Text == newRulingKey.Text)
                                {
                                    contextRulings.Add(new { contextRuling.MtgCardFk, contextRuling.Text, contextRuling.MtgCardRulingPk });
                                    break;
                                }
                            }
                        }

                        foreach (var ruling in newMtgCard.MtgCardRulings)
                        {
                            foreach (var contextRuling in contextRulings)
                            {
                                if (ruling.MtgCardFk == newMtgCard.MtgCardPk && ruling.Text == contextRuling.Text)
                                {
                                    ruling.MtgCardRulingPk = contextRuling.MtgCardRulingPk;
                                    break;
                                }
                            }
                        }
                    }

                    if (newMtgCard.MtgCardLegalities?.Count > 0)
                    {
                        var legalityKeys = newMtgCard.MtgCardLegalities.Select(l => new { newMtgCard.MtgCardPk, l.Format }).ToList();

                        foreach (var legality in newMtgCard.MtgCardLegalities)
                        {
                            var existingLegalities = _masterContext.MtgCardLegalities
                                .Where(cl => cl.MtgCardFk == newMtgCard.MtgCardPk && cl.Format == legality.Format)
                                .ToList();

                            foreach (var existingLegality in existingLegalities)
                            {
                                if (existingLegality != null)
                                {
                                    legality.MtgCardLegalityPk = existingLegality.MtgCardLegalityPk;
                                }
                            }
                        }
                    }

                    if (newMtgCard.MtgCardForeignNames?.Count > 0)
                    {
                        var foreignNameKeys = newMtgCard.MtgCardForeignNames.Select(fn => new { newMtgCard.MtgCardPk, fn.Language }).ToList();

                        var existForeignNames = _masterContext.MtgCardForeignNames.Where(x => x.MtgCardFk == newMtgCard.MtgCardPk).ToList();
                        foreach (var contextForeignName in existForeignNames)
                        {
                            bool existsInNew = false;
                            foreach (var foreignNameKey in foreignNameKeys)
                            {
                                if (contextForeignName.MtgCardFk == newMtgCard.MtgCardPk && contextForeignName.Language == foreignNameKey.Language)
                                {
                                    existsInNew = true;
                                    break;
                                }
                            }
                            if (!existsInNew)
                            {
                                _masterContext.MtgCardForeignNames.Remove(contextForeignName);
                            }
                        }

                        foreach (var foreignName in newMtgCard.MtgCardForeignNames)
                        {
                            var existingForeignNames = _masterContext.MtgCardForeignNames
                                .Where(cfn => cfn.MtgCardFk == newMtgCard.MtgCardPk && cfn.Language == foreignName.Language)
                                .ToList();

                            foreach (var existingForeignName in existingForeignNames)
                            {
                                if (existingForeignName != null)
                                {
                                    foreignName.MtgCardForeignNamePk = existingForeignName.MtgCardForeignNamePk;
                                }
                            }
                        }
                    }
                }
            }

            if (resultList.Count > 0)
            {
                try
                {
                    _masterContext.SaveChanges();
                }
                catch (Exception ex)
                {                    
                
                }
            }


            int totalCount = resultList.Count;

            return Ok(totalCount);
        }
    }
}
