using care.ai.cloud.functions.src.HL7;
using care.ai.cloud.functions.src.TenantData;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace care.ai.cloud.functions.src.PatientData
{
    /// <summary>
    /// Patient Event.
    /// </summary>
    public partial class PatientEvent : IPatientEvent
    {
        private readonly IEvent _event;
        private readonly IEventData _eventData;
        private readonly ITenant _tenant;

        /// <summary>
        /// IEvent object.
        /// </summary>
        [JsonProperty("event")]
        public IEvent Event { get; set; }
        /// <summary>
        /// IEventData object.
        /// </summary>
        [JsonProperty("event_data")]
        public IEventData EventData { get; set; }
        /// <summary>
        /// Patient Event ID.
        /// </summary>
        [JsonProperty("eventId")]
        public string EventId { get; set; }
        /// <summary>
        /// Tenant Name.
        /// </summary>
        [JsonProperty("tenant")]
        public string Tenant { get; set; }
        /// <summary>
        /// Patient Event Time.
        /// </summary>
        [JsonProperty("time")]
        public string Time { get; set; }

       /// <summary>
        /// Patient Event Default Constructor.
        /// </summary>
        public PatientEvent() { }
        /// <summary>
        /// Patient Event Constructor.
        /// </summary>
        /// <param name="event">IEvent object.</param>
        /// <param name="eventData">IEventData object.</param>
        /// <param name="tenant">ITenant object.</param>
        public PatientEvent(IEvent @event, IEventData eventData, ITenant tenant)
        {
            _event = @event;
            _eventData = eventData;
            _tenant = tenant;
        }

        /// <summary>
        /// IPatientEvent Async Factory Method.
        /// </summary>
        /// <param name="message">IHL7_Message object.</param>
        /// <returns>Task<IPatientEvent></returns>
        public async Task<IPatientEvent> FactoryAsync(IHL7_Message message)
        {
            ITenant[] tenants = await _tenant.GetTenantsAsync(message.GetValue("MSH.3") ?? null);
            string tenantName = tenants.FirstOrDefault().FullName ?? string.Empty;

            return new PatientEvent
            {
                EventId = Guid.NewGuid().ToString(),
                Time = DateTime.UtcNow.ToString(),
                Tenant = tenantName,
                Event = _event.Factory(message),
                EventData = _eventData.Factory(message, tenantName)
            };
        }
    }
}