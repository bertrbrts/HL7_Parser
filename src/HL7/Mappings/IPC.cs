using Newtonsoft.Json;
namespace HL7Parser
{
	public partial class Mappings {
		/// <summary>
		/// The IPC segment contains information about tasks that need to be performed in order to fulfill the request for imaging service. The information includes location, type and instance identification of equipment (acquisition modality) and stages (procedure steps).Note References, field names and definitions in this section were developed in collaboration with DICOM with the goal of keeping HL7 transmission of imaging procedure control information consistent with the DICOM Standard, available at http//medical.nema.org.
		/// </summary>
		public class IPC {

			 public const string Id = "IPC";

						/// <summary>
			/// IPC.1 - A workflow-management IDIS generated number that identifies the Filler Order for an Imaging Service (Imaging Service Request). This identifier corresponds one-to-one to the Order Filler number but is used in internal tracking of the work by the IDIS and in communication between IDIS within the department. It also has specific requirements to assure its compatibility with DICOM. It is a case of the Entity Identifier data type (section 2.A.28). Its first component is a string that identifies the Imaging Service Request. A limit of sixteen (16) characters is required to allow compatibility with DICOM. See DICOM Standard Part 3 for further details on DICOM Attribute (0008,0050) that conveys information identical to the component one of this field.An IDIS that performs functions of the workflow management for a department may accept a single Placer Order that gives rise to one or more Filler Orders-Imaging Service Requests. For example, an IDIS may receive an order for an X-ray examination of the patient daily at 8 am for the next three days. For the purposes of fulfilling the Placer Order, it will identify each of the daily exams either as a separate Filler Order or parts of a single Filler Order. Correspondingly, it will assign one or more Filler Order numbers associated with the order. For each of the Filler Order numbers, it will assign a unique Accession Number.Each of the Imaging Service Requests may contain one or more Requested Procedures that it will identify with the Requested Procedure ID. The Requested Procedure is the most granular unit of work that may lead to the creation of the procedure report. Each procedure report contributes to the results for the order. In the example mentioned above, each of the daily examinations will require a separate diagnostic report, hence each of them will be treated as a separate Requested Procedure. Depending on the treatment of the order by the IDIS, it will either link all Requested Procedures to a single Filler Order-Imaging Service Request, or link each Requested Procedure to its own Imaging Service Request. Exact type of requested procedure is conveyed by the coded values in OBR-44 Procedure Code and OBR-45 Procedure Code modifier for each procedure. Note that in case of multiple Requested Procedures corresponding to one order, each procedure may have different code.To support communication with the instances of equipment in a department (acquisition modalities), IDIS will also generate the Study Instance UID, a globally unique identifier for each Requested Procedure. This identifier will be used by acquisition modalities to identify all generated images and other DICOM objects related to this Requested Procedure. Note that, unlike the Study Instance UID, the Requested Procedure ID must only be unique within the scope of the encompassing Imaging Service Request identified by an Accession Number.Each of the Requested Procedures may be further broken down by the IDIS into the Scheduled Procedure Steps based on the timing and equipment requirements. Each step is identified with the Scheduled Procedure Step ID. A single Procedure Step may only be performed on a single type and instance of the equipment. Thus, while the Requested Procedure may identify multi-modality examination (such as ones common in Nuclear Medicine), a single Procedure Step shall correspond to the operations performed on a single modality.
			/// </summary>
			public class AccessionIdentifier : HL7Base<AccessionIdentifier>
			{

				private const string _id = "IPC.1";
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
				/// IPC.1.1 - The first component, entity identifier, is usually defined to be unique within the series of identifiers created by the assigning authority, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, "HD - hierarchic designator".
				/// </summary>
				public class EntityIdentifier : HL7Base<EntityIdentifier>
				{

					private const string _id = "IPC.1.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.1.2 - See Section 2.A.33.1, "Namespace ID (IS)" for definition. The component intentionally remains associated with the IS data type in v 2.7.The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363  Assigning Authority for suggested values.Note When the HD is used as a part of another data type, in this case as part of the EI data type, this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment. By site agreement, implementers may continue to use User-defined Table 0300  Namespace ID for the first component
				/// </summary>
				public class NamespaceId : HL7Base<NamespaceId>
				{

