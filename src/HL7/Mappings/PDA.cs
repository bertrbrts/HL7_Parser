using Newtonsoft.Json;
namespace care.ai.cloud.functions.hl7
{
	public partial class Mappings {
		/// <summary>
		/// This segment carries information on a patient's death and possible autopsy.
		/// </summary>
		public class PDA {

			 public const string Id = "PDA";

						/// <summary>
			/// PDA.1 - This field is valued with the reason of the death.
			/// </summary>
			public class DeathCauseCode : HL7Base<DeathCauseCode>
			{

				private const string _id = "PDA.1";
				public override string Id
				{
					get { return _id; }
				}

				private readonly bool[] _repeatableHierarchy = {false, false};
				public override bool[] RepeatableHierarchy
				{
					get { return _repeatableHierarchy; }
				}

								/// <summary>
				/// PDA.1.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
				/// </summary>
				public class Identifier : HL7Base<Identifier>
				{

					private const string _id = "PDA.1.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// PDA.1.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
				/// </summary>
				public class Text : HL7Base<Text>
				{

					private const string _id = "PDA.1.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// PDA.1.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
				/// </summary>
				public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
				{

					private const string _id = "PDA.1.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// PDA.1.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
				/// </summary>
				public class AlternateIdentifier : HL7Base<AlternateIdentifier>
				{

					private const string _id = "PDA.1.4";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// PDA.1.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
				/// </summary>
				public class AlternateText : HL7Base<AlternateText>
				{

					private const string _id = "PDA.1.5";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// PDA.1.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
				{

					private const string _id = "PDA.1.6";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// PDA.1.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
				/// </summary>
				public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
				{

					private const string _id = "PDA.1.7";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// PDA.1.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
				/// </summary>
				public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
				{

					private const string _id = "PDA.1.8";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// PDA.1.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
				/// </summary>
				public class OriginalText : HL7Base<OriginalText>
				{

					private const string _id = "PDA.1.9";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// PDA.1.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
				/// </summary>
				public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
				{

					private const string _id = "PDA.1.10";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// PDA.1.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
				/// </summary>
				public class SecondAlternateText : HL7Base<SecondAlternateText>
				{

					private const string _id = "PDA.1.11";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// PDA.1.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
				{

					private const string _id = "PDA.1.12";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// PDA.1.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
				/// </summary>
				public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
				{

					private const string _id = "PDA.1.13";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// PDA.1.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
				/// </summary>
				public class CodingSystemOid : HL7Base<CodingSystemOid>
				{

					private const string _id = "PDA.1.14";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// PDA.1.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class ValueSetOid : HL7Base<ValueSetOid>
				{

					private const string _id = "PDA.1.15";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// PDA.1.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
				/// </summary>
				public class ValueSetVersionId : HL7Base<ValueSetVersionId>
				{

					private const string _id = "PDA.1.16";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// PDA.1.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
				/// </summary>
				public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
				{

					private const string _id = "PDA.1.17";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// PDA.1.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
				{

					private const string _id = "PDA.1.18";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// PDA.1.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
				/// </summary>
				public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
				{

					private const string _id = "PDA.1.19";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// PDA.1.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
				/// </summary>
				public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
				{

					private const string _id = "PDA.1.20";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// PDA.1.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
				{

					private const string _id = "PDA.1.21";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// PDA.1.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
				/// </summary>
				public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
				{

					private const string _id = "PDA.1.22";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

			}

						/// <summary>
			/// PDA.2 - This field is valued with the place the death occurred.
			/// </summary>
			public class DeathLocation : HL7Base<DeathLocation>
			{

				private const string _id = "PDA.2";
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
				/// PDA.2.1 - This component specifies the code for the point where patient care is administered. It is conditional on PL.6 Person Location Type (e.g., nursing unit or department or clinic). After floor, it is the most general patient location designation. Refer to User-defined Table 0302 - Point of Care for suggested values.
				/// </summary>
				public class PointOfCare : HL7Base<PointOfCare>
				{

					private const string _id = "PDA.2.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

										/// <summary>
					/// PDA.2.1.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
					/// </summary>
					public class NamespaceId : HL7Base<NamespaceId>
					{

						private const string _id = "PDA.2.1.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.2.1.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
					/// </summary>
					public class UniversalId : HL7Base<UniversalId>
					{

						private const string _id = "PDA.2.1.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.2.1.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
					/// </summary>
					public class UniversalIdType : HL7Base<UniversalIdType>
					{

						private const string _id = "PDA.2.1.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

				}

								/// <summary>
				/// PDA.2.2 - This component specifies the code for the patient's room. After point of care, it is the most general person location designation. Refer to User-defined Table 0303 - Room for suggested values.
				/// </summary>
				public class Room : HL7Base<Room>
				{

					private const string _id = "PDA.2.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

										/// <summary>
					/// PDA.2.2.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
					/// </summary>
					public class NamespaceId : HL7Base<NamespaceId>
					{

						private const string _id = "PDA.2.2.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.2.2.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
					/// </summary>
					public class UniversalId : HL7Base<UniversalId>
					{

						private const string _id = "PDA.2.2.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.2.2.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
					/// </summary>
					public class UniversalIdType : HL7Base<UniversalIdType>
					{

						private const string _id = "PDA.2.2.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

				}

								/// <summary>
				/// PDA.2.3 - This component specifies the code for the patient's bed. After room, it is the most general person location designation. Refer to User-defined Table 0304 - Bed for suggested values.
				/// </summary>
				public class Bed : HL7Base<Bed>
				{

					private const string _id = "PDA.2.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

										/// <summary>
					/// PDA.2.3.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
					/// </summary>
					public class NamespaceId : HL7Base<NamespaceId>
					{

						private const string _id = "PDA.2.3.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.2.3.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
					/// </summary>
					public class UniversalId : HL7Base<UniversalId>
					{

						private const string _id = "PDA.2.3.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.2.3.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
					/// </summary>
					public class UniversalIdType : HL7Base<UniversalIdType>
					{

						private const string _id = "PDA.2.3.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

				}

								/// <summary>
				/// PDA.2.4 - This component is subject to site interpretation but generally describes the highest level physical designation of an institution, medical center or enterprise. It is the most general person location designation. Note When the HD data type is used in a given segment as a component of a field of another data type, User-defined Table 0300 - Namespace ID (referenced by the first sub-component of the HD component) may be redefined (given a different user-defined table number and name) by the technical committee responsible for that segment.
				/// </summary>
				public class Facility : HL7Base<Facility>
				{

					private const string _id = "PDA.2.4";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

										/// <summary>
					/// PDA.2.4.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
					/// </summary>
					public class NamespaceId : HL7Base<NamespaceId>
					{

						private const string _id = "PDA.2.4.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.2.4.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
					/// </summary>
					public class UniversalId : HL7Base<UniversalId>
					{

						private const string _id = "PDA.2.4.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.2.4.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
					/// </summary>
					public class UniversalIdType : HL7Base<UniversalIdType>
					{

						private const string _id = "PDA.2.4.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

				}

								/// <summary>
				/// PDA.2.5 - This component specifies the code for the status or availability of the location. For example, it may convey bed status. Refer to User-defined Table 0306 - Location Status for suggested values.
				/// </summary>
				public class LocationStatus : HL7Base<LocationStatus>
				{

					private const string _id = "PDA.2.5";
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
				/// PDA.2.6 - Person location type is the categorization of the persons location defined by facility, building, floor, point of care, room or bed. Although not a required field, when used, it may be the only populated field. It usually includes values such as nursing unit, department, clinic, SNF, physicians office. Refer to User-defined Table 0305 - Person location type for suggested values.
				/// </summary>
				public class PersonLocationType : HL7Base<PersonLocationType>
				{

					private const string _id = "PDA.2.6";
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
				/// PDA.2.7 - This component specifies the code for the building where the person is located. After facility, it is the most general person location designation. Refer to User-defined Table 0307 - Building for suggested values.
				/// </summary>
				public class Building : HL7Base<Building>
				{

					private const string _id = "PDA.2.7";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

										/// <summary>
					/// PDA.2.7.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
					/// </summary>
					public class NamespaceId : HL7Base<NamespaceId>
					{

						private const string _id = "PDA.2.7.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.2.7.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
					/// </summary>
					public class UniversalId : HL7Base<UniversalId>
					{

						private const string _id = "PDA.2.7.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.2.7.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
					/// </summary>
					public class UniversalIdType : HL7Base<UniversalIdType>
					{

						private const string _id = "PDA.2.7.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

				}

								/// <summary>
				/// PDA.2.8 - This component specifies the code for the floor where the person is located. After building, it is the most general person location designation. Refer to User-defined Table 0308 - Floor for suggested values.
				/// </summary>
				public class Floor : HL7Base<Floor>
				{

					private const string _id = "PDA.2.8";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

										/// <summary>
					/// PDA.2.8.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
					/// </summary>
					public class NamespaceId : HL7Base<NamespaceId>
					{

						private const string _id = "PDA.2.8.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.2.8.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
					/// </summary>
					public class UniversalId : HL7Base<UniversalId>
					{

						private const string _id = "PDA.2.8.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.2.8.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
					/// </summary>
					public class UniversalIdType : HL7Base<UniversalIdType>
					{

						private const string _id = "PDA.2.8.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

				}

								/// <summary>
				/// PDA.2.9 - This component describes the location in free text.
				/// </summary>
				public class LocationDescription : HL7Base<LocationDescription>
				{

					private const string _id = "PDA.2.9";
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
				/// PDA.2.10 - The unique identifier that represents the physical location as a whole without regard for the individual components. This accommodates sites that may have a different method of defining physical units or who may code at a less granular level. For example, point of care, room, and bed may be 1 indivisible code.
				/// </summary>
				public class ComprehensiveLocationIdentifier : HL7Base<ComprehensiveLocationIdentifier>
				{

					private const string _id = "PDA.2.10";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

										/// <summary>
					/// PDA.2.10.1 - The first component, entity identifier, is usually defined to be unique within the series of identifiers created by the assigning authority, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, "HD - hierarchic designator".
					/// </summary>
					public class EntityIdentifier : HL7Base<EntityIdentifier>
					{

						private const string _id = "PDA.2.10.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.2.10.2 - See Section 2.A.33.1, "Namespace ID (IS)" for definition. The component intentionally remains associated with the IS data type in v 2.7.The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363  Assigning Authority for suggested values.Note When the HD is used as a part of another data type, in this case as part of the EI data type, this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment. By site agreement, implementers may continue to use User-defined Table 0300  Namespace ID for the first component
					/// </summary>
					public class NamespaceId : HL7Base<NamespaceId>
					{

						private const string _id = "PDA.2.10.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.2.10.3 - See Section 2.A.33.2, "Universal ID (ST)" for definition.
					/// </summary>
					public class UniversalId : HL7Base<UniversalId>
					{

						private const string _id = "PDA.2.10.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.2.10.4 - Refer to HL7 Table 0301 - Universal ID Type for valid values. See Section 2.A.33.3, "Universal ID Type (ID)," for definition.
					/// </summary>
					public class UniversalIdType : HL7Base<UniversalIdType>
					{

						private const string _id = "PDA.2.10.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

				}

								/// <summary>
				/// PDA.2.11 - The entity that creates the data for the individual physical location components. If populated, it should be the authority for all components populated. Refer to User-defined Table 0363  Assigning Authority for suggested values for the first sub-component of the HD component, namespace ID.This component makes it possible for codes to be differentiated when the field in which this data type is used repeats.Note When the HD data type is used in a given segment as a component of a field of another data type, User-defined Table 0300 - Namespace ID (referenced by the first sub-component of the HD component) may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.By site agreement, implementors may continue to use User-defined Table 0300  Namespace ID for the first sub-component.
				/// </summary>
				public class AssigningAuthorityForLocation : HL7Base<AssigningAuthorityForLocation>
				{

					private const string _id = "PDA.2.11";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

										/// <summary>
					/// PDA.2.11.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
					/// </summary>
					public class NamespaceId : HL7Base<NamespaceId>
					{

						private const string _id = "PDA.2.11.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.2.11.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
					/// </summary>
					public class UniversalId : HL7Base<UniversalId>
					{

						private const string _id = "PDA.2.11.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.2.11.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
					/// </summary>
					public class UniversalIdType : HL7Base<UniversalIdType>
					{

						private const string _id = "PDA.2.11.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

				}

			}

						/// <summary>
			/// PDA.3 - This field indicates whether a death was officially certified or not. Refer to HL7 Table 0136 - Yes/No Indicator for valid values.Y - death has been certifiedN - death has not been certified
			/// </summary>
			public class DeathCertifiedIndicator : HL7Base<DeathCertifiedIndicator>
			{

				private const string _id = "PDA.3";
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
			/// PDA.4 - This field is valued with the date and time the death certificate was signed.
			/// </summary>
			public class DeathCertificateSignedDateTime : HL7Base<DeathCertificateSignedDateTime>
			{

				private const string _id = "PDA.4";
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
			/// PDA.5 - This field is valued with the person who signed the death certificate.
			/// </summary>
			public class DeathCertifiedBy : HL7Base<DeathCertifiedBy>
			{

				private const string _id = "PDA.5";
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
				/// PDA.5.1 - This component carries the Person Identifier itself. XCN.1, in conjunction with XCN.9 uniquely identifies the entity/person. XCN.1 is required if XCN.2 is not populated. Both may be populated. 
				/// </summary>
				public class PersonIdentifier : HL7Base<PersonIdentifier>
				{

					private const string _id = "PDA.5.1";
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
				/// PDA.5.2 - This component allows full specification of the surname of a person. Where appropriate, it differentiates the person's own surname from that of the person's partner or spouse, in cases where the person's name may contain elements from either name. It also permits messages to distinguish the surname prefix (such as "van" or "de") from the surname root. See section 2.A.30, "FN - family name".XCN.2 is required if XCN.1 is not populated. Both may be populated.
				/// </summary>
				public class FamilyName : HL7Base<FamilyName>
				{

					private const string _id = "PDA.5.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

										/// <summary>
					/// PDA.5.2.1 - The atomic element of the person's family name. In most Western usage, this is the person's last name.
					/// </summary>
					public class Surname : HL7Base<Surname>
					{

						private const string _id = "PDA.5.2.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.2.2 - Internationalization usage for Germanic languages. This component is optional. An example of a surname prefix is the "van" in "Ludwig van Beethoven". Since the surname prefix doesn't sort completely alphabetically, it is reasonable to specify it as a separate sub-component of the PN and extended PN data types (XPN and XCN).Note Subcomponents own surname prefix, own surname, surname prefix from partner/spouse and surname from partner/spouse decompose complex Germanic names such as Martha de Mum-van Beethoven. If these subcomponents are valued, the surname subcomponent should still be fully valued for backward compatibility, i.e., de Mum-van Beethoven&de&Mum&van&Beethoven.Also, for clarity, the last name prefix has been renamed to own surname prefix.
					/// </summary>
					public class OwnSurnamePrefix : HL7Base<OwnSurnamePrefix>
					{

						private const string _id = "PDA.5.2.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.2.3 - The portion of the surname (in most Western usage, the last name) that is derived from the person's own surname, as distinguished from any portion that is derived from the surname of the person's partner or spouse. This component is optional.If the person's surname has legally changed to become (or incorporate) the surname of the person's partner or spouse, this is the person's surname immediately prior to such change. Often this is the person's "maiden name".
					/// </summary>
					public class OwnSurname : HL7Base<OwnSurname>
					{

						private const string _id = "PDA.5.2.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.2.4 - Internationalization usage for Germanic languages. This component is optional. An example of a surname prefix is the van in "Ludwig van Beethoven". Since the surname prefix doesn't sort completely alphabetically, it is reasonable to specify it as a separate sub-component of the PN and extended PN data types (XPN and XCN). Note Subcomponents own surname prefix, own surname, surname prefix from partner/spouse and surname from partner/spouse decompose complex Germanic names such as Martha de Mum-van Beethoven. If these subcomponents are valued, the surname subcomponent should still be fully valued for backward compatibility, i.e., de Mum-van Beethoven&de&Mum&van&Beethoven.Also, for clarity, the last name prefix has been renamed to own surname prefix.
					/// </summary>
					public class SurnamePrefixFromPartnerSpouse : HL7Base<SurnamePrefixFromPartnerSpouse>
					{

						private const string _id = "PDA.5.2.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.2.5 - The portion of the person's surname (in most Western usage, the last name) that is derived from the surname of the person's partner or spouse, as distinguished from the part derived from the person's own surname. This component is optional.If no portion of the person's surname is derived from the surname of the person's partner or spouse, this component is not valued. Otherwise, if the surname of the partner or spouse has legally changed to become (or incorporate) the person's surname, this is the surname of the partner or spouse immediately prior to such change.
					/// </summary>
					public class SurnameFromPartnerSpouse : HL7Base<SurnameFromPartnerSpouse>
					{

						private const string _id = "PDA.5.2.5";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

				}

								/// <summary>
				/// PDA.5.3 - First name.
				/// </summary>
				public class GivenName : HL7Base<GivenName>
				{

					private const string _id = "PDA.5.3";
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
				/// PDA.5.4 - Multiple middle names may be included by separating them with spaces.
				/// </summary>
				public class SecondAndFurtherGivenNamesOrInitialsThereof : HL7Base<SecondAndFurtherGivenNamesOrInitialsThereof>
				{

					private const string _id = "PDA.5.4";
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
				/// PDA.5.5 - Used to specify a name suffix (e.g., Jr. or III).
				/// </summary>
				public class SuffixegJrOrIii : HL7Base<SuffixegJrOrIii>
				{

					private const string _id = "PDA.5.5";
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
				/// PDA.5.6 - Used to specify a name prefix (e.g., Dr.).
				/// </summary>
				public class PrefixegDr : HL7Base<PrefixegDr>
				{

					private const string _id = "PDA.5.6";
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
				/// PDA.5.7 - Attention The XCN-7 component was deprecated as of v2.5 and the detail was withdrawn and removed from the standard as of v27.. Refer to XCN.21 Professional Suffix.
				/// </summary>
				public class DegreeegMd : HL7Base<DegreeegMd>
				{

					private const string _id = "PDA.5.7";
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
				/// PDA.5.8 - Attention Retained for backwards compatibility only as of v 2.7. The reader is referred to XCN.9 instead.User-defined Table 0297  CN ID source is used as the HL7 identifier for the user-defined table of values for this component. Used to delineate the first component.
				/// </summary>
				public class SourceTable : HL7Base<SourceTable>
				{

					private const string _id = "PDA.5.8";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

										/// <summary>
					/// PDA.5.8.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "PDA.5.8.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.8.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "PDA.5.8.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.8.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "PDA.5.8.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.8.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "PDA.5.8.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.8.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "PDA.5.8.5";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.8.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "PDA.5.8.6";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.8.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "PDA.5.8.7";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.8.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "PDA.5.8.8";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.8.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "PDA.5.8.9";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.8.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "PDA.5.8.10";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.8.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "PDA.5.8.11";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.8.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "PDA.5.8.12";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.8.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "PDA.5.8.13";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.8.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "PDA.5.8.14";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.8.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "PDA.5.8.15";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.8.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "PDA.5.8.16";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.8.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "PDA.5.8.17";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.8.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "PDA.5.8.18";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.8.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "PDA.5.8.19";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.8.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "PDA.5.8.20";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.8.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "PDA.5.8.21";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.8.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "PDA.5.8.22";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

				}

								/// <summary>
				/// PDA.5.9 - The assigning authority is a unique identifier of the system (or organization or agency of department) that creates the data. User-defined Table 0363  Assigning Authority is used as the HL7 identifier for the user-defined table of values for the first sub-component of the HD component, namespace ID.As of v 2.7, the Assigning Authority is conditional. It is required if XCN.1 is populated and neither XCN.22 nor XCN.23 are populated. All 3 components may be populated. No assumptions can be safely made based on position or sequence. Best practice is to send an OID in this component when populated.The reader is referred to XCN.22 and XCN.23 if there is a need to transmit values with semantic meaning for an assigning jurisdiction or assigning department or agency in addition to, or instead of, an assigning authority. However, all 3 components may be valued.  If, in so doing, it is discovered that the values in XCN.22 and/or XCN.23 conflict with XCN.9, the user would look to the Message Profile or other implementation agreement for a statement as to which takes precedence.Note When the HD data type is used in a given segment as a component of a field of another data type, User-defined Table 0300 - Namespace ID (referenced by the first sub-component of the HD component) may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.By site agreement, implementors may continue to use User-defined Table 0300  Namespace ID for the first sub-component.
				/// </summary>
				public class AssigningAuthority : HL7Base<AssigningAuthority>
				{

					private const string _id = "PDA.5.9";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

										/// <summary>
					/// PDA.5.9.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
					/// </summary>
					public class NamespaceId : HL7Base<NamespaceId>
					{

						private const string _id = "PDA.5.9.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.9.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
					/// </summary>
					public class UniversalId : HL7Base<UniversalId>
					{

						private const string _id = "PDA.5.9.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.9.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
					/// </summary>
					public class UniversalIdType : HL7Base<UniversalIdType>
					{

						private const string _id = "PDA.5.9.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

				}

								/// <summary>
				/// PDA.5.10 - A code that represents the type of name. Refer to HL7 Table 0200 - Name Type for valid values. See Section 2.A.89.7, "Name Type Code (ID)".As of v 2.7, XCN.10 is conditional. It is required if XCN.2 is populated.
				/// </summary>
				public class NameTypeCode : HL7Base<NameTypeCode>
				{

					private const string _id = "PDA.5.10";
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
				/// PDA.5.11 - This component contains the digit, or digits, exclusive of the identifier in XCN.1, calculated by applying an algorithm to all or some of the digits in the number, which may be used to test validity of the non-check-digit identifier.
				/// </summary>
				public class IdentifierCheckDigit : HL7Base<IdentifierCheckDigit>
				{

					private const string _id = "PDA.5.11";
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
				/// PDA.5.12 - Contains the code identifying the check digit scheme employed.Refer to HL7 Table 0061 - Check Digit Scheme for valid values.
				/// </summary>
				public class CheckDigitScheme : HL7Base<CheckDigitScheme>
				{

					private const string _id = "PDA.5.12";
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
				/// PDA.5.13 - A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the assigning authority component. Refer to HL7 Table 0203 - Identifier Type for suggested values.As of v 2.7, XCN.13 is conditional. It is required if XCN.1 is populated.
				/// </summary>
				public class IdentifierTypeCode : HL7Base<IdentifierTypeCode>
				{

					private const string _id = "PDA.5.13";
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
				/// PDA.5.14 - The place or location identifier where the identifier was first assigned to the person. This component is not an inherent part of the identifier but rather part of the history of the identifier as part of this data type, its existence is a convenience for certain intercommunicating systems.Note When the HD data type is used in a given segment as a component of a field of another data type, User-defined Table 0300 - Namespace ID (referenced by the first sub-component of the HD component) may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
				/// </summary>
				public class AssigningFacility : HL7Base<AssigningFacility>
				{

					private const string _id = "PDA.5.14";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

										/// <summary>
					/// PDA.5.14.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
					/// </summary>
					public class NamespaceId : HL7Base<NamespaceId>
					{

						private const string _id = "PDA.5.14.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.14.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
					/// </summary>
					public class UniversalId : HL7Base<UniversalId>
					{

						private const string _id = "PDA.5.14.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.14.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
					/// </summary>
					public class UniversalIdType : HL7Base<UniversalIdType>
					{

						private const string _id = "PDA.5.14.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

				}

								/// <summary>
				/// PDA.5.15 - Different name/address types and representations of the same name/address should be described by repeating of this field, with different values of the name/address type and/or name/address representation component.Note This new component remains in alphabetic representation with each repetition of the field using these data types. I.e., even though the name may be represented in an ideographic character set, this component will remain represented in an alphabetic character set.Refer to HL7 Table 0465  Name/address Representation for valid values.In general this component provides an indication of the representation provided by the data item. It does not necessarily specify the character sets used. Thus, even though the representation might provide an indication of what to expect, the sender is still free to encode the contents using whatever character set is desired. This component provides only hints for the receiver, so it can make choices regarding what it has been sent and what it is capable of displaying.
				/// </summary>
				public class NameRepresentationCode : HL7Base<NameRepresentationCode>
				{

					private const string _id = "PDA.5.15";
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
				/// PDA.5.16 - This component is used to designate the context in which a name is used. The main use case is in Australian healthcare for indigenous patients who prefer to use different names when attending different healthcare institutions. Another use case occurs in the US where health practitioners can be licensed under slightly different names and the reporting of the correct name is vital for administrative purposes. Refer to User-defined Table 0448  Name Context for suggested values.
				/// </summary>
				public class NameContext : HL7Base<NameContext>
				{

					private const string _id = "PDA.5.16";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

										/// <summary>
					/// PDA.5.16.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "PDA.5.16.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.16.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "PDA.5.16.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.16.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "PDA.5.16.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.16.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "PDA.5.16.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.16.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "PDA.5.16.5";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.16.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "PDA.5.16.6";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.16.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "PDA.5.16.7";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.16.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "PDA.5.16.8";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.16.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "PDA.5.16.9";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.16.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "PDA.5.16.10";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.16.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "PDA.5.16.11";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.16.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "PDA.5.16.12";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.16.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "PDA.5.16.13";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.16.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "PDA.5.16.14";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.16.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "PDA.5.16.15";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.16.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "PDA.5.16.16";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.16.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "PDA.5.16.17";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.16.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "PDA.5.16.18";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.16.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "PDA.5.16.19";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.16.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "PDA.5.16.20";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.16.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "PDA.5.16.21";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.16.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "PDA.5.16.22";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

				}

								/// <summary>
				/// PDA.5.17 - Attention The XCN.17 component was deprecated as of v2.5 and the detail was withdrawn and removed from the standard as of v 2.7. Refer to XCN.19 Effective Date and XCN.20 Expiration Date instead.This component contains the start and end date/times that define the period during which this name was valid.
				/// </summary>
				public class NameValidityRange : HL7Base<NameValidityRange>
				{

					private const string _id = "PDA.5.17";
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
				/// PDA.5.18 - A code that represents the preferred display order of the components of this person name. Refer to HL7 Table 0444 - Name Assembly Order for valid values.
				/// </summary>
				public class NameAssemblyOrder : HL7Base<NameAssemblyOrder>
				{

					private const string _id = "PDA.5.18";
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
				/// PDA.5.19 - The first date, if known, on which the person name is valid and active.
				/// </summary>
				public class EffectiveDate : HL7Base<EffectiveDate>
				{

					private const string _id = "PDA.5.19";
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
				/// PDA.5.20 - The last date, if known, on which the person name is valid and active.
				/// </summary>
				public class ExpirationDate : HL7Base<ExpirationDate>
				{

					private const string _id = "PDA.5.20";
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
				/// PDA.5.21 - Used to specify an abbreviation, or a string of abbreviations denoting qualifications that support the persons profession, (e.g., licenses, certificates, degrees, affiliations with professional societies, etc.). The Professional Suffix normally follows the Family Name when the Person Name is used for display purposes. Please note that this component is an unformatted string and is used for display purposes only. Detailed information regarding the contents of Professional Suffix is obtained using appropriate segments in Chapter 15, "Personnel Management".
				/// </summary>
				public class ProfessionalSuffix : HL7Base<ProfessionalSuffix>
				{

					private const string _id = "PDA.5.21";
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
				/// PDA.5.22 - The geo-political body that assigned the identifier in XCN.1. As of v 2.7, the Assigning Jurisdiction is conditional. It is required if XCN.1 is populated and neither XCN.9 nor XCN.23 are populated. All 3 components may be populated. The reader is referred to XCN.9 if there is a need to transmit this information as an OID.
				/// </summary>
				public class AssigningJurisdiction : HL7Base<AssigningJurisdiction>
				{

					private const string _id = "PDA.5.22";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

										/// <summary>
					/// PDA.5.22.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "PDA.5.22.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.22.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "PDA.5.22.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.22.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "PDA.5.22.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.22.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "PDA.5.22.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.22.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "PDA.5.22.5";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.22.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "PDA.5.22.6";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.22.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "PDA.5.22.7";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.22.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "PDA.5.22.8";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.22.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "PDA.5.22.9";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.22.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "PDA.5.22.10";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.22.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "PDA.5.22.11";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.22.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "PDA.5.22.12";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.22.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "PDA.5.22.13";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.22.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "PDA.5.22.14";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.22.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "PDA.5.22.15";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.22.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "PDA.5.22.16";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.22.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "PDA.5.22.17";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.22.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "PDA.5.22.18";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.22.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "PDA.5.22.19";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.22.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "PDA.5.22.20";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.22.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "PDA.5.22.21";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.22.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "PDA.5.22.22";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

				}

								/// <summary>
				/// PDA.5.23 - The agency or department that assigned the identifier in XCN.1.As of v 2.7, the Assigning Jurisdiction is conditional. It is required if XCN.1 is populated and neither XCN.9 nor XCN.22 are populated. All 3 components may be populated. The reader is referred to XCN.9 if there is a need to transmit this information as an OID.
				/// </summary>
				public class AssigningAgencyOrDepartment : HL7Base<AssigningAgencyOrDepartment>
				{

					private const string _id = "PDA.5.23";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

										/// <summary>
					/// PDA.5.23.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "PDA.5.23.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.23.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "PDA.5.23.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.23.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "PDA.5.23.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.23.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "PDA.5.23.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.23.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "PDA.5.23.5";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.23.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "PDA.5.23.6";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.23.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "PDA.5.23.7";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.23.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "PDA.5.23.8";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.23.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "PDA.5.23.9";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.23.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "PDA.5.23.10";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.23.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "PDA.5.23.11";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.23.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "PDA.5.23.12";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.23.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "PDA.5.23.13";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.23.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "PDA.5.23.14";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.23.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "PDA.5.23.15";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.23.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "PDA.5.23.16";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.23.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "PDA.5.23.17";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.23.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "PDA.5.23.18";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.23.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "PDA.5.23.19";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.23.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "PDA.5.23.20";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.23.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "PDA.5.23.21";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.5.23.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "PDA.5.23.22";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

				}

								/// <summary>
				/// PDA.5.24 - This component is used to communicate a version code that may be assigned to the value given in XCN.1 Person Identifier.
				/// </summary>
				public class SecurityCheck : HL7Base<SecurityCheck>
				{

					private const string _id = "PDA.5.24";
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
				/// PDA.5.25 - This component is used to transmit information intended to validate the veracity of the supplied identifier or the presenter of the identifier. For example, this component may be used to ensure that the presenter of a credit card is an authorized user of that card.Refer to HL7 Table 0904 - Security Check Scheme for valid values
				/// </summary>
				public class SecurityCheckScheme : HL7Base<SecurityCheckScheme>
				{

					private const string _id = "PDA.5.25";
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
			/// PDA.6 - This field indicates whether an autopsy was performed. Refer to HL7 Table 0136 - Yes/No Indicator for valid values.Y - an autopsy was performedN - an autopsy was not performed
			/// </summary>
			public class AutopsyIndicator : HL7Base<AutopsyIndicator>
			{

				private const string _id = "PDA.6";
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
			/// PDA.7 - If an autopsy is performed, this field is valued with the date and time the autopsy was begun and completed
			/// </summary>
			public class AutopsyStartAndEndDateTime : HL7Base<AutopsyStartAndEndDateTime>
			{

				private const string _id = "PDA.7";
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
				/// PDA.7.1 - The first component contains the earliest date/time (time stamp) in the specified range.
				/// </summary>
				public class RangeStartDateTime : HL7Base<RangeStartDateTime>
				{

					private const string _id = "PDA.7.1";
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
				/// PDA.7.2 - The second component contains the latest date/time in the specified range. Note that the DTM (time stamp) data type allows the specification of precision.
				/// </summary>
				public class RangeEndDateTime : HL7Base<RangeEndDateTime>
				{

					private const string _id = "PDA.7.2";
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
			/// PDA.8 - This field is valued with the authority who performed the autopsy.
			/// </summary>
			public class AutopsyPerformedBy : HL7Base<AutopsyPerformedBy>
			{

				private const string _id = "PDA.8";
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
				/// PDA.8.1 - This component carries the Person Identifier itself. XCN.1, in conjunction with XCN.9 uniquely identifies the entity/person. XCN.1 is required if XCN.2 is not populated. Both may be populated. 
				/// </summary>
				public class PersonIdentifier : HL7Base<PersonIdentifier>
				{

					private const string _id = "PDA.8.1";
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
				/// PDA.8.2 - This component allows full specification of the surname of a person. Where appropriate, it differentiates the person's own surname from that of the person's partner or spouse, in cases where the person's name may contain elements from either name. It also permits messages to distinguish the surname prefix (such as "van" or "de") from the surname root. See section 2.A.30, "FN - family name".XCN.2 is required if XCN.1 is not populated. Both may be populated.
				/// </summary>
				public class FamilyName : HL7Base<FamilyName>
				{

					private const string _id = "PDA.8.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

										/// <summary>
					/// PDA.8.2.1 - The atomic element of the person's family name. In most Western usage, this is the person's last name.
					/// </summary>
					public class Surname : HL7Base<Surname>
					{

						private const string _id = "PDA.8.2.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.2.2 - Internationalization usage for Germanic languages. This component is optional. An example of a surname prefix is the "van" in "Ludwig van Beethoven". Since the surname prefix doesn't sort completely alphabetically, it is reasonable to specify it as a separate sub-component of the PN and extended PN data types (XPN and XCN).Note Subcomponents own surname prefix, own surname, surname prefix from partner/spouse and surname from partner/spouse decompose complex Germanic names such as Martha de Mum-van Beethoven. If these subcomponents are valued, the surname subcomponent should still be fully valued for backward compatibility, i.e., de Mum-van Beethoven&de&Mum&van&Beethoven.Also, for clarity, the last name prefix has been renamed to own surname prefix.
					/// </summary>
					public class OwnSurnamePrefix : HL7Base<OwnSurnamePrefix>
					{

						private const string _id = "PDA.8.2.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.2.3 - The portion of the surname (in most Western usage, the last name) that is derived from the person's own surname, as distinguished from any portion that is derived from the surname of the person's partner or spouse. This component is optional.If the person's surname has legally changed to become (or incorporate) the surname of the person's partner or spouse, this is the person's surname immediately prior to such change. Often this is the person's "maiden name".
					/// </summary>
					public class OwnSurname : HL7Base<OwnSurname>
					{

						private const string _id = "PDA.8.2.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.2.4 - Internationalization usage for Germanic languages. This component is optional. An example of a surname prefix is the van in "Ludwig van Beethoven". Since the surname prefix doesn't sort completely alphabetically, it is reasonable to specify it as a separate sub-component of the PN and extended PN data types (XPN and XCN). Note Subcomponents own surname prefix, own surname, surname prefix from partner/spouse and surname from partner/spouse decompose complex Germanic names such as Martha de Mum-van Beethoven. If these subcomponents are valued, the surname subcomponent should still be fully valued for backward compatibility, i.e., de Mum-van Beethoven&de&Mum&van&Beethoven.Also, for clarity, the last name prefix has been renamed to own surname prefix.
					/// </summary>
					public class SurnamePrefixFromPartnerSpouse : HL7Base<SurnamePrefixFromPartnerSpouse>
					{

						private const string _id = "PDA.8.2.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.2.5 - The portion of the person's surname (in most Western usage, the last name) that is derived from the surname of the person's partner or spouse, as distinguished from the part derived from the person's own surname. This component is optional.If no portion of the person's surname is derived from the surname of the person's partner or spouse, this component is not valued. Otherwise, if the surname of the partner or spouse has legally changed to become (or incorporate) the person's surname, this is the surname of the partner or spouse immediately prior to such change.
					/// </summary>
					public class SurnameFromPartnerSpouse : HL7Base<SurnameFromPartnerSpouse>
					{

						private const string _id = "PDA.8.2.5";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

				}

								/// <summary>
				/// PDA.8.3 - First name.
				/// </summary>
				public class GivenName : HL7Base<GivenName>
				{

					private const string _id = "PDA.8.3";
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
				/// PDA.8.4 - Multiple middle names may be included by separating them with spaces.
				/// </summary>
				public class SecondAndFurtherGivenNamesOrInitialsThereof : HL7Base<SecondAndFurtherGivenNamesOrInitialsThereof>
				{

					private const string _id = "PDA.8.4";
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
				/// PDA.8.5 - Used to specify a name suffix (e.g., Jr. or III).
				/// </summary>
				public class SuffixegJrOrIii : HL7Base<SuffixegJrOrIii>
				{

					private const string _id = "PDA.8.5";
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
				/// PDA.8.6 - Used to specify a name prefix (e.g., Dr.).
				/// </summary>
				public class PrefixegDr : HL7Base<PrefixegDr>
				{

					private const string _id = "PDA.8.6";
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
				/// PDA.8.7 - Attention The XCN-7 component was deprecated as of v2.5 and the detail was withdrawn and removed from the standard as of v27.. Refer to XCN.21 Professional Suffix.
				/// </summary>
				public class DegreeegMd : HL7Base<DegreeegMd>
				{

					private const string _id = "PDA.8.7";
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
				/// PDA.8.8 - Attention Retained for backwards compatibility only as of v 2.7. The reader is referred to XCN.9 instead.User-defined Table 0297  CN ID source is used as the HL7 identifier for the user-defined table of values for this component. Used to delineate the first component.
				/// </summary>
				public class SourceTable : HL7Base<SourceTable>
				{

					private const string _id = "PDA.8.8";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

										/// <summary>
					/// PDA.8.8.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "PDA.8.8.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.8.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "PDA.8.8.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.8.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "PDA.8.8.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.8.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "PDA.8.8.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.8.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "PDA.8.8.5";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.8.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "PDA.8.8.6";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.8.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "PDA.8.8.7";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.8.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "PDA.8.8.8";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.8.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "PDA.8.8.9";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.8.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "PDA.8.8.10";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.8.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "PDA.8.8.11";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.8.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "PDA.8.8.12";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.8.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "PDA.8.8.13";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.8.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "PDA.8.8.14";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.8.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "PDA.8.8.15";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.8.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "PDA.8.8.16";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.8.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "PDA.8.8.17";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.8.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "PDA.8.8.18";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.8.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "PDA.8.8.19";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.8.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "PDA.8.8.20";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.8.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "PDA.8.8.21";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.8.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "PDA.8.8.22";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

				}

								/// <summary>
				/// PDA.8.9 - The assigning authority is a unique identifier of the system (or organization or agency of department) that creates the data. User-defined Table 0363  Assigning Authority is used as the HL7 identifier for the user-defined table of values for the first sub-component of the HD component, namespace ID.As of v 2.7, the Assigning Authority is conditional. It is required if XCN.1 is populated and neither XCN.22 nor XCN.23 are populated. All 3 components may be populated. No assumptions can be safely made based on position or sequence. Best practice is to send an OID in this component when populated.The reader is referred to XCN.22 and XCN.23 if there is a need to transmit values with semantic meaning for an assigning jurisdiction or assigning department or agency in addition to, or instead of, an assigning authority. However, all 3 components may be valued.  If, in so doing, it is discovered that the values in XCN.22 and/or XCN.23 conflict with XCN.9, the user would look to the Message Profile or other implementation agreement for a statement as to which takes precedence.Note When the HD data type is used in a given segment as a component of a field of another data type, User-defined Table 0300 - Namespace ID (referenced by the first sub-component of the HD component) may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.By site agreement, implementors may continue to use User-defined Table 0300  Namespace ID for the first sub-component.
				/// </summary>
				public class AssigningAuthority : HL7Base<AssigningAuthority>
				{

					private const string _id = "PDA.8.9";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

										/// <summary>
					/// PDA.8.9.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
					/// </summary>
					public class NamespaceId : HL7Base<NamespaceId>
					{

						private const string _id = "PDA.8.9.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.9.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
					/// </summary>
					public class UniversalId : HL7Base<UniversalId>
					{

						private const string _id = "PDA.8.9.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.9.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
					/// </summary>
					public class UniversalIdType : HL7Base<UniversalIdType>
					{

						private const string _id = "PDA.8.9.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

				}

								/// <summary>
				/// PDA.8.10 - A code that represents the type of name. Refer to HL7 Table 0200 - Name Type for valid values. See Section 2.A.89.7, "Name Type Code (ID)".As of v 2.7, XCN.10 is conditional. It is required if XCN.2 is populated.
				/// </summary>
				public class NameTypeCode : HL7Base<NameTypeCode>
				{

					private const string _id = "PDA.8.10";
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
				/// PDA.8.11 - This component contains the digit, or digits, exclusive of the identifier in XCN.1, calculated by applying an algorithm to all or some of the digits in the number, which may be used to test validity of the non-check-digit identifier.
				/// </summary>
				public class IdentifierCheckDigit : HL7Base<IdentifierCheckDigit>
				{

					private const string _id = "PDA.8.11";
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
				/// PDA.8.12 - Contains the code identifying the check digit scheme employed.Refer to HL7 Table 0061 - Check Digit Scheme for valid values.
				/// </summary>
				public class CheckDigitScheme : HL7Base<CheckDigitScheme>
				{

					private const string _id = "PDA.8.12";
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
				/// PDA.8.13 - A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the assigning authority component. Refer to HL7 Table 0203 - Identifier Type for suggested values.As of v 2.7, XCN.13 is conditional. It is required if XCN.1 is populated.
				/// </summary>
				public class IdentifierTypeCode : HL7Base<IdentifierTypeCode>
				{

					private const string _id = "PDA.8.13";
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
				/// PDA.8.14 - The place or location identifier where the identifier was first assigned to the person. This component is not an inherent part of the identifier but rather part of the history of the identifier as part of this data type, its existence is a convenience for certain intercommunicating systems.Note When the HD data type is used in a given segment as a component of a field of another data type, User-defined Table 0300 - Namespace ID (referenced by the first sub-component of the HD component) may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
				/// </summary>
				public class AssigningFacility : HL7Base<AssigningFacility>
				{

					private const string _id = "PDA.8.14";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

										/// <summary>
					/// PDA.8.14.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
					/// </summary>
					public class NamespaceId : HL7Base<NamespaceId>
					{

						private const string _id = "PDA.8.14.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.14.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
					/// </summary>
					public class UniversalId : HL7Base<UniversalId>
					{

						private const string _id = "PDA.8.14.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.14.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
					/// </summary>
					public class UniversalIdType : HL7Base<UniversalIdType>
					{

						private const string _id = "PDA.8.14.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

				}

								/// <summary>
				/// PDA.8.15 - Different name/address types and representations of the same name/address should be described by repeating of this field, with different values of the name/address type and/or name/address representation component.Note This new component remains in alphabetic representation with each repetition of the field using these data types. I.e., even though the name may be represented in an ideographic character set, this component will remain represented in an alphabetic character set.Refer to HL7 Table 0465  Name/address Representation for valid values.In general this component provides an indication of the representation provided by the data item. It does not necessarily specify the character sets used. Thus, even though the representation might provide an indication of what to expect, the sender is still free to encode the contents using whatever character set is desired. This component provides only hints for the receiver, so it can make choices regarding what it has been sent and what it is capable of displaying.
				/// </summary>
				public class NameRepresentationCode : HL7Base<NameRepresentationCode>
				{

					private const string _id = "PDA.8.15";
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
				/// PDA.8.16 - This component is used to designate the context in which a name is used. The main use case is in Australian healthcare for indigenous patients who prefer to use different names when attending different healthcare institutions. Another use case occurs in the US where health practitioners can be licensed under slightly different names and the reporting of the correct name is vital for administrative purposes. Refer to User-defined Table 0448  Name Context for suggested values.
				/// </summary>
				public class NameContext : HL7Base<NameContext>
				{

					private const string _id = "PDA.8.16";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

										/// <summary>
					/// PDA.8.16.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "PDA.8.16.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.16.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "PDA.8.16.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.16.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "PDA.8.16.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.16.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "PDA.8.16.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.16.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "PDA.8.16.5";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.16.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "PDA.8.16.6";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.16.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "PDA.8.16.7";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.16.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "PDA.8.16.8";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.16.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "PDA.8.16.9";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.16.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "PDA.8.16.10";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.16.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "PDA.8.16.11";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.16.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "PDA.8.16.12";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.16.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "PDA.8.16.13";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.16.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "PDA.8.16.14";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.16.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "PDA.8.16.15";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.16.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "PDA.8.16.16";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.16.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "PDA.8.16.17";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.16.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "PDA.8.16.18";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.16.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "PDA.8.16.19";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.16.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "PDA.8.16.20";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.16.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "PDA.8.16.21";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.16.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "PDA.8.16.22";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

				}

								/// <summary>
				/// PDA.8.17 - Attention The XCN.17 component was deprecated as of v2.5 and the detail was withdrawn and removed from the standard as of v 2.7. Refer to XCN.19 Effective Date and XCN.20 Expiration Date instead.This component contains the start and end date/times that define the period during which this name was valid.
				/// </summary>
				public class NameValidityRange : HL7Base<NameValidityRange>
				{

					private const string _id = "PDA.8.17";
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
				/// PDA.8.18 - A code that represents the preferred display order of the components of this person name. Refer to HL7 Table 0444 - Name Assembly Order for valid values.
				/// </summary>
				public class NameAssemblyOrder : HL7Base<NameAssemblyOrder>
				{

					private const string _id = "PDA.8.18";
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
				/// PDA.8.19 - The first date, if known, on which the person name is valid and active.
				/// </summary>
				public class EffectiveDate : HL7Base<EffectiveDate>
				{

					private const string _id = "PDA.8.19";
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
				/// PDA.8.20 - The last date, if known, on which the person name is valid and active.
				/// </summary>
				public class ExpirationDate : HL7Base<ExpirationDate>
				{

					private const string _id = "PDA.8.20";
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
				/// PDA.8.21 - Used to specify an abbreviation, or a string of abbreviations denoting qualifications that support the persons profession, (e.g., licenses, certificates, degrees, affiliations with professional societies, etc.). The Professional Suffix normally follows the Family Name when the Person Name is used for display purposes. Please note that this component is an unformatted string and is used for display purposes only. Detailed information regarding the contents of Professional Suffix is obtained using appropriate segments in Chapter 15, "Personnel Management".
				/// </summary>
				public class ProfessionalSuffix : HL7Base<ProfessionalSuffix>
				{

					private const string _id = "PDA.8.21";
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
				/// PDA.8.22 - The geo-political body that assigned the identifier in XCN.1. As of v 2.7, the Assigning Jurisdiction is conditional. It is required if XCN.1 is populated and neither XCN.9 nor XCN.23 are populated. All 3 components may be populated. The reader is referred to XCN.9 if there is a need to transmit this information as an OID.
				/// </summary>
				public class AssigningJurisdiction : HL7Base<AssigningJurisdiction>
				{

					private const string _id = "PDA.8.22";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

										/// <summary>
					/// PDA.8.22.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "PDA.8.22.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.22.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "PDA.8.22.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.22.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "PDA.8.22.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.22.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "PDA.8.22.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.22.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "PDA.8.22.5";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.22.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "PDA.8.22.6";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.22.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "PDA.8.22.7";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.22.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "PDA.8.22.8";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.22.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "PDA.8.22.9";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.22.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "PDA.8.22.10";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.22.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "PDA.8.22.11";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.22.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "PDA.8.22.12";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.22.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "PDA.8.22.13";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.22.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "PDA.8.22.14";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.22.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "PDA.8.22.15";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.22.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "PDA.8.22.16";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.22.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "PDA.8.22.17";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.22.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "PDA.8.22.18";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.22.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "PDA.8.22.19";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.22.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "PDA.8.22.20";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.22.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "PDA.8.22.21";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.22.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "PDA.8.22.22";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

				}

								/// <summary>
				/// PDA.8.23 - The agency or department that assigned the identifier in XCN.1.As of v 2.7, the Assigning Jurisdiction is conditional. It is required if XCN.1 is populated and neither XCN.9 nor XCN.22 are populated. All 3 components may be populated. The reader is referred to XCN.9 if there is a need to transmit this information as an OID.
				/// </summary>
				public class AssigningAgencyOrDepartment : HL7Base<AssigningAgencyOrDepartment>
				{

					private const string _id = "PDA.8.23";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

										/// <summary>
					/// PDA.8.23.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "PDA.8.23.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.23.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "PDA.8.23.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.23.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "PDA.8.23.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.23.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "PDA.8.23.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.23.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "PDA.8.23.5";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.23.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "PDA.8.23.6";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.23.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "PDA.8.23.7";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.23.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "PDA.8.23.8";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.23.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "PDA.8.23.9";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.23.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "PDA.8.23.10";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.23.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "PDA.8.23.11";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.23.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "PDA.8.23.12";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.23.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "PDA.8.23.13";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.23.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "PDA.8.23.14";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.23.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "PDA.8.23.15";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.23.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "PDA.8.23.16";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.23.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "PDA.8.23.17";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.23.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "PDA.8.23.18";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.23.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "PDA.8.23.19";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.23.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "PDA.8.23.20";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.23.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "PDA.8.23.21";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PDA.8.23.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "PDA.8.23.22";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

				}

								/// <summary>
				/// PDA.8.24 - This component is used to communicate a version code that may be assigned to the value given in XCN.1 Person Identifier.
				/// </summary>
				public class SecurityCheck : HL7Base<SecurityCheck>
				{

					private const string _id = "PDA.8.24";
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
				/// PDA.8.25 - This component is used to transmit information intended to validate the veracity of the supplied identifier or the presenter of the identifier. For example, this component may be used to ensure that the presenter of a credit card is an authorized user of that card.Refer to HL7 Table 0904 - Security Check Scheme for valid values
				/// </summary>
				public class SecurityCheckScheme : HL7Base<SecurityCheckScheme>
				{

					private const string _id = "PDA.8.25";
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
			/// PDA.9 - This flag indicates whether the case/death has been assigned to the coroner/medical examiner for investigative purposed. Refer to HL7 Table 0136 - Yes/No Indicator for valid values.Y - Has been assigned to the coroner.N - Has not been assigned to the coroner.
			/// </summary>
			public class CoronerIndicator : HL7Base<CoronerIndicator>
			{

				private const string _id = "PDA.9";
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

