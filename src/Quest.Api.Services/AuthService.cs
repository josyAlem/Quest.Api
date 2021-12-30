using AutoMapper;
using Quest.Api.Common.Request;
using Quest.Api.Common.Response;
using Quest.Api.Services.Interfaces;
using Studio.Auth.Auth0.Interfaces;
using Studio.Auth.Auth0.Models;
using System.Threading.Tasks;

namespace Quest.Api.Services
{
    public class AuthService : IAuthService
    {
        private readonly IMapper _mapper;
        private readonly IAuth0Service _auth0Service;

        public AuthService(IAuth0Service auth0Service, IMapper mapper)
        {
            _auth0Service = auth0Service;
            _mapper = mapper;
        }

        public async Task<LoginResponse> Login(LoginRequest loginRequest)
        {
            try
            {
                Auth0LoginRequest auth0loginRequest = _mapper.Map<Auth0LoginRequest>(loginRequest);
                var authResponse = await _auth0Service.Login(auth0loginRequest);
                LoginResponse loginResponse = _mapper.Map<LoginResponse>(authResponse);


                return loginResponse;
            }
            catch
            {
                throw;
            }
        }

        public async Task<RefreshTokenResponse> Refresh(RefreshTokenRequest refreshTokenRequest)
        {

            try
            {
                Auth0RefreshTokenRequest auth0refreshTokenRequest = _mapper.Map<Auth0RefreshTokenRequest>(refreshTokenRequest);
                var authResponse = await _auth0Service.Refresh(auth0refreshTokenRequest);

                RefreshTokenResponse refreshResponse = _mapper.Map<RefreshTokenResponse>(authResponse);

                return refreshResponse;
            }
            catch
            {
                throw;
            }
        }

        public async Task<SignupResponse> SignUp(SignupRequest signupRequest)
        {

            try
            {
                Auth0SignupRequest auth0signupRequest = _mapper.Map<Auth0SignupRequest>(signupRequest);
                var authResponse = await _auth0Service.SignUp(auth0signupRequest);

                SignupResponse signupResponse = _mapper.Map<SignupResponse>(authResponse);

                return signupResponse;
            }
            catch
            {
                throw;
            }
        }
    }
}