					private const string _id = "IPC.1.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.1.3 - See Section 2.A.33.2, "Universal ID (ST)" for definition.
				/// </summary>
				public class UniversalId : HL7Base<UniversalId>
				{

					private const string _id = "IPC.1.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.1.4 - Refer to HL7 Table 0301 - Universal ID Type for valid values. See Section 2.A.33.3, "Universal ID Type (ID)," for definition.
				/// </summary>
				public class UniversalIdType : HL7Base<UniversalIdType>
				{

					private const string _id = "IPC.1.4";
					public override string Id
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
			/// IPC.2 - This field is the identifier of the Requested Procedure that the workflow management IDIS selected to perform as a part of the order for the imaging service. It is a case of the Entity Identifier data type (section 2.A.28). The first component of this field is a string that identifies the Requested Procedure. A limit of sixteen (16) characters is required to allow compatibility with DICOM. This string must uniquely identify the Requested Procedure within the scope of the order (as specified by accession number). This uniqueness must persist over time. See DICOM Standard Part 3 for further details on DICOM Attribute (0040,0001) that conveys information identical to the component one of this field.The second through fourth components contain the ID of the workflow management IDIS, in the form of the HD data type (see section 2.A.36, "HD - hierarchic designator"). The second component is a user-defined coded value that uniquely defines the application from other applications on the network. A limit of five (5) characters is suggested but not required. The second component of the Requested Procedure number always identifies the actual filler of an order.A Requested Procedure is an instance of a Procedure of a given Procedure Type. An instance of a Requested Procedure includes all of the items of information that are specified by an instance of a Procedure Plan that is selected for the Requested Procedure by the imaging service provider. This Procedure Plan is defined by the imaging service provider on the basis of the Procedure Plan templates associated with the considered Procedure Type. An Imaging Service Request may include requests for several different Requested Procedures. The purpose of this entity is to establish the association between Imaging Service Requests and Procedure Types, to convey the information that belongs to this association and to establish the relationships between Requested Procedures and the other entities that are needed to describe them. A single Requested Procedure of one Procedure Type is the smallest unit of service that can be requested, reported, coded and billed. Performance of one instance of a Requested Procedure is specified by exactly one Procedure Plan. A Requested Procedure leads to one or more Scheduled Procedure Steps involving Protocols as specified by a Procedure Plan. A Requested Procedure may involve one or more pieces of equipment.Each OMI message shall convey information about Requested Procedure(s) pertaining to one order. Pair of Segments ORC/OBR shall correspond to each requested procedure. If the Requested Procedure is comprised of multiple Procedure Steps, multiple IPC segments shall be included for each ORC/OBR pair in the message. In this case, the value of the IPC-2 field shall be identical in all IPC segments related to the same Requested Procedure.
			/// </summary>
			public class RequestedProcedureId : HL7Base<RequestedProcedureId>
			{

				private const string _id = "IPC.2";
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
				/// IPC.2.1 - The first component, entity identifier, is usually defined to be unique within the series of identifiers created by the assigning authority, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, "HD - hierarchic designator".
				/// </summary>
				public class EntityIdentifier : HL7Base<EntityIdentifier>
				{

					private const string _id = "IPC.2.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.2.2 - See Section 2.A.33.1, "Namespace ID (IS)" for definition. The component intentionally remains associated with the IS data type in v 2.7.The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363  Assigning Authority for suggested values.Note When the HD is used as a part of another data type, in this case as part of the EI data type, this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment. By site agreement, implementers may continue to use User-defined Table 0300  Namespace ID for the first component
				/// </summary>
				public class NamespaceId : HL7Base<NamespaceId>
				{

					private const string _id = "IPC.2.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.2.3 - See Section 2.A.33.2, "Universal ID (ST)" for definition.
				/// </summary>
				public class UniversalId : HL7Base<UniversalId>
				{

