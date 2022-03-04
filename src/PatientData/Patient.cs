using care.ai.cloud.functions.src.HL7;
using care.ai.cloud.functions.hl7;
using Newtonsoft.Json;
using System;
using System.Text.RegularExpressions;
using Microsoft.Extensions.Logging;

namespace care.ai.cloud.functions.src.PatientData
{
    /// <summary>
    /// Patient
    /// </summary>
    public partial class Patient : IPatient
    {
        private readonly IAddress _address;
        private readonly IName _name;
        private readonly ILogger _logger;

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
        /// <param name="address">IAddress object.</param>
        /// <param name="name">IName object.</param>
        public Patient(ILogger<Patient> logger, IAddress address, IName name)
        {
            _address = address;
            _name = name;
            _logger = logger;
        }

        /// <summary>
        /// IPatient Factory Method.
        /// </summary>
        /// <param name="message">IHL7_Message object.</param>
        /// <returns>IPatient object.</returns>
        public IPatient Factory(IHL7_Message message)
        {
            string _mrn = Mappings.PID.PatientIdentifierList.IdNumber.GetValue(message, 1) ?? string.Empty;

            return new Patient
            {
                Mrn = _mrn,
                AdmitDate = ConvertToDateString(Mappings.PV1.AdmitDateTime.GetValue(message), "yyyy-MM-ddTHH:mm:ss.fffffffZ") ?? string.Empty,
                AdmitReason = Mappings.PV1.AdmissionType.Text.GetValue(message) ?? string.Empty,
                DischargedDate = ConvertToDateString(Mappings.PV1.DischargeDateTime.GetValue(message), "yyyy-MM-ddTHH:mm:ss.fffffffZ") ?? string.Empty,
                Gender = Mappings.PID.AdministrativeSex.Text.GetValue(message) ?? string.Empty,
                Birthdate = ConvertToDateString(Mappings.PID.DateTimeOfBirth.GetValue(message), "MM/dd/yyyy") ?? string.Empty,
                Phone = Mappings.PID.PhoneNumberHome.GetValue(message) ?? string.Empty,
                Address = _address.Factory(message),
                Name = _name.Factory(message),
                PatientId = _mrn,
                Type = "IDENTITY.PATIENT"
            };
        }

        private string ConvertToDateString(string messageDate, string format)
        {
            try
            {
                string result = string.Empty;
                if (!string.IsNullOrEmpty(messageDate))
                {
                    messageDate = Regex.Replace(messageDate, "[^0-9.]", "");
                    int length = messageDate.Length;

                    int year = (length >= 4) ? Convert.ToInt32(messageDate.Substring(0, 4)) : 0;
                    int month = (length >= 6) ? Convert.ToInt32(messageDate.Substring(4, 2)) : 0;
                    int day = (length >= 8) ? Convert.ToInt32(messageDate.Substring(6, 2)) : 0;
                    int hour = (length >= 10) ? Convert.ToInt32(messageDate.Substring(8, 2)) : 0;
                    int minute = (length >= 12) ? Convert.ToInt32(messageDate.Substring(10, 2)) : 0;

                    result = new DateTime(year, month, day, hour, minute, 00).ToString(format);
                }

                return result;
            }
            catch (Exception ex)
            {
                _logger.LogInformation($"invalid date {messageDate}.  Ex: {ex.Message}");
                return null;
            }
        }
    }
}