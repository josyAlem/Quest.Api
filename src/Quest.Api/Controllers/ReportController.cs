using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Quest.Api.Helpers.Auth;

namespace Quest.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ReportController : ControllerBase
    {
        public ReportController()
        {

        }
        [HttpGet("[action]")]
        [Authorize(AuthorizationScope.Report.View)]
        public ActionResult<string> Check()
        {

            return Ok(nameof(ReportController) + " works!");
        }
    }
}
