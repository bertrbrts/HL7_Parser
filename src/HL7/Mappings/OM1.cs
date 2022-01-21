using Newtonsoft.Json;
namespace care.ai.cloud.functions.hl7
{
	public partial class Mappings {
		/// <summary>
		/// The OM1 segment contains the attributes that apply to the definition of most observations.  This segment also contains the field attributes that specify what additional segments might also be defined for this observation.
		/// </summary>
		public class OM1 {

			 public const string Id = "OM1";

						/// <summary>
			/// OM1.1 - This field contains the first OM1 segment in a message and is described as 1, the second as 2, and so on.
			/// </summary>
			public class SequenceNumberTestObservationMasterFile : HL7Base<SequenceNumberTestObservationMasterFile>
			{

				private const string _id = "OM1.1";
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
			/// OM1.2 - This field contains the observations whose categorical responses are taken from a specified table of codes (e.g., CWE data types).  Record the preferred coding system for this observation (e.g., ICD9, SNOMED III).  Take the codes from ASTM Table 3 or 5, or specify a local code.
			/// </summary>
			public class ProducersServiceTestObservationId : HL7Base<ProducersServiceTestObservationId>
			{

				private const string _id = "OM1.2";
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
				/// OM1.2.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
				/// </summary>
				public class Identifier : HL7Base<Identifier>
				{

					private const string _id = "OM1.2.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.2.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
				/// </summary>
				public class Text : HL7Base<Text>
				{

