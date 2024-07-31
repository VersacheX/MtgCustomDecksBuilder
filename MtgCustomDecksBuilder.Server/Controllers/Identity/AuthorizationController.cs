using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MtgCustomDecksBuilder.Server.Models.Identity;
using MtgCustomDecksBuilder.Server.Schema.WNSMaster;
using MtgCustomDecksBuilder.Server.Services;
using System.Data;

namespace MtgCustomDecksBuilder.Server.Controllers.Identity
{
    [Route("[controller]/[action]")]
    public class AuthorizationController : Controller
    {
        //PERMISSION CONSTANTS
        private int PERM_ACCOUNT_ENABLED = 1;
        private int PERM_USER_MANAGEMENT = 2;
        private int PERM_VIEW_ORDERS = 3;
        private int PERM_EDITORDER_BILLING_SHIPPING = 4;
        private int PERM_EDITORDER_ADDMODREMOVE_ITEMS = 5;
        private int PERM_CAPTUREVOIDUPDATE_PAYMENT = 6;
        private int PERM_APPROVEVOID_ORDERS = 7;
        private int PERM_ADD_TO_BLACKLIST = 8;
        private int PERM_VIEW_PRODUCTINFO = 9;
        private int PERM_EDIT_PRODUCTINFO_INCLUDINGPRICE = 10;
        private int PERM_VIEWEDIT_KEYWORDMETATAGS = 11;
        private int PERM_EDIT_SHIP_RATES = 12;
        private int PERM_VIEW_FRAUD_BLACKLIST = 13;
        private int PERM_VIEW_BUNDLES_MANAGEMENT = 14;
        private int PERM_CREATE_EDIT_BUNDLES = 15;
        private int PERM_VIEW_EMAIL_MARKETING_CAMPAIGNS = 16;
        private int PERM_CREATE_EDIT_EMAIL_MARKETING_CAMPAIGNS = 17;
        private int PERM_VIEW_COUPON_MANAGEMENT = 18;
        private int PERM_CREATE_EDIT_COUPONS = 19;
        private int PERM_VIEW_METATAGS_INFO = 20;
        private int PERM_VIEW_FRIENDLYURL_MANAGEMENT = 21;
        private int PERM_EDIT_FRIENDLYURL_MANAGEMENT = 22;
        private int PERM_VIEW_SHIP_RATES = 23;
        private int PERM_CREATE_ORDER = 24;
        private int PERM_VIEW_DROPSHIP_BILLING_INFO = 25;
        private int PERM_WEB_SERVICE = 26;

        private IJwtTokenManager _jwtService { get; set; }
        private WNSMasterContext _masterContext { get; set; }

