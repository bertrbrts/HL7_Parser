using HL7Parser.HL7;

namespace HL7Parser.PatientData
{
    /// <summary>
    /// IAddress Interface.
    /// </summary>
    public interface IAddress
    {
        /// <summary>
        /// IAddress Factory Method.
        /// </summary>
        /// <param name="message">IHL7_Message object.</param>
        /// <returns>IAddress object.</returns>
        IAddress Factory(IHL7_Message message);
    }
}