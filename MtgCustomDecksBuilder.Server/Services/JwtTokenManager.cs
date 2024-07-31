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
                    new Claim("SFAdminID", user.SFAdminID.ToString()),
                    new Claim("SFAdministratorStorefrontID", user.SFAdministratorStorefrontID.ToString()),
                    new Claim("SFLegalName", user.SFLegalName),
                    new Claim("SFPrimaryAccount", user.SFPrimaryAccount.ToString()),
                    new Claim("SFUserName", user.SFUserName)



                    //new Claim("StorefrontID", user.StorefrontId.ToString()),
                    //new Claim("WarehouseID", user.Admin_WarehouseID.ToString()),
                    //new Claim("Admin_ProviderID", user.Admin_ProviderID.ToString()),
                    //new Claim("Admin_WarehouseName", user.Admin_WarehouseName),
                    //new Claim("Admin_ProviderName", user.Admin_ProviderName),
                    //new Claim("AdminID", user.AdminID.ToString()),
                    //new Claim("Admin_Auth_AdminID", user.Admin_Auth_AdminID.ToString()),
                    //new Claim("Admin_Auth_UserName", user.Admin_Auth_UserName),
                    //new Claim("Admin_Auth_Password", user.Admin_Auth_Password),
                    //new Claim("Admin_Auth_EmailAddress", user.Admin_Auth_EmailAddress)
                })
            };
            tokenDescriptor.Subject.AddClaim(new Claim("TokenExpirationDate", tokenDescriptor.Expires.ToString()));

            ////Add token claims based on credentials
            if (user.PERM_ACCOUNT_ENABLED) tokenDescriptor.Subject.AddClaim(new Claim("PERM_ACCOUNT_ENABLED", user.PERM_ACCOUNT_ENABLED.ToString()));
            if (user.PERM_USER_MANAGEMENT) tokenDescriptor.Subject.AddClaim(new Claim("PERM_USER_MANAGEMENT", user.PERM_USER_MANAGEMENT.ToString()));
            if (user.PERM_VIEW_ORDERS) tokenDescriptor.Subject.AddClaim(new Claim("PERM_VIEW_ORDERS", user.PERM_VIEW_ORDERS.ToString()));
            if (user.PERM_EDITORDER_BILLING_SHIPPING) tokenDescriptor.Subject.AddClaim(new Claim("PERM_EDITORDER_BILLING_SHIPPING", user.PERM_EDITORDER_BILLING_SHIPPING.ToString()));
            if (user.PERM_EDITORDER_ADDMODREMOVE_ITEMS) tokenDescriptor.Subject.AddClaim(new Claim("PERM_EDITORDER_ADDMODREMOVE_ITEMS", user.PERM_EDITORDER_ADDMODREMOVE_ITEMS.ToString()));
            if (user.PERM_CAPTUREVOIDUPDATE_PAYMENT) tokenDescriptor.Subject.AddClaim(new Claim("PERM_CAPTUREVOIDUPDATE_PAYMENT", user.PERM_CAPTUREVOIDUPDATE_PAYMENT.ToString()));
            if (user.PERM_APPROVEVOID_ORDERS) tokenDescriptor.Subject.AddClaim(new Claim("PERM_APPROVEVOID_ORDERS", user.PERM_APPROVEVOID_ORDERS.ToString()));
            if (user.PERM_ADD_TO_BLACKLIST) tokenDescriptor.Subject.AddClaim(new Claim("PERM_ADD_TO_BLACKLIST", user.PERM_ADD_TO_BLACKLIST.ToString()));
            if (user.PERM_VIEW_PRODUCTINFO) tokenDescriptor.Subject.AddClaim(new Claim("PERM_VIEW_PRODUCTINFO", user.PERM_VIEW_PRODUCTINFO.ToString()));
            if (user.PERM_EDIT_PRODUCTINFO_INCLUDINGPRICE) tokenDescriptor.Subject.AddClaim(new Claim("PERM_EDIT_PRODUCTINFO_INCLUDINGPRICE", user.PERM_EDIT_PRODUCTINFO_INCLUDINGPRICE.ToString()));
            if (user.PERM_VIEWEDIT_KEYWORDMETATAGS) tokenDescriptor.Subject.AddClaim(new Claim("PERM_VIEWEDIT_KEYWORDMETATAGS", user.PERM_VIEWEDIT_KEYWORDMETATAGS.ToString()));
            if (user.PERM_EDIT_SHIP_RATES) tokenDescriptor.Subject.AddClaim(new Claim("PERM_EDIT_SHIP_RATES", user.PERM_EDIT_SHIP_RATES.ToString()));
            if (user.PERM_VIEW_FRAUD_BLACKLIST) tokenDescriptor.Subject.AddClaim(new Claim("PERM_VIEW_FRAUD_BLACKLIST", user.PERM_VIEW_FRAUD_BLACKLIST.ToString()));
            if (user.PERM_VIEW_BUNDLES_MANAGEMENT) tokenDescriptor.Subject.AddClaim(new Claim("PERM_VIEW_BUNDLES_MANAGEMENT", user.PERM_VIEW_BUNDLES_MANAGEMENT.ToString()));
            if (user.PERM_CREATE_EDIT_BUNDLES) tokenDescriptor.Subject.AddClaim(new Claim("PERM_CREATE_EDIT_BUNDLES", user.PERM_CREATE_EDIT_BUNDLES.ToString()));
            if (user.PERM_VIEW_EMAIL_MARKETING_CAMPAIGNS) tokenDescriptor.Subject.AddClaim(new Claim("PERM_VIEW_EMAIL_MARKETING_CAMPAIGNS", user.PERM_VIEW_EMAIL_MARKETING_CAMPAIGNS.ToString()));
            if (user.PERM_CREATE_EDIT_EMAIL_MARKETING_CAMPAIGNS) tokenDescriptor.Subject.AddClaim(new Claim("PERM_CREATE_EDIT_EMAIL_MARKETING_CAMPAIGNS", user.PERM_CREATE_EDIT_EMAIL_MARKETING_CAMPAIGNS.ToString()));
            if (user.PERM_VIEW_COUPON_MANAGEMENT) tokenDescriptor.Subject.AddClaim(new Claim("PERM_VIEW_COUPON_MANAGEMENT", user.PERM_VIEW_COUPON_MANAGEMENT.ToString()));
            if (user.PERM_CREATE_EDIT_COUPONS) tokenDescriptor.Subject.AddClaim(new Claim("PERM_CREATE_EDIT_COUPONS", user.PERM_CREATE_EDIT_COUPONS.ToString()));
            if (user.PERM_VIEW_METATAGS_INFO) tokenDescriptor.Subject.AddClaim(new Claim("PERM_VIEW_METATAGS_INFO", user.PERM_VIEW_METATAGS_INFO.ToString()));
            if (user.PERM_VIEW_FRIENDLYURL_MANAGEMENT) tokenDescriptor.Subject.AddClaim(new Claim("PERM_VIEW_FRIENDLYURL_MANAGEMENT", user.PERM_VIEW_FRIENDLYURL_MANAGEMENT.ToString()));
            if (user.PERM_EDIT_FRIENDLYURL_MANAGEMENT) tokenDescriptor.Subject.AddClaim(new Claim("PERM_EDIT_FRIENDLYURL_MANAGEMENT", user.PERM_EDIT_FRIENDLYURL_MANAGEMENT.ToString()));
            if (user.PERM_VIEW_SHIP_RATES) tokenDescriptor.Subject.AddClaim(new Claim("PERM_VIEW_SHIP_RATES", user.PERM_VIEW_SHIP_RATES.ToString()));
            if (user.PERM_CREATE_ORDER) tokenDescriptor.Subject.AddClaim(new Claim("PERM_CREATE_ORDER", user.PERM_CREATE_ORDER.ToString()));
            if (user.PERM_VIEW_DROPSHIP_BILLING_INFO) tokenDescriptor.Subject.AddClaim(new Claim("PERM_VIEW_DROPSHIP_BILLING_INFO", user.PERM_VIEW_DROPSHIP_BILLING_INFO.ToString()));
            if (user.PERM_WEB_SERVICE) tokenDescriptor.Subject.AddClaim(new Claim("PERM_WEB_SERVICE", user.PERM_WEB_SERVICE.ToString()));


            //if (user.Admin_Auth_AccountEnabled) tokenDescriptor.Subject.AddClaim(new Claim("Admin_Auth_AccountEnabled", user.Admin_Auth_AccountEnabled ? "1" : "0"));
            //if (user.Admin_Auth_SysAdmin) tokenDescriptor.Subject.AddClaim(new Claim("Admin_Auth_SysAdmin", user.Admin_Auth_SysAdmin ? "1" : "0"));
            //if (user.Admin_Auth_PickPacking) tokenDescriptor.Subject.AddClaim(new Claim("Admin_Auth_PickPacking", user.Admin_Auth_PickPacking ? "1" : "0"));
            //if (user.Admin_Auth_CreateEditPO) tokenDescriptor.Subject.AddClaim(new Claim("Admin_Auth_CreateEditPO", user.Admin_Auth_CreateEditPO ? "1" : "0"));
            //if (user.Admin_Auth_ViewPO) tokenDescriptor.Subject.AddClaim(new Claim("Admin_Auth_ViewPO", user.Admin_Auth_ViewPO ? "1" : "0"));
            //if (user.Admin_Auth_ReceiveInvForPO) tokenDescriptor.Subject.AddClaim(new Claim("Admin_Auth_ReceiveInvForPO", user.Admin_Auth_ReceiveInvForPO ? "1" : "0"));
            //if (user.Admin_Auth_AdjustInventory) tokenDescriptor.Subject.AddClaim(new Claim("Admin_Auth_AdjustInventory", user.Admin_Auth_AdjustInventory ? "1" : "0"));
            //if (user.Admin_Auth_AddEditProdsExceptPrice) tokenDescriptor.Subject.AddClaim(new Claim("Admin_Auth_AddEditProdsExceptPrice", user.Admin_Auth_AddEditProdsExceptPrice ? "1" : "0"));
            //if (user.Admin_Auth_AddEditProdsIncludingPrice) tokenDescriptor.Subject.AddClaim(new Claim("Admin_Auth_AddEditProdsIncludingPrice", user.Admin_Auth_AddEditProdsIncludingPrice ? "1" : "0"));
            //if (user.Admin_Auth_ViewMarketingInfo) tokenDescriptor.Subject.AddClaim(new Claim("Admin_Auth_ViewMarketingInfo", user.Admin_Auth_ViewMarketingInfo ? "1" : "0"));
            //if (user.Admin_Auth_StorefrontManagement) tokenDescriptor.Subject.AddClaim(new Claim("Admin_Auth_StorefrontManagement", user.Admin_Auth_StorefrontManagement ? "1" : "0"));
            //if (user.Admin_Auth_CreateEditWholesaleOrders) tokenDescriptor.Subject.AddClaim(new Claim("Admin_Auth_CreateEditWholesaleOrders", user.Admin_Auth_CreateEditWholesaleOrders ? "1" : "0"));
            //if (user.Admin_Auth_EditCriticalData) tokenDescriptor.Subject.AddClaim(new Claim("Admin_Auth_EditCriticalData", user.Admin_Auth_EditCriticalData ? "1" : "0"));
            //if (user.Admin_Auth_EditVendors) tokenDescriptor.Subject.AddClaim(new Claim("Admin_Auth_EditVendors", user.Admin_Auth_EditVendors ? "1" : "0"));
            //if (user.Admin_Auth_CreateEditRO) tokenDescriptor.Subject.AddClaim(new Claim("Admin_Auth_CreateEditRO", user.Admin_Auth_CreateEditRO ? "1" : "0"));
            //if (user.Admin_Auth_CreateBoxSugg) tokenDescriptor.Subject.AddClaim(new Claim("Admin_Auth_CreateBoxSugg", user.Admin_Auth_CreateBoxSugg ? "1" : "0"));
            //if (user.Admin_Auth_EditTimeSheets) tokenDescriptor.Subject.AddClaim(new Claim("Admin_Auth_EditTimeSheets", user.Admin_Auth_EditTimeSheets ? "1" : "0"));
            //if (user.Admin_Auth_CustomerReturns) tokenDescriptor.Subject.AddClaim(new Claim("Admin_Auth_CustomerReturns", user.Admin_Auth_CustomerReturns ? "1" : "0"));
            //if (user.Admin_Auth_ViewDropshipBillingInfo) tokenDescriptor.Subject.AddClaim(new Claim("Admin_Auth_ViewDropshipBillingInfo", user.Admin_Auth_ViewDropshipBillingInfo ? "1" : "0"));
            //if (user.Admin_Auth_CreateEditDropshipBillingInfo) tokenDescriptor.Subject.AddClaim(new Claim("Admin_Auth_CreateEditDropshipBillingInfo", user.Admin_Auth_CreateEditDropshipBillingInfo ? "1" : "0"));
            //if (user.Admin_Auth_CreateOrderBatches) tokenDescriptor.Subject.AddClaim(new Claim("Admin_Auth_CreateOrderBatches", user.Admin_Auth_CreateOrderBatches ? "1" : "0"));
            //if (user.Admin_Auth_EditWholesaleOrdersPayments) tokenDescriptor.Subject.AddClaim(new Claim("Admin_Auth_EditWholesaleOrdersPayments", user.Admin_Auth_EditWholesaleOrdersPayments ? "1" : "0"));
            //if (user.Admin_Auth_Supervisor) tokenDescriptor.Subject.AddClaim(new Claim("Admin_Auth_Supervisor", user.Admin_Auth_Supervisor ? "1" : "0"));
            //if (user.Admin_Auth_SalesSupervisor) tokenDescriptor.Subject.AddClaim(new Claim("Admin_Auth_SalesSupervisor", user.Admin_Auth_SalesSupervisor ? "1" : "0"));
            //if (user.Admin_Auth_CreateEditWholesaleOrdersWithSensitiveInfo) tokenDescriptor.Subject.AddClaim(new Claim("Admin_Auth_CreateEditWholesaleOrdersWithSensitiveInfo", user.Admin_Auth_CreateEditWholesaleOrdersWithSensitiveInfo ? "1" : "0"));
            //if (user.Admin_Auth_SalesRepBasic) tokenDescriptor.Subject.AddClaim(new Claim("Admin_Auth_SalesRepBasic", user.Admin_Auth_SalesRepBasic ? "1" : "0"));
            //if (user.Admin_Auth_CreateEditInterProviderBilling) tokenDescriptor.Subject.AddClaim(new Claim("Admin_Auth_CreateEditInterProviderBilling", user.Admin_Auth_CreateEditInterProviderBilling ? "1" : "0"));

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
