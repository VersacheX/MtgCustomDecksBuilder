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

        protected int GetUserId()
        {
            string userId = User.Claims.FirstOrDefault(x => x.Type == "UserPK")?.Value;

            int userPk = 0;
            int.TryParse(userId, out userPk);
            return userPk;
        }
    }
}
