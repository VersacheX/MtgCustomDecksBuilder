using Persistence.Schema;

namespace BObj.Dto
{
    public class HomebrewDto
    {
        public int Id { get; set; }
        public string? GameFormatName { get; set; }
        public List<AllowedSetDto>? AllowedSets { get; set; }
        public List<SetTypeDto>? SetTypes { get; set; }

        // Additional properties and methods can be added as needed
        public static HomebrewDto FromEntity (DeckRuleCriterion entity)
        {
            return new HomebrewDto
            {
                Id = entity.DeckRuleCriterionPk,
                GameFormatName = entity.GameFormatFkNavigation.Name,
                AllowedSets = entity.DeckRuleCriteriaAllowedSets.Select(allowedSet => new AllowedSetDto
                {
                    Id = allowedSet.MtgSetFk ?? 0,
                    Type = allowedSet.MtgSetFkNavigation.Type
                }).ToList(),
                SetTypes = entity.DeckRuleCriteriaSetTypes.Select(setType => new SetTypeDto
                {
                    Id = setType.SetTypeFk ?? 0,
                    Name = setType.SetTypeFkNavigation.Name
                }).ToList()
            };
        }

        public bool IsCardLegal(MtgCard card)
        {
            if (AllowedSets != null && SetTypes != null)
            {
                var isLegalInFormat = card.MtgCardLegalities.Any(legality => legality.Format == GameFormatName && legality.Legality == "Legal");

                var hasValidSetType = AllowedSets.Any(allowedSet => card.MtgCardSets.Any(cardSet => cardSet.MtgSetFkNavigation.Type == allowedSet.Type));

                var isInAllowedSet = AllowedSets.Any(allowedSet => card.MtgCardSets.Any(cardSet => cardSet.MtgSetFk == allowedSet.Id));

                return isLegalInFormat && hasValidSetType && isInAllowedSet;
            }

            return true;
        }

        public bool IsCardLegal(MtgCardDto card)
        {
            if (AllowedSets != null && SetTypes != null)
            {
                var isLegalInFormat = card.MtgCardLegalities.Any(legality => legality.Format == GameFormatName && legality.Legality == "Legal");

                var hasValidSetType = AllowedSets.Any(allowedSet => card.MtgCardSets.Any(cardSet => cardSet.SetType == allowedSet.Type));

                var isInAllowedSet = AllowedSets.Any(allowedSet => card.MtgCardSets.Any(cardSet => cardSet.MtgSetFk == allowedSet.Id));

                return isLegalInFormat && hasValidSetType && isInAllowedSet;
            }

            return true;
        }
    }

    public class AllowedSetDto
    {
        public int Id { get; set; }
        public string? Type { get; set; }
    }

    public class SetTypeDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
