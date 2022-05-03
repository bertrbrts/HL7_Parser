using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HL7Parser.TenantData
{
    public class Tenant : ITenant
    {
        private readonly IConfiguration _config;
        private readonly ILogger _logger;

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
        public Tenant(ILogger<Tenant> logger, IConfiguration config)
        {
            _logger = logger;
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
            catch (Exception ex)
            {
                string exResult = $"Tenant.GetTenantsAsync > Exception:{ex.Message} | InnerException: {ex.InnerException?.Message ?? "null"} | StackTrace: {ex.StackTrace?.ToString()}";
                _logger.LogInformation(exResult);
                return null;
            }
        }
    }
}