					private const string _id = "OM1.2.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.2.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
				/// </summary>
				public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
				{

					private const string _id = "OM1.2.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.2.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
				/// </summary>
				public class AlternateIdentifier : HL7Base<AlternateIdentifier>
				{

					private const string _id = "OM1.2.4";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.2.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
				/// </summary>
				public class AlternateText : HL7Base<AlternateText>
				{

					private const string _id = "OM1.2.5";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.2.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
				{

					private const string _id = "OM1.2.6";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.2.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
				/// </summary>
				public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
				{

					private const string _id = "OM1.2.7";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.2.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
				/// </summary>
				public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
				{

					private const string _id = "OM1.2.8";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.2.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
				/// </summary>
				public class OriginalText : HL7Base<OriginalText>
				{

					private const string _id = "OM1.2.9";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.2.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
				/// </summary>
				public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
				{

					private const string _id = "OM1.2.10";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.2.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
				/// </summary>
				public class SecondAlternateText : HL7Base<SecondAlternateText>
				{

					private const string _id = "OM1.2.11";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.2.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
				{

					private const string _id = "OM1.2.12";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.2.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
				/// </summary>
				public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
				{

					private const string _id = "OM1.2.13";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.2.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
				/// </summary>
				public class CodingSystemOid : HL7Base<CodingSystemOid>
				{

					private const string _id = "OM1.2.14";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.2.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class ValueSetOid : HL7Base<ValueSetOid>
				{

					private const string _id = "OM1.2.15";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.2.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
				/// </summary>
				public class ValueSetVersionId : HL7Base<ValueSetVersionId>
				{

					private const string _id = "OM1.2.16";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.2.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
				/// </summary>
				public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
				{

					private const string _id = "OM1.2.17";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.2.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
				{

					private const string _id = "OM1.2.18";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.2.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
				/// </summary>
				public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
				{

					private const string _id = "OM1.2.19";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.2.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
				/// </summary>
				public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
				{

					private const string _id = "OM1.2.20";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.2.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
				{

					private const string _id = "OM1.2.21";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.2.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
				/// </summary>
				public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
				{

					private const string _id = "OM1.2.22";
					public override string Id
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
			/// OM1.3 - This field contains the allowed data type(s) for this observation.  The codes are the same as those listed for OBX (a given observation may, under different circumstances, take on different data types). Indeed, under limited circumstances, an observation can consist of one or more fragments of different data types. When an observation may have more than one data type, e.g., coded (CWE) and numeric (NM) the allowable data types should be separated by repeat delimiters.  Refer to HL7 Table 0125 - Value Type for valid values.
			/// </summary>
			public class PermittedDataTypes : HL7Base<PermittedDataTypes>
			{

				private const string _id = "OM1.3";
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
			/// OM1.4 - When a specimen is required, segment OM4 will usually be included (one per specimen is required).  This field contains a flag indicating whether or not at least one specimen is required for the service/test/observation.  Refer to HL7 Table 0136 - Yes/no Indicator as defined in Chapter 2.
			/// </summary>
			public class SpecimenRequired : HL7Base<SpecimenRequired>
			{

				private const string _id = "OM1.4";
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
			/// OM1.5 - This field uniquely identifies the service producing the observation described in this segment.  Three components should be included an identifying code, the name of the producer, and the identity of the coding system (e.g., 323-5678Acme Special LabMC).  The identity of the coding system will usually be MC (Medicare provider number or HIBCC site codes) in the United States.  Each country may want to specify its preferred coding system and define a coding system ID to identify it.Remember that the magnitude of a treatment or the setting on a machine, such as a ventilator, can be regarded as an observation.  Thus, pharmacy, respiratory care, and nursing may be producers of such observations.
			/// </summary>
			public class ProducerId : HL7Base<ProducerId>
			{

				private const string _id = "OM1.5";
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
				/// OM1.5.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
				/// </summary>
				public class Identifier : HL7Base<Identifier>
				{

					private const string _id = "OM1.5.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.5.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
				/// </summary>
				public class Text : HL7Base<Text>
				{

					private const string _id = "OM1.5.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.5.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
				/// </summary>
				public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
				{

					private const string _id = "OM1.5.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.5.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
				/// </summary>
				public class AlternateIdentifier : HL7Base<AlternateIdentifier>
				{

					private const string _id = "OM1.5.4";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.5.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
				/// </summary>
				public class AlternateText : HL7Base<AlternateText>
				{

					private const string _id = "OM1.5.5";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.5.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
				{

					private const string _id = "OM1.5.6";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.5.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
				/// </summary>
				public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
				{

					private const string _id = "OM1.5.7";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.5.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
				/// </summary>
				public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
				{

					private const string _id = "OM1.5.8";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.5.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
				/// </summary>
				public class OriginalText : HL7Base<OriginalText>
				{

					private const string _id = "OM1.5.9";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.5.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
				/// </summary>
				public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
				{

					private const string _id = "OM1.5.10";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.5.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
				/// </summary>
				public class SecondAlternateText : HL7Base<SecondAlternateText>
				{

					private const string _id = "OM1.5.11";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.5.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
				{

					private const string _id = "OM1.5.12";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.5.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
				/// </summary>
				public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
				{

					private const string _id = "OM1.5.13";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.5.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
				/// </summary>
				public class CodingSystemOid : HL7Base<CodingSystemOid>
				{

					private const string _id = "OM1.5.14";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.5.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class ValueSetOid : HL7Base<ValueSetOid>
				{

					private const string _id = "OM1.5.15";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.5.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
				/// </summary>
				public class ValueSetVersionId : HL7Base<ValueSetVersionId>
				{

					private const string _id = "OM1.5.16";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.5.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
				/// </summary>
				public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
				{

					private const string _id = "OM1.5.17";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.5.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
				{

					private const string _id = "OM1.5.18";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.5.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
				/// </summary>
				public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
				{

					private const string _id = "OM1.5.19";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.5.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
				/// </summary>
				public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
				{

					private const string _id = "OM1.5.20";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.5.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
				{

					private const string _id = "OM1.5.21";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.5.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
				/// </summary>
				public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
				{

					private const string _id = "OM1.5.22";
					public override string Id
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
			/// OM1.6 - This field contains a text description of this observation.
			/// </summary>
			public class ObservationDescription : HL7Base<ObservationDescription>
			{

				private const string _id = "OM1.6";
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
			/// OM1.7 - This field contains all alias codes/identifiers for this observation.  If more than one alias code needs to be specified, multiple three-component, CWE-format entries (code 1name 1code system 1) may be given, separated by repeat delimiters.  An observation may have as many names/codes as are applicable (e.g., ICD9, ACR-NEMA, SNOMED, and READ).  We encourage the inclusion of as many different codes as may apply to assist cross-system mapping of terminology.  All components of each triplet should be non-null (that is, names and coding system IDs within the CWE data type are required in addition to codes).  The source list may be any of those included in ASTM Tables 3 and 5.Because the size (dose) of a treatment can also be an observation, codes that identify treatments (e.g., NDC, ICCS) may also be included in this field.
			/// </summary>
			public class OtherServiceTestObservationIdsForTheObservation : HL7Base<OtherServiceTestObservationIdsForTheObservation>
			{

				private const string _id = "OM1.7";
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
				/// OM1.7.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
				/// </summary>
				public class Identifier : HL7Base<Identifier>
				{

					private const string _id = "OM1.7.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.7.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
				/// </summary>
				public class Text : HL7Base<Text>
				{

					private const string _id = "OM1.7.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.7.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
				/// </summary>
				public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
				{

					private const string _id = "OM1.7.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.7.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
				/// </summary>
				public class AlternateIdentifier : HL7Base<AlternateIdentifier>
				{

					private const string _id = "OM1.7.4";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.7.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
				/// </summary>
				public class AlternateText : HL7Base<AlternateText>
				{

					private const string _id = "OM1.7.5";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.7.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
				{

					private const string _id = "OM1.7.6";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.7.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
				/// </summary>
				public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
				{

					private const string _id = "OM1.7.7";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.7.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
				/// </summary>
				public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
				{

					private const string _id = "OM1.7.8";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.7.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
				/// </summary>
				public class OriginalText : HL7Base<OriginalText>
				{

					private const string _id = "OM1.7.9";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.7.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
				/// </summary>
				public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
				{

					private const string _id = "OM1.7.10";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.7.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
				/// </summary>
				public class SecondAlternateText : HL7Base<SecondAlternateText>
				{

					private const string _id = "OM1.7.11";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.7.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
				{

					private const string _id = "OM1.7.12";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.7.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
				/// </summary>
				public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
				{

					private const string _id = "OM1.7.13";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.7.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
				/// </summary>
				public class CodingSystemOid : HL7Base<CodingSystemOid>
				{

					private const string _id = "OM1.7.14";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.7.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class ValueSetOid : HL7Base<ValueSetOid>
				{

					private const string _id = "OM1.7.15";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.7.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
				/// </summary>
				public class ValueSetVersionId : HL7Base<ValueSetVersionId>
				{

					private const string _id = "OM1.7.16";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.7.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
				/// </summary>
				public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
				{

					private const string _id = "OM1.7.17";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.7.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
				{

					private const string _id = "OM1.7.18";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.7.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
				/// </summary>
				public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
				{

					private const string _id = "OM1.7.19";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.7.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
				/// </summary>
				public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
				{

					private const string _id = "OM1.7.20";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.7.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
				{

					private const string _id = "OM1.7.21";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.7.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
				/// </summary>
				public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
				{

					private const string _id = "OM1.7.22";
					public override string Id
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
			/// OM1.8 - This field contains any test aliases or synonyms for the name in the context of the ordering service.  These are alternative names, not associated with a particular coding system, by which the battery, test, or observation (e.g., measurement, test, diagnostic study, treatment, etc.) is known to users of the system.  Multiple names in this list are separated by repeat delimiters.
			/// </summary>
			public class OtherNames : HL7Base<OtherNames>
			{

				private const string _id = "OM1.8";
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
			/// OM1.9 - This field contains the preferred name for reporting the observation or battery.  The name can contain up to 30 characters (including blanks).  It is the preferred name for columnar reports that require a maximum name size.
			/// </summary>
			public class PreferredReportNameForTheObservation : HL7Base<PreferredReportNameForTheObservation>
			{

				private const string _id = "OM1.9";
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
			/// OM1.10 - This field contains the name that can be used in space-limited reports (e.g., specimen labels) to identify the observation for the convenience of human readers.  The name can contain up to eight characters.
			/// </summary>
			public class PreferredShortNameOrMnemonicForTheObservation : HL7Base<PreferredShortNameOrMnemonicForTheObservation>
			{

				private const string _id = "OM1.10";
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
			/// OM1.11 - This field contains the fully-specified name for the observation or battery.  It may include the full (unabbreviated) multiple-word names and contain up to 200 characters.  It should be as scientifically precise as possible.
			/// </summary>
			public class PreferredLongNameForTheObservation : HL7Base<PreferredLongNameForTheObservation>
			{

				private const string _id = "OM1.11";
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
			/// OM1.12 - For example, blood differential count is usually an orderable "test," MCV, contained within the differential count, is usually not independently orderable.  This field indicates whether or not a service/test/observation is an orderable code.   Refer to HL7 Table 0136 - Yes/no Indicator for valid values.
			/// </summary>
			public class Orderability : HL7Base<Orderability>
			{

				private const string _id = "OM1.12";
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
			/// OM1.13 - When applicable, this field identifies the instrument or device that is used to generate this observation or battery.  Examples are the automated instrument in the laboratory, the imaging device and model number in radiology, and the automatic blood pressure machine on the ward.  The instrument is specified as a coded entry in anticipation that these identifiers could be specified as codes.  Initially, we expect that most of the information about devices will be transmitted as text in the second component of the CWE identifier.  If more than one kind of instrument is used, all of them can be listed, separated by repeat delimiters.
			/// </summary>
			public class IdentityOfInstrumentUsedToPerformThisStudy : HL7Base<IdentityOfInstrumentUsedToPerformThisStudy>
			{

				private const string _id = "OM1.13";
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
				/// OM1.13.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
				/// </summary>
				public class Identifier : HL7Base<Identifier>
				{

					private const string _id = "OM1.13.1";
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
				/// OM1.13.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
				/// </summary>
				public class Text : HL7Base<Text>
				{

					private const string _id = "OM1.13.2";
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
				/// OM1.13.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
				/// </summary>
				public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
				{

					private const string _id = "OM1.13.3";
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
				/// OM1.13.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
				/// </summary>
				public class AlternateIdentifier : HL7Base<AlternateIdentifier>
				{

					private const string _id = "OM1.13.4";
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
				/// OM1.13.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
				/// </summary>
				public class AlternateText : HL7Base<AlternateText>
				{

					private const string _id = "OM1.13.5";
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
				/// OM1.13.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
				{

					private const string _id = "OM1.13.6";
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
				/// OM1.13.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
				/// </summary>
				public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
				{

					private const string _id = "OM1.13.7";
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
				/// OM1.13.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
				/// </summary>
				public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
				{

					private const string _id = "OM1.13.8";
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
				/// OM1.13.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
				/// </summary>
				public class OriginalText : HL7Base<OriginalText>
				{

					private const string _id = "OM1.13.9";
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
				/// OM1.13.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
				/// </summary>
				public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
				{

					private const string _id = "OM1.13.10";
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
				/// OM1.13.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
				/// </summary>
				public class SecondAlternateText : HL7Base<SecondAlternateText>
				{

					private const string _id = "OM1.13.11";
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
				/// OM1.13.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
				{

					private const string _id = "OM1.13.12";
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
				/// OM1.13.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
				/// </summary>
				public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
				{

					private const string _id = "OM1.13.13";
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
				/// OM1.13.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
				/// </summary>
				public class CodingSystemOid : HL7Base<CodingSystemOid>
				{

					private const string _id = "OM1.13.14";
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
				/// OM1.13.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class ValueSetOid : HL7Base<ValueSetOid>
				{

					private const string _id = "OM1.13.15";
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
				/// OM1.13.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
				/// </summary>
				public class ValueSetVersionId : HL7Base<ValueSetVersionId>
				{

					private const string _id = "OM1.13.16";
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
				/// OM1.13.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
				/// </summary>
				public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
				{

					private const string _id = "OM1.13.17";
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
				/// OM1.13.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
				{

					private const string _id = "OM1.13.18";
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
				/// OM1.13.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
				/// </summary>
				public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
				{

					private const string _id = "OM1.13.19";
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
				/// OM1.13.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
				/// </summary>
				public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
				{

					private const string _id = "OM1.13.20";
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
				/// OM1.13.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
				{

					private const string _id = "OM1.13.21";
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
				/// OM1.13.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
				/// </summary>
				public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
				{

					private const string _id = "OM1.13.22";
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
			/// OM1.14 - This field contains the method(s) used to produce the observation and should be recorded in a computer-understandable (coded) form here.  This field should report the same method(s) reported in narrative in the following field.  More than one method may be listed, but only if they produce results that are clinically indistinguishable.  Multiple methods must be separated by repeat delimiters.
			/// </summary>
			public class CodedRepresentationOfMethod : HL7Base<CodedRepresentationOfMethod>
			{

				private const string _id = "OM1.14";
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
				/// OM1.14.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
				/// </summary>
				public class Identifier : HL7Base<Identifier>
				{

					private const string _id = "OM1.14.1";
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
				/// OM1.14.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
				/// </summary>
				public class Text : HL7Base<Text>
				{

					private const string _id = "OM1.14.2";
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
				/// OM1.14.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
				/// </summary>
				public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
				{

					private const string _id = "OM1.14.3";
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
				/// OM1.14.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
				/// </summary>
				public class AlternateIdentifier : HL7Base<AlternateIdentifier>
				{

					private const string _id = "OM1.14.4";
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
				/// OM1.14.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
				/// </summary>
				public class AlternateText : HL7Base<AlternateText>
				{

					private const string _id = "OM1.14.5";
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
				/// OM1.14.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
				{

					private const string _id = "OM1.14.6";
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
				/// OM1.14.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
				/// </summary>
				public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
				{

					private const string _id = "OM1.14.7";
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
				/// OM1.14.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
				/// </summary>
				public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
				{

					private const string _id = "OM1.14.8";
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
				/// OM1.14.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
				/// </summary>
				public class OriginalText : HL7Base<OriginalText>
				{

					private const string _id = "OM1.14.9";
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
				/// OM1.14.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
				/// </summary>
				public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
				{

					private const string _id = "OM1.14.10";
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
				/// OM1.14.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
				/// </summary>
				public class SecondAlternateText : HL7Base<SecondAlternateText>
				{

					private const string _id = "OM1.14.11";
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
				/// OM1.14.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
				{

					private const string _id = "OM1.14.12";
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
				/// OM1.14.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
				/// </summary>
				public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
				{

					private const string _id = "OM1.14.13";
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
				/// OM1.14.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
				/// </summary>
				public class CodingSystemOid : HL7Base<CodingSystemOid>
				{

					private const string _id = "OM1.14.14";
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
				/// OM1.14.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class ValueSetOid : HL7Base<ValueSetOid>
				{

					private const string _id = "OM1.14.15";
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
				/// OM1.14.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
				/// </summary>
				public class ValueSetVersionId : HL7Base<ValueSetVersionId>
				{

					private const string _id = "OM1.14.16";
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
				/// OM1.14.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
				/// </summary>
				public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
				{

					private const string _id = "OM1.14.17";
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
				/// OM1.14.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
				{

					private const string _id = "OM1.14.18";
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
				/// OM1.14.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
				/// </summary>
				public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
				{

					private const string _id = "OM1.14.19";
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
				/// OM1.14.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
				/// </summary>
				public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
				{

					private const string _id = "OM1.14.20";
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
				/// OM1.14.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
				{

					private const string _id = "OM1.14.21";
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
				/// OM1.14.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
				/// </summary>
				public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
				{

					private const string _id = "OM1.14.22";
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
			/// OM1.15 - This field indicates whether or not a portable device may be used for the service/test/observation.  Refer to HL7 Table 0136 - Yes/no Indicator for valid values.
			/// </summary>
			public class PortableDeviceIndicator : HL7Base<PortableDeviceIndicator>
			{

				private const string _id = "OM1.15";
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
			/// OM1.16 - This field permits the sorting of observation orders and values by the providing service's department/section.  It provides "source oriented" reporting when required.  The codes for this field should be taken from ASTM Table 15 (Diagnostic Service Codes).  Free text may be used instead of these codes, but in that case, they should be recorded as the second "component" of the field to distinguish them from the standard codes.  Multiple codes in this field are separated by repeat delimiters.
			/// </summary>
			public class ObservationProducingDepartmentSection : HL7Base<ObservationProducingDepartmentSection>
			{

				private const string _id = "OM1.16";
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
				/// OM1.16.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
				/// </summary>
				public class Identifier : HL7Base<Identifier>
				{

					private const string _id = "OM1.16.1";
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
				/// OM1.16.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
				/// </summary>
				public class Text : HL7Base<Text>
				{

					private const string _id = "OM1.16.2";
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
				/// OM1.16.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
				/// </summary>
				public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
				{

					private const string _id = "OM1.16.3";
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
				/// OM1.16.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
				/// </summary>
				public class AlternateIdentifier : HL7Base<AlternateIdentifier>
				{

					private const string _id = "OM1.16.4";
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
				/// OM1.16.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
				/// </summary>
				public class AlternateText : HL7Base<AlternateText>
				{

					private const string _id = "OM1.16.5";
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
				/// OM1.16.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
				{

					private const string _id = "OM1.16.6";
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
				/// OM1.16.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
				/// </summary>
				public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
				{

					private const string _id = "OM1.16.7";
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
				/// OM1.16.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
				/// </summary>
				public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
				{

					private const string _id = "OM1.16.8";
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
				/// OM1.16.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
				/// </summary>
				public class OriginalText : HL7Base<OriginalText>
				{

					private const string _id = "OM1.16.9";
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
				/// OM1.16.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
				/// </summary>
				public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
				{

					private const string _id = "OM1.16.10";
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
				/// OM1.16.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
				/// </summary>
				public class SecondAlternateText : HL7Base<SecondAlternateText>
				{

					private const string _id = "OM1.16.11";
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
				/// OM1.16.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
				{

					private const string _id = "OM1.16.12";
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
				/// OM1.16.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
				/// </summary>
				public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
				{

					private const string _id = "OM1.16.13";
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
				/// OM1.16.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
				/// </summary>
				public class CodingSystemOid : HL7Base<CodingSystemOid>
				{

					private const string _id = "OM1.16.14";
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
				/// OM1.16.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class ValueSetOid : HL7Base<ValueSetOid>
				{

					private const string _id = "OM1.16.15";
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
				/// OM1.16.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
				/// </summary>
				public class ValueSetVersionId : HL7Base<ValueSetVersionId>
				{

					private const string _id = "OM1.16.16";
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
				/// OM1.16.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
				/// </summary>
				public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
				{

					private const string _id = "OM1.16.17";
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
				/// OM1.16.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
				{

					private const string _id = "OM1.16.18";
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
				/// OM1.16.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
				/// </summary>
				public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
				{

					private const string _id = "OM1.16.19";
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
				/// OM1.16.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
				/// </summary>
				public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
				{

					private const string _id = "OM1.16.20";
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
				/// OM1.16.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
				{

					private const string _id = "OM1.16.21";
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
				/// OM1.16.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
				/// </summary>
				public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
				{

					private const string _id = "OM1.16.22";
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
			/// OM1.17 - This field contains the telephone number for calling responsible parties in this section to ask results or advice about the use of this test.
			/// </summary>
			public class TelephoneNumberOfSection : HL7Base<TelephoneNumberOfSection>
			{

				private const string _id = "OM1.17";
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
				/// OM1.17.1 - Attention The XTN-1 component was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v2.6.
				/// </summary>
				public class TelephoneNumber : HL7Base<TelephoneNumber>
				{

					private const string _id = "OM1.17.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.17.2 - A code that represents a specific use of a telecommunication number. Refer to HL7 Table 0201 - Telecommunication Use Code for valid values. This component along with XTN.3 describes the nature of the telecommunication data that follows. Best practice requires the population of XTN.2 when XTN.4 or XTN.7 is populated. 
				/// </summary>
				public class TelecommunicationUseCode : HL7Base<TelecommunicationUseCode>
				{

					private const string _id = "OM1.17.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.17.3 - A code that represents the type of telecommunication equipment. Refer to HL7 Table 0202 - Telecommunication Equipment Type for valid values. This component along with XTN.2 describes the nature of the telecommunication data that follows and is necessary to accurately interpret it.
				/// </summary>
				public class TelecommunicationEquipmentType : HL7Base<TelecommunicationEquipmentType>
				{

					private const string _id = "OM1.17.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.17.4 - This component is required if, and only allowed if, XTN.7 or XTN.12 are not populated.  Note If any of the HL7 delimiters are found in the Communication Address, such as , the appropriate HL7 escape sequence SHALL be used when encoding an Internet address (see Chapter 2, "Control", section 2.7.1, "Formatting Codes").
				/// </summary>
				public class CommunicationAddress : HL7Base<CommunicationAddress>
				{

					private const string _id = "OM1.17.4";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.17.5 - The numeric code assigned by the International Telecommunication Union in standard E.164 to access telephone services in another country.  For example, "+1" is the country code for the United States, "+49" is the code for Germany.
				/// </summary>
				public class CountryCode : HL7Base<CountryCode>
				{

					private const string _id = "OM1.17.5";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.17.6 - The numeric code to access telephone services in another area/city within a country. This number historically needs not be dialed if the caller is located in the same area/city as the phone number of the called party.The use and size of area/city codes is however country specific some countries do not use area/city codes, or the use of area/city codes may be mandatory when dialing, or area/city codes may be used to group phone numbers based on other criteria than geographic location, such as cell-phone area/city-codes, or free information numbers (e.g., 800 numbers).Most countries have a prefix for Area/City codes which only has to be dialed if one doesn't use a country code. This prefix (mostly "0", sometimes "9") should be omitted from the content of this field. If the prefix for the Area/Code is also mandatory if one uses the country code (e.g., in Italy) then this field should also contain the prefix.
				/// </summary>
				public class AreaCityCode : HL7Base<AreaCityCode>
				{

					private const string _id = "OM1.17.6";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.17.7 - The numeric code used to contact the called party, exclusive of country and area/city codes. The Local Number is required when, and allowed only if, XTN.4 and XTN.12 are not populated. The size of the Local Number is country specific.Note that the Local Number does not include the numeric codes that have to be dialed once a connection has been established. Examples include (automated) organizational phone systems which allow external callers to dial additional numeric codes. These additional numeric codes should be specified as an extension.
				/// </summary>
				public class LocalNumber : HL7Base<LocalNumber>
				{

					private const string _id = "OM1.17.7";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.17.8 - The numeric code to contact the called party used within an organization, e.g., the number used if both caller and called party are located within the same organization. The extension is often the same as the last few digits of the Local Number. The use of extensions is country and site specific, and may depend on the type of phone system (PBX) used by the organization.
				/// </summary>
				public class Extension : HL7Base<Extension>
				{

					private const string _id = "OM1.17.8";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.17.9 - Contains comments with respect to the telephone number.Example Do not use after 5PM
				/// </summary>
				public class AnyText : HL7Base<AnyText>
				{

					private const string _id = "OM1.17.9";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.17.10 - The characters established within a companys internal telephone system network used as a prefix to the Extension component for internal dialing. Note that the use of Extension Prefix requires that the Extension component be valued and that digits, as well as special characters (e.g., *, #) may be used.
				/// </summary>
				public class ExtensionPrefix : HL7Base<ExtensionPrefix>
				{

					private const string _id = "OM1.17.10";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.17.11 - The characters established within a companys internal telephone system used in place of the (external) telephone number to facilitate calling because its length is shorter than that of the telephone number. Note that digits, as well as special characters (e.g., *, #) may be used.
				/// </summary>
				public class SpeedDialCode : HL7Base<SpeedDialCode>
				{

					private const string _id = "OM1.17.11";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.17.12 - An expression of the telephone number as an unparsable string. The Unformatted Telephone number is required when, and allowed only if, XTN.4 and XTN.7 are not populated.The phone number was entered as free text and sending system does not know how to parse it. Example 1-800-Dentist
				/// </summary>
				public class UnformattedTelephoneNumber : HL7Base<UnformattedTelephoneNumber>
				{

					private const string _id = "OM1.17.12";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.17.13 - The first date, if known, on which the telecommunication number is valid and active.
				/// </summary>
				public class EffectiveStartDate : HL7Base<EffectiveStartDate>
				{

					private const string _id = "OM1.17.13";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.17.14 - The last date, if known, on which the telecommunication number is valid and active.
				/// </summary>
				public class ExpirationDate : HL7Base<ExpirationDate>
				{

					private const string _id = "OM1.17.14";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.17.15 - Indicates why this contact number/e-mail was marked as "ended".  Refer to User-defined Table 0868  Telecommunication Expiration Reason for valid values.
				/// </summary>
				public class ExpirationReason : HL7Base<ExpirationReason>
				{

					private const string _id = "OM1.17.15";
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
					/// OM1.17.15.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "OM1.17.15.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.17.15.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "OM1.17.15.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.17.15.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "OM1.17.15.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.17.15.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "OM1.17.15.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.17.15.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "OM1.17.15.5";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.17.15.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "OM1.17.15.6";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.17.15.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "OM1.17.15.7";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.17.15.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "OM1.17.15.8";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.17.15.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "OM1.17.15.9";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.17.15.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "OM1.17.15.10";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.17.15.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "OM1.17.15.11";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.17.15.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "OM1.17.15.12";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.17.15.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "OM1.17.15.13";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.17.15.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "OM1.17.15.14";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.17.15.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "OM1.17.15.15";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.17.15.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "OM1.17.15.16";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.17.15.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "OM1.17.15.17";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.17.15.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "OM1.17.15.18";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.17.15.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "OM1.17.15.19";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.17.15.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "OM1.17.15.20";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.17.15.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "OM1.17.15.21";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.17.15.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "OM1.17.15.22";
						public override string Id
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
				/// OM1.17.16 - Indicates whether this information is considered sensitive or should be protected in some way. Refer to User-defined table 0618 - Protection Code for suggested values.The specific set of codes and appropriate handling of such telecommunications addresses will vary by jurisdiction and is subject to site-specific negotiation. For example, a provider address marked as 'unlisted' might not be printed in an internal address listing.
				/// </summary>
				public class ProtectionCode : HL7Base<ProtectionCode>
				{

					private const string _id = "OM1.17.16";
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
					/// OM1.17.16.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "OM1.17.16.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.17.16.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "OM1.17.16.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.17.16.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "OM1.17.16.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.17.16.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "OM1.17.16.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.17.16.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "OM1.17.16.5";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.17.16.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "OM1.17.16.6";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.17.16.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "OM1.17.16.7";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.17.16.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "OM1.17.16.8";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.17.16.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "OM1.17.16.9";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.17.16.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "OM1.17.16.10";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.17.16.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "OM1.17.16.11";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.17.16.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "OM1.17.16.12";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.17.16.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "OM1.17.16.13";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.17.16.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "OM1.17.16.14";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.17.16.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "OM1.17.16.15";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.17.16.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "OM1.17.16.16";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.17.16.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "OM1.17.16.17";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.17.16.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "OM1.17.16.18";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.17.16.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "OM1.17.16.19";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.17.16.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "OM1.17.16.20";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.17.16.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "OM1.17.16.21";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.17.16.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "OM1.17.16.22";
						public override string Id
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
				/// OM1.17.17 - A unique identifier for the phone number or e-mail address.This component allows a phone number to be uniquely identified, and enables the linking of a single phone number to multiple people and contexts. For example, each member of a family living at the same location would share the same phone number, having the same identifier. A correction to the phone number of one family member could be automatically propagated to other members of the family.HL7 does not assume responsibility for the processing rules for this component.
				/// </summary>
				public class SharedTelecommunicationIdentifier : HL7Base<SharedTelecommunicationIdentifier>
				{

					private const string _id = "OM1.17.17";
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
					/// OM1.17.17.1 - The first component, entity identifier, is usually defined to be unique within the series of identifiers created by the assigning authority, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, "HD - hierarchic designator".
					/// </summary>
					public class EntityIdentifier : HL7Base<EntityIdentifier>
					{

						private const string _id = "OM1.17.17.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.17.17.2 - See Section 2.A.33.1, "Namespace ID (IS)" for definition. The component intentionally remains associated with the IS data type in v 2.7.The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363  Assigning Authority for suggested values.Note When the HD is used as a part of another data type, in this case as part of the EI data type, this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment. By site agreement, implementers may continue to use User-defined Table 0300  Namespace ID for the first component
					/// </summary>
					public class NamespaceId : HL7Base<NamespaceId>
					{

						private const string _id = "OM1.17.17.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.17.17.3 - See Section 2.A.33.2, "Universal ID (ST)" for definition.
					/// </summary>
					public class UniversalId : HL7Base<UniversalId>
					{

						private const string _id = "OM1.17.17.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.17.17.4 - Refer to HL7 Table 0301 - Universal ID Type for valid values. See Section 2.A.33.3, "Universal ID Type (ID)," for definition.
					/// </summary>
					public class UniversalIdType : HL7Base<UniversalIdType>
					{

						private const string _id = "OM1.17.17.4";
						public override string Id
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
				/// OM1.17.18 - For an entity having multiple telecommunication addresses, indicates which is the "most preferred" (lowest number) to "least preferred" (highest number).If the preference order is unique across all usages for a given type, then it indicates the preference across all usages, (e.g. first try my home number, then my business number). If the preference order is unique across all usages and types, then it indicates the preference across all types of telecommunication addresses.  (E.g., first try my phone if that doesn't work, use my pager.) Otherwise, the preference order is assumed to only apply within a specific type and usage.Preference order numbers need not be sequential (i.e., three numbers with the priority orders of 0, 5 and 15 are legitimate).  The preference order numbers must be non-negative.
				/// </summary>
				public class PreferenceOrder : HL7Base<PreferenceOrder>
				{

					private const string _id = "OM1.17.18";
					public override string Id
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
			/// OM1.18 - This field indicates whether the definition entry identifies a test battery, an entire functional procedure or study, a single test value (observation), multiple test batteries or functional procedures as an orderable unit (profile), or a single test value (observation) calculated from other independent observations.  Refer to User-defined Table 0174 - Nature of Service/Test/Observation for suggested values.
			/// </summary>
			public class NatureOfServiceTestObservation : HL7Base<NatureOfServiceTestObservation>
			{

				private const string _id = "OM1.18";
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
				/// OM1.18.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
				/// </summary>
				public class Identifier : HL7Base<Identifier>
				{

					private const string _id = "OM1.18.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.18.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
				/// </summary>
				public class Text : HL7Base<Text>
				{

					private const string _id = "OM1.18.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.18.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
				/// </summary>
				public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
				{

					private const string _id = "OM1.18.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.18.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
				/// </summary>
				public class AlternateIdentifier : HL7Base<AlternateIdentifier>
				{

					private const string _id = "OM1.18.4";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.18.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
				/// </summary>
				public class AlternateText : HL7Base<AlternateText>
				{

					private const string _id = "OM1.18.5";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.18.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
				{

					private const string _id = "OM1.18.6";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.18.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
				/// </summary>
				public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
				{

					private const string _id = "OM1.18.7";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.18.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
				/// </summary>
				public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
				{

					private const string _id = "OM1.18.8";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.18.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
				/// </summary>
				public class OriginalText : HL7Base<OriginalText>
				{

					private const string _id = "OM1.18.9";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.18.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
				/// </summary>
				public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
				{

					private const string _id = "OM1.18.10";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.18.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
				/// </summary>
				public class SecondAlternateText : HL7Base<SecondAlternateText>
				{

					private const string _id = "OM1.18.11";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.18.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
				{

					private const string _id = "OM1.18.12";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.18.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
				/// </summary>
				public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
				{

					private const string _id = "OM1.18.13";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.18.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
				/// </summary>
				public class CodingSystemOid : HL7Base<CodingSystemOid>
				{

					private const string _id = "OM1.18.14";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.18.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class ValueSetOid : HL7Base<ValueSetOid>
				{

					private const string _id = "OM1.18.15";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.18.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
				/// </summary>
				public class ValueSetVersionId : HL7Base<ValueSetVersionId>
				{

					private const string _id = "OM1.18.16";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.18.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
				/// </summary>
				public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
				{

					private const string _id = "OM1.18.17";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.18.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
				{

					private const string _id = "OM1.18.18";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.18.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
				/// </summary>
				public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
				{

					private const string _id = "OM1.18.19";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.18.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
				/// </summary>
				public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
				{

					private const string _id = "OM1.18.20";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.18.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
				{

					private const string _id = "OM1.18.21";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.18.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
				/// </summary>
				public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
				{

					private const string _id = "OM1.18.22";
					public override string Id
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
			/// OM1.19 - This field contains an optional string that defines the preferred header under which this observation should be listed on a standard display.  For example, if the test is hemoglobin, this string might be "Complete blood count."  It is represented as a coded data type so that a battery can be a header.  Only the description part of the string may be included in case the subheader does not have an associated code.  When a series of observations is displayed according to the sort order given below, the subheader that groups those observations is presented whenever the subheader changes.
			/// </summary>
			public class ReportSubheader : HL7Base<ReportSubheader>
			{

				private const string _id = "OM1.19";
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
				/// OM1.19.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
				/// </summary>
				public class Identifier : HL7Base<Identifier>
				{

					private const string _id = "OM1.19.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.19.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
				/// </summary>
				public class Text : HL7Base<Text>
				{

					private const string _id = "OM1.19.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.19.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
				/// </summary>
				public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
				{

					private const string _id = "OM1.19.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.19.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
				/// </summary>
				public class AlternateIdentifier : HL7Base<AlternateIdentifier>
				{

					private const string _id = "OM1.19.4";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.19.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
				/// </summary>
				public class AlternateText : HL7Base<AlternateText>
				{

					private const string _id = "OM1.19.5";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.19.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
				{

					private const string _id = "OM1.19.6";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.19.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
				/// </summary>
				public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
				{

					private const string _id = "OM1.19.7";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.19.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
				/// </summary>
				public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
				{

					private const string _id = "OM1.19.8";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.19.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
				/// </summary>
				public class OriginalText : HL7Base<OriginalText>
				{

					private const string _id = "OM1.19.9";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.19.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
				/// </summary>
				public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
				{

					private const string _id = "OM1.19.10";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.19.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
				/// </summary>
				public class SecondAlternateText : HL7Base<SecondAlternateText>
				{

					private const string _id = "OM1.19.11";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.19.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
				{

					private const string _id = "OM1.19.12";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.19.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
				/// </summary>
				public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
				{

					private const string _id = "OM1.19.13";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.19.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
				/// </summary>
				public class CodingSystemOid : HL7Base<CodingSystemOid>
				{

					private const string _id = "OM1.19.14";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.19.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class ValueSetOid : HL7Base<ValueSetOid>
				{

					private const string _id = "OM1.19.15";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.19.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
				/// </summary>
				public class ValueSetVersionId : HL7Base<ValueSetVersionId>
				{

					private const string _id = "OM1.19.16";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.19.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
				/// </summary>
				public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
				{

					private const string _id = "OM1.19.17";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.19.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
				{

					private const string _id = "OM1.19.18";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.19.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
				/// </summary>
				public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
				{

					private const string _id = "OM1.19.19";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.19.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
				/// </summary>
				public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
				{

					private const string _id = "OM1.19.20";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.19.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
				{

					private const string _id = "OM1.19.21";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.19.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
				/// </summary>
				public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
				{

					private const string _id = "OM1.19.22";
					public override string Id
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
			/// OM1.20 - This field contains an optional string that defines the sort order in which this observation is presented in a standard report or display that contains the many observations.
			/// </summary>
			public class ReportDisplayOrder : HL7Base<ReportDisplayOrder>
			{

				private const string _id = "OM1.20";
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
			/// OM1.21 - This field contains the date and time that the last of any field change was made and in the host's record corresponding to the OM1 segment.
			/// </summary>
			public class DateTimeStampForAnyChangeInDefinitionForTheObservation : HL7Base<DateTimeStampForAnyChangeInDefinitionForTheObservation>
			{

				private const string _id = "OM1.21";
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
			/// OM1.22 - This field contains the date and time of the last change in the test procedure that would make previous results incompatible with new results, e.g., the last time that normal reference range or units changed for a numeric test/observation.We strongly suggest that observation producers never use the same observation ID when the measurement procedures change in such a way that results produced under the new procedure are clinically different from those produced with the old procedure. Rather, the producer should try to adjust the new procedure so that its values are clinically indistinguishable from the old. Failing that, one should create a new observation ID for the observation produced under the new procedure.In the rare circumstances when a procedure change occurs and neither of the above two options is viable, this field shall be used to transmit the effective date/time of the new procedure. The receiving system shall assume that any values that come across under this observation ID are under the new procedure after this date and take appropriate steps to distinguish the old from the new observations.
			/// </summary>
			public class EffectiveDateTimeOfChange : HL7Base<EffectiveDateTimeOfChange>
			{

				private const string _id = "OM1.22";
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
			/// OM1.23 - This field contains the typical processing time for single test/observation.  This field indicates the time from the delivery of a specimen or transport of a patient to a diagnostic service and the completion of the study.  It includes the usual waiting time.  The units are measured in minutes.
			/// </summary>
			public class TypicalTurnaroundTime : HL7Base<TypicalTurnaroundTime>
			{

				private const string _id = "OM1.23";
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
			/// OM1.24 - This field contains the usual length of time (in minutes) between the start of a test process and its completion.
			/// </summary>
			public class ProcessingTime : HL7Base<ProcessingTime>
			{

				private const string _id = "OM1.24";
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
			/// OM1.25 - This field contains one or more available priorities for performing the observation or test.  This is the priority that can be placed in TQ1-9 - Priority.  Multiple priorities may be given, separated by repeat delimiters.  For example, SARPT indicates that the test may be ordered using codes S, A, R, P, or T.  Refer to HL7 Table 0168 - Processing Priority in Chapter 2C, Code Tables, for valid values.For tests requiring a specimen, the priority for obtaining the specimen is included in OM4-13 - Specimen Priorities.
			/// </summary>
			public class ProcessingPriority : HL7Base<ProcessingPriority>
			{

				private const string _id = "OM1.25";
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
			/// OM1.26 - This field contains the available priorities reporting the test results when the user is asked to specify the reporting priority independent of the processing priority.  Refer to HL7 Table 0169 - Reporting Priority for valid values.
			/// </summary>
			public class ReportingPriority : HL7Base<ReportingPriority>
			{

				private const string _id = "OM1.26";
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
			/// OM1.27 - This field contains the identification(s) of the outside service(s) that produce(s) the observation.  The format of this CWE field uses the producer ID (as defined in OM1-5 - Producer ID) and the name of the service separated by component delimiters.  An example is ...39221ACME labMC...  If multiple services are used, they should be separated by repeat delimiter(s).
			/// </summary>
			public class OutsideSitesWhereObservationMayBePerformed : HL7Base<OutsideSitesWhereObservationMayBePerformed>
			{

				private const string _id = "OM1.27";
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
				/// OM1.27.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
				/// </summary>
				public class Identifier : HL7Base<Identifier>
				{

					private const string _id = "OM1.27.1";
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
				/// OM1.27.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
				/// </summary>
				public class Text : HL7Base<Text>
				{

					private const string _id = "OM1.27.2";
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
				/// OM1.27.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
				/// </summary>
				public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
				{

					private const string _id = "OM1.27.3";
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
				/// OM1.27.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
				/// </summary>
				public class AlternateIdentifier : HL7Base<AlternateIdentifier>
				{

					private const string _id = "OM1.27.4";
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
				/// OM1.27.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
				/// </summary>
				public class AlternateText : HL7Base<AlternateText>
				{

					private const string _id = "OM1.27.5";
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
				/// OM1.27.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
				{

					private const string _id = "OM1.27.6";
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
				/// OM1.27.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
				/// </summary>
				public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
				{

					private const string _id = "OM1.27.7";
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
				/// OM1.27.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
				/// </summary>
				public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
				{

					private const string _id = "OM1.27.8";
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
				/// OM1.27.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
				/// </summary>
				public class OriginalText : HL7Base<OriginalText>
				{

					private const string _id = "OM1.27.9";
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
				/// OM1.27.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
				/// </summary>
				public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
				{

					private const string _id = "OM1.27.10";
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
				/// OM1.27.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
				/// </summary>
				public class SecondAlternateText : HL7Base<SecondAlternateText>
				{

					private const string _id = "OM1.27.11";
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
				/// OM1.27.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
				{

					private const string _id = "OM1.27.12";
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
				/// OM1.27.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
				/// </summary>
				public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
				{

					private const string _id = "OM1.27.13";
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
				/// OM1.27.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
				/// </summary>
				public class CodingSystemOid : HL7Base<CodingSystemOid>
				{

					private const string _id = "OM1.27.14";
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
				/// OM1.27.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class ValueSetOid : HL7Base<ValueSetOid>
				{

					private const string _id = "OM1.27.15";
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
				/// OM1.27.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
				/// </summary>
				public class ValueSetVersionId : HL7Base<ValueSetVersionId>
				{

					private const string _id = "OM1.27.16";
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
				/// OM1.27.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
				/// </summary>
				public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
				{

					private const string _id = "OM1.27.17";
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
				/// OM1.27.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
				{

					private const string _id = "OM1.27.18";
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
				/// OM1.27.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
				/// </summary>
				public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
				{

					private const string _id = "OM1.27.19";
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
				/// OM1.27.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
				/// </summary>
				public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
				{

					private const string _id = "OM1.27.20";
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
				/// OM1.27.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
				{

					private const string _id = "OM1.27.21";
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
				/// OM1.27.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
				/// </summary>
				public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
				{

					private const string _id = "OM1.27.22";
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
			/// OM1.28 - This field contains the address of the outside services listed in OM1-28 - Address of Outside Site(s) where observation may be performed.  If multiple services are recorded in that field, their addresses should be separated by repeat delimiters, and the addresses should appear in the same order in which the services appear in the preceding field.
			/// </summary>
			public class AddressOfOutsideSites : HL7Base<AddressOfOutsideSites>
			{

				private const string _id = "OM1.28";
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
				/// OM1.28.1 - This component contains the house number, apartment number, street name, street direction, P.O. Box number, and similar address information. 
				/// </summary>
				public class StreetAddress : HL7Base<StreetAddress>
				{

					private const string _id = "OM1.28.1";
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
					/// OM1.28.1.1 - This component specifies the street or mailing address of a person or institution. When referencing an institution, this first component is used to specify the institution name. When used in connection with a person, this component specifies the first line of the address.
					/// </summary>
					public class StreetOrMailingAddress : HL7Base<StreetOrMailingAddress>
					{

						private const string _id = "OM1.28.1.1";
						public override string Id
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
					/// OM1.28.1.2 - 
					/// </summary>
					public class StreetName : HL7Base<StreetName>
					{

						private const string _id = "OM1.28.1.2";
						public override string Id
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
					/// OM1.28.1.3 - 
					/// </summary>
					public class DwellingNumber : HL7Base<DwellingNumber>
					{

						private const string _id = "OM1.28.1.3";
						public override string Id
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
				/// OM1.28.2 - This component contains the second line of address. In US usage, it qualifies address. Examples Suite 555 or Fourth Floor. When referencing an institution, this component specifies the street address.
				/// </summary>
				public class OtherDesignation : HL7Base<OtherDesignation>
				{

					private const string _id = "OM1.28.2";
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
				/// OM1.28.3 - This component specifies the city, or district or place where the addressee is located depending upon the national convention for formatting addresses for postal usage.
				/// </summary>
				public class City : HL7Base<City>
				{

					private const string _id = "OM1.28.3";
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
				/// OM1.28.4 - This component specifies the state or province where the addressee is located. State or province should be represented by the official postal service codes for that country.
				/// </summary>
				public class StateOrProvince : HL7Base<StateOrProvince>
				{

					private const string _id = "OM1.28.4";
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
				/// OM1.28.5 - This component specifies the zip or postal code where the addressee is located. Zip or postal codes should be represented by the official codes for that country. In the US, the zip code takes the form 99999-9999, while the Canadian postal code takes the form A9A9A9, and the Australian Postcode takes the form 9999.
				/// </summary>
				public class ZipOrPostalCode : HL7Base<ZipOrPostalCode>
				{

					private const string _id = "OM1.28.5";
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
				/// OM1.28.6 - This component specifies the country where the addressee is located.  HL7 specifies that the 3-character (alphabetic) form of ISO 3166 be used for the country code. Refer to HL7 Table 0399  Country Code for valid values.
				/// </summary>
				public class Country : HL7Base<Country>
				{

					private const string _id = "OM1.28.6";
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
				/// OM1.28.7 - This component specifies the kind or type of address. Refer to HL7 Table 0190 - Address Type for valid values.XAD.7 is required if there are multiple occurrences of XAD in a field.
				/// </summary>
				public class AddressType : HL7Base<AddressType>
				{

					private const string _id = "OM1.28.7";
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
				/// OM1.28.8 - This component specifies any other geographic designation. It includes county, bioregion, SMSA, etc.
				/// </summary>
				public class OtherGeographicDesignation : HL7Base<OtherGeographicDesignation>
				{

					private const string _id = "OM1.28.8";
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
				/// OM1.28.9 - A code that represents the county in which the specified address resides. User-defined Table 0289 - County/parish is used as the HL7 identifier for the user-defined table of values for this component. When this component is used to represent the county (or parish), component 8 other geographic designation should not duplicate it (i.e., the use of other geographic designation to represent the county is allowed only for the purpose of backward compatibility, and should be discouraged in this and future versions of HL7).Allowable values codes defined by government.
				/// </summary>
				public class CountyParishCode : HL7Base<CountyParishCode>
				{

					private const string _id = "OM1.28.9";
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
					/// OM1.28.9.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "OM1.28.9.1";
						public override string Id
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
					/// OM1.28.9.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "OM1.28.9.2";
						public override string Id
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
					/// OM1.28.9.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "OM1.28.9.3";
						public override string Id
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
					/// OM1.28.9.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "OM1.28.9.4";
						public override string Id
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
					/// OM1.28.9.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "OM1.28.9.5";
						public override string Id
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
					/// OM1.28.9.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "OM1.28.9.6";
						public override string Id
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
					/// OM1.28.9.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "OM1.28.9.7";
						public override string Id
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
					/// OM1.28.9.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "OM1.28.9.8";
						public override string Id
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
					/// OM1.28.9.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "OM1.28.9.9";
						public override string Id
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
					/// OM1.28.9.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "OM1.28.9.10";
						public override string Id
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
					/// OM1.28.9.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "OM1.28.9.11";
						public override string Id
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
					/// OM1.28.9.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "OM1.28.9.12";
						public override string Id
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
					/// OM1.28.9.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "OM1.28.9.13";
						public override string Id
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
					/// OM1.28.9.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "OM1.28.9.14";
						public override string Id
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
					/// OM1.28.9.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "OM1.28.9.15";
						public override string Id
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
					/// OM1.28.9.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "OM1.28.9.16";
						public override string Id
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
					/// OM1.28.9.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "OM1.28.9.17";
						public override string Id
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
					/// OM1.28.9.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "OM1.28.9.18";
						public override string Id
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
					/// OM1.28.9.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "OM1.28.9.19";
						public override string Id
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
					/// OM1.28.9.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "OM1.28.9.20";
						public override string Id
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
					/// OM1.28.9.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "OM1.28.9.21";
						public override string Id
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
					/// OM1.28.9.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "OM1.28.9.22";
						public override string Id
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
				/// OM1.28.10 - A code that represents the census tract in which the specified address resides. User-defined Table 0288 - Census Tract is used as the HL7 identifier for the user-defined table of values for this component.Allowable Values codes defined by government.
				/// </summary>
				public class CensusTract : HL7Base<CensusTract>
				{

					private const string _id = "OM1.28.10";
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
					/// OM1.28.10.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "OM1.28.10.1";
						public override string Id
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
					/// OM1.28.10.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "OM1.28.10.2";
						public override string Id
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
					/// OM1.28.10.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "OM1.28.10.3";
						public override string Id
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
					/// OM1.28.10.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "OM1.28.10.4";
						public override string Id
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
					/// OM1.28.10.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "OM1.28.10.5";
						public override string Id
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
					/// OM1.28.10.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "OM1.28.10.6";
						public override string Id
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
					/// OM1.28.10.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "OM1.28.10.7";
						public override string Id
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
					/// OM1.28.10.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "OM1.28.10.8";
						public override string Id
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
					/// OM1.28.10.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "OM1.28.10.9";
						public override string Id
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
					/// OM1.28.10.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "OM1.28.10.10";
						public override string Id
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
					/// OM1.28.10.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "OM1.28.10.11";
						public override string Id
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
					/// OM1.28.10.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "OM1.28.10.12";
						public override string Id
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
					/// OM1.28.10.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "OM1.28.10.13";
						public override string Id
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
					/// OM1.28.10.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "OM1.28.10.14";
						public override string Id
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
					/// OM1.28.10.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "OM1.28.10.15";
						public override string Id
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
					/// OM1.28.10.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "OM1.28.10.16";
						public override string Id
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
					/// OM1.28.10.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "OM1.28.10.17";
						public override string Id
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
					/// OM1.28.10.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "OM1.28.10.18";
						public override string Id
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
					/// OM1.28.10.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "OM1.28.10.19";
						public override string Id
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
					/// OM1.28.10.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "OM1.28.10.20";
						public override string Id
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
					/// OM1.28.10.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "OM1.28.10.21";
						public override string Id
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
					/// OM1.28.10.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "OM1.28.10.22";
						public override string Id
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
				/// OM1.28.11 - Different name/address types and representations of the same name/address should be described by repeating of this field, with different values of the name/address type and/or name/address representation component.Note Also note that this new component remains in "alphabetic" representation with each repetition of the fields using these data types. I.e. even though the address may be represented in an ideographic character set, this component will remain represented in an alphabetic character set.Refer to HL7 Table 0465  Name/address Representation for valid values.In general this component provides an indication of the representation provided by the data item. It does not necessarily specify the character sets used. Thus, even though the representation might provide an indication of what to expect, the sender is still free to encode the contents using whatever character set is desired. This component provides only hints for the receiver, so it can make choices regarding what it has been sent and what it is capable of displaying.
				/// </summary>
				public class AddressRepresentationCode : HL7Base<AddressRepresentationCode>
				{

					private const string _id = "OM1.28.11";
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
				/// OM1.28.12 - Attention The XAD.12 component was retained for backward compatibility as of v2.5 and the detail was withdrawn and removed from the standard as of v2.7. Refer to 2.A.86.13, "Effective Date (DTM)" and 2.A.86.14, "Expiration Date (DTM)" components.
				/// </summary>
				public class AddressValidityRange : HL7Base<AddressValidityRange>
				{

					private const string _id = "OM1.28.12";
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
				/// OM1.28.13 - The first date, if known, on which the address is valid and active for the owning entity.
				/// </summary>
				public class EffectiveDate : HL7Base<EffectiveDate>
				{

					private const string _id = "OM1.28.13";
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
				/// OM1.28.14 - The last date, if known, on which the address is valid and active for the owning entity.
				/// </summary>
				public class ExpirationDate : HL7Base<ExpirationDate>
				{

					private const string _id = "OM1.28.14";
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
				/// OM1.28.15 - This identifies why this address was marked as "ended".   Refer to User-defined Table 0616  Address Expiration Reason for valid values.
				/// </summary>
				public class ExpirationReason : HL7Base<ExpirationReason>
				{

					private const string _id = "OM1.28.15";
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
					/// OM1.28.15.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "OM1.28.15.1";
						public override string Id
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
					/// OM1.28.15.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "OM1.28.15.2";
						public override string Id
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
					/// OM1.28.15.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "OM1.28.15.3";
						public override string Id
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
					/// OM1.28.15.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "OM1.28.15.4";
						public override string Id
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
					/// OM1.28.15.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "OM1.28.15.5";
						public override string Id
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
					/// OM1.28.15.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "OM1.28.15.6";
						public override string Id
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
					/// OM1.28.15.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "OM1.28.15.7";
						public override string Id
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
					/// OM1.28.15.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "OM1.28.15.8";
						public override string Id
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
					/// OM1.28.15.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "OM1.28.15.9";
						public override string Id
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
					/// OM1.28.15.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "OM1.28.15.10";
						public override string Id
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
					/// OM1.28.15.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "OM1.28.15.11";
						public override string Id
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
					/// OM1.28.15.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "OM1.28.15.12";
						public override string Id
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
					/// OM1.28.15.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "OM1.28.15.13";
						public override string Id
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
					/// OM1.28.15.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "OM1.28.15.14";
						public override string Id
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
					/// OM1.28.15.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "OM1.28.15.15";
						public override string Id
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
					/// OM1.28.15.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "OM1.28.15.16";
						public override string Id
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
					/// OM1.28.15.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "OM1.28.15.17";
						public override string Id
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
					/// OM1.28.15.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "OM1.28.15.18";
						public override string Id
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
					/// OM1.28.15.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "OM1.28.15.19";
						public override string Id
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
					/// OM1.28.15.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "OM1.28.15.20";
						public override string Id
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
					/// OM1.28.15.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "OM1.28.15.21";
						public override string Id
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
					/// OM1.28.15.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "OM1.28.15.22";
						public override string Id
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
				/// OM1.28.16 - If "Y" this indicates that the address is considered temporary.  Refer to HL7 Table 0136  Yes/No Indicator.
				/// </summary>
				public class TemporaryIndicator : HL7Base<TemporaryIndicator>
				{

					private const string _id = "OM1.28.16";
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
				/// OM1.28.17 - If "Y", this indicates that it is not possible to contact the "owning" entity at this address. Refer to HL7 Table 0136  Yes/No Indicator.
				/// </summary>
				public class BadAddressIndicator : HL7Base<BadAddressIndicator>
				{

					private const string _id = "OM1.28.17";
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
				/// OM1.28.18 - This indicates how the address is intended to be used.  Refer to User-defined Table 0617  Address Usage for valid values.
				/// </summary>
				public class AddressUsage : HL7Base<AddressUsage>
				{

					private const string _id = "OM1.28.18";
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
				/// OM1.28.19 - Identifies the name of the person or organization that should appear as part of the address. This is also known as the "Care of" or "C/O" line.
				/// </summary>
				public class Addressee : HL7Base<Addressee>
				{

					private const string _id = "OM1.28.19";
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
				/// OM1.28.20 - Descriptive information about the use of the address.Example "Do not ring bell."
				/// </summary>
				public class Comment : HL7Base<Comment>
				{

					private const string _id = "OM1.28.20";
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
				/// OM1.28.21 - For an entity having multiple addresses, indicates which is the 'most preferred' (lowest number) to 'least preferred' (highest number).If the preference order is unique across all usages for a given type, then it indicates the preference across all usages, (e.g., first try my home address, then my business address). Otherwise, the preference order is assumed to only apply within a specific usage.Preference order numbers need not be sequential (i.e., four addresses with the priority orders of 10, 1, 5 and 15 are legitimate). The preference order numbers must be non-negative.
				/// </summary>
				public class PreferenceOrder : HL7Base<PreferenceOrder>
				{

					private const string _id = "OM1.28.21";
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
				/// OM1.28.22 - Identifies that an address needs to be treated with special care or sensitivity.The specific set of codes and appropriate handling of such addresses will vary by jurisdiction and is subject to site-specific negotiation. For example, a provider address marked as 'unlisted' might not be printed in an internal address listing.  Refer to User-defined Table 0618  Protection Code for valid values.
				/// </summary>
				public class ProtectionCode : HL7Base<ProtectionCode>
				{

					private const string _id = "OM1.28.22";
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
					/// OM1.28.22.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "OM1.28.22.1";
						public override string Id
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
					/// OM1.28.22.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "OM1.28.22.2";
						public override string Id
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
					/// OM1.28.22.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "OM1.28.22.3";
						public override string Id
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
					/// OM1.28.22.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "OM1.28.22.4";
						public override string Id
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
					/// OM1.28.22.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "OM1.28.22.5";
						public override string Id
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
					/// OM1.28.22.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "OM1.28.22.6";
						public override string Id
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
					/// OM1.28.22.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "OM1.28.22.7";
						public override string Id
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
					/// OM1.28.22.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "OM1.28.22.8";
						public override string Id
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
					/// OM1.28.22.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "OM1.28.22.9";
						public override string Id
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
					/// OM1.28.22.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "OM1.28.22.10";
						public override string Id
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
					/// OM1.28.22.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "OM1.28.22.11";
						public override string Id
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
					/// OM1.28.22.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "OM1.28.22.12";
						public override string Id
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
					/// OM1.28.22.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "OM1.28.22.13";
						public override string Id
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
					/// OM1.28.22.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "OM1.28.22.14";
						public override string Id
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
					/// OM1.28.22.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "OM1.28.22.15";
						public override string Id
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
					/// OM1.28.22.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "OM1.28.22.16";
						public override string Id
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
					/// OM1.28.22.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "OM1.28.22.17";
						public override string Id
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
					/// OM1.28.22.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "OM1.28.22.18";
						public override string Id
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
					/// OM1.28.22.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "OM1.28.22.19";
						public override string Id
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
					/// OM1.28.22.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "OM1.28.22.20";
						public override string Id
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
					/// OM1.28.22.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "OM1.28.22.21";
						public override string Id
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
					/// OM1.28.22.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "OM1.28.22.22";
						public override string Id
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
				/// OM1.28.23 - A unique identifier for the address.This component allows an address to be uniquely identified, and enables the linking of a single address to multiple people and contexts. For example, each member of a family living at the same location would share the same address, having the same identifier. A correction to the address of one family member could be automatically propagated to other members of the family.
				/// </summary>
				public class AddressIdentifier : HL7Base<AddressIdentifier>
				{

					private const string _id = "OM1.28.23";
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
					/// OM1.28.23.1 - The first component, entity identifier, is usually defined to be unique within the series of identifiers created by the assigning authority, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, "HD - hierarchic designator".
					/// </summary>
					public class EntityIdentifier : HL7Base<EntityIdentifier>
					{

						private const string _id = "OM1.28.23.1";
						public override string Id
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
					/// OM1.28.23.2 - See Section 2.A.33.1, "Namespace ID (IS)" for definition. The component intentionally remains associated with the IS data type in v 2.7.The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363  Assigning Authority for suggested values.Note When the HD is used as a part of another data type, in this case as part of the EI data type, this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment. By site agreement, implementers may continue to use User-defined Table 0300  Namespace ID for the first component
					/// </summary>
					public class NamespaceId : HL7Base<NamespaceId>
					{

						private const string _id = "OM1.28.23.2";
						public override string Id
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
					/// OM1.28.23.3 - See Section 2.A.33.2, "Universal ID (ST)" for definition.
					/// </summary>
					public class UniversalId : HL7Base<UniversalId>
					{

						private const string _id = "OM1.28.23.3";
						public override string Id
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
					/// OM1.28.23.4 - Refer to HL7 Table 0301 - Universal ID Type for valid values. See Section 2.A.33.3, "Universal ID Type (ID)," for definition.
					/// </summary>
					public class UniversalIdType : HL7Base<UniversalIdType>
					{

						private const string _id = "OM1.28.23.4";
						public override string Id
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
			/// OM1.29 - This field contains the telephone number of the outside site.
			/// </summary>
			public class PhoneNumberOfOutsideSite : HL7Base<PhoneNumberOfOutsideSite>
			{

				private const string _id = "OM1.29";
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
				/// OM1.29.1 - Attention The XTN-1 component was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v2.6.
				/// </summary>
				public class TelephoneNumber : HL7Base<TelephoneNumber>
				{

					private const string _id = "OM1.29.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.29.2 - A code that represents a specific use of a telecommunication number. Refer to HL7 Table 0201 - Telecommunication Use Code for valid values. This component along with XTN.3 describes the nature of the telecommunication data that follows. Best practice requires the population of XTN.2 when XTN.4 or XTN.7 is populated. 
				/// </summary>
				public class TelecommunicationUseCode : HL7Base<TelecommunicationUseCode>
				{

					private const string _id = "OM1.29.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.29.3 - A code that represents the type of telecommunication equipment. Refer to HL7 Table 0202 - Telecommunication Equipment Type for valid values. This component along with XTN.2 describes the nature of the telecommunication data that follows and is necessary to accurately interpret it.
				/// </summary>
				public class TelecommunicationEquipmentType : HL7Base<TelecommunicationEquipmentType>
				{

					private const string _id = "OM1.29.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.29.4 - This component is required if, and only allowed if, XTN.7 or XTN.12 are not populated.  Note If any of the HL7 delimiters are found in the Communication Address, such as , the appropriate HL7 escape sequence SHALL be used when encoding an Internet address (see Chapter 2, "Control", section 2.7.1, "Formatting Codes").
				/// </summary>
				public class CommunicationAddress : HL7Base<CommunicationAddress>
				{

					private const string _id = "OM1.29.4";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.29.5 - The numeric code assigned by the International Telecommunication Union in standard E.164 to access telephone services in another country.  For example, "+1" is the country code for the United States, "+49" is the code for Germany.
				/// </summary>
				public class CountryCode : HL7Base<CountryCode>
				{

					private const string _id = "OM1.29.5";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.29.6 - The numeric code to access telephone services in another area/city within a country. This number historically needs not be dialed if the caller is located in the same area/city as the phone number of the called party.The use and size of area/city codes is however country specific some countries do not use area/city codes, or the use of area/city codes may be mandatory when dialing, or area/city codes may be used to group phone numbers based on other criteria than geographic location, such as cell-phone area/city-codes, or free information numbers (e.g., 800 numbers).Most countries have a prefix for Area/City codes which only has to be dialed if one doesn't use a country code. This prefix (mostly "0", sometimes "9") should be omitted from the content of this field. If the prefix for the Area/Code is also mandatory if one uses the country code (e.g., in Italy) then this field should also contain the prefix.
				/// </summary>
				public class AreaCityCode : HL7Base<AreaCityCode>
				{

					private const string _id = "OM1.29.6";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.29.7 - The numeric code used to contact the called party, exclusive of country and area/city codes. The Local Number is required when, and allowed only if, XTN.4 and XTN.12 are not populated. The size of the Local Number is country specific.Note that the Local Number does not include the numeric codes that have to be dialed once a connection has been established. Examples include (automated) organizational phone systems which allow external callers to dial additional numeric codes. These additional numeric codes should be specified as an extension.
				/// </summary>
				public class LocalNumber : HL7Base<LocalNumber>
				{

					private const string _id = "OM1.29.7";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.29.8 - The numeric code to contact the called party used within an organization, e.g., the number used if both caller and called party are located within the same organization. The extension is often the same as the last few digits of the Local Number. The use of extensions is country and site specific, and may depend on the type of phone system (PBX) used by the organization.
				/// </summary>
				public class Extension : HL7Base<Extension>
				{

					private const string _id = "OM1.29.8";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.29.9 - Contains comments with respect to the telephone number.Example Do not use after 5PM
				/// </summary>
				public class AnyText : HL7Base<AnyText>
				{

					private const string _id = "OM1.29.9";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.29.10 - The characters established within a companys internal telephone system network used as a prefix to the Extension component for internal dialing. Note that the use of Extension Prefix requires that the Extension component be valued and that digits, as well as special characters (e.g., *, #) may be used.
				/// </summary>
				public class ExtensionPrefix : HL7Base<ExtensionPrefix>
				{

					private const string _id = "OM1.29.10";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.29.11 - The characters established within a companys internal telephone system used in place of the (external) telephone number to facilitate calling because its length is shorter than that of the telephone number. Note that digits, as well as special characters (e.g., *, #) may be used.
				/// </summary>
				public class SpeedDialCode : HL7Base<SpeedDialCode>
				{

					private const string _id = "OM1.29.11";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.29.12 - An expression of the telephone number as an unparsable string. The Unformatted Telephone number is required when, and allowed only if, XTN.4 and XTN.7 are not populated.The phone number was entered as free text and sending system does not know how to parse it. Example 1-800-Dentist
				/// </summary>
				public class UnformattedTelephoneNumber : HL7Base<UnformattedTelephoneNumber>
				{

					private const string _id = "OM1.29.12";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.29.13 - The first date, if known, on which the telecommunication number is valid and active.
				/// </summary>
				public class EffectiveStartDate : HL7Base<EffectiveStartDate>
				{

					private const string _id = "OM1.29.13";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.29.14 - The last date, if known, on which the telecommunication number is valid and active.
				/// </summary>
				public class ExpirationDate : HL7Base<ExpirationDate>
				{

					private const string _id = "OM1.29.14";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.29.15 - Indicates why this contact number/e-mail was marked as "ended".  Refer to User-defined Table 0868  Telecommunication Expiration Reason for valid values.
				/// </summary>
				public class ExpirationReason : HL7Base<ExpirationReason>
				{

					private const string _id = "OM1.29.15";
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
					/// OM1.29.15.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "OM1.29.15.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.29.15.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "OM1.29.15.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.29.15.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "OM1.29.15.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.29.15.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "OM1.29.15.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.29.15.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "OM1.29.15.5";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.29.15.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "OM1.29.15.6";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.29.15.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "OM1.29.15.7";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.29.15.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "OM1.29.15.8";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.29.15.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "OM1.29.15.9";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.29.15.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "OM1.29.15.10";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.29.15.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "OM1.29.15.11";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.29.15.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "OM1.29.15.12";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.29.15.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "OM1.29.15.13";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.29.15.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "OM1.29.15.14";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.29.15.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "OM1.29.15.15";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.29.15.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "OM1.29.15.16";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.29.15.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "OM1.29.15.17";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.29.15.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "OM1.29.15.18";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.29.15.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "OM1.29.15.19";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.29.15.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "OM1.29.15.20";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.29.15.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "OM1.29.15.21";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.29.15.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "OM1.29.15.22";
						public override string Id
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
				/// OM1.29.16 - Indicates whether this information is considered sensitive or should be protected in some way. Refer to User-defined table 0618 - Protection Code for suggested values.The specific set of codes and appropriate handling of such telecommunications addresses will vary by jurisdiction and is subject to site-specific negotiation. For example, a provider address marked as 'unlisted' might not be printed in an internal address listing.
				/// </summary>
				public class ProtectionCode : HL7Base<ProtectionCode>
				{

					private const string _id = "OM1.29.16";
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
					/// OM1.29.16.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "OM1.29.16.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.29.16.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "OM1.29.16.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.29.16.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "OM1.29.16.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.29.16.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "OM1.29.16.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.29.16.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "OM1.29.16.5";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.29.16.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "OM1.29.16.6";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.29.16.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "OM1.29.16.7";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.29.16.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "OM1.29.16.8";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.29.16.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "OM1.29.16.9";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.29.16.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "OM1.29.16.10";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.29.16.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "OM1.29.16.11";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.29.16.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "OM1.29.16.12";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.29.16.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "OM1.29.16.13";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.29.16.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "OM1.29.16.14";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.29.16.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "OM1.29.16.15";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.29.16.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "OM1.29.16.16";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.29.16.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "OM1.29.16.17";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.29.16.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "OM1.29.16.18";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.29.16.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "OM1.29.16.19";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.29.16.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "OM1.29.16.20";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.29.16.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "OM1.29.16.21";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.29.16.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "OM1.29.16.22";
						public override string Id
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
				/// OM1.29.17 - A unique identifier for the phone number or e-mail address.This component allows a phone number to be uniquely identified, and enables the linking of a single phone number to multiple people and contexts. For example, each member of a family living at the same location would share the same phone number, having the same identifier. A correction to the phone number of one family member could be automatically propagated to other members of the family.HL7 does not assume responsibility for the processing rules for this component.
				/// </summary>
				public class SharedTelecommunicationIdentifier : HL7Base<SharedTelecommunicationIdentifier>
				{

					private const string _id = "OM1.29.17";
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
					/// OM1.29.17.1 - The first component, entity identifier, is usually defined to be unique within the series of identifiers created by the assigning authority, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, "HD - hierarchic designator".
					/// </summary>
					public class EntityIdentifier : HL7Base<EntityIdentifier>
					{

						private const string _id = "OM1.29.17.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.29.17.2 - See Section 2.A.33.1, "Namespace ID (IS)" for definition. The component intentionally remains associated with the IS data type in v 2.7.The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363  Assigning Authority for suggested values.Note When the HD is used as a part of another data type, in this case as part of the EI data type, this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment. By site agreement, implementers may continue to use User-defined Table 0300  Namespace ID for the first component
					/// </summary>
					public class NamespaceId : HL7Base<NamespaceId>
					{

						private const string _id = "OM1.29.17.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.29.17.3 - See Section 2.A.33.2, "Universal ID (ST)" for definition.
					/// </summary>
					public class UniversalId : HL7Base<UniversalId>
					{

						private const string _id = "OM1.29.17.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// OM1.29.17.4 - Refer to HL7 Table 0301 - Universal ID Type for valid values. See Section 2.A.33.3, "Universal ID Type (ID)," for definition.
					/// </summary>
					public class UniversalIdType : HL7Base<UniversalIdType>
					{

						private const string _id = "OM1.29.17.4";
						public override string Id
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
				/// OM1.29.18 - For an entity having multiple telecommunication addresses, indicates which is the "most preferred" (lowest number) to "least preferred" (highest number).If the preference order is unique across all usages for a given type, then it indicates the preference across all usages, (e.g. first try my home number, then my business number). If the preference order is unique across all usages and types, then it indicates the preference across all types of telecommunication addresses.  (E.g., first try my phone if that doesn't work, use my pager.) Otherwise, the preference order is assumed to only apply within a specific type and usage.Preference order numbers need not be sequential (i.e., three numbers with the priority orders of 0, 5 and 15 are legitimate).  The preference order numbers must be non-negative.
				/// </summary>
				public class PreferenceOrder : HL7Base<PreferenceOrder>
				{

					private const string _id = "OM1.29.18";
					public override string Id
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
			/// OM1.30 - This field contains the degree to which special confidentiality protection should be applied to the observation.  For example, a tighter control may be applied to an HIV test than to a CBC.  Refer to User-defined Table 0177 - Confidentiality Code for suggested values.
			/// </summary>
			public class ConfidentialityCode : HL7Base<ConfidentialityCode>
			{

				private const string _id = "OM1.30";
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
				/// OM1.30.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
				/// </summary>
				public class Identifier : HL7Base<Identifier>
				{

					private const string _id = "OM1.30.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.30.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
				/// </summary>
				public class Text : HL7Base<Text>
				{

					private const string _id = "OM1.30.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.30.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
				/// </summary>
				public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
				{

					private const string _id = "OM1.30.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.30.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
				/// </summary>
				public class AlternateIdentifier : HL7Base<AlternateIdentifier>
				{

					private const string _id = "OM1.30.4";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.30.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
				/// </summary>
				public class AlternateText : HL7Base<AlternateText>
				{

					private const string _id = "OM1.30.5";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.30.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
				{

					private const string _id = "OM1.30.6";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.30.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
				/// </summary>
				public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
				{

					private const string _id = "OM1.30.7";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.30.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
				/// </summary>
				public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
				{

					private const string _id = "OM1.30.8";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.30.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
				/// </summary>
				public class OriginalText : HL7Base<OriginalText>
				{

					private const string _id = "OM1.30.9";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.30.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
				/// </summary>
				public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
				{

					private const string _id = "OM1.30.10";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.30.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
				/// </summary>
				public class SecondAlternateText : HL7Base<SecondAlternateText>
				{

					private const string _id = "OM1.30.11";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.30.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
				{

					private const string _id = "OM1.30.12";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.30.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
				/// </summary>
				public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
				{

					private const string _id = "OM1.30.13";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.30.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
				/// </summary>
				public class CodingSystemOid : HL7Base<CodingSystemOid>
				{

					private const string _id = "OM1.30.14";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.30.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class ValueSetOid : HL7Base<ValueSetOid>
				{

					private const string _id = "OM1.30.15";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.30.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
				/// </summary>
				public class ValueSetVersionId : HL7Base<ValueSetVersionId>
				{

					private const string _id = "OM1.30.16";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.30.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
				/// </summary>
				public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
				{

					private const string _id = "OM1.30.17";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.30.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
				{

					private const string _id = "OM1.30.18";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.30.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
				/// </summary>
				public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
				{

					private const string _id = "OM1.30.19";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.30.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
				/// </summary>
				public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
				{

					private const string _id = "OM1.30.20";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.30.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
				{

					private const string _id = "OM1.30.21";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.30.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
				/// </summary>
				public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
				{

					private const string _id = "OM1.30.22";
					public override string Id
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
			/// OM1.31 - This field indicates whether the order is to be executed in an inpatient setting or an outpatient setting.  If this field is not valued, the system default is assumed.  Refer to HL7 Table 0482 - Order Type for suggested values.Examples Before discharge an order is placed for follow-up physical therapy, or to pick up a prescription at a community pharmacy.  The patient is an inpatient according to PV1, but the order is an outpatient order.
			/// </summary>
			public class ObservationsRequiredToInterpretThisObservation : HL7Base<ObservationsRequiredToInterpretThisObservation>
			{

				private const string _id = "OM1.31";
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
				/// OM1.31.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
				/// </summary>
				public class Identifier : HL7Base<Identifier>
				{

					private const string _id = "OM1.31.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.31.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
				/// </summary>
				public class Text : HL7Base<Text>
				{

					private const string _id = "OM1.31.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.31.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
				/// </summary>
				public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
				{

					private const string _id = "OM1.31.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.31.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
				/// </summary>
				public class AlternateIdentifier : HL7Base<AlternateIdentifier>
				{

					private const string _id = "OM1.31.4";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.31.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
				/// </summary>
				public class AlternateText : HL7Base<AlternateText>
				{

					private const string _id = "OM1.31.5";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.31.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
				{

					private const string _id = "OM1.31.6";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.31.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
				/// </summary>
				public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
				{

					private const string _id = "OM1.31.7";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.31.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
				/// </summary>
				public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
				{

					private const string _id = "OM1.31.8";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.31.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
				/// </summary>
				public class OriginalText : HL7Base<OriginalText>
				{

					private const string _id = "OM1.31.9";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.31.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
				/// </summary>
				public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
				{

					private const string _id = "OM1.31.10";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.31.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
				/// </summary>
				public class SecondAlternateText : HL7Base<SecondAlternateText>
				{

					private const string _id = "OM1.31.11";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.31.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
				{

					private const string _id = "OM1.31.12";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.31.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
				/// </summary>
				public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
				{

					private const string _id = "OM1.31.13";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.31.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
				/// </summary>
				public class CodingSystemOid : HL7Base<CodingSystemOid>
				{

					private const string _id = "OM1.31.14";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.31.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class ValueSetOid : HL7Base<ValueSetOid>
				{

					private const string _id = "OM1.31.15";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.31.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
				/// </summary>
				public class ValueSetVersionId : HL7Base<ValueSetVersionId>
				{

					private const string _id = "OM1.31.16";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.31.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
				/// </summary>
				public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
				{

					private const string _id = "OM1.31.17";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.31.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
				{

					private const string _id = "OM1.31.18";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.31.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
				/// </summary>
				public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
				{

					private const string _id = "OM1.31.19";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.31.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
				/// </summary>
				public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
				{

					private const string _id = "OM1.31.20";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.31.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
				{

					private const string _id = "OM1.31.21";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.31.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
				/// </summary>
				public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
				{

					private const string _id = "OM1.31.22";
					public override string Id
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
			/// OM1.32 - This field contains the clinical information about interpreting test results.  Examples are the conditions (drugs) that may cause false abnormals, and the information about the sensitivity and specificity of the test for diagnoses.
			/// </summary>
			public class InterpretationOfObservations : HL7Base<InterpretationOfObservations>
			{

				private const string _id = "OM1.32";
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
			/// OM1.33 - This field contains the diagnosis or problem for which the test is a contraindication or of possible danger (e.g., pacemaker, pregnancy, diabetes).  For example, if the test identified in OM1 was an intravenous pyelogram, this field would include warnings about the use of contrast media in diabetes. The contraindication diagnoses should be separated by repeat delimiters.Most contraindication rules will be transmitted as free text.  In such cases, the contents serve only as information for human reading.  However, an alternative for machine readable contraindication rules also exists. The rule may be defined formally in the Arden Syntax (ASTM 1460-1992) which has syntax for defining algebraic and transcendental equations, as well as temporal and logical selection criteria based on patient information stored in the computer record. Reflex rules that are written in Arden Syntax should begin and end with a double semi-colon (), the Arden slot delimiter.
			/// </summary>
			public class ContraindicationsToObservations : HL7Base<ContraindicationsToObservations>
			{

				private const string _id = "OM1.33";
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
				/// OM1.33.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
				/// </summary>
				public class Identifier : HL7Base<Identifier>
				{

					private const string _id = "OM1.33.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.33.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
				/// </summary>
				public class Text : HL7Base<Text>
				{

					private const string _id = "OM1.33.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.33.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
				/// </summary>
				public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
				{

					private const string _id = "OM1.33.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.33.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
				/// </summary>
				public class AlternateIdentifier : HL7Base<AlternateIdentifier>
				{

					private const string _id = "OM1.33.4";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.33.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
				/// </summary>
				public class AlternateText : HL7Base<AlternateText>
				{

					private const string _id = "OM1.33.5";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.33.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
				{

					private const string _id = "OM1.33.6";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.33.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
				/// </summary>
				public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
				{

					private const string _id = "OM1.33.7";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.33.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
				/// </summary>
				public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
				{

					private const string _id = "OM1.33.8";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.33.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
				/// </summary>
				public class OriginalText : HL7Base<OriginalText>
				{

					private const string _id = "OM1.33.9";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.33.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
				/// </summary>
				public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
				{

					private const string _id = "OM1.33.10";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.33.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
				/// </summary>
				public class SecondAlternateText : HL7Base<SecondAlternateText>
				{

					private const string _id = "OM1.33.11";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.33.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
				{

					private const string _id = "OM1.33.12";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.33.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
				/// </summary>
				public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
				{

					private const string _id = "OM1.33.13";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.33.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
				/// </summary>
				public class CodingSystemOid : HL7Base<CodingSystemOid>
				{

					private const string _id = "OM1.33.14";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.33.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class ValueSetOid : HL7Base<ValueSetOid>
				{

					private const string _id = "OM1.33.15";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.33.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
				/// </summary>
				public class ValueSetVersionId : HL7Base<ValueSetVersionId>
				{

					private const string _id = "OM1.33.16";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.33.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
				/// </summary>
				public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
				{

					private const string _id = "OM1.33.17";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.33.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
				{

					private const string _id = "OM1.33.18";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.33.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
				/// </summary>
				public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
				{

					private const string _id = "OM1.33.19";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.33.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
				/// </summary>
				public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
				{

					private const string _id = "OM1.33.20";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.33.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
				{

					private const string _id = "OM1.33.21";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.33.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
				/// </summary>
				public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
				{

					private const string _id = "OM1.33.22";
					public override string Id
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
			/// OM1.34 - This field contains the test names as type CWE (i.e., codetext namecoding system) that may be ordered automatically by the diagnostic service, depending on the results obtained from the ordered battery.  A screening CBC might trigger a reticulocyte count if the Hgb is less than 12.  Multiple reflex tests are separated by repeat delimiters.
			/// </summary>
			public class ReflexTestsObservations : HL7Base<ReflexTestsObservations>
			{

				private const string _id = "OM1.34";
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
				/// OM1.34.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
				/// </summary>
				public class Identifier : HL7Base<Identifier>
				{

					private const string _id = "OM1.34.1";
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
				/// OM1.34.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
				/// </summary>
				public class Text : HL7Base<Text>
				{

					private const string _id = "OM1.34.2";
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
				/// OM1.34.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
				/// </summary>
				public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
				{

					private const string _id = "OM1.34.3";
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
				/// OM1.34.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
				/// </summary>
				public class AlternateIdentifier : HL7Base<AlternateIdentifier>
				{

					private const string _id = "OM1.34.4";
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
				/// OM1.34.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
				/// </summary>
				public class AlternateText : HL7Base<AlternateText>
				{

					private const string _id = "OM1.34.5";
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
				/// OM1.34.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
				{

					private const string _id = "OM1.34.6";
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
				/// OM1.34.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
				/// </summary>
				public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
				{

					private const string _id = "OM1.34.7";
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
				/// OM1.34.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
				/// </summary>
				public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
				{

					private const string _id = "OM1.34.8";
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
				/// OM1.34.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
				/// </summary>
				public class OriginalText : HL7Base<OriginalText>
				{

					private const string _id = "OM1.34.9";
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
				/// OM1.34.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
				/// </summary>
				public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
				{

					private const string _id = "OM1.34.10";
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
				/// OM1.34.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
				/// </summary>
				public class SecondAlternateText : HL7Base<SecondAlternateText>
				{

					private const string _id = "OM1.34.11";
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
				/// OM1.34.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
				{

					private const string _id = "OM1.34.12";
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
				/// OM1.34.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
				/// </summary>
				public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
				{

					private const string _id = "OM1.34.13";
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
				/// OM1.34.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
				/// </summary>
				public class CodingSystemOid : HL7Base<CodingSystemOid>
				{

					private const string _id = "OM1.34.14";
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
				/// OM1.34.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class ValueSetOid : HL7Base<ValueSetOid>
				{

					private const string _id = "OM1.34.15";
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
				/// OM1.34.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
				/// </summary>
				public class ValueSetVersionId : HL7Base<ValueSetVersionId>
				{

					private const string _id = "OM1.34.16";
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
				/// OM1.34.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
				/// </summary>
				public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
				{

					private const string _id = "OM1.34.17";
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
				/// OM1.34.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
				{

					private const string _id = "OM1.34.18";
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
				/// OM1.34.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
				/// </summary>
				public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
				{

					private const string _id = "OM1.34.19";
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
				/// OM1.34.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
				/// </summary>
				public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
				{

					private const string _id = "OM1.34.20";
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
				/// OM1.34.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
				{

					private const string _id = "OM1.34.21";
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
				/// OM1.34.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
				/// </summary>
				public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
				{

					private const string _id = "OM1.34.22";
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
			/// OM1.35 - This field contains the rules that trigger the reflex tests listed above.  If multiple reflex tests are listed in OM1-34 - Reflex Text/Observations separated by repeat delimiters, a set of corresponding rules will be included in this section.  The first rule will apply to the first test, the second to the second test, and so on.Most reflex rules will usually be transmitted as free text.  In such cases, the contents serve only as information for human reading.  However, an alternative for machine readable rules also exists. The rule may be defined formally in the Arden Syntax (ASTM 1460-1992) which has syntax for defining algebraic and transcendental equations, as well as temporal and logical selection criteria based on patient information stored in the computer record.  Reflex rules that are written in Arden Syntax should begin and end with a double semi-colon (), the Arden slot delimiter.
			/// </summary>
			public class RulesThatTriggerReflexTesting : HL7Base<RulesThatTriggerReflexTesting>
			{

				private const string _id = "OM1.35";
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
			/// OM1.36 - Most rules about patient testing will be transmitted as free text.  In such cases, the contents serve only as information for human reading.  However, an alternative for machine readable rules also exists.  The rule may be defined formally in the Arden Syntax (ASTM 1460-1992) which has syntax for defining algebraic and transcendental equations, as well as temporal and logical selection criteria based on patient information stored in the computer record.  Rules about patient preparation are written in Arden Syntax should begin and end with a double semi-colon (), the Arden slot delimiter.  This field contains the codes and a fixed text message that is always associated with an abbreviation.  The field may include multiple messages separated by repeat delimiters.
			/// </summary>
			public class FixedCannedMessage : HL7Base<FixedCannedMessage>
			{

				private const string _id = "OM1.36";
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
				/// OM1.36.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
				/// </summary>
				public class Identifier : HL7Base<Identifier>
				{

					private const string _id = "OM1.36.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.36.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
				/// </summary>
				public class Text : HL7Base<Text>
				{

					private const string _id = "OM1.36.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.36.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
				/// </summary>
				public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
				{

					private const string _id = "OM1.36.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.36.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
				/// </summary>
				public class AlternateIdentifier : HL7Base<AlternateIdentifier>
				{

					private const string _id = "OM1.36.4";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.36.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
				/// </summary>
				public class AlternateText : HL7Base<AlternateText>
				{

					private const string _id = "OM1.36.5";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.36.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
				{

					private const string _id = "OM1.36.6";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.36.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
				/// </summary>
				public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
				{

					private const string _id = "OM1.36.7";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.36.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
				/// </summary>
				public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
				{

					private const string _id = "OM1.36.8";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.36.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
				/// </summary>
				public class OriginalText : HL7Base<OriginalText>
				{

					private const string _id = "OM1.36.9";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.36.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
				/// </summary>
				public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
				{

					private const string _id = "OM1.36.10";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.36.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
				/// </summary>
				public class SecondAlternateText : HL7Base<SecondAlternateText>
				{

					private const string _id = "OM1.36.11";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.36.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
				{

					private const string _id = "OM1.36.12";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.36.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
				/// </summary>
				public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
				{

					private const string _id = "OM1.36.13";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.36.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
				/// </summary>
				public class CodingSystemOid : HL7Base<CodingSystemOid>
				{

					private const string _id = "OM1.36.14";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.36.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class ValueSetOid : HL7Base<ValueSetOid>
				{

					private const string _id = "OM1.36.15";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.36.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
				/// </summary>
				public class ValueSetVersionId : HL7Base<ValueSetVersionId>
				{

					private const string _id = "OM1.36.16";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.36.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
				/// </summary>
				public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
				{

					private const string _id = "OM1.36.17";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.36.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
				{

					private const string _id = "OM1.36.18";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.36.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
				/// </summary>
				public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
				{

					private const string _id = "OM1.36.19";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.36.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
				/// </summary>
				public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
				{

					private const string _id = "OM1.36.20";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.36.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
				{

					private const string _id = "OM1.36.21";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.36.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
				/// </summary>
				public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
				{

					private const string _id = "OM1.36.22";
					public override string Id
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
			/// OM1.37 - This field contains the tests or observations that require special patient preparation, diet, or medications.  For GI contrast studies, this field would contain the pretest diet, e.g., low residue for two days, NPO before study, and the preferred purgatives.  Each separate med, diet, or preparation should be delimited by a repeat delimiter.  Separate each requirement by a repeat delimiter.  Example for a sigmoidectomy
			/// </summary>
			public class PatientPreparation : HL7Base<PatientPreparation>
			{

				private const string _id = "OM1.37";
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
			/// OM1.38 - This field contains the treatments that may be needed as part of the procedure.  Examples are radioactive iodine for a thyroid screen, and methacholine for a methacholine spirometry challenge.  This field should be identified as a CWE data type.
			/// </summary>
			public class ProcedureMedication : HL7Base<ProcedureMedication>
			{

				private const string _id = "OM1.38";
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
				/// OM1.38.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
				/// </summary>
				public class Identifier : HL7Base<Identifier>
				{

					private const string _id = "OM1.38.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.38.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
				/// </summary>
				public class Text : HL7Base<Text>
				{

					private const string _id = "OM1.38.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.38.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
				/// </summary>
				public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
				{

					private const string _id = "OM1.38.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.38.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
				/// </summary>
				public class AlternateIdentifier : HL7Base<AlternateIdentifier>
				{

					private const string _id = "OM1.38.4";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.38.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
				/// </summary>
				public class AlternateText : HL7Base<AlternateText>
				{

					private const string _id = "OM1.38.5";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.38.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
				{

					private const string _id = "OM1.38.6";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.38.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
				/// </summary>
				public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
				{

					private const string _id = "OM1.38.7";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.38.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
				/// </summary>
				public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
				{

					private const string _id = "OM1.38.8";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.38.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
				/// </summary>
				public class OriginalText : HL7Base<OriginalText>
				{

					private const string _id = "OM1.38.9";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.38.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
				/// </summary>
				public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
				{

					private const string _id = "OM1.38.10";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.38.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
				/// </summary>
				public class SecondAlternateText : HL7Base<SecondAlternateText>
				{

					private const string _id = "OM1.38.11";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.38.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
				{

					private const string _id = "OM1.38.12";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.38.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
				/// </summary>
				public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
				{

					private const string _id = "OM1.38.13";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.38.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
				/// </summary>
				public class CodingSystemOid : HL7Base<CodingSystemOid>
				{

					private const string _id = "OM1.38.14";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.38.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class ValueSetOid : HL7Base<ValueSetOid>
				{

					private const string _id = "OM1.38.15";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.38.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
				/// </summary>
				public class ValueSetVersionId : HL7Base<ValueSetVersionId>
				{

					private const string _id = "OM1.38.16";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.38.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
				/// </summary>
				public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
				{

					private const string _id = "OM1.38.17";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.38.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
				{

					private const string _id = "OM1.38.18";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.38.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
				/// </summary>
				public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
				{

					private const string _id = "OM1.38.19";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.38.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
				/// </summary>
				public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
				{

					private const string _id = "OM1.38.20";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.38.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
				{

					private const string _id = "OM1.38.21";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.38.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
				/// </summary>
				public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
				{

					private const string _id = "OM1.38.22";
					public override string Id
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
			/// OM1.39 - This field contains the text description of the foods, diagnoses, drugs, or other conditions that may influence the interpretation of the observation. Information about the direction of the effect, and any recommendation about altering the diet, conditions, or drug before initiating the test observation.Most rules about factors that effect the test interpretation will be transmitted as free text.  In such cases, the contents serve only as information for human reading.  However, an alternative for machine readable rules also exists.  The rule may be defined formally in the Arden Syntax (ASTM 1460-1992) which has syntax for defining algebraic and transcendental equations, as well as temporal and logical selection criteria based on patient information stored in the computer record.  Rules about patient preparation are written in Arden Syntax and should begin and end with a double semi-colon (), the Arden slot delimiter.
			/// </summary>
			public class FactorsThatMayAffectTheObservation : HL7Base<FactorsThatMayAffectTheObservation>
			{

				private const string _id = "OM1.39";
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
			/// OM1.40 - This field contains the diagnostic studies/tests that are performed only at certain times during the course of a work day or work week.  This field indicates the maximum interval between successive test performances (the test may actually be performed more frequently).  The format given in Chapter 4, Section 4.3.2.1, "Repeat Pattern," should be used.  If necessary, multiple codes may be given, separated by repeat delimiters.  The use of multiple codes indicates that the test is performed at multiple concurrent intervals.  For example, Q6H indicates that the test is performed at least once every 6 hours around the clock.  QJ1 indicates that the test is performed at least every week on Mondays.  QAMQPM indicates that the test is performed at least once every morning and every evening. QJ1QJ3QJ5 indicates that the test is performed at least every week on Mondays, Wednesdays, and Fridays.  C indicates that the test is performed continuously, 7 days per week.
			/// </summary>
			public class ServiceTestObservationPerformanceSchedule : HL7Base<ServiceTestObservationPerformanceSchedule>
			{

				private const string _id = "OM1.40";
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
			/// OM1.41 - This field contains the text description of the methods used to perform the text and generate the observations.  Bibliographic citations may be included.
			/// </summary>
			public class DescriptionOfTestMethods : HL7Base<DescriptionOfTestMethods>
			{

				private const string _id = "OM1.41";
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
			/// OM1.42 - This optional attribute describes the underlying kind of property represented by this observation.  This attribute distinguishes concentrations from total amounts, molar concentrations from mass concentrations, partial pressures from colors, and so forth.  These are discussed more fully in the LOINC Users' Manual.  They are derived from the approach described in 1995 edition of the IUPAC Silver Book. These distinctions are used in IUPAC and LOINC standard codes.  Defined categories are listed in HL7 Table 0254 - Kind of Quantity.The distinctions of true quantities in this table are based primarily on dimensional analyses. The table contains a number of "families," those related to simple counts (number, number concentration, etc.), to mass (mass, mass concentration, etc.), to enzyme activity (catalytic content, catalytic concentration, etc.), and molar or equivalents (substance content, substance concentration).By this classification, a glucose (in the US) would be classed as a mass concentration.  A sodium would be classed as a substance concentration. Within the family, a total amount should be described as the unadorned variant e.g., the property of measure for a patient's weight would be mass, not mass content.  Most chemical measures produce concentrations, as exemplified by sodium and glucose. However, a 24-hour urine protein is not a mass concentration, but a mass rate (mass per unit time).  The content variants (e.g., mass content, substance content) are used to reflect an amount per mass (usually) of tissue.This attribute would be valued in a master file only if the service sending the master file classified observations by their principle of measurement.
			/// </summary>
			public class KindOfQuantityObserved : HL7Base<KindOfQuantityObserved>
			{

				private const string _id = "OM1.42";
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
				/// OM1.42.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
				/// </summary>
				public class Identifier : HL7Base<Identifier>
				{

					private const string _id = "OM1.42.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.42.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
				/// </summary>
				public class Text : HL7Base<Text>
				{

					private const string _id = "OM1.42.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.42.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
				/// </summary>
				public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
				{

					private const string _id = "OM1.42.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.42.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
				/// </summary>
				public class AlternateIdentifier : HL7Base<AlternateIdentifier>
				{

					private const string _id = "OM1.42.4";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.42.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
				/// </summary>
				public class AlternateText : HL7Base<AlternateText>
				{

					private const string _id = "OM1.42.5";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.42.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
				{

					private const string _id = "OM1.42.6";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.42.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
				/// </summary>
				public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
				{

					private const string _id = "OM1.42.7";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.42.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
				/// </summary>
				public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
				{

					private const string _id = "OM1.42.8";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.42.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
				/// </summary>
				public class OriginalText : HL7Base<OriginalText>
				{

					private const string _id = "OM1.42.9";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.42.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
				/// </summary>
				public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
				{

					private const string _id = "OM1.42.10";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.42.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
				/// </summary>
				public class SecondAlternateText : HL7Base<SecondAlternateText>
				{

					private const string _id = "OM1.42.11";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.42.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
				{

					private const string _id = "OM1.42.12";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.42.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
				/// </summary>
				public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
				{

					private const string _id = "OM1.42.13";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.42.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
				/// </summary>
				public class CodingSystemOid : HL7Base<CodingSystemOid>
				{

					private const string _id = "OM1.42.14";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.42.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class ValueSetOid : HL7Base<ValueSetOid>
				{

					private const string _id = "OM1.42.15";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.42.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
				/// </summary>
				public class ValueSetVersionId : HL7Base<ValueSetVersionId>
				{

					private const string _id = "OM1.42.16";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.42.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
				/// </summary>
				public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
				{

					private const string _id = "OM1.42.17";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.42.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
				{

					private const string _id = "OM1.42.18";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.42.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
				/// </summary>
				public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
				{

					private const string _id = "OM1.42.19";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.42.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
				/// </summary>
				public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
				{

					private const string _id = "OM1.42.20";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.42.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
				{

					private const string _id = "OM1.42.21";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.42.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
				/// </summary>
				public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
				{

					private const string _id = "OM1.42.22";
					public override string Id
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
			/// OM1.43 - This optional attribute allows master files to classify observations as measuring the patient's state at a point in time (e.g., spot urines, random urines, serum potassium), or averaged over an interval of time (e.g., concentration, total amount, or clearance over a 24-hour collection).  Interval measures most often apply to urine and stool specimens (e.g., 24-hour urines, 3-day stool fats).  They also apply to clinical measurements such as urine outputs, which are reported as shift totals and 24-hour totals, and event counts on physiologic monitors such as the number of PVCs on a 24-hour Holter monitor.This field would only be valued in a transaction if the service sending this master file message classified its observation by point versus time interval. This field is not used to record the time collection interval for a particular sample. It is used to specify a characteristic of an observation which has a defined normal range and to distinguish observations of the same kind but observed over varying periods of time.  A spot urine sodium would have PT stored in this field. A 24-hour urine sodium and a 24-hour Holter monitor would have 24H stored here. This attribute would only be valued if the filling service classified its observations by timing.  Refer to User-defined Table 0255 - Duration Categories for suggested values.
			/// </summary>
			public class PointVersusInterval : HL7Base<PointVersusInterval>
			{

				private const string _id = "OM1.43";
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
				/// OM1.43.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
				/// </summary>
				public class Identifier : HL7Base<Identifier>
				{

					private const string _id = "OM1.43.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.43.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
				/// </summary>
				public class Text : HL7Base<Text>
				{

					private const string _id = "OM1.43.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.43.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
				/// </summary>
				public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
				{

					private const string _id = "OM1.43.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.43.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
				/// </summary>
				public class AlternateIdentifier : HL7Base<AlternateIdentifier>
				{

					private const string _id = "OM1.43.4";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.43.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
				/// </summary>
				public class AlternateText : HL7Base<AlternateText>
				{

					private const string _id = "OM1.43.5";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.43.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
				{

					private const string _id = "OM1.43.6";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.43.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
				/// </summary>
				public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
				{

					private const string _id = "OM1.43.7";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.43.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
				/// </summary>
				public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
				{

					private const string _id = "OM1.43.8";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.43.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
				/// </summary>
				public class OriginalText : HL7Base<OriginalText>
				{

					private const string _id = "OM1.43.9";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.43.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
				/// </summary>
				public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
				{

					private const string _id = "OM1.43.10";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.43.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
				/// </summary>
				public class SecondAlternateText : HL7Base<SecondAlternateText>
				{

					private const string _id = "OM1.43.11";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.43.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
				{

					private const string _id = "OM1.43.12";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.43.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
				/// </summary>
				public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
				{

					private const string _id = "OM1.43.13";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.43.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
				/// </summary>
				public class CodingSystemOid : HL7Base<CodingSystemOid>
				{

					private const string _id = "OM1.43.14";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.43.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class ValueSetOid : HL7Base<ValueSetOid>
				{

					private const string _id = "OM1.43.15";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.43.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
				/// </summary>
				public class ValueSetVersionId : HL7Base<ValueSetVersionId>
				{

					private const string _id = "OM1.43.16";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.43.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
				/// </summary>
				public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
				{

					private const string _id = "OM1.43.17";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.43.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
				{

					private const string _id = "OM1.43.18";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.43.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
				/// </summary>
				public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
				{

					private const string _id = "OM1.43.19";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.43.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
				/// </summary>
				public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
				{

					private const string _id = "OM1.43.20";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.43.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
				{

					private const string _id = "OM1.43.21";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.43.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
				/// </summary>
				public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
				{

					private const string _id = "OM1.43.22";
					public override string Id
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
			/// OM1.44 - This optional attribute provides information for classifying observations by the challenge component of the test, if a challenge does speciate the observation.  For example, distinguishing tests that have a challenge component in database. There co-ascribes the physiologic or drug challenge that is intrinsic to the measurement. To identify, for example, tests that include a glucose challenge.To construct this text string, use the following template.  (Note  This field is not constructed of formally defined components it is a free text field.  Component delimiters are not used and it is not necessary to supply placeholders if some "components" are not used.)The time delay follows the syntax nSMHDW where n is a number (possibly a decimal) S denotes seconds M denotes minutes H denotes hours D denotes days and W denotes weeks.  The time delay can be preceded by a 'greater than' () sign, e.g. 4H.HL7 Table 0256 - Time Delay Post Challenge lists possible values for time delay.ExamplesFor drug peak and trough measures the nature of the substance challenged is the same as the analyte name, and need not be included.We denote the route of the challenge via abbreviations for medication routes (see Chapter 4, section 4.14.2.1, "Route," HL7 Table 0162 - Route of Administration).  An oral route of administration would be denoted by "PO," an intravenous route by "IV."Details of the drug dose, time the dose was given, route of administration, etc., would be noted in separate OBX, and would have corresponding master observation definitions stored in the observation master file map to different records stored in the master file segments contained in the drug level message.The nature of a physiologic (non-drug) challenge may also be specified, using the terms in HL7 Table 0257 - Nature of challenge.
			/// </summary>
			public class ChallengeInformation : HL7Base<ChallengeInformation>
			{

				private const string _id = "OM1.44";
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
			/// OM1.45 - This optional attribute provides a mechanism for classifying observations according to the subject, in relation to the patient whose results might be stored with as "patient" data.  It is standard practice, for example, to report values for controls, donors, and blood product units as well as the patient's own values, and store them in the patient's record. (This may not be the best way to model such information, but it is the way it is usually reported.) This should be valued when two values (e.g., one for patient and one for a blood product unit) could otherwise be confused.The default value is "Patient," and if not specified, this value is assumed.  The persons sub-component can refer to HL7 Table 0258 - Relationship Modifier for valid values.
			/// </summary>
			public class RelationshipModifier : HL7Base<RelationshipModifier>
			{

				private const string _id = "OM1.45";
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
				/// OM1.45.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
				/// </summary>
				public class Identifier : HL7Base<Identifier>
				{

					private const string _id = "OM1.45.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.45.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
				/// </summary>
				public class Text : HL7Base<Text>
				{

					private const string _id = "OM1.45.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.45.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
				/// </summary>
				public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
				{

					private const string _id = "OM1.45.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.45.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
				/// </summary>
				public class AlternateIdentifier : HL7Base<AlternateIdentifier>
				{

					private const string _id = "OM1.45.4";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.45.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
				/// </summary>
				public class AlternateText : HL7Base<AlternateText>
				{

					private const string _id = "OM1.45.5";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.45.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
				{

					private const string _id = "OM1.45.6";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.45.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
				/// </summary>
				public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
				{

					private const string _id = "OM1.45.7";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.45.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
				/// </summary>
				public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
				{

					private const string _id = "OM1.45.8";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.45.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
				/// </summary>
				public class OriginalText : HL7Base<OriginalText>
				{

					private const string _id = "OM1.45.9";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.45.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
				/// </summary>
				public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
				{

					private const string _id = "OM1.45.10";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.45.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
				/// </summary>
				public class SecondAlternateText : HL7Base<SecondAlternateText>
				{

					private const string _id = "OM1.45.11";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.45.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
				{

					private const string _id = "OM1.45.12";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.45.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
				/// </summary>
				public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
				{

					private const string _id = "OM1.45.13";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.45.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
				/// </summary>
				public class CodingSystemOid : HL7Base<CodingSystemOid>
				{

					private const string _id = "OM1.45.14";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.45.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class ValueSetOid : HL7Base<ValueSetOid>
				{

					private const string _id = "OM1.45.15";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.45.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
				/// </summary>
				public class ValueSetVersionId : HL7Base<ValueSetVersionId>
				{

					private const string _id = "OM1.45.16";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.45.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
				/// </summary>
				public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
				{

					private const string _id = "OM1.45.17";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.45.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
				{

					private const string _id = "OM1.45.18";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.45.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
				/// </summary>
				public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
				{

					private const string _id = "OM1.45.19";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.45.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
				/// </summary>
				public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
				{

					private const string _id = "OM1.45.20";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.45.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
				{

					private const string _id = "OM1.45.21";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.45.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
				/// </summary>
				public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
				{

					private const string _id = "OM1.45.22";
					public override string Id
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
			/// OM1.46 - This optional attribute formally indicates the site of the observation (to make it easy for a system to find all tests related to one anatomic site). It can be used to classify the observation by target site of the examination.  For example, "heart" might be recorded as the target of the electrocardiogram, cardiac echo, and thallium exercise test.  This attribute would be applicable to most imaging and electro-physiologic examinations. The SNOMED topology axis is an example of a coding system for anatomic sites.  User-defined tables may also apply here
			/// </summary>
			public class TargetAnatomicSiteOfTest : HL7Base<TargetAnatomicSiteOfTest>
			{

				private const string _id = "OM1.46";
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
				/// OM1.46.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
				/// </summary>
				public class Identifier : HL7Base<Identifier>
				{

					private const string _id = "OM1.46.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.46.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
				/// </summary>
				public class Text : HL7Base<Text>
				{

					private const string _id = "OM1.46.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.46.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
				/// </summary>
				public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
				{

					private const string _id = "OM1.46.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.46.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
				/// </summary>
				public class AlternateIdentifier : HL7Base<AlternateIdentifier>
				{

					private const string _id = "OM1.46.4";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.46.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
				/// </summary>
				public class AlternateText : HL7Base<AlternateText>
				{

					private const string _id = "OM1.46.5";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.46.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
				{

					private const string _id = "OM1.46.6";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.46.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
				/// </summary>
				public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
				{

					private const string _id = "OM1.46.7";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.46.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
				/// </summary>
				public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
				{

					private const string _id = "OM1.46.8";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.46.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
				/// </summary>
				public class OriginalText : HL7Base<OriginalText>
				{

					private const string _id = "OM1.46.9";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.46.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
				/// </summary>
				public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
				{

					private const string _id = "OM1.46.10";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.46.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
				/// </summary>
				public class SecondAlternateText : HL7Base<SecondAlternateText>
				{

					private const string _id = "OM1.46.11";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.46.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
				{

					private const string _id = "OM1.46.12";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.46.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
				/// </summary>
				public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
				{

					private const string _id = "OM1.46.13";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.46.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
				/// </summary>
				public class CodingSystemOid : HL7Base<CodingSystemOid>
				{

					private const string _id = "OM1.46.14";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.46.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class ValueSetOid : HL7Base<ValueSetOid>
				{

					private const string _id = "OM1.46.15";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.46.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
				/// </summary>
				public class ValueSetVersionId : HL7Base<ValueSetVersionId>
				{

					private const string _id = "OM1.46.16";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.46.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
				/// </summary>
				public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
				{

					private const string _id = "OM1.46.17";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.46.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
				{

					private const string _id = "OM1.46.18";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.46.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
				/// </summary>
				public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
				{

					private const string _id = "OM1.46.19";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.46.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
				/// </summary>
				public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
				{

					private const string _id = "OM1.46.20";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.46.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
				{

					private const string _id = "OM1.46.21";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.46.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
				/// </summary>
				public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
				{

					private const string _id = "OM1.46.22";
					public override string Id
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
			/// OM1.47 - This optional attribute describes the modality used to acquire the observation data, e.g., radiograph, ultrasound, CT scan, MR, etc.  This attribute is especially important for imaging studies.  Refer to External Table 0910  Acquisition Modality in Chapter 2C, Code Tables, for the defined value set, which may be repalce or extended with local codes.  If the DICOM codes are used, the coding system ID is DCM.Note The use of User-defined Table 0259 - Modality for this field is deprecated and retained for backward compatibility as of v 2.7.
			/// </summary>
			public class ModalityOfImagingMeasurement : HL7Base<ModalityOfImagingMeasurement>
			{

				private const string _id = "OM1.47";
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
				/// OM1.47.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
				/// </summary>
				public class Identifier : HL7Base<Identifier>
				{

					private const string _id = "OM1.47.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.47.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
				/// </summary>
				public class Text : HL7Base<Text>
				{

					private const string _id = "OM1.47.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.47.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
				/// </summary>
				public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
				{

					private const string _id = "OM1.47.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.47.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
				/// </summary>
				public class AlternateIdentifier : HL7Base<AlternateIdentifier>
				{

					private const string _id = "OM1.47.4";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.47.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
				/// </summary>
				public class AlternateText : HL7Base<AlternateText>
				{

					private const string _id = "OM1.47.5";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.47.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
				{

					private const string _id = "OM1.47.6";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.47.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
				/// </summary>
				public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
				{

					private const string _id = "OM1.47.7";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.47.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
				/// </summary>
				public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
				{

					private const string _id = "OM1.47.8";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.47.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
				/// </summary>
				public class OriginalText : HL7Base<OriginalText>
				{

					private const string _id = "OM1.47.9";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.47.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
				/// </summary>
				public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
				{

					private const string _id = "OM1.47.10";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.47.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
				/// </summary>
				public class SecondAlternateText : HL7Base<SecondAlternateText>
				{

					private const string _id = "OM1.47.11";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.47.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
				{

					private const string _id = "OM1.47.12";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.47.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
				/// </summary>
				public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
				{

					private const string _id = "OM1.47.13";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.47.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
				/// </summary>
				public class CodingSystemOid : HL7Base<CodingSystemOid>
				{

					private const string _id = "OM1.47.14";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.47.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class ValueSetOid : HL7Base<ValueSetOid>
				{

					private const string _id = "OM1.47.15";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.47.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
				/// </summary>
				public class ValueSetVersionId : HL7Base<ValueSetVersionId>
				{

					private const string _id = "OM1.47.16";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.47.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
				/// </summary>
				public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
				{

					private const string _id = "OM1.47.17";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.47.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
				{

					private const string _id = "OM1.47.18";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.47.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
				/// </summary>
				public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
				{

					private const string _id = "OM1.47.19";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.47.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
				/// </summary>
				public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
				{

					private const string _id = "OM1.47.20";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.47.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
				{

					private const string _id = "OM1.47.21";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.47.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
				/// </summary>
				public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
				{

					private const string _id = "OM1.47.22";
					public override string Id
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
			/// OM1.48 - This field defines if this test should be a specific event with no other tests to be performed with this test.  Refer to HL7 Table 0919  Exclusive Test in Chapter 2C, Code Tables, for valid values.  If not populated, the default value of "N" is assumed and  that this test can be included with any number of other tests.When D is specified for this field, using field OM1-49 determines how tests must be grouped together.  Tests within the same Diagnostic Service Sector may be on the same requisition, and therefore in the same message.
			/// </summary>
			public class ExclusiveTest : HL7Base<ExclusiveTest>
			{

				private const string _id = "OM1.48";
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
			/// OM1.49 - This field is the section of the diagnostic service where the observation was performed. If the study was performed by an outside service, the identification of that service should be recorded here. Refer to HL7 Table 0074  Diagnostic Service Section ID in Chapter 2C, Code Tables, for valid entries.  Same as OBR-24.
			/// </summary>
			public class DiagnosticServSectID : HL7Base<DiagnosticServSectID>
			{

				private const string _id = "OM1.49";
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
			/// OM1.50 - The species of living organism. This may include the common or scientific name, based on the coding system(s) used. SNOMED is the recommended coding system. If this field is not valued, a human is assumed. Refer to User-defined Table 0446 - Species Code in Chapter 2C, Code Tables, for suggested values.For example...L-80700Canine, NOSSNM3......L-80100BovineSNM3......L-80A00FelineSNM3....This field is a list of species or other taxonomic classification(s) to which the indicated specimen type may appropriately be applied for the indicated observation or test.  If this field is omitted the default meaning is that the test or observation is applicable to humans.  In a veterinary context if the test is applicable to any species, an appropriate code such as "Kingdom Animalia (organism)" should be used to avoid confusion with the meaning of human only.
			/// </summary>
			public class TaxonomicClassificationCode : HL7Base<TaxonomicClassificationCode>
			{

				private const string _id = "OM1.50";
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
				/// OM1.50.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
				/// </summary>
				public class Identifier : HL7Base<Identifier>
				{

					private const string _id = "OM1.50.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.50.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
				/// </summary>
				public class Text : HL7Base<Text>
				{

					private const string _id = "OM1.50.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.50.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
				/// </summary>
				public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
				{

					private const string _id = "OM1.50.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.50.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
				/// </summary>
				public class AlternateIdentifier : HL7Base<AlternateIdentifier>
				{

					private const string _id = "OM1.50.4";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.50.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
				/// </summary>
				public class AlternateText : HL7Base<AlternateText>
				{

					private const string _id = "OM1.50.5";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.50.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
				{

					private const string _id = "OM1.50.6";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.50.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
				/// </summary>
				public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
				{

					private const string _id = "OM1.50.7";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.50.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
				/// </summary>
				public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
				{

					private const string _id = "OM1.50.8";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.50.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
				/// </summary>
				public class OriginalText : HL7Base<OriginalText>
				{

					private const string _id = "OM1.50.9";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.50.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
				/// </summary>
				public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
				{

					private const string _id = "OM1.50.10";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.50.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
				/// </summary>
				public class SecondAlternateText : HL7Base<SecondAlternateText>
				{

					private const string _id = "OM1.50.11";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.50.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
				{

					private const string _id = "OM1.50.12";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.50.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
				/// </summary>
				public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
				{

					private const string _id = "OM1.50.13";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.50.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
				/// </summary>
				public class CodingSystemOid : HL7Base<CodingSystemOid>
				{

					private const string _id = "OM1.50.14";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.50.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class ValueSetOid : HL7Base<ValueSetOid>
				{

					private const string _id = "OM1.50.15";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.50.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
				/// </summary>
				public class ValueSetVersionId : HL7Base<ValueSetVersionId>
				{

					private const string _id = "OM1.50.16";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.50.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
				/// </summary>
				public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
				{

					private const string _id = "OM1.50.17";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.50.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
				{

					private const string _id = "OM1.50.18";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.50.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
				/// </summary>
				public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
				{

					private const string _id = "OM1.50.19";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.50.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
				/// </summary>
				public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
				{

					private const string _id = "OM1.50.20";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.50.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
				{

					private const string _id = "OM1.50.21";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// OM1.50.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
				/// </summary>
				public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
				{

					private const string _id = "OM1.50.22";
					public override string Id
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
			/// OM1.51 - This field contains any test aliases or synonyms for the name in the context of the ordering service.  These are alternative names, not associated with a particular coding system, by which the battery, test, or observation (e.g., measurement, test, diagnostic study, treatment, etc.) is known to users of the system.  Multiple names in this list are separated by repeat delimiters.
			/// </summary>
			public class OtherNames_ : HL7Base<OtherNames_>
			{

				private const string _id = "OM1.51";
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

		  }
	}
}

