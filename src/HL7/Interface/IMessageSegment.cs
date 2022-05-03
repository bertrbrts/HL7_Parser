namespace HL7Parser.HL7
{
    /// <summary>
    /// IMessageSegment Interface.
    /// </summary>
    public interface IMessageSegment
    {
        /// <summary>
        /// ETag object.
        /// </summary>
        object ETag { get; set; }
        /// <summary>
        /// IMessageFields object.
        /// </summary>
        IMessageFields Fields { get; set; }
        /// <summary>
        /// Segment ID
        /// </summary>
        string SegmentID { get; set; }
        /// <summary>
        /// Set ID object.
        /// </summary>
        object SetId { get; set; }
    }
}