using Newtonsoft.Json;
namespace HL7Parser
{
	public partial class Mappings {
		/// <summary>
		/// The SCH segment contains general information about the scheduled appointment.
		/// </summary>
		public class SCH {

			 public const string Id = "SCH";

						/// <summary>
			/// SCH.1 - This field contains the placer application's permanent identifier for the appointment request (and the scheduled appointment itself, when it has been confirmed as a booked slot by the filler application).  This is a composite field.The first component is a string that identifies an individual appointment request, or a booked appointment.  It is assigned by the placer application, and identifies an appointment request, and the subsequent scheduled appointment, uniquely among all such requests and/or booked appointments from a particular requesting application.  If SCH-1-Placer Appointment ID identifies a parent of a repeating schedule request, then the individual child scheduled appointments can be uniquely identified either by a new SCH-1-Placer Appointment ID or by SCH-23-Parent Placer Appointment ID plus an SCH-3-Occurrence Number.If a schedule request originates from a placer it MUST have a placer appointment ID.  If the filler sends responses, it may use the placer appointment ID and/or assign a filler appointment ID (which it would echo back to the placer to enable the placer application to associate the two).  If the placer appointment ID is not present, the filler appointment ID must be present and vice versa. 
			/// </summary>
			public class PlacerAppointmentId : HL7Base<PlacerAppointmentId>
			{

				private const string _id = "SCH.1";
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
				/// SCH.1.1 - The first component, entity identifier, is usually defined to be unique within the series of identifiers created by the assigning authority, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, "HD - hierarchic designator".
				/// </summary>
				public class EntityIdentifier : HL7Base<EntityIdentifier>
				{

					private const string _id = "SCH.1.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.1.2 - See Section 2.A.33.1, "Namespace ID (IS)" for definition. The component intentionally remains associated with the IS data type in v 2.7.The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363  Assigning Authority for suggested values.Note When the HD is used as a part of another data type, in this case as part of the EI data type, this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment. By site agreement, implementers may continue to use User-defined Table 0300  Namespace ID for the first component
				/// </summary>
				public class NamespaceId : HL7Base<NamespaceId>
				{

					private const string _id = "SCH.1.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.1.3 - See Section 2.A.33.2, "Universal ID (ST)" for definition.
				/// </summary>
				public class UniversalId : HL7Base<UniversalId>
				{

					private const string _id = "SCH.1.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.1.4 - Refer to HL7 Table 0301 - Universal ID Type for valid values. See Section 2.A.33.3, "Universal ID Type (ID)," for definition.
				/// </summary>
				public class UniversalIdType : HL7Base<UniversalIdType>
				{

					private const string _id = "SCH.1.4";
					public override string Id
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
			/// SCH.2 - This field contains the filler application's permanent identifier for the appointment request (and the scheduled appointment itself, when it has been confirmed as a booked slot by the filler application).  This is a composite field.  The first component is a string of up to fifteen characters that identifies an individual appointment request, or a booked appointment.  It is assigned by the filler application, and identifies an appointment request, and the subsequent scheduled appointment, uniquely among all such requests and/or booked appointments from a particular processing application.  If SCH-2-Filler Appointment ID identifies a parent of a repeating schedule request, then the individual child scheduled appointments can be uniquely identified either by a new SCH-2-Filler Appointment ID or by SCH-25-Parent Filler Appointment ID plus an SCH-3-Occurrence Number.
			/// </summary>
			public class FillerAppointmentId : HL7Base<FillerAppointmentId>
			{

				private const string _id = "SCH.2";
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
				/// SCH.2.1 - The first component, entity identifier, is usually defined to be unique within the series of identifiers created by the assigning authority, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, "HD - hierarchic designator".
				/// </summary>
				public class EntityIdentifier : HL7Base<EntityIdentifier>
				{

					private const string _id = "SCH.2.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.2.2 - See Section 2.A.33.1, "Namespace ID (IS)" for definition. The component intentionally remains associated with the IS data type in v 2.7.The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363  Assigning Authority for suggested values.Note When the HD is used as a part of another data type, in this case as part of the EI data type, this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment. By site agreement, implementers may continue to use User-defined Table 0300  Namespace ID for the first component
				/// </summary>
				public class NamespaceId : HL7Base<NamespaceId>
				{

					private const string _id = "SCH.2.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.2.3 - See Section 2.A.33.2, "Universal ID (ST)" for definition.
				/// </summary>
				public class UniversalId : HL7Base<UniversalId>
				{

					private const string _id = "SCH.2.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.2.4 - Refer to HL7 Table 0301 - Universal ID Type for valid values. See Section 2.A.33.3, "Universal ID Type (ID)," for definition.
				/// </summary>
				public class UniversalIdType : HL7Base<UniversalIdType>
				{

					private const string _id = "SCH.2.4";
					public override string Id
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
			/// SCH.3 - This field is used in conjunction with SCH-1-Placer Appointment ID and/or SCH-2-Filler Appointment ID to uniquely identify an individual occurrence (a child) of a parent repeating schedule appointment.This field is conditionally required.  If the transaction using this segment is intended to apply only to one occurrence of a repeating appointment, and an occurrence number is required to uniquely identify the child appointment (that is, the child does not have a separate and unique SCH-1-Placer Appointment ID or SCH-2-Filler Appointment ID), then this field is required.
			/// </summary>
			public class OccurrenceNumber : HL7Base<OccurrenceNumber>
			{

				private const string _id = "SCH.3";
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
			/// SCH.4 - This field contains a unique identifier for the Placer Group as referenced by the Placer application, the Filler application, or both. A Placer Group is a set of appointments grouped together by the placer application, and subsequently identified by the placer application and/or by the filler application.Within each of the two subcomponents, the first component is a string that identifies a group of appointment requests.  It is assigned by the Placer or Filler application, and it identifies an appointment group uniquely among all such groups of requests from a particular requesting application.
			/// </summary>
			public class PlacerGroupNumber : HL7Base<PlacerGroupNumber>
			{

				private const string _id = "SCH.4";
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
				/// SCH.4.1 - The first component, entity identifier, is usually defined to be unique within the series of identifiers created by the assigning authority, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, "HD - hierarchic designator".
				/// </summary>
				public class EntityIdentifier : HL7Base<EntityIdentifier>
				{

					private const string _id = "SCH.4.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.4.2 - See Section 2.A.33.1, "Namespace ID (IS)" for definition. The component intentionally remains associated with the IS data type in v 2.7.The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363  Assigning Authority for suggested values.Note When the HD is used as a part of another data type, in this case as part of the EI data type, this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment. By site agreement, implementers may continue to use User-defined Table 0300  Namespace ID for the first component
				/// </summary>
				public class NamespaceId : HL7Base<NamespaceId>
				{

					private const string _id = "SCH.4.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.4.3 - See Section 2.A.33.2, "Universal ID (ST)" for definition.
				/// </summary>
				public class UniversalId : HL7Base<UniversalId>
				{

					private const string _id = "SCH.4.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.4.4 - Refer to HL7 Table 0301 - Universal ID Type for valid values. See Section 2.A.33.3, "Universal ID Type (ID)," for definition.
				/// </summary>
				public class UniversalIdType : HL7Base<UniversalIdType>
				{

					private const string _id = "SCH.4.4";
					public override string Id
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
			/// SCH.5 - This field contains an identifier code for the schedule in which this appointment is (or will be) booked.  This field is provided for instances in which filler applications maintain multiple schedules, and when a particular resource or set of resources is controlled by more than one of those schedules.This field is provided on the SCH segment for informational purposes to applications fulfilling the placer, querying and auxiliary roles.
			/// </summary>
			public class ScheduleId : HL7Base<ScheduleId>
			{

				private const string _id = "SCH.5";
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
				/// SCH.5.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
				/// </summary>
				public class Identifier : HL7Base<Identifier>
				{

					private const string _id = "SCH.5.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.5.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
				/// </summary>
				public class Text : HL7Base<Text>
				{

