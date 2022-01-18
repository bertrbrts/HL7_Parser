using Newtonsoft.Json;

namespace care.ai.cloud.functions.src.TenantData
{
    [JsonObject("Privacy")]
    public class Privacy
    {
        [JsonProperty("doNotStoreImages")]
        public bool DoNotStoreImages { get; set; }
    }
}