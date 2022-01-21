using Newtonsoft.Json;
namespace care.ai.cloud.functions.hl7
{
	public partial class Mappings {
		/// <summary>
		/// The BHS segment defines the start of a batch.
		/// </summary>
		public class BHS {

			 public const string Id = "BHS";

						/// <summary>
			/// BHS.1 - This field contains the separator between the segment ID and the first real field, BHS-2 Batch Encoding Characters. As such it serves as the separator and defines the character to be used as a separator for the rest of the message. Recommended value is  (ASCII 124).
			/// </summary>
			public class BatchFieldSeparator : HL7Base<BatchFieldSeparator>
			{

				private const string _id = "BHS.1";
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
			/// BHS.2 - This field contains the four characters in the following order the component separator, repetition separator, escape characters, and subcomponent separator. Recommended values are & (ASCII 94, 126, 92, and 38, respectively). See Section 2.5.4, "Message delimiters."
			/// </summary>
			public class BatchEncodingCharacters : HL7Base<BatchEncodingCharacters>
			{

				private const string _id = "BHS.2";
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
			/// BHS.3 - This field uniquely identifies the sending application among all other applications within the network enterprise. The network enterprise consists of all those applications that participate in the exchange of HL7 messages within the enterprise. Entirely site-defined.
			/// </summary>
			public class BatchSendingApplication : HL7Base<BatchSendingApplication>
			{

				private const string _id = "BHS.3";
				public override string Id
				{
					get { return _id; }
				}

				private readonly bool[] _repeatableHierarchy = {false, true};
				public override bool[] RepeatableHierarchy
				{
					get { return _repeatableHierarchy; }
				}

								/// <summary>
				/// BHS.3.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
				/// </summary>
				public class NamespaceId : HL7Base<NamespaceId>
				{

					private const string _id = "BHS.3.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// BHS.3.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
				/// </summary>
				public class UniversalId : HL7Base<UniversalId>
				{

					private const string _id = "BHS.3.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// BHS.3.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
				/// </summary>
				public class UniversalIdType : HL7Base<UniversalIdType>
				{

					private const string _id = "BHS.3.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

			}

						/// <summary>
			/// BHS.4 - This field contains the address of one of several occurrences of the same application within the sending system. Absent other considerations, the Medicare Provider ID might be used with an appropriate sub-identifier in the second component. Entirely site-defined.
			/// </summary>
			public class BatchSendingFacility : HL7Base<BatchSendingFacility>
			{

				private const string _id = "BHS.4";
				public override string Id
				{
					get { return _id; }
				}

				private readonly bool[] _repeatableHierarchy = {false, true};
				public override bool[] RepeatableHierarchy
				{
					get { return _repeatableHierarchy; }
				}

								/// <summary>
				/// BHS.4.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
				/// </summary>
				public class NamespaceId : HL7Base<NamespaceId>
				{

					private const string _id = "BHS.4.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// BHS.4.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
				/// </summary>
				public class UniversalId : HL7Base<UniversalId>
				{

					private const string _id = "BHS.4.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// BHS.4.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
				/// </summary>
				public class UniversalIdType : HL7Base<UniversalIdType>
				{

					private const string _id = "BHS.4.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

			}

						/// <summary>
			/// BHS.5 - This field uniquely identifies the receiving applications among all other applications within the network enterprise. The network enterprise consists of all those applications that participate in the exchange of HL7 messages within the enterprise. Entirely site-defined.
			/// </summary>
			public class BatchReceivingApplication : HL7Base<BatchReceivingApplication>
			{

				private const string _id = "BHS.5";
				public override string Id
				{
					get { return _id; }
				}

				private readonly bool[] _repeatableHierarchy = {false, true};
				public override bool[] RepeatableHierarchy
				{
					get { return _repeatableHierarchy; }
				}

								/// <summary>
				/// BHS.5.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
				/// </summary>
				public class NamespaceId : HL7Base<NamespaceId>
				{

					private const string _id = "BHS.5.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// BHS.5.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
				/// </summary>
				public class UniversalId : HL7Base<UniversalId>
				{

					private const string _id = "BHS.5.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// BHS.5.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
				/// </summary>
				public class UniversalIdType : HL7Base<UniversalIdType>
				{

					private const string _id = "BHS.5.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

			}

						/// <summary>
			/// BHS.6 - This field identifies the receiving application among multiple identical instances of the application running on behalf of different organizations. See comments 2.14.2.4, "BHS-4 Batch Sending Facility (HD) 00084." Entirely site-defined.
			/// </summary>
			public class BatchReceivingFacility : HL7Base<BatchReceivingFacility>
			{

				private const string _id = "BHS.6";
				public override string Id
				{
					get { return _id; }
				}

				private readonly bool[] _repeatableHierarchy = {false, true};
				public override bool[] RepeatableHierarchy
				{
					get { return _repeatableHierarchy; }
				}

