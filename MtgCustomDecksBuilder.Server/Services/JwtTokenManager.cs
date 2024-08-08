using Microsoft.Extensions.Caching.Distributed;
using Microsoft.IdentityModel.Tokens;
using MtgCustomDecksBuilder.Server.Models.Identity;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;

namespace MtgCustomDecksBuilder.Server.Services
{
    public interface IJwtTokenManager
    {
        public string Authenticate(UserCredential user);

        Task<bool> IsCurrentActiveToken();
        Task DeactivateCurrentAsync();
        Task<bool> IsActiveAsync(string token);
        Task DeactivateAsync(string token);
    }

    public class JwtTokenManager : IJwtTokenManager
    {
        private readonly IConfiguration _configuration;
        private readonly IDistributedCache _cache;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public JwtTokenManager(IConfiguration configuration, IDistributedCache cache,
            IHttpContextAccessor httpContextAccessor)
        {
            _configuration = configuration;
            _cache = cache;
            _httpContextAccessor = httpContextAccessor;
        }

        public string Authenticate(UserCredential user)
        {
            var key = _configuration.GetValue<string>("Jwt:Key");
            var keyBytes = Encoding.UTF8.GetBytes(key);
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                SigningCredentials = new SigningCredentials(
                                      new SymmetricSecurityKey(keyBytes),
                                      SecurityAlgorithms.HmacSha256Signature),
                Issuer = _configuration["Jwt:Issuer"],
                Audience = _configuration["Jwt:Issuer"],
                Expires = DateTime.UtcNow.AddDays(7),
                Subject = new ClaimsIdentity(new Claim[]
                 {
                    new Claim(ClaimTypes.NameIdentifier, user.Username),
                    new Claim("UserPK", user.UserPK.ToString())
                })
            };
            tokenDescriptor.Subject.AddClaim(new Claim("TokenExpirationDate", tokenDescriptor.Expires.ToString()));

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public async Task<bool> IsCurrentActiveToken()
            => await IsActiveAsync(GetCurrentAsync());

        public async Task DeactivateCurrentAsync()
            => await DeactivateAsync(GetCurrentAsync());

        public async Task<bool> IsActiveAsync(string token)
            => await _cache.GetStringAsync(GetKey(token)) == null;

        public async Task DeactivateAsync(string token) {
            var tokenHandler = new JwtSecurityTokenHandler();
            var jwtToken = tokenHandler.ReadJwtToken(token);

            await _cache.SetStringAsync(GetKey(token),
                " ", new DistributedCacheEntryOptions
                {
                    AbsoluteExpiration = jwtToken.ValidTo

                    //,AbsoluteExpirationRelativeToNow =
                    //    TimeSpan.FromMinutes(_jwtOptions.Value.ExpiryMinutes)
                });
        }

        private string GetCurrentAsync()
        {
            string authorizationHeader = _httpContextAccessor.HttpContext.Request.Cookies["ash_auth_cookie"];

            return authorizationHeader;
        }

        private static string GetKey(string token)
            => $"tokens:{token}:deactivated";
    }

    public class TokenManagerMiddleware : IMiddleware
    {
        private readonly IJwtTokenManager _tokenManager;

        public TokenManagerMiddleware(IJwtTokenManager tokenManager)
        {
            _tokenManager = tokenManager;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            if (await _tokenManager.IsCurrentActiveToken())
            {
                await next(context);

                return;
            }
            context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
        }
    }
}
