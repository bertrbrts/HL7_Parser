using Newtonsoft.Json;
namespace HL7Parser
{
	public partial class Mappings {
		/// <summary>
		/// Details related to a particular clinical experience or event are embodied in the PEO segment. This segment can be used to characterize an event which might be attributed to a product to which the patient was exposed. Products with a possible causal relationship to the observed experience are described in the following PCR (possible causal relationship) segments. The message format was designed to be robust and includes many optional elements which may not be required for a particular regulatory purpose but allow a complete representation of the drug experience if needed.A PEX message can contain multiple PEO segments if the patient experienced more than one event but must contain at least one PEO segment.
		/// </summary>
		public class PEO {

			 public const string Id = "PEO";

						/// <summary>
			/// PEO.1 - This field may be used to transmit the event identifier used by other entities for this event. The entry would typically contain a unique alphanumeric identifier assigned by an entity with the text component null or repeating the unique alphanumeric identifier followed by the organizations identifier. An event identifier might be GB1234GB1234PharmaGiant for example.
			/// </summary>
			public class EventIdentifiersUsed : HL7Base<EventIdentifiersUsed>
			{

				private const string _id = "PEO.1";
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
				/// PEO.1.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
				/// </summary>
				public class Identifier : HL7Base<Identifier>
				{

					private const string _id = "PEO.1.1";
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
				/// PEO.1.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
				/// </summary>
				public class Text : HL7Base<Text>
				{

