using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Quest.Api.Helpers.Auth;

namespace Quest.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CatalogController : ControllerBase
    {
        public CatalogController()
        {

        }
        [HttpGet("[action]")]
        [Authorize(AuthorizationScope.Catalog.Get)]
        public ActionResult<string> Check()
        {

            return Ok(nameof(CatalogController) + " works!");
        }
    }
}
