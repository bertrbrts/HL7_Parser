using HL7Parser.HL7;

namespace HL7Parser.PatientData
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