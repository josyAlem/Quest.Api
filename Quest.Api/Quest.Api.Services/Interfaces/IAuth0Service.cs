using Quest.Api.Common.Request;
using Quest.Api.Common.Response;
using System.Threading.Tasks;

namespace Quest.Api.Services.Interfaces
{
    public   interface IAuth0Service
    {
        Task<Auth0LoginResponse> Login(Auth0LoginRequest loginRequest);
        Task<Auth0SignupResponse> SignUp(Auth0SignupRequest signupRequest);
        Task<Auth0RefreshTokenResponse> Refresh(Auth0RefreshTokenRequest refreshTokenRequest);
        Task<Auth0UserInfoResponse> GetUserInfo(Auth0UserInfoRequest auth0UserInfoRequest);
    }
}
