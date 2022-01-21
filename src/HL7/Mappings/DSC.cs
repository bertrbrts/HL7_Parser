using Newtonsoft.Json;
namespace care.ai.cloud.functions.hl7
{
	public partial class Mappings {
		/// <summary>
		/// The DSC segment is used in the continuation protocol.
		/// </summary>
		public class DSC {

			 public const string Id = "DSC";

						/// <summary>
			/// DSC.1 - This field contains the continuation pointer. In an initial query, this field is not present. If the responder returns a value of null or not present, then there is no more data to fulfill any future continuation requests. For use with continuations of unsolicited messages, see chapter 5 and section 2.10.2, "Continuation messages and segments." Note that continuation protocols work with both display- and record-oriented messages.
			/// </summary>
			public class ContinuationPointer : HL7Base<ContinuationPointer>
			{

				private const string _id = "DSC.1";
				public override string Id
				{
					get { return _id; }
				}

				private readonly bool[] _repeatableHierarchy = {false, true};
				public override bool[] RepeatableHierarchy
				{
					get { return _repeatableHierarchy; }
				}

			}

						/// <summary>
			/// DSC.2 - Indicates whether this is a fragmented message (see Section 2.10.2, "Continuation messages and segments"), or if it is part of an interactive continuation message (see Section 5.6.3, "Interactive continuation of response messages").
			/// </summary>
			public class ContinuationStyle : HL7Base<ContinuationStyle>
			{

				private const string _id = "DSC.2";
				public override string Id
				{
					get { return _id; }
				}

				private readonly bool[] _repeatableHierarchy = {false, true};
				public override bool[] RepeatableHierarchy
				{
					get { return _repeatableHierarchy; }
				}

			}

		  }
	}
}

