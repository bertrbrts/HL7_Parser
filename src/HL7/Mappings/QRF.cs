using Newtonsoft.Json;
namespace HL7Parser
{
	public partial class Mappings {
		/// <summary>
		/// 
		/// </summary>
		public class QRF {

			 public const string Id = "QRF";

						/// <summary>
			/// QRF.1 - 
			/// </summary>
			public class QRF1 : HL7Base<QRF1>
			{

				private const string _id = "QRF.1";
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

