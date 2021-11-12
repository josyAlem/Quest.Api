using Quest.Api.Common.Request;
using Quest.Api.Common.Response;
using System.Threading.Tasks;

namespace Quest.Api.Services.Interfaces
{
    public interface IAuthService
    {
        Task<SignupResponse> SignUp(SignupRequest signupRequest);
        Task<LoginResponse> Login(LoginRequest loginRequest);
        Task<RefreshTokenResponse> Refresh(RefreshTokenRequest refreshTokenRequest);
    }
}
