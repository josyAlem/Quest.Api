using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Quest.Api.Helpers.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quest.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PaymentController : ControllerBase
    {
        public PaymentController()
        {

        }
        [HttpGet("[action]")]
        [Authorize(AuthorizationScope.Payment.Get)]
        public ActionResult<string> Check()
        {

            return Ok(nameof(PaymentController) + " works!");
        }
    }
}
