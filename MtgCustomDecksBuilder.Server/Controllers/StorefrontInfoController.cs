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

namespace MtgCustomDecksBuilder.Server.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    [Authorize]
    public class StorefrontInfoController : ProviderBaseController
    {
        private IConfiguration _config;
        private readonly WNSMasterContext _masterContext;

        public StorefrontInfoController(IConfiguration config, WNSMasterContext masterContext)
        {
            _config = config;
            _masterContext = masterContext;
        }

        public IActionResult GetStorefrontInfo()
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
                        command.CommandText = "usp_storefrontinfo_sel_v2";
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add(new SqlParameter("@sfid", SqlDbType.Int, 4) { Value = GetStoreFrontId() });

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

            return Ok(DataConversion.SerializeJsonObjectFromDataTable(dataTable));
        }
    }
}
