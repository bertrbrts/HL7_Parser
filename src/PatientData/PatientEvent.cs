using HL7Parser.HL7;
using HL7Parser;
using HL7Parser.TenantData;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace HL7Parser.PatientData
{
    /// <summary>
    /// Patient Event.
    /// </summary>
    public partial class PatientEvent : IPatientEvent
    {
        private readonly ILogger _logger;
        private readonly IEvent _event;
        private readonly IEventData _eventData;
        private readonly ITenant _tenant;
        private readonly IPoc _poc;

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
        /// IPoc object.
        /// </summary>
        [JsonProperty("poc")]
        public IPoc Poc { get; set; }
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
        public PatientEvent(ILogger<PatientEvent> logger, IEvent @event, IEventData eventData, ITenant tenant, IPoc poc)
        {
            _logger = logger;
            _event = @event;
            _eventData = eventData;
            _tenant = tenant;
            _poc = poc;
        }

        /// <summary>
        /// IPatientEvent Async Factory Method.
        /// </summary>
        /// <param name="message">IHL7_Message object.</param>
        /// <returns>Task<IPatientEvent></returns>
        public async Task<IPatientEvent> FactoryAsync(IHL7_Message message)
        {
            try
            {
                ITenant[] tenants = await _tenant.GetTenantsAsync(Mappings.MSH.SendingFacility.GetValue(message) ?? null);
                string tenantName = tenants?.FirstOrDefault()?.FullName ?? string.Empty;

                return new PatientEvent
                {
                    EventId = Guid.NewGuid().ToString(),
                    Time = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss.fffffffZ"),
                    Tenant = tenantName,
                    Event = _event.Factory(message),
                    EventData = _eventData.Factory(message),
                    Poc = _poc.Factory(message)
                };
            }
            catch (Exception ex)
            {
                string exResult = $"PatientEvent.Factory > Exception:{ex.Message} | InnerException: {ex.InnerException?.Message ?? "null"} | StackTrace: {ex.StackTrace?.ToString()}";
                _logger.LogInformation(exResult);
                throw new Exception(exResult);
            }
        }
    }
}