using care.ai.cloud.functions.src.HL7;

namespace care.ai.cloud.functions.src.PatientData
{
    public interface IEventData
    {
        IPatient Patient { get; set; }

        IEventData Create(IHL7_Message message, string tenantName);
    }
}