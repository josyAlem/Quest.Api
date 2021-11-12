using Newtonsoft.Json;

namespace Quest.Api.Common.Response
{
    public class Auth0SignupResponse
    {
        [JsonProperty("name")]
        public string UserName { get; set; }
        [JsonProperty("user_id")]
        public string UserId { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
    }
}
