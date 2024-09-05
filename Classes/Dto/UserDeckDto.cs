using Persistence.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BObj.Dto
{
    public class UserDeckDto
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public MtgCardDto? Commander1 { get; set; }
        public MtgCardDto? Commander2 { get; set; }
        public MtgCardDto? Companion { get; set; }
        public HomebrewDto? Homebrew { get; set; }
        public MtgCardDto[]? DeckList { get; set; }

        public static UserDeckDto FromEntity(UserDeck entity)
        {
            return new UserDeckDto
            {
                Id = entity.UserDeckPk,
                Name = entity.DeckName
            };
        }
    }
}
