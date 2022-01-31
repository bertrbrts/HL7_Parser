using care.ai.cloud.functions.src.HL7;
using care.ai.cloud.functions.hl7;
using Newtonsoft.Json;

namespace care.ai.cloud.functions.src.PatientData
{
    /// <summary>
    /// Patient
    /// </summary>
    public partial class Patient : IPatient
    {
       // private readonly IPoc _iPoc;
        private readonly IAddress _address;
        private readonly IName _name;

        /// <summary>
        /// IAddress object.
        /// </summary>
        [JsonProperty("address")]
        public IAddress Address { get; set; }
        /// <summary>
        /// Patient Admit Date.
        /// </summary>
        [JsonProperty("admitDate")]
        public string AdmitDate { get; set; }
        /// <summary>
        /// Patient Admission Reason.
        /// </summary>
        [JsonProperty("admitReason")]
        public string AdmitReason { get; set; }
        /// <summary>
        /// Patient Birth Date.
        /// </summary>
        [JsonProperty("birthdate")]
        public string Birthdate { get; set; }
        /// <summary>
        /// Patient Discharge Date.
        /// </summary>
        [JsonProperty("dischargedDate")]
        public string DischargedDate { get; set; }
        /// <summary>
        /// Patient Gender.
        /// </summary>
        [JsonProperty("gender")]
        public string Gender { get; set; }
        /// <summary>
        /// Patient Medical Record Number (MRN).
        /// </summary>
        [JsonProperty("mrn")]
        public string Mrn { get; set; }
        /// <summary>
        /// IName object.
        /// </summary>
        [JsonProperty("name")]
        public IName Name { get; set; }
        /// <summary>
        /// Patient ID.
        /// </summary>
        [JsonProperty("patientId")]
        public string PatientId { get; set; }
        /// <summary>
        /// Patient Phone.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }
        /// <summary>
        /// IPoc object.
        /// </summary>
        //[JsonProperty("poc")]
        //public IPoc Poc { get; set; }
        /// <summary>
        /// Patient Type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Patient Default Constructor.
        /// </summary>
        public Patient() { }
        /// <summary>
        /// Patient Constructor.
        /// </summary>
        /// <param name="config">IConfiguration object.</param>
        /// <param name="iPoc">IPoc object.</param>
        /// <param name="address">IAddress object.</param>
        /// <param name="name">IName object.</param>
        public Patient(/*IPoc iPoc,*/ IAddress address, IName name)
        {
            //_iPoc = iPoc;
            _address = address;
            _name = name;
        }

        /// <summary>
        /// IPatient Factory Method.
        /// </summary>
        /// <param name="message">IHL7_Message object.</param>
        /// <param name="tenantName">Tenant Name.</param>
        /// <returns>IPatient object.</returns>
        public IPatient Factory(IHL7_Message message, string tenantName)
        {
            string _mrn = Mappings.PID.PatientIdentifierList.IdNumber.GetValue(message, 1) ?? string.Empty;
            string assignedFac = Mappings.PV1.AssignedPatientLocation.Facility.GetValue(message) ?? string.Empty;

            return new Patient
            {
               // Poc = _iPoc.Factory(message),
                Mrn = _mrn,
                AdmitDate = Mappings.PV1.AdmitDateTime.GetValue(message) ?? string.Empty,
                AdmitReason = Mappings.PV1.AdmissionType.Text.GetValue(message) ?? string.Empty,
                DischargedDate = Mappings.PV1.DischargeDateTime.GetValue(message) ?? string.Empty,
                Gender = Mappings.PID.AdministrativeSex.Text.GetValue(message) ?? string.Empty,
                Birthdate = Mappings.PID.DateTimeOfBirth.GetValue(message) ?? string.Empty,
                Phone = Mappings.PID.PhoneNumberHome.GetValue(message) ?? string.Empty,
                Address = _address.Factory(message),
                Name = _name.Factory(message),
                PatientId = $"{tenantName}|{assignedFac}|{_mrn}",
                Type = "IDENTITY.PATIENT"
            };
        }
    }
}