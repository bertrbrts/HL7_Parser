using Google.Apis.CloudHealthcare.v1.Data;
using System.Collections.Generic;

namespace HL7Parser.HL7
{
    /// <summary>
    /// IHL7_Message Interface.
    /// </summary>
    public interface IHL7_Message
    {
        /// <summary>
        /// ETag.
        /// </summary>
        string ETag { get; set; }
        /// <summary>
        /// Segments List.
        /// </summary>
        IList<Segment> Segments { get; set; }
        /// <summary>
        /// IHL7_Message Factory Method.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        IHL7_Message Factory(string message);
        /// <summary>
        /// Get Value From Key.
        /// </summary>
        /// <param name="strValueFormat">Key.</param>
        /// <returns>string value.</returns>
        string GetValue(string strValueFormat);
    }
}