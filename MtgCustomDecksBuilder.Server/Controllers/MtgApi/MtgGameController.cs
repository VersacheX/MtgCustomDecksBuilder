using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MtgApiManager.Lib.Service;
using Persistence.Schema;

namespace MtgCustomDecksBuilder.Server.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    [Authorize]
    public class MtgGameController : BaseController
    {
        private readonly IMtgServiceProvider _mtgServiceProvider;
        private readonly MtgCustomDecksBuilderContext _masterContext;

        public MtgGameController(IMtgServiceProvider mtgServiceProvider, MtgCustomDecksBuilderContext masterContext)
        {
            _mtgServiceProvider = mtgServiceProvider;
            _masterContext = masterContext;
        }

        public async Task<IActionResult> GetAllMtgFormats()
        {
            var results = _masterContext.MtgFormats.ToList();

            return Ok(results);
        }
    }
}
