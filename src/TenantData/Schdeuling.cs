using Newtonsoft.Json;

namespace care.ai.cloud.functions.src.TenantData
{
    [JsonObject("Scheduling")]
    public class Scheduling
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("rules")]
        public Rule[] Rules { get; set; }
    }
}