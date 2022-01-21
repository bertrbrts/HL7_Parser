using Newtonsoft.Json;
namespace care.ai.cloud.functions.hl7
{
	public partial class Mappings {
		/// <summary>
		/// 
		/// </summary>
		public class RFI {

			 public const string Id = "RFI";

						/// <summary>
			/// RFI.1 - 
			/// </summary>
			public class RequestDate : HL7Base<RequestDate>
			{

				private const string _id = "RFI.1";
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
			/// RFI.2 - The latest date by which the additional information is to be returned to requestor.
			/// </summary>
			public class ResponseDueDate : HL7Base<ResponseDueDate>
			{

				private const string _id = "RFI.2";
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
			/// RFI.3 - Code indicating if the Payer has obtained patient consent for release of information (1)  Optional.  Refer to HL7 Table 0136  Yes/No Indicator for suggested values.
			/// </summary>
			public class PatientConsent : HL7Base<PatientConsent>
			{

				private const string _id = "RFI.3";
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
			/// RFI.4 - The date on which the information was assembled for transmission to the Payer.  Not necessarily the same as the message date.
			/// </summary>
			public class DateAdditionalInformationWasSubmitted : HL7Base<DateAdditionalInformationWasSubmitted>
			{

				private const string _id = "RFI.4";
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

