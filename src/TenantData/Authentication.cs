using Newtonsoft.Json;

namespace care.ai.cloud.functions.src.TenantData
{
    [JsonObject("Authentication")]
    public class Authentication
    {
        [JsonProperty("webClientId")]
        public string WebClientId { get; set; }

        [JsonProperty("auth0Domain")]
        public string Auth0Domain { get; set; }

        [JsonProperty("webDefaultConnection")]
        public string WebDefaultConnection { get; set; }

        [JsonProperty("mobileClientId")]
        public string MobileClientId { get; set; }

        [JsonProperty("mobileDefaultConnection")]
        public string MobileDefaultConnection { get; set; }

        [JsonProperty("api")]
        public string API { get; set; }

        [JsonProperty("webAudience")]
        public string WebAudience { get; set; }

        [JsonProperty("mobileAudience")]
        public string MobileAudience { get; set; }

        [JsonProperty("servicesEndpoints")]
        public ServicesEndpoint[] ServicesEndpoints { get; set; }
    }
}