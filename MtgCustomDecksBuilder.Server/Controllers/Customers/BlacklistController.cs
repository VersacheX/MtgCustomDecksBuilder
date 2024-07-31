using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using MtgCustomDecksBuilder.Server.Schema.WNSMaster;
using MtgCustomDecksBuilder.Server.Tools;
using System.Data;
using System.Data.Common;
using System.Net.Http.Headers;

namespace MtgCustomDecksBuilder.Server.Controllers.Customers
{
    [ApiController]
    [Route("[controller]/[action]")]
    [Authorize]
    public class BlacklistController : ProviderBaseController
    {
        private IConfiguration _config;
        private readonly WNSMasterContext _masterContext;

        public BlacklistController(IConfiguration config, WNSMasterContext masterContext)
        {
            _config = config;
            _masterContext = masterContext;
        }

        public IActionResult GetBlackListOrders()
        {
            if (User.Claims.Count(x => x.Type == "PERM_ACCOUNT_ENABLED") == 0 || User.Claims.Count(x => x.Type == "PERM_VIEW_FRAUD_BLACKLIST") == 0)
                return BadRequest();


            DataTable dt = GetAllBlackListOrders();
            return Ok(DataConversion.SerializeJsonListFromDataTable(dt));
        }

        private DataTable GetAllBlackListOrders()
        {
            DataTable dataTable = new DataTable();

            try
            {
                string s = "blacklistds" + User.Claims.Where(x => x.Type == "SFAdministratorStorefrontID").FirstOrDefault().Value;

                using (var command = _masterContext.Database.GetDbConnection().CreateCommand())
                {
                    bool wasOpen = command.Connection?.State == ConnectionState.Open;
                    if (!wasOpen) command.Connection?.Open();

                    try
                    {
                        command.CommandText = "usp_adminsf_BlacklistGetAllOrders";
                        command.CommandType = CommandType.StoredProcedure;

                        using (var reader = command.ExecuteReader())
                        {
                            dataTable.Load(reader);
                        }
                    }
                    finally
                    {
                        if (!wasOpen) command.Connection?.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return dataTable;
        }

        [HttpGet("{id}")]
        public IActionResult GetOrderDetail(int id)
        {
            if (User.Claims.Count(x => x.Type == "PERM_ACCOUNT_ENABLED") == 0 || User.Claims.Count(x => x.Type == "PERM_VIEW_ORDERS") == 0)
                return BadRequest();


            DataTable dt = LoadOrderDetail(id);
            return Ok(DataConversion.SerializeJsonObjectFromDataTable(dt));
        }

        private DataTable LoadOrderDetail(int orderId)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (var command = _masterContext.Database.GetDbConnection().CreateCommand())
                {
                    command.CommandText =
                        @$"
                            OPEN SYMMETRIC KEY [key_Encrypt_Data] 
                            DECRYPTION BY CERTIFICATE [cert_Encrypt_Data]

                            SELECT 
	                            op.StorefrontSessionID,
	                            op.StorefrontOrderID,
	                            op.StorefrontCartID,
	                            op.StorefrontAdminID,
	                            adm.UserName,
	                            op.DateTimeImported, 
	                            op.DateTimeOrderPlaced, 
	                            op.ReadyToProcess,
	                            op.InProcess, 
	                            op.Void, 
	                            op.ReadyForPickup,
	                            os.SourceDesc,
                            --	op.ConsumerAccountID, 
                            --	ua.UserName,
                            --	ua.UserPassword,
	                            op.BillToFName,
	                            op.BillToMName,
	                            op.BillToLName,
	                            op.BillToAddress,
	                            op.BillToAddress2,
	                            op.BillToCity,
	                            op.BillToState,
	                            op.BillToZip,
	                            op.BillToCountry,
	                            op.BillToPhone,
	                            op.BillToEmail,

	                            op.ShipToFName,
	                            op.ShipToMName,
	                            op.ShipToLName,
	                            op.ShipToAddress,
	                            op.ShipToAddress2,
	                            op.ShipToCity,
	                            op.ShipToState,
	                            op.ShipToZip,
	                            stc.CountryName,
	                            op.ShipToPhone,
	                            op.ShipToEmail,
	                            op.ShipAddressVerified,
	                            op.ShipAmount,
	                            op.ProcessingType,
	                            sm.ShipMethodCode,
	                            sm.ShipMethodDescToPublic,

	                            op.SalesTaxDesc,
	                            op.SalesTaxAmount,
	                            op.InsTypeIDDesired,
	                            op.InsAmount,
	                            op.InsDesc,
	                            op.InsuranceRequired,
	                            op.CouponDesc,
	                            op.CouponAppliedAmount,
	                            op.CommentsFromConsumer,
	
	                            op.StorefrontPriceTot,
	                            op.PubPriceTot,
	                            op.RetailPriceTot,
	                            op.OrderGrandTotal,
	                            op.PaymentMethod,

	                            op.CCTypeCode,
	                            op.NameAsOnCC,
	                            Right(Convert( VARCHAR(100), decryptbykey( op.CCNumberEnc )), 4) AS CCNumber ,
	                            op.CCExpMonth,
	                            op.CCExpYear,

	                            op.FraudWarningFlag,
	                            op.DateFollowUp


                            FROM Orders_Provider op
                            INNER JOIN Orders_Blacklist ob ON (ob.ProviderOrderID = op.ProviderOrderID)
                            INNER JOIN ShipToCountries stc ON (stc.CountryID = op.ShipToCountryID)
                            INNER JOIN ShippingMethods sm ON (sm.ShipMethodID = op.ShipMethodIDDesired)
                            LEFT OUTER JOIN UserAccounts ua ON (ua.AccountID = op.ConsumerAccountID)
                            LEFT OUTER JOIN Orders_Source os ON (os.SourceID = op.SourceID)
                            LEFT OUTER JOIN Admins_Storefronts adm ON (adm.AdminID = op.StorefrontAdminID)
                            WHERE op.ProviderOrderID = {orderId}

                            CLOSE SYMMETRIC KEY [key_Encrypt_Data]
                        ";

                    bool wasOpen = command.Connection?.State == ConnectionState.Open;
                    if (!wasOpen) command.Connection?.Open();

                    try
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            dataTable.Load(reader);
                        }
                    }
                    finally
                    {
                        if (!wasOpen) command.Connection?.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return dataTable;
        }

        [HttpGet("{orderId}")]
        public IActionResult GetOrderDetailLineItems(int orderId)
        {
            if (User.Claims.Count(x => x.Type == "PERM_ACCOUNT_ENABLED") == 0 || User.Claims.Count(x => x.Type == "PERM_VIEW_ORDERS") == 0)
                return BadRequest();

            int storeId = GetStoreFrontId();

            if (storeId > 0)
            {
                DataTable dataTable = new DataTable();

                try
                {
                    using (var command = _masterContext.Database.GetDbConnection().CreateCommand())
                    {
                        bool wasOpen = command.Connection?.State == ConnectionState.Open;
                        if (!wasOpen) command.Connection?.Open();

                        try
                        {
                            command.CommandText = "usp_adminsf_orderdetails_lineitems_sel_v4";
                            command.CommandType = CommandType.StoredProcedure;

                            command.Parameters.Add(new SqlParameter("@storefrontid", SqlDbType.Int, 4) { Value = storeId });
                            command.Parameters.Add(new SqlParameter("@orderid", SqlDbType.Int, 4) { Value = orderId });

                            using (var reader = command.ExecuteReader())
                            {
                                dataTable.Load(reader);
                            }
                        }
                        finally
                        {
                            if (!wasOpen) command.Connection?.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    return BadRequest();
                }

                return Ok(DataConversion.SerializeJsonListFromDataTable(dataTable));
            }

            return BadRequest();
        }


        [HttpGet("{orderId}")]
        public IActionResult GetOrderDetailAccountInfo(int orderId)
        {
            if (User.Claims.Count(x => x.Type == "PERM_ACCOUNT_ENABLED") == 0 || User.Claims.Count(x => x.Type == "PERM_VIEW_ORDERS") == 0)
                return BadRequest();

            int storeId = GetStoreFrontId();

            DataTable dt = LoadAccountInfo(orderId, storeId);
            return Ok(DataConversion.SerializeJsonObjectFromDataTable(dt));
        }
        private DataTable LoadAccountInfo(int orderId, int storeId)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (var command = _masterContext.Database.GetDbConnection().CreateCommand())
                {
                    command.CommandText =
                        @$"
                            OPEN SYMMETRIC KEY [key_Encrypt_Data] 
                            DECRYPTION BY CERTIFICATE [cert_Encrypt_Data]

                            SELECT 
	                            ua.AccountID,
	                            --ua.UserName,
	                            --UserPassword,

	                            ua.BFName,
	                            ua.BMName,
	                            ua.BLName,
	                            ua.BAddress,
	                            ua.BAddress2,
	                            ua.BCity,
	                            ua.BState,
	                            ua.BZip,
	                            ua.BCountry,
	                            ua.BPhone,
	                            ua.BEmail,

	                            ua.SFName,
	                            ua.SMName,
	                            ua.SLName,
	                            ua.SAddress,
	                            ua.SAddress2,
	                            ua.SCity,
	                            ua.SState,
	                            ua.SZip,
	                            stc.CountryName,
	                            ua.SPhone,
	                            ua.SEmail,

	                            ua.CCTypeCode,
	                            ua.NameAsOnCC,
	                            Right(CONVERT( VARCHAR(100), decryptbykey( ua.CCNumberEnc )), 4) AS CCNumber,
	                            ua.CCExpMonth,
	                            ua.CCExpYear,

	                            ua.CCInfoFaxOnFile,
	                            ua.CheckNotesBeforeShipping

                            FROM UserAccounts ua
                            JOIN Orders_Provider op ON (op.ConsumerAccountID = ua.AccountID)
                            INNER JOIN ShipToCountries stc ON (stc.CountryID = op.ShipToCountryID)
                            INNER JOIN ShippingMethods sm ON (sm.ShipMethodID = op.ShipMethodIDDesired)

                            WHERE op.ProviderOrderID = {orderId} AND op.StorefrontID = {storeId}

                            CLOSE SYMMETRIC KEY [key_Encrypt_Data]
                        ";

                    bool wasOpen = command.Connection?.State == ConnectionState.Open;
                    if (!wasOpen) command.Connection?.Open();

                    try
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            dataTable.Load(reader);
                        }
                    }
                    finally
                    {
                        if (!wasOpen) command.Connection?.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return dataTable;
        }

        [HttpGet("{orderId}")]
        public IActionResult GetOrderDetailShipInfo(int orderId)
        {
            if (User.Claims.Count(x => x.Type == "PERM_ACCOUNT_ENABLED") == 0 || User.Claims.Count(x => x.Type == "PERM_VIEW_ORDERS") == 0)
                return BadRequest();

            int storeId = GetStoreFrontId();

            if (storeId > 0)
            {
                DataTable dataTable = new DataTable();

                try
                {
                    using (var command = _masterContext.Database.GetDbConnection().CreateCommand())
                    {
                        bool wasOpen = command.Connection?.State == ConnectionState.Open;
                        if (!wasOpen) command.Connection?.Open();

                        try
                        {
                            command.CommandText = "usp_adminsf_orderdetails_shipments";
                            command.CommandType = CommandType.StoredProcedure;

                            command.Parameters.Add(new SqlParameter("@storefrontid", SqlDbType.Int, 4) { Value = storeId });
                            command.Parameters.Add(new SqlParameter("@orderid", SqlDbType.Int, 4) { Value = orderId });

                            using (var reader = command.ExecuteReader())
                            {
                                dataTable.Load(reader);
                            }
                        }
                        finally
                        {
                            if (!wasOpen) command.Connection?.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    return BadRequest();
                }

                return Ok(DataConversion.SerializeJsonListFromDataTable(dataTable));
            }

            return BadRequest();
        }

        [HttpGet("{orderId}")]
        public IActionResult GetOrderDetailBlacklistOrders(int orderId)
        {
            if (User.Claims.Count(x => x.Type == "PERM_ACCOUNT_ENABLED") == 0 || User.Claims.Count(x => x.Type == "PERM_VIEW_ORDERS") == 0)
                return BadRequest();

            DataTable dataTable = new DataTable();

            try
            {
                using (var command = _masterContext.Database.GetDbConnection().CreateCommand())
                {
                    bool wasOpen = command.Connection?.State == ConnectionState.Open;
                    if (!wasOpen) command.Connection?.Open();

                    try
                    {
                        command.CommandText = "usp_adminsf_orderdetails_BlacklistCheckOrder";
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add(new SqlParameter("@ProviderOrderID", SqlDbType.Int, 4) { Value = orderId });

                        using (var reader = command.ExecuteReader())
                        {
                            dataTable.Load(reader);
                        }
                    }
                    finally
                    {
                        if (!wasOpen) command.Connection?.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

            return Ok(DataConversion.SerializeJsonListFromDataTable(dataTable));
        }

        [HttpGet("{orderId}")]
        public IActionResult GetOrderDetailActionsLog(int orderId)
        {
            if (User.Claims.Count(x => x.Type == "PERM_ACCOUNT_ENABLED") == 0 || User.Claims.Count(x => x.Type == "PERM_VIEW_ORDERS") == 0)
                return BadRequest();

            DataTable dataTable = new DataTable();

            try
            {
                using (var command = _masterContext.Database.GetDbConnection().CreateCommand())
                {
                    bool wasOpen = command.Connection?.State == ConnectionState.Open;
                    if (!wasOpen) command.Connection?.Open();

                    try
                    {
                        command.CommandText = "usp_orders_actions_log_sel";
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add(new SqlParameter("@orderid", SqlDbType.Int, 4) { Value = orderId });

                        using (var reader = command.ExecuteReader())
                        {
                            dataTable.Load(reader);
                        }
                    }
                    finally
                    {
                        if (!wasOpen) command.Connection?.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

            return Ok(DataConversion.SerializeJsonListFromDataTable(dataTable));
        }
    }
}
