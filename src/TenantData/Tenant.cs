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
            var result = await client.GetStringAsync($"https://dev-discover.care.ai/discovery/whois?routes.key={routeKey ?? "EPIC_ORG_1"}&routes.type=ROUTES_LICENSE_KEY");
            return JsonConvert.DeserializeObject<Tenant[]>(result);
        }
    }
}