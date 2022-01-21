using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace care.ai.cloud.functions.src.TenantData
{
    public class Tenant : ITenant
    {
        private readonly IConfiguration _config;

        /// <summary>
        /// Full Name.
        /// </summary>
        [JsonProperty("fullName")]
        public string FullName { get; set; }
        /// <summary>
        /// ID.
        /// </summary>
        [JsonProperty("_id")]
        public string ID { get; set; }

        /// <summary>
        /// Tenant Constructor.
        /// </summary>
        /// <param name="config">IConfiguration object.</param>
        public Tenant(IConfiguration config)
        {
            _config = config;
        }

        /// <summary>
        /// Get Tenants Method.
        /// </summary>
        /// <param name="routeKey">Route Key.</param>
        /// <returns>Task<Tenant[]></returns>
        public async Task<Tenant[]> GetTenantsAsync(string routeKey)
        {
            try
            {
                using HttpClient client = new HttpClient();
                string url = string.Format(_config.GetValue<string>("DiscoveryAPI:TenantURL"),
                    routeKey ?? _config.GetValue<string>("DiscoveryAPI:DefaultRouteKey"));

                var result = await client.GetStringAsync(url);
                return JsonConvert.DeserializeObject<Tenant[]>(result);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}