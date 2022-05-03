using Newtonsoft.Json;
namespace HL7Parser
{
	public partial class Mappings {
		/// <summary>
		/// The MSA segment contains information sent while acknowledging another message.
		/// </summary>
		public class MSA {

			 public const string Id = "MSA";

						/// <summary>
			/// MSA.1 - This field contains an acknowledgment code, see message processing rules. Refer to HL7 Table 0008 - Acknowledgment Code for valid values.
			/// </summary>
			public class AcknowledgmentCode : HL7Base<AcknowledgmentCode>
			{

				private const string _id = "MSA.1";
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
			/// MSA.2 - This field contains the message control ID of the message sent by the sending system. It allows the sending system to associate this response with the message for which it is intended.
			/// </summary>
			public class MessageControlId : HL7Base<MessageControlId>
			{

				private const string _id = "MSA.2";
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
			/// MSA.3 - Attention The MSA-3 was deprecated as of v 2.4 and the detail was withdrawn and removed from the standard as of v 2.7. The reader is referred to the ERR segment. The ERR segment allows for richer descriptions of the erroneous conditions.
			/// </summary>
			public class TextMessage : HL7Base<TextMessage>
			{

				private const string _id = "MSA.3";
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
			/// MSA.4 - This optional numeric field is used in the sequence number protocol.
			/// </summary>
			public class ExpectedSequenceNumber : HL7Base<ExpectedSequenceNumber>
			{

				private const string _id = "MSA.4";
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
			/// MSA.5 - Attention The MSA-5 was deprecated as of v2.2 and the detail was withdrawn and removed from the standard as of v 2.5.
			/// </summary>
			public class DelayedAcknowledgmentType : HL7Base<DelayedAcknowledgmentType>
			{

				private const string _id = "MSA.5";
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
			/// MSA.6 - Attention The MSA-3 was deprecated as of v 2.4 and the detail was withdrawn and removed from the standard as of v 2.7. The reader is referred to the ERR segment. The ERR segment allows for richer descriptions of the erroneous conditions.
			/// </summary>
			public class ErrorCondition : HL7Base<ErrorCondition>
			{

				private const string _id = "MSA.6";
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
			/// MSA.7 - If present, indicates that the Sending Application has messages waiting on a queue for the Receiving Application. These messages would then need to be retrieved via a query. This facilitates receiving applications that cannot receive unsolicited messages (i.e., polling). The code specified identifies how important the most important waiting message is (and may govern how soon the receiving application is required to poll for the message).For example, if there are 3 low priority messages, 1 medium priority message and 1 high priority message, the message waiting priority would be 'high', because that is the highest priority of any message waiting.With some applications, there is no guarantee that the sending application will be running. The receiving application is therefore unable to submit unsolicited messages. To mitigate this, a polling approach is used where the receiving application requests any queued messages when it is connected. To avoid the network overhead of continuous polling, the sending application needs a way to indicate that there are queued messages awaiting retrieval. It is also useful to provide an indication of the importance of those messages to indicate how quickly they should be retrieved.Refer to HL7 Table 0520 - Message Waiting Priority for valid values.See MSA-7 above for Use Case.
			/// </summary>
			public class MessageWaitingNumber : HL7Base<MessageWaitingNumber>
			{

				private const string _id = "MSA.7";
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
			/// MSA.8 - If present, indicates that the Sending Application has messages waiting on a queue for the Receiving Application. These messages would then need to be retrieved via a query. This facilitates receiving applications that cannot receive unsolicited messages (i.e., polling). The code specified identifies how important the most important waiting message is (and may govern how soon the receiving application is required to poll for the message).For example, if there are 3 low priority messages, 1 medium priority message and 1 high priority message, the message waiting priority would be 'high', because that is the highest priority of any message waiting.With some applications, there is no guarantee that the sending application will be running. The receiving application is therefore unable to submit unsolicited messages. To mitigate this, a polling approach is used where the receiving application requests any queued messages when it is connected. To avoid the network overhead of continuous polling, the sending application needs a way to indicate that there are queued messages awaiting retrieval. It is also useful to provide an indication of the importance of those messages to indicate how quickly they should be retrieved.Refer to HL7 Table 0520 - Message Waiting Priority for valid values.See MSA-7 above for Use Case.
			/// </summary>
			public class MessageWaitingPriority : HL7Base<MessageWaitingPriority>
			{

				private const string _id = "MSA.8";
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

