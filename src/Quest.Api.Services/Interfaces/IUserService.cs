using Quest.Api.Common.Request;
using Quest.Api.Common.Response;
using System.Collections.Generic;

namespace Quest.Api.Services.Interfaces
{
    public  interface IUserService
    {
        public UserInfoResponse UserInfo(UserInfoRequest userInfoRequest);
        public List<RoleResponse> GetRoles(string  userid);
    }
}
