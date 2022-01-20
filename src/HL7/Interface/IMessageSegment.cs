namespace care.ai.cloud.functions.src.HL7
{
    public interface IMessageSegment
    {
        object ETag { get; set; }
        IMessageFields Fields { get; set; }
        string SegmentID { get; set; }
        object SetId { get; set; }
    }
}