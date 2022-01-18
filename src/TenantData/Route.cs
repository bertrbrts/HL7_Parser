using Newtonsoft.Json;

namespace care.ai.cloud.functions.src.TenantData
{
    [JsonObject("Route")]
    public class Route
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("connectionId")]
        public string ConnectionId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}