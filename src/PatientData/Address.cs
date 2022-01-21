using care.ai.cloud.functions.hl7;
using care.ai.cloud.functions.src.HL7;
using Newtonsoft.Json;

namespace care.ai.cloud.functions.src.PatientData
{
    /// <summary>
    /// Patient Address.
    /// </summary>
    public partial class Address : IAddress
    {
        /// <summary>
        /// Patient Address 1.  PID.11.1
        /// </summary>
        [JsonProperty("address_1")]
        public string Address1 { get; set; }
        /// <summary>
        /// Patient Address 2.  PID.11.2
        /// </summary>

        [JsonProperty("address_2")]
        public string Address2 { get; set; }
        /// <summary>
        /// Patient City.  PID.11.3
        /// </summary>

        [JsonProperty("city")]
        public string City { get; set; }
        /// <summary>
        /// Patient State.  PID.11.4
        /// </summary>

        [JsonProperty("state")]
        public string State { get; set; }
        /// <summary>
        /// Patient Zip Code.  PID.11.5
        /// </summary>

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        /// <summary>
        /// Address Factory Method
        /// </summary>
        /// <param name="message">HL7 Message</param>
        /// <returns>IAddress object</returns>
        public IAddress Factory(IHL7_Message message)
        {
            return new Address
            {
                Address1 = Mappings.PID.PatientAddress.StreetAddress.GetValue(message) ?? "",
                Address2 = Mappings.PID.PatientAddress.OtherDesignation.GetValue(message) ?? "",
                City = Mappings.PID.PatientAddress.City.GetValue(message) ?? "",
                State = Mappings.PID.PatientAddress.StateOrProvince.GetValue(message) ?? "",
                Zipcode = Mappings.PID.PatientAddress.ZipOrPostalCode.GetValue(message) ?? ""
            };
        }
    }
}