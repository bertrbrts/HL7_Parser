using care.ai.cloud.functions.src.HL7;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

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
            return new Event()
            {
                Code = message.GetValue("MSH.9.2") ?? "", //Message Code: Specifies the message type code. Refer to HL7 Table 0076– Message Type for valid values.
                DisplayName = message.GetValue("MSH.9.2") ?? "" //Message Control Id: This field contains a number or other identifier that uniquely identifies the message. The receiving system echoes this ID back to the sending system in the Message acknowledgment segment (MSA).
            };
        }
    }
}