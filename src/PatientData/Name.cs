using care.ai.cloud.functions.src.HL7;
using care.ai.cloud.functions.hl7;
using Newtonsoft.Json;

namespace care.ai.cloud.functions.src.PatientData
{
    /// <summary>
    /// Patient Name
    /// </summary>
    public partial class Name : IName
    {
        /// <summary>
        /// Patient First Name.
        /// </summary>
        [JsonProperty("first")]
        public string First { get; set; }
        /// <summary>
        /// Patient Last Name.
        /// </summary>
        [JsonProperty("last")]
        public string Last { get; set; }
        /// <summary>
        /// Patient Middle Name.
        /// </summary>
        [JsonProperty("middle")]
        public string Middle { get; set; }
        /// <summary>
        /// IName Factory Method.
        /// </summary>
        /// <param name="message">IHL7_Message object.</param>
        /// <returns>IName object.</returns>
        public IName Factory(IHL7_Message message)
        {
            return new Name
            {
                First = Mappings.PID.PatientName.GivenName.GetValue(message) ?? string.Empty,
                Last = Mappings.PID.PatientName.FamilyName.GetValue(message) ?? string.Empty,
                Middle = Mappings.PID.PatientName.SecondAndFurtherGivenNamesOrInitialsThereof.GetValue(message) ?? string.Empty
            };
        }
    }
}