using care.ai.cloud.functions.src.HL7;

namespace care.ai.cloud.functions.src.PatientData
{
    public interface IPatient
    {
        IAddress Address { get; set; }
        string AdmitDate { get; set; }
        string AdmitReason { get; set; }
        string Birthdate { get; set; }
        string DischargedDate { get; set; }
        string Gender { get; set; }
        string Mrn { get; set; }
        IName Name { get; set; }
        string PatientId { get; set; }
        string Phone { get; set; }
        IPoc Poc { get; set; }
        string Type { get; set; }

        IPatient Create(IHL7_Message message);
    }
}