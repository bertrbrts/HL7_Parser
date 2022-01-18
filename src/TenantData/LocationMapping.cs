using Newtonsoft.Json;

namespace care.ai.cloud.functions.src.TenantData
{
    [JsonObject("Locationmapping")]
    public class LocationMapping
    {
        [JsonProperty("careailocationId")]
        public string CareailocationId { get; set; }

        [JsonProperty("tenantlocation")]
        public string Tenantlocation { get; set; }
    }
}