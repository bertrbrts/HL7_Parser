using care.ai.cloud.functions.src.HL7;
using care.ai.cloud.functions.src.TenantData;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace care.ai.cloud.functions.src.PatientData
{
    //https://hl7-definition.caristix.com/v2/HL7v2.8/Segments
    public partial class PatientEvent : IPatientEvent
    {
        IEvent _event;
        IEventData _eventData;
        ITenant _tenant;

        public PatientEvent() { }
        public PatientEvent(IEvent @event, IEventData eventData, ITenant tenant)
        {
            _event = @event;
            _eventData = eventData;
            _tenant = tenant;
        }

        [JsonProperty("eventId")]
        public string EventId { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("tenant")]
        public string Tenant { get; set; }

        [JsonProperty("event")]
        public IEvent Event { get; set; }

        [JsonProperty("event_data")]
        public IEventData EventData { get; set; }

        public async Task<IPatientEvent> CreateAsync(IHL7_Message message)
        {
            ITenant[] tenants = await _tenant.GetTenantsAsync(message.GetValue("MSH.3") ?? null);
            string tenantName = tenants.FirstOrDefault().FullName ?? string.Empty;

            return new PatientEvent
            {
                EventId = Guid.NewGuid().ToString(),
                Time = DateTime.UtcNow.ToString(),
                Tenant = tenantName,
                Event = _event.Create(message),
                EventData = _eventData.Create(message, tenantName)
            };
        }
    }
}