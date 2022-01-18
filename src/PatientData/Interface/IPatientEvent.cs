using care.ai.cloud.functions.src.HL7;
using System.Threading.Tasks;

namespace care.ai.cloud.functions.src.PatientData
{
    public interface IPatientEvent
    {
        IEvent Event { get; set; }
        IEventData EventData { get; set; }
        string EventId { get; set; }
        string Tenant { get; set; }
        string Time { get; set; }

        Task<IPatientEvent> CreateAsync(IHL7_Message message);
    }
}