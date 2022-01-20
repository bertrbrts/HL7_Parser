using care.ai.cloud.functions.src.HL7;
using System.Threading.Tasks;

namespace care.ai.cloud.functions.src.PatientData
{
    /// <summary>
    /// IPatientEvent Interface.
    /// </summary>
    public interface IPatientEvent
    {
        /// <summary>
        /// IEvent object.
        /// </summary>
        IEvent Event { get; set; }
        /// <summary>
        /// IEventData object.
        /// </summary>
        IEventData EventData { get; set; }
        /// <summary>
        /// Patient Event ID.
        /// </summary>
        string EventId { get; set; }
        /// <summary>
        /// Tenant Name.
        /// </summary>
        string Tenant { get; set; }
        /// <summary>
        /// Patient Event Time.
        /// </summary>
        string Time { get; set; }
        /// <summary>
        /// IPatientEvent Async Factory Method.
        /// </summary>
        /// <param name="message">IHL7_Message object.</param>
        /// <returns>Task<IPatientEvent></returns>
        Task<IPatientEvent> FactoryAsync(IHL7_Message message);
    }
}