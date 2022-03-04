using care.ai.cloud.functions.src.HL7;
using care.ai.cloud.functions.src.PatientData;
using Google.Events.Protobuf.Cloud.PubSub.V1;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace care.ai.cloud.functions.src.Services.PatientEvent
{
    /// <summary>
    /// IPatientEventService Interface.
    /// </summary>
    public interface IPatientEventService
    {
        public IHL7_Message HL7_Message { get; set; }
        public IPatientEvent PatientEvent { get; set; }
        public IPublisherService PublisherService { get; set; }

        /// <summary>
        /// Execute Service Action.
        /// </summary>
        /// <param name="data">MessagePublishedData object.</param>
        /// <returns>Task<List<string>></returns>
        Task<List<string>> ExecuteAsync(MessagePublishedData data);
    }
}