using System.Collections.Generic;
using System.Threading.Tasks;

namespace care.ai.cloud.functions.src.Services
{
    public interface IPublisherService
    {
        Task<List<string>> PublishAsync(string data);
    }
}