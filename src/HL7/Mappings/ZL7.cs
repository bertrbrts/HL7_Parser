using Newtonsoft.Json;
namespace care.ai.cloud.functions.hl7
{
	public partial class Mappings {
		/// <summary>
		/// 
		/// </summary>
		public class ZL7 {

			 public const string Id = "ZL7";

						/// <summary>
			/// ZL7.1 - 
			/// </summary>
			public class ZL71 : HL7Base<ZL71>
			{

				private const string _id = "ZL7.1";
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

