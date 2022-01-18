using care.ai.cloud.functions.src.HL7;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace care.ai.cloud.functions.src.PatientData
{
    public partial class Patient : IPatient
    {
        IConfiguration _config;
        IPoc _iPoc;
        IAddress _address;
        IName _name;

        public Patient() { }
        public Patient(IConfiguration config, IPoc iPoc, IAddress address, IName name)
        {
            _config = config;
            _iPoc = iPoc;
            _address = address;
            _name = name;
        }

        [JsonProperty("poc")]
        public IPoc Poc { get; set; }

        [JsonProperty("mrn")]
        public string Mrn { get; set; }

        [JsonProperty("admitDate")]
        public string AdmitDate { get; set; }

        [JsonProperty("admitReason")]
        public string AdmitReason { get; set; }

        [JsonProperty("dischargedDate")]
        public string DischargedDate { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthdate")]
        public string Birthdate { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("address")]
        public IAddress Address { get; set; }

        [JsonProperty("name")]
        public IName Name { get; set; }

        [JsonProperty("patientId")]
        public string PatientId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        public IPatient Create(IHL7_Message message)
        {
            return new Patient
            {
                Poc = _iPoc.Create(message),
                Mrn = message.GetValue("PID.3[1].1") ?? "",
                AdmitDate = message.GetValue("PV1.44") ?? "",
                AdmitReason = message.GetValue("PV1.4.2") ?? "",
                DischargedDate = message.GetValue("PV1.45") ?? "",
                Gender = message.GetValue("PID.8.2") ?? "",
                Birthdate = message.GetValue("PID.7") ?? "",
                Phone = message.GetValue("PID.13") ?? "",
                Address = _address.Create(message),
                Name = _name.Create(message),
                PatientId = "<< TENANT_NAME|External Facility Id|Unique Patient Id >>",
                Type = "IDENTITY.PATIENT"
            };
        }
    }
}