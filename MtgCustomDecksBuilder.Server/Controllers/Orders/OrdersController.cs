using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using MtgCustomDecksBuilder.Server.Models.SearchCriteria;
using MtgCustomDecksBuilder.Server.Schema.WNSMaster;
using MtgCustomDecksBuilder.Server.Tools;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Xml.Linq;

namespace MtgCustomDecksBuilder.Server.Controllers.Orders
{
    [ApiController]
    [Route("[controller]/[action]")]
    [Authorize]
    public class OrdersController : ProviderBaseController
    {
        private IConfiguration _config;
        private readonly WNSMasterContext _masterContext;

        public OrdersController(IConfiguration config, WNSMasterContext masterContext)
        {
            _config = config;
            _masterContext = masterContext;
        }

        [HttpPost]
        public IActionResult GetOrdersByCriteria(OrderSearchCriteria searchCriteria)
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
                        command.CommandText = "usp_adminsf_orders_sel_v4";
                        command.CommandType = CommandType.StoredProcedure;


                        command.Parameters.Add(new SqlParameter("@storefrontid", SqlDbType.Int, 4) { Value = GetStoreFrontId() });
                        command.Parameters.Add(new SqlParameter("@begindate", SqlDbType.DateTime, 8) { Value = searchCriteria.DateFrom });
                        command.Parameters.Add(new SqlParameter("@enddate", SqlDbType.DateTime, 8) { Value = searchCriteria.DateTo });
                        command.Parameters.Add(new SqlParameter("@beginordernum", SqlDbType.Int, 4) { Value = (object?)searchCriteria.ProviderOrderRangeFrom ?? DBNull.Value });
                        command.Parameters.Add(new SqlParameter("@endordernum", SqlDbType.Int, 4) { Value = (object?)searchCriteria.ProviderOrderRangeTo ?? DBNull.Value });
                        command.Parameters.Add(new SqlParameter("@beginstoreorderid", SqlDbType.VarChar, 32) { Value = (object?)searchCriteria.StoreOrderRangeFrom ?? DBNull.Value });
                        command.Parameters.Add(new SqlParameter("@endstoreorderid", SqlDbType.VarChar, 32) { Value = (object?)searchCriteria.StoreOrderRangeTo ?? DBNull.Value });
                        command.Parameters.Add(new SqlParameter("@readytoprocess", SqlDbType.VarChar, 1) { Value = (object?)searchCriteria.ReadyToProcess ?? DBNull.Value });
                        command.Parameters.Add(new SqlParameter("@inprocess", SqlDbType.VarChar, 1) { Value = (object?)searchCriteria.InProcess ?? DBNull.Value });
                        command.Parameters.Add(new SqlParameter("@void", SqlDbType.VarChar, 1) { Value = (object?)searchCriteria.Void ?? DBNull.Value });
                        command.Parameters.Add(new SqlParameter("@proctype", SqlDbType.TinyInt, 2) { Value = (object?)searchCriteria.ProcessingType ?? 2 });
                        command.Parameters.Add(new SqlParameter("@readyforpickup", SqlDbType.VarChar, 1) { Value = (object?)searchCriteria.ReadyForPickup ?? DBNull.Value });
                        command.Parameters.Add(new SqlParameter("@fname", SqlDbType.VarChar, 50) { Value = (object?)searchCriteria.FirstName ?? DBNull.Value });
                        command.Parameters.Add(new SqlParameter("@lname", SqlDbType.VarChar, 50) { Value = (object?)searchCriteria.LastName ?? DBNull.Value });
                        command.Parameters.Add(new SqlParameter("@email", SqlDbType.VarChar, 100) { Value = (object?)searchCriteria.Email ?? DBNull.Value });
                        command.Parameters.Add(new SqlParameter("@trackingnum", SqlDbType.VarChar, 50) { Value = (object?)searchCriteria.TrackingNum ?? DBNull.Value });
                        command.Parameters.Add(new SqlParameter("@balancecrit", SqlDbType.VarChar, 3) { Value = (object?)searchCriteria.Balance ?? DBNull.Value });
                        command.Parameters.Add(new SqlParameter("@followupdate", SqlDbType.DateTime, 8) { Value = (object?)searchCriteria.FollowUpDate ?? DBNull.Value });
                        command.Parameters.Add(new SqlParameter("@sourceid", SqlDbType.TinyInt, 1) { Value = (object?)searchCriteria.Source ?? 0 });
                        command.Parameters.Add(new SqlParameter("@suggestedcarrierid", SqlDbType.SmallInt, 2) { Value = (object?)searchCriteria.CarrierId ?? 0 });
                        command.Parameters.Add(new SqlParameter("@wrhsid", SqlDbType.SmallInt, 2) { Value = (object?)searchCriteria.Warehouse ?? 0 });
                        command.Parameters.Add(new SqlParameter("@hasrecentorder", SqlDbType.VarChar, 1) { Value = (object?)searchCriteria.HasRecentOrders ?? DBNull.Value });
                        command.Parameters.Add(new SqlParameter("@maxrows", SqlDbType.Int, 4) { Value = (object?)searchCriteria.MaxRow ?? 1000 });

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