					private const string _id = "IPC.2.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.2.4 - Refer to HL7 Table 0301 - Universal ID Type for valid values. See Section 2.A.33.3, "Universal ID Type (ID)," for definition.
				/// </summary>
				public class UniversalIdType : HL7Base<UniversalIdType>
				{

					private const string _id = "IPC.2.4";
					public override string Id
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
			/// IPC.3 - Globally unique identifier assigned by the workflow management IDIS to the Imaging Study under which all images and other DICOM objects produced in the course of the Requested Procedure shall be collected. It is a case of the Entity Identifier data type (section 2.A.28). Its first component is a string that identifies the Study. A limit of sixty-four (64) characters is required to allow compatibility with DICOM. See DICOM Standard Part 3 for further details on DICOM Attribute (0020,000D) that conveys information identical to component one of this field. The second through fourth components contain the ID of the workflow management IDIS, in the form of the HD data type (see section 2.A.36, "HD - hierarchic designator"). The second component is a user-defined coded value that uniquely defines the application from other applications on the network. A limit of five (5) characters is suggested but not required. The second component of the Study Instance UID always identifies the actual filler of an order.Each OMI message shall convey information about Requested Procedure(s) pertaining to one order. Pair of Segments ORC/OBR shall correspond to each requested procedure. If the Requested Procedure is comprised of multiple Procedure Steps, multiple IPC segments shall be included for each ORC/OBR pair in the message. In this case, the value of the IPC-3 field shall be identical in all IPC segments related to the same Requested Procedure.The second through fourth components contain the ID of the workflow management IDIS, in the form of the HD data type (see section 2.A.36, "HD - hierarchic designator"). The second component is a user-defined coded value that uniquely defines the application from other applications on the network.  A limit of five (5) characters is suggested but not required.  The second component of the Requested Procedure number always identifies the actual filler of an order.A Procedure Step is an arbitrarily defined scheduled unit of service, which is specified by the Procedure Plan for a Requested Procedure. A Procedure Step prescribes Protocol that may be identified by one or more protocol codes. A Procedure Step involves equipment (e.g., imaging Modality equipment, anesthesia equipment, surgical equipment, transportation equipment), human resources, consumable supplies, location, and time (e.g., start time, stop time, duration). While in the context of Imaging Service request the scheduling of a Procedure Step might include only a general designation of imaging Modality that could be satisfied by multiple pieces of the same equipment type, the performance of one instance of a Procedure Step involves one and only one piece of imaging Modality equipment.
			/// </summary>
			public class StudyInstanceUid : HL7Base<StudyInstanceUid>
			{

				private const string _id = "IPC.3";
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
				/// IPC.3.1 - The first component, entity identifier, is usually defined to be unique within the series of identifiers created by the assigning authority, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, "HD - hierarchic designator".
				/// </summary>
				public class EntityIdentifier : HL7Base<EntityIdentifier>
				{

					private const string _id = "IPC.3.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.3.2 - See Section 2.A.33.1, "Namespace ID (IS)" for definition. The component intentionally remains associated with the IS data type in v 2.7.The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363  Assigning Authority for suggested values.Note When the HD is used as a part of another data type, in this case as part of the EI data type, this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment. By site agreement, implementers may continue to use User-defined Table 0300  Namespace ID for the first component
				/// </summary>
				public class NamespaceId : HL7Base<NamespaceId>
				{

					private const string _id = "IPC.3.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.3.3 - See Section 2.A.33.2, "Universal ID (ST)" for definition.
				/// </summary>
				public class UniversalId : HL7Base<UniversalId>
				{

					private const string _id = "IPC.3.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.3.4 - Refer to HL7 Table 0301 - Universal ID Type for valid values. See Section 2.A.33.3, "Universal ID Type (ID)," for definition.
				/// </summary>
				public class UniversalIdType : HL7Base<UniversalIdType>
				{

