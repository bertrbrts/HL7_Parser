using Newtonsoft.Json;

namespace care.ai.cloud.functions.src.TenantData
{
    [JsonObject("Field")]
    public class Field
    {
        [JsonProperty("careaifield")]
        public string Careaifield { get; set; }

        [JsonProperty("tenantfield")]
        public string Tenantfield { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("fieldvalueifstaff")]
        public string Fieldvalueifstaff { get; set; }

        [JsonProperty("fieldvalueifvendor")]
        public string Fieldvalueifvendor { get; set; }

        [JsonProperty("locationMappings")]
        public LocationMapping[] LocationMappings { get; set; }
    }
}