using System.Threading.Tasks;

namespace care.ai.cloud.functions.src.Services
{
    public interface IPublisherService
    {
        Task<string> PublishAsync(string data);
    }
}