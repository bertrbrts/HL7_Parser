using Newtonsoft.Json;
namespace care.ai.cloud.functions.hl7
{
	public partial class Mappings {
		/// <summary>
		/// The NCK segment is used to allow the various applications on the network to synchronize their system clocks (system date and time).Usage Notes If this message is to be used to automatically reset/correct system clocks, it is recommended that the system or administrative personnel initiating the NMQ with the NCK segment have the authority to correct the clock (system date and time) for the other systems on the network.  This is important in order to avoid the obvious confusion of multiple systems attempting to resynchronize each other's clocks.If this message is used only to gather information on the various systems' clocks, it is still important for an administrative procedure to be worked out to avoid conflicts when resetting clocks.
		/// </summary>
		public class NCK {

			 public const string Id = "NCK";

						/// <summary>
			/// NCK.1 - This field contains an HL7 time stamp.  It is strongly recommended that seconds be included.  If the message contains an NST or NSC segment, the NCK segment is optional.  If the NCK segment is present, this field is required.  If present in the NMQ message, or the unsolicited NMD message, it contains the system date/time of the sending system.  If present in the NMR response message, it contains the responding system's date/time. 
			/// </summary>
			public class SystemDateTime : HL7Base<SystemDateTime>
			{

				private const string _id = "NCK.1";
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

