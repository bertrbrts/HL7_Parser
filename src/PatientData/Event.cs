using HL7Parser.HL7;
using HL7Parser;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Linq;

namespace HL7Parser.PatientData
{
    /// <summary>
    /// Patient Event
    /// </summary>
    public partial class Event : IEvent
    {
        private readonly IConfiguration _config;

        /// <summary>
        /// Event Code.
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }
        /// <summary>
        /// Display Name.
        /// </summary>
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Event Default Constructor.
        /// </summary>
        public Event() { }
        /// <summary>
        /// Event Constructor.
        /// </summary>
        /// <param name="config">IConfiguration object.</param>
        public Event(IConfiguration config)
        {
            _config = config;
        }

        /// <summary>
        /// Event Factory.
        /// </summary>
        /// <param name="message">IHL7_Message object.</param>
        /// <returns>IEvent object.</returns>
        public IEvent Factory(IHL7_Message message)
        {
            string _code = Mappings.MSH.MessageType.TriggerEvent.GetValue(message) ?? string.Empty;
            var @event = _config.GetSection("EventCodeLookup:EventCodes").Get<EventCode[]>()
                    .FirstOrDefault(eventCode => eventCode.Key.Equals(_code));

            return new Event
            {
                Code = @event?.Value ?? string.Empty,
                DisplayName = @event?.DisplayName ?? string.Empty
            };        
        }
    }
}