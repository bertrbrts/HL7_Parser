using Google.Events.Protobuf.Cloud.PubSub.V1;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace care.ai.cloud.functions.src.Services.PatientEvent
{
    /// <summary>
    /// IPatientEventService Interface.
    /// </summary>
    internal interface IPatientEventService
    {
        /// <summary>
        /// Execute Service Action.
        /// </summary>
        /// <param name="data">MessagePublishedData object.</param>
        /// <returns>Task<List<string>></returns>
        Task<List<string>> ExecuteAsync(MessagePublishedData data);
    }
}