using Newtonsoft.Json;
namespace care.ai.cloud.functions.hl7
{
	public partial class Mappings {
		/// <summary>
		/// 
		/// </summary>
		public class QRD {

			 public const string Id = "QRD";

						/// <summary>
			/// QRD.1 - 
			/// </summary>
			public class QRD1 : HL7Base<QRD1>
			{

				private const string _id = "QRD.1";
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

