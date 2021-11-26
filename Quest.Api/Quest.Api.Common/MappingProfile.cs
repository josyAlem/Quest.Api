using AutoMapper;
using Quest.Api.Common.Request;
using Quest.Api.Common.Response;
using Studio.Auth.Auth0.Models;

namespace Quest.Api.Common
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Auth0LoginResponse,LoginResponse>();
            CreateMap<Auth0RefreshTokenResponse,RefreshTokenResponse>();
            CreateMap<Auth0RoleResponse, RoleResponse>();
            CreateMap<Auth0SignupResponse,SignupResponse>();
            CreateMap<Auth0UserInfoResponse, UserInfoResponse>();
            CreateMap<LoginRequest,Auth0LoginRequest>();
            CreateMap<SignupRequest,Auth0SignupRequest>();
            CreateMap<RefreshTokenRequest,Auth0RefreshTokenRequest>();
            CreateMap<UserInfoRequest,Auth0UserInfoRequest>();
        }
    }
}
