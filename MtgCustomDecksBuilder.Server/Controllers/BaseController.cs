using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using MtgCustomDecksBuilder.Server.Tools;
using System.Data;
using System.Data.Common;
using System.Net.Http.Headers;

namespace MtgCustomDecksBuilder.Server.Controllers
{
    public class BaseController : Controller
    {
        public BaseController()
        {
        }

        protected int GetStoreFrontId()
        {
            string storeID = User.Claims.FirstOrDefault(x => x.Type == "SFAdministratorStorefrontID")?.Value;

            int storeId = 0;
            int.TryParse(storeID, out storeId);
            return storeId;
        }
    }
}
