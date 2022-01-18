namespace care.ai.cloud.functions.src.HL7
{
    public class MessageSegment : IMessageSegment
    {
        public IMessageFields fields { get; set; }
        public string segmentId { get; set; }
        public object setId { get; set; }
        public object ETag { get; set; }
    }
}