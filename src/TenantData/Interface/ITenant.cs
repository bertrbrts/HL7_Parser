using System.Threading.Tasks;

namespace HL7Parser.TenantData
{
    /// <summary>
    /// ITenant Interface.
    /// </summary>
    public interface ITenant
    {
        /// <summary>
        /// Full Name.
        /// </summary>
        string FullName { get; set; }
        /// <summary>
        /// ID.
        /// </summary>
        string ID { get; set; }
        /// <summary>
        /// Get Tenants Method.
        /// </summary>
        /// <param name="routeKey">Route Key.</param>
        /// <returns>Task<Tenant[]></returns>
        Task<Tenant[]> GetTenantsAsync(string routeKey);
    }
}