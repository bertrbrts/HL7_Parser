using HL7Parser.HL7;

namespace HL7Parser.PatientData
{

    /// <summary>
    /// IPoc Interface.
    /// </summary>
    public interface IPoc
    {
        /// <summary>
        /// External Facility ID.
        /// </summary>
        string ExternalFacilityId { get; set; }
        /// <summary>
        /// External Location ID.
        /// </summary>
        string ExternalLocationId { get; set; }
        /// <summary>
        /// External Zone ID.
        /// </summary>
        string ExternalZoneId { get; set; }
        /// <summary>
        /// External Bed ID.
        /// </summary>
        string ExternalBedId { get; set; }

        /// <summary>
        /// IPoc Factory Method.
        /// </summary>
        /// <param name="message">IHL7_Message object.</param>
        /// <returns>IPoc object.</returns>
        IPoc Factory(IHL7_Message message);
    }
}