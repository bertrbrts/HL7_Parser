using Newtonsoft.Json;

namespace care.ai.cloud.functions.src.TenantData
{
    [JsonObject("Othermobilesettings")]
    public class OtherMobileSettings
    {
        [JsonProperty("logoutDisplayText")]
        public string LogoutDisplayText { get; set; }

        [JsonProperty("disableIdleTimeout")]
        public bool DisableIdleTimeout { get; set; }

        [JsonProperty("idleTimeoutInSeconds")]
        public int IdleTimeoutInSeconds { get; set; }

        [JsonProperty("disableBiometricAuthentication")]
        public bool DisableBiometricAuthentication { get; set; }

        [JsonProperty("forceRefreshToken")]
        public bool ForceRefreshToken { get; set; }

        [JsonProperty("forceChangeDateToCurrentDateInEntrance")]
        public bool ForceChangeDateToCurrentDateInEntrance { get; set; }

        [JsonProperty("enableTimerInEntranceActivity")]
        public bool EnableTimerInEntranceActivity { get; set; }

        [JsonProperty("entranceActivityRefreshRateInSeconds")]
        public int EntranceActivityRefreshRateInSeconds { get; set; }
    }
}