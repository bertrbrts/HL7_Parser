using System.Threading.Tasks;

namespace care.ai.cloud.functions.src.TenantData
{
    public interface ITenant
    {
        string[] ActiveFeatures { get; set; }
        Authentication Authentication { get; set; }
        string ConfigType { get; set; }
        DataImportSettingsModel DataImportSettingsModel { get; set; }
        ForceUpdate ForceUpdate { get; set; }
        string FullName { get; set; }
        string ID { get; set; }
        string LogoUrl { get; set; }
        string Name { get; set; }
        OtherMobileSettings OtherMobileSettings { get; set; }
        OtherWebSettings OtherWebSettings { get; set; }
        Privacy Privacy { get; set; }
        Route[] Routes { get; set; }
        Scheduling[] Scheduling { get; set; }

        Task<Tenant[]> GetTenantsAsync(string routeKey);
    }
}