using care.ai.cloud.functions.src.HL7;
using Newtonsoft.Json;

namespace care.ai.cloud.functions.src.PatientData
{
    public partial class EventData : IEventData
    {
        IPatient _patient;
        public EventData() { }
        public EventData(IPatient patient)
        {
            _patient = patient;
        }

        [JsonProperty("patient")]
        public IPatient Patient { get; set; }

        public IEventData Create(IHL7_Message message, string tenantName)
        {
            return new EventData
            {
                Patient = _patient.Create(message, tenantName)
            };
        }
    }
}