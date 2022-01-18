using Newtonsoft.Json;

namespace care.ai.cloud.functions.src.TenantData
{
    [JsonObject("Dataimportsettingsmodel")]
    public class DataImportSettingsModel
    {
        [JsonProperty("rootSFTPPath")]
        public string RootSFTPPath { get; set; }

        [JsonProperty("processedSFTPPath")]
        public string ProcessedSFTPPath { get; set; }

        [JsonProperty("rootFileName")]
        public string RootFileName { get; set; }

        [JsonProperty("badgeType")]
        public string BadgeType { get; set; }

        [JsonProperty("importFileMode")]
        public string ImportFileMode { get; set; }

        [JsonProperty("tenantDB")]
        public string TenantDB { get; set; }

        [JsonProperty("userIDRootName")]
        public string UserIDRootName { get; set; }

        [JsonProperty("fields")]
        public Field[] Fields { get; set; }
    }
}