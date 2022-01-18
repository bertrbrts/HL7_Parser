using care.ai.cloud.functions.src.HL7;

namespace care.ai.cloud.functions.src.PatientData
{
    public interface IEvent
    {
        string Code { get; set; }
        string DisplayName { get; set; }

        IEvent Create(IHL7_Message message);
    }
}