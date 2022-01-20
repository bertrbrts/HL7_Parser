using care.ai.cloud.functions.src.HL7;

namespace care.ai.cloud.functions.src.PatientData
{
    /// <summary>
    /// IPatient Interface.
    /// </summary>
    public interface IPatient
    {
        /// <summary>
        /// IAddress object.
        /// </summary>
        IAddress Address { get; set; }
        /// <summary>
        /// Patient Admit Date.
        /// </summary>
        string AdmitDate { get; set; }
        /// <summary>
        /// Patient Admission Reason.
        /// </summary>
        string AdmitReason { get; set; }
        /// <summary>
        /// Patient Birth Date.
        /// </summary>
        string Birthdate { get; set; }
        /// <summary>
        /// Patient Discharge Date.
        /// </summary>
        string DischargedDate { get; set; }
        /// <summary>
        /// Patient Gender.
        /// </summary>
        string Gender { get; set; }
        /// <summary>
        /// Patient Medical Record Number (MRN).
        /// </summary>
        string Mrn { get; set; }
        /// <summary>
        /// IName object.
        /// </summary>
        IName Name { get; set; }
        /// <summary>
        /// Patient ID.
        /// </summary>
        string PatientId { get; set; }
        /// <summary>
        /// Patient Phone.
        /// </summary>
        string Phone { get; set; }
        /// <summary>
        /// IPoc object.
        /// </summary>
        IPoc Poc { get; set; }
        /// <summary>
        /// Patient Type.
        /// </summary>
        string Type { get; set; }
        /// <summary>
        /// IPatient Factory Method.
        /// </summary>
        /// <param name="message">IHL7_Message object.</param>
        /// <param name="tenantName">Tenant Name.</param>
        /// <returns>IPatient object.</returns>
        IPatient Factory(IHL7_Message message, string tenantName);
    }
}