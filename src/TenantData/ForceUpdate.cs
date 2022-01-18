using Newtonsoft.Json;

namespace care.ai.cloud.functions.src.TenantData
{
    [JsonObject("Forceupdate")]
    public class ForceUpdate
    {
        [JsonProperty("iOS")]
        public IOS IOS { get; set; }

        [JsonProperty("android")]
        public Android Android { get; set; }
    }
}