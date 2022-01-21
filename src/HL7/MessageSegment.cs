using Newtonsoft.Json;

namespace care.ai.cloud.functions.src.HL7
{
    /// <summary>
    /// Message Segment.
    /// </summary>
    public class MessageSegment : IMessageSegment
    {
        /// <summary>
        /// ETag object.
        /// </summary>
        [JsonProperty("ETag")]
        public object ETag { get; set; }
        /// <summary>
        /// IMessageFields object.
        /// </summary>
        [JsonProperty("fields")]
        public IMessageFields Fields { get; set; }
        /// <summary>
        /// Segment ID
        /// </summary>
        [JsonProperty("segmentId")]
        public string SegmentID { get; set; }
        /// <summary>
        /// Set ID object.
        /// </summary>
        [JsonProperty("setId")]
        public object SetId { get; set; }
    }
}