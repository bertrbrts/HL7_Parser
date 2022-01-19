using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
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
            using HttpClient client = new HttpClient();

            string prefix = string.Empty;
#if DEBUG
            prefix = _config.GetValue<string>("DiscoveryAPI:DevelopmentPrefix");
#endif

            string url = string.Format(_config.GetValue<string>("DiscoveryAPI:TenantURL"), 
                prefix, 
                routeKey ?? _config.GetValue<string>("DiscoveryAPI:DefaultRouteKey"));

            var result = await client.GetStringAsync(url);
            return JsonConvert.DeserializeObject<Tenant[]>(result);
        }
    }
}