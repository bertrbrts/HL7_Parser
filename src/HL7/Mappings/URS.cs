using Newtonsoft.Json;
namespace HL7Parser
{
	public partial class Mappings {
		/// <summary>
		/// 
		/// </summary>
		public class URS {

			 public const string Id = "URS";

						/// <summary>
			/// URS.1 - 
			/// </summary>
			public class URS1 : HL7Base<URS1>
			{

				private const string _id = "URS.1";
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

