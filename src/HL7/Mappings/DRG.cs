using Newtonsoft.Json;
namespace HL7Parser
{
	public partial class Mappings {
		/// <summary>
		/// The DRG segment contains diagnoses-related grouping information of various types. The DRG segment is used to send the DRG information, for example, for billing and medical records encoding.
		/// </summary>
		public class DRG {

			 public const string Id = "DRG";

						/// <summary>
			/// DRG.1 - This field contains the DRG for the transaction. Interim DRGs could be determined for an encounter. Refer to Externally-defined Table 0055  Diagnosis Related Group for suggested values.
			/// </summary>
			public class DiagnosticRelatedGroup : HL7Base<DiagnosticRelatedGroup>
			{

				private const string _id = "DRG.1";
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
				/// DRG.1.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CNE.2. Different coding schemes will have different elements here.Usage Note The identifier is required and must be a valid code.
				/// </summary>
				public class Identifier : HL7Base<Identifier>
				{

					private const string _id = "DRG.1.1";
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
				/// DRG.1.2 - The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression. This is the corresponding text assigned by the coding system to the identifier.Usage Note Text description of code is optional but its use should be encouraged since it makes messages easier to review for accuracy, especially during interface testing and debugging.
				/// </summary>
				public class Text : HL7Base<Text>
				{

