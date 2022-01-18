using Newtonsoft.Json;

namespace care.ai.cloud.functions.src.TenantData
{
    [JsonObject("Otherwebsettings")]
    public class OtherWebSettings
    {
        [JsonProperty("hasQuestionnarieTemplete")]
        public bool HasQuestionnarieTemplete { get; set; }

        [JsonProperty("entranceActivityRefreshRateInSeconds")]
        public string EntranceActivityRefreshRateInSeconds { get; set; }

        [JsonProperty("enableCSVDownload")]
        public bool EnableCSVDownload { get; set; }

        [JsonProperty("punchInDataAvailable")]
        public bool PunchInDataAvailable { get; set; }

        [JsonProperty("lowTemperatureCutoff")]
        public float LowTemperatureCutoff { get; set; }

        [JsonProperty("employeeIdNotUnique")]
        public bool EmployeeIdNotUnique { get; set; }

        [JsonProperty("enableSchedule")]
        public bool EnableSchedule { get; set; }

        [JsonProperty("useTenantSpecificRoles")]
        public bool UseTenantSpecificRoles { get; set; }

        [JsonProperty("hasQuestionnarieAddress")]
        public bool HasQuestionnarieAddress { get; set; }
    }
}