								/// <summary>
				/// BHS.6.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
				/// </summary>
				public class NamespaceId : HL7Base<NamespaceId>
				{

					private const string _id = "BHS.6.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// BHS.6.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
				/// </summary>
				public class UniversalId : HL7Base<UniversalId>
				{

					private const string _id = "BHS.6.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// BHS.6.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
				/// </summary>
				public class UniversalIdType : HL7Base<UniversalIdType>
				{

					private const string _id = "BHS.6.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

			}

						/// <summary>
			/// BHS.7 - This field contains the date/time that the sending system created the message. If the time zone is specified, it will be used throughout the message as the default time zone.
			/// </summary>
			public class BatchCreationDateTime : HL7Base<BatchCreationDateTime>
			{

				private const string _id = "BHS.7";
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
			/// BHS.8 - In some applications of HL7, this field is used to implement security features. Its use is not yet further specified.
			/// </summary>
			public class BatchSecurity : HL7Base<BatchSecurity>
			{

				private const string _id = "BHS.8";
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
			/// BHS.9 - This field can be used by the application processing the batch. It can have extra components if needed.Note the text regarding "extra components" has been retained for backward compatibility, but it is not currently an accepted format for the ST data type.
			/// </summary>
			public class BatchNameIdType : HL7Base<BatchNameIdType>
			{

				private const string _id = "BHS.9";
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
			/// BHS.10 - This field is a comment field that is not further defined in the HL7 protocol.
			/// </summary>
			public class BatchComment : HL7Base<BatchComment>
			{

				private const string _id = "BHS.10";
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
			/// BHS.11 - This field is used to uniquely identify a particular batch. It can be echoed back in BHS-12 Reference Batch Control ID if an answering batch is needed.
			/// </summary>
			public class BatchControlId : HL7Base<BatchControlId>
			{

				private const string _id = "BHS.11";
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
			/// BHS.12 - This field contains the value of BHS-11 Batch Control ID when this batch was originally transmitted. Not present if this batch is being sent for the first time. See definition for BHS-11 Batch Control ID.
			/// </summary>
			public class ReferenceBatchControlId : HL7Base<ReferenceBatchControlId>
			{

				private const string _id = "BHS.12";
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
			/// BHS.13 - Identifier of the network location the message was transmitted from. Identified by an OID or text string (e.g., URI). The reader is referred to the "Report from the Joint W3C/IETF URI Planning Interest Group Uniform Resource Identifiers (URIs), URLs, and Uniform Resource Names (URNs) Clarifications and Recommendations".1As with the Sending/Receiving Responsible Organization, the Sending Network Address provides a more detailed picture of the source of the message. This information is lower than the application layer, but is often useful/necessary for routing and identification purposes. This field should only be populated when the underlying communication protocol does not support identification of sending network locations.The specific values and usage must be site negotiated
			/// </summary>
			public class BatchSendingNetworkAddress : HL7Base<BatchSendingNetworkAddress>
			{

				private const string _id = "BHS.13";
				public override string Id
				{
					get { return _id; }
				}

				private readonly bool[] _repeatableHierarchy = {false, true};
				public override bool[] RepeatableHierarchy
				{
					get { return _repeatableHierarchy; }
				}

								/// <summary>
				/// BHS.13.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
				/// </summary>
				public class NamespaceId : HL7Base<NamespaceId>
				{

					private const string _id = "BHS.13.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// BHS.13.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
				/// </summary>
				public class UniversalId : HL7Base<UniversalId>
				{

					private const string _id = "BHS.13.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// BHS.13.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
				/// </summary>
				public class UniversalIdType : HL7Base<UniversalIdType>
				{

					private const string _id = "BHS.13.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

			}

						/// <summary>
			/// BHS.14 - Identifier of the network location the message was transmitted to. Identified by an OID or text string. (e.g., URL).This is analogous with the Sending Network Address, however in the receiving role.This field should only be populated when the underlying communication protocol does not support identification receiving network locations.
			/// </summary>
			public class BatchReceivingNetworkAddress : HL7Base<BatchReceivingNetworkAddress>
			{

				private const string _id = "BHS.14";
				public override string Id
				{
					get { return _id; }
				}

				private readonly bool[] _repeatableHierarchy = {false, true};
				public override bool[] RepeatableHierarchy
				{
					get { return _repeatableHierarchy; }
				}

								/// <summary>
				/// BHS.14.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
				/// </summary>
				public class NamespaceId : HL7Base<NamespaceId>
				{

					private const string _id = "BHS.14.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// BHS.14.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
				/// </summary>
				public class UniversalId : HL7Base<UniversalId>
				{

					private const string _id = "BHS.14.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// BHS.14.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
				/// </summary>
				public class UniversalIdType : HL7Base<UniversalIdType>
				{

					private const string _id = "BHS.14.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

			}

		  }
	}
}

