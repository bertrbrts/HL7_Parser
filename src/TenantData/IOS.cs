using Newtonsoft.Json;

namespace care.ai.cloud.functions.src.TenantData
{
    [JsonObject("Ios")]
    public class IOS
    {
        [JsonProperty("upgradeTo")]
        public string UpgradeTo { get; set; }

        [JsonProperty("updateURL")]
        public string UpdateURL { get; set; }

        [JsonProperty("displayText")]
        public string DisplayText { get; set; }
    }
}