using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Persistence.Schema;

namespace MtgCustomDecksBuilder.Server.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    [Authorize]
    public class GameFormatController : BaseController
    {
        private readonly MtgCustomDecksBuilderContext _masterContext;

        public GameFormatController(MtgCustomDecksBuilderContext masterContext)
        {
            _masterContext = masterContext;
        }

        public async Task<IActionResult> GetAllGameFormats()
        {
            var results = _masterContext.GameFormats.ToList();

            return Ok(results);
        }
    }
}
