using Newtonsoft.Json;
namespace care.ai.cloud.functions.hl7
{
	public partial class Mappings {
		/// <summary>
		/// The BTS segment defines the end of a batch.
		/// </summary>
		public class BTS {

			 public const string Id = "BTS";

						/// <summary>
			/// BTS.1 - This field contains the count of the individual messages contained within the batch.
			/// </summary>
			public class BatchMessageCount : HL7Base<BatchMessageCount>
			{

				private const string _id = "BTS.1";
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
			/// BTS.2 - This field is a comment field that is not further defined in the HL7 protocol.
			/// </summary>
			public class BatchComment : HL7Base<BatchComment>
			{

				private const string _id = "BTS.2";
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
			/// BTS.3 - We encourage new users of this field to use the HL7 Version 2.3 data type of NM and to define it as "repeating." This field contains the batch total. If more than a single batch total exists, this field may be repeated.Prior to v2.5 this field may have been defined as a CM data type for backward compatibility with HL7 Versions 2.2 and 2.1 with each total being carried as a separate component. Each component in this case is an NM data type.
			/// </summary>
			public class BatchTotals : HL7Base<BatchTotals>
			{

				private const string _id = "BTS.3";
				public override string Id
				{
					get { return _id; }
				}

				private readonly bool[] _repeatableHierarchy = {false, false};
				public override bool[] RepeatableHierarchy
				{
					get { return _repeatableHierarchy; }
				}

			}

		  }
	}
}

