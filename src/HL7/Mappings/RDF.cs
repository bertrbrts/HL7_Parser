using Newtonsoft.Json;
namespace care.ai.cloud.functions.hl7
{
	public partial class Mappings {
		/// <summary>
		/// The RDF segment defines the content of the row data segments (RDT) in the tabular response (RTB). - As an optional segment in a query either a QBP or QBS, this segment can be used to limit the number of columns returned and to specify what column positions the fields occupy (where supported, these features can be used to override the defaults for the particular query).  If omitted, all fields defined for the query are returned in their default column order. - As a required segment in a tabular response (RTB) to either a QBP or QBS, this segment defines the contents of the table row data (RDT) segments that follows. It is not necessarily an echo back of the segment as it appeared in the query.
		/// </summary>
		public class RDF {

			 public const string Id = "RDF";

						/// <summary>
			/// RDF.1 - This field specifies the number of data columns (and therefore the number of fields) contained within each row of returned data.
			/// </summary>
			public class NumberOfColumnsPerRow : HL7Base<NumberOfColumnsPerRow>
			{

				private const string _id = "RDF.1";
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
			/// RDF.2 - Each repetition of this field consists of three componentsThe segment field name that identifies the field occupying the column.  The segment field name SHALL agree with the column name as it appears in the Query Profile. Use of the  sign as prefix to the column name is optional. - The 2 or 3 character HL7 data type, as defined in Chapter 2.  Refer to HL7 Table 0440 - Data types in Chapter 2C, Code Tables, for valid values. - The maximum width of the column, as dictated by the responding system.  (This may vary from the HL7-defined maximum field length.)
			/// </summary>
			public class ColumnDescription : HL7Base<ColumnDescription>
			{

				private const string _id = "RDF.2";
				public override string Id
				{
					get { return _id; }
				}

				private readonly bool[] _repeatableHierarchy = {false, false};
				public override bool[] RepeatableHierarchy
				{
					get { return _repeatableHierarchy; }
				}

								/// <summary>
				/// RDF.2.1 - The HL7 segment field name, which identifies the field occupying the columnNaming conventionsSegment field names are designated by the  symbol concatenated with the HL7 segment ID followed by the sequence number for the field separated by a period. See sections 2.5.2, "Segments and segment groups" and 2.5.3.1, "Position (sequence within the segment)" for a definition of segment ID and sequence number. If the field is divided into components, the designation may be suffixed with ".nn", to identify a particular component (a suffix of .3 indicates the third component of the field) otherwise, the whole field is assumed. If the field is further divided into subcomponents, the designation is suffixed with .nn.mm", which identifies the component and subcomponent requested by relative position.Site-specific segment field names may be used. In this case, the site-specific segment ID (if the field is not being added to an existing HL7 segment) and the sequence number must be defined so that they do not conflict with existing HL7 segment IDs and field sequence numbers.Values for this field are defined in the function-specific chapters of this specification.Note If the  is being used as one of the delimiter characters defined in MSH-2-encoding characters, it must be escaped.  See Section 2.7.1, "Formatting Codes".
				/// </summary>
				public class SegmentFieldName : HL7Base<SegmentFieldName>
				{

					private const string _id = "RDF.2.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// RDF.2.2 - The two or three character HL7 data type. Refer to HL7 Table 0440  Data Types for valid values.
				/// </summary>
				public class Hl7DataType : HL7Base<Hl7DataType>
				{

					private const string _id = "RDF.2.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// RDF.2.3 - The maximum width of the column, as dictated by the responding system. This may vary from the HL7-defined maximum field length.
				/// </summary>
				public class MaximumColumnWidth : HL7Base<MaximumColumnWidth>
				{

					private const string _id = "RDF.2.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

			}

		  }
	}
}

