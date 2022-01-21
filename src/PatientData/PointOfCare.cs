using care.ai.cloud.functions.src.HL7;
using care.ai.cloud.functions.hl7;
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
                ExternalFacilityId = Mappings.PV1.AssignedPatientLocation.Facility.GetValue(message) ?? "",
                ExternalLocationId = Mappings.PV1.AssignedPatientLocation.PointOfCare.GetValue(message) ?? "",
                ExternalZoneId = Mappings.PV1.AssignedPatientLocation.Room.GetValue(message) ?? "",
                ExternalBedId = Mappings.PV1.AssignedPatientLocation.Bed.GetValue(message) ?? ""
            };
        }
    }
}