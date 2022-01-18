using Newtonsoft.Json;

namespace care.ai.cloud.functions.src.TenantData
{
    [JsonObject("Servicesendpoint")]
    public class ServicesEndpoint
    {
        [JsonProperty("serviceName")]
        public string ServiceName { get; set; }

        [JsonProperty("serviceBaseURL")]
        public string ServiceBaseURL { get; set; }
    }
}