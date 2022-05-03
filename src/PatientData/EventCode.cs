namespace HL7Parser.PatientData
{
    /// <summary>
    /// Event Code Key Value Pair.
    /// </summary>
    public class EventCode
    {
        /// <summary>
        /// Event Code Key.
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// Event Code Value.
        /// </summary>
        public string Value { get; set; }
        /// <summary>
        /// Event Code Display Name
        /// </summary>
        public string DisplayName { get;set; }
    }
}