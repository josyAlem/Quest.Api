namespace Quest.Api.Common.Request
{
    public class Auth0UserInfoRequest
    {
        public string AccessToken { get; set; }
        public string Audience { get; set; }

    }
}
