using Newtonsoft.Json;
namespace care.ai.cloud.functions.hl7
{
	public partial class Mappings {
		/// <summary>
		/// The ADD segment is used to define the continuation of the prior segment in a continuation message. See Section 2.10.2, "Continuation messages and segments," for details.
		/// </summary>
		public class ADD {

			 public const string Id = "ADD";

						/// <summary>
			/// ADD.1 - This field is used to define the continuation of the prior segment in a continuation message. See section 2.10.2, "Continuation messages and segments" for details. When the ADD is sent after the segment being continued, it contains no fields. It is only a marker that the previous segment is being continued in a subsequent message. Thus fields 1-N are not present. The sequence designation, 1-N, means the remainder of the fields in the segment being continued. These remainder of the segment being continued fields are present only when the ADD is sent with a continuation message.
			/// </summary>
			public class AddendumContinuationPointer : HL7Base<AddendumContinuationPointer>
			{

				private const string _id = "ADD.1";
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

