using care.ai.cloud.functions.src.HL7;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Linq;

namespace care.ai.cloud.functions.src.PatientData
{
    public partial class Event : IEvent
    {
        IConfiguration _config;
        public Event() { }
        public Event(IConfiguration config)
        {
            _config = config;
        }

        [JsonProperty("code")]
        public string Code { get; set; }
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        public IEvent Create(IHL7_Message message)
        {
            string _code = message.GetValue("MSH.8.2") ?? "";

            return new Event 
            { 
                Code = _code,
                DisplayName = GetDisplayName(_code)
            };        
        }

        private string GetDisplayName(string code)
        {
            return _config.GetSection("EventCodeLookup:EventCodes").Get<EventCode[]>()
                .FirstOrDefault(eventCode => eventCode.Name.Equals(code)).Value;
        }
    }
}