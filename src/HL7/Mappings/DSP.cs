using Newtonsoft.Json;
namespace care.ai.cloud.functions.hl7
{
	public partial class Mappings {
		/// <summary>
		/// The DSP segment is used to contain data that has been preformatted by the sender for display.  The semantic content of the data is lost the data is simply treated as lines of text. 
		/// </summary>
		public class DSP {

			 public const string Id = "DSP";

						/// <summary>
			/// DSP.1 - This field is used optionally to number multiple display segments
			/// </summary>
			public class SetIdDsp : HL7Base<SetIdDsp>
			{

				private const string _id = "DSP.1";
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
			/// DSP.2 - This field contains numbering to define groups of fields as assigned by the individual sites or applications.
			/// </summary>
			public class DisplayLevel : HL7Base<DisplayLevel>
			{

				private const string _id = "DSP.2";
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
			/// DSP.3 - This field contains an actual line as it should be displayed.  As described for the TX data type, highlighting and other special display characteristics may be included.
			/// </summary>
			public class DataLine : HL7Base<DataLine>
			{

				private const string _id = "DSP.3";
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
			/// DSP.4 - This field is non-null if this line is the last line of a logical break point in the response as defined by the responding system.Often the lines of display text will fall into logical groups that differ from the physical size of a screen or printer page.  For example, a complete battery or an entire radiology report might be thought of as comprising a logical group, though it might have as few as six or as many as 120 lines.  Knowledge of the logical break points in the display data can be useful to the application system that is displaying or printing data.  For this reason, DSP-4-Logical break point is used.  The sending application (the one that formats the data) places the logical break points where appropriate.  If there is a particular ancillary result ID associated with the data delineated by DSP-4-Logical break point, the value of this ID also can be returned in DSP-5-Result ID.  Then if the user selects the area of the display delineated by DSP-4-Logical break point, the displaying system can query for the associated DSP-5-Result ID.
			/// </summary>
			public class LogicalBreakPoint : HL7Base<LogicalBreakPoint>
			{

				private const string _id = "DSP.4";
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
			/// DSP.5 - When the user selects a result ID (defined by DSP-4-Logical break point) from the screen display corresponding to a record in which DSP-5-Result ID is non-null, the application can initiate a second query (a separate session) to the ancillary with the QRD-10-What department data code filled in with this non-null value (e.g., the ancillary accession number or its equivalent).  The ancillary response will contain the report referenced by this result ID (e.g., accession number).  The ancillary should correlate the result ID with DSP-4-Logical break point as follows If more than one line of text is sent per result, DSP-5-Result ID should be only non-null for a DSP segment that contains a non-null DSP-4-Logical break point.  This field may be broken into components by local agreement.  A common example might be to include placer order number, filler order number, and universal service identifier.  Whenever such fields are used as components of the result ID, their components will be sent as subcomponents.
			/// </summary>
			public class ResultId : HL7Base<ResultId>
			{

				private const string _id = "DSP.5";
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

