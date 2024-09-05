using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BObj.Dto
{
    public class ComboDto
    {
        public string? IncludeId { get; set; }
        public List<MtgCardDto>? Cards { get; set; }
    }
}