					private const string _id = "IPC.3.4";
					public override string Id
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
			/// IPC.4 - This field is the identifier of a particular Procedure Step (sub-procedure) of the Requested Procedure that the workflow management IDIS selected to perform as a part of the order for imaging service. It is a case of the Entity Identifier data type (section 2.A.28). Its first component is a string that identifies the Procedure Step. A limit of sixteen (16) characters is required to allow compatibility with DICOM. This string must uniquely identify the Procedure Step within the scope of the Requested Procedure. This uniqueness must persist over time. See DICOM Standard Part 3 for further details on DICOM Attribute (0040,0009) that conveys information identical to the component one of this field.The second through fourth components contain the ID of the workflow management IDIS, in the form of the HD data type (see section 2.A.36, "HD - hierarchic designator"). The second component is a user-defined coded value that uniquely defines the application from other applications on the network. A limit of five (5) characters is suggested but not required. The second component of the Requested Procedure number always identifies the actual filler of an order.A Procedure Step is an arbitrarily defined scheduled unit of service, which is specified by the Procedure Plan for a Requested Procedure. A Procedure Step prescribes Protocol that may be identified by one or more protocol codes. A Procedure Step involves equipment (e.g., imaging Modality equipment, anesthesia equipment, surgical equipment, transportation equipment), human resources, consumable supplies, location, and time (e.g., start time, stop time, duration). While in the context of Imaging Service request the scheduling of a Procedure Step might include only a general designation of imaging Modality that could be satisfied by multiple pieces of the same equipment type, the performance of one instance of a Procedure Step involves one and only one piece of imaging Modality equipment.
			/// </summary>
			public class ScheduledProcedureStepId : HL7Base<ScheduledProcedureStepId>
			{

				private const string _id = "IPC.4";
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
				/// IPC.4.1 - The first component, entity identifier, is usually defined to be unique within the series of identifiers created by the assigning authority, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, "HD - hierarchic designator".
				/// </summary>
				public class EntityIdentifier : HL7Base<EntityIdentifier>
				{

					private const string _id = "IPC.4.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.4.2 - See Section 2.A.33.1, "Namespace ID (IS)" for definition. The component intentionally remains associated with the IS data type in v 2.7.The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363  Assigning Authority for suggested values.Note When the HD is used as a part of another data type, in this case as part of the EI data type, this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment. By site agreement, implementers may continue to use User-defined Table 0300  Namespace ID for the first component
				/// </summary>
				public class NamespaceId : HL7Base<NamespaceId>
				{

					private const string _id = "IPC.4.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.4.3 - See Section 2.A.33.2, "Universal ID (ST)" for definition.
				/// </summary>
				public class UniversalId : HL7Base<UniversalId>
				{

					private const string _id = "IPC.4.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.4.4 - Refer to HL7 Table 0301 - Universal ID Type for valid values. See Section 2.A.33.3, "Universal ID Type (ID)," for definition.
				/// </summary>
				public class UniversalIdType : HL7Base<UniversalIdType>
				{

					private const string _id = "IPC.4.4";
					public override string Id
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
			/// IPC.5 - The type of equipment requested to acquire data during performance of a Procedure Step. The acquired data will be used to create the images for the Imaging Study corresponding to the Requested Procedure.This field is a case of the CE data type. Refer to External Table 0910  Acquisition Modality for valid values, and to DICOM Standard Part 3 for further details on DICOM Attribute (0008,0060) that conveys information identical to component one of this field.A limit of sixteen (16) characters for the first component is required to allow compatibility with DICOM. The third component of this field, if present, shall have the value of "DCM" (see HL7 Table 0396  Coding Systems).
			/// </summary>
			public class Modality : HL7Base<Modality>
			{

				private const string _id = "IPC.5";
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
				/// IPC.5.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
				/// </summary>
				public class Identifier : HL7Base<Identifier>
				{

					private const string _id = "IPC.5.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.5.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
				/// </summary>
				public class Text : HL7Base<Text>
				{

