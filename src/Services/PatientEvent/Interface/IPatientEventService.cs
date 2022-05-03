using HL7Parser.HL7;
using HL7Parser.PatientData;
using Google.Events.Protobuf.Cloud.PubSub.V1;
using System.Collections.Generic;
using System.Threading.Tasks;
using HL7Parser.Services.Publisher;

namespace HL7Parser.Services.PatientEvent
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