					private const string _id = "DRG.1.2";
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
				/// DRG.1.3 - The third component contains the code for the name of the coding system from which the value in CNE.1 is obtained. Refer to HL7 Table 0396 - Coding Systems in Chapter 2C, Code Tables, for valid values. Each coding system is assigned a unique identifier.As of v2.7 this component is required when CNE.1 is populated and CNE.14 is not populated. Both CNE.3 and CNE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CNE.3 and/or CNE.14 the Coding System component or the Coding System OID for the tuple.The combination of the identifier and name of coding system represent a unique concept for a data item.Some organizations that publish code sets author more than one. The coding system, then, to be unique, is a concatenation of the name of the coding authority organization and the name of its code set or table. When an HL7 table is used for a CNE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. Similarly, ISO tables will be named ISOnnnn, where nnnn is the ISO table number.Usage Note The following statement is retained for backward compatibility as of v2.7. Best practice would recommend that this component always be populated. However, if the field narrative explicitly states "Refer to HL7 Table nnnn for valid values, and, if the sending and receiving systems are HL7 compliant, the coding system would be known from the standard.  This would be similar to a field with an ID data type, except that there is a second triplet in which to express an alternate code.
				/// </summary>
				public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
				{

					private const string _id = "DRG.1.3";
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
				/// DRG.1.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CNE.1 Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
				/// </summary>
				public class AlternateIdentifier : HL7Base<AlternateIdentifier>
				{

					private const string _id = "DRG.1.4";
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
				/// DRG.1.5 - The descriptive or textual name of the alternate identifier. Analogous to CNE.2 Text. Usage Notes If present, CNE.5 obeys the same rules of use and interpretation as described for CNE.2. 
				/// </summary>
				public class AlternateText : HL7Base<AlternateText>
				{

					private const string _id = "DRG.1.5";
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
				/// DRG.1.6 - Identifies the coding scheme being used in the alternate identifier component.  Analogous to  CNE.3 Name of Coding System.  Refer to HL7 Table 0396 - Coding Systems in Chapter 2C, Code Tables, for valid values.As of v2.7 this component is required when CNE.4 is populated and CNE.17 is not populated. Both CNE.6 and CNE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CNE.6 and/or CNE.17, the "Coding System" component or the "Coding System OID", for the tuple.Usage Notes If present, CNE.6 obeys the same rules of use and interpretation as described for CNE.3.
				/// </summary>
				public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
				{

					private const string _id = "DRG.1.6";
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
				/// DRG.1.7 - The version ID for the coding system identified by CNE.3. It belongs conceptually to components 1-3 and appears here only for reasons of backward compatibility.Usage Note If the coding system is any system other than an "HL7 coding system," version ID must be valued with an actual version ID. If the coding system is "HL7 coding system," version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. Text description of code is optional but its use should be encouraged since it makes messages easier to review for accuracy, especially during interface testing and debugging.
				/// </summary>
				public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
				{

					private const string _id = "DRG.1.7";
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
				/// DRG.1.8 - The version ID for the coding system identified by CNE.6.  It belongs conceptually to the group of Alternate components (see note 2.A.1) and appears here only for reasons of backward compatibility. Analogous to CNE.7 Coding System Version ID.Usage Notes If present, CNE.8 obeys the same rules of use and interpretation as described for CNE.7.
				/// </summary>
				public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
				{

					private const string _id = "DRG.1.8";
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
				/// DRG.1.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
				/// </summary>
				public class OriginalText : HL7Base<OriginalText>
				{

					private const string _id = "DRG.1.9";
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
				/// DRG.1.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CN-1 Identifier.
				/// </summary>
				public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
				{

					private const string _id = "DRG.1.10";
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
				/// DRG.1.11 - The descriptive or textual name of the Second Alternate Identifier. Analogous to CNE.2 Text.
				/// </summary>
				public class SecondAlternateText : HL7Base<SecondAlternateText>
				{

					private const string _id = "DRG.1.11";
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
				/// DRG.1.12 - Identifies the coding scheme being used in the Second Alternate Identifier component. Analogous to CNE.3 Name of Coding System.  Refer to HL7 Table 0396 - Coding Systems in Chapter 2C, Code Tables, for valid values.As of v2.7 this component is required when CNE.10 is populated and CNE.20 is not populated. Both CNE.12 and CNE.20 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CNE.12 and/or CNE.20, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
				{

					private const string _id = "DRG.1.12";
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
				/// DRG.1.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CNE.7 Coding System Version ID.
				/// </summary>
				public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
				{

					private const string _id = "DRG.1.13";
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
				/// DRG.1.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CNE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CNE.1 is populated and CNE.3 is not populated. Both CNE.3 and CNE.14 may be populated.
				/// </summary>
				public class CodingSystemOid : HL7Base<CodingSystemOid>
				{

					private const string _id = "DRG.1.14";
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
				/// DRG.1.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CNE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class ValueSetOid : HL7Base<ValueSetOid>
				{

					private const string _id = "DRG.1.15";
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
				/// DRG.1.16 - This component carries the version for the value set identified by CNE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CNE.15 is populated.
				/// </summary>
				public class ValueSetVersionId : HL7Base<ValueSetVersionId>
				{

					private const string _id = "DRG.1.16";
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
				/// DRG.1.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CNE.6. Analogous to CNE.14 OID for Coding System. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CNE.4 is populated and CNE.6 is not populated. Both CNE.6 and CNE.17 may be populated.
				/// </summary>
				public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
				{

					private const string _id = "DRG.1.17";
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
				/// DRG.1.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CNE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
				{

					private const string _id = "DRG.1.18";
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
				/// DRG.1.19 - This component carries the version for the value set identified by CNE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CNE.18 is populated.
				/// </summary>
				public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
				{

					private const string _id = "DRG.1.19";
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
				/// DRG.1.20 - This component contains the ISO Object Identifier (OID) from which the value in CNE.12 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined numbers, the OID registered in the HL7 OID registry should be used. This component is required when CNE.4 is populated and neither CNE.6 nor CNE.18 is populated. In short either the CNE.6 or the CNE.14 or CNE.17 must be populated when CNE.4 is populated.
				/// </summary>
				public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
				{

					private const string _id = "DRG.1.20";
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
				/// DRG.1.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CNE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
				{

					private const string _id = "DRG.1.21";
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
				/// DRG.1.22 - This component carries the version for the value set identified by CNE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CNE.21 is populated.
				/// </summary>
				public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
				{

					private const string _id = "DRG.1.22";
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
			/// DRG.2 - This field contains the time stamp to indicate the date and time that the DRG was assigned.
			/// </summary>
			public class DrgAssignedDateTime : HL7Base<DrgAssignedDateTime>
			{

				private const string _id = "DRG.2";
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
			/// DRG.3 - This field indicates if the DRG has been approved by a reviewing entity. Refer to HL7 Table 0136 - Yes/no Indicator for valid values.Y - the DRG has been approved by a reviewing entityN - the DRG has not been approved
			/// </summary>
			public class DrgApprovalIndicator : HL7Base<DrgApprovalIndicator>
			{

				private const string _id = "DRG.3";
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
			/// DRG.4 - This code indicates that the grouper results have been reviewed and approved. Refer to User-defined Table 0056 - DRG Grouper Review Code for suggested values.
			/// </summary>
			public class DrgGrouperReviewCode : HL7Base<DrgGrouperReviewCode>
			{

				private const string _id = "DRG.4";
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
				/// DRG.4.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
				/// </summary>
				public class Identifier : HL7Base<Identifier>
				{

					private const string _id = "DRG.4.1";
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
				/// DRG.4.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
				/// </summary>
				public class Text : HL7Base<Text>
				{

					private const string _id = "DRG.4.2";
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
				/// DRG.4.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
				/// </summary>
				public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
				{

					private const string _id = "DRG.4.3";
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
				/// DRG.4.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
				/// </summary>
				public class AlternateIdentifier : HL7Base<AlternateIdentifier>
				{

					private const string _id = "DRG.4.4";
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
				/// DRG.4.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
				/// </summary>
				public class AlternateText : HL7Base<AlternateText>
				{

					private const string _id = "DRG.4.5";
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
				/// DRG.4.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
				{

					private const string _id = "DRG.4.6";
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
				/// DRG.4.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
				/// </summary>
				public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
				{

					private const string _id = "DRG.4.7";
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
				/// DRG.4.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
				/// </summary>
				public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
				{

					private const string _id = "DRG.4.8";
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
				/// DRG.4.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
				/// </summary>
				public class OriginalText : HL7Base<OriginalText>
				{

					private const string _id = "DRG.4.9";
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
				/// DRG.4.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
				/// </summary>
				public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
				{

					private const string _id = "DRG.4.10";
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
				/// DRG.4.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
				/// </summary>
				public class SecondAlternateText : HL7Base<SecondAlternateText>
				{

					private const string _id = "DRG.4.11";
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
				/// DRG.4.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
				{

					private const string _id = "DRG.4.12";
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
				/// DRG.4.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
				/// </summary>
				public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
				{

					private const string _id = "DRG.4.13";
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
				/// DRG.4.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
				/// </summary>
				public class CodingSystemOid : HL7Base<CodingSystemOid>
				{

					private const string _id = "DRG.4.14";
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
				/// DRG.4.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class ValueSetOid : HL7Base<ValueSetOid>
				{

					private const string _id = "DRG.4.15";
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
				/// DRG.4.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
				/// </summary>
				public class ValueSetVersionId : HL7Base<ValueSetVersionId>
				{

					private const string _id = "DRG.4.16";
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
				/// DRG.4.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
				/// </summary>
				public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
				{

					private const string _id = "DRG.4.17";
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
				/// DRG.4.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
				{

					private const string _id = "DRG.4.18";
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
				/// DRG.4.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
				/// </summary>
				public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
				{

					private const string _id = "DRG.4.19";
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
				/// DRG.4.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
				/// </summary>
				public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
				{

					private const string _id = "DRG.4.20";
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
				/// DRG.4.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
				{

					private const string _id = "DRG.4.21";
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
				/// DRG.4.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
				/// </summary>
				public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
				{

					private const string _id = "DRG.4.22";
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
			/// DRG.5 - Refers to the type of outlier (i.e., period of care beyond DRG-standard stay in facility) that has been paid. Refer to User-defined Table 0083 - Outlier Type for suggested values.
			/// </summary>
			public class OutlierType : HL7Base<OutlierType>
			{

				private const string _id = "DRG.5";
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
				/// DRG.5.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
				/// </summary>
				public class Identifier : HL7Base<Identifier>
				{

					private const string _id = "DRG.5.1";
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
				/// DRG.5.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
				/// </summary>
				public class Text : HL7Base<Text>
				{

					private const string _id = "DRG.5.2";
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
				/// DRG.5.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
				/// </summary>
				public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
				{

					private const string _id = "DRG.5.3";
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
				/// DRG.5.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
				/// </summary>
				public class AlternateIdentifier : HL7Base<AlternateIdentifier>
				{

					private const string _id = "DRG.5.4";
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
				/// DRG.5.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
				/// </summary>
				public class AlternateText : HL7Base<AlternateText>
				{

					private const string _id = "DRG.5.5";
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
				/// DRG.5.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
				{

					private const string _id = "DRG.5.6";
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
				/// DRG.5.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
				/// </summary>
				public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
				{

					private const string _id = "DRG.5.7";
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
				/// DRG.5.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
				/// </summary>
				public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
				{

					private const string _id = "DRG.5.8";
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
				/// DRG.5.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
				/// </summary>
				public class OriginalText : HL7Base<OriginalText>
				{

					private const string _id = "DRG.5.9";
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
				/// DRG.5.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
				/// </summary>
				public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
				{

					private const string _id = "DRG.5.10";
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
				/// DRG.5.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
				/// </summary>
				public class SecondAlternateText : HL7Base<SecondAlternateText>
				{

					private const string _id = "DRG.5.11";
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
				/// DRG.5.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
				{

					private const string _id = "DRG.5.12";
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
				/// DRG.5.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
				/// </summary>
				public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
				{

					private const string _id = "DRG.5.13";
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
				/// DRG.5.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
				/// </summary>
				public class CodingSystemOid : HL7Base<CodingSystemOid>
				{

					private const string _id = "DRG.5.14";
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
				/// DRG.5.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class ValueSetOid : HL7Base<ValueSetOid>
				{

					private const string _id = "DRG.5.15";
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
				/// DRG.5.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
				/// </summary>
				public class ValueSetVersionId : HL7Base<ValueSetVersionId>
				{

					private const string _id = "DRG.5.16";
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
				/// DRG.5.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
				/// </summary>
				public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
				{

					private const string _id = "DRG.5.17";
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
				/// DRG.5.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
				{

					private const string _id = "DRG.5.18";
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
				/// DRG.5.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
				/// </summary>
				public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
				{

					private const string _id = "DRG.5.19";
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
				/// DRG.5.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
				/// </summary>
				public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
				{

					private const string _id = "DRG.5.20";
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
				/// DRG.5.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
				{

					private const string _id = "DRG.5.21";
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
				/// DRG.5.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
				/// </summary>
				public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
				{

					private const string _id = "DRG.5.22";
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
			/// DRG.6 - This field contains the number of days that have been approved as an outlier payment.
			/// </summary>
			public class OutlierDays : HL7Base<OutlierDays>
			{

				private const string _id = "DRG.6";
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
			/// DRG.7 - This field contains the amount of money that has been approved for an outlier payment.
			/// </summary>
			public class OutlierCost : HL7Base<OutlierCost>
			{

				private const string _id = "DRG.7";
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
				/// DRG.7.1 - The only required component usually containing a decimal point. Note that each component of the MO data type (Section 2.A.41, "MO - money") is a subcomponent here.
				/// </summary>
				public class Price : HL7Base<Price>
				{

					private const string _id = "DRG.7.1";
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
					/// DRG.7.1.1 - The first component is a quantity.
					/// </summary>
					public class Quantity : HL7Base<Quantity>
					{

						private const string _id = "DRG.7.1.1";
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
					/// DRG.7.1.2 - The second component is the denomination in which the quantity is expressed. The values for the denomination component are the three-character codes specified in ISO-4217. See Externally-defined Table 0913  Monetary Denomination Code.If the denomination is not specified, "MSH-17-country code", in Chapter 2, section 2.14.9.17, is used to determine the default. Example, where USD is the ISO 4217 code for the U.S. American dollar. 99.50USD
					/// </summary>
					public class Denomination : HL7Base<Denomination>
					{

						private const string _id = "DRG.7.1.2";
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
				/// DRG.7.2 - A coded value, data type ID.  Refer to HL7 Table 0205  Price Type in Chapter 2C, Code Tables, for valid values.
				/// </summary>
				public class PriceType : HL7Base<PriceType>
				{

					private const string _id = "DRG.7.2";
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
				/// DRG.7.3 - The number specifying the lower limit or boundary of the range. This component, together with the CP.4 component, specifies the "price range". The range can be defined as either time or quantity. For example, the range can indicate that the first 10 minutes of the procedure has one price. Another repetition of the data type can use the range to specify that the following 10 to 60 minutes of the procedure is charged at another price per a final repetition can specify that the final 60 to N minutes of the procedure at a third price.Note that, if the CP.2 Price Type component is TP, both CP.3 and CP.4 may be null.
				/// </summary>
				public class FromValue : HL7Base<FromValue>
				{

					private const string _id = "DRG.7.3";
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
				/// DRG.7.4 - The number specifying the high limit or boundary of the range.
				/// </summary>
				public class ToValue : HL7Base<ToValue>
				{

					private const string _id = "DRG.7.4";
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
				/// DRG.7.5 - This component describes the units associated with the range, e.g., seconds, minutes, hours, days, quantity (i.e., count).  As of v2.7 the Externally-defined Unified Code for Units of Measure (UCUM) case sensitive code is the required code for units of measure.  Refer to the externally-defined table "Unified Code for Units of Measure" (UCUM) http//aurora.rg.iupui.edu/UCUM for valid values. Local codes may be transmitted in addition to UCUM codes. This component is required if CP.3 From Value and/or CP.4 To Value are present.
				/// </summary>
				public class RangeUnits : HL7Base<RangeUnits>
				{

					private const string _id = "DRG.7.5";
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
					/// DRG.7.5.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "DRG.7.5.1";
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
					/// DRG.7.5.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "DRG.7.5.2";
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
					/// DRG.7.5.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "DRG.7.5.3";
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
					/// DRG.7.5.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "DRG.7.5.4";
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
					/// DRG.7.5.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "DRG.7.5.5";
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
					/// DRG.7.5.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "DRG.7.5.6";
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
					/// DRG.7.5.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "DRG.7.5.7";
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
					/// DRG.7.5.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "DRG.7.5.8";
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
					/// DRG.7.5.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "DRG.7.5.9";
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
					/// DRG.7.5.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "DRG.7.5.10";
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
					/// DRG.7.5.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "DRG.7.5.11";
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
					/// DRG.7.5.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "DRG.7.5.12";
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
					/// DRG.7.5.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "DRG.7.5.13";
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
					/// DRG.7.5.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "DRG.7.5.14";
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
					/// DRG.7.5.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "DRG.7.5.15";
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
					/// DRG.7.5.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "DRG.7.5.16";
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
					/// DRG.7.5.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "DRG.7.5.17";
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
					/// DRG.7.5.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "DRG.7.5.18";
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
					/// DRG.7.5.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "DRG.7.5.19";
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
					/// DRG.7.5.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "DRG.7.5.20";
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
					/// DRG.7.5.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "DRG.7.5.21";
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
					/// DRG.7.5.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "DRG.7.5.22";
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
				/// DRG.7.6 - Refer to HL7 Table 0298 - CP Range Type for valid values.
				/// </summary>
				public class RangeType : HL7Base<RangeType>
				{

					private const string _id = "DRG.7.6";
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
			/// DRG.8 - This field indicates the associated DRG Payor. Refer to User-defined Table 0229 - DRG Payor for suggested values.
			/// </summary>
			public class DrgPayor : HL7Base<DrgPayor>
			{

				private const string _id = "DRG.8";
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
				/// DRG.8.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
				/// </summary>
				public class Identifier : HL7Base<Identifier>
				{

					private const string _id = "DRG.8.1";
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
				/// DRG.8.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
				/// </summary>
				public class Text : HL7Base<Text>
				{

					private const string _id = "DRG.8.2";
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
				/// DRG.8.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
				/// </summary>
				public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
				{

					private const string _id = "DRG.8.3";
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
				/// DRG.8.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
				/// </summary>
				public class AlternateIdentifier : HL7Base<AlternateIdentifier>
				{

					private const string _id = "DRG.8.4";
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
				/// DRG.8.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
				/// </summary>
				public class AlternateText : HL7Base<AlternateText>
				{

					private const string _id = "DRG.8.5";
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
				/// DRG.8.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
				{

					private const string _id = "DRG.8.6";
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
				/// DRG.8.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
				/// </summary>
				public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
				{

					private const string _id = "DRG.8.7";
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
				/// DRG.8.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
				/// </summary>
				public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
				{

					private const string _id = "DRG.8.8";
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
				/// DRG.8.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
				/// </summary>
				public class OriginalText : HL7Base<OriginalText>
				{

					private const string _id = "DRG.8.9";
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
				/// DRG.8.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
				/// </summary>
				public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
				{

					private const string _id = "DRG.8.10";
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
				/// DRG.8.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
				/// </summary>
				public class SecondAlternateText : HL7Base<SecondAlternateText>
				{

					private const string _id = "DRG.8.11";
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
				/// DRG.8.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
				{

					private const string _id = "DRG.8.12";
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
				/// DRG.8.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
				/// </summary>
				public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
				{

					private const string _id = "DRG.8.13";
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
				/// DRG.8.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
				/// </summary>
				public class CodingSystemOid : HL7Base<CodingSystemOid>
				{

					private const string _id = "DRG.8.14";
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
				/// DRG.8.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class ValueSetOid : HL7Base<ValueSetOid>
				{

					private const string _id = "DRG.8.15";
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
				/// DRG.8.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
				/// </summary>
				public class ValueSetVersionId : HL7Base<ValueSetVersionId>
				{

					private const string _id = "DRG.8.16";
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
				/// DRG.8.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
				/// </summary>
				public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
				{

					private const string _id = "DRG.8.17";
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
				/// DRG.8.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
				{

					private const string _id = "DRG.8.18";
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
				/// DRG.8.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
				/// </summary>
				public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
				{

					private const string _id = "DRG.8.19";
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
				/// DRG.8.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
				/// </summary>
				public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
				{

					private const string _id = "DRG.8.20";
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
				/// DRG.8.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
				{

					private const string _id = "DRG.8.21";
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
				/// DRG.8.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
				/// </summary>
				public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
				{

					private const string _id = "DRG.8.22";
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
			/// DRG.9 - Where applicable, the outlier reimbursement amount indicates the part of the total reimbursement designated for reimbursement of outlier conditions (day or cost).
			/// </summary>
			public class OutlierReimbursement : HL7Base<OutlierReimbursement>
			{

				private const string _id = "DRG.9";
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
				/// DRG.9.1 - The only required component usually containing a decimal point. Note that each component of the MO data type (Section 2.A.41, "MO - money") is a subcomponent here.
				/// </summary>
				public class Price : HL7Base<Price>
				{

					private const string _id = "DRG.9.1";
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
					/// DRG.9.1.1 - The first component is a quantity.
					/// </summary>
					public class Quantity : HL7Base<Quantity>
					{

						private const string _id = "DRG.9.1.1";
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
					/// DRG.9.1.2 - The second component is the denomination in which the quantity is expressed. The values for the denomination component are the three-character codes specified in ISO-4217. See Externally-defined Table 0913  Monetary Denomination Code.If the denomination is not specified, "MSH-17-country code", in Chapter 2, section 2.14.9.17, is used to determine the default. Example, where USD is the ISO 4217 code for the U.S. American dollar. 99.50USD
					/// </summary>
					public class Denomination : HL7Base<Denomination>
					{

						private const string _id = "DRG.9.1.2";
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
				/// DRG.9.2 - A coded value, data type ID.  Refer to HL7 Table 0205  Price Type in Chapter 2C, Code Tables, for valid values.
				/// </summary>
				public class PriceType : HL7Base<PriceType>
				{

					private const string _id = "DRG.9.2";
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
				/// DRG.9.3 - The number specifying the lower limit or boundary of the range. This component, together with the CP.4 component, specifies the "price range". The range can be defined as either time or quantity. For example, the range can indicate that the first 10 minutes of the procedure has one price. Another repetition of the data type can use the range to specify that the following 10 to 60 minutes of the procedure is charged at another price per a final repetition can specify that the final 60 to N minutes of the procedure at a third price.Note that, if the CP.2 Price Type component is TP, both CP.3 and CP.4 may be null.
				/// </summary>
				public class FromValue : HL7Base<FromValue>
				{

					private const string _id = "DRG.9.3";
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
				/// DRG.9.4 - The number specifying the high limit or boundary of the range.
				/// </summary>
				public class ToValue : HL7Base<ToValue>
				{

					private const string _id = "DRG.9.4";
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
				/// DRG.9.5 - This component describes the units associated with the range, e.g., seconds, minutes, hours, days, quantity (i.e., count).  As of v2.7 the Externally-defined Unified Code for Units of Measure (UCUM) case sensitive code is the required code for units of measure.  Refer to the externally-defined table "Unified Code for Units of Measure" (UCUM) http//aurora.rg.iupui.edu/UCUM for valid values. Local codes may be transmitted in addition to UCUM codes. This component is required if CP.3 From Value and/or CP.4 To Value are present.
				/// </summary>
				public class RangeUnits : HL7Base<RangeUnits>
				{

					private const string _id = "DRG.9.5";
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
					/// DRG.9.5.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "DRG.9.5.1";
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
					/// DRG.9.5.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "DRG.9.5.2";
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
					/// DRG.9.5.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "DRG.9.5.3";
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
					/// DRG.9.5.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "DRG.9.5.4";
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
					/// DRG.9.5.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "DRG.9.5.5";
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
					/// DRG.9.5.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "DRG.9.5.6";
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
					/// DRG.9.5.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "DRG.9.5.7";
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
					/// DRG.9.5.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "DRG.9.5.8";
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
					/// DRG.9.5.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "DRG.9.5.9";
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
					/// DRG.9.5.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "DRG.9.5.10";
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
					/// DRG.9.5.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "DRG.9.5.11";
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
					/// DRG.9.5.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "DRG.9.5.12";
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
					/// DRG.9.5.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "DRG.9.5.13";
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
					/// DRG.9.5.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "DRG.9.5.14";
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
					/// DRG.9.5.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "DRG.9.5.15";
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
					/// DRG.9.5.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "DRG.9.5.16";
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
					/// DRG.9.5.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "DRG.9.5.17";
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
					/// DRG.9.5.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "DRG.9.5.18";
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
					/// DRG.9.5.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "DRG.9.5.19";
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
					/// DRG.9.5.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "DRG.9.5.20";
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
					/// DRG.9.5.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "DRG.9.5.21";
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
					/// DRG.9.5.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "DRG.9.5.22";
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
				/// DRG.9.6 - Refer to HL7 Table 0298 - CP Range Type for valid values.
				/// </summary>
				public class RangeType : HL7Base<RangeType>
				{

					private const string _id = "DRG.9.6";
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
			/// DRG.10 - This field indicates if the DRG contains a confidential diagnosis. Refer to HL7 Table 0136 - Yes/no Indicator for valid values.Y - the DRG contains a confidential diagnosisN - the DRG does not contain a confidential diagnosis
			/// </summary>
			public class ConfidentialIndicator : HL7Base<ConfidentialIndicator>
			{

				private const string _id = "DRG.10";
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
			/// DRG.11 - This field indicates the type of hospital receiving a transfer patient, which affects how a facility is reimbursed under diagnosis related group (DRGs), for example, exempt or non-exempt. Refer to User-defined Table 0415 - DRG Transfer Type for suggested values.
			/// </summary>
			public class DrgTransferType : HL7Base<DrgTransferType>
			{

				private const string _id = "DRG.11";
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
				/// DRG.11.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
				/// </summary>
				public class Identifier : HL7Base<Identifier>
				{

					private const string _id = "DRG.11.1";
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
				/// DRG.11.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
				/// </summary>
				public class Text : HL7Base<Text>
				{

					private const string _id = "DRG.11.2";
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
				/// DRG.11.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
				/// </summary>
				public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
				{

					private const string _id = "DRG.11.3";
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
				/// DRG.11.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
				/// </summary>
				public class AlternateIdentifier : HL7Base<AlternateIdentifier>
				{

					private const string _id = "DRG.11.4";
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
				/// DRG.11.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
				/// </summary>
				public class AlternateText : HL7Base<AlternateText>
				{

					private const string _id = "DRG.11.5";
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
				/// DRG.11.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
				{

					private const string _id = "DRG.11.6";
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
				/// DRG.11.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
				/// </summary>
				public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
				{

					private const string _id = "DRG.11.7";
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
				/// DRG.11.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
				/// </summary>
				public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
				{

					private const string _id = "DRG.11.8";
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
				/// DRG.11.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
				/// </summary>
				public class OriginalText : HL7Base<OriginalText>
				{

					private const string _id = "DRG.11.9";
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
				/// DRG.11.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
				/// </summary>
				public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
				{

					private const string _id = "DRG.11.10";
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
				/// DRG.11.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
				/// </summary>
				public class SecondAlternateText : HL7Base<SecondAlternateText>
				{

					private const string _id = "DRG.11.11";
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
				/// DRG.11.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
				{

					private const string _id = "DRG.11.12";
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
				/// DRG.11.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
				/// </summary>
				public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
				{

					private const string _id = "DRG.11.13";
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
				/// DRG.11.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
				/// </summary>
				public class CodingSystemOid : HL7Base<CodingSystemOid>
				{

					private const string _id = "DRG.11.14";
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
				/// DRG.11.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class ValueSetOid : HL7Base<ValueSetOid>
				{

					private const string _id = "DRG.11.15";
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
				/// DRG.11.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
				/// </summary>
				public class ValueSetVersionId : HL7Base<ValueSetVersionId>
				{

					private const string _id = "DRG.11.16";
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
				/// DRG.11.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
				/// </summary>
				public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
				{

					private const string _id = "DRG.11.17";
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
				/// DRG.11.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
				{

					private const string _id = "DRG.11.18";
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
				/// DRG.11.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
				/// </summary>
				public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
				{

					private const string _id = "DRG.11.19";
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
				/// DRG.11.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
				/// </summary>
				public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
				{

					private const string _id = "DRG.11.20";
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
				/// DRG.11.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
				{

					private const string _id = "DRG.11.21";
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
				/// DRG.11.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
				/// </summary>
				public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
				{

					private const string _id = "DRG.11.22";
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
			/// DRG.12 - This field holds the name of the person ("coder") who supervised or undertook the determination of the DRG code.
			/// </summary>
			public class NameOfCoder : HL7Base<NameOfCoder>
			{

				private const string _id = "DRG.12";
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
				/// DRG.12.1 - This component allows full specification of the surname of a person. Where appropriate, it differentiates the person's own surname from that of the person's partner or spouse, in cases where the person's name may contain elements from either name. It also permits messages to distinguish the surname prefix (such as "van" or "de") from the surname root. See section 2.A.30, "FN - family name".XPN.1 will be empty when XPN.7 is MSK. It MAY be empty when XPN.7 is NAV.Usage Note If a persons name has only one component, that name will be sent in XPN.1 Family Name. This is common practice in some countries such as Indonesia. This note does not cover the case where only one part of a person's multi-part name is known (e.g., only know "John" of "John Doe").
				/// </summary>
				public class FamilyName : HL7Base<FamilyName>
				{

					private const string _id = "DRG.12.1";
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
					/// DRG.12.1.1 - The atomic element of the person's family name. In most Western usage, this is the person's last name.
					/// </summary>
					public class Surname : HL7Base<Surname>
					{

						private const string _id = "DRG.12.1.1";
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
					/// DRG.12.1.2 - Internationalization usage for Germanic languages. This component is optional. An example of a surname prefix is the "van" in "Ludwig van Beethoven". Since the surname prefix doesn't sort completely alphabetically, it is reasonable to specify it as a separate sub-component of the PN and extended PN data types (XPN and XCN).Note Subcomponents own surname prefix, own surname, surname prefix from partner/spouse and surname from partner/spouse decompose complex Germanic names such as Martha de Mum-van Beethoven. If these subcomponents are valued, the surname subcomponent should still be fully valued for backward compatibility, i.e., de Mum-van Beethoven&de&Mum&van&Beethoven.Also, for clarity, the last name prefix has been renamed to own surname prefix.
					/// </summary>
					public class OwnSurnamePrefix : HL7Base<OwnSurnamePrefix>
					{

						private const string _id = "DRG.12.1.2";
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
					/// DRG.12.1.3 - The portion of the surname (in most Western usage, the last name) that is derived from the person's own surname, as distinguished from any portion that is derived from the surname of the person's partner or spouse. This component is optional.If the person's surname has legally changed to become (or incorporate) the surname of the person's partner or spouse, this is the person's surname immediately prior to such change. Often this is the person's "maiden name".
					/// </summary>
					public class OwnSurname : HL7Base<OwnSurname>
					{

						private const string _id = "DRG.12.1.3";
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
					/// DRG.12.1.4 - Internationalization usage for Germanic languages. This component is optional. An example of a surname prefix is the van in "Ludwig van Beethoven". Since the surname prefix doesn't sort completely alphabetically, it is reasonable to specify it as a separate sub-component of the PN and extended PN data types (XPN and XCN). Note Subcomponents own surname prefix, own surname, surname prefix from partner/spouse and surname from partner/spouse decompose complex Germanic names such as Martha de Mum-van Beethoven. If these subcomponents are valued, the surname subcomponent should still be fully valued for backward compatibility, i.e., de Mum-van Beethoven&de&Mum&van&Beethoven.Also, for clarity, the last name prefix has been renamed to own surname prefix.
					/// </summary>
					public class SurnamePrefixFromPartnerSpouse : HL7Base<SurnamePrefixFromPartnerSpouse>
					{

						private const string _id = "DRG.12.1.4";
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
					/// DRG.12.1.5 - The portion of the person's surname (in most Western usage, the last name) that is derived from the surname of the person's partner or spouse, as distinguished from the part derived from the person's own surname. This component is optional.If no portion of the person's surname is derived from the surname of the person's partner or spouse, this component is not valued. Otherwise, if the surname of the partner or spouse has legally changed to become (or incorporate) the person's surname, this is the surname of the partner or spouse immediately prior to such change.
					/// </summary>
					public class SurnameFromPartnerSpouse : HL7Base<SurnameFromPartnerSpouse>
					{

						private const string _id = "DRG.12.1.5";
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
				/// DRG.12.2 - First name.
				/// </summary>
				public class GivenName : HL7Base<GivenName>
				{

					private const string _id = "DRG.12.2";
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
				/// DRG.12.3 - Multiple middle names may be included by separating them with spaces.
				/// </summary>
				public class SecondAndFurtherGivenNamesOrInitialsThereof : HL7Base<SecondAndFurtherGivenNamesOrInitialsThereof>
				{

					private const string _id = "DRG.12.3";
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
				/// DRG.12.4 - Used to specify a name suffix (e.g., Jr. or III).
				/// </summary>
				public class SuffixegJrOrIii : HL7Base<SuffixegJrOrIii>
				{

					private const string _id = "DRG.12.4";
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
				/// DRG.12.5 - Used to specify a name prefix (e.g., Dr.).
				/// </summary>
				public class PrefixegDr : HL7Base<PrefixegDr>
				{

					private const string _id = "DRG.12.5";
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
				/// DRG.12.6 - Attention The XPN-6 component was deprecated as of v2.5 and the detail was withdrawn and removed from the standard as of v 2.7. See XPN.14 Professional Suffix.
				/// </summary>
				public class DegreeegMd : HL7Base<DegreeegMd>
				{

					private const string _id = "DRG.12.6";
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
				/// DRG.12.7 - A code that represents the type of name. Refer to HL7 Table 0200 - Name Type for valid values.Note The content of Legal Name is country specific. In the US the legal name is the same as the current married name.
				/// </summary>
				public class NameTypeCode : HL7Base<NameTypeCode>
				{

					private const string _id = "DRG.12.7";
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
				/// DRG.12.8 - Different name/address types and representations of the same name/address should be described by repeating of this field, with different values of the name/address type and/or name/address representation component.Note This new component remains in "alphabetic" representation with each repetition of the field using these data types, i.e., even though the name may be represented in an ideographic character set, this component will remain represented in an alphabetic character set.Refer to HL7 Table 0465  Name/address Representation for valid values.In general this component provides an indication of the representation provided by the data item. It does not necessarily specify the character sets used. Thus, even though the representation might provide an indication of what to expect, the sender is still free to encode the contents using whatever character set is desired. This component provides only hints for the receiver, so it can make choices regarding what it has been sent and what it is capable of displaying.
				/// </summary>
				public class NameRepresentationCode : HL7Base<NameRepresentationCode>
				{

					private const string _id = "DRG.12.8";
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
				/// DRG.12.9 - This component is used to designate the context in which a name is used. The main use case is in Australian healthcare for indigenous patients who prefer to use different names when attending different healthcare institutions. Another use case occurs in the US where health practitioners can be licensed under slightly different names and the reporting of the correct name is vital for administrative purposes. Refer to User-defined Table 0448  Name Context for suggested values.
				/// </summary>
				public class NameContext : HL7Base<NameContext>
				{

					private const string _id = "DRG.12.9";
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
					/// DRG.12.9.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "DRG.12.9.1";
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
					/// DRG.12.9.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "DRG.12.9.2";
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
					/// DRG.12.9.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "DRG.12.9.3";
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
					/// DRG.12.9.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "DRG.12.9.4";
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
					/// DRG.12.9.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "DRG.12.9.5";
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
					/// DRG.12.9.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "DRG.12.9.6";
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
					/// DRG.12.9.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "DRG.12.9.7";
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
					/// DRG.12.9.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "DRG.12.9.8";
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
					/// DRG.12.9.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "DRG.12.9.9";
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
					/// DRG.12.9.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "DRG.12.9.10";
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
					/// DRG.12.9.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "DRG.12.9.11";
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
					/// DRG.12.9.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "DRG.12.9.12";
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
					/// DRG.12.9.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "DRG.12.9.13";
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
					/// DRG.12.9.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "DRG.12.9.14";
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
					/// DRG.12.9.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "DRG.12.9.15";
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
					/// DRG.12.9.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "DRG.12.9.16";
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
					/// DRG.12.9.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "DRG.12.9.17";
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
					/// DRG.12.9.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "DRG.12.9.18";
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
					/// DRG.12.9.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "DRG.12.9.19";
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
					/// DRG.12.9.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "DRG.12.9.20";
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
					/// DRG.12.9.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "DRG.12.9.21";
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
					/// DRG.12.9.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "DRG.12.9.22";
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
				/// DRG.12.10 - Attention The XPN.10 component was deprecated as of v2.5 and the detail was withdrawn and removed from the standard as of v2.7. Refer to 2.A.89.12, "Effective date (DTM)" and 2.A.89.13, "Expiration date (DTM)" components.
				/// </summary>
				public class NameValidityRange : HL7Base<NameValidityRange>
				{

					private const string _id = "DRG.12.10";
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
				/// DRG.12.11 - A code that represents the preferred display order of the components of this person name. Refer to HL7 0444  Name Assembly Order for valid values.
				/// </summary>
				public class NameAssemblyOrder : HL7Base<NameAssemblyOrder>
				{

					private const string _id = "DRG.12.11";
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
				/// DRG.12.12 - The first date, if known, on which the person name is valid and active.
				/// </summary>
				public class EffectiveDate : HL7Base<EffectiveDate>
				{

					private const string _id = "DRG.12.12";
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
				/// DRG.12.13 - The last date, if known, on which the person name is valid and active.
				/// </summary>
				public class ExpirationDate : HL7Base<ExpirationDate>
				{

					private const string _id = "DRG.12.13";
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
				/// DRG.12.14 - Used to specify an abbreviation, or a string of abbreviations denoting qualifications that support the persons profession, (e.g., licenses, certificates, degrees, affiliations with professional societies, etc.). The Professional Suffix normally follows the Family Name when the Person Name is used for display purposes. Please note that this component is an unformatted string and is used for display purposes only. Detailed information regarding the contents of Professional Suffix is obtained using appropriate segments in Chapter 15, Personnel Management.
				/// </summary>
				public class ProfessionalSuffix : HL7Base<ProfessionalSuffix>
				{

					private const string _id = "DRG.12.14";
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
				/// DRG.12.15 - A "called by" name is the name that is preferred when a person is directly addressed sometimes known as a nickname.Note The called by component contains a name that could be categorized as a nickname using the name usage types in HL7 Table 0200 - Name type. Its use is reserved for instances in which the nickname is a single name part that is provided in addition to a name that has some other type, such as legal. It is understood that the "called by" name is not part of the full name. Where a nickname has more parts, possibly including a family name, a different XPN with a type of nickname should instead be used.Examples - James Robert Smith is Called By Jim Bob - James Robert Smith is Called By JR - Peter Richard Smith is Called By Richard - Mary Margaret Elizabeth Jones is Called By Meg.
				/// </summary>
				public class CalledBy : HL7Base<CalledBy>
				{

					private const string _id = "DRG.12.15";
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
			/// DRG.13 - This field indicates the grouper status in general. Refer to Externally-defined Table 0734 - Grouper Status for suggested values.
			/// </summary>
			public class GrouperStatus : HL7Base<GrouperStatus>
			{

				private const string _id = "DRG.13";
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
				/// DRG.13.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
				/// </summary>
				public class Identifier : HL7Base<Identifier>
				{

					private const string _id = "DRG.13.1";
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
				/// DRG.13.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
				/// </summary>
				public class Text : HL7Base<Text>
				{

					private const string _id = "DRG.13.2";
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
				/// DRG.13.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
				/// </summary>
				public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
				{

					private const string _id = "DRG.13.3";
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
				/// DRG.13.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
				/// </summary>
				public class AlternateIdentifier : HL7Base<AlternateIdentifier>
				{

					private const string _id = "DRG.13.4";
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
				/// DRG.13.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
				/// </summary>
				public class AlternateText : HL7Base<AlternateText>
				{

					private const string _id = "DRG.13.5";
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
				/// DRG.13.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
				{

					private const string _id = "DRG.13.6";
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
				/// DRG.13.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
				/// </summary>
				public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
				{

					private const string _id = "DRG.13.7";
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
				/// DRG.13.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
				/// </summary>
				public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
				{

					private const string _id = "DRG.13.8";
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
				/// DRG.13.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
				/// </summary>
				public class OriginalText : HL7Base<OriginalText>
				{

					private const string _id = "DRG.13.9";
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
				/// DRG.13.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
				/// </summary>
				public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
				{

					private const string _id = "DRG.13.10";
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
				/// DRG.13.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
				/// </summary>
				public class SecondAlternateText : HL7Base<SecondAlternateText>
				{

					private const string _id = "DRG.13.11";
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
				/// DRG.13.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
				{

					private const string _id = "DRG.13.12";
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
				/// DRG.13.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
				/// </summary>
				public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
				{

					private const string _id = "DRG.13.13";
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
				/// DRG.13.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
				/// </summary>
				public class CodingSystemOid : HL7Base<CodingSystemOid>
				{

					private const string _id = "DRG.13.14";
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
				/// DRG.13.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class ValueSetOid : HL7Base<ValueSetOid>
				{

					private const string _id = "DRG.13.15";
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
				/// DRG.13.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
				/// </summary>
				public class ValueSetVersionId : HL7Base<ValueSetVersionId>
				{

					private const string _id = "DRG.13.16";
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
				/// DRG.13.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
				/// </summary>
				public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
				{

					private const string _id = "DRG.13.17";
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
				/// DRG.13.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
				{

					private const string _id = "DRG.13.18";
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
				/// DRG.13.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
				/// </summary>
				public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
				{

					private const string _id = "DRG.13.19";
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
				/// DRG.13.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
				/// </summary>
				public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
				{

					private const string _id = "DRG.13.20";
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
				/// DRG.13.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
				{

					private const string _id = "DRG.13.21";
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
				/// DRG.13.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
				/// </summary>
				public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
				{

					private const string _id = "DRG.13.22";
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
			/// DRG.14 - This field indicates the PCCL (Patient Clinical Complexity Level) value for the calculated DRG as a single value. This value is calculated based on all individual CCL values calculated so far in relation to the basic DRG. Refer to Externally-defined Table 0728 - CCL Value for suggested values.
			/// </summary>
			public class PcclValueCode : HL7Base<PcclValueCode>
			{

				private const string _id = "DRG.14";
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
				/// DRG.14.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
				/// </summary>
				public class Identifier : HL7Base<Identifier>
				{

					private const string _id = "DRG.14.1";
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
				/// DRG.14.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
				/// </summary>
				public class Text : HL7Base<Text>
				{

					private const string _id = "DRG.14.2";
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
				/// DRG.14.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
				/// </summary>
				public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
				{

					private const string _id = "DRG.14.3";
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
				/// DRG.14.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
				/// </summary>
				public class AlternateIdentifier : HL7Base<AlternateIdentifier>
				{

					private const string _id = "DRG.14.4";
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
				/// DRG.14.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
				/// </summary>
				public class AlternateText : HL7Base<AlternateText>
				{

					private const string _id = "DRG.14.5";
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
				/// DRG.14.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
				{

					private const string _id = "DRG.14.6";
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
				/// DRG.14.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
				/// </summary>
				public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
				{

					private const string _id = "DRG.14.7";
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
				/// DRG.14.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
				/// </summary>
				public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
				{

					private const string _id = "DRG.14.8";
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
				/// DRG.14.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
				/// </summary>
				public class OriginalText : HL7Base<OriginalText>
				{

					private const string _id = "DRG.14.9";
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
				/// DRG.14.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
				/// </summary>
				public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
				{

					private const string _id = "DRG.14.10";
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
				/// DRG.14.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
				/// </summary>
				public class SecondAlternateText : HL7Base<SecondAlternateText>
				{

					private const string _id = "DRG.14.11";
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
				/// DRG.14.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
				{

					private const string _id = "DRG.14.12";
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
				/// DRG.14.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
				/// </summary>
				public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
				{

					private const string _id = "DRG.14.13";
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
				/// DRG.14.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
				/// </summary>
				public class CodingSystemOid : HL7Base<CodingSystemOid>
				{

					private const string _id = "DRG.14.14";
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
				/// DRG.14.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class ValueSetOid : HL7Base<ValueSetOid>
				{

					private const string _id = "DRG.14.15";
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
				/// DRG.14.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
				/// </summary>
				public class ValueSetVersionId : HL7Base<ValueSetVersionId>
				{

					private const string _id = "DRG.14.16";
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
				/// DRG.14.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
				/// </summary>
				public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
				{

					private const string _id = "DRG.14.17";
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
				/// DRG.14.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
				{

					private const string _id = "DRG.14.18";
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
				/// DRG.14.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
				/// </summary>
				public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
				{

					private const string _id = "DRG.14.19";
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
				/// DRG.14.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
				/// </summary>
				public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
				{

					private const string _id = "DRG.14.20";
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
				/// DRG.14.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
				{

					private const string _id = "DRG.14.21";
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
				/// DRG.14.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
				/// </summary>
				public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
				{

					private const string _id = "DRG.14.22";
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
			/// DRG.15 - This field contains the effective weight as calculated for this DRG. When exceeding the upper or lower trim point the effective weight is lower or higher.
			/// </summary>
			public class EffectiveWeight : HL7Base<EffectiveWeight>
			{

				private const string _id = "DRG.15";
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
			/// DRG.16 - This field contains the monetary amount as calculated for this DRG, i.e., the sum of money the insurance company will pay.
			/// </summary>
			public class MonetaryAmount : HL7Base<MonetaryAmount>
			{

				private const string _id = "DRG.16";
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
				/// DRG.16.1 - The first component is a quantity.
				/// </summary>
				public class Quantity : HL7Base<Quantity>
				{

					private const string _id = "DRG.16.1";
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
				/// DRG.16.2 - The second component is the denomination in which the quantity is expressed. The values for the denomination component are the three-character codes specified in ISO-4217. See Externally-defined Table 0913  Monetary Denomination Code.If the denomination is not specified, "MSH-17-country code", in Chapter 2, section 2.14.9.17, is used to determine the default. Example, where USD is the ISO 4217 code for the U.S. American dollar. 99.50USD
				/// </summary>
				public class Denomination : HL7Base<Denomination>
				{

					private const string _id = "DRG.16.2";
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
			/// DRG.17 - This field contains the status of the patient concerning the financial aspects. It indicates whether the length of stay is normal or respectively shorter or longer than normal. Refer to User-defined Table 0739  DRG Status Patient for suggested values.This field is also used along with DRG-23 and DRG-24 as an indication of whether a surcharge (long length of stay) or a discount (short length of stay) has been determined.
			/// </summary>
			public class StatusPatient : HL7Base<StatusPatient>
			{

				private const string _id = "DRG.17";
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
				/// DRG.17.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
				/// </summary>
				public class Identifier : HL7Base<Identifier>
				{

					private const string _id = "DRG.17.1";
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
				/// DRG.17.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
				/// </summary>
				public class Text : HL7Base<Text>
				{

					private const string _id = "DRG.17.2";
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
				/// DRG.17.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
				/// </summary>
				public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
				{

					private const string _id = "DRG.17.3";
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
				/// DRG.17.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
				/// </summary>
				public class AlternateIdentifier : HL7Base<AlternateIdentifier>
				{

					private const string _id = "DRG.17.4";
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
				/// DRG.17.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
				/// </summary>
				public class AlternateText : HL7Base<AlternateText>
				{

					private const string _id = "DRG.17.5";
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
				/// DRG.17.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
				{

					private const string _id = "DRG.17.6";
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
				/// DRG.17.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
				/// </summary>
				public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
				{

					private const string _id = "DRG.17.7";
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
				/// DRG.17.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
				/// </summary>
				public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
				{

					private const string _id = "DRG.17.8";
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
				/// DRG.17.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
				/// </summary>
				public class OriginalText : HL7Base<OriginalText>
				{

					private const string _id = "DRG.17.9";
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
				/// DRG.17.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
				/// </summary>
				public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
				{

					private const string _id = "DRG.17.10";
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
				/// DRG.17.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
				/// </summary>
				public class SecondAlternateText : HL7Base<SecondAlternateText>
				{

					private const string _id = "DRG.17.11";
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
				/// DRG.17.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
				{

					private const string _id = "DRG.17.12";
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
				/// DRG.17.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
				/// </summary>
				public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
				{

					private const string _id = "DRG.17.13";
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
				/// DRG.17.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
				/// </summary>
				public class CodingSystemOid : HL7Base<CodingSystemOid>
				{

					private const string _id = "DRG.17.14";
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
				/// DRG.17.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class ValueSetOid : HL7Base<ValueSetOid>
				{

					private const string _id = "DRG.17.15";
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
				/// DRG.17.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
				/// </summary>
				public class ValueSetVersionId : HL7Base<ValueSetVersionId>
				{

					private const string _id = "DRG.17.16";
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
				/// DRG.17.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
				/// </summary>
				public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
				{

					private const string _id = "DRG.17.17";
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
				/// DRG.17.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
				{

					private const string _id = "DRG.17.18";
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
				/// DRG.17.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
				/// </summary>
				public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
				{

					private const string _id = "DRG.17.19";
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
				/// DRG.17.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
				/// </summary>
				public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
				{

					private const string _id = "DRG.17.20";
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
				/// DRG.17.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
				{

					private const string _id = "DRG.17.21";
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
				/// DRG.17.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
				/// </summary>
				public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
				{

					private const string _id = "DRG.17.22";
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
			/// DRG.18 - This field contains the name of the software used for grouping.
			/// </summary>
			public class GrouperSoftwareName : HL7Base<GrouperSoftwareName>
			{

				private const string _id = "DRG.18";
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
			/// DRG.19 - This field contains the version information of the software used for grouping.
			/// </summary>
			public class GrouperSoftwareVersion : HL7Base<GrouperSoftwareVersion>
			{

				private const string _id = "DRG.19";
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
			/// DRG.20 - This field contains the status of the DRG calculation regarding the financial aspects. Refer to User-defined Table 0742  DRG Status Financial Calculation for suggested values.
			/// </summary>
			public class StatusFinancialCalculation : HL7Base<StatusFinancialCalculation>
			{

				private const string _id = "DRG.20";
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
				/// DRG.20.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
				/// </summary>
				public class Identifier : HL7Base<Identifier>
				{

					private const string _id = "DRG.20.1";
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
				/// DRG.20.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
				/// </summary>
				public class Text : HL7Base<Text>
				{

					private const string _id = "DRG.20.2";
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
				/// DRG.20.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
				/// </summary>
				public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
				{

					private const string _id = "DRG.20.3";
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
				/// DRG.20.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
				/// </summary>
				public class AlternateIdentifier : HL7Base<AlternateIdentifier>
				{

					private const string _id = "DRG.20.4";
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
				/// DRG.20.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
				/// </summary>
				public class AlternateText : HL7Base<AlternateText>
				{

					private const string _id = "DRG.20.5";
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
				/// DRG.20.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
				{

					private const string _id = "DRG.20.6";
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
				/// DRG.20.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
				/// </summary>
				public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
				{

					private const string _id = "DRG.20.7";
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
				/// DRG.20.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
				/// </summary>
				public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
				{

					private const string _id = "DRG.20.8";
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
				/// DRG.20.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
				/// </summary>
				public class OriginalText : HL7Base<OriginalText>
				{

					private const string _id = "DRG.20.9";
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
				/// DRG.20.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
				/// </summary>
				public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
				{

					private const string _id = "DRG.20.10";
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
				/// DRG.20.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
				/// </summary>
				public class SecondAlternateText : HL7Base<SecondAlternateText>
				{

					private const string _id = "DRG.20.11";
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
				/// DRG.20.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
				{

					private const string _id = "DRG.20.12";
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
				/// DRG.20.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
				/// </summary>
				public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
				{

					private const string _id = "DRG.20.13";
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
				/// DRG.20.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
				/// </summary>
				public class CodingSystemOid : HL7Base<CodingSystemOid>
				{

					private const string _id = "DRG.20.14";
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
				/// DRG.20.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class ValueSetOid : HL7Base<ValueSetOid>
				{

					private const string _id = "DRG.20.15";
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
				/// DRG.20.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
				/// </summary>
				public class ValueSetVersionId : HL7Base<ValueSetVersionId>
				{

					private const string _id = "DRG.20.16";
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
				/// DRG.20.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
				/// </summary>
				public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
				{

					private const string _id = "DRG.20.17";
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
				/// DRG.20.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
				{

					private const string _id = "DRG.20.18";
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
				/// DRG.20.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
				/// </summary>
				public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
				{

					private const string _id = "DRG.20.19";
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
				/// DRG.20.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
				/// </summary>
				public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
				{

					private const string _id = "DRG.20.20";
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
				/// DRG.20.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
				{

					private const string _id = "DRG.20.21";
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
				/// DRG.20.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
				/// </summary>
				public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
				{

					private const string _id = "DRG.20.22";
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
			/// DRG.21 - There will be a discount/surcharge for the calculated price due to a very short stay, early referral or a very long stay. This field contains the discount or surcharge that is included in the final price.
			/// </summary>
			public class RelativeDiscountSurcharge : HL7Base<RelativeDiscountSurcharge>
			{

				private const string _id = "DRG.21";
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
				/// DRG.21.1 - The first component is a quantity.
				/// </summary>
				public class Quantity : HL7Base<Quantity>
				{

					private const string _id = "DRG.21.1";
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
				/// DRG.21.2 - The second component is the denomination in which the quantity is expressed. The values for the denomination component are the three-character codes specified in ISO-4217. See Externally-defined Table 0913  Monetary Denomination Code.If the denomination is not specified, "MSH-17-country code", in Chapter 2, section 2.14.9.17, is used to determine the default. Example, where USD is the ISO 4217 code for the U.S. American dollar. 99.50USD
				/// </summary>
				public class Denomination : HL7Base<Denomination>
				{

					private const string _id = "DRG.21.2";
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
			/// DRG.22 - The basic charge is calculated as a multiplication of the relative weight with the base rate.
			/// </summary>
			public class BasicCharge : HL7Base<BasicCharge>
			{

				private const string _id = "DRG.22";
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
				/// DRG.22.1 - The first component is a quantity.
				/// </summary>
				public class Quantity : HL7Base<Quantity>
				{

					private const string _id = "DRG.22.1";
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
				/// DRG.22.2 - The second component is the denomination in which the quantity is expressed. The values for the denomination component are the three-character codes specified in ISO-4217. See Externally-defined Table 0913  Monetary Denomination Code.If the denomination is not specified, "MSH-17-country code", in Chapter 2, section 2.14.9.17, is used to determine the default. Example, where USD is the ISO 4217 code for the U.S. American dollar. 99.50USD
				/// </summary>
				public class Denomination : HL7Base<Denomination>
				{

					private const string _id = "DRG.22.2";
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
			/// DRG.23 - This field contains the total charge including surcharges or discounts.
			/// </summary>
			public class TotalCharge : HL7Base<TotalCharge>
			{

				private const string _id = "DRG.23";
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
				/// DRG.23.1 - The first component is a quantity.
				/// </summary>
				public class Quantity : HL7Base<Quantity>
				{

					private const string _id = "DRG.23.1";
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
				/// DRG.23.2 - The second component is the denomination in which the quantity is expressed. The values for the denomination component are the three-character codes specified in ISO-4217. See Externally-defined Table 0913  Monetary Denomination Code.If the denomination is not specified, "MSH-17-country code", in Chapter 2, section 2.14.9.17, is used to determine the default. Example, where USD is the ISO 4217 code for the U.S. American dollar. 99.50USD
				/// </summary>
				public class Denomination : HL7Base<Denomination>
				{

					private const string _id = "DRG.23.2";
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
			/// DRG.24 - This field contains the discount/surcharge as determined for this DRG. The addition/reduction is indicated by DRG-17 - Status Patient.
			/// </summary>
			public class DiscountSurcharge : HL7Base<DiscountSurcharge>
			{

				private const string _id = "DRG.24";
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
				/// DRG.24.1 - The first component is a quantity.
				/// </summary>
				public class Quantity : HL7Base<Quantity>
				{

					private const string _id = "DRG.24.1";
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
				/// DRG.24.2 - The second component is the denomination in which the quantity is expressed. The values for the denomination component are the three-character codes specified in ISO-4217. See Externally-defined Table 0913  Monetary Denomination Code.If the denomination is not specified, "MSH-17-country code", in Chapter 2, section 2.14.9.17, is used to determine the default. Example, where USD is the ISO 4217 code for the U.S. American dollar. 99.50USD
				/// </summary>
				public class Denomination : HL7Base<Denomination>
				{

					private const string _id = "DRG.24.2";
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
			/// DRG.25 - This field contains the number of days, for which a surcharge/discount has been determined. The addition/reduction is indicated by DRG-17 - Status Patient.
			/// </summary>
			public class CalculatedDays : HL7Base<CalculatedDays>
			{

				private const string _id = "DRG.25";
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
			/// DRG.26 - This field contains the status of the use of the gender information for DRG determination. Refer to User-defined Table 0749  DRG Grouping Status for suggested values.
			/// </summary>
			public class StatusGender : HL7Base<StatusGender>
			{

				private const string _id = "DRG.26";
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
				/// DRG.26.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
				/// </summary>
				public class Identifier : HL7Base<Identifier>
				{

					private const string _id = "DRG.26.1";
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
				/// DRG.26.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
				/// </summary>
				public class Text : HL7Base<Text>
				{

					private const string _id = "DRG.26.2";
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
				/// DRG.26.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
				/// </summary>
				public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
				{

					private const string _id = "DRG.26.3";
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
				/// DRG.26.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
				/// </summary>
				public class AlternateIdentifier : HL7Base<AlternateIdentifier>
				{

					private const string _id = "DRG.26.4";
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
				/// DRG.26.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
				/// </summary>
				public class AlternateText : HL7Base<AlternateText>
				{

					private const string _id = "DRG.26.5";
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
				/// DRG.26.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
				{

					private const string _id = "DRG.26.6";
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
				/// DRG.26.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
				/// </summary>
				public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
				{

					private const string _id = "DRG.26.7";
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
				/// DRG.26.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
				/// </summary>
				public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
				{

					private const string _id = "DRG.26.8";
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
				/// DRG.26.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
				/// </summary>
				public class OriginalText : HL7Base<OriginalText>
				{

					private const string _id = "DRG.26.9";
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
				/// DRG.26.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
				/// </summary>
				public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
				{

					private const string _id = "DRG.26.10";
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
				/// DRG.26.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
				/// </summary>
				public class SecondAlternateText : HL7Base<SecondAlternateText>
				{

					private const string _id = "DRG.26.11";
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
				/// DRG.26.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
				{

					private const string _id = "DRG.26.12";
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
				/// DRG.26.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
				/// </summary>
				public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
				{

					private const string _id = "DRG.26.13";
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
				/// DRG.26.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
				/// </summary>
				public class CodingSystemOid : HL7Base<CodingSystemOid>
				{

					private const string _id = "DRG.26.14";
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
				/// DRG.26.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class ValueSetOid : HL7Base<ValueSetOid>
				{

					private const string _id = "DRG.26.15";
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
				/// DRG.26.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
				/// </summary>
				public class ValueSetVersionId : HL7Base<ValueSetVersionId>
				{

					private const string _id = "DRG.26.16";
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
				/// DRG.26.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
				/// </summary>
				public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
				{

					private const string _id = "DRG.26.17";
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
				/// DRG.26.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
				{

					private const string _id = "DRG.26.18";
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
				/// DRG.26.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
				/// </summary>
				public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
				{

					private const string _id = "DRG.26.19";
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
				/// DRG.26.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
				/// </summary>
				public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
				{

					private const string _id = "DRG.26.20";
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
				/// DRG.26.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
				{

					private const string _id = "DRG.26.21";
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
				/// DRG.26.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
				/// </summary>
				public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
				{

					private const string _id = "DRG.26.22";
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
			/// DRG.27 - This field contains the status of the use of the age information for DRG determination. Refer to User-defined Table 0749  DRG Grouping Status for suggested values.
			/// </summary>
			public class StatusAge : HL7Base<StatusAge>
			{

				private const string _id = "DRG.27";
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
				/// DRG.27.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
				/// </summary>
				public class Identifier : HL7Base<Identifier>
				{

					private const string _id = "DRG.27.1";
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
				/// DRG.27.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
				/// </summary>
				public class Text : HL7Base<Text>
				{

					private const string _id = "DRG.27.2";
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
				/// DRG.27.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
				/// </summary>
				public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
				{

					private const string _id = "DRG.27.3";
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
				/// DRG.27.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
				/// </summary>
				public class AlternateIdentifier : HL7Base<AlternateIdentifier>
				{

					private const string _id = "DRG.27.4";
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
				/// DRG.27.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
				/// </summary>
				public class AlternateText : HL7Base<AlternateText>
				{

					private const string _id = "DRG.27.5";
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
				/// DRG.27.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
				{

					private const string _id = "DRG.27.6";
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
				/// DRG.27.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
				/// </summary>
				public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
				{

					private const string _id = "DRG.27.7";
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
				/// DRG.27.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
				/// </summary>
				public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
				{

					private const string _id = "DRG.27.8";
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
				/// DRG.27.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
				/// </summary>
				public class OriginalText : HL7Base<OriginalText>
				{

					private const string _id = "DRG.27.9";
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
				/// DRG.27.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
				/// </summary>
				public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
				{

					private const string _id = "DRG.27.10";
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
				/// DRG.27.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
				/// </summary>
				public class SecondAlternateText : HL7Base<SecondAlternateText>
				{

					private const string _id = "DRG.27.11";
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
				/// DRG.27.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
				{

					private const string _id = "DRG.27.12";
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
				/// DRG.27.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
				/// </summary>
				public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
				{

					private const string _id = "DRG.27.13";
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
				/// DRG.27.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
				/// </summary>
				public class CodingSystemOid : HL7Base<CodingSystemOid>
				{

					private const string _id = "DRG.27.14";
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
				/// DRG.27.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class ValueSetOid : HL7Base<ValueSetOid>
				{

					private const string _id = "DRG.27.15";
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
				/// DRG.27.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
				/// </summary>
				public class ValueSetVersionId : HL7Base<ValueSetVersionId>
				{

					private const string _id = "DRG.27.16";
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
				/// DRG.27.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
				/// </summary>
				public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
				{

					private const string _id = "DRG.27.17";
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
				/// DRG.27.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
				{

					private const string _id = "DRG.27.18";
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
				/// DRG.27.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
				/// </summary>
				public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
				{

					private const string _id = "DRG.27.19";
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
				/// DRG.27.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
				/// </summary>
				public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
				{

					private const string _id = "DRG.27.20";
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
				/// DRG.27.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
				{

					private const string _id = "DRG.27.21";
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
				/// DRG.27.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
				/// </summary>
				public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
				{

					private const string _id = "DRG.27.22";
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
			/// DRG.28 - This field contains the status of the DRG calculation for the length of stay information. Refer to User-defined Table 0749  DRG Grouping Status for suggested values.
			/// </summary>
			public class StatusLengthOfStay : HL7Base<StatusLengthOfStay>
			{

				private const string _id = "DRG.28";
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
				/// DRG.28.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
				/// </summary>
				public class Identifier : HL7Base<Identifier>
				{

					private const string _id = "DRG.28.1";
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
				/// DRG.28.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
				/// </summary>
				public class Text : HL7Base<Text>
				{

					private const string _id = "DRG.28.2";
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
				/// DRG.28.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
				/// </summary>
				public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
				{

					private const string _id = "DRG.28.3";
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
				/// DRG.28.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
				/// </summary>
				public class AlternateIdentifier : HL7Base<AlternateIdentifier>
				{

					private const string _id = "DRG.28.4";
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
				/// DRG.28.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
				/// </summary>
				public class AlternateText : HL7Base<AlternateText>
				{

					private const string _id = "DRG.28.5";
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
				/// DRG.28.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
				{

					private const string _id = "DRG.28.6";
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
				/// DRG.28.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
				/// </summary>
				public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
				{

					private const string _id = "DRG.28.7";
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
				/// DRG.28.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
				/// </summary>
				public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
				{

					private const string _id = "DRG.28.8";
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
				/// DRG.28.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
				/// </summary>
				public class OriginalText : HL7Base<OriginalText>
				{

					private const string _id = "DRG.28.9";
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
				/// DRG.28.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
				/// </summary>
				public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
				{

					private const string _id = "DRG.28.10";
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
				/// DRG.28.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
				/// </summary>
				public class SecondAlternateText : HL7Base<SecondAlternateText>
				{

					private const string _id = "DRG.28.11";
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
				/// DRG.28.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
				{

					private const string _id = "DRG.28.12";
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
				/// DRG.28.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
				/// </summary>
				public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
				{

					private const string _id = "DRG.28.13";
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
				/// DRG.28.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
				/// </summary>
				public class CodingSystemOid : HL7Base<CodingSystemOid>
				{

					private const string _id = "DRG.28.14";
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
				/// DRG.28.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class ValueSetOid : HL7Base<ValueSetOid>
				{

					private const string _id = "DRG.28.15";
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
				/// DRG.28.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
				/// </summary>
				public class ValueSetVersionId : HL7Base<ValueSetVersionId>
				{

					private const string _id = "DRG.28.16";
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
				/// DRG.28.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
				/// </summary>
				public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
				{

					private const string _id = "DRG.28.17";
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
				/// DRG.28.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
				{

					private const string _id = "DRG.28.18";
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
				/// DRG.28.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
				/// </summary>
				public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
				{

					private const string _id = "DRG.28.19";
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
				/// DRG.28.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
				/// </summary>
				public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
				{

					private const string _id = "DRG.28.20";
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
				/// DRG.28.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
				{

					private const string _id = "DRG.28.21";
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
				/// DRG.28.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
				/// </summary>
				public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
				{

					private const string _id = "DRG.28.22";
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
			/// DRG.29 - This field contains the status of the use of the same day information for DRG determination. Refer to User-defined Table 0749  DRG Grouping Status for suggested values.
			/// </summary>
			public class StatusSameDayFlag : HL7Base<StatusSameDayFlag>
			{

				private const string _id = "DRG.29";
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
				/// DRG.29.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
				/// </summary>
				public class Identifier : HL7Base<Identifier>
				{

					private const string _id = "DRG.29.1";
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
				/// DRG.29.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
				/// </summary>
				public class Text : HL7Base<Text>
				{

					private const string _id = "DRG.29.2";
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
				/// DRG.29.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
				/// </summary>
				public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
				{

					private const string _id = "DRG.29.3";
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
				/// DRG.29.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
				/// </summary>
				public class AlternateIdentifier : HL7Base<AlternateIdentifier>
				{

					private const string _id = "DRG.29.4";
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
				/// DRG.29.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
				/// </summary>
				public class AlternateText : HL7Base<AlternateText>
				{

					private const string _id = "DRG.29.5";
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
				/// DRG.29.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
				{

					private const string _id = "DRG.29.6";
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
				/// DRG.29.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
				/// </summary>
				public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
				{

					private const string _id = "DRG.29.7";
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
				/// DRG.29.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
				/// </summary>
				public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
				{

					private const string _id = "DRG.29.8";
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
				/// DRG.29.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
				/// </summary>
				public class OriginalText : HL7Base<OriginalText>
				{

					private const string _id = "DRG.29.9";
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
				/// DRG.29.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
				/// </summary>
				public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
				{

					private const string _id = "DRG.29.10";
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
				/// DRG.29.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
				/// </summary>
				public class SecondAlternateText : HL7Base<SecondAlternateText>
				{

					private const string _id = "DRG.29.11";
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
				/// DRG.29.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
				{

					private const string _id = "DRG.29.12";
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
				/// DRG.29.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
				/// </summary>
				public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
				{

					private const string _id = "DRG.29.13";
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
				/// DRG.29.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
				/// </summary>
				public class CodingSystemOid : HL7Base<CodingSystemOid>
				{

					private const string _id = "DRG.29.14";
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
				/// DRG.29.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class ValueSetOid : HL7Base<ValueSetOid>
				{

					private const string _id = "DRG.29.15";
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
				/// DRG.29.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
				/// </summary>
				public class ValueSetVersionId : HL7Base<ValueSetVersionId>
				{

					private const string _id = "DRG.29.16";
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
				/// DRG.29.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
				/// </summary>
				public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
				{

					private const string _id = "DRG.29.17";
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
				/// DRG.29.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
				{

					private const string _id = "DRG.29.18";
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
				/// DRG.29.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
				/// </summary>
				public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
				{

					private const string _id = "DRG.29.19";
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
				/// DRG.29.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
				/// </summary>
				public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
				{

					private const string _id = "DRG.29.20";
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
				/// DRG.29.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
				{

					private const string _id = "DRG.29.21";
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
				/// DRG.29.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
				/// </summary>
				public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
				{

					private const string _id = "DRG.29.22";
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
			/// DRG.30 - This field contains the status of the use of the separation mode information for DRG determination. Refer to User-defined Table 0749  DRG Grouping Status for suggested values.
			/// </summary>
			public class StatusSeparationMode : HL7Base<StatusSeparationMode>
			{

				private const string _id = "DRG.30";
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
				/// DRG.30.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
				/// </summary>
				public class Identifier : HL7Base<Identifier>
				{

					private const string _id = "DRG.30.1";
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
				/// DRG.30.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
				/// </summary>
				public class Text : HL7Base<Text>
				{

					private const string _id = "DRG.30.2";
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
				/// DRG.30.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
				/// </summary>
				public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
				{

					private const string _id = "DRG.30.3";
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
				/// DRG.30.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
				/// </summary>
				public class AlternateIdentifier : HL7Base<AlternateIdentifier>
				{

					private const string _id = "DRG.30.4";
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
				/// DRG.30.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
				/// </summary>
				public class AlternateText : HL7Base<AlternateText>
				{

					private const string _id = "DRG.30.5";
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
				/// DRG.30.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
				{

					private const string _id = "DRG.30.6";
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
				/// DRG.30.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
				/// </summary>
				public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
				{

					private const string _id = "DRG.30.7";
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
				/// DRG.30.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
				/// </summary>
				public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
				{

					private const string _id = "DRG.30.8";
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
				/// DRG.30.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
				/// </summary>
				public class OriginalText : HL7Base<OriginalText>
				{

					private const string _id = "DRG.30.9";
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
				/// DRG.30.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
				/// </summary>
				public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
				{

					private const string _id = "DRG.30.10";
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
				/// DRG.30.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
				/// </summary>
				public class SecondAlternateText : HL7Base<SecondAlternateText>
				{

					private const string _id = "DRG.30.11";
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
				/// DRG.30.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
				{

					private const string _id = "DRG.30.12";
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
				/// DRG.30.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
				/// </summary>
				public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
				{

					private const string _id = "DRG.30.13";
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
				/// DRG.30.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
				/// </summary>
				public class CodingSystemOid : HL7Base<CodingSystemOid>
				{

					private const string _id = "DRG.30.14";
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
				/// DRG.30.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class ValueSetOid : HL7Base<ValueSetOid>
				{

					private const string _id = "DRG.30.15";
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
				/// DRG.30.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
				/// </summary>
				public class ValueSetVersionId : HL7Base<ValueSetVersionId>
				{

					private const string _id = "DRG.30.16";
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
				/// DRG.30.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
				/// </summary>
				public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
				{

					private const string _id = "DRG.30.17";
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
				/// DRG.30.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
				{

					private const string _id = "DRG.30.18";
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
				/// DRG.30.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
				/// </summary>
				public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
				{

					private const string _id = "DRG.30.19";
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
				/// DRG.30.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
				/// </summary>
				public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
				{

					private const string _id = "DRG.30.20";
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
				/// DRG.30.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
				{

					private const string _id = "DRG.30.21";
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
				/// DRG.30.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
				/// </summary>
				public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
				{

					private const string _id = "DRG.30.22";
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
			/// DRG.31 - This field contains the status of the use of the weight at birth information for DRG determination. Refer to User-defined Table 0755  DRG Status Weight At Birth for suggested values.
			/// </summary>
			public class StatusWeightAtBirth : HL7Base<StatusWeightAtBirth>
			{

				private const string _id = "DRG.31";
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
				/// DRG.31.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
				/// </summary>
				public class Identifier : HL7Base<Identifier>
				{

					private const string _id = "DRG.31.1";
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
				/// DRG.31.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
				/// </summary>
				public class Text : HL7Base<Text>
				{

					private const string _id = "DRG.31.2";
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
				/// DRG.31.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
				/// </summary>
				public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
				{

					private const string _id = "DRG.31.3";
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
				/// DRG.31.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
				/// </summary>
				public class AlternateIdentifier : HL7Base<AlternateIdentifier>
				{

					private const string _id = "DRG.31.4";
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
				/// DRG.31.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
				/// </summary>
				public class AlternateText : HL7Base<AlternateText>
				{

					private const string _id = "DRG.31.5";
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
				/// DRG.31.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
				{

					private const string _id = "DRG.31.6";
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
				/// DRG.31.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
				/// </summary>
				public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
				{

					private const string _id = "DRG.31.7";
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
				/// DRG.31.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
				/// </summary>
				public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
				{

					private const string _id = "DRG.31.8";
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
				/// DRG.31.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
				/// </summary>
				public class OriginalText : HL7Base<OriginalText>
				{

					private const string _id = "DRG.31.9";
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
				/// DRG.31.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
				/// </summary>
				public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
				{

					private const string _id = "DRG.31.10";
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
				/// DRG.31.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
				/// </summary>
				public class SecondAlternateText : HL7Base<SecondAlternateText>
				{

					private const string _id = "DRG.31.11";
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
				/// DRG.31.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
				{

					private const string _id = "DRG.31.12";
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
				/// DRG.31.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
				/// </summary>
				public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
				{

					private const string _id = "DRG.31.13";
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
				/// DRG.31.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
				/// </summary>
				public class CodingSystemOid : HL7Base<CodingSystemOid>
				{

					private const string _id = "DRG.31.14";
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
				/// DRG.31.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class ValueSetOid : HL7Base<ValueSetOid>
				{

					private const string _id = "DRG.31.15";
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
				/// DRG.31.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
				/// </summary>
				public class ValueSetVersionId : HL7Base<ValueSetVersionId>
				{

					private const string _id = "DRG.31.16";
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
				/// DRG.31.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
				/// </summary>
				public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
				{

					private const string _id = "DRG.31.17";
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
				/// DRG.31.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
				{

					private const string _id = "DRG.31.18";
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
				/// DRG.31.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
				/// </summary>
				public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
				{

					private const string _id = "DRG.31.19";
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
				/// DRG.31.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
				/// </summary>
				public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
				{

					private const string _id = "DRG.31.20";
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
				/// DRG.31.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
				{

					private const string _id = "DRG.31.21";
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
				/// DRG.31.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
				/// </summary>
				public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
				{

					private const string _id = "DRG.31.22";
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
			/// DRG.32 - This field contains the status of the use of the respiration minutes information for DRG determination. Refer to User-defined Table 0757  DRG Status Respiration Minutes for suggested values.
			/// </summary>
			public class StatusRespirationMinutes : HL7Base<StatusRespirationMinutes>
			{

				private const string _id = "DRG.32";
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
				/// DRG.32.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
				/// </summary>
				public class Identifier : HL7Base<Identifier>
				{

					private const string _id = "DRG.32.1";
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
				/// DRG.32.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
				/// </summary>
				public class Text : HL7Base<Text>
				{

					private const string _id = "DRG.32.2";
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
				/// DRG.32.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
				/// </summary>
				public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
				{

					private const string _id = "DRG.32.3";
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
				/// DRG.32.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
				/// </summary>
				public class AlternateIdentifier : HL7Base<AlternateIdentifier>
				{

					private const string _id = "DRG.32.4";
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
				/// DRG.32.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
				/// </summary>
				public class AlternateText : HL7Base<AlternateText>
				{

					private const string _id = "DRG.32.5";
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
				/// DRG.32.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
				{

					private const string _id = "DRG.32.6";
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
				/// DRG.32.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
				/// </summary>
				public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
				{

					private const string _id = "DRG.32.7";
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
				/// DRG.32.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
				/// </summary>
				public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
				{

					private const string _id = "DRG.32.8";
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
				/// DRG.32.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
				/// </summary>
				public class OriginalText : HL7Base<OriginalText>
				{

					private const string _id = "DRG.32.9";
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
				/// DRG.32.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
				/// </summary>
				public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
				{

					private const string _id = "DRG.32.10";
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
				/// DRG.32.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
				/// </summary>
				public class SecondAlternateText : HL7Base<SecondAlternateText>
				{

					private const string _id = "DRG.32.11";
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
				/// DRG.32.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
				{

					private const string _id = "DRG.32.12";
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
				/// DRG.32.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
				/// </summary>
				public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
				{

					private const string _id = "DRG.32.13";
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
				/// DRG.32.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
				/// </summary>
				public class CodingSystemOid : HL7Base<CodingSystemOid>
				{

					private const string _id = "DRG.32.14";
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
				/// DRG.32.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class ValueSetOid : HL7Base<ValueSetOid>
				{

					private const string _id = "DRG.32.15";
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
				/// DRG.32.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
				/// </summary>
				public class ValueSetVersionId : HL7Base<ValueSetVersionId>
				{

					private const string _id = "DRG.32.16";
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
				/// DRG.32.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
				/// </summary>
				public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
				{

					private const string _id = "DRG.32.17";
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
				/// DRG.32.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
				{

					private const string _id = "DRG.32.18";
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
				/// DRG.32.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
				/// </summary>
				public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
				{

					private const string _id = "DRG.32.19";
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
				/// DRG.32.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
				/// </summary>
				public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
				{

					private const string _id = "DRG.32.20";
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
				/// DRG.32.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
				{

					private const string _id = "DRG.32.21";
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
				/// DRG.32.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
				/// </summary>
				public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
				{

					private const string _id = "DRG.32.22";
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
			/// DRG.33 - This field contains the admission status for the DRG determination. Refer to User-defined Table 0759  Status Admission for suggested values.
			/// </summary>
			public class StatusAdmission : HL7Base<StatusAdmission>
			{

				private const string _id = "DRG.33";
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
				/// DRG.33.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
				/// </summary>
				public class Identifier : HL7Base<Identifier>
				{

					private const string _id = "DRG.33.1";
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
				/// DRG.33.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
				/// </summary>
				public class Text : HL7Base<Text>
				{

					private const string _id = "DRG.33.2";
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
				/// DRG.33.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
				/// </summary>
				public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
				{

					private const string _id = "DRG.33.3";
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
				/// DRG.33.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
				/// </summary>
				public class AlternateIdentifier : HL7Base<AlternateIdentifier>
				{

					private const string _id = "DRG.33.4";
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
				/// DRG.33.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
				/// </summary>
				public class AlternateText : HL7Base<AlternateText>
				{

					private const string _id = "DRG.33.5";
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
				/// DRG.33.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
				{

					private const string _id = "DRG.33.6";
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
				/// DRG.33.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
				/// </summary>
				public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
				{

					private const string _id = "DRG.33.7";
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
				/// DRG.33.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
				/// </summary>
				public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
				{

					private const string _id = "DRG.33.8";
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
				/// DRG.33.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
				/// </summary>
				public class OriginalText : HL7Base<OriginalText>
				{

					private const string _id = "DRG.33.9";
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
				/// DRG.33.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
				/// </summary>
				public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
				{

					private const string _id = "DRG.33.10";
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
				/// DRG.33.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
				/// </summary>
				public class SecondAlternateText : HL7Base<SecondAlternateText>
				{

					private const string _id = "DRG.33.11";
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
				/// DRG.33.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
				{

					private const string _id = "DRG.33.12";
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
				/// DRG.33.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
				/// </summary>
				public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
				{

					private const string _id = "DRG.33.13";
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
				/// DRG.33.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
				/// </summary>
				public class CodingSystemOid : HL7Base<CodingSystemOid>
				{

					private const string _id = "DRG.33.14";
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
				/// DRG.33.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class ValueSetOid : HL7Base<ValueSetOid>
				{

					private const string _id = "DRG.33.15";
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
				/// DRG.33.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
				/// </summary>
				public class ValueSetVersionId : HL7Base<ValueSetVersionId>
				{

					private const string _id = "DRG.33.16";
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
				/// DRG.33.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
				/// </summary>
				public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
				{

					private const string _id = "DRG.33.17";
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
				/// DRG.33.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
				{

					private const string _id = "DRG.33.18";
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
				/// DRG.33.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
				/// </summary>
				public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
				{

					private const string _id = "DRG.33.19";
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
				/// DRG.33.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
				/// </summary>
				public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
				{

					private const string _id = "DRG.33.20";
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
				/// DRG.33.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
				{

					private const string _id = "DRG.33.21";
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
				/// DRG.33.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
				/// </summary>
				public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
				{

					private const string _id = "DRG.33.22";
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