        public AuthorizationController(IJwtTokenManager jwtService, WNSMasterContext masterContext)
        {
            _jwtService = jwtService;
            _masterContext = masterContext;
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Authenticate([FromBody] UserCredential model)
        {
            if (model == null)
                return BadRequest();

            DataTable resultSet = null;

            using (var command = _masterContext.Database.GetDbConnection().CreateCommand())
            {
                bool wasOpen = command.Connection?.State == ConnectionState.Open;
                if (!wasOpen) command.Connection?.Open();

                try
                {
                    command.CommandText = "usp_adminsf_login_v2";
                    command.CommandType = CommandType.StoredProcedure;

                    var param = command.CreateParameter();
                    param.ParameterName = "@StorefrontID";
                    param.DbType = DbType.Int16;
                    param.Value = model.StorefrontId;
                    command.Parameters.Add(param);

                    param = command.CreateParameter();
                    param.ParameterName = "@Username";
                    param.DbType = DbType.String;
                    param.Value = model.Username;
                    command.Parameters.Add(param);

                    param = command.CreateParameter();
                    param.ParameterName = "@Password";
                    param.DbType = DbType.String;
                    param.Value = model.Password;
                    command.Parameters.Add(param);

                    //Not used
                    var usernameExistsParam = command.CreateParameter();
                    usernameExistsParam.ParameterName = "@UsernameExists";
                    usernameExistsParam.DbType = DbType.Boolean;
                    //usernameExistsParam.Value = userCredential.UserName;
                    usernameExistsParam.Direction = ParameterDirection.Output;
                    command.Parameters.Add(usernameExistsParam);

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        resultSet = new DataTable();
                        resultSet.Load(reader);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (!wasOpen) command.Connection?.Close();
                }
            }

            if (resultSet != null && resultSet.Rows.Count > 0)
            {
                DataRow row = resultSet.Rows[0];

                model.SFAdminID = Convert.ToInt32(row["AdminID"]);
                model.SFAdministratorStorefrontID = Convert.ToInt32(row["StorefrontID"]);
                model.SFLegalName = row["LegalName"].ToString();
                model.SFPrimaryAccount = Convert.ToBoolean(row["PrimaryAccount"]);
                model.SFUserName = row["Username"].ToString();

                this.GetAdminPermissions(model.SFAdminID, ref model);

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

                HttpContext.Response.Cookies.Append("ash_auth_cookie", token, options);



                ////TL 3/16/2010 - IMPLEMENTATION AND CONSTANT DEFINIED IN STOREFRONTLIB.LOGGING.CS
                //base.SaveIntranetActivity(Convert.ToInt32(dr["StorefrontID"]), "Login Succeeded", "");

                model.TokenExpiration = DateTime.UtcNow.AddDays(7).ToString();
                model.AuthData = token;
                return Ok(model);
            }
            else
            {
                ////LOCKOUT USERS
                ///
                ////TL 3/16/2010 - IMPLEMENTATION AND CONSTANT DEFINIED IN STOREFRONTLIB.LOGGING.CS
                //base.SaveIntranetActivity(int.Parse(sfID), "Login Failed", "<DETAIL><SFID>" + this.txtStorefrontID.Text.Trim() + "</SFID><USER>" + this.txtUsername.Text.Trim() + "</USER><PASS>" + this.txtPassword.Text.Trim() + "</PASS></DETAIL>");
            }

            return Unauthorized();

            //var response = _jwtService.Authenticate(model);

            //if (response == null)
            //    return BadRequest(new { message = "Username or password is incorrect" });

            //return Ok(response);
        }

        private void GetAdminPermissions(int adminID, ref UserCredential userCredential)
        {
            DataTable dtAdminPerms = new DataTable();

            using (var command = _masterContext.Database.GetDbConnection().CreateCommand())
            {
                bool wasOpen = command.Connection?.State == ConnectionState.Open;
                if (!wasOpen) command.Connection?.Open();

                try
                {
                    command.CommandText = "usp_adminsf_UserMngmtGetUserPermissions";
                    command.CommandType = CommandType.StoredProcedure;

                    var param = command.CreateParameter();
                    param.ParameterName = "@AdminID";
                    param.DbType = DbType.Int16;
                    param.Value = adminID;
                    command.Parameters.Add(param);

                    using (var reader = command.ExecuteReader())
                    {
                        dtAdminPerms.Load(reader);
                    }
                }
                finally
                {
                    if (!wasOpen) command.Connection?.Close();
                }
            }


            if ((dtAdminPerms.Rows.Count > 0))
            {
                for (int j = 0; j < dtAdminPerms.Rows.Count; j++)
                {
                    int permId = -1;

                    int.TryParse(dtAdminPerms.Rows[j][0].ToString(), out permId);

                    if (permId == this.PERM_ACCOUNT_ENABLED) userCredential.PERM_ACCOUNT_ENABLED = true;
                    if (permId == this.PERM_USER_MANAGEMENT) userCredential.PERM_USER_MANAGEMENT = true;
                    if (permId == this.PERM_VIEW_ORDERS) userCredential.PERM_VIEW_ORDERS = true;
                    if (permId == this.PERM_EDITORDER_BILLING_SHIPPING) userCredential.PERM_EDITORDER_BILLING_SHIPPING = true;
                    if (permId == this.PERM_EDITORDER_ADDMODREMOVE_ITEMS) userCredential.PERM_EDITORDER_ADDMODREMOVE_ITEMS = true;
                    if (permId == this.PERM_CAPTUREVOIDUPDATE_PAYMENT) userCredential.PERM_CAPTUREVOIDUPDATE_PAYMENT = true;
                    if (permId == this.PERM_APPROVEVOID_ORDERS) userCredential.PERM_APPROVEVOID_ORDERS = true;
                    if (permId == this.PERM_ADD_TO_BLACKLIST) userCredential.PERM_ADD_TO_BLACKLIST = true;
                    if (permId == this.PERM_VIEW_PRODUCTINFO) userCredential.PERM_VIEW_PRODUCTINFO = true;
                    if (permId == this.PERM_EDIT_PRODUCTINFO_INCLUDINGPRICE) userCredential.PERM_EDIT_PRODUCTINFO_INCLUDINGPRICE = true;
                    if (permId == this.PERM_VIEWEDIT_KEYWORDMETATAGS) userCredential.PERM_VIEWEDIT_KEYWORDMETATAGS = true;
                    if (permId == this.PERM_EDIT_SHIP_RATES) userCredential.PERM_EDIT_SHIP_RATES = true;
                    if (permId == this.PERM_VIEW_FRAUD_BLACKLIST) userCredential.PERM_VIEW_FRAUD_BLACKLIST = true;
                    if (permId == this.PERM_VIEW_BUNDLES_MANAGEMENT) userCredential.PERM_VIEW_BUNDLES_MANAGEMENT = true;
                    if (permId == this.PERM_CREATE_EDIT_BUNDLES) userCredential.PERM_CREATE_EDIT_BUNDLES = true;
                    if (permId == this.PERM_VIEW_EMAIL_MARKETING_CAMPAIGNS) userCredential.PERM_VIEW_EMAIL_MARKETING_CAMPAIGNS = true;
                    if (permId == this.PERM_CREATE_EDIT_EMAIL_MARKETING_CAMPAIGNS) userCredential.PERM_CREATE_EDIT_EMAIL_MARKETING_CAMPAIGNS = true;
                    if (permId == this.PERM_VIEW_COUPON_MANAGEMENT) userCredential.PERM_VIEW_COUPON_MANAGEMENT = true;
                    if (permId == this.PERM_CREATE_EDIT_COUPONS) userCredential.PERM_CREATE_EDIT_COUPONS = true;
                    if (permId == this.PERM_VIEW_METATAGS_INFO) userCredential.PERM_VIEW_METATAGS_INFO = true;
                    if (permId == this.PERM_VIEW_FRIENDLYURL_MANAGEMENT) userCredential.PERM_VIEW_FRIENDLYURL_MANAGEMENT = true;
                    if (permId == this.PERM_EDIT_FRIENDLYURL_MANAGEMENT) userCredential.PERM_EDIT_FRIENDLYURL_MANAGEMENT = true;
                    if (permId == this.PERM_VIEW_SHIP_RATES) userCredential.PERM_VIEW_SHIP_RATES = true;
                    if (permId == this.PERM_CREATE_ORDER) userCredential.PERM_CREATE_ORDER = true;
                    if (permId == this.PERM_VIEW_DROPSHIP_BILLING_INFO) userCredential.PERM_VIEW_DROPSHIP_BILLING_INFO = true;
                    if (permId == this.PERM_WEB_SERVICE) userCredential.PERM_WEB_SERVICE = true;
                }
            }
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
