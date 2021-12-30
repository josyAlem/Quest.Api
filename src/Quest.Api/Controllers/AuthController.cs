using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Quest.Api.Helpers.Auth;
using Quest.Api.Common.Request;
using Quest.Api.Common.Response;
using Quest.Api.Services.Interfaces;
using System.Threading.Tasks;
using System;

namespace Quest.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authenticationService;

        public AuthController(IAuthService authenticationService)
        {
            _authenticationService = authenticationService;
        }
       
        [HttpPost("[action]")]
        [AllowAnonymous]
        public async Task<ActionResult<SignupResponse>> Signup([FromBody]  SignupRequest signupRequest)
        {
            var response = await _authenticationService.SignUp(signupRequest);
            return Ok(response);
        }

        [HttpPost("[action]")]
        [AllowAnonymous]
        public async Task<ActionResult<LoginResponse>> Login([FromBody] LoginRequest loginRequest)
        {
            try { var response = await _authenticationService.Login(loginRequest);
                return Ok(response);
            } catch (Exception ex) {
                return StatusCode(500, ex);
            } }
       
        [HttpPost("[action]")]
        [AllowAnonymous]
        public async Task<ActionResult<RefreshTokenResponse>> Refresh([FromBody] RefreshTokenRequest refreshTokenRequest)
        {
            var response = await _authenticationService.Refresh(refreshTokenRequest);
            return Ok(response);
        }
}
}
