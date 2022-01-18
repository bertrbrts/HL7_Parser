using care.ai.cloud.functions.src.HL7;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace care.ai.cloud.functions.src.PatientData
{
    public partial class Name : IName
    {
        IConfiguration _config;
        public Name() { }
        public Name(IConfiguration config)
        {
            _config = config;
        }

        [JsonProperty("first")]
        public string First { get; set; }

        [JsonProperty("last")]
        public string Last { get; set; }

        [JsonProperty("middle")]
        public string Middle { get; set; }

        public IName Create(IHL7_Message message)
        {
            return new Name
            {
                First = message.GetValue("PID.5.2") ?? "",
                Last = message.GetValue("PID.5.1") ?? "",
                Middle = message.GetValue("PID.5.3") ?? ""
            };
        }
    }
}