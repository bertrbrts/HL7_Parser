using Newtonsoft.Json;

namespace care.ai.cloud.functions.src.TenantData
{
    [JsonObject("Android")]
    public class Android
    {
        [JsonProperty("upgradeTo")]
        public string UpgradeTo { get; set; }
        [JsonProperty("updateURL")]
        public string UpdateURL { get; set; }
        [JsonProperty("displayText")]
        public string DisplayText { get; set; }
    }
}