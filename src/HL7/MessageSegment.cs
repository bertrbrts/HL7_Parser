using Newtonsoft.Json;

namespace care.ai.cloud.functions.src.HL7
{
    public class MessageSegment : IMessageSegment
    {
        [JsonProperty("fields")]
        public IMessageFields Fields { get; set; }
        [JsonProperty("segmentId")]
        public string SegmentID { get; set; }
        [JsonProperty("setId")]
        public object SetId { get; set; }
        [JsonProperty("ETag")]
        public object ETag { get; set; }
    }
}