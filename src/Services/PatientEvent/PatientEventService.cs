using care.ai.cloud.functions.src.HL7;
using care.ai.cloud.functions.src.PatientData;
using Google.Events.Protobuf.Cloud.PubSub.V1;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace care.ai.cloud.functions.src.Services.PatientEvent
{
    internal class PatientEventService : IPatientEventService
    {
        IHL7_Message _hl7_Message;
        IPatientEvent _patientEvent;
        IPublisherService _publisherService;

        public string PatientEventJSON = string.Empty;
        public PatientEventService(IHL7_Message hL7_Message, IPatientEvent patientEvent, IPublisherService publisherService)
        {
            _hl7_Message = hL7_Message;
            _patientEvent = patientEvent;
            _publisherService = publisherService;
        }

        public async Task<List<string>> ExecuteAsync(MessagePublishedData data)
        {
            IHL7_Message message = _hl7_Message.Create(data?.Message.TextData);
            IPatientEvent patientEvent = await _patientEvent.CreateAsync(message);
            PatientEventJSON = await Task.Run(() => JsonConvert.SerializeObject(patientEvent));

            return await _publisherService.PublishAsync(PatientEventJSON);
        }
    }
}