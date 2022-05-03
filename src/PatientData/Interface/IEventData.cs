using HL7Parser.HL7;

namespace HL7Parser.PatientData
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
        /// <returns></returns>
        IEventData Factory(IHL7_Message message);
    }
}