					private const string _id = "PEO.1.2";
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
				/// PEO.1.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
				/// </summary>
				public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
				{

					private const string _id = "PEO.1.3";
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
				/// PEO.1.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
				/// </summary>
				public class AlternateIdentifier : HL7Base<AlternateIdentifier>
				{

					private const string _id = "PEO.1.4";
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
				/// PEO.1.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
				/// </summary>
				public class AlternateText : HL7Base<AlternateText>
				{

					private const string _id = "PEO.1.5";
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
				/// PEO.1.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
				{

					private const string _id = "PEO.1.6";
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
				/// PEO.1.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
				/// </summary>
				public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
				{

					private const string _id = "PEO.1.7";
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
				/// PEO.1.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
				/// </summary>
				public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
				{

					private const string _id = "PEO.1.8";
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
				/// PEO.1.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
				/// </summary>
				public class OriginalText : HL7Base<OriginalText>
				{

					private const string _id = "PEO.1.9";
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
				/// PEO.1.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
				/// </summary>
				public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
				{

					private const string _id = "PEO.1.10";
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
				/// PEO.1.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
				/// </summary>
				public class SecondAlternateText : HL7Base<SecondAlternateText>
				{

					private const string _id = "PEO.1.11";
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
				/// PEO.1.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
				{

					private const string _id = "PEO.1.12";
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
				/// PEO.1.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
				/// </summary>
				public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
				{

					private const string _id = "PEO.1.13";
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
				/// PEO.1.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
				/// </summary>
				public class CodingSystemOid : HL7Base<CodingSystemOid>
				{

					private const string _id = "PEO.1.14";
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
				/// PEO.1.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class ValueSetOid : HL7Base<ValueSetOid>
				{

					private const string _id = "PEO.1.15";
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
				/// PEO.1.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
				/// </summary>
				public class ValueSetVersionId : HL7Base<ValueSetVersionId>
				{

					private const string _id = "PEO.1.16";
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
				/// PEO.1.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
				/// </summary>
				public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
				{

					private const string _id = "PEO.1.17";
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
				/// PEO.1.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
				{

					private const string _id = "PEO.1.18";
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
				/// PEO.1.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
				/// </summary>
				public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
				{

					private const string _id = "PEO.1.19";
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
				/// PEO.1.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
				/// </summary>
				public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
				{

					private const string _id = "PEO.1.20";
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
				/// PEO.1.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
				{

					private const string _id = "PEO.1.21";
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
				/// PEO.1.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
				/// </summary>
				public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
				{

					private const string _id = "PEO.1.22";
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
			/// PEO.2 - This field is the coded diagnosis or problem description which best describes the event. A text representation of the coded item should routinely be included. MEDDRA and WHO-ART are examples of appropriate coding schemes, as are the patient and device codes included in the FDA Center for Devices and Radiologic Healths coding manual for Form 3500A.
			/// </summary>
			public class EventSymptomDiagnosisCode : HL7Base<EventSymptomDiagnosisCode>
			{

				private const string _id = "PEO.2";
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
				/// PEO.2.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
				/// </summary>
				public class Identifier : HL7Base<Identifier>
				{

					private const string _id = "PEO.2.1";
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
				/// PEO.2.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
				/// </summary>
				public class Text : HL7Base<Text>
				{

					private const string _id = "PEO.2.2";
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
				/// PEO.2.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
				/// </summary>
				public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
				{

					private const string _id = "PEO.2.3";
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
				/// PEO.2.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
				/// </summary>
				public class AlternateIdentifier : HL7Base<AlternateIdentifier>
				{

					private const string _id = "PEO.2.4";
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
				/// PEO.2.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
				/// </summary>
				public class AlternateText : HL7Base<AlternateText>
				{

					private const string _id = "PEO.2.5";
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
				/// PEO.2.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
				{

					private const string _id = "PEO.2.6";
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
				/// PEO.2.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
				/// </summary>
				public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
				{

					private const string _id = "PEO.2.7";
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
				/// PEO.2.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
				/// </summary>
				public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
				{

					private const string _id = "PEO.2.8";
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
				/// PEO.2.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
				/// </summary>
				public class OriginalText : HL7Base<OriginalText>
				{

					private const string _id = "PEO.2.9";
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
				/// PEO.2.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
				/// </summary>
				public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
				{

					private const string _id = "PEO.2.10";
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
				/// PEO.2.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
				/// </summary>
				public class SecondAlternateText : HL7Base<SecondAlternateText>
				{

					private const string _id = "PEO.2.11";
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
				/// PEO.2.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
				{

					private const string _id = "PEO.2.12";
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
				/// PEO.2.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
				/// </summary>
				public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
				{

					private const string _id = "PEO.2.13";
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
				/// PEO.2.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
				/// </summary>
				public class CodingSystemOid : HL7Base<CodingSystemOid>
				{

					private const string _id = "PEO.2.14";
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
				/// PEO.2.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class ValueSetOid : HL7Base<ValueSetOid>
				{

					private const string _id = "PEO.2.15";
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
				/// PEO.2.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
				/// </summary>
				public class ValueSetVersionId : HL7Base<ValueSetVersionId>
				{

					private const string _id = "PEO.2.16";
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
				/// PEO.2.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
				/// </summary>
				public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
				{

					private const string _id = "PEO.2.17";
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
				/// PEO.2.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
				{

					private const string _id = "PEO.2.18";
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
				/// PEO.2.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
				/// </summary>
				public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
				{

					private const string _id = "PEO.2.19";
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
				/// PEO.2.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
				/// </summary>
				public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
				{

					private const string _id = "PEO.2.20";
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
				/// PEO.2.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
				{

					private const string _id = "PEO.2.21";
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
				/// PEO.2.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
				/// </summary>
				public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
				{

					private const string _id = "PEO.2.22";
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
			/// PEO.3 - This field contains a report or best estimate of the date/time of onset of the event. The date/time can be recorded to any level of precision it is known (hour, day, month, year).
			/// </summary>
			public class EventOnsetDateTime : HL7Base<EventOnsetDateTime>
			{

				private const string _id = "PEO.3";
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
			/// PEO.4 - This field identifies the best estimate of the date/time the event was exacerbated.
			/// </summary>
			public class EventExacerbationDateTime : HL7Base<EventExacerbationDateTime>
			{

				private const string _id = "PEO.4";
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
			/// PEO.5 - This field identifies the best estimate of the date/time the event improved.
			/// </summary>
			public class EventImprovedDateTime : HL7Base<EventImprovedDateTime>
			{

				private const string _id = "PEO.5";
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
			/// PEO.6 - This field identifies the best estimate of the date/time the event resolved.
			/// </summary>
			public class EventEndedDataTime : HL7Base<EventEndedDataTime>
			{

				private const string _id = "PEO.6";
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
			/// PEO.7 - This field identifies the location at which the event started. Often this will specify only the country in which the event started.
			/// </summary>
			public class EventLocationOccurredAddress : HL7Base<EventLocationOccurredAddress>
			{

				private const string _id = "PEO.7";
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
				/// PEO.7.1 - This component contains the house number, apartment number, street name, street direction, P.O. Box number, and similar address information. 
				/// </summary>
				public class StreetAddress : HL7Base<StreetAddress>
				{

					private const string _id = "PEO.7.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

										/// <summary>
					/// PEO.7.1.1 - This component specifies the street or mailing address of a person or institution. When referencing an institution, this first component is used to specify the institution name. When used in connection with a person, this component specifies the first line of the address.
					/// </summary>
					public class StreetOrMailingAddress : HL7Base<StreetOrMailingAddress>
					{

						private const string _id = "PEO.7.1.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.1.2 - 
					/// </summary>
					public class StreetName : HL7Base<StreetName>
					{

						private const string _id = "PEO.7.1.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.1.3 - 
					/// </summary>
					public class DwellingNumber : HL7Base<DwellingNumber>
					{

						private const string _id = "PEO.7.1.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

				}

								/// <summary>
				/// PEO.7.2 - This component contains the second line of address. In US usage, it qualifies address. Examples Suite 555 or Fourth Floor. When referencing an institution, this component specifies the street address.
				/// </summary>
				public class OtherDesignation : HL7Base<OtherDesignation>
				{

					private const string _id = "PEO.7.2";
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
				/// PEO.7.3 - This component specifies the city, or district or place where the addressee is located depending upon the national convention for formatting addresses for postal usage.
				/// </summary>
				public class City : HL7Base<City>
				{

					private const string _id = "PEO.7.3";
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
				/// PEO.7.4 - This component specifies the state or province where the addressee is located. State or province should be represented by the official postal service codes for that country.
				/// </summary>
				public class StateOrProvince : HL7Base<StateOrProvince>
				{

					private const string _id = "PEO.7.4";
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
				/// PEO.7.5 - This component specifies the zip or postal code where the addressee is located. Zip or postal codes should be represented by the official codes for that country. In the US, the zip code takes the form 99999-9999, while the Canadian postal code takes the form A9A9A9, and the Australian Postcode takes the form 9999.
				/// </summary>
				public class ZipOrPostalCode : HL7Base<ZipOrPostalCode>
				{

					private const string _id = "PEO.7.5";
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
				/// PEO.7.6 - This component specifies the country where the addressee is located.  HL7 specifies that the 3-character (alphabetic) form of ISO 3166 be used for the country code. Refer to HL7 Table 0399  Country Code for valid values.
				/// </summary>
				public class Country : HL7Base<Country>
				{

					private const string _id = "PEO.7.6";
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
				/// PEO.7.7 - This component specifies the kind or type of address. Refer to HL7 Table 0190 - Address Type for valid values.XAD.7 is required if there are multiple occurrences of XAD in a field.
				/// </summary>
				public class AddressType : HL7Base<AddressType>
				{

					private const string _id = "PEO.7.7";
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
				/// PEO.7.8 - This component specifies any other geographic designation. It includes county, bioregion, SMSA, etc.
				/// </summary>
				public class OtherGeographicDesignation : HL7Base<OtherGeographicDesignation>
				{

					private const string _id = "PEO.7.8";
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
				/// PEO.7.9 - A code that represents the county in which the specified address resides. User-defined Table 0289 - County/parish is used as the HL7 identifier for the user-defined table of values for this component. When this component is used to represent the county (or parish), component 8 other geographic designation should not duplicate it (i.e., the use of other geographic designation to represent the county is allowed only for the purpose of backward compatibility, and should be discouraged in this and future versions of HL7).Allowable values codes defined by government.
				/// </summary>
				public class CountyParishCode : HL7Base<CountyParishCode>
				{

					private const string _id = "PEO.7.9";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

										/// <summary>
					/// PEO.7.9.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "PEO.7.9.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.9.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "PEO.7.9.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.9.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "PEO.7.9.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.9.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "PEO.7.9.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.9.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "PEO.7.9.5";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.9.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "PEO.7.9.6";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.9.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "PEO.7.9.7";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.9.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "PEO.7.9.8";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.9.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "PEO.7.9.9";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.9.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "PEO.7.9.10";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.9.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "PEO.7.9.11";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.9.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "PEO.7.9.12";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.9.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "PEO.7.9.13";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.9.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "PEO.7.9.14";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.9.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "PEO.7.9.15";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.9.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "PEO.7.9.16";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.9.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "PEO.7.9.17";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.9.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "PEO.7.9.18";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.9.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "PEO.7.9.19";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.9.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "PEO.7.9.20";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.9.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "PEO.7.9.21";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.9.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "PEO.7.9.22";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

				}

								/// <summary>
				/// PEO.7.10 - A code that represents the census tract in which the specified address resides. User-defined Table 0288 - Census Tract is used as the HL7 identifier for the user-defined table of values for this component.Allowable Values codes defined by government.
				/// </summary>
				public class CensusTract : HL7Base<CensusTract>
				{

					private const string _id = "PEO.7.10";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

										/// <summary>
					/// PEO.7.10.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "PEO.7.10.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.10.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "PEO.7.10.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.10.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "PEO.7.10.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.10.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "PEO.7.10.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.10.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "PEO.7.10.5";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.10.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "PEO.7.10.6";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.10.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "PEO.7.10.7";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.10.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "PEO.7.10.8";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.10.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "PEO.7.10.9";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.10.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "PEO.7.10.10";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.10.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "PEO.7.10.11";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.10.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "PEO.7.10.12";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.10.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "PEO.7.10.13";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.10.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "PEO.7.10.14";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.10.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "PEO.7.10.15";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.10.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "PEO.7.10.16";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.10.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "PEO.7.10.17";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.10.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "PEO.7.10.18";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.10.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "PEO.7.10.19";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.10.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "PEO.7.10.20";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.10.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "PEO.7.10.21";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.10.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "PEO.7.10.22";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

				}

								/// <summary>
				/// PEO.7.11 - Different name/address types and representations of the same name/address should be described by repeating of this field, with different values of the name/address type and/or name/address representation component.Note Also note that this new component remains in "alphabetic" representation with each repetition of the fields using these data types. I.e. even though the address may be represented in an ideographic character set, this component will remain represented in an alphabetic character set.Refer to HL7 Table 0465  Name/address Representation for valid values.In general this component provides an indication of the representation provided by the data item. It does not necessarily specify the character sets used. Thus, even though the representation might provide an indication of what to expect, the sender is still free to encode the contents using whatever character set is desired. This component provides only hints for the receiver, so it can make choices regarding what it has been sent and what it is capable of displaying.
				/// </summary>
				public class AddressRepresentationCode : HL7Base<AddressRepresentationCode>
				{

					private const string _id = "PEO.7.11";
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
				/// PEO.7.12 - Attention The XAD.12 component was retained for backward compatibility as of v2.5 and the detail was withdrawn and removed from the standard as of v2.7. Refer to 2.A.86.13, "Effective Date (DTM)" and 2.A.86.14, "Expiration Date (DTM)" components.
				/// </summary>
				public class AddressValidityRange : HL7Base<AddressValidityRange>
				{

					private const string _id = "PEO.7.12";
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
				/// PEO.7.13 - The first date, if known, on which the address is valid and active for the owning entity.
				/// </summary>
				public class EffectiveDate : HL7Base<EffectiveDate>
				{

					private const string _id = "PEO.7.13";
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
				/// PEO.7.14 - The last date, if known, on which the address is valid and active for the owning entity.
				/// </summary>
				public class ExpirationDate : HL7Base<ExpirationDate>
				{

					private const string _id = "PEO.7.14";
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
				/// PEO.7.15 - This identifies why this address was marked as "ended".   Refer to User-defined Table 0616  Address Expiration Reason for valid values.
				/// </summary>
				public class ExpirationReason : HL7Base<ExpirationReason>
				{

					private const string _id = "PEO.7.15";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

										/// <summary>
					/// PEO.7.15.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "PEO.7.15.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.15.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "PEO.7.15.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.15.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "PEO.7.15.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.15.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "PEO.7.15.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.15.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "PEO.7.15.5";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.15.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "PEO.7.15.6";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.15.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "PEO.7.15.7";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.15.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "PEO.7.15.8";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.15.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "PEO.7.15.9";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.15.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "PEO.7.15.10";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.15.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "PEO.7.15.11";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.15.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "PEO.7.15.12";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.15.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "PEO.7.15.13";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.15.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "PEO.7.15.14";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.15.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "PEO.7.15.15";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.15.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "PEO.7.15.16";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.15.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "PEO.7.15.17";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.15.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "PEO.7.15.18";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.15.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "PEO.7.15.19";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.15.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "PEO.7.15.20";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.15.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "PEO.7.15.21";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.15.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "PEO.7.15.22";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

				}

								/// <summary>
				/// PEO.7.16 - If "Y" this indicates that the address is considered temporary.  Refer to HL7 Table 0136  Yes/No Indicator.
				/// </summary>
				public class TemporaryIndicator : HL7Base<TemporaryIndicator>
				{

					private const string _id = "PEO.7.16";
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
				/// PEO.7.17 - If "Y", this indicates that it is not possible to contact the "owning" entity at this address. Refer to HL7 Table 0136  Yes/No Indicator.
				/// </summary>
				public class BadAddressIndicator : HL7Base<BadAddressIndicator>
				{

					private const string _id = "PEO.7.17";
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
				/// PEO.7.18 - This indicates how the address is intended to be used.  Refer to User-defined Table 0617  Address Usage for valid values.
				/// </summary>
				public class AddressUsage : HL7Base<AddressUsage>
				{

					private const string _id = "PEO.7.18";
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
				/// PEO.7.19 - Identifies the name of the person or organization that should appear as part of the address. This is also known as the "Care of" or "C/O" line.
				/// </summary>
				public class Addressee : HL7Base<Addressee>
				{

					private const string _id = "PEO.7.19";
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
				/// PEO.7.20 - Descriptive information about the use of the address.Example "Do not ring bell."
				/// </summary>
				public class Comment : HL7Base<Comment>
				{

					private const string _id = "PEO.7.20";
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
				/// PEO.7.21 - For an entity having multiple addresses, indicates which is the 'most preferred' (lowest number) to 'least preferred' (highest number).If the preference order is unique across all usages for a given type, then it indicates the preference across all usages, (e.g., first try my home address, then my business address). Otherwise, the preference order is assumed to only apply within a specific usage.Preference order numbers need not be sequential (i.e., four addresses with the priority orders of 10, 1, 5 and 15 are legitimate). The preference order numbers must be non-negative.
				/// </summary>
				public class PreferenceOrder : HL7Base<PreferenceOrder>
				{

					private const string _id = "PEO.7.21";
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
				/// PEO.7.22 - Identifies that an address needs to be treated with special care or sensitivity.The specific set of codes and appropriate handling of such addresses will vary by jurisdiction and is subject to site-specific negotiation. For example, a provider address marked as 'unlisted' might not be printed in an internal address listing.  Refer to User-defined Table 0618  Protection Code for valid values.
				/// </summary>
				public class ProtectionCode : HL7Base<ProtectionCode>
				{

					private const string _id = "PEO.7.22";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

										/// <summary>
					/// PEO.7.22.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "PEO.7.22.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.22.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "PEO.7.22.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.22.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "PEO.7.22.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.22.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "PEO.7.22.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.22.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "PEO.7.22.5";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.22.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "PEO.7.22.6";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.22.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "PEO.7.22.7";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.22.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "PEO.7.22.8";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.22.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "PEO.7.22.9";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.22.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "PEO.7.22.10";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.22.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "PEO.7.22.11";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.22.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "PEO.7.22.12";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.22.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "PEO.7.22.13";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.22.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "PEO.7.22.14";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.22.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "PEO.7.22.15";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.22.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "PEO.7.22.16";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.22.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "PEO.7.22.17";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.22.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "PEO.7.22.18";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.22.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "PEO.7.22.19";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.22.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "PEO.7.22.20";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.22.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "PEO.7.22.21";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.22.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "PEO.7.22.22";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

				}

								/// <summary>
				/// PEO.7.23 - A unique identifier for the address.This component allows an address to be uniquely identified, and enables the linking of a single address to multiple people and contexts. For example, each member of a family living at the same location would share the same address, having the same identifier. A correction to the address of one family member could be automatically propagated to other members of the family.
				/// </summary>
				public class AddressIdentifier : HL7Base<AddressIdentifier>
				{

					private const string _id = "PEO.7.23";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

										/// <summary>
					/// PEO.7.23.1 - The first component, entity identifier, is usually defined to be unique within the series of identifiers created by the assigning authority, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, "HD - hierarchic designator".
					/// </summary>
					public class EntityIdentifier : HL7Base<EntityIdentifier>
					{

						private const string _id = "PEO.7.23.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.23.2 - See Section 2.A.33.1, "Namespace ID (IS)" for definition. The component intentionally remains associated with the IS data type in v 2.7.The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363  Assigning Authority for suggested values.Note When the HD is used as a part of another data type, in this case as part of the EI data type, this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment. By site agreement, implementers may continue to use User-defined Table 0300  Namespace ID for the first component
					/// </summary>
					public class NamespaceId : HL7Base<NamespaceId>
					{

						private const string _id = "PEO.7.23.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.23.3 - See Section 2.A.33.2, "Universal ID (ST)" for definition.
					/// </summary>
					public class UniversalId : HL7Base<UniversalId>
					{

						private const string _id = "PEO.7.23.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.7.23.4 - Refer to HL7 Table 0301 - Universal ID Type for valid values. See Section 2.A.33.3, "Universal ID Type (ID)," for definition.
					/// </summary>
					public class UniversalIdType : HL7Base<UniversalIdType>
					{

						private const string _id = "PEO.7.23.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

				}

			}

						/// <summary>
			/// PEO.8 - This field is contains a classification of the type of product experience this event is considered to represent. Refer to HL7 Table 0237 - Event Qualification for valid values.Unexpected beneficial effects would not often be reported but are required by certain countries.
			/// </summary>
			public class EventQualification : HL7Base<EventQualification>
			{

				private const string _id = "PEO.8";
				public override string Id
				{
					get { return _id; }
				}

				private readonly bool[] _repeatableHierarchy = {false, false};
				public override bool[] RepeatableHierarchy
				{
					get { return _repeatableHierarchy; }
				}

			}

						/// <summary>
			/// PEO.9 - This field indicates whether the event was judged as serious. If the event did not meet the criteria for seriousness but the sender judges the event significant on other grounds, the event can be identified as significant but not serious. Refer to HL7 Table 0238 - Event Seriousness for valid values.
			/// </summary>
			public class EventSerious : HL7Base<EventSerious>
			{

				private const string _id = "PEO.9";
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
			/// PEO.10 - This field indicates whether the observed event was expected or unexpected as judged. Refer to HL7 Table 0239 - Event Expected for valid values.
			/// </summary>
			public class EventExpected : HL7Base<EventExpected>
			{

				private const string _id = "PEO.10";
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
			/// PEO.11 - This field identifies the consequence of the event on the patient. If the consequence of the event is not understood or not available, the patient outcome element may be used although neither is required. May be repeated if more than one is appropriate. Refer to HL7 Table 0240 - Event Consequence for valid values.
			/// </summary>
			public class EventOutcome : HL7Base<EventOutcome>
			{

				private const string _id = "PEO.11";
				public override string Id
				{
					get { return _id; }
				}

				private readonly bool[] _repeatableHierarchy = {false, false};
				public override bool[] RepeatableHierarchy
				{
					get { return _repeatableHierarchy; }
				}

			}

						/// <summary>
			/// PEO.12 - When an event specific outcome is not available, the patient outcome element may be used to represent the patients overall outcome if that information is known. Refer to HL7 Table 0241 - Patient Outcome for valid values.
			/// </summary>
			public class PatientOutcome : HL7Base<PatientOutcome>
			{

				private const string _id = "PEO.12";
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
			/// PEO.13 - This field contains a summary narrative text description of the event that occurred written by the sender. Note that laboratory results can be encoded as OBX segments rather then including them in the narrative. By representing clinical information in OBX segments rather than in the narrative, these data become much more useful and flexible.
			/// </summary>
			public class EventDescriptionFromOthers : HL7Base<EventDescriptionFromOthers>
			{

				private const string _id = "PEO.13";
				public override string Id
				{
					get { return _id; }
				}

				private readonly bool[] _repeatableHierarchy = {false, false};
				public override bool[] RepeatableHierarchy
				{
					get { return _repeatableHierarchy; }
				}

			}

						/// <summary>
			/// PEO.14 - This field contains a summary narrative text description of the event that occurred written by the sender. Note that laboratory results can be encoded as OBX segments rather then including them in the narrative. By representing clinical information in OBX segments rather than in the narrative, these data become much more useful and flexible.
			/// </summary>
			public class EventDescriptionFromOriginalReporter : HL7Base<EventDescriptionFromOriginalReporter>
			{

				private const string _id = "PEO.14";
				public override string Id
				{
					get { return _id; }
				}

				private readonly bool[] _repeatableHierarchy = {false, false};
				public override bool[] RepeatableHierarchy
				{
					get { return _repeatableHierarchy; }
				}

			}

						/// <summary>
			/// PEO.15 - This field contains a summary narrative text description of the event obtained directly from the patient. Note that laboratory results can be encoded as OBX segments rather then including them in the narrative, which will allow the data to be more readily represented and manipulated.
			/// </summary>
			public class EventDescriptionFromPatient : HL7Base<EventDescriptionFromPatient>
			{

				private const string _id = "PEO.15";
				public override string Id
				{
					get { return _id; }
				}

				private readonly bool[] _repeatableHierarchy = {false, false};
				public override bool[] RepeatableHierarchy
				{
					get { return _repeatableHierarchy; }
				}

			}

						/// <summary>
			/// PEO.16 - This field contains a summary narrative text description of the event provided by the practitioner most familiar with the event. Note that laboratory results can be encoded as OBX segments rather then including them in the narrative.
			/// </summary>
			public class EventDescriptionFromPractitioner : HL7Base<EventDescriptionFromPractitioner>
			{

				private const string _id = "PEO.16";
				public override string Id
				{
					get { return _id; }
				}

				private readonly bool[] _repeatableHierarchy = {false, false};
				public override bool[] RepeatableHierarchy
				{
					get { return _repeatableHierarchy; }
				}

			}

						/// <summary>
			/// PEO.17 - This field contains a summary narrative text description of the autopsy results. Note that laboratory results can be encoded as OBX segments rather then including them in the narrative.
			/// </summary>
			public class EventDescriptionFromAutopsy : HL7Base<EventDescriptionFromAutopsy>
			{

				private const string _id = "PEO.17";
				public override string Id
				{
					get { return _id; }
				}

				private readonly bool[] _repeatableHierarchy = {false, false};
				public override bool[] RepeatableHierarchy
				{
					get { return _repeatableHierarchy; }
				}

			}

						/// <summary>
			/// PEO.18 - This field identifies the coded cause of death. May be repeated as necessary to list multiple contributing causes. A text description can be included by including text but no code or coding system. For example, if the cause of death is to be determined at autopsy but results are not yet available, the cause of death element could be Pending autopsy. The date/time of death can be sent in the PID and the autopsy results sent in the event description from autopsy element of the PEO segment.
			/// </summary>
			public class CauseOfDeath : HL7Base<CauseOfDeath>
			{

				private const string _id = "PEO.18";
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
				/// PEO.18.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
				/// </summary>
				public class Identifier : HL7Base<Identifier>
				{

					private const string _id = "PEO.18.1";
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
				/// PEO.18.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
				/// </summary>
				public class Text : HL7Base<Text>
				{

					private const string _id = "PEO.18.2";
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
				/// PEO.18.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
				/// </summary>
				public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
				{

					private const string _id = "PEO.18.3";
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
				/// PEO.18.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
				/// </summary>
				public class AlternateIdentifier : HL7Base<AlternateIdentifier>
				{

					private const string _id = "PEO.18.4";
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
				/// PEO.18.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
				/// </summary>
				public class AlternateText : HL7Base<AlternateText>
				{

					private const string _id = "PEO.18.5";
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
				/// PEO.18.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
				{

					private const string _id = "PEO.18.6";
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
				/// PEO.18.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
				/// </summary>
				public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
				{

					private const string _id = "PEO.18.7";
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
				/// PEO.18.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
				/// </summary>
				public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
				{

					private const string _id = "PEO.18.8";
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
				/// PEO.18.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
				/// </summary>
				public class OriginalText : HL7Base<OriginalText>
				{

					private const string _id = "PEO.18.9";
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
				/// PEO.18.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
				/// </summary>
				public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
				{

					private const string _id = "PEO.18.10";
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
				/// PEO.18.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
				/// </summary>
				public class SecondAlternateText : HL7Base<SecondAlternateText>
				{

					private const string _id = "PEO.18.11";
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
				/// PEO.18.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
				{

					private const string _id = "PEO.18.12";
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
				/// PEO.18.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
				/// </summary>
				public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
				{

					private const string _id = "PEO.18.13";
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
				/// PEO.18.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
				/// </summary>
				public class CodingSystemOid : HL7Base<CodingSystemOid>
				{

					private const string _id = "PEO.18.14";
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
				/// PEO.18.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class ValueSetOid : HL7Base<ValueSetOid>
				{

					private const string _id = "PEO.18.15";
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
				/// PEO.18.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
				/// </summary>
				public class ValueSetVersionId : HL7Base<ValueSetVersionId>
				{

					private const string _id = "PEO.18.16";
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
				/// PEO.18.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
				/// </summary>
				public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
				{

					private const string _id = "PEO.18.17";
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
				/// PEO.18.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
				{

					private const string _id = "PEO.18.18";
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
				/// PEO.18.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
				/// </summary>
				public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
				{

					private const string _id = "PEO.18.19";
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
				/// PEO.18.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
				/// </summary>
				public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
				{

					private const string _id = "PEO.18.20";
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
				/// PEO.18.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
				{

					private const string _id = "PEO.18.21";
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
				/// PEO.18.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
				/// </summary>
				public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
				{

					private const string _id = "PEO.18.22";
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
			/// PEO.19 - This field identifies the name of the person who initially described the event.
			/// </summary>
			public class PrimaryObserverName : HL7Base<PrimaryObserverName>
			{

				private const string _id = "PEO.19";
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
				/// PEO.19.1 - This component allows full specification of the surname of a person. Where appropriate, it differentiates the person's own surname from that of the person's partner or spouse, in cases where the person's name may contain elements from either name. It also permits messages to distinguish the surname prefix (such as "van" or "de") from the surname root. See section 2.A.30, "FN - family name".XPN.1 will be empty when XPN.7 is MSK. It MAY be empty when XPN.7 is NAV.Usage Note If a persons name has only one component, that name will be sent in XPN.1 Family Name. This is common practice in some countries such as Indonesia. This note does not cover the case where only one part of a person's multi-part name is known (e.g., only know "John" of "John Doe").
				/// </summary>
				public class FamilyName : HL7Base<FamilyName>
				{

					private const string _id = "PEO.19.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

										/// <summary>
					/// PEO.19.1.1 - The atomic element of the person's family name. In most Western usage, this is the person's last name.
					/// </summary>
					public class Surname : HL7Base<Surname>
					{

						private const string _id = "PEO.19.1.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.19.1.2 - Internationalization usage for Germanic languages. This component is optional. An example of a surname prefix is the "van" in "Ludwig van Beethoven". Since the surname prefix doesn't sort completely alphabetically, it is reasonable to specify it as a separate sub-component of the PN and extended PN data types (XPN and XCN).Note Subcomponents own surname prefix, own surname, surname prefix from partner/spouse and surname from partner/spouse decompose complex Germanic names such as Martha de Mum-van Beethoven. If these subcomponents are valued, the surname subcomponent should still be fully valued for backward compatibility, i.e., de Mum-van Beethoven&de&Mum&van&Beethoven.Also, for clarity, the last name prefix has been renamed to own surname prefix.
					/// </summary>
					public class OwnSurnamePrefix : HL7Base<OwnSurnamePrefix>
					{

						private const string _id = "PEO.19.1.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.19.1.3 - The portion of the surname (in most Western usage, the last name) that is derived from the person's own surname, as distinguished from any portion that is derived from the surname of the person's partner or spouse. This component is optional.If the person's surname has legally changed to become (or incorporate) the surname of the person's partner or spouse, this is the person's surname immediately prior to such change. Often this is the person's "maiden name".
					/// </summary>
					public class OwnSurname : HL7Base<OwnSurname>
					{

						private const string _id = "PEO.19.1.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.19.1.4 - Internationalization usage for Germanic languages. This component is optional. An example of a surname prefix is the van in "Ludwig van Beethoven". Since the surname prefix doesn't sort completely alphabetically, it is reasonable to specify it as a separate sub-component of the PN and extended PN data types (XPN and XCN). Note Subcomponents own surname prefix, own surname, surname prefix from partner/spouse and surname from partner/spouse decompose complex Germanic names such as Martha de Mum-van Beethoven. If these subcomponents are valued, the surname subcomponent should still be fully valued for backward compatibility, i.e., de Mum-van Beethoven&de&Mum&van&Beethoven.Also, for clarity, the last name prefix has been renamed to own surname prefix.
					/// </summary>
					public class SurnamePrefixFromPartnerSpouse : HL7Base<SurnamePrefixFromPartnerSpouse>
					{

						private const string _id = "PEO.19.1.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.19.1.5 - The portion of the person's surname (in most Western usage, the last name) that is derived from the surname of the person's partner or spouse, as distinguished from the part derived from the person's own surname. This component is optional.If no portion of the person's surname is derived from the surname of the person's partner or spouse, this component is not valued. Otherwise, if the surname of the partner or spouse has legally changed to become (or incorporate) the person's surname, this is the surname of the partner or spouse immediately prior to such change.
					/// </summary>
					public class SurnameFromPartnerSpouse : HL7Base<SurnameFromPartnerSpouse>
					{

						private const string _id = "PEO.19.1.5";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

				}

								/// <summary>
				/// PEO.19.2 - First name.
				/// </summary>
				public class GivenName : HL7Base<GivenName>
				{

					private const string _id = "PEO.19.2";
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
				/// PEO.19.3 - Multiple middle names may be included by separating them with spaces.
				/// </summary>
				public class SecondAndFurtherGivenNamesOrInitialsThereof : HL7Base<SecondAndFurtherGivenNamesOrInitialsThereof>
				{

					private const string _id = "PEO.19.3";
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
				/// PEO.19.4 - Used to specify a name suffix (e.g., Jr. or III).
				/// </summary>
				public class SuffixegJrOrIii : HL7Base<SuffixegJrOrIii>
				{

					private const string _id = "PEO.19.4";
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
				/// PEO.19.5 - Used to specify a name prefix (e.g., Dr.).
				/// </summary>
				public class PrefixegDr : HL7Base<PrefixegDr>
				{

					private const string _id = "PEO.19.5";
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
				/// PEO.19.6 - Attention The XPN-6 component was deprecated as of v2.5 and the detail was withdrawn and removed from the standard as of v 2.7. See XPN.14 Professional Suffix.
				/// </summary>
				public class DegreeegMd : HL7Base<DegreeegMd>
				{

					private const string _id = "PEO.19.6";
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
				/// PEO.19.7 - A code that represents the type of name. Refer to HL7 Table 0200 - Name Type for valid values.Note The content of Legal Name is country specific. In the US the legal name is the same as the current married name.
				/// </summary>
				public class NameTypeCode : HL7Base<NameTypeCode>
				{

					private const string _id = "PEO.19.7";
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
				/// PEO.19.8 - Different name/address types and representations of the same name/address should be described by repeating of this field, with different values of the name/address type and/or name/address representation component.Note This new component remains in "alphabetic" representation with each repetition of the field using these data types, i.e., even though the name may be represented in an ideographic character set, this component will remain represented in an alphabetic character set.Refer to HL7 Table 0465  Name/address Representation for valid values.In general this component provides an indication of the representation provided by the data item. It does not necessarily specify the character sets used. Thus, even though the representation might provide an indication of what to expect, the sender is still free to encode the contents using whatever character set is desired. This component provides only hints for the receiver, so it can make choices regarding what it has been sent and what it is capable of displaying.
				/// </summary>
				public class NameRepresentationCode : HL7Base<NameRepresentationCode>
				{

					private const string _id = "PEO.19.8";
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
				/// PEO.19.9 - This component is used to designate the context in which a name is used. The main use case is in Australian healthcare for indigenous patients who prefer to use different names when attending different healthcare institutions. Another use case occurs in the US where health practitioners can be licensed under slightly different names and the reporting of the correct name is vital for administrative purposes. Refer to User-defined Table 0448  Name Context for suggested values.
				/// </summary>
				public class NameContext : HL7Base<NameContext>
				{

					private const string _id = "PEO.19.9";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

										/// <summary>
					/// PEO.19.9.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "PEO.19.9.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.19.9.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "PEO.19.9.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.19.9.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "PEO.19.9.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.19.9.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "PEO.19.9.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.19.9.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "PEO.19.9.5";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.19.9.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "PEO.19.9.6";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.19.9.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "PEO.19.9.7";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.19.9.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "PEO.19.9.8";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.19.9.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "PEO.19.9.9";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.19.9.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "PEO.19.9.10";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.19.9.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "PEO.19.9.11";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.19.9.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "PEO.19.9.12";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.19.9.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "PEO.19.9.13";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.19.9.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "PEO.19.9.14";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.19.9.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "PEO.19.9.15";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.19.9.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "PEO.19.9.16";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.19.9.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "PEO.19.9.17";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.19.9.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "PEO.19.9.18";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.19.9.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "PEO.19.9.19";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.19.9.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "PEO.19.9.20";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.19.9.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "PEO.19.9.21";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.19.9.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "PEO.19.9.22";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

				}

								/// <summary>
				/// PEO.19.10 - Attention The XPN.10 component was deprecated as of v2.5 and the detail was withdrawn and removed from the standard as of v2.7. Refer to 2.A.89.12, "Effective date (DTM)" and 2.A.89.13, "Expiration date (DTM)" components.
				/// </summary>
				public class NameValidityRange : HL7Base<NameValidityRange>
				{

					private const string _id = "PEO.19.10";
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
				/// PEO.19.11 - A code that represents the preferred display order of the components of this person name. Refer to HL7 0444  Name Assembly Order for valid values.
				/// </summary>
				public class NameAssemblyOrder : HL7Base<NameAssemblyOrder>
				{

					private const string _id = "PEO.19.11";
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
				/// PEO.19.12 - The first date, if known, on which the person name is valid and active.
				/// </summary>
				public class EffectiveDate : HL7Base<EffectiveDate>
				{

					private const string _id = "PEO.19.12";
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
				/// PEO.19.13 - The last date, if known, on which the person name is valid and active.
				/// </summary>
				public class ExpirationDate : HL7Base<ExpirationDate>
				{

					private const string _id = "PEO.19.13";
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
				/// PEO.19.14 - Used to specify an abbreviation, or a string of abbreviations denoting qualifications that support the persons profession, (e.g., licenses, certificates, degrees, affiliations with professional societies, etc.). The Professional Suffix normally follows the Family Name when the Person Name is used for display purposes. Please note that this component is an unformatted string and is used for display purposes only. Detailed information regarding the contents of Professional Suffix is obtained using appropriate segments in Chapter 15, Personnel Management.
				/// </summary>
				public class ProfessionalSuffix : HL7Base<ProfessionalSuffix>
				{

					private const string _id = "PEO.19.14";
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
				/// PEO.19.15 - A "called by" name is the name that is preferred when a person is directly addressed sometimes known as a nickname.Note The called by component contains a name that could be categorized as a nickname using the name usage types in HL7 Table 0200 - Name type. Its use is reserved for instances in which the nickname is a single name part that is provided in addition to a name that has some other type, such as legal. It is understood that the "called by" name is not part of the full name. Where a nickname has more parts, possibly including a family name, a different XPN with a type of nickname should instead be used.Examples - James Robert Smith is Called By Jim Bob - James Robert Smith is Called By JR - Peter Richard Smith is Called By Richard - Mary Margaret Elizabeth Jones is Called By Meg.
				/// </summary>
				public class CalledBy : HL7Base<CalledBy>
				{

					private const string _id = "PEO.19.15";
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
			/// PEO.20 - This field identifies the address of the person who initially described the event.
			/// </summary>
			public class PrimaryObserverAddress : HL7Base<PrimaryObserverAddress>
			{

				private const string _id = "PEO.20";
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
				/// PEO.20.1 - This component contains the house number, apartment number, street name, street direction, P.O. Box number, and similar address information. 
				/// </summary>
				public class StreetAddress : HL7Base<StreetAddress>
				{

					private const string _id = "PEO.20.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

										/// <summary>
					/// PEO.20.1.1 - This component specifies the street or mailing address of a person or institution. When referencing an institution, this first component is used to specify the institution name. When used in connection with a person, this component specifies the first line of the address.
					/// </summary>
					public class StreetOrMailingAddress : HL7Base<StreetOrMailingAddress>
					{

						private const string _id = "PEO.20.1.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.1.2 - 
					/// </summary>
					public class StreetName : HL7Base<StreetName>
					{

						private const string _id = "PEO.20.1.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.1.3 - 
					/// </summary>
					public class DwellingNumber : HL7Base<DwellingNumber>
					{

						private const string _id = "PEO.20.1.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

				}

								/// <summary>
				/// PEO.20.2 - This component contains the second line of address. In US usage, it qualifies address. Examples Suite 555 or Fourth Floor. When referencing an institution, this component specifies the street address.
				/// </summary>
				public class OtherDesignation : HL7Base<OtherDesignation>
				{

					private const string _id = "PEO.20.2";
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
				/// PEO.20.3 - This component specifies the city, or district or place where the addressee is located depending upon the national convention for formatting addresses for postal usage.
				/// </summary>
				public class City : HL7Base<City>
				{

					private const string _id = "PEO.20.3";
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
				/// PEO.20.4 - This component specifies the state or province where the addressee is located. State or province should be represented by the official postal service codes for that country.
				/// </summary>
				public class StateOrProvince : HL7Base<StateOrProvince>
				{

					private const string _id = "PEO.20.4";
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
				/// PEO.20.5 - This component specifies the zip or postal code where the addressee is located. Zip or postal codes should be represented by the official codes for that country. In the US, the zip code takes the form 99999-9999, while the Canadian postal code takes the form A9A9A9, and the Australian Postcode takes the form 9999.
				/// </summary>
				public class ZipOrPostalCode : HL7Base<ZipOrPostalCode>
				{

					private const string _id = "PEO.20.5";
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
				/// PEO.20.6 - This component specifies the country where the addressee is located.  HL7 specifies that the 3-character (alphabetic) form of ISO 3166 be used for the country code. Refer to HL7 Table 0399  Country Code for valid values.
				/// </summary>
				public class Country : HL7Base<Country>
				{

					private const string _id = "PEO.20.6";
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
				/// PEO.20.7 - This component specifies the kind or type of address. Refer to HL7 Table 0190 - Address Type for valid values.XAD.7 is required if there are multiple occurrences of XAD in a field.
				/// </summary>
				public class AddressType : HL7Base<AddressType>
				{

					private const string _id = "PEO.20.7";
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
				/// PEO.20.8 - This component specifies any other geographic designation. It includes county, bioregion, SMSA, etc.
				/// </summary>
				public class OtherGeographicDesignation : HL7Base<OtherGeographicDesignation>
				{

					private const string _id = "PEO.20.8";
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
				/// PEO.20.9 - A code that represents the county in which the specified address resides. User-defined Table 0289 - County/parish is used as the HL7 identifier for the user-defined table of values for this component. When this component is used to represent the county (or parish), component 8 other geographic designation should not duplicate it (i.e., the use of other geographic designation to represent the county is allowed only for the purpose of backward compatibility, and should be discouraged in this and future versions of HL7).Allowable values codes defined by government.
				/// </summary>
				public class CountyParishCode : HL7Base<CountyParishCode>
				{

					private const string _id = "PEO.20.9";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

										/// <summary>
					/// PEO.20.9.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "PEO.20.9.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.9.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "PEO.20.9.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.9.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "PEO.20.9.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.9.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "PEO.20.9.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.9.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "PEO.20.9.5";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.9.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "PEO.20.9.6";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.9.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "PEO.20.9.7";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.9.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "PEO.20.9.8";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.9.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "PEO.20.9.9";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.9.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "PEO.20.9.10";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.9.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "PEO.20.9.11";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.9.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "PEO.20.9.12";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.9.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "PEO.20.9.13";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.9.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "PEO.20.9.14";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.9.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "PEO.20.9.15";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.9.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "PEO.20.9.16";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.9.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "PEO.20.9.17";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.9.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "PEO.20.9.18";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.9.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "PEO.20.9.19";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.9.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "PEO.20.9.20";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.9.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "PEO.20.9.21";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.9.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "PEO.20.9.22";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

				}

								/// <summary>
				/// PEO.20.10 - A code that represents the census tract in which the specified address resides. User-defined Table 0288 - Census Tract is used as the HL7 identifier for the user-defined table of values for this component.Allowable Values codes defined by government.
				/// </summary>
				public class CensusTract : HL7Base<CensusTract>
				{

					private const string _id = "PEO.20.10";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

										/// <summary>
					/// PEO.20.10.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "PEO.20.10.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.10.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "PEO.20.10.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.10.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "PEO.20.10.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.10.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "PEO.20.10.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.10.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "PEO.20.10.5";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.10.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "PEO.20.10.6";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.10.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "PEO.20.10.7";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.10.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "PEO.20.10.8";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.10.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "PEO.20.10.9";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.10.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "PEO.20.10.10";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.10.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "PEO.20.10.11";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.10.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "PEO.20.10.12";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.10.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "PEO.20.10.13";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.10.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "PEO.20.10.14";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.10.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "PEO.20.10.15";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.10.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "PEO.20.10.16";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.10.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "PEO.20.10.17";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.10.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "PEO.20.10.18";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.10.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "PEO.20.10.19";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.10.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "PEO.20.10.20";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.10.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "PEO.20.10.21";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.10.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "PEO.20.10.22";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

				}

								/// <summary>
				/// PEO.20.11 - Different name/address types and representations of the same name/address should be described by repeating of this field, with different values of the name/address type and/or name/address representation component.Note Also note that this new component remains in "alphabetic" representation with each repetition of the fields using these data types. I.e. even though the address may be represented in an ideographic character set, this component will remain represented in an alphabetic character set.Refer to HL7 Table 0465  Name/address Representation for valid values.In general this component provides an indication of the representation provided by the data item. It does not necessarily specify the character sets used. Thus, even though the representation might provide an indication of what to expect, the sender is still free to encode the contents using whatever character set is desired. This component provides only hints for the receiver, so it can make choices regarding what it has been sent and what it is capable of displaying.
				/// </summary>
				public class AddressRepresentationCode : HL7Base<AddressRepresentationCode>
				{

					private const string _id = "PEO.20.11";
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
				/// PEO.20.12 - Attention The XAD.12 component was retained for backward compatibility as of v2.5 and the detail was withdrawn and removed from the standard as of v2.7. Refer to 2.A.86.13, "Effective Date (DTM)" and 2.A.86.14, "Expiration Date (DTM)" components.
				/// </summary>
				public class AddressValidityRange : HL7Base<AddressValidityRange>
				{

					private const string _id = "PEO.20.12";
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
				/// PEO.20.13 - The first date, if known, on which the address is valid and active for the owning entity.
				/// </summary>
				public class EffectiveDate : HL7Base<EffectiveDate>
				{

					private const string _id = "PEO.20.13";
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
				/// PEO.20.14 - The last date, if known, on which the address is valid and active for the owning entity.
				/// </summary>
				public class ExpirationDate : HL7Base<ExpirationDate>
				{

					private const string _id = "PEO.20.14";
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
				/// PEO.20.15 - This identifies why this address was marked as "ended".   Refer to User-defined Table 0616  Address Expiration Reason for valid values.
				/// </summary>
				public class ExpirationReason : HL7Base<ExpirationReason>
				{

					private const string _id = "PEO.20.15";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

										/// <summary>
					/// PEO.20.15.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "PEO.20.15.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.15.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "PEO.20.15.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.15.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "PEO.20.15.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.15.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "PEO.20.15.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.15.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "PEO.20.15.5";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.15.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "PEO.20.15.6";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.15.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "PEO.20.15.7";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.15.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "PEO.20.15.8";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.15.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "PEO.20.15.9";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.15.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "PEO.20.15.10";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.15.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "PEO.20.15.11";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.15.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "PEO.20.15.12";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.15.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "PEO.20.15.13";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.15.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "PEO.20.15.14";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.15.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "PEO.20.15.15";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.15.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "PEO.20.15.16";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.15.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "PEO.20.15.17";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.15.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "PEO.20.15.18";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.15.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "PEO.20.15.19";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.15.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "PEO.20.15.20";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.15.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "PEO.20.15.21";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.15.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "PEO.20.15.22";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

				}

								/// <summary>
				/// PEO.20.16 - If "Y" this indicates that the address is considered temporary.  Refer to HL7 Table 0136  Yes/No Indicator.
				/// </summary>
				public class TemporaryIndicator : HL7Base<TemporaryIndicator>
				{

					private const string _id = "PEO.20.16";
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
				/// PEO.20.17 - If "Y", this indicates that it is not possible to contact the "owning" entity at this address. Refer to HL7 Table 0136  Yes/No Indicator.
				/// </summary>
				public class BadAddressIndicator : HL7Base<BadAddressIndicator>
				{

					private const string _id = "PEO.20.17";
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
				/// PEO.20.18 - This indicates how the address is intended to be used.  Refer to User-defined Table 0617  Address Usage for valid values.
				/// </summary>
				public class AddressUsage : HL7Base<AddressUsage>
				{

					private const string _id = "PEO.20.18";
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
				/// PEO.20.19 - Identifies the name of the person or organization that should appear as part of the address. This is also known as the "Care of" or "C/O" line.
				/// </summary>
				public class Addressee : HL7Base<Addressee>
				{

					private const string _id = "PEO.20.19";
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
				/// PEO.20.20 - Descriptive information about the use of the address.Example "Do not ring bell."
				/// </summary>
				public class Comment : HL7Base<Comment>
				{

					private const string _id = "PEO.20.20";
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
				/// PEO.20.21 - For an entity having multiple addresses, indicates which is the 'most preferred' (lowest number) to 'least preferred' (highest number).If the preference order is unique across all usages for a given type, then it indicates the preference across all usages, (e.g., first try my home address, then my business address). Otherwise, the preference order is assumed to only apply within a specific usage.Preference order numbers need not be sequential (i.e., four addresses with the priority orders of 10, 1, 5 and 15 are legitimate). The preference order numbers must be non-negative.
				/// </summary>
				public class PreferenceOrder : HL7Base<PreferenceOrder>
				{

					private const string _id = "PEO.20.21";
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
				/// PEO.20.22 - Identifies that an address needs to be treated with special care or sensitivity.The specific set of codes and appropriate handling of such addresses will vary by jurisdiction and is subject to site-specific negotiation. For example, a provider address marked as 'unlisted' might not be printed in an internal address listing.  Refer to User-defined Table 0618  Protection Code for valid values.
				/// </summary>
				public class ProtectionCode : HL7Base<ProtectionCode>
				{

					private const string _id = "PEO.20.22";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

										/// <summary>
					/// PEO.20.22.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "PEO.20.22.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.22.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "PEO.20.22.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.22.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "PEO.20.22.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.22.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "PEO.20.22.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.22.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "PEO.20.22.5";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.22.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "PEO.20.22.6";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.22.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "PEO.20.22.7";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.22.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "PEO.20.22.8";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.22.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "PEO.20.22.9";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.22.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "PEO.20.22.10";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.22.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "PEO.20.22.11";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.22.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "PEO.20.22.12";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.22.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "PEO.20.22.13";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.22.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "PEO.20.22.14";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.22.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "PEO.20.22.15";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.22.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "PEO.20.22.16";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.22.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "PEO.20.22.17";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.22.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "PEO.20.22.18";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.22.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "PEO.20.22.19";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.22.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "PEO.20.22.20";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.22.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "PEO.20.22.21";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.22.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "PEO.20.22.22";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

				}

								/// <summary>
				/// PEO.20.23 - A unique identifier for the address.This component allows an address to be uniquely identified, and enables the linking of a single address to multiple people and contexts. For example, each member of a family living at the same location would share the same address, having the same identifier. A correction to the address of one family member could be automatically propagated to other members of the family.
				/// </summary>
				public class AddressIdentifier : HL7Base<AddressIdentifier>
				{

					private const string _id = "PEO.20.23";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

										/// <summary>
					/// PEO.20.23.1 - The first component, entity identifier, is usually defined to be unique within the series of identifiers created by the assigning authority, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, "HD - hierarchic designator".
					/// </summary>
					public class EntityIdentifier : HL7Base<EntityIdentifier>
					{

						private const string _id = "PEO.20.23.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.23.2 - See Section 2.A.33.1, "Namespace ID (IS)" for definition. The component intentionally remains associated with the IS data type in v 2.7.The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363  Assigning Authority for suggested values.Note When the HD is used as a part of another data type, in this case as part of the EI data type, this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment. By site agreement, implementers may continue to use User-defined Table 0300  Namespace ID for the first component
					/// </summary>
					public class NamespaceId : HL7Base<NamespaceId>
					{

						private const string _id = "PEO.20.23.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.23.3 - See Section 2.A.33.2, "Universal ID (ST)" for definition.
					/// </summary>
					public class UniversalId : HL7Base<UniversalId>
					{

						private const string _id = "PEO.20.23.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.20.23.4 - Refer to HL7 Table 0301 - Universal ID Type for valid values. See Section 2.A.33.3, "Universal ID Type (ID)," for definition.
					/// </summary>
					public class UniversalIdType : HL7Base<UniversalIdType>
					{

						private const string _id = "PEO.20.23.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

				}

			}

						/// <summary>
			/// PEO.21 - This field identifies the telephone number of the person who initially described the event.
			/// </summary>
			public class PrimaryObserverTelephone : HL7Base<PrimaryObserverTelephone>
			{

				private const string _id = "PEO.21";
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
				/// PEO.21.1 - Attention The XTN-1 component was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v2.6.
				/// </summary>
				public class TelephoneNumber : HL7Base<TelephoneNumber>
				{

					private const string _id = "PEO.21.1";
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
				/// PEO.21.2 - A code that represents a specific use of a telecommunication number. Refer to HL7 Table 0201 - Telecommunication Use Code for valid values. This component along with XTN.3 describes the nature of the telecommunication data that follows. Best practice requires the population of XTN.2 when XTN.4 or XTN.7 is populated. 
				/// </summary>
				public class TelecommunicationUseCode : HL7Base<TelecommunicationUseCode>
				{

					private const string _id = "PEO.21.2";
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
				/// PEO.21.3 - A code that represents the type of telecommunication equipment. Refer to HL7 Table 0202 - Telecommunication Equipment Type for valid values. This component along with XTN.2 describes the nature of the telecommunication data that follows and is necessary to accurately interpret it.
				/// </summary>
				public class TelecommunicationEquipmentType : HL7Base<TelecommunicationEquipmentType>
				{

					private const string _id = "PEO.21.3";
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
				/// PEO.21.4 - This component is required if, and only allowed if, XTN.7 or XTN.12 are not populated.  Note If any of the HL7 delimiters are found in the Communication Address, such as , the appropriate HL7 escape sequence SHALL be used when encoding an Internet address (see Chapter 2, "Control", section 2.7.1, "Formatting Codes").
				/// </summary>
				public class CommunicationAddress : HL7Base<CommunicationAddress>
				{

					private const string _id = "PEO.21.4";
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
				/// PEO.21.5 - The numeric code assigned by the International Telecommunication Union in standard E.164 to access telephone services in another country.  For example, "+1" is the country code for the United States, "+49" is the code for Germany.
				/// </summary>
				public class CountryCode : HL7Base<CountryCode>
				{

					private const string _id = "PEO.21.5";
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
				/// PEO.21.6 - The numeric code to access telephone services in another area/city within a country. This number historically needs not be dialed if the caller is located in the same area/city as the phone number of the called party.The use and size of area/city codes is however country specific some countries do not use area/city codes, or the use of area/city codes may be mandatory when dialing, or area/city codes may be used to group phone numbers based on other criteria than geographic location, such as cell-phone area/city-codes, or free information numbers (e.g., 800 numbers).Most countries have a prefix for Area/City codes which only has to be dialed if one doesn't use a country code. This prefix (mostly "0", sometimes "9") should be omitted from the content of this field. If the prefix for the Area/Code is also mandatory if one uses the country code (e.g., in Italy) then this field should also contain the prefix.
				/// </summary>
				public class AreaCityCode : HL7Base<AreaCityCode>
				{

					private const string _id = "PEO.21.6";
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
				/// PEO.21.7 - The numeric code used to contact the called party, exclusive of country and area/city codes. The Local Number is required when, and allowed only if, XTN.4 and XTN.12 are not populated. The size of the Local Number is country specific.Note that the Local Number does not include the numeric codes that have to be dialed once a connection has been established. Examples include (automated) organizational phone systems which allow external callers to dial additional numeric codes. These additional numeric codes should be specified as an extension.
				/// </summary>
				public class LocalNumber : HL7Base<LocalNumber>
				{

					private const string _id = "PEO.21.7";
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
				/// PEO.21.8 - The numeric code to contact the called party used within an organization, e.g., the number used if both caller and called party are located within the same organization. The extension is often the same as the last few digits of the Local Number. The use of extensions is country and site specific, and may depend on the type of phone system (PBX) used by the organization.
				/// </summary>
				public class Extension : HL7Base<Extension>
				{

					private const string _id = "PEO.21.8";
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
				/// PEO.21.9 - Contains comments with respect to the telephone number.Example Do not use after 5PM
				/// </summary>
				public class AnyText : HL7Base<AnyText>
				{

					private const string _id = "PEO.21.9";
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
				/// PEO.21.10 - The characters established within a companys internal telephone system network used as a prefix to the Extension component for internal dialing. Note that the use of Extension Prefix requires that the Extension component be valued and that digits, as well as special characters (e.g., *, #) may be used.
				/// </summary>
				public class ExtensionPrefix : HL7Base<ExtensionPrefix>
				{

					private const string _id = "PEO.21.10";
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
				/// PEO.21.11 - The characters established within a companys internal telephone system used in place of the (external) telephone number to facilitate calling because its length is shorter than that of the telephone number. Note that digits, as well as special characters (e.g., *, #) may be used.
				/// </summary>
				public class SpeedDialCode : HL7Base<SpeedDialCode>
				{

					private const string _id = "PEO.21.11";
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
				/// PEO.21.12 - An expression of the telephone number as an unparsable string. The Unformatted Telephone number is required when, and allowed only if, XTN.4 and XTN.7 are not populated.The phone number was entered as free text and sending system does not know how to parse it. Example 1-800-Dentist
				/// </summary>
				public class UnformattedTelephoneNumber : HL7Base<UnformattedTelephoneNumber>
				{

					private const string _id = "PEO.21.12";
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
				/// PEO.21.13 - The first date, if known, on which the telecommunication number is valid and active.
				/// </summary>
				public class EffectiveStartDate : HL7Base<EffectiveStartDate>
				{

					private const string _id = "PEO.21.13";
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
				/// PEO.21.14 - The last date, if known, on which the telecommunication number is valid and active.
				/// </summary>
				public class ExpirationDate : HL7Base<ExpirationDate>
				{

					private const string _id = "PEO.21.14";
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
				/// PEO.21.15 - Indicates why this contact number/e-mail was marked as "ended".  Refer to User-defined Table 0868  Telecommunication Expiration Reason for valid values.
				/// </summary>
				public class ExpirationReason : HL7Base<ExpirationReason>
				{

					private const string _id = "PEO.21.15";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

										/// <summary>
					/// PEO.21.15.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "PEO.21.15.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.21.15.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "PEO.21.15.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.21.15.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "PEO.21.15.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.21.15.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "PEO.21.15.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.21.15.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "PEO.21.15.5";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.21.15.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "PEO.21.15.6";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.21.15.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "PEO.21.15.7";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.21.15.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "PEO.21.15.8";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.21.15.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "PEO.21.15.9";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.21.15.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "PEO.21.15.10";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.21.15.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "PEO.21.15.11";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.21.15.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "PEO.21.15.12";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.21.15.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "PEO.21.15.13";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.21.15.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "PEO.21.15.14";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.21.15.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "PEO.21.15.15";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.21.15.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "PEO.21.15.16";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.21.15.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "PEO.21.15.17";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.21.15.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "PEO.21.15.18";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.21.15.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "PEO.21.15.19";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.21.15.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "PEO.21.15.20";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.21.15.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "PEO.21.15.21";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.21.15.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "PEO.21.15.22";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

				}

								/// <summary>
				/// PEO.21.16 - Indicates whether this information is considered sensitive or should be protected in some way. Refer to User-defined table 0618 - Protection Code for suggested values.The specific set of codes and appropriate handling of such telecommunications addresses will vary by jurisdiction and is subject to site-specific negotiation. For example, a provider address marked as 'unlisted' might not be printed in an internal address listing.
				/// </summary>
				public class ProtectionCode : HL7Base<ProtectionCode>
				{

					private const string _id = "PEO.21.16";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

										/// <summary>
					/// PEO.21.16.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "PEO.21.16.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.21.16.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "PEO.21.16.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.21.16.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "PEO.21.16.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.21.16.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "PEO.21.16.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.21.16.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "PEO.21.16.5";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.21.16.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "PEO.21.16.6";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.21.16.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "PEO.21.16.7";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.21.16.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "PEO.21.16.8";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.21.16.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "PEO.21.16.9";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.21.16.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "PEO.21.16.10";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.21.16.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "PEO.21.16.11";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.21.16.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "PEO.21.16.12";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.21.16.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "PEO.21.16.13";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.21.16.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "PEO.21.16.14";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.21.16.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "PEO.21.16.15";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.21.16.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "PEO.21.16.16";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.21.16.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "PEO.21.16.17";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.21.16.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "PEO.21.16.18";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.21.16.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "PEO.21.16.19";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.21.16.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "PEO.21.16.20";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.21.16.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "PEO.21.16.21";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.21.16.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "PEO.21.16.22";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

				}

								/// <summary>
				/// PEO.21.17 - A unique identifier for the phone number or e-mail address.This component allows a phone number to be uniquely identified, and enables the linking of a single phone number to multiple people and contexts. For example, each member of a family living at the same location would share the same phone number, having the same identifier. A correction to the phone number of one family member could be automatically propagated to other members of the family.HL7 does not assume responsibility for the processing rules for this component.
				/// </summary>
				public class SharedTelecommunicationIdentifier : HL7Base<SharedTelecommunicationIdentifier>
				{

					private const string _id = "PEO.21.17";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

										/// <summary>
					/// PEO.21.17.1 - The first component, entity identifier, is usually defined to be unique within the series of identifiers created by the assigning authority, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, "HD - hierarchic designator".
					/// </summary>
					public class EntityIdentifier : HL7Base<EntityIdentifier>
					{

						private const string _id = "PEO.21.17.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.21.17.2 - See Section 2.A.33.1, "Namespace ID (IS)" for definition. The component intentionally remains associated with the IS data type in v 2.7.The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363  Assigning Authority for suggested values.Note When the HD is used as a part of another data type, in this case as part of the EI data type, this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment. By site agreement, implementers may continue to use User-defined Table 0300  Namespace ID for the first component
					/// </summary>
					public class NamespaceId : HL7Base<NamespaceId>
					{

						private const string _id = "PEO.21.17.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.21.17.3 - See Section 2.A.33.2, "Universal ID (ST)" for definition.
					/// </summary>
					public class UniversalId : HL7Base<UniversalId>
					{

						private const string _id = "PEO.21.17.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// PEO.21.17.4 - Refer to HL7 Table 0301 - Universal ID Type for valid values. See Section 2.A.33.3, "Universal ID Type (ID)," for definition.
					/// </summary>
					public class UniversalIdType : HL7Base<UniversalIdType>
					{

						private const string _id = "PEO.21.17.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

				}

								/// <summary>
				/// PEO.21.18 - For an entity having multiple telecommunication addresses, indicates which is the "most preferred" (lowest number) to "least preferred" (highest number).If the preference order is unique across all usages for a given type, then it indicates the preference across all usages, (e.g. first try my home number, then my business number). If the preference order is unique across all usages and types, then it indicates the preference across all types of telecommunication addresses.  (E.g., first try my phone if that doesn't work, use my pager.) Otherwise, the preference order is assumed to only apply within a specific type and usage.Preference order numbers need not be sequential (i.e., three numbers with the priority orders of 0, 5 and 15 are legitimate).  The preference order numbers must be non-negative.
				/// </summary>
				public class PreferenceOrder : HL7Base<PreferenceOrder>
				{

					private const string _id = "PEO.21.18";
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
			/// PEO.22 - This field contains the qualification of the primary observer which may assist in assessing the validity of the observations. Refer to HL7 Table 0242 - Primary Observers Qualification for valid values.
			/// </summary>
			public class PrimaryObserversQualification : HL7Base<PrimaryObserversQualification>
			{

				private const string _id = "PEO.22";
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
			/// PEO.23 - This field contains the qualification of the health professional who confirmed the observation if the primary observer was not a health professional. Refer to HL7 Table 0242 - Primary Observers Qualification for valid values.
			/// </summary>
			public class ConfirmationProvidedBy : HL7Base<ConfirmationProvidedBy>
			{

				private const string _id = "PEO.23";
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
			/// PEO.24 - This field identifies the date/time the primary observer became aware of event.
			/// </summary>
			public class PrimaryObserverAwareDateTime : HL7Base<PrimaryObserverAwareDateTime>
			{

				private const string _id = "PEO.24";
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
			/// PEO.25 - Indicates whether or not the primary observer, if known to the sender, grants permission to disclose his or her identity to the product manufacturer for the purpose of further investigating the event. If the element is absent, the assumption should be made that permission is not granted. Refer to HL7 Table 0243 - Identity May Be Divulged for valid values.
			/// </summary>
			public class PrimaryObserversIdentityMayBeDivulged : HL7Base<PrimaryObserversIdentityMayBeDivulged>
			{

				private const string _id = "PEO.25";
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

