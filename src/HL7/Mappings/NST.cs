using Newtonsoft.Json;
namespace HL7Parser
{
	public partial class Mappings {
		/// <summary>
		/// The NST segment allows application control-level statistical information to be passed between the various systems on the network.  Some fields in this segment refer to portions of lower level protocols they contain information that can be used by application management applications monitoring the state of various network links. Usage Notes Fields 2-15.  These are all marked optional since the statistics kept on a particular link and negotiated between the two systems in question will vary.  Not all values will apply to each system.  Some values are concerned with the type of port, and some values pertain to the lower level protocol.
		/// </summary>
		public class NST {

			 public const string Id = "NST";

						/// <summary>
			/// NST.1 - This field indicates the availability of statistics. Refer to HL7 Table 0136 - Yes/no Indicator for valid values.  N - the responding application does not keep any statistics.  If the value "N" is specified, the response message is used to signify to the initiating application that the communication link between the initiating application and the responding application is operational (and fields 2 15 are empty in the response message).  Y - the responding application does keep statistics, fields 4 and 5 are required (and the response message contains one or more non null fields in the range 2 3, 6 15). 
			/// </summary>
			public class StatisticsAvailable : HL7Base<StatisticsAvailable>
			{

				private const string _id = "NST.1";
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
			/// NST.2 - This field identifies a particular lower level link (e.g., a port number). 
			/// </summary>
			public class SourceIdentifier : HL7Base<SourceIdentifier>
			{

				private const string _id = "NST.2";
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
			/// NST.3 - This field identifies (in certain systems) whether a lower level source identifier is an initiate or accept type.   Refer to HL7 Table 0332  Source Type in Chapter 2C, Code Tables, for valid values.
			/// </summary>
			public class SourceType : HL7Base<SourceType>
			{

				private const string _id = "NST.3";
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
			/// NST.4 - This field contains the date/time stamp of the start of the collection of the statistics reported in fields 6 15 of this segment.  It is strongly recommended that this value include seconds. 
			/// </summary>
			public class StatisticsStart : HL7Base<StatisticsStart>
			{

				private const string _id = "NST.4";
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
			/// NST.5 - This field contains the date/time stamp of the end of the statistics collection period reported in fields 6 15 of this segment.  It is strongly recommended that this value include seconds. 
			/// </summary>
			public class StatisticsEnd : HL7Base<StatisticsEnd>
			{

				private const string _id = "NST.5";
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
			/// NST.6 - This field contains the number of characters received. 
			/// </summary>
			public class ReceiveCharacterCount : HL7Base<ReceiveCharacterCount>
			{

				private const string _id = "NST.6";
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
			/// NST.7 - This field contains the number of characters sent. 
			/// </summary>
			public class SendCharacterCount : HL7Base<SendCharacterCount>
			{

				private const string _id = "NST.7";
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
			/// NST.8 - This field contains the number of messages received. 
			/// </summary>
			public class MessagesReceived : HL7Base<MessagesReceived>
			{

				private const string _id = "NST.8";
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
			/// NST.9 - This field contains the number of messages sent. 
			/// </summary>
			public class MessagesSent : HL7Base<MessagesSent>
			{

				private const string _id = "NST.9";
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
			/// NST.10 - This field contains the number of messages received with checksum errors. 
			/// </summary>
			public class ChecksumErrorsReceived : HL7Base<ChecksumErrorsReceived>
			{

				private const string _id = "NST.10";
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
			/// NST.11 - This field contains the number of messages received with length errors. 
			/// </summary>
			public class LengthErrorsReceived : HL7Base<LengthErrorsReceived>
			{

				private const string _id = "NST.11";
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
			/// NST.12 - This field contains the number of "other" invalid messages received (excluding length and checksum errors). 
			/// </summary>
			public class OtherErrorsReceived : HL7Base<OtherErrorsReceived>
			{

				private const string _id = "NST.12";
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
			/// NST.13 - This field contains the number of connect timeout errors. 
			/// </summary>
			public class ConnectTimeouts : HL7Base<ConnectTimeouts>
			{

				private const string _id = "NST.13";
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
			/// NST.14 - This field contains the number of timeouts while waiting for a response to an initiated message. 
			/// </summary>
			public class ReceiveTimeouts : HL7Base<ReceiveTimeouts>
			{

				private const string _id = "NST.14";
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
			/// NST.15 - This field contains the number of application control-level errors in response to an initiated message. 
			/// </summary>
			public class ApplicationControllevelErrors : HL7Base<ApplicationControllevelErrors>
			{

				private const string _id = "NST.15";
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

