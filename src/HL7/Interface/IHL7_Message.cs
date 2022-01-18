using Google.Apis.CloudHealthcare.v1.Data;
using System.Collections.Generic;

namespace care.ai.cloud.functions.src.HL7
{
    public interface IHL7_Message
    {
        string ETag { get; set; }
        IList<Segment> Segments { get; set; }
        IHL7_Message Create(string message);

        string GetValue(string strValueFormat);
    }
}