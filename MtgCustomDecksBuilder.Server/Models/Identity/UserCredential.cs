using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Drawing.Printing;

namespace MtgCustomDecksBuilder.Server.Models.Identity
{
    public class UserCredential
    {
        public string? AuthData { get; set; }
        public string? TokenExpiration { get; set; }

        public string? Username { get; set; }

        public string? Password { get; set; }


        public int? UserPK { get; set; }

    }
}
