using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MtgCustomDecksBuilder.Server.Models.Identity;
using MtgCustomDecksBuilder.Server.Services;
using Persistence.Schema;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace MtgCustomDecksBuilder.Server.Controllers.Identity
{
    [Route("[controller]/[action]")]
    public class AuthorizationController : Controller
    {
        private IJwtTokenManager _jwtService { get; set; }
        private MtgCustomDecksBuilderContext _masterContext { get; set; }
        private IConfiguration _configuration { get; set; }

        public AuthorizationController(IJwtTokenManager jwtService, MtgCustomDecksBuilderContext masterContext, IConfiguration configuration)
        {
            _jwtService = jwtService;
            _masterContext = masterContext;
            _configuration = configuration;
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Authenticate([FromBody] UserCredential model)
        {
            if (model == null)
                return BadRequest();
            
            User user = _masterContext.Users
                    .FirstOrDefault(x => x.Username == model.Username);

            if (user == null || !VerifyPassword(model.Password, user.Password))
                return Unauthorized();

            if (user != null)
            {
                model = new UserCredential()
                {
                    Username = user.Username,
                    UserPK = user.UserPk
                };

                var token = _jwtService.Authenticate(model);

                CookieOptions options = new CookieOptions
                {
                    Expires = DateTimeOffset.UtcNow.AddDays(7),
                    HttpOnly = true, // Prevent client-side JavaScript access
                    IsEssential = true,
                    Domain = Request.Host.Host,
                    SameSite = SameSiteMode.Strict // Protect against CSRF attacks
                };

                options.Secure = true;
#if DEBUG
                options.Secure = false;
#endif

                HttpContext.Response.Cookies.Append("mdf_auth_cookie", token, options);

                model.TokenExpiration = DateTime.UtcNow.AddDays(7).ToString();
                model.AuthData = token;
                return Ok(model);
            }
            else
            {
                ////LOCKOUT USERS
            }

            return Unauthorized();
        }

        private bool VerifyPassword(string inputPassword, string storedHash)
        {
            var salt = _configuration["PasswordHashing:Salt"];
            var inputHash = ComputeSha256Hash(inputPassword, salt);
            return inputHash == storedHash;
        }

        public static string ComputeSha256Hash(string input, string salt)
        {
            using var sha256 = SHA256.Create();
            var bytes = Encoding.UTF8.GetBytes(input + salt);
            var hashBytes = sha256.ComputeHash(bytes);
            return BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            // Sign out the user
            await _jwtService.DeactivateCurrentAsync();

            // Clear the cookies
            Response.Cookies.Delete("ash_auth_cookie");

            return RedirectToAction("login");
        }
    }
}
