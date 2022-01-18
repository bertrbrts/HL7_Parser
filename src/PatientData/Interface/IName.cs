using care.ai.cloud.functions.src.HL7;

namespace care.ai.cloud.functions.src.PatientData
{
    public interface IName
    {
        IName Create(IHL7_Message message);
    }
}