using care.ai.cloud.functions.src.HL7;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace care.ai.cloud.functions.src.PatientData
{
    public partial class Address : IAddress
    {
        IConfiguration _config;
        public Address() { }
        public Address(IConfiguration config)
        {
            _config = config;
        }

        [JsonProperty("address_1")]
        public string Address1 { get; set; }

        [JsonProperty("address_2")]
        public string Address2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        public IAddress Create(IHL7_Message message)
        {
            return new Address
            {
                Address1 = message.GetValue("PID.11.1") ?? "",
                Address2 = message.GetValue("PID.11.2") ?? "",
                City = message.GetValue("PID.11.3") ?? "",
                State = message.GetValue("PID.11.4") ?? "",
                Zipcode = message.GetValue("PID.11.5") ?? ""
            };
        }
    }
}