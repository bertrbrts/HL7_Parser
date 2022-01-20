using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace care.ai.cloud.functions.src.TenantData
{
    public class Tenant : ITenant
    {
        private IConfiguration _config;
        public Tenant(IConfiguration config)
        {
            _config = config;
        }

        [JsonProperty("_id")]
        public string ID { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("authentication")]
        public Authentication Authentication { get; set; }

        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("privacy")]
        public Privacy Privacy { get; set; }

        [JsonProperty("routes")]
        public Route[] Routes { get; set; }

        [JsonProperty("configType")]
        public string ConfigType { get; set; }

        [JsonProperty("forceUpdate")]
        public ForceUpdate ForceUpdate { get; set; }

        [JsonProperty("otherMobileSettings")]
        public OtherMobileSettings OtherMobileSettings { get; set; }

        [JsonProperty("otherWebSettings")]
        public OtherWebSettings OtherWebSettings { get; set; }

        [JsonProperty("activeFeatures")]
        public string[] ActiveFeatures { get; set; }

        [JsonProperty("scheduling")]
        public Scheduling[] Scheduling { get; set; }

        [JsonProperty("dataImportSettingsModel")]
        public DataImportSettingsModel DataImportSettingsModel { get; set; }

        public async Task<Tenant[]> GetTenantsAsync(string routeKey)
        {
            try
            {
                using HttpClient client = new HttpClient();

                var x = _config.GetValue<string>("DiscoveryAPI:TenantURL");

                string url = string.Format(_config.GetValue<string>("DiscoveryAPI:TenantURL"),
                    routeKey ?? _config.GetValue<string>("DiscoveryAPI:DefaultRouteKey"));

                var result = await client.GetStringAsync(url);
                return JsonConvert.DeserializeObject<Tenant[]>(result);
            }
            catch (Exception ex)
            {
                var t = ex.Message;
                throw;
            }
        }
    }
}