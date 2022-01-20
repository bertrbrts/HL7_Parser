using care.ai.cloud.functions.src.HL7;
using Newtonsoft.Json;

namespace care.ai.cloud.functions.src.PatientData
{
    public partial class Poc : IPoc
    {
        [JsonProperty("externalFacilityId")]
        public string ExternalFacilityId { get; set; }

        [JsonProperty("externalLocationId")]
        public string ExternalLocationId { get; set; }

        [JsonProperty("externalZoneId")]
        public string ExternalZoneId { get; set; }

        [JsonProperty("externalBedId")]
        public string ExternalBedId { get; set; }

        public IPoc Create(IHL7_Message message)
        {
            return new Poc
            {
                ExternalFacilityId = message.GetValue("PV1.3.4") ?? "",
                ExternalLocationId = message.GetValue("PV1.3.1") ?? "",
                ExternalZoneId = message.GetValue("PV1.3.2") ?? "",
                ExternalBedId = message.GetValue("PV1.3.3") ?? ""
            };
        }
    }
}