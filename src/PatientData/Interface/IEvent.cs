using care.ai.cloud.functions.src.HL7;

namespace care.ai.cloud.functions.src.PatientData
{
    /// <summary>
    /// IEvent Interface.
    /// </summary>
    public interface IEvent
    {
        /// <summary>
        /// Event Code.
        /// </summary>
        string Code { get; set; }
        /// <summary>
        /// Display Name.
        /// </summary>
        string DisplayName { get; set; }
        /// <summary>
        /// Event Factory Method.
        /// </summary>
        /// <param name="message">IHL7_Message object.</param>
        /// <returns>IEvent object.</returns>
        IEvent Factory(IHL7_Message message);
    }
}