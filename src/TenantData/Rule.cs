using Newtonsoft.Json;

namespace care.ai.cloud.functions.src.TenantData
{
    [JsonObject("Rule")]
    public class Rule
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}