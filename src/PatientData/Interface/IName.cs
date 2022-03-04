using care.ai.cloud.functions.src.HL7;

namespace care.ai.cloud.functions.src.PatientData
{
    /// <summary>
    /// IName Interface.
    /// </summary>
    public interface IName
    {
        public string First { get; set; }
        public string Last { get; set; }
        public string Middle { get; set; }
        /// <summary>
        /// IName Factory Method.
        /// </summary>
        /// <param name="message">IHL7_Message object.</param>
        /// <returns>IName object.</returns>
        IName Factory(IHL7_Message message);
    }
}