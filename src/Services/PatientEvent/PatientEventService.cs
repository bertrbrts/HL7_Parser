using care.ai.cloud.functions.src.HL7;
using care.ai.cloud.functions.src.PatientData;
using Google.Events.Protobuf.Cloud.PubSub.V1;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace care.ai.cloud.functions.src.Services.PatientEvent
{
    /// <summary>
    /// Patient Event Service.
    /// </summary>
    internal class PatientEventService : IPatientEventService
    {
        private readonly IHL7_Message _hl7_Message;
        private readonly IPatientEvent _patientEvent;
        private readonly IPublisherService _publisherService;

        public string PatientEventJSON = string.Empty;

        /// <summary>
        /// PatientEventService Constructor.
        /// </summary>
        /// <param name="hL7_Message">IHL7_Message object.</param>
        /// <param name="patientEvent">IPatientEvent object.</param>
        /// <param name="publisherService">IPublisherService object.</param>
        public PatientEventService(IHL7_Message hL7_Message, IPatientEvent patientEvent, IPublisherService publisherService)
        {
            _hl7_Message = hL7_Message;
            _patientEvent = patientEvent;
            _publisherService = publisherService;
        }

        /// <summary>
        /// Execute Service Action.
        /// </summary>
        /// <param name="data">MessagePublishedData object.</param>
        /// <returns>Task<List<string>></returns>
        public async Task<List<string>> ExecuteAsync(MessagePublishedData data)
        {
            IHL7_Message message = _hl7_Message.Factory(data?.Message.TextData);
            IPatientEvent patientEvent = await _patientEvent.FactoryAsync(message);
            PatientEventJSON = await Task.Run(() => JsonConvert.SerializeObject(patientEvent));

            return await _publisherService.PublishAsync(PatientEventJSON);
        }
    }
}