					private const string _id = "SCH.5.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.5.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
				/// </summary>
				public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
				{

					private const string _id = "SCH.5.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.5.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
				/// </summary>
				public class AlternateIdentifier : HL7Base<AlternateIdentifier>
				{

					private const string _id = "SCH.5.4";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.5.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
				/// </summary>
				public class AlternateText : HL7Base<AlternateText>
				{

					private const string _id = "SCH.5.5";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.5.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
				{

					private const string _id = "SCH.5.6";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.5.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
				/// </summary>
				public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
				{

					private const string _id = "SCH.5.7";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.5.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
				/// </summary>
				public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
				{

					private const string _id = "SCH.5.8";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.5.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
				/// </summary>
				public class OriginalText : HL7Base<OriginalText>
				{

					private const string _id = "SCH.5.9";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.5.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
				/// </summary>
				public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
				{

					private const string _id = "SCH.5.10";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.5.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
				/// </summary>
				public class SecondAlternateText : HL7Base<SecondAlternateText>
				{

					private const string _id = "SCH.5.11";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.5.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
				{

					private const string _id = "SCH.5.12";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.5.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
				/// </summary>
				public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
				{

					private const string _id = "SCH.5.13";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.5.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
				/// </summary>
				public class CodingSystemOid : HL7Base<CodingSystemOid>
				{

					private const string _id = "SCH.5.14";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.5.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class ValueSetOid : HL7Base<ValueSetOid>
				{

					private const string _id = "SCH.5.15";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.5.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
				/// </summary>
				public class ValueSetVersionId : HL7Base<ValueSetVersionId>
				{

					private const string _id = "SCH.5.16";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.5.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
				/// </summary>
				public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
				{

					private const string _id = "SCH.5.17";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.5.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
				{

					private const string _id = "SCH.5.18";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.5.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
				/// </summary>
				public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
				{

					private const string _id = "SCH.5.19";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.5.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
				/// </summary>
				public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
				{

					private const string _id = "SCH.5.20";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.5.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
				{

					private const string _id = "SCH.5.21";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.5.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
				/// </summary>
				public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
				{

					private const string _id = "SCH.5.22";
					public override string Id
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
			/// SCH.6 - This field contains an identifier code for the reason that the notification event was triggered.  This field may contain a code describing the cancel reason, the delete reason, the discontinue reason, the add reason, the block reason or any other code describing the reason that a specific event will occur.This field should not have been made required but is retained as such for reasons of backwards compatibility.
			/// </summary>
			public class EventReason : HL7Base<EventReason>
			{

				private const string _id = "SCH.6";
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
				/// SCH.6.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
				/// </summary>
				public class Identifier : HL7Base<Identifier>
				{

					private const string _id = "SCH.6.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.6.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
				/// </summary>
				public class Text : HL7Base<Text>
				{

					private const string _id = "SCH.6.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.6.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
				/// </summary>
				public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
				{

					private const string _id = "SCH.6.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.6.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
				/// </summary>
				public class AlternateIdentifier : HL7Base<AlternateIdentifier>
				{

					private const string _id = "SCH.6.4";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.6.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
				/// </summary>
				public class AlternateText : HL7Base<AlternateText>
				{

					private const string _id = "SCH.6.5";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.6.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
				{

					private const string _id = "SCH.6.6";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.6.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
				/// </summary>
				public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
				{

					private const string _id = "SCH.6.7";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.6.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
				/// </summary>
				public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
				{

					private const string _id = "SCH.6.8";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.6.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
				/// </summary>
				public class OriginalText : HL7Base<OriginalText>
				{

					private const string _id = "SCH.6.9";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.6.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
				/// </summary>
				public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
				{

					private const string _id = "SCH.6.10";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.6.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
				/// </summary>
				public class SecondAlternateText : HL7Base<SecondAlternateText>
				{

					private const string _id = "SCH.6.11";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.6.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
				{

					private const string _id = "SCH.6.12";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.6.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
				/// </summary>
				public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
				{

					private const string _id = "SCH.6.13";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.6.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
				/// </summary>
				public class CodingSystemOid : HL7Base<CodingSystemOid>
				{

					private const string _id = "SCH.6.14";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.6.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class ValueSetOid : HL7Base<ValueSetOid>
				{

					private const string _id = "SCH.6.15";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.6.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
				/// </summary>
				public class ValueSetVersionId : HL7Base<ValueSetVersionId>
				{

					private const string _id = "SCH.6.16";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.6.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
				/// </summary>
				public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
				{

					private const string _id = "SCH.6.17";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.6.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
				{

					private const string _id = "SCH.6.18";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.6.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
				/// </summary>
				public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
				{

					private const string _id = "SCH.6.19";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.6.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
				/// </summary>
				public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
				{

					private const string _id = "SCH.6.20";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.6.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
				{

					private const string _id = "SCH.6.21";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.6.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
				/// </summary>
				public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
				{

					private const string _id = "SCH.6.22";
					public override string Id
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
			/// SCH.7 - This field contains an identifier code for the reason that the appointment is to take place.  This field may contain a Universal Service ID describing the observation/test/battery/procedure or other activity that is to take place during the requested appointment, similar to the Universal Service ID defined for the OBR segment in the Order Entry chapter (Chapter 4).  It may also contain a site-specific code describing a pre-defined set of reasons that an appointment may be set to occur.  This code can be based on local and/or universal codes.  The use of universal codes is recommended.  Refer to User-Defined Table 0276 - Appointment Reason Codes in Chapter 2C, Code Tables, for suggested values.
			/// </summary>
			public class AppointmentReason : HL7Base<AppointmentReason>
			{

				private const string _id = "SCH.7";
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
				/// SCH.7.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
				/// </summary>
				public class Identifier : HL7Base<Identifier>
				{

					private const string _id = "SCH.7.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.7.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
				/// </summary>
				public class Text : HL7Base<Text>
				{

					private const string _id = "SCH.7.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.7.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
				/// </summary>
				public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
				{

					private const string _id = "SCH.7.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.7.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
				/// </summary>
				public class AlternateIdentifier : HL7Base<AlternateIdentifier>
				{

					private const string _id = "SCH.7.4";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.7.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
				/// </summary>
				public class AlternateText : HL7Base<AlternateText>
				{

					private const string _id = "SCH.7.5";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.7.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
				{

					private const string _id = "SCH.7.6";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.7.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
				/// </summary>
				public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
				{

					private const string _id = "SCH.7.7";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.7.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
				/// </summary>
				public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
				{

					private const string _id = "SCH.7.8";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.7.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
				/// </summary>
				public class OriginalText : HL7Base<OriginalText>
				{

					private const string _id = "SCH.7.9";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.7.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
				/// </summary>
				public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
				{

					private const string _id = "SCH.7.10";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.7.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
				/// </summary>
				public class SecondAlternateText : HL7Base<SecondAlternateText>
				{

					private const string _id = "SCH.7.11";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.7.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
				{

					private const string _id = "SCH.7.12";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.7.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
				/// </summary>
				public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
				{

					private const string _id = "SCH.7.13";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.7.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
				/// </summary>
				public class CodingSystemOid : HL7Base<CodingSystemOid>
				{

					private const string _id = "SCH.7.14";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.7.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class ValueSetOid : HL7Base<ValueSetOid>
				{

					private const string _id = "SCH.7.15";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.7.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
				/// </summary>
				public class ValueSetVersionId : HL7Base<ValueSetVersionId>
				{

					private const string _id = "SCH.7.16";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.7.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
				/// </summary>
				public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
				{

					private const string _id = "SCH.7.17";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.7.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
				{

					private const string _id = "SCH.7.18";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.7.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
				/// </summary>
				public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
				{

					private const string _id = "SCH.7.19";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.7.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
				/// </summary>
				public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
				{

					private const string _id = "SCH.7.20";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.7.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
				{

					private const string _id = "SCH.7.21";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.7.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
				/// </summary>
				public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
				{

					private const string _id = "SCH.7.22";
					public override string Id
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
			/// SCH.8 - This field contains the identifier code for the type of appointment.  Refer to User-Defined Table 0277 - Appointment Type Codes in Chapter 2C, Code Tables, for suggested values.
			/// </summary>
			public class AppointmentType : HL7Base<AppointmentType>
			{

				private const string _id = "SCH.8";
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
				/// SCH.8.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
				/// </summary>
				public class Identifier : HL7Base<Identifier>
				{

					private const string _id = "SCH.8.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.8.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
				/// </summary>
				public class Text : HL7Base<Text>
				{

					private const string _id = "SCH.8.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.8.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
				/// </summary>
				public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
				{

					private const string _id = "SCH.8.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.8.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
				/// </summary>
				public class AlternateIdentifier : HL7Base<AlternateIdentifier>
				{

					private const string _id = "SCH.8.4";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.8.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
				/// </summary>
				public class AlternateText : HL7Base<AlternateText>
				{

					private const string _id = "SCH.8.5";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.8.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
				{

					private const string _id = "SCH.8.6";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.8.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
				/// </summary>
				public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
				{

					private const string _id = "SCH.8.7";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.8.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
				/// </summary>
				public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
				{

					private const string _id = "SCH.8.8";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.8.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
				/// </summary>
				public class OriginalText : HL7Base<OriginalText>
				{

					private const string _id = "SCH.8.9";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.8.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
				/// </summary>
				public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
				{

					private const string _id = "SCH.8.10";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.8.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
				/// </summary>
				public class SecondAlternateText : HL7Base<SecondAlternateText>
				{

					private const string _id = "SCH.8.11";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.8.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
				{

					private const string _id = "SCH.8.12";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.8.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
				/// </summary>
				public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
				{

					private const string _id = "SCH.8.13";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.8.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
				/// </summary>
				public class CodingSystemOid : HL7Base<CodingSystemOid>
				{

					private const string _id = "SCH.8.14";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.8.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class ValueSetOid : HL7Base<ValueSetOid>
				{

					private const string _id = "SCH.8.15";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.8.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
				/// </summary>
				public class ValueSetVersionId : HL7Base<ValueSetVersionId>
				{

					private const string _id = "SCH.8.16";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.8.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
				/// </summary>
				public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
				{

					private const string _id = "SCH.8.17";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.8.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
				{

					private const string _id = "SCH.8.18";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.8.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
				/// </summary>
				public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
				{

					private const string _id = "SCH.8.19";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.8.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
				/// </summary>
				public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
				{

					private const string _id = "SCH.8.20";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.8.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
				{

					private const string _id = "SCH.8.21";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.8.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
				/// </summary>
				public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
				{

					private const string _id = "SCH.8.22";
					public override string Id
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
			/// SCH.9 - As of version 2.5, this field was retained for backward compatibility only and withdrawn and removed as of v2.7. Refer to the TQ1 segment described in Chapter 4.
			/// </summary>
			public class AppointmentDuration : HL7Base<AppointmentDuration>
			{

				private const string _id = "SCH.9";
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
			/// SCH.10 - As of version 2.5, this field is retained for backward compatibility only. Refer to the TQ1 segment described in Chapter 4.This field contains a code describing the units of time used for expressing the ARQ-9-Appointment Duration field.  This field should be valued according to the recommendations in Chapters 2 and 7.  If this component is not valued, the ISO base unit of seconds (code "s") is assumed.  Refer to Chapter 7, Figures 7-6 through 7-9, for a list of ISO and ANSI+ unit codes.As of v2.6, the known applicable external coding systems include those in the table below. If the code set you are using is in this table, then you must use that designation.
			/// </summary>
			public class AppointmentDurationUnits : HL7Base<AppointmentDurationUnits>
			{

				private const string _id = "SCH.10";
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
				/// SCH.10.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CNE.2. Different coding schemes will have different elements here.Usage Note The identifier is required and must be a valid code.
				/// </summary>
				public class Identifier : HL7Base<Identifier>
				{

					private const string _id = "SCH.10.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.10.2 - The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression. This is the corresponding text assigned by the coding system to the identifier.Usage Note Text description of code is optional but its use should be encouraged since it makes messages easier to review for accuracy, especially during interface testing and debugging.
				/// </summary>
				public class Text : HL7Base<Text>
				{

					private const string _id = "SCH.10.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.10.3 - The third component contains the code for the name of the coding system from which the value in CNE.1 is obtained. Refer to HL7 Table 0396 - Coding Systems in Chapter 2C, Code Tables, for valid values. Each coding system is assigned a unique identifier.As of v2.7 this component is required when CNE.1 is populated and CNE.14 is not populated. Both CNE.3 and CNE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CNE.3 and/or CNE.14 the Coding System component or the Coding System OID for the tuple.The combination of the identifier and name of coding system represent a unique concept for a data item.Some organizations that publish code sets author more than one. The coding system, then, to be unique, is a concatenation of the name of the coding authority organization and the name of its code set or table. When an HL7 table is used for a CNE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. Similarly, ISO tables will be named ISOnnnn, where nnnn is the ISO table number.Usage Note The following statement is retained for backward compatibility as of v2.7. Best practice would recommend that this component always be populated. However, if the field narrative explicitly states "Refer to HL7 Table nnnn for valid values, and, if the sending and receiving systems are HL7 compliant, the coding system would be known from the standard.  This would be similar to a field with an ID data type, except that there is a second triplet in which to express an alternate code.
				/// </summary>
				public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
				{

					private const string _id = "SCH.10.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.10.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CNE.1 Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
				/// </summary>
				public class AlternateIdentifier : HL7Base<AlternateIdentifier>
				{

					private const string _id = "SCH.10.4";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.10.5 - The descriptive or textual name of the alternate identifier. Analogous to CNE.2 Text. Usage Notes If present, CNE.5 obeys the same rules of use and interpretation as described for CNE.2. 
				/// </summary>
				public class AlternateText : HL7Base<AlternateText>
				{

					private const string _id = "SCH.10.5";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.10.6 - Identifies the coding scheme being used in the alternate identifier component.  Analogous to  CNE.3 Name of Coding System.  Refer to HL7 Table 0396 - Coding Systems in Chapter 2C, Code Tables, for valid values.As of v2.7 this component is required when CNE.4 is populated and CNE.17 is not populated. Both CNE.6 and CNE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CNE.6 and/or CNE.17, the "Coding System" component or the "Coding System OID", for the tuple.Usage Notes If present, CNE.6 obeys the same rules of use and interpretation as described for CNE.3.
				/// </summary>
				public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
				{

					private const string _id = "SCH.10.6";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.10.7 - The version ID for the coding system identified by CNE.3. It belongs conceptually to components 1-3 and appears here only for reasons of backward compatibility.Usage Note If the coding system is any system other than an "HL7 coding system," version ID must be valued with an actual version ID. If the coding system is "HL7 coding system," version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. Text description of code is optional but its use should be encouraged since it makes messages easier to review for accuracy, especially during interface testing and debugging.
				/// </summary>
				public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
				{

					private const string _id = "SCH.10.7";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.10.8 - The version ID for the coding system identified by CNE.6.  It belongs conceptually to the group of Alternate components (see note 2.A.1) and appears here only for reasons of backward compatibility. Analogous to CNE.7 Coding System Version ID.Usage Notes If present, CNE.8 obeys the same rules of use and interpretation as described for CNE.7.
				/// </summary>
				public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
				{

					private const string _id = "SCH.10.8";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.10.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
				/// </summary>
				public class OriginalText : HL7Base<OriginalText>
				{

					private const string _id = "SCH.10.9";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.10.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CN-1 Identifier.
				/// </summary>
				public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
				{

					private const string _id = "SCH.10.10";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.10.11 - The descriptive or textual name of the Second Alternate Identifier. Analogous to CNE.2 Text.
				/// </summary>
				public class SecondAlternateText : HL7Base<SecondAlternateText>
				{

					private const string _id = "SCH.10.11";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.10.12 - Identifies the coding scheme being used in the Second Alternate Identifier component. Analogous to CNE.3 Name of Coding System.  Refer to HL7 Table 0396 - Coding Systems in Chapter 2C, Code Tables, for valid values.As of v2.7 this component is required when CNE.10 is populated and CNE.20 is not populated. Both CNE.12 and CNE.20 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CNE.12 and/or CNE.20, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
				{

					private const string _id = "SCH.10.12";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.10.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CNE.7 Coding System Version ID.
				/// </summary>
				public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
				{

					private const string _id = "SCH.10.13";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.10.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CNE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CNE.1 is populated and CNE.3 is not populated. Both CNE.3 and CNE.14 may be populated.
				/// </summary>
				public class CodingSystemOid : HL7Base<CodingSystemOid>
				{

					private const string _id = "SCH.10.14";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.10.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CNE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class ValueSetOid : HL7Base<ValueSetOid>
				{

					private const string _id = "SCH.10.15";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.10.16 - This component carries the version for the value set identified by CNE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CNE.15 is populated.
				/// </summary>
				public class ValueSetVersionId : HL7Base<ValueSetVersionId>
				{

					private const string _id = "SCH.10.16";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.10.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CNE.6. Analogous to CNE.14 OID for Coding System. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CNE.4 is populated and CNE.6 is not populated. Both CNE.6 and CNE.17 may be populated.
				/// </summary>
				public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
				{

					private const string _id = "SCH.10.17";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.10.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CNE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
				{

					private const string _id = "SCH.10.18";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.10.19 - This component carries the version for the value set identified by CNE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CNE.18 is populated.
				/// </summary>
				public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
				{

					private const string _id = "SCH.10.19";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.10.20 - This component contains the ISO Object Identifier (OID) from which the value in CNE.12 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined numbers, the OID registered in the HL7 OID registry should be used. This component is required when CNE.4 is populated and neither CNE.6 nor CNE.18 is populated. In short either the CNE.6 or the CNE.14 or CNE.17 must be populated when CNE.4 is populated.
				/// </summary>
				public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
				{

					private const string _id = "SCH.10.20";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.10.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CNE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
				{

					private const string _id = "SCH.10.21";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.10.22 - This component carries the version for the value set identified by CNE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CNE.21 is populated.
				/// </summary>
				public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
				{

					private const string _id = "SCH.10.22";
					public override string Id
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
			/// SCH.11 - As of version 2.5, this field was retained for backward compatibility only and withdrawn and removed as of v2.7. Refer to the TQ1 segment described in Chapter 4.
			/// </summary>
			public class AppointmentTimingQuantity : HL7Base<AppointmentTimingQuantity>
			{

				private const string _id = "SCH.11";
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
			/// SCH.12 - This field identifies the person responsible for requesting the scheduling of a requested appointment.  Most often, this person will be the same person responsible for executing the appointment.
			/// </summary>
			public class PlacerContactPerson : HL7Base<PlacerContactPerson>
			{

				private const string _id = "SCH.12";
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
				/// SCH.12.1 - This component carries the Person Identifier itself. XCN.1, in conjunction with XCN.9 uniquely identifies the entity/person. XCN.1 is required if XCN.2 is not populated. Both may be populated. 
				/// </summary>
				public class PersonIdentifier : HL7Base<PersonIdentifier>
				{

					private const string _id = "SCH.12.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.12.2 - This component allows full specification of the surname of a person. Where appropriate, it differentiates the person's own surname from that of the person's partner or spouse, in cases where the person's name may contain elements from either name. It also permits messages to distinguish the surname prefix (such as "van" or "de") from the surname root. See section 2.A.30, "FN - family name".XCN.2 is required if XCN.1 is not populated. Both may be populated.
				/// </summary>
				public class FamilyName : HL7Base<FamilyName>
				{

					private const string _id = "SCH.12.2";
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
					/// SCH.12.2.1 - The atomic element of the person's family name. In most Western usage, this is the person's last name.
					/// </summary>
					public class Surname : HL7Base<Surname>
					{

						private const string _id = "SCH.12.2.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.2.2 - Internationalization usage for Germanic languages. This component is optional. An example of a surname prefix is the "van" in "Ludwig van Beethoven". Since the surname prefix doesn't sort completely alphabetically, it is reasonable to specify it as a separate sub-component of the PN and extended PN data types (XPN and XCN).Note Subcomponents own surname prefix, own surname, surname prefix from partner/spouse and surname from partner/spouse decompose complex Germanic names such as Martha de Mum-van Beethoven. If these subcomponents are valued, the surname subcomponent should still be fully valued for backward compatibility, i.e., de Mum-van Beethoven&de&Mum&van&Beethoven.Also, for clarity, the last name prefix has been renamed to own surname prefix.
					/// </summary>
					public class OwnSurnamePrefix : HL7Base<OwnSurnamePrefix>
					{

						private const string _id = "SCH.12.2.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.2.3 - The portion of the surname (in most Western usage, the last name) that is derived from the person's own surname, as distinguished from any portion that is derived from the surname of the person's partner or spouse. This component is optional.If the person's surname has legally changed to become (or incorporate) the surname of the person's partner or spouse, this is the person's surname immediately prior to such change. Often this is the person's "maiden name".
					/// </summary>
					public class OwnSurname : HL7Base<OwnSurname>
					{

						private const string _id = "SCH.12.2.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.2.4 - Internationalization usage for Germanic languages. This component is optional. An example of a surname prefix is the van in "Ludwig van Beethoven". Since the surname prefix doesn't sort completely alphabetically, it is reasonable to specify it as a separate sub-component of the PN and extended PN data types (XPN and XCN). Note Subcomponents own surname prefix, own surname, surname prefix from partner/spouse and surname from partner/spouse decompose complex Germanic names such as Martha de Mum-van Beethoven. If these subcomponents are valued, the surname subcomponent should still be fully valued for backward compatibility, i.e., de Mum-van Beethoven&de&Mum&van&Beethoven.Also, for clarity, the last name prefix has been renamed to own surname prefix.
					/// </summary>
					public class SurnamePrefixFromPartnerSpouse : HL7Base<SurnamePrefixFromPartnerSpouse>
					{

						private const string _id = "SCH.12.2.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.2.5 - The portion of the person's surname (in most Western usage, the last name) that is derived from the surname of the person's partner or spouse, as distinguished from the part derived from the person's own surname. This component is optional.If no portion of the person's surname is derived from the surname of the person's partner or spouse, this component is not valued. Otherwise, if the surname of the partner or spouse has legally changed to become (or incorporate) the person's surname, this is the surname of the partner or spouse immediately prior to such change.
					/// </summary>
					public class SurnameFromPartnerSpouse : HL7Base<SurnameFromPartnerSpouse>
					{

						private const string _id = "SCH.12.2.5";
						public override string Id
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
				/// SCH.12.3 - First name.
				/// </summary>
				public class GivenName : HL7Base<GivenName>
				{

					private const string _id = "SCH.12.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.12.4 - Multiple middle names may be included by separating them with spaces.
				/// </summary>
				public class SecondAndFurtherGivenNamesOrInitialsThereof : HL7Base<SecondAndFurtherGivenNamesOrInitialsThereof>
				{

					private const string _id = "SCH.12.4";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.12.5 - Used to specify a name suffix (e.g., Jr. or III).
				/// </summary>
				public class SuffixegJrOrIii : HL7Base<SuffixegJrOrIii>
				{

					private const string _id = "SCH.12.5";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.12.6 - Used to specify a name prefix (e.g., Dr.).
				/// </summary>
				public class PrefixegDr : HL7Base<PrefixegDr>
				{

					private const string _id = "SCH.12.6";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.12.7 - Attention The XCN-7 component was deprecated as of v2.5 and the detail was withdrawn and removed from the standard as of v27.. Refer to XCN.21 Professional Suffix.
				/// </summary>
				public class DegreeegMd : HL7Base<DegreeegMd>
				{

					private const string _id = "SCH.12.7";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.12.8 - Attention Retained for backwards compatibility only as of v 2.7. The reader is referred to XCN.9 instead.User-defined Table 0297  CN ID source is used as the HL7 identifier for the user-defined table of values for this component. Used to delineate the first component.
				/// </summary>
				public class SourceTable : HL7Base<SourceTable>
				{

					private const string _id = "SCH.12.8";
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
					/// SCH.12.8.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "SCH.12.8.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.8.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "SCH.12.8.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.8.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "SCH.12.8.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.8.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "SCH.12.8.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.8.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "SCH.12.8.5";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.8.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "SCH.12.8.6";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.8.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "SCH.12.8.7";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.8.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "SCH.12.8.8";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.8.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "SCH.12.8.9";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.8.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "SCH.12.8.10";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.8.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "SCH.12.8.11";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.8.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "SCH.12.8.12";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.8.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "SCH.12.8.13";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.8.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "SCH.12.8.14";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.8.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "SCH.12.8.15";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.8.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "SCH.12.8.16";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.8.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "SCH.12.8.17";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.8.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "SCH.12.8.18";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.8.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "SCH.12.8.19";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.8.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "SCH.12.8.20";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.8.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "SCH.12.8.21";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.8.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "SCH.12.8.22";
						public override string Id
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
				/// SCH.12.9 - The assigning authority is a unique identifier of the system (or organization or agency of department) that creates the data. User-defined Table 0363  Assigning Authority is used as the HL7 identifier for the user-defined table of values for the first sub-component of the HD component, namespace ID.As of v 2.7, the Assigning Authority is conditional. It is required if XCN.1 is populated and neither XCN.22 nor XCN.23 are populated. All 3 components may be populated. No assumptions can be safely made based on position or sequence. Best practice is to send an OID in this component when populated.The reader is referred to XCN.22 and XCN.23 if there is a need to transmit values with semantic meaning for an assigning jurisdiction or assigning department or agency in addition to, or instead of, an assigning authority. However, all 3 components may be valued.  If, in so doing, it is discovered that the values in XCN.22 and/or XCN.23 conflict with XCN.9, the user would look to the Message Profile or other implementation agreement for a statement as to which takes precedence.Note When the HD data type is used in a given segment as a component of a field of another data type, User-defined Table 0300 - Namespace ID (referenced by the first sub-component of the HD component) may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.By site agreement, implementors may continue to use User-defined Table 0300  Namespace ID for the first sub-component.
				/// </summary>
				public class AssigningAuthority : HL7Base<AssigningAuthority>
				{

					private const string _id = "SCH.12.9";
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
					/// SCH.12.9.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
					/// </summary>
					public class NamespaceId : HL7Base<NamespaceId>
					{

						private const string _id = "SCH.12.9.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.9.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
					/// </summary>
					public class UniversalId : HL7Base<UniversalId>
					{

						private const string _id = "SCH.12.9.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.9.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
					/// </summary>
					public class UniversalIdType : HL7Base<UniversalIdType>
					{

						private const string _id = "SCH.12.9.3";
						public override string Id
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
				/// SCH.12.10 - A code that represents the type of name. Refer to HL7 Table 0200 - Name Type for valid values. See Section 2.A.89.7, "Name Type Code (ID)".As of v 2.7, XCN.10 is conditional. It is required if XCN.2 is populated.
				/// </summary>
				public class NameTypeCode : HL7Base<NameTypeCode>
				{

					private const string _id = "SCH.12.10";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.12.11 - This component contains the digit, or digits, exclusive of the identifier in XCN.1, calculated by applying an algorithm to all or some of the digits in the number, which may be used to test validity of the non-check-digit identifier.
				/// </summary>
				public class IdentifierCheckDigit : HL7Base<IdentifierCheckDigit>
				{

					private const string _id = "SCH.12.11";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.12.12 - Contains the code identifying the check digit scheme employed.Refer to HL7 Table 0061 - Check Digit Scheme for valid values.
				/// </summary>
				public class CheckDigitScheme : HL7Base<CheckDigitScheme>
				{

					private const string _id = "SCH.12.12";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.12.13 - A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the assigning authority component. Refer to HL7 Table 0203 - Identifier Type for suggested values.As of v 2.7, XCN.13 is conditional. It is required if XCN.1 is populated.
				/// </summary>
				public class IdentifierTypeCode : HL7Base<IdentifierTypeCode>
				{

					private const string _id = "SCH.12.13";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.12.14 - The place or location identifier where the identifier was first assigned to the person. This component is not an inherent part of the identifier but rather part of the history of the identifier as part of this data type, its existence is a convenience for certain intercommunicating systems.Note When the HD data type is used in a given segment as a component of a field of another data type, User-defined Table 0300 - Namespace ID (referenced by the first sub-component of the HD component) may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
				/// </summary>
				public class AssigningFacility : HL7Base<AssigningFacility>
				{

					private const string _id = "SCH.12.14";
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
					/// SCH.12.14.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
					/// </summary>
					public class NamespaceId : HL7Base<NamespaceId>
					{

						private const string _id = "SCH.12.14.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.14.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
					/// </summary>
					public class UniversalId : HL7Base<UniversalId>
					{

						private const string _id = "SCH.12.14.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.14.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
					/// </summary>
					public class UniversalIdType : HL7Base<UniversalIdType>
					{

						private const string _id = "SCH.12.14.3";
						public override string Id
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
				/// SCH.12.15 - Different name/address types and representations of the same name/address should be described by repeating of this field, with different values of the name/address type and/or name/address representation component.Note This new component remains in alphabetic representation with each repetition of the field using these data types. I.e., even though the name may be represented in an ideographic character set, this component will remain represented in an alphabetic character set.Refer to HL7 Table 0465  Name/address Representation for valid values.In general this component provides an indication of the representation provided by the data item. It does not necessarily specify the character sets used. Thus, even though the representation might provide an indication of what to expect, the sender is still free to encode the contents using whatever character set is desired. This component provides only hints for the receiver, so it can make choices regarding what it has been sent and what it is capable of displaying.
				/// </summary>
				public class NameRepresentationCode : HL7Base<NameRepresentationCode>
				{

					private const string _id = "SCH.12.15";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.12.16 - This component is used to designate the context in which a name is used. The main use case is in Australian healthcare for indigenous patients who prefer to use different names when attending different healthcare institutions. Another use case occurs in the US where health practitioners can be licensed under slightly different names and the reporting of the correct name is vital for administrative purposes. Refer to User-defined Table 0448  Name Context for suggested values.
				/// </summary>
				public class NameContext : HL7Base<NameContext>
				{

					private const string _id = "SCH.12.16";
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
					/// SCH.12.16.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "SCH.12.16.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.16.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "SCH.12.16.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.16.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "SCH.12.16.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.16.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "SCH.12.16.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.16.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "SCH.12.16.5";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.16.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "SCH.12.16.6";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.16.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "SCH.12.16.7";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.16.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "SCH.12.16.8";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.16.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "SCH.12.16.9";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.16.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "SCH.12.16.10";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.16.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "SCH.12.16.11";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.16.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "SCH.12.16.12";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.16.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "SCH.12.16.13";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.16.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "SCH.12.16.14";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.16.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "SCH.12.16.15";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.16.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "SCH.12.16.16";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.16.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "SCH.12.16.17";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.16.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "SCH.12.16.18";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.16.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "SCH.12.16.19";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.16.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "SCH.12.16.20";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.16.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "SCH.12.16.21";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.16.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "SCH.12.16.22";
						public override string Id
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
				/// SCH.12.17 - Attention The XCN.17 component was deprecated as of v2.5 and the detail was withdrawn and removed from the standard as of v 2.7. Refer to XCN.19 Effective Date and XCN.20 Expiration Date instead.This component contains the start and end date/times that define the period during which this name was valid.
				/// </summary>
				public class NameValidityRange : HL7Base<NameValidityRange>
				{

					private const string _id = "SCH.12.17";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.12.18 - A code that represents the preferred display order of the components of this person name. Refer to HL7 Table 0444 - Name Assembly Order for valid values.
				/// </summary>
				public class NameAssemblyOrder : HL7Base<NameAssemblyOrder>
				{

					private const string _id = "SCH.12.18";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.12.19 - The first date, if known, on which the person name is valid and active.
				/// </summary>
				public class EffectiveDate : HL7Base<EffectiveDate>
				{

					private const string _id = "SCH.12.19";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.12.20 - The last date, if known, on which the person name is valid and active.
				/// </summary>
				public class ExpirationDate : HL7Base<ExpirationDate>
				{

					private const string _id = "SCH.12.20";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.12.21 - Used to specify an abbreviation, or a string of abbreviations denoting qualifications that support the persons profession, (e.g., licenses, certificates, degrees, affiliations with professional societies, etc.). The Professional Suffix normally follows the Family Name when the Person Name is used for display purposes. Please note that this component is an unformatted string and is used for display purposes only. Detailed information regarding the contents of Professional Suffix is obtained using appropriate segments in Chapter 15, "Personnel Management".
				/// </summary>
				public class ProfessionalSuffix : HL7Base<ProfessionalSuffix>
				{

					private const string _id = "SCH.12.21";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.12.22 - The geo-political body that assigned the identifier in XCN.1. As of v 2.7, the Assigning Jurisdiction is conditional. It is required if XCN.1 is populated and neither XCN.9 nor XCN.23 are populated. All 3 components may be populated. The reader is referred to XCN.9 if there is a need to transmit this information as an OID.
				/// </summary>
				public class AssigningJurisdiction : HL7Base<AssigningJurisdiction>
				{

					private const string _id = "SCH.12.22";
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
					/// SCH.12.22.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "SCH.12.22.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.22.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "SCH.12.22.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.22.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "SCH.12.22.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.22.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "SCH.12.22.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.22.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "SCH.12.22.5";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.22.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "SCH.12.22.6";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.22.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "SCH.12.22.7";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.22.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "SCH.12.22.8";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.22.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "SCH.12.22.9";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.22.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "SCH.12.22.10";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.22.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "SCH.12.22.11";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.22.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "SCH.12.22.12";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.22.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "SCH.12.22.13";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.22.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "SCH.12.22.14";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.22.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "SCH.12.22.15";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.22.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "SCH.12.22.16";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.22.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "SCH.12.22.17";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.22.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "SCH.12.22.18";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.22.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "SCH.12.22.19";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.22.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "SCH.12.22.20";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.22.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "SCH.12.22.21";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.22.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "SCH.12.22.22";
						public override string Id
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
				/// SCH.12.23 - The agency or department that assigned the identifier in XCN.1.As of v 2.7, the Assigning Jurisdiction is conditional. It is required if XCN.1 is populated and neither XCN.9 nor XCN.22 are populated. All 3 components may be populated. The reader is referred to XCN.9 if there is a need to transmit this information as an OID.
				/// </summary>
				public class AssigningAgencyOrDepartment : HL7Base<AssigningAgencyOrDepartment>
				{

					private const string _id = "SCH.12.23";
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
					/// SCH.12.23.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "SCH.12.23.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.23.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "SCH.12.23.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.23.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "SCH.12.23.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.23.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "SCH.12.23.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.23.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "SCH.12.23.5";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.23.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "SCH.12.23.6";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.23.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "SCH.12.23.7";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.23.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "SCH.12.23.8";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.23.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "SCH.12.23.9";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.23.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "SCH.12.23.10";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.23.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "SCH.12.23.11";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.23.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "SCH.12.23.12";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.23.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "SCH.12.23.13";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.23.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "SCH.12.23.14";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.23.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "SCH.12.23.15";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.23.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "SCH.12.23.16";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.23.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "SCH.12.23.17";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.23.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "SCH.12.23.18";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.23.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "SCH.12.23.19";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.23.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "SCH.12.23.20";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.23.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "SCH.12.23.21";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.12.23.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "SCH.12.23.22";
						public override string Id
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
				/// SCH.12.24 - This component is used to communicate a version code that may be assigned to the value given in XCN.1 Person Identifier.
				/// </summary>
				public class SecurityCheck : HL7Base<SecurityCheck>
				{

					private const string _id = "SCH.12.24";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.12.25 - This component is used to transmit information intended to validate the veracity of the supplied identifier or the presenter of the identifier. For example, this component may be used to ensure that the presenter of a credit card is an authorized user of that card.Refer to HL7 Table 0904 - Security Check Scheme for valid values
				/// </summary>
				public class SecurityCheckScheme : HL7Base<SecurityCheckScheme>
				{

					private const string _id = "SCH.12.25";
					public override string Id
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
			/// SCH.13 - This field contains the phone number used to contact the SCH-12-Placer Contact Person.
			/// </summary>
			public class PlacerContactPhoneNumber : HL7Base<PlacerContactPhoneNumber>
			{

				private const string _id = "SCH.13";
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
				/// SCH.13.1 - Attention The XTN-1 component was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v2.6.
				/// </summary>
				public class TelephoneNumber : HL7Base<TelephoneNumber>
				{

					private const string _id = "SCH.13.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.13.2 - A code that represents a specific use of a telecommunication number. Refer to HL7 Table 0201 - Telecommunication Use Code for valid values. This component along with XTN.3 describes the nature of the telecommunication data that follows. Best practice requires the population of XTN.2 when XTN.4 or XTN.7 is populated. 
				/// </summary>
				public class TelecommunicationUseCode : HL7Base<TelecommunicationUseCode>
				{

					private const string _id = "SCH.13.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.13.3 - A code that represents the type of telecommunication equipment. Refer to HL7 Table 0202 - Telecommunication Equipment Type for valid values. This component along with XTN.2 describes the nature of the telecommunication data that follows and is necessary to accurately interpret it.
				/// </summary>
				public class TelecommunicationEquipmentType : HL7Base<TelecommunicationEquipmentType>
				{

					private const string _id = "SCH.13.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.13.4 - This component is required if, and only allowed if, XTN.7 or XTN.12 are not populated.  Note If any of the HL7 delimiters are found in the Communication Address, such as , the appropriate HL7 escape sequence SHALL be used when encoding an Internet address (see Chapter 2, "Control", section 2.7.1, "Formatting Codes").
				/// </summary>
				public class CommunicationAddress : HL7Base<CommunicationAddress>
				{

					private const string _id = "SCH.13.4";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.13.5 - The numeric code assigned by the International Telecommunication Union in standard E.164 to access telephone services in another country.  For example, "+1" is the country code for the United States, "+49" is the code for Germany.
				/// </summary>
				public class CountryCode : HL7Base<CountryCode>
				{

					private const string _id = "SCH.13.5";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.13.6 - The numeric code to access telephone services in another area/city within a country. This number historically needs not be dialed if the caller is located in the same area/city as the phone number of the called party.The use and size of area/city codes is however country specific some countries do not use area/city codes, or the use of area/city codes may be mandatory when dialing, or area/city codes may be used to group phone numbers based on other criteria than geographic location, such as cell-phone area/city-codes, or free information numbers (e.g., 800 numbers).Most countries have a prefix for Area/City codes which only has to be dialed if one doesn't use a country code. This prefix (mostly "0", sometimes "9") should be omitted from the content of this field. If the prefix for the Area/Code is also mandatory if one uses the country code (e.g., in Italy) then this field should also contain the prefix.
				/// </summary>
				public class AreaCityCode : HL7Base<AreaCityCode>
				{

					private const string _id = "SCH.13.6";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.13.7 - The numeric code used to contact the called party, exclusive of country and area/city codes. The Local Number is required when, and allowed only if, XTN.4 and XTN.12 are not populated. The size of the Local Number is country specific.Note that the Local Number does not include the numeric codes that have to be dialed once a connection has been established. Examples include (automated) organizational phone systems which allow external callers to dial additional numeric codes. These additional numeric codes should be specified as an extension.
				/// </summary>
				public class LocalNumber : HL7Base<LocalNumber>
				{

					private const string _id = "SCH.13.7";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.13.8 - The numeric code to contact the called party used within an organization, e.g., the number used if both caller and called party are located within the same organization. The extension is often the same as the last few digits of the Local Number. The use of extensions is country and site specific, and may depend on the type of phone system (PBX) used by the organization.
				/// </summary>
				public class Extension : HL7Base<Extension>
				{

					private const string _id = "SCH.13.8";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.13.9 - Contains comments with respect to the telephone number.Example Do not use after 5PM
				/// </summary>
				public class AnyText : HL7Base<AnyText>
				{

					private const string _id = "SCH.13.9";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.13.10 - The characters established within a companys internal telephone system network used as a prefix to the Extension component for internal dialing. Note that the use of Extension Prefix requires that the Extension component be valued and that digits, as well as special characters (e.g., *, #) may be used.
				/// </summary>
				public class ExtensionPrefix : HL7Base<ExtensionPrefix>
				{

					private const string _id = "SCH.13.10";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.13.11 - The characters established within a companys internal telephone system used in place of the (external) telephone number to facilitate calling because its length is shorter than that of the telephone number. Note that digits, as well as special characters (e.g., *, #) may be used.
				/// </summary>
				public class SpeedDialCode : HL7Base<SpeedDialCode>
				{

					private const string _id = "SCH.13.11";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.13.12 - An expression of the telephone number as an unparsable string. The Unformatted Telephone number is required when, and allowed only if, XTN.4 and XTN.7 are not populated.The phone number was entered as free text and sending system does not know how to parse it. Example 1-800-Dentist
				/// </summary>
				public class UnformattedTelephoneNumber : HL7Base<UnformattedTelephoneNumber>
				{

					private const string _id = "SCH.13.12";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.13.13 - The first date, if known, on which the telecommunication number is valid and active.
				/// </summary>
				public class EffectiveStartDate : HL7Base<EffectiveStartDate>
				{

					private const string _id = "SCH.13.13";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.13.14 - The last date, if known, on which the telecommunication number is valid and active.
				/// </summary>
				public class ExpirationDate : HL7Base<ExpirationDate>
				{

					private const string _id = "SCH.13.14";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.13.15 - Indicates why this contact number/e-mail was marked as "ended".  Refer to User-defined Table 0868  Telecommunication Expiration Reason for valid values.
				/// </summary>
				public class ExpirationReason : HL7Base<ExpirationReason>
				{

					private const string _id = "SCH.13.15";
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
					/// SCH.13.15.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "SCH.13.15.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.13.15.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "SCH.13.15.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.13.15.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "SCH.13.15.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.13.15.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "SCH.13.15.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.13.15.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "SCH.13.15.5";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.13.15.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "SCH.13.15.6";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.13.15.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "SCH.13.15.7";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.13.15.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "SCH.13.15.8";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.13.15.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "SCH.13.15.9";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.13.15.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "SCH.13.15.10";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.13.15.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "SCH.13.15.11";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.13.15.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "SCH.13.15.12";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.13.15.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "SCH.13.15.13";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.13.15.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "SCH.13.15.14";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.13.15.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "SCH.13.15.15";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.13.15.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "SCH.13.15.16";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.13.15.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "SCH.13.15.17";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.13.15.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "SCH.13.15.18";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.13.15.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "SCH.13.15.19";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.13.15.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "SCH.13.15.20";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.13.15.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "SCH.13.15.21";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.13.15.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "SCH.13.15.22";
						public override string Id
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
				/// SCH.13.16 - Indicates whether this information is considered sensitive or should be protected in some way. Refer to User-defined table 0618 - Protection Code for suggested values.The specific set of codes and appropriate handling of such telecommunications addresses will vary by jurisdiction and is subject to site-specific negotiation. For example, a provider address marked as 'unlisted' might not be printed in an internal address listing.
				/// </summary>
				public class ProtectionCode : HL7Base<ProtectionCode>
				{

					private const string _id = "SCH.13.16";
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
					/// SCH.13.16.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "SCH.13.16.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.13.16.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "SCH.13.16.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.13.16.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "SCH.13.16.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.13.16.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "SCH.13.16.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.13.16.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "SCH.13.16.5";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.13.16.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "SCH.13.16.6";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.13.16.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "SCH.13.16.7";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.13.16.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "SCH.13.16.8";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.13.16.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "SCH.13.16.9";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.13.16.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "SCH.13.16.10";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.13.16.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "SCH.13.16.11";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.13.16.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "SCH.13.16.12";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.13.16.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "SCH.13.16.13";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.13.16.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "SCH.13.16.14";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.13.16.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "SCH.13.16.15";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.13.16.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "SCH.13.16.16";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.13.16.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "SCH.13.16.17";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.13.16.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "SCH.13.16.18";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.13.16.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "SCH.13.16.19";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.13.16.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "SCH.13.16.20";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.13.16.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "SCH.13.16.21";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.13.16.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "SCH.13.16.22";
						public override string Id
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
				/// SCH.13.17 - A unique identifier for the phone number or e-mail address.This component allows a phone number to be uniquely identified, and enables the linking of a single phone number to multiple people and contexts. For example, each member of a family living at the same location would share the same phone number, having the same identifier. A correction to the phone number of one family member could be automatically propagated to other members of the family.HL7 does not assume responsibility for the processing rules for this component.
				/// </summary>
				public class SharedTelecommunicationIdentifier : HL7Base<SharedTelecommunicationIdentifier>
				{

					private const string _id = "SCH.13.17";
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
					/// SCH.13.17.1 - The first component, entity identifier, is usually defined to be unique within the series of identifiers created by the assigning authority, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, "HD - hierarchic designator".
					/// </summary>
					public class EntityIdentifier : HL7Base<EntityIdentifier>
					{

						private const string _id = "SCH.13.17.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.13.17.2 - See Section 2.A.33.1, "Namespace ID (IS)" for definition. The component intentionally remains associated with the IS data type in v 2.7.The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363  Assigning Authority for suggested values.Note When the HD is used as a part of another data type, in this case as part of the EI data type, this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment. By site agreement, implementers may continue to use User-defined Table 0300  Namespace ID for the first component
					/// </summary>
					public class NamespaceId : HL7Base<NamespaceId>
					{

						private const string _id = "SCH.13.17.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.13.17.3 - See Section 2.A.33.2, "Universal ID (ST)" for definition.
					/// </summary>
					public class UniversalId : HL7Base<UniversalId>
					{

						private const string _id = "SCH.13.17.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.13.17.4 - Refer to HL7 Table 0301 - Universal ID Type for valid values. See Section 2.A.33.3, "Universal ID Type (ID)," for definition.
					/// </summary>
					public class UniversalIdType : HL7Base<UniversalIdType>
					{

						private const string _id = "SCH.13.17.4";
						public override string Id
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
				/// SCH.13.18 - For an entity having multiple telecommunication addresses, indicates which is the "most preferred" (lowest number) to "least preferred" (highest number).If the preference order is unique across all usages for a given type, then it indicates the preference across all usages, (e.g. first try my home number, then my business number). If the preference order is unique across all usages and types, then it indicates the preference across all types of telecommunication addresses.  (E.g., first try my phone if that doesn't work, use my pager.) Otherwise, the preference order is assumed to only apply within a specific type and usage.Preference order numbers need not be sequential (i.e., three numbers with the priority orders of 0, 5 and 15 are legitimate).  The preference order numbers must be non-negative.
				/// </summary>
				public class PreferenceOrder : HL7Base<PreferenceOrder>
				{

					private const string _id = "SCH.13.18";
					public override string Id
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
			/// SCH.14 - This field contains the address used to contact the SCH-12-Placer Contact Person. 
			/// </summary>
			public class PlacerContactAddress : HL7Base<PlacerContactAddress>
			{

				private const string _id = "SCH.14";
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
				/// SCH.14.1 - This component contains the house number, apartment number, street name, street direction, P.O. Box number, and similar address information. 
				/// </summary>
				public class StreetAddress : HL7Base<StreetAddress>
				{

					private const string _id = "SCH.14.1";
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
					/// SCH.14.1.1 - This component specifies the street or mailing address of a person or institution. When referencing an institution, this first component is used to specify the institution name. When used in connection with a person, this component specifies the first line of the address.
					/// </summary>
					public class StreetOrMailingAddress : HL7Base<StreetOrMailingAddress>
					{

						private const string _id = "SCH.14.1.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.1.2 - 
					/// </summary>
					public class StreetName : HL7Base<StreetName>
					{

						private const string _id = "SCH.14.1.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.1.3 - 
					/// </summary>
					public class DwellingNumber : HL7Base<DwellingNumber>
					{

						private const string _id = "SCH.14.1.3";
						public override string Id
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
				/// SCH.14.2 - This component contains the second line of address. In US usage, it qualifies address. Examples Suite 555 or Fourth Floor. When referencing an institution, this component specifies the street address.
				/// </summary>
				public class OtherDesignation : HL7Base<OtherDesignation>
				{

					private const string _id = "SCH.14.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.14.3 - This component specifies the city, or district or place where the addressee is located depending upon the national convention for formatting addresses for postal usage.
				/// </summary>
				public class City : HL7Base<City>
				{

					private const string _id = "SCH.14.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.14.4 - This component specifies the state or province where the addressee is located. State or province should be represented by the official postal service codes for that country.
				/// </summary>
				public class StateOrProvince : HL7Base<StateOrProvince>
				{

					private const string _id = "SCH.14.4";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.14.5 - This component specifies the zip or postal code where the addressee is located. Zip or postal codes should be represented by the official codes for that country. In the US, the zip code takes the form 99999-9999, while the Canadian postal code takes the form A9A9A9, and the Australian Postcode takes the form 9999.
				/// </summary>
				public class ZipOrPostalCode : HL7Base<ZipOrPostalCode>
				{

					private const string _id = "SCH.14.5";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.14.6 - This component specifies the country where the addressee is located.  HL7 specifies that the 3-character (alphabetic) form of ISO 3166 be used for the country code. Refer to HL7 Table 0399  Country Code for valid values.
				/// </summary>
				public class Country : HL7Base<Country>
				{

					private const string _id = "SCH.14.6";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.14.7 - This component specifies the kind or type of address. Refer to HL7 Table 0190 - Address Type for valid values.XAD.7 is required if there are multiple occurrences of XAD in a field.
				/// </summary>
				public class AddressType : HL7Base<AddressType>
				{

					private const string _id = "SCH.14.7";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.14.8 - This component specifies any other geographic designation. It includes county, bioregion, SMSA, etc.
				/// </summary>
				public class OtherGeographicDesignation : HL7Base<OtherGeographicDesignation>
				{

					private const string _id = "SCH.14.8";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.14.9 - A code that represents the county in which the specified address resides. User-defined Table 0289 - County/parish is used as the HL7 identifier for the user-defined table of values for this component. When this component is used to represent the county (or parish), component 8 other geographic designation should not duplicate it (i.e., the use of other geographic designation to represent the county is allowed only for the purpose of backward compatibility, and should be discouraged in this and future versions of HL7).Allowable values codes defined by government.
				/// </summary>
				public class CountyParishCode : HL7Base<CountyParishCode>
				{

					private const string _id = "SCH.14.9";
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
					/// SCH.14.9.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "SCH.14.9.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.9.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "SCH.14.9.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.9.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "SCH.14.9.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.9.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "SCH.14.9.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.9.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "SCH.14.9.5";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.9.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "SCH.14.9.6";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.9.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "SCH.14.9.7";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.9.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "SCH.14.9.8";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.9.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "SCH.14.9.9";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.9.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "SCH.14.9.10";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.9.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "SCH.14.9.11";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.9.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "SCH.14.9.12";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.9.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "SCH.14.9.13";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.9.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "SCH.14.9.14";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.9.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "SCH.14.9.15";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.9.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "SCH.14.9.16";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.9.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "SCH.14.9.17";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.9.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "SCH.14.9.18";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.9.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "SCH.14.9.19";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.9.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "SCH.14.9.20";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.9.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "SCH.14.9.21";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.9.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "SCH.14.9.22";
						public override string Id
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
				/// SCH.14.10 - A code that represents the census tract in which the specified address resides. User-defined Table 0288 - Census Tract is used as the HL7 identifier for the user-defined table of values for this component.Allowable Values codes defined by government.
				/// </summary>
				public class CensusTract : HL7Base<CensusTract>
				{

					private const string _id = "SCH.14.10";
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
					/// SCH.14.10.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "SCH.14.10.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.10.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "SCH.14.10.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.10.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "SCH.14.10.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.10.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "SCH.14.10.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.10.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "SCH.14.10.5";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.10.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "SCH.14.10.6";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.10.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "SCH.14.10.7";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.10.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "SCH.14.10.8";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.10.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "SCH.14.10.9";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.10.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "SCH.14.10.10";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.10.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "SCH.14.10.11";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.10.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "SCH.14.10.12";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.10.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "SCH.14.10.13";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.10.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "SCH.14.10.14";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.10.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "SCH.14.10.15";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.10.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "SCH.14.10.16";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.10.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "SCH.14.10.17";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.10.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "SCH.14.10.18";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.10.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "SCH.14.10.19";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.10.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "SCH.14.10.20";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.10.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "SCH.14.10.21";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.10.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "SCH.14.10.22";
						public override string Id
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
				/// SCH.14.11 - Different name/address types and representations of the same name/address should be described by repeating of this field, with different values of the name/address type and/or name/address representation component.Note Also note that this new component remains in "alphabetic" representation with each repetition of the fields using these data types. I.e. even though the address may be represented in an ideographic character set, this component will remain represented in an alphabetic character set.Refer to HL7 Table 0465  Name/address Representation for valid values.In general this component provides an indication of the representation provided by the data item. It does not necessarily specify the character sets used. Thus, even though the representation might provide an indication of what to expect, the sender is still free to encode the contents using whatever character set is desired. This component provides only hints for the receiver, so it can make choices regarding what it has been sent and what it is capable of displaying.
				/// </summary>
				public class AddressRepresentationCode : HL7Base<AddressRepresentationCode>
				{

					private const string _id = "SCH.14.11";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.14.12 - Attention The XAD.12 component was retained for backward compatibility as of v2.5 and the detail was withdrawn and removed from the standard as of v2.7. Refer to 2.A.86.13, "Effective Date (DTM)" and 2.A.86.14, "Expiration Date (DTM)" components.
				/// </summary>
				public class AddressValidityRange : HL7Base<AddressValidityRange>
				{

					private const string _id = "SCH.14.12";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.14.13 - The first date, if known, on which the address is valid and active for the owning entity.
				/// </summary>
				public class EffectiveDate : HL7Base<EffectiveDate>
				{

					private const string _id = "SCH.14.13";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.14.14 - The last date, if known, on which the address is valid and active for the owning entity.
				/// </summary>
				public class ExpirationDate : HL7Base<ExpirationDate>
				{

					private const string _id = "SCH.14.14";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.14.15 - This identifies why this address was marked as "ended".   Refer to User-defined Table 0616  Address Expiration Reason for valid values.
				/// </summary>
				public class ExpirationReason : HL7Base<ExpirationReason>
				{

					private const string _id = "SCH.14.15";
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
					/// SCH.14.15.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "SCH.14.15.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.15.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "SCH.14.15.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.15.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "SCH.14.15.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.15.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "SCH.14.15.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.15.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "SCH.14.15.5";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.15.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "SCH.14.15.6";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.15.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "SCH.14.15.7";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.15.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "SCH.14.15.8";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.15.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "SCH.14.15.9";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.15.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "SCH.14.15.10";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.15.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "SCH.14.15.11";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.15.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "SCH.14.15.12";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.15.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "SCH.14.15.13";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.15.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "SCH.14.15.14";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.15.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "SCH.14.15.15";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.15.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "SCH.14.15.16";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.15.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "SCH.14.15.17";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.15.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "SCH.14.15.18";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.15.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "SCH.14.15.19";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.15.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "SCH.14.15.20";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.15.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "SCH.14.15.21";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.15.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "SCH.14.15.22";
						public override string Id
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
				/// SCH.14.16 - If "Y" this indicates that the address is considered temporary.  Refer to HL7 Table 0136  Yes/No Indicator.
				/// </summary>
				public class TemporaryIndicator : HL7Base<TemporaryIndicator>
				{

					private const string _id = "SCH.14.16";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.14.17 - If "Y", this indicates that it is not possible to contact the "owning" entity at this address. Refer to HL7 Table 0136  Yes/No Indicator.
				/// </summary>
				public class BadAddressIndicator : HL7Base<BadAddressIndicator>
				{

					private const string _id = "SCH.14.17";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.14.18 - This indicates how the address is intended to be used.  Refer to User-defined Table 0617  Address Usage for valid values.
				/// </summary>
				public class AddressUsage : HL7Base<AddressUsage>
				{

					private const string _id = "SCH.14.18";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.14.19 - Identifies the name of the person or organization that should appear as part of the address. This is also known as the "Care of" or "C/O" line.
				/// </summary>
				public class Addressee : HL7Base<Addressee>
				{

					private const string _id = "SCH.14.19";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.14.20 - Descriptive information about the use of the address.Example "Do not ring bell."
				/// </summary>
				public class Comment : HL7Base<Comment>
				{

					private const string _id = "SCH.14.20";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.14.21 - For an entity having multiple addresses, indicates which is the 'most preferred' (lowest number) to 'least preferred' (highest number).If the preference order is unique across all usages for a given type, then it indicates the preference across all usages, (e.g., first try my home address, then my business address). Otherwise, the preference order is assumed to only apply within a specific usage.Preference order numbers need not be sequential (i.e., four addresses with the priority orders of 10, 1, 5 and 15 are legitimate). The preference order numbers must be non-negative.
				/// </summary>
				public class PreferenceOrder : HL7Base<PreferenceOrder>
				{

					private const string _id = "SCH.14.21";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.14.22 - Identifies that an address needs to be treated with special care or sensitivity.The specific set of codes and appropriate handling of such addresses will vary by jurisdiction and is subject to site-specific negotiation. For example, a provider address marked as 'unlisted' might not be printed in an internal address listing.  Refer to User-defined Table 0618  Protection Code for valid values.
				/// </summary>
				public class ProtectionCode : HL7Base<ProtectionCode>
				{

					private const string _id = "SCH.14.22";
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
					/// SCH.14.22.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "SCH.14.22.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.22.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "SCH.14.22.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.22.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "SCH.14.22.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.22.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "SCH.14.22.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.22.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "SCH.14.22.5";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.22.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "SCH.14.22.6";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.22.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "SCH.14.22.7";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.22.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "SCH.14.22.8";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.22.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "SCH.14.22.9";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.22.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "SCH.14.22.10";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.22.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "SCH.14.22.11";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.22.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "SCH.14.22.12";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.22.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "SCH.14.22.13";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.22.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "SCH.14.22.14";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.22.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "SCH.14.22.15";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.22.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "SCH.14.22.16";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.22.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "SCH.14.22.17";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.22.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "SCH.14.22.18";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.22.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "SCH.14.22.19";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.22.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "SCH.14.22.20";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.22.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "SCH.14.22.21";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.22.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "SCH.14.22.22";
						public override string Id
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
				/// SCH.14.23 - A unique identifier for the address.This component allows an address to be uniquely identified, and enables the linking of a single address to multiple people and contexts. For example, each member of a family living at the same location would share the same address, having the same identifier. A correction to the address of one family member could be automatically propagated to other members of the family.
				/// </summary>
				public class AddressIdentifier : HL7Base<AddressIdentifier>
				{

					private const string _id = "SCH.14.23";
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
					/// SCH.14.23.1 - The first component, entity identifier, is usually defined to be unique within the series of identifiers created by the assigning authority, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, "HD - hierarchic designator".
					/// </summary>
					public class EntityIdentifier : HL7Base<EntityIdentifier>
					{

						private const string _id = "SCH.14.23.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.23.2 - See Section 2.A.33.1, "Namespace ID (IS)" for definition. The component intentionally remains associated with the IS data type in v 2.7.The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363  Assigning Authority for suggested values.Note When the HD is used as a part of another data type, in this case as part of the EI data type, this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment. By site agreement, implementers may continue to use User-defined Table 0300  Namespace ID for the first component
					/// </summary>
					public class NamespaceId : HL7Base<NamespaceId>
					{

						private const string _id = "SCH.14.23.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.23.3 - See Section 2.A.33.2, "Universal ID (ST)" for definition.
					/// </summary>
					public class UniversalId : HL7Base<UniversalId>
					{

						private const string _id = "SCH.14.23.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.14.23.4 - Refer to HL7 Table 0301 - Universal ID Type for valid values. See Section 2.A.33.3, "Universal ID Type (ID)," for definition.
					/// </summary>
					public class UniversalIdType : HL7Base<UniversalIdType>
					{

						private const string _id = "SCH.14.23.4";
						public override string Id
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
			/// SCH.15 - This field contains a code that identifies the location of the SCH-12-Placer Contact Person. 
			/// </summary>
			public class PlacerContactLocation : HL7Base<PlacerContactLocation>
			{

				private const string _id = "SCH.15";
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
				/// SCH.15.1 - This component specifies the code for the point where patient care is administered. It is conditional on PL.6 Person Location Type (e.g., nursing unit or department or clinic). After floor, it is the most general patient location designation. Refer to User-defined Table 0302 - Point of Care for suggested values.
				/// </summary>
				public class PointOfCare : HL7Base<PointOfCare>
				{

					private const string _id = "SCH.15.1";
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
					/// SCH.15.1.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
					/// </summary>
					public class NamespaceId : HL7Base<NamespaceId>
					{

						private const string _id = "SCH.15.1.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.15.1.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
					/// </summary>
					public class UniversalId : HL7Base<UniversalId>
					{

						private const string _id = "SCH.15.1.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.15.1.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
					/// </summary>
					public class UniversalIdType : HL7Base<UniversalIdType>
					{

						private const string _id = "SCH.15.1.3";
						public override string Id
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
				/// SCH.15.2 - This component specifies the code for the patient's room. After point of care, it is the most general person location designation. Refer to User-defined Table 0303 - Room for suggested values.
				/// </summary>
				public class Room : HL7Base<Room>
				{

					private const string _id = "SCH.15.2";
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
					/// SCH.15.2.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
					/// </summary>
					public class NamespaceId : HL7Base<NamespaceId>
					{

						private const string _id = "SCH.15.2.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.15.2.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
					/// </summary>
					public class UniversalId : HL7Base<UniversalId>
					{

						private const string _id = "SCH.15.2.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.15.2.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
					/// </summary>
					public class UniversalIdType : HL7Base<UniversalIdType>
					{

						private const string _id = "SCH.15.2.3";
						public override string Id
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
				/// SCH.15.3 - This component specifies the code for the patient's bed. After room, it is the most general person location designation. Refer to User-defined Table 0304 - Bed for suggested values.
				/// </summary>
				public class Bed : HL7Base<Bed>
				{

					private const string _id = "SCH.15.3";
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
					/// SCH.15.3.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
					/// </summary>
					public class NamespaceId : HL7Base<NamespaceId>
					{

						private const string _id = "SCH.15.3.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.15.3.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
					/// </summary>
					public class UniversalId : HL7Base<UniversalId>
					{

						private const string _id = "SCH.15.3.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.15.3.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
					/// </summary>
					public class UniversalIdType : HL7Base<UniversalIdType>
					{

						private const string _id = "SCH.15.3.3";
						public override string Id
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
				/// SCH.15.4 - This component is subject to site interpretation but generally describes the highest level physical designation of an institution, medical center or enterprise. It is the most general person location designation. Note When the HD data type is used in a given segment as a component of a field of another data type, User-defined Table 0300 - Namespace ID (referenced by the first sub-component of the HD component) may be redefined (given a different user-defined table number and name) by the technical committee responsible for that segment.
				/// </summary>
				public class Facility : HL7Base<Facility>
				{

					private const string _id = "SCH.15.4";
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
					/// SCH.15.4.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
					/// </summary>
					public class NamespaceId : HL7Base<NamespaceId>
					{

						private const string _id = "SCH.15.4.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.15.4.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
					/// </summary>
					public class UniversalId : HL7Base<UniversalId>
					{

						private const string _id = "SCH.15.4.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.15.4.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
					/// </summary>
					public class UniversalIdType : HL7Base<UniversalIdType>
					{

						private const string _id = "SCH.15.4.3";
						public override string Id
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
				/// SCH.15.5 - This component specifies the code for the status or availability of the location. For example, it may convey bed status. Refer to User-defined Table 0306 - Location Status for suggested values.
				/// </summary>
				public class LocationStatus : HL7Base<LocationStatus>
				{

					private const string _id = "SCH.15.5";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.15.6 - Person location type is the categorization of the persons location defined by facility, building, floor, point of care, room or bed. Although not a required field, when used, it may be the only populated field. It usually includes values such as nursing unit, department, clinic, SNF, physicians office. Refer to User-defined Table 0305 - Person location type for suggested values.
				/// </summary>
				public class PersonLocationType : HL7Base<PersonLocationType>
				{

					private const string _id = "SCH.15.6";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.15.7 - This component specifies the code for the building where the person is located. After facility, it is the most general person location designation. Refer to User-defined Table 0307 - Building for suggested values.
				/// </summary>
				public class Building : HL7Base<Building>
				{

					private const string _id = "SCH.15.7";
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
					/// SCH.15.7.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
					/// </summary>
					public class NamespaceId : HL7Base<NamespaceId>
					{

						private const string _id = "SCH.15.7.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.15.7.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
					/// </summary>
					public class UniversalId : HL7Base<UniversalId>
					{

						private const string _id = "SCH.15.7.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.15.7.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
					/// </summary>
					public class UniversalIdType : HL7Base<UniversalIdType>
					{

						private const string _id = "SCH.15.7.3";
						public override string Id
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
				/// SCH.15.8 - This component specifies the code for the floor where the person is located. After building, it is the most general person location designation. Refer to User-defined Table 0308 - Floor for suggested values.
				/// </summary>
				public class Floor : HL7Base<Floor>
				{

					private const string _id = "SCH.15.8";
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
					/// SCH.15.8.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
					/// </summary>
					public class NamespaceId : HL7Base<NamespaceId>
					{

						private const string _id = "SCH.15.8.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.15.8.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
					/// </summary>
					public class UniversalId : HL7Base<UniversalId>
					{

						private const string _id = "SCH.15.8.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.15.8.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
					/// </summary>
					public class UniversalIdType : HL7Base<UniversalIdType>
					{

						private const string _id = "SCH.15.8.3";
						public override string Id
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
				/// SCH.15.9 - This component describes the location in free text.
				/// </summary>
				public class LocationDescription : HL7Base<LocationDescription>
				{

					private const string _id = "SCH.15.9";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.15.10 - The unique identifier that represents the physical location as a whole without regard for the individual components. This accommodates sites that may have a different method of defining physical units or who may code at a less granular level. For example, point of care, room, and bed may be 1 indivisible code.
				/// </summary>
				public class ComprehensiveLocationIdentifier : HL7Base<ComprehensiveLocationIdentifier>
				{

					private const string _id = "SCH.15.10";
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
					/// SCH.15.10.1 - The first component, entity identifier, is usually defined to be unique within the series of identifiers created by the assigning authority, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, "HD - hierarchic designator".
					/// </summary>
					public class EntityIdentifier : HL7Base<EntityIdentifier>
					{

						private const string _id = "SCH.15.10.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.15.10.2 - See Section 2.A.33.1, "Namespace ID (IS)" for definition. The component intentionally remains associated with the IS data type in v 2.7.The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363  Assigning Authority for suggested values.Note When the HD is used as a part of another data type, in this case as part of the EI data type, this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment. By site agreement, implementers may continue to use User-defined Table 0300  Namespace ID for the first component
					/// </summary>
					public class NamespaceId : HL7Base<NamespaceId>
					{

						private const string _id = "SCH.15.10.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.15.10.3 - See Section 2.A.33.2, "Universal ID (ST)" for definition.
					/// </summary>
					public class UniversalId : HL7Base<UniversalId>
					{

						private const string _id = "SCH.15.10.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.15.10.4 - Refer to HL7 Table 0301 - Universal ID Type for valid values. See Section 2.A.33.3, "Universal ID Type (ID)," for definition.
					/// </summary>
					public class UniversalIdType : HL7Base<UniversalIdType>
					{

						private const string _id = "SCH.15.10.4";
						public override string Id
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
				/// SCH.15.11 - The entity that creates the data for the individual physical location components. If populated, it should be the authority for all components populated. Refer to User-defined Table 0363  Assigning Authority for suggested values for the first sub-component of the HD component, namespace ID.This component makes it possible for codes to be differentiated when the field in which this data type is used repeats.Note When the HD data type is used in a given segment as a component of a field of another data type, User-defined Table 0300 - Namespace ID (referenced by the first sub-component of the HD component) may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.By site agreement, implementors may continue to use User-defined Table 0300  Namespace ID for the first sub-component.
				/// </summary>
				public class AssigningAuthorityForLocation : HL7Base<AssigningAuthorityForLocation>
				{

					private const string _id = "SCH.15.11";
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
					/// SCH.15.11.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
					/// </summary>
					public class NamespaceId : HL7Base<NamespaceId>
					{

						private const string _id = "SCH.15.11.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.15.11.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
					/// </summary>
					public class UniversalId : HL7Base<UniversalId>
					{

						private const string _id = "SCH.15.11.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.15.11.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
					/// </summary>
					public class UniversalIdType : HL7Base<UniversalIdType>
					{

						private const string _id = "SCH.15.11.3";
						public override string Id
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
			/// SCH.16 - This field identifies the person responsible for the scheduling of the requested appointment.  Most often, this person will be the same person responsible for maintaining the schedule and for reviewing appointment requests.  This field should not have been made required but is retained as such for reasons of backward compatibility.
			/// </summary>
			public class FillerContactPerson : HL7Base<FillerContactPerson>
			{

				private const string _id = "SCH.16";
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
				/// SCH.16.1 - This component carries the Person Identifier itself. XCN.1, in conjunction with XCN.9 uniquely identifies the entity/person. XCN.1 is required if XCN.2 is not populated. Both may be populated. 
				/// </summary>
				public class PersonIdentifier : HL7Base<PersonIdentifier>
				{

					private const string _id = "SCH.16.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.16.2 - This component allows full specification of the surname of a person. Where appropriate, it differentiates the person's own surname from that of the person's partner or spouse, in cases where the person's name may contain elements from either name. It also permits messages to distinguish the surname prefix (such as "van" or "de") from the surname root. See section 2.A.30, "FN - family name".XCN.2 is required if XCN.1 is not populated. Both may be populated.
				/// </summary>
				public class FamilyName : HL7Base<FamilyName>
				{

					private const string _id = "SCH.16.2";
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
					/// SCH.16.2.1 - The atomic element of the person's family name. In most Western usage, this is the person's last name.
					/// </summary>
					public class Surname : HL7Base<Surname>
					{

						private const string _id = "SCH.16.2.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.2.2 - Internationalization usage for Germanic languages. This component is optional. An example of a surname prefix is the "van" in "Ludwig van Beethoven". Since the surname prefix doesn't sort completely alphabetically, it is reasonable to specify it as a separate sub-component of the PN and extended PN data types (XPN and XCN).Note Subcomponents own surname prefix, own surname, surname prefix from partner/spouse and surname from partner/spouse decompose complex Germanic names such as Martha de Mum-van Beethoven. If these subcomponents are valued, the surname subcomponent should still be fully valued for backward compatibility, i.e., de Mum-van Beethoven&de&Mum&van&Beethoven.Also, for clarity, the last name prefix has been renamed to own surname prefix.
					/// </summary>
					public class OwnSurnamePrefix : HL7Base<OwnSurnamePrefix>
					{

						private const string _id = "SCH.16.2.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.2.3 - The portion of the surname (in most Western usage, the last name) that is derived from the person's own surname, as distinguished from any portion that is derived from the surname of the person's partner or spouse. This component is optional.If the person's surname has legally changed to become (or incorporate) the surname of the person's partner or spouse, this is the person's surname immediately prior to such change. Often this is the person's "maiden name".
					/// </summary>
					public class OwnSurname : HL7Base<OwnSurname>
					{

						private const string _id = "SCH.16.2.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.2.4 - Internationalization usage for Germanic languages. This component is optional. An example of a surname prefix is the van in "Ludwig van Beethoven". Since the surname prefix doesn't sort completely alphabetically, it is reasonable to specify it as a separate sub-component of the PN and extended PN data types (XPN and XCN). Note Subcomponents own surname prefix, own surname, surname prefix from partner/spouse and surname from partner/spouse decompose complex Germanic names such as Martha de Mum-van Beethoven. If these subcomponents are valued, the surname subcomponent should still be fully valued for backward compatibility, i.e., de Mum-van Beethoven&de&Mum&van&Beethoven.Also, for clarity, the last name prefix has been renamed to own surname prefix.
					/// </summary>
					public class SurnamePrefixFromPartnerSpouse : HL7Base<SurnamePrefixFromPartnerSpouse>
					{

						private const string _id = "SCH.16.2.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.2.5 - The portion of the person's surname (in most Western usage, the last name) that is derived from the surname of the person's partner or spouse, as distinguished from the part derived from the person's own surname. This component is optional.If no portion of the person's surname is derived from the surname of the person's partner or spouse, this component is not valued. Otherwise, if the surname of the partner or spouse has legally changed to become (or incorporate) the person's surname, this is the surname of the partner or spouse immediately prior to such change.
					/// </summary>
					public class SurnameFromPartnerSpouse : HL7Base<SurnameFromPartnerSpouse>
					{

						private const string _id = "SCH.16.2.5";
						public override string Id
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
				/// SCH.16.3 - First name.
				/// </summary>
				public class GivenName : HL7Base<GivenName>
				{

					private const string _id = "SCH.16.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.16.4 - Multiple middle names may be included by separating them with spaces.
				/// </summary>
				public class SecondAndFurtherGivenNamesOrInitialsThereof : HL7Base<SecondAndFurtherGivenNamesOrInitialsThereof>
				{

					private const string _id = "SCH.16.4";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.16.5 - Used to specify a name suffix (e.g., Jr. or III).
				/// </summary>
				public class SuffixegJrOrIii : HL7Base<SuffixegJrOrIii>
				{

					private const string _id = "SCH.16.5";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.16.6 - Used to specify a name prefix (e.g., Dr.).
				/// </summary>
				public class PrefixegDr : HL7Base<PrefixegDr>
				{

					private const string _id = "SCH.16.6";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.16.7 - Attention The XCN-7 component was deprecated as of v2.5 and the detail was withdrawn and removed from the standard as of v27.. Refer to XCN.21 Professional Suffix.
				/// </summary>
				public class DegreeegMd : HL7Base<DegreeegMd>
				{

					private const string _id = "SCH.16.7";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.16.8 - Attention Retained for backwards compatibility only as of v 2.7. The reader is referred to XCN.9 instead.User-defined Table 0297  CN ID source is used as the HL7 identifier for the user-defined table of values for this component. Used to delineate the first component.
				/// </summary>
				public class SourceTable : HL7Base<SourceTable>
				{

					private const string _id = "SCH.16.8";
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
					/// SCH.16.8.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "SCH.16.8.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.8.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "SCH.16.8.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.8.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "SCH.16.8.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.8.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "SCH.16.8.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.8.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "SCH.16.8.5";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.8.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "SCH.16.8.6";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.8.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "SCH.16.8.7";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.8.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "SCH.16.8.8";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.8.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "SCH.16.8.9";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.8.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "SCH.16.8.10";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.8.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "SCH.16.8.11";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.8.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "SCH.16.8.12";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.8.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "SCH.16.8.13";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.8.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "SCH.16.8.14";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.8.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "SCH.16.8.15";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.8.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "SCH.16.8.16";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.8.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "SCH.16.8.17";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.8.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "SCH.16.8.18";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.8.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "SCH.16.8.19";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.8.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "SCH.16.8.20";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.8.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "SCH.16.8.21";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.8.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "SCH.16.8.22";
						public override string Id
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
				/// SCH.16.9 - The assigning authority is a unique identifier of the system (or organization or agency of department) that creates the data. User-defined Table 0363  Assigning Authority is used as the HL7 identifier for the user-defined table of values for the first sub-component of the HD component, namespace ID.As of v 2.7, the Assigning Authority is conditional. It is required if XCN.1 is populated and neither XCN.22 nor XCN.23 are populated. All 3 components may be populated. No assumptions can be safely made based on position or sequence. Best practice is to send an OID in this component when populated.The reader is referred to XCN.22 and XCN.23 if there is a need to transmit values with semantic meaning for an assigning jurisdiction or assigning department or agency in addition to, or instead of, an assigning authority. However, all 3 components may be valued.  If, in so doing, it is discovered that the values in XCN.22 and/or XCN.23 conflict with XCN.9, the user would look to the Message Profile or other implementation agreement for a statement as to which takes precedence.Note When the HD data type is used in a given segment as a component of a field of another data type, User-defined Table 0300 - Namespace ID (referenced by the first sub-component of the HD component) may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.By site agreement, implementors may continue to use User-defined Table 0300  Namespace ID for the first sub-component.
				/// </summary>
				public class AssigningAuthority : HL7Base<AssigningAuthority>
				{

					private const string _id = "SCH.16.9";
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
					/// SCH.16.9.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
					/// </summary>
					public class NamespaceId : HL7Base<NamespaceId>
					{

						private const string _id = "SCH.16.9.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.9.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
					/// </summary>
					public class UniversalId : HL7Base<UniversalId>
					{

						private const string _id = "SCH.16.9.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.9.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
					/// </summary>
					public class UniversalIdType : HL7Base<UniversalIdType>
					{

						private const string _id = "SCH.16.9.3";
						public override string Id
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
				/// SCH.16.10 - A code that represents the type of name. Refer to HL7 Table 0200 - Name Type for valid values. See Section 2.A.89.7, "Name Type Code (ID)".As of v 2.7, XCN.10 is conditional. It is required if XCN.2 is populated.
				/// </summary>
				public class NameTypeCode : HL7Base<NameTypeCode>
				{

					private const string _id = "SCH.16.10";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.16.11 - This component contains the digit, or digits, exclusive of the identifier in XCN.1, calculated by applying an algorithm to all or some of the digits in the number, which may be used to test validity of the non-check-digit identifier.
				/// </summary>
				public class IdentifierCheckDigit : HL7Base<IdentifierCheckDigit>
				{

					private const string _id = "SCH.16.11";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.16.12 - Contains the code identifying the check digit scheme employed.Refer to HL7 Table 0061 - Check Digit Scheme for valid values.
				/// </summary>
				public class CheckDigitScheme : HL7Base<CheckDigitScheme>
				{

					private const string _id = "SCH.16.12";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.16.13 - A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the assigning authority component. Refer to HL7 Table 0203 - Identifier Type for suggested values.As of v 2.7, XCN.13 is conditional. It is required if XCN.1 is populated.
				/// </summary>
				public class IdentifierTypeCode : HL7Base<IdentifierTypeCode>
				{

					private const string _id = "SCH.16.13";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.16.14 - The place or location identifier where the identifier was first assigned to the person. This component is not an inherent part of the identifier but rather part of the history of the identifier as part of this data type, its existence is a convenience for certain intercommunicating systems.Note When the HD data type is used in a given segment as a component of a field of another data type, User-defined Table 0300 - Namespace ID (referenced by the first sub-component of the HD component) may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
				/// </summary>
				public class AssigningFacility : HL7Base<AssigningFacility>
				{

					private const string _id = "SCH.16.14";
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
					/// SCH.16.14.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
					/// </summary>
					public class NamespaceId : HL7Base<NamespaceId>
					{

						private const string _id = "SCH.16.14.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.14.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
					/// </summary>
					public class UniversalId : HL7Base<UniversalId>
					{

						private const string _id = "SCH.16.14.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.14.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
					/// </summary>
					public class UniversalIdType : HL7Base<UniversalIdType>
					{

						private const string _id = "SCH.16.14.3";
						public override string Id
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
				/// SCH.16.15 - Different name/address types and representations of the same name/address should be described by repeating of this field, with different values of the name/address type and/or name/address representation component.Note This new component remains in alphabetic representation with each repetition of the field using these data types. I.e., even though the name may be represented in an ideographic character set, this component will remain represented in an alphabetic character set.Refer to HL7 Table 0465  Name/address Representation for valid values.In general this component provides an indication of the representation provided by the data item. It does not necessarily specify the character sets used. Thus, even though the representation might provide an indication of what to expect, the sender is still free to encode the contents using whatever character set is desired. This component provides only hints for the receiver, so it can make choices regarding what it has been sent and what it is capable of displaying.
				/// </summary>
				public class NameRepresentationCode : HL7Base<NameRepresentationCode>
				{

					private const string _id = "SCH.16.15";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.16.16 - This component is used to designate the context in which a name is used. The main use case is in Australian healthcare for indigenous patients who prefer to use different names when attending different healthcare institutions. Another use case occurs in the US where health practitioners can be licensed under slightly different names and the reporting of the correct name is vital for administrative purposes. Refer to User-defined Table 0448  Name Context for suggested values.
				/// </summary>
				public class NameContext : HL7Base<NameContext>
				{

					private const string _id = "SCH.16.16";
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
					/// SCH.16.16.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "SCH.16.16.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.16.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "SCH.16.16.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.16.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "SCH.16.16.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.16.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "SCH.16.16.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.16.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "SCH.16.16.5";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.16.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "SCH.16.16.6";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.16.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "SCH.16.16.7";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.16.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "SCH.16.16.8";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.16.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "SCH.16.16.9";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.16.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "SCH.16.16.10";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.16.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "SCH.16.16.11";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.16.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "SCH.16.16.12";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.16.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "SCH.16.16.13";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.16.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "SCH.16.16.14";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.16.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "SCH.16.16.15";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.16.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "SCH.16.16.16";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.16.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "SCH.16.16.17";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.16.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "SCH.16.16.18";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.16.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "SCH.16.16.19";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.16.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "SCH.16.16.20";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.16.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "SCH.16.16.21";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.16.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "SCH.16.16.22";
						public override string Id
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
				/// SCH.16.17 - Attention The XCN.17 component was deprecated as of v2.5 and the detail was withdrawn and removed from the standard as of v 2.7. Refer to XCN.19 Effective Date and XCN.20 Expiration Date instead.This component contains the start and end date/times that define the period during which this name was valid.
				/// </summary>
				public class NameValidityRange : HL7Base<NameValidityRange>
				{

					private const string _id = "SCH.16.17";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.16.18 - A code that represents the preferred display order of the components of this person name. Refer to HL7 Table 0444 - Name Assembly Order for valid values.
				/// </summary>
				public class NameAssemblyOrder : HL7Base<NameAssemblyOrder>
				{

					private const string _id = "SCH.16.18";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.16.19 - The first date, if known, on which the person name is valid and active.
				/// </summary>
				public class EffectiveDate : HL7Base<EffectiveDate>
				{

					private const string _id = "SCH.16.19";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.16.20 - The last date, if known, on which the person name is valid and active.
				/// </summary>
				public class ExpirationDate : HL7Base<ExpirationDate>
				{

					private const string _id = "SCH.16.20";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.16.21 - Used to specify an abbreviation, or a string of abbreviations denoting qualifications that support the persons profession, (e.g., licenses, certificates, degrees, affiliations with professional societies, etc.). The Professional Suffix normally follows the Family Name when the Person Name is used for display purposes. Please note that this component is an unformatted string and is used for display purposes only. Detailed information regarding the contents of Professional Suffix is obtained using appropriate segments in Chapter 15, "Personnel Management".
				/// </summary>
				public class ProfessionalSuffix : HL7Base<ProfessionalSuffix>
				{

					private const string _id = "SCH.16.21";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.16.22 - The geo-political body that assigned the identifier in XCN.1. As of v 2.7, the Assigning Jurisdiction is conditional. It is required if XCN.1 is populated and neither XCN.9 nor XCN.23 are populated. All 3 components may be populated. The reader is referred to XCN.9 if there is a need to transmit this information as an OID.
				/// </summary>
				public class AssigningJurisdiction : HL7Base<AssigningJurisdiction>
				{

					private const string _id = "SCH.16.22";
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
					/// SCH.16.22.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "SCH.16.22.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.22.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "SCH.16.22.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.22.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "SCH.16.22.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.22.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "SCH.16.22.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.22.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "SCH.16.22.5";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.22.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "SCH.16.22.6";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.22.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "SCH.16.22.7";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.22.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "SCH.16.22.8";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.22.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "SCH.16.22.9";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.22.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "SCH.16.22.10";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.22.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "SCH.16.22.11";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.22.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "SCH.16.22.12";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.22.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "SCH.16.22.13";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.22.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "SCH.16.22.14";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.22.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "SCH.16.22.15";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.22.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "SCH.16.22.16";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.22.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "SCH.16.22.17";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.22.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "SCH.16.22.18";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.22.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "SCH.16.22.19";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.22.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "SCH.16.22.20";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.22.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "SCH.16.22.21";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.22.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "SCH.16.22.22";
						public override string Id
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
				/// SCH.16.23 - The agency or department that assigned the identifier in XCN.1.As of v 2.7, the Assigning Jurisdiction is conditional. It is required if XCN.1 is populated and neither XCN.9 nor XCN.22 are populated. All 3 components may be populated. The reader is referred to XCN.9 if there is a need to transmit this information as an OID.
				/// </summary>
				public class AssigningAgencyOrDepartment : HL7Base<AssigningAgencyOrDepartment>
				{

					private const string _id = "SCH.16.23";
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
					/// SCH.16.23.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "SCH.16.23.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.23.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "SCH.16.23.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.23.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "SCH.16.23.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.23.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "SCH.16.23.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.23.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "SCH.16.23.5";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.23.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "SCH.16.23.6";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.23.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "SCH.16.23.7";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.23.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "SCH.16.23.8";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.23.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "SCH.16.23.9";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.23.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "SCH.16.23.10";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.23.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "SCH.16.23.11";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.23.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "SCH.16.23.12";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.23.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "SCH.16.23.13";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.23.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "SCH.16.23.14";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.23.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "SCH.16.23.15";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.23.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "SCH.16.23.16";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.23.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "SCH.16.23.17";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.23.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "SCH.16.23.18";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.23.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "SCH.16.23.19";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.23.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "SCH.16.23.20";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.23.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "SCH.16.23.21";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.16.23.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "SCH.16.23.22";
						public override string Id
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
				/// SCH.16.24 - This component is used to communicate a version code that may be assigned to the value given in XCN.1 Person Identifier.
				/// </summary>
				public class SecurityCheck : HL7Base<SecurityCheck>
				{

					private const string _id = "SCH.16.24";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.16.25 - This component is used to transmit information intended to validate the veracity of the supplied identifier or the presenter of the identifier. For example, this component may be used to ensure that the presenter of a credit card is an authorized user of that card.Refer to HL7 Table 0904 - Security Check Scheme for valid values
				/// </summary>
				public class SecurityCheckScheme : HL7Base<SecurityCheckScheme>
				{

					private const string _id = "SCH.16.25";
					public override string Id
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
			/// SCH.17 - This field contains the phone number used to contact the SCH-16-Filler Contact Person.
			/// </summary>
			public class FillerContactPhoneNumber : HL7Base<FillerContactPhoneNumber>
			{

				private const string _id = "SCH.17";
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
				/// SCH.17.1 - Attention The XTN-1 component was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v2.6.
				/// </summary>
				public class TelephoneNumber : HL7Base<TelephoneNumber>
				{

					private const string _id = "SCH.17.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.17.2 - A code that represents a specific use of a telecommunication number. Refer to HL7 Table 0201 - Telecommunication Use Code for valid values. This component along with XTN.3 describes the nature of the telecommunication data that follows. Best practice requires the population of XTN.2 when XTN.4 or XTN.7 is populated. 
				/// </summary>
				public class TelecommunicationUseCode : HL7Base<TelecommunicationUseCode>
				{

					private const string _id = "SCH.17.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.17.3 - A code that represents the type of telecommunication equipment. Refer to HL7 Table 0202 - Telecommunication Equipment Type for valid values. This component along with XTN.2 describes the nature of the telecommunication data that follows and is necessary to accurately interpret it.
				/// </summary>
				public class TelecommunicationEquipmentType : HL7Base<TelecommunicationEquipmentType>
				{

					private const string _id = "SCH.17.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.17.4 - This component is required if, and only allowed if, XTN.7 or XTN.12 are not populated.  Note If any of the HL7 delimiters are found in the Communication Address, such as , the appropriate HL7 escape sequence SHALL be used when encoding an Internet address (see Chapter 2, "Control", section 2.7.1, "Formatting Codes").
				/// </summary>
				public class CommunicationAddress : HL7Base<CommunicationAddress>
				{

					private const string _id = "SCH.17.4";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.17.5 - The numeric code assigned by the International Telecommunication Union in standard E.164 to access telephone services in another country.  For example, "+1" is the country code for the United States, "+49" is the code for Germany.
				/// </summary>
				public class CountryCode : HL7Base<CountryCode>
				{

					private const string _id = "SCH.17.5";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.17.6 - The numeric code to access telephone services in another area/city within a country. This number historically needs not be dialed if the caller is located in the same area/city as the phone number of the called party.The use and size of area/city codes is however country specific some countries do not use area/city codes, or the use of area/city codes may be mandatory when dialing, or area/city codes may be used to group phone numbers based on other criteria than geographic location, such as cell-phone area/city-codes, or free information numbers (e.g., 800 numbers).Most countries have a prefix for Area/City codes which only has to be dialed if one doesn't use a country code. This prefix (mostly "0", sometimes "9") should be omitted from the content of this field. If the prefix for the Area/Code is also mandatory if one uses the country code (e.g., in Italy) then this field should also contain the prefix.
				/// </summary>
				public class AreaCityCode : HL7Base<AreaCityCode>
				{

					private const string _id = "SCH.17.6";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.17.7 - The numeric code used to contact the called party, exclusive of country and area/city codes. The Local Number is required when, and allowed only if, XTN.4 and XTN.12 are not populated. The size of the Local Number is country specific.Note that the Local Number does not include the numeric codes that have to be dialed once a connection has been established. Examples include (automated) organizational phone systems which allow external callers to dial additional numeric codes. These additional numeric codes should be specified as an extension.
				/// </summary>
				public class LocalNumber : HL7Base<LocalNumber>
				{

					private const string _id = "SCH.17.7";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.17.8 - The numeric code to contact the called party used within an organization, e.g., the number used if both caller and called party are located within the same organization. The extension is often the same as the last few digits of the Local Number. The use of extensions is country and site specific, and may depend on the type of phone system (PBX) used by the organization.
				/// </summary>
				public class Extension : HL7Base<Extension>
				{

					private const string _id = "SCH.17.8";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.17.9 - Contains comments with respect to the telephone number.Example Do not use after 5PM
				/// </summary>
				public class AnyText : HL7Base<AnyText>
				{

					private const string _id = "SCH.17.9";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.17.10 - The characters established within a companys internal telephone system network used as a prefix to the Extension component for internal dialing. Note that the use of Extension Prefix requires that the Extension component be valued and that digits, as well as special characters (e.g., *, #) may be used.
				/// </summary>
				public class ExtensionPrefix : HL7Base<ExtensionPrefix>
				{

					private const string _id = "SCH.17.10";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.17.11 - The characters established within a companys internal telephone system used in place of the (external) telephone number to facilitate calling because its length is shorter than that of the telephone number. Note that digits, as well as special characters (e.g., *, #) may be used.
				/// </summary>
				public class SpeedDialCode : HL7Base<SpeedDialCode>
				{

					private const string _id = "SCH.17.11";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.17.12 - An expression of the telephone number as an unparsable string. The Unformatted Telephone number is required when, and allowed only if, XTN.4 and XTN.7 are not populated.The phone number was entered as free text and sending system does not know how to parse it. Example 1-800-Dentist
				/// </summary>
				public class UnformattedTelephoneNumber : HL7Base<UnformattedTelephoneNumber>
				{

					private const string _id = "SCH.17.12";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.17.13 - The first date, if known, on which the telecommunication number is valid and active.
				/// </summary>
				public class EffectiveStartDate : HL7Base<EffectiveStartDate>
				{

					private const string _id = "SCH.17.13";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.17.14 - The last date, if known, on which the telecommunication number is valid and active.
				/// </summary>
				public class ExpirationDate : HL7Base<ExpirationDate>
				{

					private const string _id = "SCH.17.14";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.17.15 - Indicates why this contact number/e-mail was marked as "ended".  Refer to User-defined Table 0868  Telecommunication Expiration Reason for valid values.
				/// </summary>
				public class ExpirationReason : HL7Base<ExpirationReason>
				{

					private const string _id = "SCH.17.15";
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
					/// SCH.17.15.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "SCH.17.15.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.17.15.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "SCH.17.15.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.17.15.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "SCH.17.15.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.17.15.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "SCH.17.15.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.17.15.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "SCH.17.15.5";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.17.15.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "SCH.17.15.6";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.17.15.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "SCH.17.15.7";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.17.15.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "SCH.17.15.8";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.17.15.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "SCH.17.15.9";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.17.15.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "SCH.17.15.10";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.17.15.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "SCH.17.15.11";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.17.15.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "SCH.17.15.12";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.17.15.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "SCH.17.15.13";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.17.15.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "SCH.17.15.14";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.17.15.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "SCH.17.15.15";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.17.15.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "SCH.17.15.16";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.17.15.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "SCH.17.15.17";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.17.15.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "SCH.17.15.18";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.17.15.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "SCH.17.15.19";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.17.15.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "SCH.17.15.20";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.17.15.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "SCH.17.15.21";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.17.15.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "SCH.17.15.22";
						public override string Id
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
				/// SCH.17.16 - Indicates whether this information is considered sensitive or should be protected in some way. Refer to User-defined table 0618 - Protection Code for suggested values.The specific set of codes and appropriate handling of such telecommunications addresses will vary by jurisdiction and is subject to site-specific negotiation. For example, a provider address marked as 'unlisted' might not be printed in an internal address listing.
				/// </summary>
				public class ProtectionCode : HL7Base<ProtectionCode>
				{

					private const string _id = "SCH.17.16";
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
					/// SCH.17.16.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "SCH.17.16.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.17.16.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "SCH.17.16.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.17.16.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "SCH.17.16.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.17.16.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "SCH.17.16.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.17.16.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "SCH.17.16.5";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.17.16.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "SCH.17.16.6";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.17.16.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "SCH.17.16.7";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.17.16.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "SCH.17.16.8";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.17.16.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "SCH.17.16.9";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.17.16.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "SCH.17.16.10";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.17.16.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "SCH.17.16.11";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.17.16.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "SCH.17.16.12";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.17.16.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "SCH.17.16.13";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.17.16.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "SCH.17.16.14";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.17.16.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "SCH.17.16.15";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.17.16.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "SCH.17.16.16";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.17.16.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "SCH.17.16.17";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.17.16.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "SCH.17.16.18";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.17.16.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "SCH.17.16.19";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.17.16.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "SCH.17.16.20";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.17.16.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "SCH.17.16.21";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.17.16.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "SCH.17.16.22";
						public override string Id
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
				/// SCH.17.17 - A unique identifier for the phone number or e-mail address.This component allows a phone number to be uniquely identified, and enables the linking of a single phone number to multiple people and contexts. For example, each member of a family living at the same location would share the same phone number, having the same identifier. A correction to the phone number of one family member could be automatically propagated to other members of the family.HL7 does not assume responsibility for the processing rules for this component.
				/// </summary>
				public class SharedTelecommunicationIdentifier : HL7Base<SharedTelecommunicationIdentifier>
				{

					private const string _id = "SCH.17.17";
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
					/// SCH.17.17.1 - The first component, entity identifier, is usually defined to be unique within the series of identifiers created by the assigning authority, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, "HD - hierarchic designator".
					/// </summary>
					public class EntityIdentifier : HL7Base<EntityIdentifier>
					{

						private const string _id = "SCH.17.17.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.17.17.2 - See Section 2.A.33.1, "Namespace ID (IS)" for definition. The component intentionally remains associated with the IS data type in v 2.7.The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363  Assigning Authority for suggested values.Note When the HD is used as a part of another data type, in this case as part of the EI data type, this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment. By site agreement, implementers may continue to use User-defined Table 0300  Namespace ID for the first component
					/// </summary>
					public class NamespaceId : HL7Base<NamespaceId>
					{

						private const string _id = "SCH.17.17.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.17.17.3 - See Section 2.A.33.2, "Universal ID (ST)" for definition.
					/// </summary>
					public class UniversalId : HL7Base<UniversalId>
					{

						private const string _id = "SCH.17.17.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.17.17.4 - Refer to HL7 Table 0301 - Universal ID Type for valid values. See Section 2.A.33.3, "Universal ID Type (ID)," for definition.
					/// </summary>
					public class UniversalIdType : HL7Base<UniversalIdType>
					{

						private const string _id = "SCH.17.17.4";
						public override string Id
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
				/// SCH.17.18 - For an entity having multiple telecommunication addresses, indicates which is the "most preferred" (lowest number) to "least preferred" (highest number).If the preference order is unique across all usages for a given type, then it indicates the preference across all usages, (e.g. first try my home number, then my business number). If the preference order is unique across all usages and types, then it indicates the preference across all types of telecommunication addresses.  (E.g., first try my phone if that doesn't work, use my pager.) Otherwise, the preference order is assumed to only apply within a specific type and usage.Preference order numbers need not be sequential (i.e., three numbers with the priority orders of 0, 5 and 15 are legitimate).  The preference order numbers must be non-negative.
				/// </summary>
				public class PreferenceOrder : HL7Base<PreferenceOrder>
				{

					private const string _id = "SCH.17.18";
					public override string Id
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
			/// SCH.18 - This field contains the address used to contact the SCH-16-Filler Contact Person.
			/// </summary>
			public class FillerContactAddress : HL7Base<FillerContactAddress>
			{

				private const string _id = "SCH.18";
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
				/// SCH.18.1 - This component contains the house number, apartment number, street name, street direction, P.O. Box number, and similar address information. 
				/// </summary>
				public class StreetAddress : HL7Base<StreetAddress>
				{

					private const string _id = "SCH.18.1";
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
					/// SCH.18.1.1 - This component specifies the street or mailing address of a person or institution. When referencing an institution, this first component is used to specify the institution name. When used in connection with a person, this component specifies the first line of the address.
					/// </summary>
					public class StreetOrMailingAddress : HL7Base<StreetOrMailingAddress>
					{

						private const string _id = "SCH.18.1.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.1.2 - 
					/// </summary>
					public class StreetName : HL7Base<StreetName>
					{

						private const string _id = "SCH.18.1.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.1.3 - 
					/// </summary>
					public class DwellingNumber : HL7Base<DwellingNumber>
					{

						private const string _id = "SCH.18.1.3";
						public override string Id
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
				/// SCH.18.2 - This component contains the second line of address. In US usage, it qualifies address. Examples Suite 555 or Fourth Floor. When referencing an institution, this component specifies the street address.
				/// </summary>
				public class OtherDesignation : HL7Base<OtherDesignation>
				{

					private const string _id = "SCH.18.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.18.3 - This component specifies the city, or district or place where the addressee is located depending upon the national convention for formatting addresses for postal usage.
				/// </summary>
				public class City : HL7Base<City>
				{

					private const string _id = "SCH.18.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.18.4 - This component specifies the state or province where the addressee is located. State or province should be represented by the official postal service codes for that country.
				/// </summary>
				public class StateOrProvince : HL7Base<StateOrProvince>
				{

					private const string _id = "SCH.18.4";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.18.5 - This component specifies the zip or postal code where the addressee is located. Zip or postal codes should be represented by the official codes for that country. In the US, the zip code takes the form 99999-9999, while the Canadian postal code takes the form A9A9A9, and the Australian Postcode takes the form 9999.
				/// </summary>
				public class ZipOrPostalCode : HL7Base<ZipOrPostalCode>
				{

					private const string _id = "SCH.18.5";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.18.6 - This component specifies the country where the addressee is located.  HL7 specifies that the 3-character (alphabetic) form of ISO 3166 be used for the country code. Refer to HL7 Table 0399  Country Code for valid values.
				/// </summary>
				public class Country : HL7Base<Country>
				{

					private const string _id = "SCH.18.6";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.18.7 - This component specifies the kind or type of address. Refer to HL7 Table 0190 - Address Type for valid values.XAD.7 is required if there are multiple occurrences of XAD in a field.
				/// </summary>
				public class AddressType : HL7Base<AddressType>
				{

					private const string _id = "SCH.18.7";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.18.8 - This component specifies any other geographic designation. It includes county, bioregion, SMSA, etc.
				/// </summary>
				public class OtherGeographicDesignation : HL7Base<OtherGeographicDesignation>
				{

					private const string _id = "SCH.18.8";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.18.9 - A code that represents the county in which the specified address resides. User-defined Table 0289 - County/parish is used as the HL7 identifier for the user-defined table of values for this component. When this component is used to represent the county (or parish), component 8 other geographic designation should not duplicate it (i.e., the use of other geographic designation to represent the county is allowed only for the purpose of backward compatibility, and should be discouraged in this and future versions of HL7).Allowable values codes defined by government.
				/// </summary>
				public class CountyParishCode : HL7Base<CountyParishCode>
				{

					private const string _id = "SCH.18.9";
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
					/// SCH.18.9.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "SCH.18.9.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.9.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "SCH.18.9.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.9.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "SCH.18.9.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.9.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "SCH.18.9.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.9.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "SCH.18.9.5";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.9.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "SCH.18.9.6";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.9.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "SCH.18.9.7";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.9.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "SCH.18.9.8";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.9.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "SCH.18.9.9";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.9.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "SCH.18.9.10";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.9.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "SCH.18.9.11";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.9.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "SCH.18.9.12";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.9.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "SCH.18.9.13";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.9.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "SCH.18.9.14";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.9.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "SCH.18.9.15";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.9.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "SCH.18.9.16";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.9.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "SCH.18.9.17";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.9.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "SCH.18.9.18";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.9.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "SCH.18.9.19";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.9.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "SCH.18.9.20";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.9.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "SCH.18.9.21";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.9.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "SCH.18.9.22";
						public override string Id
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
				/// SCH.18.10 - A code that represents the census tract in which the specified address resides. User-defined Table 0288 - Census Tract is used as the HL7 identifier for the user-defined table of values for this component.Allowable Values codes defined by government.
				/// </summary>
				public class CensusTract : HL7Base<CensusTract>
				{

					private const string _id = "SCH.18.10";
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
					/// SCH.18.10.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "SCH.18.10.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.10.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "SCH.18.10.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.10.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "SCH.18.10.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.10.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "SCH.18.10.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.10.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "SCH.18.10.5";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.10.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "SCH.18.10.6";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.10.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "SCH.18.10.7";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.10.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "SCH.18.10.8";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.10.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "SCH.18.10.9";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.10.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "SCH.18.10.10";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.10.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "SCH.18.10.11";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.10.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "SCH.18.10.12";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.10.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "SCH.18.10.13";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.10.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "SCH.18.10.14";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.10.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "SCH.18.10.15";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.10.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "SCH.18.10.16";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.10.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "SCH.18.10.17";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.10.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "SCH.18.10.18";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.10.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "SCH.18.10.19";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.10.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "SCH.18.10.20";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.10.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "SCH.18.10.21";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.10.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "SCH.18.10.22";
						public override string Id
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
				/// SCH.18.11 - Different name/address types and representations of the same name/address should be described by repeating of this field, with different values of the name/address type and/or name/address representation component.Note Also note that this new component remains in "alphabetic" representation with each repetition of the fields using these data types. I.e. even though the address may be represented in an ideographic character set, this component will remain represented in an alphabetic character set.Refer to HL7 Table 0465  Name/address Representation for valid values.In general this component provides an indication of the representation provided by the data item. It does not necessarily specify the character sets used. Thus, even though the representation might provide an indication of what to expect, the sender is still free to encode the contents using whatever character set is desired. This component provides only hints for the receiver, so it can make choices regarding what it has been sent and what it is capable of displaying.
				/// </summary>
				public class AddressRepresentationCode : HL7Base<AddressRepresentationCode>
				{

					private const string _id = "SCH.18.11";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.18.12 - Attention The XAD.12 component was retained for backward compatibility as of v2.5 and the detail was withdrawn and removed from the standard as of v2.7. Refer to 2.A.86.13, "Effective Date (DTM)" and 2.A.86.14, "Expiration Date (DTM)" components.
				/// </summary>
				public class AddressValidityRange : HL7Base<AddressValidityRange>
				{

					private const string _id = "SCH.18.12";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.18.13 - The first date, if known, on which the address is valid and active for the owning entity.
				/// </summary>
				public class EffectiveDate : HL7Base<EffectiveDate>
				{

					private const string _id = "SCH.18.13";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.18.14 - The last date, if known, on which the address is valid and active for the owning entity.
				/// </summary>
				public class ExpirationDate : HL7Base<ExpirationDate>
				{

					private const string _id = "SCH.18.14";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.18.15 - This identifies why this address was marked as "ended".   Refer to User-defined Table 0616  Address Expiration Reason for valid values.
				/// </summary>
				public class ExpirationReason : HL7Base<ExpirationReason>
				{

					private const string _id = "SCH.18.15";
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
					/// SCH.18.15.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "SCH.18.15.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.15.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "SCH.18.15.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.15.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "SCH.18.15.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.15.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "SCH.18.15.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.15.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "SCH.18.15.5";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.15.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "SCH.18.15.6";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.15.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "SCH.18.15.7";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.15.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "SCH.18.15.8";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.15.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "SCH.18.15.9";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.15.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "SCH.18.15.10";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.15.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "SCH.18.15.11";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.15.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "SCH.18.15.12";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.15.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "SCH.18.15.13";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.15.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "SCH.18.15.14";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.15.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "SCH.18.15.15";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.15.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "SCH.18.15.16";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.15.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "SCH.18.15.17";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.15.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "SCH.18.15.18";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.15.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "SCH.18.15.19";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.15.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "SCH.18.15.20";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.15.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "SCH.18.15.21";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.15.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "SCH.18.15.22";
						public override string Id
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
				/// SCH.18.16 - If "Y" this indicates that the address is considered temporary.  Refer to HL7 Table 0136  Yes/No Indicator.
				/// </summary>
				public class TemporaryIndicator : HL7Base<TemporaryIndicator>
				{

					private const string _id = "SCH.18.16";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.18.17 - If "Y", this indicates that it is not possible to contact the "owning" entity at this address. Refer to HL7 Table 0136  Yes/No Indicator.
				/// </summary>
				public class BadAddressIndicator : HL7Base<BadAddressIndicator>
				{

					private const string _id = "SCH.18.17";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.18.18 - This indicates how the address is intended to be used.  Refer to User-defined Table 0617  Address Usage for valid values.
				/// </summary>
				public class AddressUsage : HL7Base<AddressUsage>
				{

					private const string _id = "SCH.18.18";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.18.19 - Identifies the name of the person or organization that should appear as part of the address. This is also known as the "Care of" or "C/O" line.
				/// </summary>
				public class Addressee : HL7Base<Addressee>
				{

					private const string _id = "SCH.18.19";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.18.20 - Descriptive information about the use of the address.Example "Do not ring bell."
				/// </summary>
				public class Comment : HL7Base<Comment>
				{

					private const string _id = "SCH.18.20";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.18.21 - For an entity having multiple addresses, indicates which is the 'most preferred' (lowest number) to 'least preferred' (highest number).If the preference order is unique across all usages for a given type, then it indicates the preference across all usages, (e.g., first try my home address, then my business address). Otherwise, the preference order is assumed to only apply within a specific usage.Preference order numbers need not be sequential (i.e., four addresses with the priority orders of 10, 1, 5 and 15 are legitimate). The preference order numbers must be non-negative.
				/// </summary>
				public class PreferenceOrder : HL7Base<PreferenceOrder>
				{

					private const string _id = "SCH.18.21";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.18.22 - Identifies that an address needs to be treated with special care or sensitivity.The specific set of codes and appropriate handling of such addresses will vary by jurisdiction and is subject to site-specific negotiation. For example, a provider address marked as 'unlisted' might not be printed in an internal address listing.  Refer to User-defined Table 0618  Protection Code for valid values.
				/// </summary>
				public class ProtectionCode : HL7Base<ProtectionCode>
				{

					private const string _id = "SCH.18.22";
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
					/// SCH.18.22.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "SCH.18.22.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.22.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "SCH.18.22.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.22.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "SCH.18.22.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.22.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "SCH.18.22.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.22.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "SCH.18.22.5";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.22.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "SCH.18.22.6";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.22.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "SCH.18.22.7";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.22.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "SCH.18.22.8";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.22.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "SCH.18.22.9";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.22.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "SCH.18.22.10";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.22.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "SCH.18.22.11";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.22.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "SCH.18.22.12";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.22.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "SCH.18.22.13";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.22.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "SCH.18.22.14";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.22.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "SCH.18.22.15";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.22.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "SCH.18.22.16";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.22.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "SCH.18.22.17";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.22.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "SCH.18.22.18";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.22.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "SCH.18.22.19";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.22.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "SCH.18.22.20";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.22.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "SCH.18.22.21";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.22.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "SCH.18.22.22";
						public override string Id
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
				/// SCH.18.23 - A unique identifier for the address.This component allows an address to be uniquely identified, and enables the linking of a single address to multiple people and contexts. For example, each member of a family living at the same location would share the same address, having the same identifier. A correction to the address of one family member could be automatically propagated to other members of the family.
				/// </summary>
				public class AddressIdentifier : HL7Base<AddressIdentifier>
				{

					private const string _id = "SCH.18.23";
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
					/// SCH.18.23.1 - The first component, entity identifier, is usually defined to be unique within the series of identifiers created by the assigning authority, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, "HD - hierarchic designator".
					/// </summary>
					public class EntityIdentifier : HL7Base<EntityIdentifier>
					{

						private const string _id = "SCH.18.23.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.23.2 - See Section 2.A.33.1, "Namespace ID (IS)" for definition. The component intentionally remains associated with the IS data type in v 2.7.The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363  Assigning Authority for suggested values.Note When the HD is used as a part of another data type, in this case as part of the EI data type, this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment. By site agreement, implementers may continue to use User-defined Table 0300  Namespace ID for the first component
					/// </summary>
					public class NamespaceId : HL7Base<NamespaceId>
					{

						private const string _id = "SCH.18.23.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.23.3 - See Section 2.A.33.2, "Universal ID (ST)" for definition.
					/// </summary>
					public class UniversalId : HL7Base<UniversalId>
					{

						private const string _id = "SCH.18.23.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.18.23.4 - Refer to HL7 Table 0301 - Universal ID Type for valid values. See Section 2.A.33.3, "Universal ID Type (ID)," for definition.
					/// </summary>
					public class UniversalIdType : HL7Base<UniversalIdType>
					{

						private const string _id = "SCH.18.23.4";
						public override string Id
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
			/// SCH.19 - This field contains a code that identifies the location of the SCH-16-Filler Contact Person.
			/// </summary>
			public class FillerContactLocation : HL7Base<FillerContactLocation>
			{

				private const string _id = "SCH.19";
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
				/// SCH.19.1 - This component specifies the code for the point where patient care is administered. It is conditional on PL.6 Person Location Type (e.g., nursing unit or department or clinic). After floor, it is the most general patient location designation. Refer to User-defined Table 0302 - Point of Care for suggested values.
				/// </summary>
				public class PointOfCare : HL7Base<PointOfCare>
				{

					private const string _id = "SCH.19.1";
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
					/// SCH.19.1.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
					/// </summary>
					public class NamespaceId : HL7Base<NamespaceId>
					{

						private const string _id = "SCH.19.1.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.19.1.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
					/// </summary>
					public class UniversalId : HL7Base<UniversalId>
					{

						private const string _id = "SCH.19.1.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.19.1.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
					/// </summary>
					public class UniversalIdType : HL7Base<UniversalIdType>
					{

						private const string _id = "SCH.19.1.3";
						public override string Id
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
				/// SCH.19.2 - This component specifies the code for the patient's room. After point of care, it is the most general person location designation. Refer to User-defined Table 0303 - Room for suggested values.
				/// </summary>
				public class Room : HL7Base<Room>
				{

					private const string _id = "SCH.19.2";
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
					/// SCH.19.2.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
					/// </summary>
					public class NamespaceId : HL7Base<NamespaceId>
					{

						private const string _id = "SCH.19.2.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.19.2.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
					/// </summary>
					public class UniversalId : HL7Base<UniversalId>
					{

						private const string _id = "SCH.19.2.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.19.2.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
					/// </summary>
					public class UniversalIdType : HL7Base<UniversalIdType>
					{

						private const string _id = "SCH.19.2.3";
						public override string Id
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
				/// SCH.19.3 - This component specifies the code for the patient's bed. After room, it is the most general person location designation. Refer to User-defined Table 0304 - Bed for suggested values.
				/// </summary>
				public class Bed : HL7Base<Bed>
				{

					private const string _id = "SCH.19.3";
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
					/// SCH.19.3.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
					/// </summary>
					public class NamespaceId : HL7Base<NamespaceId>
					{

						private const string _id = "SCH.19.3.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.19.3.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
					/// </summary>
					public class UniversalId : HL7Base<UniversalId>
					{

						private const string _id = "SCH.19.3.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.19.3.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
					/// </summary>
					public class UniversalIdType : HL7Base<UniversalIdType>
					{

						private const string _id = "SCH.19.3.3";
						public override string Id
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
				/// SCH.19.4 - This component is subject to site interpretation but generally describes the highest level physical designation of an institution, medical center or enterprise. It is the most general person location designation. Note When the HD data type is used in a given segment as a component of a field of another data type, User-defined Table 0300 - Namespace ID (referenced by the first sub-component of the HD component) may be redefined (given a different user-defined table number and name) by the technical committee responsible for that segment.
				/// </summary>
				public class Facility : HL7Base<Facility>
				{

					private const string _id = "SCH.19.4";
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
					/// SCH.19.4.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
					/// </summary>
					public class NamespaceId : HL7Base<NamespaceId>
					{

						private const string _id = "SCH.19.4.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.19.4.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
					/// </summary>
					public class UniversalId : HL7Base<UniversalId>
					{

						private const string _id = "SCH.19.4.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.19.4.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
					/// </summary>
					public class UniversalIdType : HL7Base<UniversalIdType>
					{

						private const string _id = "SCH.19.4.3";
						public override string Id
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
				/// SCH.19.5 - This component specifies the code for the status or availability of the location. For example, it may convey bed status. Refer to User-defined Table 0306 - Location Status for suggested values.
				/// </summary>
				public class LocationStatus : HL7Base<LocationStatus>
				{

					private const string _id = "SCH.19.5";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.19.6 - Person location type is the categorization of the persons location defined by facility, building, floor, point of care, room or bed. Although not a required field, when used, it may be the only populated field. It usually includes values such as nursing unit, department, clinic, SNF, physicians office. Refer to User-defined Table 0305 - Person location type for suggested values.
				/// </summary>
				public class PersonLocationType : HL7Base<PersonLocationType>
				{

					private const string _id = "SCH.19.6";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.19.7 - This component specifies the code for the building where the person is located. After facility, it is the most general person location designation. Refer to User-defined Table 0307 - Building for suggested values.
				/// </summary>
				public class Building : HL7Base<Building>
				{

					private const string _id = "SCH.19.7";
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
					/// SCH.19.7.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
					/// </summary>
					public class NamespaceId : HL7Base<NamespaceId>
					{

						private const string _id = "SCH.19.7.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.19.7.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
					/// </summary>
					public class UniversalId : HL7Base<UniversalId>
					{

						private const string _id = "SCH.19.7.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.19.7.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
					/// </summary>
					public class UniversalIdType : HL7Base<UniversalIdType>
					{

						private const string _id = "SCH.19.7.3";
						public override string Id
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
				/// SCH.19.8 - This component specifies the code for the floor where the person is located. After building, it is the most general person location designation. Refer to User-defined Table 0308 - Floor for suggested values.
				/// </summary>
				public class Floor : HL7Base<Floor>
				{

					private const string _id = "SCH.19.8";
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
					/// SCH.19.8.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
					/// </summary>
					public class NamespaceId : HL7Base<NamespaceId>
					{

						private const string _id = "SCH.19.8.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.19.8.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
					/// </summary>
					public class UniversalId : HL7Base<UniversalId>
					{

						private const string _id = "SCH.19.8.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.19.8.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
					/// </summary>
					public class UniversalIdType : HL7Base<UniversalIdType>
					{

						private const string _id = "SCH.19.8.3";
						public override string Id
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
				/// SCH.19.9 - This component describes the location in free text.
				/// </summary>
				public class LocationDescription : HL7Base<LocationDescription>
				{

					private const string _id = "SCH.19.9";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.19.10 - The unique identifier that represents the physical location as a whole without regard for the individual components. This accommodates sites that may have a different method of defining physical units or who may code at a less granular level. For example, point of care, room, and bed may be 1 indivisible code.
				/// </summary>
				public class ComprehensiveLocationIdentifier : HL7Base<ComprehensiveLocationIdentifier>
				{

					private const string _id = "SCH.19.10";
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
					/// SCH.19.10.1 - The first component, entity identifier, is usually defined to be unique within the series of identifiers created by the assigning authority, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, "HD - hierarchic designator".
					/// </summary>
					public class EntityIdentifier : HL7Base<EntityIdentifier>
					{

						private const string _id = "SCH.19.10.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.19.10.2 - See Section 2.A.33.1, "Namespace ID (IS)" for definition. The component intentionally remains associated with the IS data type in v 2.7.The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363  Assigning Authority for suggested values.Note When the HD is used as a part of another data type, in this case as part of the EI data type, this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment. By site agreement, implementers may continue to use User-defined Table 0300  Namespace ID for the first component
					/// </summary>
					public class NamespaceId : HL7Base<NamespaceId>
					{

						private const string _id = "SCH.19.10.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.19.10.3 - See Section 2.A.33.2, "Universal ID (ST)" for definition.
					/// </summary>
					public class UniversalId : HL7Base<UniversalId>
					{

						private const string _id = "SCH.19.10.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.19.10.4 - Refer to HL7 Table 0301 - Universal ID Type for valid values. See Section 2.A.33.3, "Universal ID Type (ID)," for definition.
					/// </summary>
					public class UniversalIdType : HL7Base<UniversalIdType>
					{

						private const string _id = "SCH.19.10.4";
						public override string Id
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
				/// SCH.19.11 - The entity that creates the data for the individual physical location components. If populated, it should be the authority for all components populated. Refer to User-defined Table 0363  Assigning Authority for suggested values for the first sub-component of the HD component, namespace ID.This component makes it possible for codes to be differentiated when the field in which this data type is used repeats.Note When the HD data type is used in a given segment as a component of a field of another data type, User-defined Table 0300 - Namespace ID (referenced by the first sub-component of the HD component) may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.By site agreement, implementors may continue to use User-defined Table 0300  Namespace ID for the first sub-component.
				/// </summary>
				public class AssigningAuthorityForLocation : HL7Base<AssigningAuthorityForLocation>
				{

					private const string _id = "SCH.19.11";
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
					/// SCH.19.11.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
					/// </summary>
					public class NamespaceId : HL7Base<NamespaceId>
					{

						private const string _id = "SCH.19.11.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.19.11.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
					/// </summary>
					public class UniversalId : HL7Base<UniversalId>
					{

						private const string _id = "SCH.19.11.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.19.11.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
					/// </summary>
					public class UniversalIdType : HL7Base<UniversalIdType>
					{

						private const string _id = "SCH.19.11.3";
						public override string Id
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
			/// SCH.20 - This field identifies the person responsible for entering the request for the scheduling of an appointment.  It is included to provide an audit trail of persons responsible for the request.  This person may be someone other than the placer contact person, who is responsible for entering orders and requests. This field should not have been made required but is retained as such for reasons of backwards compatibility.
			/// </summary>
			public class EnteredByPerson : HL7Base<EnteredByPerson>
			{

				private const string _id = "SCH.20";
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
				/// SCH.20.1 - This component carries the Person Identifier itself. XCN.1, in conjunction with XCN.9 uniquely identifies the entity/person. XCN.1 is required if XCN.2 is not populated. Both may be populated. 
				/// </summary>
				public class PersonIdentifier : HL7Base<PersonIdentifier>
				{

					private const string _id = "SCH.20.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.20.2 - This component allows full specification of the surname of a person. Where appropriate, it differentiates the person's own surname from that of the person's partner or spouse, in cases where the person's name may contain elements from either name. It also permits messages to distinguish the surname prefix (such as "van" or "de") from the surname root. See section 2.A.30, "FN - family name".XCN.2 is required if XCN.1 is not populated. Both may be populated.
				/// </summary>
				public class FamilyName : HL7Base<FamilyName>
				{

					private const string _id = "SCH.20.2";
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
					/// SCH.20.2.1 - The atomic element of the person's family name. In most Western usage, this is the person's last name.
					/// </summary>
					public class Surname : HL7Base<Surname>
					{

						private const string _id = "SCH.20.2.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.2.2 - Internationalization usage for Germanic languages. This component is optional. An example of a surname prefix is the "van" in "Ludwig van Beethoven". Since the surname prefix doesn't sort completely alphabetically, it is reasonable to specify it as a separate sub-component of the PN and extended PN data types (XPN and XCN).Note Subcomponents own surname prefix, own surname, surname prefix from partner/spouse and surname from partner/spouse decompose complex Germanic names such as Martha de Mum-van Beethoven. If these subcomponents are valued, the surname subcomponent should still be fully valued for backward compatibility, i.e., de Mum-van Beethoven&de&Mum&van&Beethoven.Also, for clarity, the last name prefix has been renamed to own surname prefix.
					/// </summary>
					public class OwnSurnamePrefix : HL7Base<OwnSurnamePrefix>
					{

						private const string _id = "SCH.20.2.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.2.3 - The portion of the surname (in most Western usage, the last name) that is derived from the person's own surname, as distinguished from any portion that is derived from the surname of the person's partner or spouse. This component is optional.If the person's surname has legally changed to become (or incorporate) the surname of the person's partner or spouse, this is the person's surname immediately prior to such change. Often this is the person's "maiden name".
					/// </summary>
					public class OwnSurname : HL7Base<OwnSurname>
					{

						private const string _id = "SCH.20.2.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.2.4 - Internationalization usage for Germanic languages. This component is optional. An example of a surname prefix is the van in "Ludwig van Beethoven". Since the surname prefix doesn't sort completely alphabetically, it is reasonable to specify it as a separate sub-component of the PN and extended PN data types (XPN and XCN). Note Subcomponents own surname prefix, own surname, surname prefix from partner/spouse and surname from partner/spouse decompose complex Germanic names such as Martha de Mum-van Beethoven. If these subcomponents are valued, the surname subcomponent should still be fully valued for backward compatibility, i.e., de Mum-van Beethoven&de&Mum&van&Beethoven.Also, for clarity, the last name prefix has been renamed to own surname prefix.
					/// </summary>
					public class SurnamePrefixFromPartnerSpouse : HL7Base<SurnamePrefixFromPartnerSpouse>
					{

						private const string _id = "SCH.20.2.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.2.5 - The portion of the person's surname (in most Western usage, the last name) that is derived from the surname of the person's partner or spouse, as distinguished from the part derived from the person's own surname. This component is optional.If no portion of the person's surname is derived from the surname of the person's partner or spouse, this component is not valued. Otherwise, if the surname of the partner or spouse has legally changed to become (or incorporate) the person's surname, this is the surname of the partner or spouse immediately prior to such change.
					/// </summary>
					public class SurnameFromPartnerSpouse : HL7Base<SurnameFromPartnerSpouse>
					{

						private const string _id = "SCH.20.2.5";
						public override string Id
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
				/// SCH.20.3 - First name.
				/// </summary>
				public class GivenName : HL7Base<GivenName>
				{

					private const string _id = "SCH.20.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.20.4 - Multiple middle names may be included by separating them with spaces.
				/// </summary>
				public class SecondAndFurtherGivenNamesOrInitialsThereof : HL7Base<SecondAndFurtherGivenNamesOrInitialsThereof>
				{

					private const string _id = "SCH.20.4";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.20.5 - Used to specify a name suffix (e.g., Jr. or III).
				/// </summary>
				public class SuffixegJrOrIii : HL7Base<SuffixegJrOrIii>
				{

					private const string _id = "SCH.20.5";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.20.6 - Used to specify a name prefix (e.g., Dr.).
				/// </summary>
				public class PrefixegDr : HL7Base<PrefixegDr>
				{

					private const string _id = "SCH.20.6";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.20.7 - Attention The XCN-7 component was deprecated as of v2.5 and the detail was withdrawn and removed from the standard as of v27.. Refer to XCN.21 Professional Suffix.
				/// </summary>
				public class DegreeegMd : HL7Base<DegreeegMd>
				{

					private const string _id = "SCH.20.7";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.20.8 - Attention Retained for backwards compatibility only as of v 2.7. The reader is referred to XCN.9 instead.User-defined Table 0297  CN ID source is used as the HL7 identifier for the user-defined table of values for this component. Used to delineate the first component.
				/// </summary>
				public class SourceTable : HL7Base<SourceTable>
				{

					private const string _id = "SCH.20.8";
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
					/// SCH.20.8.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "SCH.20.8.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.8.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "SCH.20.8.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.8.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "SCH.20.8.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.8.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "SCH.20.8.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.8.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "SCH.20.8.5";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.8.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "SCH.20.8.6";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.8.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "SCH.20.8.7";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.8.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "SCH.20.8.8";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.8.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "SCH.20.8.9";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.8.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "SCH.20.8.10";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.8.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "SCH.20.8.11";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.8.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "SCH.20.8.12";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.8.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "SCH.20.8.13";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.8.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "SCH.20.8.14";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.8.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "SCH.20.8.15";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.8.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "SCH.20.8.16";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.8.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "SCH.20.8.17";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.8.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "SCH.20.8.18";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.8.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "SCH.20.8.19";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.8.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "SCH.20.8.20";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.8.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "SCH.20.8.21";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.8.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "SCH.20.8.22";
						public override string Id
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
				/// SCH.20.9 - The assigning authority is a unique identifier of the system (or organization or agency of department) that creates the data. User-defined Table 0363  Assigning Authority is used as the HL7 identifier for the user-defined table of values for the first sub-component of the HD component, namespace ID.As of v 2.7, the Assigning Authority is conditional. It is required if XCN.1 is populated and neither XCN.22 nor XCN.23 are populated. All 3 components may be populated. No assumptions can be safely made based on position or sequence. Best practice is to send an OID in this component when populated.The reader is referred to XCN.22 and XCN.23 if there is a need to transmit values with semantic meaning for an assigning jurisdiction or assigning department or agency in addition to, or instead of, an assigning authority. However, all 3 components may be valued.  If, in so doing, it is discovered that the values in XCN.22 and/or XCN.23 conflict with XCN.9, the user would look to the Message Profile or other implementation agreement for a statement as to which takes precedence.Note When the HD data type is used in a given segment as a component of a field of another data type, User-defined Table 0300 - Namespace ID (referenced by the first sub-component of the HD component) may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.By site agreement, implementors may continue to use User-defined Table 0300  Namespace ID for the first sub-component.
				/// </summary>
				public class AssigningAuthority : HL7Base<AssigningAuthority>
				{

					private const string _id = "SCH.20.9";
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
					/// SCH.20.9.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
					/// </summary>
					public class NamespaceId : HL7Base<NamespaceId>
					{

						private const string _id = "SCH.20.9.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.9.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
					/// </summary>
					public class UniversalId : HL7Base<UniversalId>
					{

						private const string _id = "SCH.20.9.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.9.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
					/// </summary>
					public class UniversalIdType : HL7Base<UniversalIdType>
					{

						private const string _id = "SCH.20.9.3";
						public override string Id
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
				/// SCH.20.10 - A code that represents the type of name. Refer to HL7 Table 0200 - Name Type for valid values. See Section 2.A.89.7, "Name Type Code (ID)".As of v 2.7, XCN.10 is conditional. It is required if XCN.2 is populated.
				/// </summary>
				public class NameTypeCode : HL7Base<NameTypeCode>
				{

					private const string _id = "SCH.20.10";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.20.11 - This component contains the digit, or digits, exclusive of the identifier in XCN.1, calculated by applying an algorithm to all or some of the digits in the number, which may be used to test validity of the non-check-digit identifier.
				/// </summary>
				public class IdentifierCheckDigit : HL7Base<IdentifierCheckDigit>
				{

					private const string _id = "SCH.20.11";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.20.12 - Contains the code identifying the check digit scheme employed.Refer to HL7 Table 0061 - Check Digit Scheme for valid values.
				/// </summary>
				public class CheckDigitScheme : HL7Base<CheckDigitScheme>
				{

					private const string _id = "SCH.20.12";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.20.13 - A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the assigning authority component. Refer to HL7 Table 0203 - Identifier Type for suggested values.As of v 2.7, XCN.13 is conditional. It is required if XCN.1 is populated.
				/// </summary>
				public class IdentifierTypeCode : HL7Base<IdentifierTypeCode>
				{

					private const string _id = "SCH.20.13";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.20.14 - The place or location identifier where the identifier was first assigned to the person. This component is not an inherent part of the identifier but rather part of the history of the identifier as part of this data type, its existence is a convenience for certain intercommunicating systems.Note When the HD data type is used in a given segment as a component of a field of another data type, User-defined Table 0300 - Namespace ID (referenced by the first sub-component of the HD component) may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
				/// </summary>
				public class AssigningFacility : HL7Base<AssigningFacility>
				{

					private const string _id = "SCH.20.14";
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
					/// SCH.20.14.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
					/// </summary>
					public class NamespaceId : HL7Base<NamespaceId>
					{

						private const string _id = "SCH.20.14.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.14.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
					/// </summary>
					public class UniversalId : HL7Base<UniversalId>
					{

						private const string _id = "SCH.20.14.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.14.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
					/// </summary>
					public class UniversalIdType : HL7Base<UniversalIdType>
					{

						private const string _id = "SCH.20.14.3";
						public override string Id
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
				/// SCH.20.15 - Different name/address types and representations of the same name/address should be described by repeating of this field, with different values of the name/address type and/or name/address representation component.Note This new component remains in alphabetic representation with each repetition of the field using these data types. I.e., even though the name may be represented in an ideographic character set, this component will remain represented in an alphabetic character set.Refer to HL7 Table 0465  Name/address Representation for valid values.In general this component provides an indication of the representation provided by the data item. It does not necessarily specify the character sets used. Thus, even though the representation might provide an indication of what to expect, the sender is still free to encode the contents using whatever character set is desired. This component provides only hints for the receiver, so it can make choices regarding what it has been sent and what it is capable of displaying.
				/// </summary>
				public class NameRepresentationCode : HL7Base<NameRepresentationCode>
				{

					private const string _id = "SCH.20.15";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.20.16 - This component is used to designate the context in which a name is used. The main use case is in Australian healthcare for indigenous patients who prefer to use different names when attending different healthcare institutions. Another use case occurs in the US where health practitioners can be licensed under slightly different names and the reporting of the correct name is vital for administrative purposes. Refer to User-defined Table 0448  Name Context for suggested values.
				/// </summary>
				public class NameContext : HL7Base<NameContext>
				{

					private const string _id = "SCH.20.16";
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
					/// SCH.20.16.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "SCH.20.16.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.16.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "SCH.20.16.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.16.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "SCH.20.16.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.16.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "SCH.20.16.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.16.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "SCH.20.16.5";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.16.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "SCH.20.16.6";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.16.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "SCH.20.16.7";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.16.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "SCH.20.16.8";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.16.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "SCH.20.16.9";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.16.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "SCH.20.16.10";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.16.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "SCH.20.16.11";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.16.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "SCH.20.16.12";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.16.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "SCH.20.16.13";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.16.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "SCH.20.16.14";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.16.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "SCH.20.16.15";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.16.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "SCH.20.16.16";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.16.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "SCH.20.16.17";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.16.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "SCH.20.16.18";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.16.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "SCH.20.16.19";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.16.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "SCH.20.16.20";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.16.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "SCH.20.16.21";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.16.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "SCH.20.16.22";
						public override string Id
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
				/// SCH.20.17 - Attention The XCN.17 component was deprecated as of v2.5 and the detail was withdrawn and removed from the standard as of v 2.7. Refer to XCN.19 Effective Date and XCN.20 Expiration Date instead.This component contains the start and end date/times that define the period during which this name was valid.
				/// </summary>
				public class NameValidityRange : HL7Base<NameValidityRange>
				{

					private const string _id = "SCH.20.17";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.20.18 - A code that represents the preferred display order of the components of this person name. Refer to HL7 Table 0444 - Name Assembly Order for valid values.
				/// </summary>
				public class NameAssemblyOrder : HL7Base<NameAssemblyOrder>
				{

					private const string _id = "SCH.20.18";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.20.19 - The first date, if known, on which the person name is valid and active.
				/// </summary>
				public class EffectiveDate : HL7Base<EffectiveDate>
				{

					private const string _id = "SCH.20.19";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.20.20 - The last date, if known, on which the person name is valid and active.
				/// </summary>
				public class ExpirationDate : HL7Base<ExpirationDate>
				{

					private const string _id = "SCH.20.20";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.20.21 - Used to specify an abbreviation, or a string of abbreviations denoting qualifications that support the persons profession, (e.g., licenses, certificates, degrees, affiliations with professional societies, etc.). The Professional Suffix normally follows the Family Name when the Person Name is used for display purposes. Please note that this component is an unformatted string and is used for display purposes only. Detailed information regarding the contents of Professional Suffix is obtained using appropriate segments in Chapter 15, "Personnel Management".
				/// </summary>
				public class ProfessionalSuffix : HL7Base<ProfessionalSuffix>
				{

					private const string _id = "SCH.20.21";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.20.22 - The geo-political body that assigned the identifier in XCN.1. As of v 2.7, the Assigning Jurisdiction is conditional. It is required if XCN.1 is populated and neither XCN.9 nor XCN.23 are populated. All 3 components may be populated. The reader is referred to XCN.9 if there is a need to transmit this information as an OID.
				/// </summary>
				public class AssigningJurisdiction : HL7Base<AssigningJurisdiction>
				{

					private const string _id = "SCH.20.22";
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
					/// SCH.20.22.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "SCH.20.22.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.22.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "SCH.20.22.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.22.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "SCH.20.22.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.22.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "SCH.20.22.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.22.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "SCH.20.22.5";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.22.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "SCH.20.22.6";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.22.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "SCH.20.22.7";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.22.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "SCH.20.22.8";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.22.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "SCH.20.22.9";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.22.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "SCH.20.22.10";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.22.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "SCH.20.22.11";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.22.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "SCH.20.22.12";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.22.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "SCH.20.22.13";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.22.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "SCH.20.22.14";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.22.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "SCH.20.22.15";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.22.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "SCH.20.22.16";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.22.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "SCH.20.22.17";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.22.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "SCH.20.22.18";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.22.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "SCH.20.22.19";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.22.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "SCH.20.22.20";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.22.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "SCH.20.22.21";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.22.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "SCH.20.22.22";
						public override string Id
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
				/// SCH.20.23 - The agency or department that assigned the identifier in XCN.1.As of v 2.7, the Assigning Jurisdiction is conditional. It is required if XCN.1 is populated and neither XCN.9 nor XCN.22 are populated. All 3 components may be populated. The reader is referred to XCN.9 if there is a need to transmit this information as an OID.
				/// </summary>
				public class AssigningAgencyOrDepartment : HL7Base<AssigningAgencyOrDepartment>
				{

					private const string _id = "SCH.20.23";
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
					/// SCH.20.23.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "SCH.20.23.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.23.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "SCH.20.23.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.23.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "SCH.20.23.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.23.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "SCH.20.23.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.23.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "SCH.20.23.5";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.23.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "SCH.20.23.6";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.23.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "SCH.20.23.7";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.23.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "SCH.20.23.8";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.23.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "SCH.20.23.9";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.23.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "SCH.20.23.10";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.23.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "SCH.20.23.11";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.23.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "SCH.20.23.12";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.23.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "SCH.20.23.13";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.23.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "SCH.20.23.14";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.23.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "SCH.20.23.15";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.23.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "SCH.20.23.16";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.23.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "SCH.20.23.17";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.23.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "SCH.20.23.18";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.23.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "SCH.20.23.19";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.23.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "SCH.20.23.20";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.23.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "SCH.20.23.21";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.20.23.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "SCH.20.23.22";
						public override string Id
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
				/// SCH.20.24 - This component is used to communicate a version code that may be assigned to the value given in XCN.1 Person Identifier.
				/// </summary>
				public class SecurityCheck : HL7Base<SecurityCheck>
				{

					private const string _id = "SCH.20.24";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.20.25 - This component is used to transmit information intended to validate the veracity of the supplied identifier or the presenter of the identifier. For example, this component may be used to ensure that the presenter of a credit card is an authorized user of that card.Refer to HL7 Table 0904 - Security Check Scheme for valid values
				/// </summary>
				public class SecurityCheckScheme : HL7Base<SecurityCheckScheme>
				{

					private const string _id = "SCH.20.25";
					public override string Id
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
			/// SCH.21 - This field contains the phone number used to contact the ARQ-19-Entered by Person.
			/// </summary>
			public class EnteredByPhoneNumber : HL7Base<EnteredByPhoneNumber>
			{

				private const string _id = "SCH.21";
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
				/// SCH.21.1 - Attention The XTN-1 component was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v2.6.
				/// </summary>
				public class TelephoneNumber : HL7Base<TelephoneNumber>
				{

					private const string _id = "SCH.21.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.21.2 - A code that represents a specific use of a telecommunication number. Refer to HL7 Table 0201 - Telecommunication Use Code for valid values. This component along with XTN.3 describes the nature of the telecommunication data that follows. Best practice requires the population of XTN.2 when XTN.4 or XTN.7 is populated. 
				/// </summary>
				public class TelecommunicationUseCode : HL7Base<TelecommunicationUseCode>
				{

					private const string _id = "SCH.21.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.21.3 - A code that represents the type of telecommunication equipment. Refer to HL7 Table 0202 - Telecommunication Equipment Type for valid values. This component along with XTN.2 describes the nature of the telecommunication data that follows and is necessary to accurately interpret it.
				/// </summary>
				public class TelecommunicationEquipmentType : HL7Base<TelecommunicationEquipmentType>
				{

					private const string _id = "SCH.21.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.21.4 - This component is required if, and only allowed if, XTN.7 or XTN.12 are not populated.  Note If any of the HL7 delimiters are found in the Communication Address, such as , the appropriate HL7 escape sequence SHALL be used when encoding an Internet address (see Chapter 2, "Control", section 2.7.1, "Formatting Codes").
				/// </summary>
				public class CommunicationAddress : HL7Base<CommunicationAddress>
				{

					private const string _id = "SCH.21.4";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.21.5 - The numeric code assigned by the International Telecommunication Union in standard E.164 to access telephone services in another country.  For example, "+1" is the country code for the United States, "+49" is the code for Germany.
				/// </summary>
				public class CountryCode : HL7Base<CountryCode>
				{

					private const string _id = "SCH.21.5";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.21.6 - The numeric code to access telephone services in another area/city within a country. This number historically needs not be dialed if the caller is located in the same area/city as the phone number of the called party.The use and size of area/city codes is however country specific some countries do not use area/city codes, or the use of area/city codes may be mandatory when dialing, or area/city codes may be used to group phone numbers based on other criteria than geographic location, such as cell-phone area/city-codes, or free information numbers (e.g., 800 numbers).Most countries have a prefix for Area/City codes which only has to be dialed if one doesn't use a country code. This prefix (mostly "0", sometimes "9") should be omitted from the content of this field. If the prefix for the Area/Code is also mandatory if one uses the country code (e.g., in Italy) then this field should also contain the prefix.
				/// </summary>
				public class AreaCityCode : HL7Base<AreaCityCode>
				{

					private const string _id = "SCH.21.6";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.21.7 - The numeric code used to contact the called party, exclusive of country and area/city codes. The Local Number is required when, and allowed only if, XTN.4 and XTN.12 are not populated. The size of the Local Number is country specific.Note that the Local Number does not include the numeric codes that have to be dialed once a connection has been established. Examples include (automated) organizational phone systems which allow external callers to dial additional numeric codes. These additional numeric codes should be specified as an extension.
				/// </summary>
				public class LocalNumber : HL7Base<LocalNumber>
				{

					private const string _id = "SCH.21.7";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.21.8 - The numeric code to contact the called party used within an organization, e.g., the number used if both caller and called party are located within the same organization. The extension is often the same as the last few digits of the Local Number. The use of extensions is country and site specific, and may depend on the type of phone system (PBX) used by the organization.
				/// </summary>
				public class Extension : HL7Base<Extension>
				{

					private const string _id = "SCH.21.8";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.21.9 - Contains comments with respect to the telephone number.Example Do not use after 5PM
				/// </summary>
				public class AnyText : HL7Base<AnyText>
				{

					private const string _id = "SCH.21.9";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.21.10 - The characters established within a companys internal telephone system network used as a prefix to the Extension component for internal dialing. Note that the use of Extension Prefix requires that the Extension component be valued and that digits, as well as special characters (e.g., *, #) may be used.
				/// </summary>
				public class ExtensionPrefix : HL7Base<ExtensionPrefix>
				{

					private const string _id = "SCH.21.10";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.21.11 - The characters established within a companys internal telephone system used in place of the (external) telephone number to facilitate calling because its length is shorter than that of the telephone number. Note that digits, as well as special characters (e.g., *, #) may be used.
				/// </summary>
				public class SpeedDialCode : HL7Base<SpeedDialCode>
				{

					private const string _id = "SCH.21.11";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.21.12 - An expression of the telephone number as an unparsable string. The Unformatted Telephone number is required when, and allowed only if, XTN.4 and XTN.7 are not populated.The phone number was entered as free text and sending system does not know how to parse it. Example 1-800-Dentist
				/// </summary>
				public class UnformattedTelephoneNumber : HL7Base<UnformattedTelephoneNumber>
				{

					private const string _id = "SCH.21.12";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.21.13 - The first date, if known, on which the telecommunication number is valid and active.
				/// </summary>
				public class EffectiveStartDate : HL7Base<EffectiveStartDate>
				{

					private const string _id = "SCH.21.13";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.21.14 - The last date, if known, on which the telecommunication number is valid and active.
				/// </summary>
				public class ExpirationDate : HL7Base<ExpirationDate>
				{

					private const string _id = "SCH.21.14";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.21.15 - Indicates why this contact number/e-mail was marked as "ended".  Refer to User-defined Table 0868  Telecommunication Expiration Reason for valid values.
				/// </summary>
				public class ExpirationReason : HL7Base<ExpirationReason>
				{

					private const string _id = "SCH.21.15";
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
					/// SCH.21.15.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "SCH.21.15.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.21.15.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "SCH.21.15.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.21.15.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "SCH.21.15.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.21.15.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "SCH.21.15.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.21.15.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "SCH.21.15.5";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.21.15.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "SCH.21.15.6";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.21.15.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "SCH.21.15.7";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.21.15.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "SCH.21.15.8";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.21.15.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "SCH.21.15.9";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.21.15.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "SCH.21.15.10";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.21.15.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "SCH.21.15.11";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.21.15.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "SCH.21.15.12";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.21.15.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "SCH.21.15.13";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.21.15.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "SCH.21.15.14";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.21.15.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "SCH.21.15.15";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.21.15.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "SCH.21.15.16";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.21.15.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "SCH.21.15.17";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.21.15.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "SCH.21.15.18";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.21.15.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "SCH.21.15.19";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.21.15.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "SCH.21.15.20";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.21.15.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "SCH.21.15.21";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.21.15.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "SCH.21.15.22";
						public override string Id
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
				/// SCH.21.16 - Indicates whether this information is considered sensitive or should be protected in some way. Refer to User-defined table 0618 - Protection Code for suggested values.The specific set of codes and appropriate handling of such telecommunications addresses will vary by jurisdiction and is subject to site-specific negotiation. For example, a provider address marked as 'unlisted' might not be printed in an internal address listing.
				/// </summary>
				public class ProtectionCode : HL7Base<ProtectionCode>
				{

					private const string _id = "SCH.21.16";
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
					/// SCH.21.16.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
					/// </summary>
					public class Identifier : HL7Base<Identifier>
					{

						private const string _id = "SCH.21.16.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.21.16.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
					/// </summary>
					public class Text : HL7Base<Text>
					{

						private const string _id = "SCH.21.16.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.21.16.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
					/// </summary>
					public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
					{

						private const string _id = "SCH.21.16.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.21.16.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
					/// </summary>
					public class AlternateIdentifier : HL7Base<AlternateIdentifier>
					{

						private const string _id = "SCH.21.16.4";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.21.16.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
					/// </summary>
					public class AlternateText : HL7Base<AlternateText>
					{

						private const string _id = "SCH.21.16.5";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.21.16.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
					{

						private const string _id = "SCH.21.16.6";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.21.16.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
					/// </summary>
					public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
					{

						private const string _id = "SCH.21.16.7";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.21.16.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
					/// </summary>
					public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
					{

						private const string _id = "SCH.21.16.8";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.21.16.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
					/// </summary>
					public class OriginalText : HL7Base<OriginalText>
					{

						private const string _id = "SCH.21.16.9";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.21.16.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
					/// </summary>
					public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
					{

						private const string _id = "SCH.21.16.10";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.21.16.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
					/// </summary>
					public class SecondAlternateText : HL7Base<SecondAlternateText>
					{

						private const string _id = "SCH.21.16.11";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.21.16.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
					/// </summary>
					public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
					{

						private const string _id = "SCH.21.16.12";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.21.16.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
					/// </summary>
					public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
					{

						private const string _id = "SCH.21.16.13";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.21.16.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
					/// </summary>
					public class CodingSystemOid : HL7Base<CodingSystemOid>
					{

						private const string _id = "SCH.21.16.14";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.21.16.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class ValueSetOid : HL7Base<ValueSetOid>
					{

						private const string _id = "SCH.21.16.15";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.21.16.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
					/// </summary>
					public class ValueSetVersionId : HL7Base<ValueSetVersionId>
					{

						private const string _id = "SCH.21.16.16";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.21.16.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
					/// </summary>
					public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
					{

						private const string _id = "SCH.21.16.17";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.21.16.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
					{

						private const string _id = "SCH.21.16.18";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.21.16.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
					/// </summary>
					public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
					{

						private const string _id = "SCH.21.16.19";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.21.16.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
					/// </summary>
					public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
					{

						private const string _id = "SCH.21.16.20";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.21.16.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
					/// </summary>
					public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
					{

						private const string _id = "SCH.21.16.21";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.21.16.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
					/// </summary>
					public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
					{

						private const string _id = "SCH.21.16.22";
						public override string Id
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
				/// SCH.21.17 - A unique identifier for the phone number or e-mail address.This component allows a phone number to be uniquely identified, and enables the linking of a single phone number to multiple people and contexts. For example, each member of a family living at the same location would share the same phone number, having the same identifier. A correction to the phone number of one family member could be automatically propagated to other members of the family.HL7 does not assume responsibility for the processing rules for this component.
				/// </summary>
				public class SharedTelecommunicationIdentifier : HL7Base<SharedTelecommunicationIdentifier>
				{

					private const string _id = "SCH.21.17";
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
					/// SCH.21.17.1 - The first component, entity identifier, is usually defined to be unique within the series of identifiers created by the assigning authority, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, "HD - hierarchic designator".
					/// </summary>
					public class EntityIdentifier : HL7Base<EntityIdentifier>
					{

						private const string _id = "SCH.21.17.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.21.17.2 - See Section 2.A.33.1, "Namespace ID (IS)" for definition. The component intentionally remains associated with the IS data type in v 2.7.The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363  Assigning Authority for suggested values.Note When the HD is used as a part of another data type, in this case as part of the EI data type, this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment. By site agreement, implementers may continue to use User-defined Table 0300  Namespace ID for the first component
					/// </summary>
					public class NamespaceId : HL7Base<NamespaceId>
					{

						private const string _id = "SCH.21.17.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.21.17.3 - See Section 2.A.33.2, "Universal ID (ST)" for definition.
					/// </summary>
					public class UniversalId : HL7Base<UniversalId>
					{

						private const string _id = "SCH.21.17.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, false, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.21.17.4 - Refer to HL7 Table 0301 - Universal ID Type for valid values. See Section 2.A.33.3, "Universal ID Type (ID)," for definition.
					/// </summary>
					public class UniversalIdType : HL7Base<UniversalIdType>
					{

						private const string _id = "SCH.21.17.4";
						public override string Id
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
				/// SCH.21.18 - For an entity having multiple telecommunication addresses, indicates which is the "most preferred" (lowest number) to "least preferred" (highest number).If the preference order is unique across all usages for a given type, then it indicates the preference across all usages, (e.g. first try my home number, then my business number). If the preference order is unique across all usages and types, then it indicates the preference across all types of telecommunication addresses.  (E.g., first try my phone if that doesn't work, use my pager.) Otherwise, the preference order is assumed to only apply within a specific type and usage.Preference order numbers need not be sequential (i.e., three numbers with the priority orders of 0, 5 and 15 are legitimate).  The preference order numbers must be non-negative.
				/// </summary>
				public class PreferenceOrder : HL7Base<PreferenceOrder>
				{

					private const string _id = "SCH.21.18";
					public override string Id
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
			/// SCH.22 - This field contains a code that identifies the location of the entered by person.  
			/// </summary>
			public class EnteredByLocation : HL7Base<EnteredByLocation>
			{

				private const string _id = "SCH.22";
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
				/// SCH.22.1 - This component specifies the code for the point where patient care is administered. It is conditional on PL.6 Person Location Type (e.g., nursing unit or department or clinic). After floor, it is the most general patient location designation. Refer to User-defined Table 0302 - Point of Care for suggested values.
				/// </summary>
				public class PointOfCare : HL7Base<PointOfCare>
				{

					private const string _id = "SCH.22.1";
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
					/// SCH.22.1.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
					/// </summary>
					public class NamespaceId : HL7Base<NamespaceId>
					{

						private const string _id = "SCH.22.1.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.22.1.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
					/// </summary>
					public class UniversalId : HL7Base<UniversalId>
					{

						private const string _id = "SCH.22.1.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.22.1.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
					/// </summary>
					public class UniversalIdType : HL7Base<UniversalIdType>
					{

						private const string _id = "SCH.22.1.3";
						public override string Id
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
				/// SCH.22.2 - This component specifies the code for the patient's room. After point of care, it is the most general person location designation. Refer to User-defined Table 0303 - Room for suggested values.
				/// </summary>
				public class Room : HL7Base<Room>
				{

					private const string _id = "SCH.22.2";
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
					/// SCH.22.2.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
					/// </summary>
					public class NamespaceId : HL7Base<NamespaceId>
					{

						private const string _id = "SCH.22.2.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.22.2.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
					/// </summary>
					public class UniversalId : HL7Base<UniversalId>
					{

						private const string _id = "SCH.22.2.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.22.2.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
					/// </summary>
					public class UniversalIdType : HL7Base<UniversalIdType>
					{

						private const string _id = "SCH.22.2.3";
						public override string Id
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
				/// SCH.22.3 - This component specifies the code for the patient's bed. After room, it is the most general person location designation. Refer to User-defined Table 0304 - Bed for suggested values.
				/// </summary>
				public class Bed : HL7Base<Bed>
				{

					private const string _id = "SCH.22.3";
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
					/// SCH.22.3.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
					/// </summary>
					public class NamespaceId : HL7Base<NamespaceId>
					{

						private const string _id = "SCH.22.3.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.22.3.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
					/// </summary>
					public class UniversalId : HL7Base<UniversalId>
					{

						private const string _id = "SCH.22.3.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.22.3.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
					/// </summary>
					public class UniversalIdType : HL7Base<UniversalIdType>
					{

						private const string _id = "SCH.22.3.3";
						public override string Id
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
				/// SCH.22.4 - This component is subject to site interpretation but generally describes the highest level physical designation of an institution, medical center or enterprise. It is the most general person location designation. Note When the HD data type is used in a given segment as a component of a field of another data type, User-defined Table 0300 - Namespace ID (referenced by the first sub-component of the HD component) may be redefined (given a different user-defined table number and name) by the technical committee responsible for that segment.
				/// </summary>
				public class Facility : HL7Base<Facility>
				{

					private const string _id = "SCH.22.4";
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
					/// SCH.22.4.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
					/// </summary>
					public class NamespaceId : HL7Base<NamespaceId>
					{

						private const string _id = "SCH.22.4.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.22.4.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
					/// </summary>
					public class UniversalId : HL7Base<UniversalId>
					{

						private const string _id = "SCH.22.4.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.22.4.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
					/// </summary>
					public class UniversalIdType : HL7Base<UniversalIdType>
					{

						private const string _id = "SCH.22.4.3";
						public override string Id
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
				/// SCH.22.5 - This component specifies the code for the status or availability of the location. For example, it may convey bed status. Refer to User-defined Table 0306 - Location Status for suggested values.
				/// </summary>
				public class LocationStatus : HL7Base<LocationStatus>
				{

					private const string _id = "SCH.22.5";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.22.6 - Person location type is the categorization of the persons location defined by facility, building, floor, point of care, room or bed. Although not a required field, when used, it may be the only populated field. It usually includes values such as nursing unit, department, clinic, SNF, physicians office. Refer to User-defined Table 0305 - Person location type for suggested values.
				/// </summary>
				public class PersonLocationType : HL7Base<PersonLocationType>
				{

					private const string _id = "SCH.22.6";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.22.7 - This component specifies the code for the building where the person is located. After facility, it is the most general person location designation. Refer to User-defined Table 0307 - Building for suggested values.
				/// </summary>
				public class Building : HL7Base<Building>
				{

					private const string _id = "SCH.22.7";
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
					/// SCH.22.7.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
					/// </summary>
					public class NamespaceId : HL7Base<NamespaceId>
					{

						private const string _id = "SCH.22.7.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.22.7.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
					/// </summary>
					public class UniversalId : HL7Base<UniversalId>
					{

						private const string _id = "SCH.22.7.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.22.7.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
					/// </summary>
					public class UniversalIdType : HL7Base<UniversalIdType>
					{

						private const string _id = "SCH.22.7.3";
						public override string Id
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
				/// SCH.22.8 - This component specifies the code for the floor where the person is located. After building, it is the most general person location designation. Refer to User-defined Table 0308 - Floor for suggested values.
				/// </summary>
				public class Floor : HL7Base<Floor>
				{

					private const string _id = "SCH.22.8";
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
					/// SCH.22.8.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
					/// </summary>
					public class NamespaceId : HL7Base<NamespaceId>
					{

						private const string _id = "SCH.22.8.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.22.8.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
					/// </summary>
					public class UniversalId : HL7Base<UniversalId>
					{

						private const string _id = "SCH.22.8.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.22.8.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
					/// </summary>
					public class UniversalIdType : HL7Base<UniversalIdType>
					{

						private const string _id = "SCH.22.8.3";
						public override string Id
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
				/// SCH.22.9 - This component describes the location in free text.
				/// </summary>
				public class LocationDescription : HL7Base<LocationDescription>
				{

					private const string _id = "SCH.22.9";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.22.10 - The unique identifier that represents the physical location as a whole without regard for the individual components. This accommodates sites that may have a different method of defining physical units or who may code at a less granular level. For example, point of care, room, and bed may be 1 indivisible code.
				/// </summary>
				public class ComprehensiveLocationIdentifier : HL7Base<ComprehensiveLocationIdentifier>
				{

					private const string _id = "SCH.22.10";
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
					/// SCH.22.10.1 - The first component, entity identifier, is usually defined to be unique within the series of identifiers created by the assigning authority, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, "HD - hierarchic designator".
					/// </summary>
					public class EntityIdentifier : HL7Base<EntityIdentifier>
					{

						private const string _id = "SCH.22.10.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.22.10.2 - See Section 2.A.33.1, "Namespace ID (IS)" for definition. The component intentionally remains associated with the IS data type in v 2.7.The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363  Assigning Authority for suggested values.Note When the HD is used as a part of another data type, in this case as part of the EI data type, this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment. By site agreement, implementers may continue to use User-defined Table 0300  Namespace ID for the first component
					/// </summary>
					public class NamespaceId : HL7Base<NamespaceId>
					{

						private const string _id = "SCH.22.10.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.22.10.3 - See Section 2.A.33.2, "Universal ID (ST)" for definition.
					/// </summary>
					public class UniversalId : HL7Base<UniversalId>
					{

						private const string _id = "SCH.22.10.3";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.22.10.4 - Refer to HL7 Table 0301 - Universal ID Type for valid values. See Section 2.A.33.3, "Universal ID Type (ID)," for definition.
					/// </summary>
					public class UniversalIdType : HL7Base<UniversalIdType>
					{

						private const string _id = "SCH.22.10.4";
						public override string Id
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
				/// SCH.22.11 - The entity that creates the data for the individual physical location components. If populated, it should be the authority for all components populated. Refer to User-defined Table 0363  Assigning Authority for suggested values for the first sub-component of the HD component, namespace ID.This component makes it possible for codes to be differentiated when the field in which this data type is used repeats.Note When the HD data type is used in a given segment as a component of a field of another data type, User-defined Table 0300 - Namespace ID (referenced by the first sub-component of the HD component) may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.By site agreement, implementors may continue to use User-defined Table 0300  Namespace ID for the first sub-component.
				/// </summary>
				public class AssigningAuthorityForLocation : HL7Base<AssigningAuthorityForLocation>
				{

					private const string _id = "SCH.22.11";
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
					/// SCH.22.11.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
					/// </summary>
					public class NamespaceId : HL7Base<NamespaceId>
					{

						private const string _id = "SCH.22.11.1";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.22.11.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
					/// </summary>
					public class UniversalId : HL7Base<UniversalId>
					{

						private const string _id = "SCH.22.11.2";
						public override string Id
						{
							get { return _id; }
						}

						private readonly bool[] _repeatableHierarchy = {false, true, true, true};
						public override bool[] RepeatableHierarchy
						{
							get { return _repeatableHierarchy; }
						}

					}

										/// <summary>
					/// SCH.22.11.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
					/// </summary>
					public class UniversalIdType : HL7Base<UniversalIdType>
					{

						private const string _id = "SCH.22.11.3";
						public override string Id
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
			/// SCH.23 - This field relates a child to its parent, when a parent-child relationship exists.  It contains the placer application's permanent identifier for the parent of the appointment request.  This is a composite field.  The first component is a string that identifies the parent appointment request.  It is assigned by the placer application, and identifies an appointment request uniquely among all such requests from a particular requesting application.
			/// </summary>
			public class ParentPlacerAppointmentId : HL7Base<ParentPlacerAppointmentId>
			{

				private const string _id = "SCH.23";
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
				/// SCH.23.1 - The first component, entity identifier, is usually defined to be unique within the series of identifiers created by the assigning authority, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, "HD - hierarchic designator".
				/// </summary>
				public class EntityIdentifier : HL7Base<EntityIdentifier>
				{

					private const string _id = "SCH.23.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.23.2 - See Section 2.A.33.1, "Namespace ID (IS)" for definition. The component intentionally remains associated with the IS data type in v 2.7.The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363  Assigning Authority for suggested values.Note When the HD is used as a part of another data type, in this case as part of the EI data type, this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment. By site agreement, implementers may continue to use User-defined Table 0300  Namespace ID for the first component
				/// </summary>
				public class NamespaceId : HL7Base<NamespaceId>
				{

					private const string _id = "SCH.23.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.23.3 - See Section 2.A.33.2, "Universal ID (ST)" for definition.
				/// </summary>
				public class UniversalId : HL7Base<UniversalId>
				{

					private const string _id = "SCH.23.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.23.4 - Refer to HL7 Table 0301 - Universal ID Type for valid values. See Section 2.A.33.3, "Universal ID Type (ID)," for definition.
				/// </summary>
				public class UniversalIdType : HL7Base<UniversalIdType>
				{

					private const string _id = "SCH.23.4";
					public override string Id
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
			/// SCH.24 - This field relates a child to its parent, when a parent-child relationship exists.  It contains the filler application's permanent identifier for the parent of the appointment request.  This is a composite field.The first component is a string that identifies the parent appointment request.  It is assigned by the filler application, and it identifies an appointment request uniquely among all such requests on a particular processing application.This is a conditionally required field.  On initial messages where a filler has not yet assigned a filler appointment ID, this field should not contain a value.  In all other subsequent messages, where a filler application has assigned a filler appointment ID, this field is required.
			/// </summary>
			public class ParentFillerAppointmentId : HL7Base<ParentFillerAppointmentId>
			{

				private const string _id = "SCH.24";
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
				/// SCH.24.1 - The first component, entity identifier, is usually defined to be unique within the series of identifiers created by the assigning authority, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, "HD - hierarchic designator".
				/// </summary>
				public class EntityIdentifier : HL7Base<EntityIdentifier>
				{

					private const string _id = "SCH.24.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.24.2 - See Section 2.A.33.1, "Namespace ID (IS)" for definition. The component intentionally remains associated with the IS data type in v 2.7.The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363  Assigning Authority for suggested values.Note When the HD is used as a part of another data type, in this case as part of the EI data type, this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment. By site agreement, implementers may continue to use User-defined Table 0300  Namespace ID for the first component
				/// </summary>
				public class NamespaceId : HL7Base<NamespaceId>
				{

					private const string _id = "SCH.24.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.24.3 - See Section 2.A.33.2, "Universal ID (ST)" for definition.
				/// </summary>
				public class UniversalId : HL7Base<UniversalId>
				{

					private const string _id = "SCH.24.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.24.4 - Refer to HL7 Table 0301 - Universal ID Type for valid values. See Section 2.A.33.3, "Universal ID Type (ID)," for definition.
				/// </summary>
				public class UniversalIdType : HL7Base<UniversalIdType>
				{

					private const string _id = "SCH.24.4";
					public override string Id
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
			/// SCH.25 - This field contains a code describing the status of the appointment with respect to the filler application.  Refer to User-Defined Table 0278 - Filler Status Codes in Chapter 2C, Code Tables, for suggested values.
			/// </summary>
			public class FillerStatusCode : HL7Base<FillerStatusCode>
			{

				private const string _id = "SCH.25";
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
				/// SCH.25.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
				/// </summary>
				public class Identifier : HL7Base<Identifier>
				{

					private const string _id = "SCH.25.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.25.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
				/// </summary>
				public class Text : HL7Base<Text>
				{

					private const string _id = "SCH.25.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.25.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
				/// </summary>
				public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
				{

					private const string _id = "SCH.25.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.25.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
				/// </summary>
				public class AlternateIdentifier : HL7Base<AlternateIdentifier>
				{

					private const string _id = "SCH.25.4";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.25.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
				/// </summary>
				public class AlternateText : HL7Base<AlternateText>
				{

					private const string _id = "SCH.25.5";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.25.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
				{

					private const string _id = "SCH.25.6";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.25.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
				/// </summary>
				public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
				{

					private const string _id = "SCH.25.7";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.25.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
				/// </summary>
				public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
				{

					private const string _id = "SCH.25.8";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.25.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
				/// </summary>
				public class OriginalText : HL7Base<OriginalText>
				{

					private const string _id = "SCH.25.9";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.25.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
				/// </summary>
				public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
				{

					private const string _id = "SCH.25.10";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.25.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
				/// </summary>
				public class SecondAlternateText : HL7Base<SecondAlternateText>
				{

					private const string _id = "SCH.25.11";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.25.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
				{

					private const string _id = "SCH.25.12";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.25.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
				/// </summary>
				public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
				{

					private const string _id = "SCH.25.13";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.25.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
				/// </summary>
				public class CodingSystemOid : HL7Base<CodingSystemOid>
				{

					private const string _id = "SCH.25.14";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.25.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class ValueSetOid : HL7Base<ValueSetOid>
				{

					private const string _id = "SCH.25.15";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.25.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
				/// </summary>
				public class ValueSetVersionId : HL7Base<ValueSetVersionId>
				{

					private const string _id = "SCH.25.16";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.25.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
				/// </summary>
				public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
				{

					private const string _id = "SCH.25.17";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.25.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
				{

					private const string _id = "SCH.25.18";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.25.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
				/// </summary>
				public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
				{

					private const string _id = "SCH.25.19";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.25.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
				/// </summary>
				public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
				{

					private const string _id = "SCH.25.20";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.25.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
				{

					private const string _id = "SCH.25.21";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.25.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
				/// </summary>
				public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
				{

					private const string _id = "SCH.25.22";
					public override string Id
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
			/// SCH.26 - This field is the placer application's order number for the order associated with this scheduling filler application response.This field is described in detail in Section 4.5.1.2.  It is an optional field, but if a Placer order number is present, then a Filler order number (Section 10.6.2.27) must also be present. Both this field and the Filler order number below may have been sent as part of the appointment request in the ARQ segment or they may be assigned by the scheduling filler application only.
			/// </summary>
			public class PlacerOrderNumber : HL7Base<PlacerOrderNumber>
			{

				private const string _id = "SCH.26";
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
				/// SCH.26.1 - The first component, entity identifier, is usually defined to be unique within the series of identifiers created by the assigning authority, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, "HD - hierarchic designator".
				/// </summary>
				public class EntityIdentifier : HL7Base<EntityIdentifier>
				{

					private const string _id = "SCH.26.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.26.2 - See Section 2.A.33.1, "Namespace ID (IS)" for definition. The component intentionally remains associated with the IS data type in v 2.7.The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363  Assigning Authority for suggested values.Note When the HD is used as a part of another data type, in this case as part of the EI data type, this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment. By site agreement, implementers may continue to use User-defined Table 0300  Namespace ID for the first component
				/// </summary>
				public class NamespaceId : HL7Base<NamespaceId>
				{

					private const string _id = "SCH.26.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.26.3 - See Section 2.A.33.2, "Universal ID (ST)" for definition.
				/// </summary>
				public class UniversalId : HL7Base<UniversalId>
				{

					private const string _id = "SCH.26.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.26.4 - Refer to HL7 Table 0301 - Universal ID Type for valid values. See Section 2.A.33.3, "Universal ID Type (ID)," for definition.
				/// </summary>
				public class UniversalIdType : HL7Base<UniversalIdType>
				{

					private const string _id = "SCH.26.4";
					public override string Id
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
			/// SCH.27 - This field is the order number assigned by the filler application for the order associated with this scheduling filler response.This field is described in detail in Chapter 4, Orders, section 4.5.1.3.  It is conditionally mandatory depending on the presence of the placer order number (section 10.6.2.26).  This conditionally mandatory requirement addresses the concern that a Scheduling system cannot and should not create or fill an order.  Therefore, an order must have been accepted by the order filler application before scheduling the resources associated with that order.
			/// </summary>
			public class FillerOrderNumber : HL7Base<FillerOrderNumber>
			{

				private const string _id = "SCH.27";
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
				/// SCH.27.1 - The first component, entity identifier, is usually defined to be unique within the series of identifiers created by the assigning authority, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, "HD - hierarchic designator".
				/// </summary>
				public class EntityIdentifier : HL7Base<EntityIdentifier>
				{

					private const string _id = "SCH.27.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.27.2 - See Section 2.A.33.1, "Namespace ID (IS)" for definition. The component intentionally remains associated with the IS data type in v 2.7.The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363  Assigning Authority for suggested values.Note When the HD is used as a part of another data type, in this case as part of the EI data type, this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment. By site agreement, implementers may continue to use User-defined Table 0300  Namespace ID for the first component
				/// </summary>
				public class NamespaceId : HL7Base<NamespaceId>
				{

					private const string _id = "SCH.27.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.27.3 - See Section 2.A.33.2, "Universal ID (ST)" for definition.
				/// </summary>
				public class UniversalId : HL7Base<UniversalId>
				{

					private const string _id = "SCH.27.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// SCH.27.4 - Refer to HL7 Table 0301 - Universal ID Type for valid values. See Section 2.A.33.3, "Universal ID Type (ID)," for definition.
				/// </summary>
				public class UniversalIdType : HL7Base<UniversalIdType>
				{

					private const string _id = "SCH.27.4";
					public override string Id
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

		  }
	}
}

