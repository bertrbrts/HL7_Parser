namespace care.ai.cloud.functions.src.HL7
{
    public interface IMessageSegment
    {
        object ETag { get; set; }
        IMessageFields fields { get; set; }
        string segmentId { get; set; }
        object setId { get; set; }
    }
}