using care.ai.cloud.functions.src.HL7;

namespace care.ai.cloud.functions.src.PatientData
{
    /// <summary>
    /// IEventData Interface.
    /// </summary>
    public interface IEventData
    {
        /// <summary>
        /// IPatient object.
        /// </summary>
        IPatient Patient { get; set; }
        /// <summary>
        /// IEventData Factory Method.
        /// </summary>
        /// <param name="message">IHL7_Message object.</param>
        /// <param name="tenantName">Tenant Name</param>
        /// <returns></returns>
        IEventData Factory(IHL7_Message message, string tenantName);
    }
}