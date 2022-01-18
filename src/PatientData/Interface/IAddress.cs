using care.ai.cloud.functions.src.HL7;

namespace care.ai.cloud.functions.src.PatientData
{
    public interface IAddress
    {
        IAddress Create(IHL7_Message message);
    }
}