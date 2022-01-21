using Newtonsoft.Json;
namespace care.ai.cloud.functions.hl7
{
	public partial class Mappings {
		/// <summary>
		/// The FTS segment defines the end of a file.
		/// </summary>
		public class FTS {

			 public const string Id = "FTS";

						/// <summary>
			/// FTS.1 - This field contains the number of batches contained in this file.
			/// </summary>
			public class FileBatchCount : HL7Base<FileBatchCount>
			{

				private const string _id = "FTS.1";
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
			/// FTS.2 - The use of this free text field is not further specified.
			/// </summary>
			public class FileTrailerComment : HL7Base<FileTrailerComment>
			{

				private const string _id = "FTS.2";
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

