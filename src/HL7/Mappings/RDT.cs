using Newtonsoft.Json;
namespace HL7Parser
{
	public partial class Mappings {
		/// <summary>
		/// The RDT segment contains the row data of the tabular data response message (TBR).
		/// </summary>
		public class RDT {

			 public const string Id = "RDT";

						/// <summary>
			/// RDT.1 - This field is a requested field.  Fields occur in the position order defined for the query or table (unless overridden by an optional RDF segment on a stored procedure request or Virtual Table query message), separated by field delimiters.
			/// </summary>
			public class ColumnValue : HL7Base<ColumnValue>
			{

				private const string _id = "RDT.1";
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

