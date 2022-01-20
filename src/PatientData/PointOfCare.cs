using care.ai.cloud.functions.src.HL7;
using Newtonsoft.Json;

namespace care.ai.cloud.functions.src.PatientData
{
    [JsonObject("Poc")]
    public partial class PointOfCare : IPoc
    {
        /// <summary>
        /// External Facility ID.
        /// </summary>
        [JsonProperty("externalFacilityId")]
        public string ExternalFacilityId { get; set; }
        /// <summary>
        /// External Location ID.
        /// </summary>
        [JsonProperty("externalLocationId")]
        public string ExternalLocationId { get; set; }
        /// <summary>
        /// External Zone ID.
        /// </summary>
        [JsonProperty("externalZoneId")]
        public string ExternalZoneId { get; set; }
        /// <summary>
        /// External Bed ID.
        /// </summary>
        [JsonProperty("externalBedId")]
        public string ExternalBedId { get; set; }
        /// <summary>
        /// IPoc Factory Method.
        /// </summary>
        /// <param name="message">IHL7_Message object.</param>
        /// <returns>IPoc object.</returns>
        public IPoc Factory(IHL7_Message message)
        {
            return new PointOfCare
            {
                ExternalFacilityId = message.GetValue("PV1.3.4") ?? "",
                ExternalLocationId = message.GetValue("PV1.3.1") ?? "",
                ExternalZoneId = message.GetValue("PV1.3.2") ?? "",
                ExternalBedId = message.GetValue("PV1.3.3") ?? ""
            };
        }
    }
}