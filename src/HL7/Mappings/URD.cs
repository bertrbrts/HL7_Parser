using Newtonsoft.Json;
namespace HL7Parser
{
	public partial class Mappings {
		/// <summary>
		/// 
		/// </summary>
		public class URD {

			 public const string Id = "URD";

						/// <summary>
			/// URD.1 - 
			/// </summary>
			public class URD1 : HL7Base<URD1>
			{

				private const string _id = "URD.1";
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

