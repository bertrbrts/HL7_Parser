using System.Collections.Generic;
using System.Threading.Tasks;

namespace HL7Parser.Services.Publisher
{
    /// <summary>
    /// IPublisherService Interface.
    /// </summary>
    public interface IPublisherService
    {
        /// <summary>
        /// Publisher Service Publish Action.
        /// </summary>
        /// <param name="data">data to publish.</param>
        /// <returns>Task<List<string>></returns>
        Task<List<string>> PublishAsync(string data);
    }
}