					private const string _id = "IPC.5.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.5.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
				/// </summary>
				public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
				{

					private const string _id = "IPC.5.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.5.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
				/// </summary>
				public class AlternateIdentifier : HL7Base<AlternateIdentifier>
				{

					private const string _id = "IPC.5.4";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.5.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
				/// </summary>
				public class AlternateText : HL7Base<AlternateText>
				{

					private const string _id = "IPC.5.5";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.5.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
				{

					private const string _id = "IPC.5.6";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.5.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
				/// </summary>
				public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
				{

					private const string _id = "IPC.5.7";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.5.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
				/// </summary>
				public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
				{

					private const string _id = "IPC.5.8";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.5.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
				/// </summary>
				public class OriginalText : HL7Base<OriginalText>
				{

					private const string _id = "IPC.5.9";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.5.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
				/// </summary>
				public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
				{

					private const string _id = "IPC.5.10";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.5.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
				/// </summary>
				public class SecondAlternateText : HL7Base<SecondAlternateText>
				{

					private const string _id = "IPC.5.11";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.5.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
				{

					private const string _id = "IPC.5.12";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.5.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
				/// </summary>
				public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
				{

					private const string _id = "IPC.5.13";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.5.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
				/// </summary>
				public class CodingSystemOid : HL7Base<CodingSystemOid>
				{

					private const string _id = "IPC.5.14";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.5.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class ValueSetOid : HL7Base<ValueSetOid>
				{

					private const string _id = "IPC.5.15";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.5.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
				/// </summary>
				public class ValueSetVersionId : HL7Base<ValueSetVersionId>
				{

					private const string _id = "IPC.5.16";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.5.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
				/// </summary>
				public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
				{

					private const string _id = "IPC.5.17";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.5.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
				{

					private const string _id = "IPC.5.18";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.5.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
				/// </summary>
				public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
				{

					private const string _id = "IPC.5.19";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.5.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
				/// </summary>
				public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
				{

					private const string _id = "IPC.5.20";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.5.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
				{

					private const string _id = "IPC.5.21";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.5.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
				/// </summary>
				public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
				{

					private const string _id = "IPC.5.22";
					public override string Id
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
			/// IPC.6 - One or more coded entries identifying the protocol according to which the Scheduled Procedure Step shall be performed. Protocol Code(s) may identify particular equipment settings as well as operator's manipulations.A Protocol is a specification of actions prescribed by a Procedure Plan to perform a specific Procedure Step. A Scheduled Procedure Step contains only one Protocol that may be conveyed by one or more Protocol Codes. Typically, the code or codes identifying Protocol instance would be selected from a catalog of protocols established locally or provided by equipment manufacturers or professional organizations. Multiple Protocols may not exist in one Scheduled Procedure Step. See DICOM Standard Part 3 for further details on DICOM Attribute (0040,0008) that conveys information identical to components one through three of this field.A limit of sixteen (16) characters for the first component and sixty-four (64) characters for the second component is required to allow compatibility with DICOM.
			/// </summary>
			public class ProtocolCode : HL7Base<ProtocolCode>
			{

				private const string _id = "IPC.6";
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
				/// IPC.6.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
				/// </summary>
				public class Identifier : HL7Base<Identifier>
				{

					private const string _id = "IPC.6.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.6.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
				/// </summary>
				public class Text : HL7Base<Text>
				{

					private const string _id = "IPC.6.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.6.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
				/// </summary>
				public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
				{

					private const string _id = "IPC.6.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.6.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
				/// </summary>
				public class AlternateIdentifier : HL7Base<AlternateIdentifier>
				{

					private const string _id = "IPC.6.4";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.6.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
				/// </summary>
				public class AlternateText : HL7Base<AlternateText>
				{

					private const string _id = "IPC.6.5";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.6.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
				{

					private const string _id = "IPC.6.6";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.6.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
				/// </summary>
				public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
				{

					private const string _id = "IPC.6.7";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.6.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
				/// </summary>
				public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
				{

					private const string _id = "IPC.6.8";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.6.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
				/// </summary>
				public class OriginalText : HL7Base<OriginalText>
				{

					private const string _id = "IPC.6.9";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.6.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
				/// </summary>
				public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
				{

					private const string _id = "IPC.6.10";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.6.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
				/// </summary>
				public class SecondAlternateText : HL7Base<SecondAlternateText>
				{

					private const string _id = "IPC.6.11";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.6.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
				{

					private const string _id = "IPC.6.12";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.6.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
				/// </summary>
				public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
				{

					private const string _id = "IPC.6.13";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.6.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
				/// </summary>
				public class CodingSystemOid : HL7Base<CodingSystemOid>
				{

					private const string _id = "IPC.6.14";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.6.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class ValueSetOid : HL7Base<ValueSetOid>
				{

					private const string _id = "IPC.6.15";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.6.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
				/// </summary>
				public class ValueSetVersionId : HL7Base<ValueSetVersionId>
				{

					private const string _id = "IPC.6.16";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.6.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
				/// </summary>
				public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
				{

					private const string _id = "IPC.6.17";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.6.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
				{

					private const string _id = "IPC.6.18";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.6.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
				/// </summary>
				public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
				{

					private const string _id = "IPC.6.19";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.6.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
				/// </summary>
				public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
				{

					private const string _id = "IPC.6.20";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.6.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
				{

					private const string _id = "IPC.6.21";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.6.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
				/// </summary>
				public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
				{

					private const string _id = "IPC.6.22";
					public override string Id
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
			/// IPC.7 - This field identifies the instance of the modality resource being requested for the performance of a particular Scheduled Procedure Step. It is a case of the Entity Identifier data type (section 2.A.28). The first component of this field is a string that identifies the particular piece of equipment. A limit of sixteen (16) characters is required to allow compatibility with DICOM. See DICOM Standard Part 3 for further details on DICOM Attribute (0040,0010) that conveys information identical to the component one of this field.The second through fourth components identify the organization, in the form of the HD data type (see section 2.A.36, "HD - hierarchic designator").If the Scheduled Procedure Step is to be performed by an unspecified member of a pool of resources, this field shall be empty and IPC-8 Scheduled Procedure Step Location is used to identify the site-specific resource pool. See section 4.5.6.8, "IPC-8 Scheduled Procedure Step Location (CWE) 01664," for explanation of the resource pool.
			/// </summary>
			public class ScheduledStationName : HL7Base<ScheduledStationName>
			{

				private const string _id = "IPC.7";
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
				/// IPC.7.1 - The first component, entity identifier, is usually defined to be unique within the series of identifiers created by the assigning authority, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, "HD - hierarchic designator".
				/// </summary>
				public class EntityIdentifier : HL7Base<EntityIdentifier>
				{

					private const string _id = "IPC.7.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.7.2 - See Section 2.A.33.1, "Namespace ID (IS)" for definition. The component intentionally remains associated with the IS data type in v 2.7.The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363  Assigning Authority for suggested values.Note When the HD is used as a part of another data type, in this case as part of the EI data type, this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment. By site agreement, implementers may continue to use User-defined Table 0300  Namespace ID for the first component
				/// </summary>
				public class NamespaceId : HL7Base<NamespaceId>
				{

					private const string _id = "IPC.7.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.7.3 - See Section 2.A.33.2, "Universal ID (ST)" for definition.
				/// </summary>
				public class UniversalId : HL7Base<UniversalId>
				{

					private const string _id = "IPC.7.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, true, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.7.4 - Refer to HL7 Table 0301 - Universal ID Type for valid values. See Section 2.A.33.3, "Universal ID Type (ID)," for definition.
				/// </summary>
				public class UniversalIdType : HL7Base<UniversalIdType>
				{

					private const string _id = "IPC.7.4";
					public override string Id
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
			/// IPC.8 - This field specifies a locally defined physical location of the modality resource being requested for performance of particular Scheduled Procedure Step. Although location is usually defined geographically (such as identification of a campus, building, floor, etc.) it may be used for identification of a pool of equipment (resources) formed by any other means. Values for the field shall be drawn from a locally defined coding scheme.For example, the pool may be defined as a set of three CT scanners belonging to an imaging center within a hospital. Two of these scanners may also be grouped into another pool based on their location at a building A, whereas the third scanner may be in a pool by itself due to its location in a building B.If this field contains more than one location code, the equipment may be drawn from several resource pools.If this field is empty and the fields IPC-7 and IPC-9 are also empty, it is assumed that a particular Procedure Step may be performed by any instance of equipment of a particular type within an organization.See DICOM Standard Part 3 for further details on DICOM Attribute (0040,0011) that conveys information identical to component one of this field. A limit of sixteen (16) characters for the first component is required to allow compatibility with DICOM.
			/// </summary>
			public class ScheduledProcedureStepLocation : HL7Base<ScheduledProcedureStepLocation>
			{

				private const string _id = "IPC.8";
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
				/// IPC.8.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
				/// </summary>
				public class Identifier : HL7Base<Identifier>
				{

					private const string _id = "IPC.8.1";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.8.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
				/// </summary>
				public class Text : HL7Base<Text>
				{

					private const string _id = "IPC.8.2";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.8.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
				/// </summary>
				public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
				{

					private const string _id = "IPC.8.3";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.8.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
				/// </summary>
				public class AlternateIdentifier : HL7Base<AlternateIdentifier>
				{

					private const string _id = "IPC.8.4";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.8.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
				/// </summary>
				public class AlternateText : HL7Base<AlternateText>
				{

					private const string _id = "IPC.8.5";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.8.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
				{

					private const string _id = "IPC.8.6";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.8.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
				/// </summary>
				public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
				{

					private const string _id = "IPC.8.7";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.8.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
				/// </summary>
				public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
				{

					private const string _id = "IPC.8.8";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.8.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
				/// </summary>
				public class OriginalText : HL7Base<OriginalText>
				{

					private const string _id = "IPC.8.9";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.8.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
				/// </summary>
				public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
				{

					private const string _id = "IPC.8.10";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.8.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
				/// </summary>
				public class SecondAlternateText : HL7Base<SecondAlternateText>
				{

					private const string _id = "IPC.8.11";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.8.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
				/// </summary>
				public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
				{

					private const string _id = "IPC.8.12";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.8.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
				/// </summary>
				public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
				{

					private const string _id = "IPC.8.13";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.8.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
				/// </summary>
				public class CodingSystemOid : HL7Base<CodingSystemOid>
				{

					private const string _id = "IPC.8.14";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.8.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class ValueSetOid : HL7Base<ValueSetOid>
				{

					private const string _id = "IPC.8.15";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.8.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
				/// </summary>
				public class ValueSetVersionId : HL7Base<ValueSetVersionId>
				{

					private const string _id = "IPC.8.16";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.8.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
				/// </summary>
				public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
				{

					private const string _id = "IPC.8.17";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.8.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
				{

					private const string _id = "IPC.8.18";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.8.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
				/// </summary>
				public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
				{

					private const string _id = "IPC.8.19";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.8.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
				/// </summary>
				public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
				{

					private const string _id = "IPC.8.20";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.8.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
				/// </summary>
				public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
				{

					private const string _id = "IPC.8.21";
					public override string Id
					{
						get { return _id; }
					}

					private readonly bool[] _repeatableHierarchy = {false, false, true};
					public override bool[] RepeatableHierarchy
					{
						get { return _repeatableHierarchy; }
					}

				}

								/// <summary>
				/// IPC.8.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
				/// </summary>
				public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
				{

					private const string _id = "IPC.8.22";
					public override string Id
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
			/// IPC.9 - This field contains the Application Entity Title of the modality resource being requested for performance of a particular Scheduled Procedure Step. Application Entity Title is the identifier that identifies an instance of DICOM-compatible equipment for the purpose of addressing during communication. See DICOM Standard, Part 3 for further details on the DICOM Attribute (0040,0001) that conveys equivalent information. A limit of sixteen (16) characters is required to allow compatibility with DICOM.If the Scheduled Procedure Step is to be performed by an unspecified member of a pool of resources, this field shall be empty and IPC-8 Scheduled Procedure Step Location is used to identify the site-specific resource pool. See section 4.5.6.8 for explanation of the resource pool.
			/// </summary>
			public class ScheduledStationAeTitle : HL7Base<ScheduledStationAeTitle>
			{

				private const string _id = "IPC.9";
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

