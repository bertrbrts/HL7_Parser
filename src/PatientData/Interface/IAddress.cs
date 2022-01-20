using care.ai.cloud.functions.src.HL7;

namespace care.ai.cloud.functions.src.PatientData
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