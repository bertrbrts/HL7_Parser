using Newtonsoft.Json;
namespace care.ai.cloud.functions.hl7
{
	public partial class Mappings {
		/// <summary>
		/// This segment contains the information about quantities that are derived from one or more other quantities or direct observations by mathematical or logical means.
		/// </summary>
		public class OM6 {

			 public const string Id = "OM6";

						/// <summary>
			/// OM6.1 - This field contains the same value as the sequence number of the associated OM1 segment.
			/// </summary>
			public class SequenceNumberTestObservationMasterFile : HL7Base<SequenceNumberTestObservationMasterFile>
			{

				private const string _id = "OM6.1";
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
			/// OM6.2 - This field contains the observations whose categorical responses are taken from a specified table of codes (e.g., CWE data types).  Record the preferred coding system for this observation (e.g., ICD9, SNOMED III).  Take the codes from ASTM Table 3 or 5, or specify a local code.
			/// </summary>
			public class DerivationRule : HL7Base<DerivationRule>
			{

				private const string _id = "OM6.2";
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

