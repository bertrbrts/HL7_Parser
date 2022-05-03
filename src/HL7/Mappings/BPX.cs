using Newtonsoft.Json;
namespace HL7Parser
{
    public partial class Mappings
    {
        /// <summary>
        /// In the processing of blood products, it is necessary for the transfusion service and the placer system to communicate information. The status messages need to contain additional information regarding the blood products requested, such as the unique donation ID, product code, blood type, expiration date/time of the blood product, and current status of the product. This segment is similar to an OBX segment, but contains additional attributes.The BP prefix in the element name indicates that the attribute pertains to any type of blood product. A blood product is defined as any type of blood component or commercially prepared blood product that is prepared and dispensed from the transfusion service.The BC prefix in the element name indicates that the attribute pertains only to blood components. A blood component is defined as the whole or any part of a blood donation. For example, from one whole blood donation, the unit of whole blood can be fractionated into red blood cells, plasma and platelets with each component contained in separate bags. These types of blood products are assigned a unique donation identification number as well as a product code that indicates the type of component contained in the bag.The CP prefix in the element name indicates that the attribute pertains only to Commercial Products. A commercial product is defined as a commercially manufactured product, such as blood derivatives ( Rh Immune Globulin, Factor VIII Concentrate or Blood Recipient Sets or Filters). These types of products are tracked by manufacturer and lot number and are not necessarily assigned a unique donation number.
        /// </summary>
        public class BPX
        {

            public const string Id = "BPX";

            /// <summary>
            /// BPX.1 - This field contains the sequence number for the BPX segment under the related BPO segment.  For the first blood product dispense status transmitted, the sequence number shall be 1 for the second product dispense status, it shall be 2 and so on.
            /// </summary>
            public class SetIdBpx : HL7Base<SetIdBpx>
            {

                private const string _id = "BPX.1";
                public override string Id
                {
                    get { return _id; }
                }

                private readonly bool[] _repeatableHierarchy = { false, true };
                public override bool[] RepeatableHierarchy
                {
                    get { return _repeatableHierarchy; }
                }

            }

            /// <summary>
            /// BPX.2 - This field indicates the current status of the specified blood product as indicated by the filler or placer.  For example, the first status change of a product that may trigger a Blood Product Dispense Status Message occurs when it first becomes linked to a patient and is ready to dispense.  The placer system may use the Blood Product Dispense Status Message to request the transfusion service to dispense the product.  When the blood product is delivered or issued to a patient, the status of the blood product would be changed to indicate that it has now been "dispensed."  Refer to HL7 Table 0510 - Blood Product Dispense Status for valid entries.
            /// </summary>
            public class BpDispenseStatus : HL7Base<BpDispenseStatus>
            {

                private const string _id = "BPX.2";
                public override string Id
                {
                    get { return _id; }
                }

                private readonly bool[] _repeatableHierarchy = { false, true };
                public override bool[] RepeatableHierarchy
                {
                    get { return _repeatableHierarchy; }
                }

                /// <summary>
                /// BPX.2.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
                /// </summary>
                public class Identifier : HL7Base<Identifier>
                {

                    private const string _id = "BPX.2.1";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.2.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
                /// </summary>
                public class Text : HL7Base<Text>
                {

                    private const string _id = "BPX.2.2";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.2.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
                /// </summary>
                public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
                {

                    private const string _id = "BPX.2.3";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.2.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
                /// </summary>
                public class AlternateIdentifier : HL7Base<AlternateIdentifier>
                {

                    private const string _id = "BPX.2.4";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.2.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
                /// </summary>
                public class AlternateText : HL7Base<AlternateText>
                {

                    private const string _id = "BPX.2.5";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.2.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
                /// </summary>
                public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
                {

                    private const string _id = "BPX.2.6";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.2.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
                /// </summary>
                public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
                {

                    private const string _id = "BPX.2.7";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.2.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
                /// </summary>
                public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
                {

                    private const string _id = "BPX.2.8";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.2.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
                /// </summary>
                public class OriginalText : HL7Base<OriginalText>
                {

                    private const string _id = "BPX.2.9";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.2.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
                /// </summary>
                public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
                {

                    private const string _id = "BPX.2.10";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.2.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
                /// </summary>
                public class SecondAlternateText : HL7Base<SecondAlternateText>
                {

                    private const string _id = "BPX.2.11";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.2.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
                /// </summary>
                public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
                {

                    private const string _id = "BPX.2.12";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.2.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
                /// </summary>
                public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
                {

                    private const string _id = "BPX.2.13";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.2.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
                /// </summary>
                public class CodingSystemOid : HL7Base<CodingSystemOid>
                {

                    private const string _id = "BPX.2.14";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.2.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class ValueSetOid : HL7Base<ValueSetOid>
                {

                    private const string _id = "BPX.2.15";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.2.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
                /// </summary>
                public class ValueSetVersionId : HL7Base<ValueSetVersionId>
                {

                    private const string _id = "BPX.2.16";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.2.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
                /// </summary>
                public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
                {

                    private const string _id = "BPX.2.17";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.2.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
                {

                    private const string _id = "BPX.2.18";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.2.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
                /// </summary>
                public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
                {

                    private const string _id = "BPX.2.19";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.2.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
                /// </summary>
                public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
                {

                    private const string _id = "BPX.2.20";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.2.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
                {

                    private const string _id = "BPX.2.21";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.2.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
                /// </summary>
                public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
                {

                    private const string _id = "BPX.2.22";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

            }

            /// <summary>
            /// BPX.3 - The most commonly used message status values in a BPX will be preliminary and final. A status is considered preliminary until a blood product has reached a final disposition for the patient. For example, when the product is first cross-matched and a status message is sent, it would be considered preliminary. When the product is dispensed to the patient, that status would also be considered preliminary. However, once the product is transfused, the status would be considered final. The status of a blood product (BPX-2) can continue to change and the previous status should be overwritten until it reaches a final status (BPX-3). Refer to HL7 Table 0511 - BP Observation Status Codes Interpretation for valid entries.
            /// </summary>
            public class BpStatus : HL7Base<BpStatus>
            {

                private const string _id = "BPX.3";
                public override string Id
                {
                    get { return _id; }
                }

                private readonly bool[] _repeatableHierarchy = { false, true };
                public override bool[] RepeatableHierarchy
                {
                    get { return _repeatableHierarchy; }
                }

            }

            /// <summary>
            /// BPX.4 - This field indicates the date and time that the status of the blood component was changed.  For example, if the blood component had a status, of "RD" (Ready to Dispense), the date and time in this field would indicate the date and time that component was made ready to dispense by the filler system.
            /// </summary>
            public class BpDateTimeOfStatus : HL7Base<BpDateTimeOfStatus>
            {

                private const string _id = "BPX.4";
                public override string Id
                {
                    get { return _id; }
                }

                private readonly bool[] _repeatableHierarchy = { false, true };
                public override bool[] RepeatableHierarchy
                {
                    get { return _repeatableHierarchy; }
                }

            }

            /// <summary>
            /// BPX.5 - The Donation ID is the unique identification number assigned to a blood donation. The Donation ID depends upon the bar code labeling system used for the component.  There are currently two blood component labeling standards ABC CODABAR and ISBT 128.  The preferred labeling system is ISBT 128.  If using ISBT 128, the Donation ID is an internationally unique identifier consisting of the following 13 charactersCountry Code & Collection Facility - 5 charactersDonation Year - 2 charactersSerial Number - 6 charactersThis field is required for blood components and is not applicable for commercial product messages.
            /// </summary>
            public class BcDonationId : HL7Base<BcDonationId>
            {

                private const string _id = "BPX.5";
                public override string Id
                {
                    get { return _id; }
                }

                private readonly bool[] _repeatableHierarchy = { false, true };
                public override bool[] RepeatableHierarchy
                {
                    get { return _repeatableHierarchy; }
                }

                /// <summary>
                /// BPX.5.1 - The first component, entity identifier, is usually defined to be unique within the series of identifiers created by the assigning authority, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, "HD - hierarchic designator".
                /// </summary>
                public class EntityIdentifier : HL7Base<EntityIdentifier>
                {

                    private const string _id = "BPX.5.1";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.5.2 - See Section 2.A.33.1, "Namespace ID (IS)" for definition. The component intentionally remains associated with the IS data type in v 2.7.The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363  Assigning Authority for suggested values.Note When the HD is used as a part of another data type, in this case as part of the EI data type, this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment. By site agreement, implementers may continue to use User-defined Table 0300  Namespace ID for the first component
                /// </summary>
                public class NamespaceId : HL7Base<NamespaceId>
                {

                    private const string _id = "BPX.5.2";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.5.3 - See Section 2.A.33.2, "Universal ID (ST)" for definition.
                /// </summary>
                public class UniversalId : HL7Base<UniversalId>
                {

                    private const string _id = "BPX.5.3";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.5.4 - Refer to HL7 Table 0301 - Universal ID Type for valid values. See Section 2.A.33.3, "Universal ID Type (ID)," for definition.
                /// </summary>
                public class UniversalIdType : HL7Base<UniversalIdType>
                {

                    private const string _id = "BPX.5.4";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

            }

            /// <summary>
            /// BPX.6 - The Component field includes an identifier and description of the specific blood component.The identifier consists of a numeric or alphanumeric product code that represents the type of blood component. The coding system will be determined by the bar code labeling system on the particular component of blood.  The preferred coding system is ISBT 128.If using ISBT 128 labeling standard, the product code will consist of an 8-character alphanumeric code, starting with an alpha character and including the component class, donation type/intended use and division indicator.If using CODABAR product labeling standard, the product code is a 5-digit number.This field is required for blood components and is not applicable for commercial product messages.
            /// </summary>
            public class BcComponent : HL7Base<BcComponent>
            {

                private const string _id = "BPX.6";
                public override string Id
                {
                    get { return _id; }
                }

                private readonly bool[] _repeatableHierarchy = { false, true };
                public override bool[] RepeatableHierarchy
                {
                    get { return _repeatableHierarchy; }
                }

                /// <summary>
                /// BPX.6.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CNE.2. Different coding schemes will have different elements here.Usage Note The identifier is required and must be a valid code.
                /// </summary>
                public class Identifier : HL7Base<Identifier>
                {

                    private const string _id = "BPX.6.1";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.6.2 - The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression. This is the corresponding text assigned by the coding system to the identifier.Usage Note Text description of code is optional but its use should be encouraged since it makes messages easier to review for accuracy, especially during interface testing and debugging.
                /// </summary>
                public class Text : HL7Base<Text>
                {

                    private const string _id = "BPX.6.2";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.6.3 - The third component contains the code for the name of the coding system from which the value in CNE.1 is obtained. Refer to HL7 Table 0396 - Coding Systems in Chapter 2C, Code Tables, for valid values. Each coding system is assigned a unique identifier.As of v2.7 this component is required when CNE.1 is populated and CNE.14 is not populated. Both CNE.3 and CNE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CNE.3 and/or CNE.14 the Coding System component or the Coding System OID for the tuple.The combination of the identifier and name of coding system represent a unique concept for a data item.Some organizations that publish code sets author more than one. The coding system, then, to be unique, is a concatenation of the name of the coding authority organization and the name of its code set or table. When an HL7 table is used for a CNE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. Similarly, ISO tables will be named ISOnnnn, where nnnn is the ISO table number.Usage Note The following statement is retained for backward compatibility as of v2.7. Best practice would recommend that this component always be populated. However, if the field narrative explicitly states "Refer to HL7 Table nnnn for valid values, and, if the sending and receiving systems are HL7 compliant, the coding system would be known from the standard.  This would be similar to a field with an ID data type, except that there is a second triplet in which to express an alternate code.
                /// </summary>
                public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
                {

                    private const string _id = "BPX.6.3";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.6.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CNE.1 Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
                /// </summary>
                public class AlternateIdentifier : HL7Base<AlternateIdentifier>
                {

                    private const string _id = "BPX.6.4";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.6.5 - The descriptive or textual name of the alternate identifier. Analogous to CNE.2 Text. Usage Notes If present, CNE.5 obeys the same rules of use and interpretation as described for CNE.2. 
                /// </summary>
                public class AlternateText : HL7Base<AlternateText>
                {

                    private const string _id = "BPX.6.5";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.6.6 - Identifies the coding scheme being used in the alternate identifier component.  Analogous to  CNE.3 Name of Coding System.  Refer to HL7 Table 0396 - Coding Systems in Chapter 2C, Code Tables, for valid values.As of v2.7 this component is required when CNE.4 is populated and CNE.17 is not populated. Both CNE.6 and CNE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CNE.6 and/or CNE.17, the "Coding System" component or the "Coding System OID", for the tuple.Usage Notes If present, CNE.6 obeys the same rules of use and interpretation as described for CNE.3.
                /// </summary>
                public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
                {

                    private const string _id = "BPX.6.6";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.6.7 - The version ID for the coding system identified by CNE.3. It belongs conceptually to components 1-3 and appears here only for reasons of backward compatibility.Usage Note If the coding system is any system other than an "HL7 coding system," version ID must be valued with an actual version ID. If the coding system is "HL7 coding system," version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. Text description of code is optional but its use should be encouraged since it makes messages easier to review for accuracy, especially during interface testing and debugging.
                /// </summary>
                public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
                {

                    private const string _id = "BPX.6.7";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.6.8 - The version ID for the coding system identified by CNE.6.  It belongs conceptually to the group of Alternate components (see note 2.A.1) and appears here only for reasons of backward compatibility. Analogous to CNE.7 Coding System Version ID.Usage Notes If present, CNE.8 obeys the same rules of use and interpretation as described for CNE.7.
                /// </summary>
                public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
                {

                    private const string _id = "BPX.6.8";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.6.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
                /// </summary>
                public class OriginalText : HL7Base<OriginalText>
                {

                    private const string _id = "BPX.6.9";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.6.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CN-1 Identifier.
                /// </summary>
                public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
                {

                    private const string _id = "BPX.6.10";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.6.11 - The descriptive or textual name of the Second Alternate Identifier. Analogous to CNE.2 Text.
                /// </summary>
                public class SecondAlternateText : HL7Base<SecondAlternateText>
                {

                    private const string _id = "BPX.6.11";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.6.12 - Identifies the coding scheme being used in the Second Alternate Identifier component. Analogous to CNE.3 Name of Coding System.  Refer to HL7 Table 0396 - Coding Systems in Chapter 2C, Code Tables, for valid values.As of v2.7 this component is required when CNE.10 is populated and CNE.20 is not populated. Both CNE.12 and CNE.20 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CNE.12 and/or CNE.20, the "Coding System" component or the "Coding System OID", for the tuple.
                /// </summary>
                public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
                {

                    private const string _id = "BPX.6.12";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.6.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CNE.7 Coding System Version ID.
                /// </summary>
                public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
                {

                    private const string _id = "BPX.6.13";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.6.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CNE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CNE.1 is populated and CNE.3 is not populated. Both CNE.3 and CNE.14 may be populated.
                /// </summary>
                public class CodingSystemOid : HL7Base<CodingSystemOid>
                {

                    private const string _id = "BPX.6.14";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.6.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CNE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class ValueSetOid : HL7Base<ValueSetOid>
                {

                    private const string _id = "BPX.6.15";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.6.16 - This component carries the version for the value set identified by CNE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CNE.15 is populated.
                /// </summary>
                public class ValueSetVersionId : HL7Base<ValueSetVersionId>
                {

                    private const string _id = "BPX.6.16";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.6.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CNE.6. Analogous to CNE.14 OID for Coding System. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CNE.4 is populated and CNE.6 is not populated. Both CNE.6 and CNE.17 may be populated.
                /// </summary>
                public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
                {

                    private const string _id = "BPX.6.17";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.6.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CNE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
                {

                    private const string _id = "BPX.6.18";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.6.19 - This component carries the version for the value set identified by CNE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CNE.18 is populated.
                /// </summary>
                public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
                {

                    private const string _id = "BPX.6.19";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.6.20 - This component contains the ISO Object Identifier (OID) from which the value in CNE.12 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined numbers, the OID registered in the HL7 OID registry should be used. This component is required when CNE.4 is populated and neither CNE.6 nor CNE.18 is populated. In short either the CNE.6 or the CNE.14 or CNE.17 must be populated when CNE.4 is populated.
                /// </summary>
                public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
                {

                    private const string _id = "BPX.6.20";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.6.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CNE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
                {

                    private const string _id = "BPX.6.21";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.6.22 - This component carries the version for the value set identified by CNE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CNE.21 is populated.
                /// </summary>
                public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
                {

                    private const string _id = "BPX.6.22";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

            }

            /// <summary>
            /// BPX.7 - This field indicates the type of donation or collection/intended use.  This value is populated from Table 5 -Type of Donation in the ISBT 128 Application Specification.  The default value is "0", meaning "Not specified."  Other values indicate whether the blood product (1) is an allogeneic unit from a volunteer donor, (2) is intended for a specific recipient but may be crossed over and used for another recipient, or (3) is an autologous donation intended only for that particular recipient.This field is optional for blood component messages and is not applicable for commercial product messages.
            /// </summary>
            public class BcDonationTypeIntendedUse : HL7Base<BcDonationTypeIntendedUse>
            {

                private const string _id = "BPX.7";
                public override string Id
                {
                    get { return _id; }
                }

                private readonly bool[] _repeatableHierarchy = { false, true };
                public override bool[] RepeatableHierarchy
                {
                    get { return _repeatableHierarchy; }
                }

                /// <summary>
                /// BPX.7.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CNE.2. Different coding schemes will have different elements here.Usage Note The identifier is required and must be a valid code.
                /// </summary>
                public class Identifier : HL7Base<Identifier>
                {

                    private const string _id = "BPX.7.1";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.7.2 - The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression. This is the corresponding text assigned by the coding system to the identifier.Usage Note Text description of code is optional but its use should be encouraged since it makes messages easier to review for accuracy, especially during interface testing and debugging.
                /// </summary>
                public class Text : HL7Base<Text>
                {

                    private const string _id = "BPX.7.2";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.7.3 - The third component contains the code for the name of the coding system from which the value in CNE.1 is obtained. Refer to HL7 Table 0396 - Coding Systems in Chapter 2C, Code Tables, for valid values. Each coding system is assigned a unique identifier.As of v2.7 this component is required when CNE.1 is populated and CNE.14 is not populated. Both CNE.3 and CNE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CNE.3 and/or CNE.14 the Coding System component or the Coding System OID for the tuple.The combination of the identifier and name of coding system represent a unique concept for a data item.Some organizations that publish code sets author more than one. The coding system, then, to be unique, is a concatenation of the name of the coding authority organization and the name of its code set or table. When an HL7 table is used for a CNE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. Similarly, ISO tables will be named ISOnnnn, where nnnn is the ISO table number.Usage Note The following statement is retained for backward compatibility as of v2.7. Best practice would recommend that this component always be populated. However, if the field narrative explicitly states "Refer to HL7 Table nnnn for valid values, and, if the sending and receiving systems are HL7 compliant, the coding system would be known from the standard.  This would be similar to a field with an ID data type, except that there is a second triplet in which to express an alternate code.
                /// </summary>
                public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
                {

                    private const string _id = "BPX.7.3";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.7.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CNE.1 Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
                /// </summary>
                public class AlternateIdentifier : HL7Base<AlternateIdentifier>
                {

                    private const string _id = "BPX.7.4";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.7.5 - The descriptive or textual name of the alternate identifier. Analogous to CNE.2 Text. Usage Notes If present, CNE.5 obeys the same rules of use and interpretation as described for CNE.2. 
                /// </summary>
                public class AlternateText : HL7Base<AlternateText>
                {

                    private const string _id = "BPX.7.5";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.7.6 - Identifies the coding scheme being used in the alternate identifier component.  Analogous to  CNE.3 Name of Coding System.  Refer to HL7 Table 0396 - Coding Systems in Chapter 2C, Code Tables, for valid values.As of v2.7 this component is required when CNE.4 is populated and CNE.17 is not populated. Both CNE.6 and CNE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CNE.6 and/or CNE.17, the "Coding System" component or the "Coding System OID", for the tuple.Usage Notes If present, CNE.6 obeys the same rules of use and interpretation as described for CNE.3.
                /// </summary>
                public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
                {

                    private const string _id = "BPX.7.6";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.7.7 - The version ID for the coding system identified by CNE.3. It belongs conceptually to components 1-3 and appears here only for reasons of backward compatibility.Usage Note If the coding system is any system other than an "HL7 coding system," version ID must be valued with an actual version ID. If the coding system is "HL7 coding system," version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. Text description of code is optional but its use should be encouraged since it makes messages easier to review for accuracy, especially during interface testing and debugging.
                /// </summary>
                public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
                {

                    private const string _id = "BPX.7.7";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.7.8 - The version ID for the coding system identified by CNE.6.  It belongs conceptually to the group of Alternate components (see note 2.A.1) and appears here only for reasons of backward compatibility. Analogous to CNE.7 Coding System Version ID.Usage Notes If present, CNE.8 obeys the same rules of use and interpretation as described for CNE.7.
                /// </summary>
                public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
                {

                    private const string _id = "BPX.7.8";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.7.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
                /// </summary>
                public class OriginalText : HL7Base<OriginalText>
                {

                    private const string _id = "BPX.7.9";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.7.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CN-1 Identifier.
                /// </summary>
                public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
                {

                    private const string _id = "BPX.7.10";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.7.11 - The descriptive or textual name of the Second Alternate Identifier. Analogous to CNE.2 Text.
                /// </summary>
                public class SecondAlternateText : HL7Base<SecondAlternateText>
                {

                    private const string _id = "BPX.7.11";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.7.12 - Identifies the coding scheme being used in the Second Alternate Identifier component. Analogous to CNE.3 Name of Coding System.  Refer to HL7 Table 0396 - Coding Systems in Chapter 2C, Code Tables, for valid values.As of v2.7 this component is required when CNE.10 is populated and CNE.20 is not populated. Both CNE.12 and CNE.20 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CNE.12 and/or CNE.20, the "Coding System" component or the "Coding System OID", for the tuple.
                /// </summary>
                public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
                {

                    private const string _id = "BPX.7.12";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.7.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CNE.7 Coding System Version ID.
                /// </summary>
                public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
                {

                    private const string _id = "BPX.7.13";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.7.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CNE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CNE.1 is populated and CNE.3 is not populated. Both CNE.3 and CNE.14 may be populated.
                /// </summary>
                public class CodingSystemOid : HL7Base<CodingSystemOid>
                {

                    private const string _id = "BPX.7.14";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.7.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CNE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class ValueSetOid : HL7Base<ValueSetOid>
                {

                    private const string _id = "BPX.7.15";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.7.16 - This component carries the version for the value set identified by CNE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CNE.15 is populated.
                /// </summary>
                public class ValueSetVersionId : HL7Base<ValueSetVersionId>
                {

                    private const string _id = "BPX.7.16";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.7.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CNE.6. Analogous to CNE.14 OID for Coding System. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CNE.4 is populated and CNE.6 is not populated. Both CNE.6 and CNE.17 may be populated.
                /// </summary>
                public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
                {

                    private const string _id = "BPX.7.17";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.7.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CNE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
                {

                    private const string _id = "BPX.7.18";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.7.19 - This component carries the version for the value set identified by CNE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CNE.18 is populated.
                /// </summary>
                public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
                {

                    private const string _id = "BPX.7.19";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.7.20 - This component contains the ISO Object Identifier (OID) from which the value in CNE.12 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined numbers, the OID registered in the HL7 OID registry should be used. This component is required when CNE.4 is populated and neither CNE.6 nor CNE.18 is populated. In short either the CNE.6 or the CNE.14 or CNE.17 must be populated when CNE.4 is populated.
                /// </summary>
                public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
                {

                    private const string _id = "BPX.7.20";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.7.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CNE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
                {

                    private const string _id = "BPX.7.21";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.7.22 - This component carries the version for the value set identified by CNE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CNE.21 is populated.
                /// </summary>
                public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
                {

                    private const string _id = "BPX.7.22";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

            }

            /// <summary>
            /// BPX.8 - This field contains the code and/or text to identify a commercial product.  Examples of commercial products are blood derivatives such as Rh Immune Globulin and Factor VIII concentrate, Leukoreduction filters, and blood administration sets.Either code and/or text may be absent.  However, the code is always placed in the first component position and any free text in the second component.  Thus, a component delimiter must precede free text without a code.  Free text can be utilized if no update is to occur.  Refer To User-Defined Table 0512 - Commercial Product for suggested values.This field is required for commercial blood products and is not applicable for blood component messages.This field is required for commercial blood products and is not applicable for blood component messages.
            /// </summary>
            public class CpCommercialProduct : HL7Base<CpCommercialProduct>
            {

                private const string _id = "BPX.8";
                public override string Id
                {
                    get { return _id; }
                }

                private readonly bool[] _repeatableHierarchy = { false, true };
                public override bool[] RepeatableHierarchy
                {
                    get { return _repeatableHierarchy; }
                }

                /// <summary>
                /// BPX.8.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
                /// </summary>
                public class Identifier : HL7Base<Identifier>
                {

                    private const string _id = "BPX.8.1";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.8.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
                /// </summary>
                public class Text : HL7Base<Text>
                {

                    private const string _id = "BPX.8.2";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.8.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
                /// </summary>
                public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
                {

                    private const string _id = "BPX.8.3";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.8.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
                /// </summary>
                public class AlternateIdentifier : HL7Base<AlternateIdentifier>
                {

                    private const string _id = "BPX.8.4";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.8.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
                /// </summary>
                public class AlternateText : HL7Base<AlternateText>
                {

                    private const string _id = "BPX.8.5";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.8.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
                /// </summary>
                public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
                {

                    private const string _id = "BPX.8.6";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.8.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
                /// </summary>
                public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
                {

                    private const string _id = "BPX.8.7";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.8.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
                /// </summary>
                public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
                {

                    private const string _id = "BPX.8.8";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.8.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
                /// </summary>
                public class OriginalText : HL7Base<OriginalText>
                {

                    private const string _id = "BPX.8.9";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.8.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
                /// </summary>
                public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
                {

                    private const string _id = "BPX.8.10";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.8.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
                /// </summary>
                public class SecondAlternateText : HL7Base<SecondAlternateText>
                {

                    private const string _id = "BPX.8.11";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.8.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
                /// </summary>
                public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
                {

                    private const string _id = "BPX.8.12";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.8.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
                /// </summary>
                public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
                {

                    private const string _id = "BPX.8.13";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.8.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
                /// </summary>
                public class CodingSystemOid : HL7Base<CodingSystemOid>
                {

                    private const string _id = "BPX.8.14";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.8.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class ValueSetOid : HL7Base<ValueSetOid>
                {

                    private const string _id = "BPX.8.15";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.8.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
                /// </summary>
                public class ValueSetVersionId : HL7Base<ValueSetVersionId>
                {

                    private const string _id = "BPX.8.16";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.8.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
                /// </summary>
                public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
                {

                    private const string _id = "BPX.8.17";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.8.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
                {

                    private const string _id = "BPX.8.18";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.8.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
                /// </summary>
                public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
                {

                    private const string _id = "BPX.8.19";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.8.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
                /// </summary>
                public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
                {

                    private const string _id = "BPX.8.20";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.8.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
                {

                    private const string _id = "BPX.8.21";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.8.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
                /// </summary>
                public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
                {

                    private const string _id = "BPX.8.22";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

            }

            /// <summary>
            /// BPX.9 - This field identifies the manufacturer of the commercial product.  The manufacturer may be different from the supplier of the commercial product.This field is required for commercial blood products and is not applicable for blood component messages.
            /// </summary>
            public class CpManufacturer : HL7Base<CpManufacturer>
            {

                private const string _id = "BPX.9";
                public override string Id
                {
                    get { return _id; }
                }

                private readonly bool[] _repeatableHierarchy = { false, true };
                public override bool[] RepeatableHierarchy
                {
                    get { return _repeatableHierarchy; }
                }

                /// <summary>
                /// BPX.9.1 - The name of the specified organization.
                /// </summary>
                public class OrganizationName : HL7Base<OrganizationName>
                {

                    private const string _id = "BPX.9.1";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.9.2 - A code that represents the type of name i.e., legal name, display name. Refer to User-defined Table 0204 - Organizational Name Type for suggested values.
                /// </summary>
                public class OrganizationNameTypeCode : HL7Base<OrganizationNameTypeCode>
                {

                    private const string _id = "BPX.9.2";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                    /// <summary>
                    /// BPX.9.2.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
                    /// </summary>
                    public class Identifier : HL7Base<Identifier>
                    {

                        private const string _id = "BPX.9.2.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.9.2.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
                    /// </summary>
                    public class Text : HL7Base<Text>
                    {

                        private const string _id = "BPX.9.2.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.9.2.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
                    /// </summary>
                    public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
                    {

                        private const string _id = "BPX.9.2.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.9.2.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
                    /// </summary>
                    public class AlternateIdentifier : HL7Base<AlternateIdentifier>
                    {

                        private const string _id = "BPX.9.2.4";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.9.2.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
                    /// </summary>
                    public class AlternateText : HL7Base<AlternateText>
                    {

                        private const string _id = "BPX.9.2.5";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.9.2.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
                    {

                        private const string _id = "BPX.9.2.6";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.9.2.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
                    /// </summary>
                    public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
                    {

                        private const string _id = "BPX.9.2.7";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.9.2.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
                    {

                        private const string _id = "BPX.9.2.8";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.9.2.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
                    /// </summary>
                    public class OriginalText : HL7Base<OriginalText>
                    {

                        private const string _id = "BPX.9.2.9";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.9.2.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
                    /// </summary>
                    public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
                    {

                        private const string _id = "BPX.9.2.10";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.9.2.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
                    /// </summary>
                    public class SecondAlternateText : HL7Base<SecondAlternateText>
                    {

                        private const string _id = "BPX.9.2.11";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.9.2.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
                    {

                        private const string _id = "BPX.9.2.12";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.9.2.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
                    {

                        private const string _id = "BPX.9.2.13";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.9.2.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
                    /// </summary>
                    public class CodingSystemOid : HL7Base<CodingSystemOid>
                    {

                        private const string _id = "BPX.9.2.14";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.9.2.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class ValueSetOid : HL7Base<ValueSetOid>
                    {

                        private const string _id = "BPX.9.2.15";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.9.2.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
                    /// </summary>
                    public class ValueSetVersionId : HL7Base<ValueSetVersionId>
                    {

                        private const string _id = "BPX.9.2.16";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.9.2.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
                    /// </summary>
                    public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
                    {

                        private const string _id = "BPX.9.2.17";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.9.2.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
                    {

                        private const string _id = "BPX.9.2.18";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.9.2.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
                    /// </summary>
                    public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
                    {

                        private const string _id = "BPX.9.2.19";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.9.2.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
                    /// </summary>
                    public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
                    {

                        private const string _id = "BPX.9.2.20";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.9.2.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
                    {

                        private const string _id = "BPX.9.2.21";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.9.2.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
                    /// </summary>
                    public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
                    {

                        private const string _id = "BPX.9.2.22";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                }

                /// <summary>
                /// BPX.9.3 - Attention The XON.3 component was deprecated as of v 2.5 and the detail was withdrawn and removed from the standard as of v 2.7. Refer to XON.10 Organization Identifier.
                /// </summary>
                public class IdNumber : HL7Base<IdNumber>
                {

                    private const string _id = "BPX.9.3";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.9.4 - Attention The XON.4 component was deprecated as of v 2.5 and the detail was withdrawn and removed from the standard as of v 2.7.
                /// </summary>
                public class IdentifierCheckDigit : HL7Base<IdentifierCheckDigit>
                {

                    private const string _id = "BPX.9.4";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.9.5 - Attention The XON.5 component was deprecated as of v 2.5 and the detail was withdrawn and removed from the standard as of v 2.7.
                /// </summary>
                public class CheckDigitScheme : HL7Base<CheckDigitScheme>
                {

                    private const string _id = "BPX.9.5";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.9.6 - The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Assigning authorities are unique across a given HL7 implementation. Refer to User-defined Table 0363 - Assigning Authority for suggested values. Note When the HD data type is used in a given segment as a component of a field of another data type, User-defined Table 0300 - Namespace ID (referenced by the first sub-component of the HD component) may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.By site agreement, implementers may continue to use User-defined Table 0300  Namespace ID for the first sub-component.
                /// </summary>
                public class AssigningAuthority : HL7Base<AssigningAuthority>
                {

                    private const string _id = "BPX.9.6";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                    /// <summary>
                    /// BPX.9.6.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
                    /// </summary>
                    public class NamespaceId : HL7Base<NamespaceId>
                    {

                        private const string _id = "BPX.9.6.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.9.6.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
                    /// </summary>
                    public class UniversalId : HL7Base<UniversalId>
                    {

                        private const string _id = "BPX.9.6.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.9.6.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
                    /// </summary>
                    public class UniversalIdType : HL7Base<UniversalIdType>
                    {

                        private const string _id = "BPX.9.6.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                }

                /// <summary>
                /// BPX.9.7 - A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the "Assigning authority" component. Refer to HL7 Table 0203 - Identifier Type for suggested values.
                /// </summary>
                public class IdentifierTypeCode : HL7Base<IdentifierTypeCode>
                {

                    private const string _id = "BPX.9.7";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.9.8 - The place or location identifier where the identifier was first assigned to the person. This component is not an inherent part of the identifier but rather part of the history of the identifier as part of this data type, its existence is a convenience for certain intercommunicating systems.Note When the HD data type is used in a given segment as a component of a field of another data type, User-defined Table 0300 - Namespace ID (referenced by the first sub-component of the HD component) may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
                /// </summary>
                public class AssigningFacility : HL7Base<AssigningFacility>
                {

                    private const string _id = "BPX.9.8";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                    /// <summary>
                    /// BPX.9.8.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
                    /// </summary>
                    public class NamespaceId : HL7Base<NamespaceId>
                    {

                        private const string _id = "BPX.9.8.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.9.8.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
                    /// </summary>
                    public class UniversalId : HL7Base<UniversalId>
                    {

                        private const string _id = "BPX.9.8.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.9.8.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
                    /// </summary>
                    public class UniversalIdType : HL7Base<UniversalIdType>
                    {

                        private const string _id = "BPX.9.8.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                }

                /// <summary>
                /// BPX.9.9 - Different name/address types and representations of the same name/address should be described by repeating of this field, with different values of the name/address type and/or name/address representation component.Note This new component remains in alphabetic representation with each repetition of the field using these data types, i.e. even though the name may be represented in an ideographic character set, this component will remain represented in an alphabetic character set.Refer to HL7 Table 0465  Name/address Representation Code for valid values.In general this component provides an indication of the representation provided by the data item. It does not necessarily specify the character sets used. Thus, even though the representation might provide an indication of what to expect, the sender is still free to encode the contents using whatever character set is desired. This component provides only hints for the receiver, so it can make choices regarding what it has been sent and what it is capable of displaying.
                /// </summary>
                public class NameRepresentationCode : HL7Base<NameRepresentationCode>
                {

                    private const string _id = "BPX.9.9";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.9.10 - This component contains the sequence of characters (the code) that uniquely identifies the item being referenced by XON.1 Organization Name. This component replaces XON.3 ID Number as of v 2.5.Note The check digit and code identifying check digit scheme are null if Organization identifier is alphanumeric.
                /// </summary>
                public class OrganizationIdentifier : HL7Base<OrganizationIdentifier>
                {

                    private const string _id = "BPX.9.10";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

            }

            /// <summary>
            /// BPX.10 - This field identifies the lot number for blood derivatives or commercially supplied items used as accessories to transfusion.This field is required for commercial blood products and is not applicable for blood component messages.
            /// </summary>
            public class CpLotNumber : HL7Base<CpLotNumber>
            {

                private const string _id = "BPX.10";
                public override string Id
                {
                    get { return _id; }
                }

                private readonly bool[] _repeatableHierarchy = { false, true };
                public override bool[] RepeatableHierarchy
                {
                    get { return _repeatableHierarchy; }
                }

                /// <summary>
                /// BPX.10.1 - The first component, entity identifier, is usually defined to be unique within the series of identifiers created by the assigning authority, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, "HD - hierarchic designator".
                /// </summary>
                public class EntityIdentifier : HL7Base<EntityIdentifier>
                {

                    private const string _id = "BPX.10.1";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.10.2 - See Section 2.A.33.1, "Namespace ID (IS)" for definition. The component intentionally remains associated with the IS data type in v 2.7.The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363  Assigning Authority for suggested values.Note When the HD is used as a part of another data type, in this case as part of the EI data type, this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment. By site agreement, implementers may continue to use User-defined Table 0300  Namespace ID for the first component
                /// </summary>
                public class NamespaceId : HL7Base<NamespaceId>
                {

                    private const string _id = "BPX.10.2";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.10.3 - See Section 2.A.33.2, "Universal ID (ST)" for definition.
                /// </summary>
                public class UniversalId : HL7Base<UniversalId>
                {

                    private const string _id = "BPX.10.3";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.10.4 - Refer to HL7 Table 0301 - Universal ID Type for valid values. See Section 2.A.33.3, "Universal ID Type (ID)," for definition.
                /// </summary>
                public class UniversalIdType : HL7Base<UniversalIdType>
                {

                    private const string _id = "BPX.10.4";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

            }

            /// <summary>
            /// BPX.11 - This field is required for blood components and certain commercial products (such as solvent detergent plasma). This field indicates the ABO/Rh blood group of the blood component. The preferred values for the blood group are the specified values in Table 3A - Encodation of ABO/Rh Blood Group in the ISBT 128 Application Specification.
            /// </summary>
            public class BpBloodGroup : HL7Base<BpBloodGroup>
            {

                private const string _id = "BPX.11";
                public override string Id
                {
                    get { return _id; }
                }

                private readonly bool[] _repeatableHierarchy = { false, true };
                public override bool[] RepeatableHierarchy
                {
                    get { return _repeatableHierarchy; }
                }

                /// <summary>
                /// BPX.11.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CNE.2. Different coding schemes will have different elements here.Usage Note The identifier is required and must be a valid code.
                /// </summary>
                public class Identifier : HL7Base<Identifier>
                {

                    private const string _id = "BPX.11.1";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.11.2 - The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression. This is the corresponding text assigned by the coding system to the identifier.Usage Note Text description of code is optional but its use should be encouraged since it makes messages easier to review for accuracy, especially during interface testing and debugging.
                /// </summary>
                public class Text : HL7Base<Text>
                {

                    private const string _id = "BPX.11.2";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.11.3 - The third component contains the code for the name of the coding system from which the value in CNE.1 is obtained. Refer to HL7 Table 0396 - Coding Systems in Chapter 2C, Code Tables, for valid values. Each coding system is assigned a unique identifier.As of v2.7 this component is required when CNE.1 is populated and CNE.14 is not populated. Both CNE.3 and CNE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CNE.3 and/or CNE.14 the Coding System component or the Coding System OID for the tuple.The combination of the identifier and name of coding system represent a unique concept for a data item.Some organizations that publish code sets author more than one. The coding system, then, to be unique, is a concatenation of the name of the coding authority organization and the name of its code set or table. When an HL7 table is used for a CNE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. Similarly, ISO tables will be named ISOnnnn, where nnnn is the ISO table number.Usage Note The following statement is retained for backward compatibility as of v2.7. Best practice would recommend that this component always be populated. However, if the field narrative explicitly states "Refer to HL7 Table nnnn for valid values, and, if the sending and receiving systems are HL7 compliant, the coding system would be known from the standard.  This would be similar to a field with an ID data type, except that there is a second triplet in which to express an alternate code.
                /// </summary>
                public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
                {

                    private const string _id = "BPX.11.3";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.11.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CNE.1 Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
                /// </summary>
                public class AlternateIdentifier : HL7Base<AlternateIdentifier>
                {

                    private const string _id = "BPX.11.4";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.11.5 - The descriptive or textual name of the alternate identifier. Analogous to CNE.2 Text. Usage Notes If present, CNE.5 obeys the same rules of use and interpretation as described for CNE.2. 
                /// </summary>
                public class AlternateText : HL7Base<AlternateText>
                {

                    private const string _id = "BPX.11.5";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.11.6 - Identifies the coding scheme being used in the alternate identifier component.  Analogous to  CNE.3 Name of Coding System.  Refer to HL7 Table 0396 - Coding Systems in Chapter 2C, Code Tables, for valid values.As of v2.7 this component is required when CNE.4 is populated and CNE.17 is not populated. Both CNE.6 and CNE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CNE.6 and/or CNE.17, the "Coding System" component or the "Coding System OID", for the tuple.Usage Notes If present, CNE.6 obeys the same rules of use and interpretation as described for CNE.3.
                /// </summary>
                public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
                {

                    private const string _id = "BPX.11.6";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.11.7 - The version ID for the coding system identified by CNE.3. It belongs conceptually to components 1-3 and appears here only for reasons of backward compatibility.Usage Note If the coding system is any system other than an "HL7 coding system," version ID must be valued with an actual version ID. If the coding system is "HL7 coding system," version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. Text description of code is optional but its use should be encouraged since it makes messages easier to review for accuracy, especially during interface testing and debugging.
                /// </summary>
                public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
                {

                    private const string _id = "BPX.11.7";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.11.8 - The version ID for the coding system identified by CNE.6.  It belongs conceptually to the group of Alternate components (see note 2.A.1) and appears here only for reasons of backward compatibility. Analogous to CNE.7 Coding System Version ID.Usage Notes If present, CNE.8 obeys the same rules of use and interpretation as described for CNE.7.
                /// </summary>
                public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
                {

                    private const string _id = "BPX.11.8";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.11.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
                /// </summary>
                public class OriginalText : HL7Base<OriginalText>
                {

                    private const string _id = "BPX.11.9";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.11.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CN-1 Identifier.
                /// </summary>
                public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
                {

                    private const string _id = "BPX.11.10";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.11.11 - The descriptive or textual name of the Second Alternate Identifier. Analogous to CNE.2 Text.
                /// </summary>
                public class SecondAlternateText : HL7Base<SecondAlternateText>
                {

                    private const string _id = "BPX.11.11";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.11.12 - Identifies the coding scheme being used in the Second Alternate Identifier component. Analogous to CNE.3 Name of Coding System.  Refer to HL7 Table 0396 - Coding Systems in Chapter 2C, Code Tables, for valid values.As of v2.7 this component is required when CNE.10 is populated and CNE.20 is not populated. Both CNE.12 and CNE.20 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CNE.12 and/or CNE.20, the "Coding System" component or the "Coding System OID", for the tuple.
                /// </summary>
                public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
                {

                    private const string _id = "BPX.11.12";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.11.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CNE.7 Coding System Version ID.
                /// </summary>
                public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
                {

                    private const string _id = "BPX.11.13";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.11.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CNE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CNE.1 is populated and CNE.3 is not populated. Both CNE.3 and CNE.14 may be populated.
                /// </summary>
                public class CodingSystemOid : HL7Base<CodingSystemOid>
                {

                    private const string _id = "BPX.11.14";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.11.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CNE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class ValueSetOid : HL7Base<ValueSetOid>
                {

                    private const string _id = "BPX.11.15";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.11.16 - This component carries the version for the value set identified by CNE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CNE.15 is populated.
                /// </summary>
                public class ValueSetVersionId : HL7Base<ValueSetVersionId>
                {

                    private const string _id = "BPX.11.16";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.11.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CNE.6. Analogous to CNE.14 OID for Coding System. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CNE.4 is populated and CNE.6 is not populated. Both CNE.6 and CNE.17 may be populated.
                /// </summary>
                public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
                {

                    private const string _id = "BPX.11.17";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.11.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CNE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
                {

                    private const string _id = "BPX.11.18";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.11.19 - This component carries the version for the value set identified by CNE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CNE.18 is populated.
                /// </summary>
                public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
                {

                    private const string _id = "BPX.11.19";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.11.20 - This component contains the ISO Object Identifier (OID) from which the value in CNE.12 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined numbers, the OID registered in the HL7 OID registry should be used. This component is required when CNE.4 is populated and neither CNE.6 nor CNE.18 is populated. In short either the CNE.6 or the CNE.14 or CNE.17 must be populated when CNE.4 is populated.
                /// </summary>
                public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
                {

                    private const string _id = "BPX.11.20";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.11.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CNE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
                {

                    private const string _id = "BPX.11.21";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.11.22 - This component carries the version for the value set identified by CNE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CNE.21 is populated.
                /// </summary>
                public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
                {

                    private const string _id = "BPX.11.22";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

            }

            /// <summary>
            /// BPX.12 - This is a repeating field to allow multiple entries for special testing that was performed on the blood component.   The preferred coding system for Special Testing is defined in the ISBT 128 Application Specification.  Proposals have been developed and will soon be published by ICCBBA, Inc. for the encodation of other antigen and antibody specificities, including HLA, platelet, red cell and other types of markers.This field is optional for blood component messages.  It is not applicable for non-commercial product messages.Refer to Table I3 - Special Testing Codes of the ISBT 128 Application Specification.
            /// </summary>
            public class BcSpecialTesting : HL7Base<BcSpecialTesting>
            {

                private const string _id = "BPX.12";
                public override string Id
                {
                    get { return _id; }
                }

                private readonly bool[] _repeatableHierarchy = { false, false };
                public override bool[] RepeatableHierarchy
                {
                    get { return _repeatableHierarchy; }
                }

                /// <summary>
                /// BPX.12.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CNE.2. Different coding schemes will have different elements here.Usage Note The identifier is required and must be a valid code.
                /// </summary>
                public class Identifier : HL7Base<Identifier>
                {

                    private const string _id = "BPX.12.1";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, false, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.12.2 - The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression. This is the corresponding text assigned by the coding system to the identifier.Usage Note Text description of code is optional but its use should be encouraged since it makes messages easier to review for accuracy, especially during interface testing and debugging.
                /// </summary>
                public class Text : HL7Base<Text>
                {

                    private const string _id = "BPX.12.2";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, false, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.12.3 - The third component contains the code for the name of the coding system from which the value in CNE.1 is obtained. Refer to HL7 Table 0396 - Coding Systems in Chapter 2C, Code Tables, for valid values. Each coding system is assigned a unique identifier.As of v2.7 this component is required when CNE.1 is populated and CNE.14 is not populated. Both CNE.3 and CNE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CNE.3 and/or CNE.14 the Coding System component or the Coding System OID for the tuple.The combination of the identifier and name of coding system represent a unique concept for a data item.Some organizations that publish code sets author more than one. The coding system, then, to be unique, is a concatenation of the name of the coding authority organization and the name of its code set or table. When an HL7 table is used for a CNE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. Similarly, ISO tables will be named ISOnnnn, where nnnn is the ISO table number.Usage Note The following statement is retained for backward compatibility as of v2.7. Best practice would recommend that this component always be populated. However, if the field narrative explicitly states "Refer to HL7 Table nnnn for valid values, and, if the sending and receiving systems are HL7 compliant, the coding system would be known from the standard.  This would be similar to a field with an ID data type, except that there is a second triplet in which to express an alternate code.
                /// </summary>
                public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
                {

                    private const string _id = "BPX.12.3";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, false, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.12.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CNE.1 Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
                /// </summary>
                public class AlternateIdentifier : HL7Base<AlternateIdentifier>
                {

                    private const string _id = "BPX.12.4";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, false, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.12.5 - The descriptive or textual name of the alternate identifier. Analogous to CNE.2 Text. Usage Notes If present, CNE.5 obeys the same rules of use and interpretation as described for CNE.2. 
                /// </summary>
                public class AlternateText : HL7Base<AlternateText>
                {

                    private const string _id = "BPX.12.5";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, false, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.12.6 - Identifies the coding scheme being used in the alternate identifier component.  Analogous to  CNE.3 Name of Coding System.  Refer to HL7 Table 0396 - Coding Systems in Chapter 2C, Code Tables, for valid values.As of v2.7 this component is required when CNE.4 is populated and CNE.17 is not populated. Both CNE.6 and CNE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CNE.6 and/or CNE.17, the "Coding System" component or the "Coding System OID", for the tuple.Usage Notes If present, CNE.6 obeys the same rules of use and interpretation as described for CNE.3.
                /// </summary>
                public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
                {

                    private const string _id = "BPX.12.6";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, false, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.12.7 - The version ID for the coding system identified by CNE.3. It belongs conceptually to components 1-3 and appears here only for reasons of backward compatibility.Usage Note If the coding system is any system other than an "HL7 coding system," version ID must be valued with an actual version ID. If the coding system is "HL7 coding system," version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. Text description of code is optional but its use should be encouraged since it makes messages easier to review for accuracy, especially during interface testing and debugging.
                /// </summary>
                public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
                {

                    private const string _id = "BPX.12.7";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, false, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.12.8 - The version ID for the coding system identified by CNE.6.  It belongs conceptually to the group of Alternate components (see note 2.A.1) and appears here only for reasons of backward compatibility. Analogous to CNE.7 Coding System Version ID.Usage Notes If present, CNE.8 obeys the same rules of use and interpretation as described for CNE.7.
                /// </summary>
                public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
                {

                    private const string _id = "BPX.12.8";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, false, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.12.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
                /// </summary>
                public class OriginalText : HL7Base<OriginalText>
                {

                    private const string _id = "BPX.12.9";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, false, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.12.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CN-1 Identifier.
                /// </summary>
                public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
                {

                    private const string _id = "BPX.12.10";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, false, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.12.11 - The descriptive or textual name of the Second Alternate Identifier. Analogous to CNE.2 Text.
                /// </summary>
                public class SecondAlternateText : HL7Base<SecondAlternateText>
                {

                    private const string _id = "BPX.12.11";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, false, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.12.12 - Identifies the coding scheme being used in the Second Alternate Identifier component. Analogous to CNE.3 Name of Coding System.  Refer to HL7 Table 0396 - Coding Systems in Chapter 2C, Code Tables, for valid values.As of v2.7 this component is required when CNE.10 is populated and CNE.20 is not populated. Both CNE.12 and CNE.20 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CNE.12 and/or CNE.20, the "Coding System" component or the "Coding System OID", for the tuple.
                /// </summary>
                public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
                {

                    private const string _id = "BPX.12.12";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, false, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.12.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CNE.7 Coding System Version ID.
                /// </summary>
                public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
                {

                    private const string _id = "BPX.12.13";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, false, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.12.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CNE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CNE.1 is populated and CNE.3 is not populated. Both CNE.3 and CNE.14 may be populated.
                /// </summary>
                public class CodingSystemOid : HL7Base<CodingSystemOid>
                {

                    private const string _id = "BPX.12.14";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, false, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.12.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CNE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class ValueSetOid : HL7Base<ValueSetOid>
                {

                    private const string _id = "BPX.12.15";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, false, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.12.16 - This component carries the version for the value set identified by CNE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CNE.15 is populated.
                /// </summary>
                public class ValueSetVersionId : HL7Base<ValueSetVersionId>
                {

                    private const string _id = "BPX.12.16";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, false, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.12.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CNE.6. Analogous to CNE.14 OID for Coding System. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CNE.4 is populated and CNE.6 is not populated. Both CNE.6 and CNE.17 may be populated.
                /// </summary>
                public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
                {

                    private const string _id = "BPX.12.17";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, false, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.12.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CNE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
                {

                    private const string _id = "BPX.12.18";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, false, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.12.19 - This component carries the version for the value set identified by CNE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CNE.18 is populated.
                /// </summary>
                public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
                {

                    private const string _id = "BPX.12.19";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, false, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.12.20 - This component contains the ISO Object Identifier (OID) from which the value in CNE.12 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined numbers, the OID registered in the HL7 OID registry should be used. This component is required when CNE.4 is populated and neither CNE.6 nor CNE.18 is populated. In short either the CNE.6 or the CNE.14 or CNE.17 must be populated when CNE.4 is populated.
                /// </summary>
                public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
                {

                    private const string _id = "BPX.12.20";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, false, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.12.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CNE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
                {

                    private const string _id = "BPX.12.21";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, false, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.12.22 - This component carries the version for the value set identified by CNE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CNE.21 is populated.
                /// </summary>
                public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
                {

                    private const string _id = "BPX.12.22";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, false, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

            }

            /// <summary>
            /// BPX.13 - This field specifies the date and time that the blood product expires.  The blood product is no longer considered acceptable once the expiration date has been reached unless cleared by the transfusion service medical staff.This field applies to blood components as well as commercial products.   There are a few commercial products that have no expiration date.  Therefore, the field is not required for those specific products.
            /// </summary>
            public class BpExpirationDateTime : HL7Base<BpExpirationDateTime>
            {

                private const string _id = "BPX.13";
                public override string Id
                {
                    get { return _id; }
                }

                private readonly bool[] _repeatableHierarchy = { false, true };
                public override bool[] RepeatableHierarchy
                {
                    get { return _repeatableHierarchy; }
                }

            }

            /// <summary>
            /// BPX.14 - This field indicates the number of blood components or commercial products to which this message refers.
            /// </summary>
            public class BpQuantity : HL7Base<BpQuantity>
            {

                private const string _id = "BPX.14";
                public override string Id
                {
                    get { return _id; }
                }

                private readonly bool[] _repeatableHierarchy = { false, true };
                public override bool[] RepeatableHierarchy
                {
                    get { return _repeatableHierarchy; }
                }

            }

            /// <summary>
            /// BPX.15 - This field contains the ordered amount (volume) associated with each quantity of a blood component or commercial product to which this message refers.
            /// </summary>
            public class BpAmount : HL7Base<BpAmount>
            {

                private const string _id = "BPX.15";
                public override string Id
                {
                    get { return _id; }
                }

                private readonly bool[] _repeatableHierarchy = { false, true };
                public override bool[] RepeatableHierarchy
                {
                    get { return _repeatableHierarchy; }
                }

            }

            /// <summary>
            /// BPX.16 - This field contains the units of measure for the blood product amount. (See Chapter 7 for more details about reporting units.)  This field specifies the units of measure for volume of a blood component (i.e., 50 ml) or the units of measure or dosage of a commercial product (i.e., 910 I.U. - International Units - of Factor VIII Concentrate).
            /// </summary>
            public class BpUnits : HL7Base<BpUnits>
            {

                private const string _id = "BPX.16";
                public override string Id
                {
                    get { return _id; }
                }

                private readonly bool[] _repeatableHierarchy = { false, true };
                public override bool[] RepeatableHierarchy
                {
                    get { return _repeatableHierarchy; }
                }

                /// <summary>
                /// BPX.16.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
                /// </summary>
                public class Identifier : HL7Base<Identifier>
                {

                    private const string _id = "BPX.16.1";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.16.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
                /// </summary>
                public class Text : HL7Base<Text>
                {

                    private const string _id = "BPX.16.2";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.16.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
                /// </summary>
                public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
                {

                    private const string _id = "BPX.16.3";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.16.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
                /// </summary>
                public class AlternateIdentifier : HL7Base<AlternateIdentifier>
                {

                    private const string _id = "BPX.16.4";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.16.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
                /// </summary>
                public class AlternateText : HL7Base<AlternateText>
                {

                    private const string _id = "BPX.16.5";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.16.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
                /// </summary>
                public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
                {

                    private const string _id = "BPX.16.6";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.16.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
                /// </summary>
                public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
                {

                    private const string _id = "BPX.16.7";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.16.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
                /// </summary>
                public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
                {

                    private const string _id = "BPX.16.8";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.16.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
                /// </summary>
                public class OriginalText : HL7Base<OriginalText>
                {

                    private const string _id = "BPX.16.9";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.16.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
                /// </summary>
                public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
                {

                    private const string _id = "BPX.16.10";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.16.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
                /// </summary>
                public class SecondAlternateText : HL7Base<SecondAlternateText>
                {

                    private const string _id = "BPX.16.11";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.16.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
                /// </summary>
                public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
                {

                    private const string _id = "BPX.16.12";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.16.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
                /// </summary>
                public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
                {

                    private const string _id = "BPX.16.13";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.16.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
                /// </summary>
                public class CodingSystemOid : HL7Base<CodingSystemOid>
                {

                    private const string _id = "BPX.16.14";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.16.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class ValueSetOid : HL7Base<ValueSetOid>
                {

                    private const string _id = "BPX.16.15";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.16.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
                /// </summary>
                public class ValueSetVersionId : HL7Base<ValueSetVersionId>
                {

                    private const string _id = "BPX.16.16";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.16.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
                /// </summary>
                public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
                {

                    private const string _id = "BPX.16.17";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.16.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
                {

                    private const string _id = "BPX.16.18";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.16.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
                /// </summary>
                public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
                {

                    private const string _id = "BPX.16.19";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.16.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
                /// </summary>
                public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
                {

                    private const string _id = "BPX.16.20";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.16.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
                {

                    private const string _id = "BPX.16.21";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.16.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
                /// </summary>
                public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
                {

                    private const string _id = "BPX.16.22";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

            }

            /// <summary>
            /// BPX.17 - This field is a unique system-generated number assigned to the blood product to which the message is referring.  Each time the status is updated, the new message should replace the previous message if the Blood Product Unique ID is the same.  If the Blood Product Unique ID is different, it indicates that the status applies to a different blood product.The sending and receiving systems must agree upon the use of this field.
            /// </summary>
            public class BpUniqueId : HL7Base<BpUniqueId>
            {

                private const string _id = "BPX.17";
                public override string Id
                {
                    get { return _id; }
                }

                private readonly bool[] _repeatableHierarchy = { false, true };
                public override bool[] RepeatableHierarchy
                {
                    get { return _repeatableHierarchy; }
                }

                /// <summary>
                /// BPX.17.1 - The first component, entity identifier, is usually defined to be unique within the series of identifiers created by the assigning authority, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, "HD - hierarchic designator".
                /// </summary>
                public class EntityIdentifier : HL7Base<EntityIdentifier>
                {

                    private const string _id = "BPX.17.1";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.17.2 - See Section 2.A.33.1, "Namespace ID (IS)" for definition. The component intentionally remains associated with the IS data type in v 2.7.The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363  Assigning Authority for suggested values.Note When the HD is used as a part of another data type, in this case as part of the EI data type, this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment. By site agreement, implementers may continue to use User-defined Table 0300  Namespace ID for the first component
                /// </summary>
                public class NamespaceId : HL7Base<NamespaceId>
                {

                    private const string _id = "BPX.17.2";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.17.3 - See Section 2.A.33.2, "Universal ID (ST)" for definition.
                /// </summary>
                public class UniversalId : HL7Base<UniversalId>
                {

                    private const string _id = "BPX.17.3";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.17.4 - Refer to HL7 Table 0301 - Universal ID Type for valid values. See Section 2.A.33.3, "Universal ID Type (ID)," for definition.
                /// </summary>
                public class UniversalIdType : HL7Base<UniversalIdType>
                {

                    private const string _id = "BPX.17.4";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

            }

            /// <summary>
            /// BPX.18 - This field contains the inpatient or outpatient location to which the blood product was actually dispensed.  The default value is the current census location for the patient.
            /// </summary>
            public class BpActualDispensedToLocation : HL7Base<BpActualDispensedToLocation>
            {

                private const string _id = "BPX.18";
                public override string Id
                {
                    get { return _id; }
                }

                private readonly bool[] _repeatableHierarchy = { false, true };
                public override bool[] RepeatableHierarchy
                {
                    get { return _repeatableHierarchy; }
                }

                /// <summary>
                /// BPX.18.1 - This component specifies the code for the point where patient care is administered. It is conditional on PL.6 Person Location Type (e.g., nursing unit or department or clinic). After floor, it is the most general patient location designation. Refer to User-defined Table 0302 - Point of Care for suggested values.
                /// </summary>
                public class PointOfCare : HL7Base<PointOfCare>
                {

                    private const string _id = "BPX.18.1";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                    /// <summary>
                    /// BPX.18.1.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
                    /// </summary>
                    public class NamespaceId : HL7Base<NamespaceId>
                    {

                        private const string _id = "BPX.18.1.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.18.1.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
                    /// </summary>
                    public class UniversalId : HL7Base<UniversalId>
                    {

                        private const string _id = "BPX.18.1.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.18.1.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
                    /// </summary>
                    public class UniversalIdType : HL7Base<UniversalIdType>
                    {

                        private const string _id = "BPX.18.1.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                }

                /// <summary>
                /// BPX.18.2 - This component specifies the code for the patient's room. After point of care, it is the most general person location designation. Refer to User-defined Table 0303 - Room for suggested values.
                /// </summary>
                public class Room : HL7Base<Room>
                {

                    private const string _id = "BPX.18.2";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                    /// <summary>
                    /// BPX.18.2.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
                    /// </summary>
                    public class NamespaceId : HL7Base<NamespaceId>
                    {

                        private const string _id = "BPX.18.2.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.18.2.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
                    /// </summary>
                    public class UniversalId : HL7Base<UniversalId>
                    {

                        private const string _id = "BPX.18.2.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.18.2.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
                    /// </summary>
                    public class UniversalIdType : HL7Base<UniversalIdType>
                    {

                        private const string _id = "BPX.18.2.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                }

                /// <summary>
                /// BPX.18.3 - This component specifies the code for the patient's bed. After room, it is the most general person location designation. Refer to User-defined Table 0304 - Bed for suggested values.
                /// </summary>
                public class Bed : HL7Base<Bed>
                {

                    private const string _id = "BPX.18.3";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                    /// <summary>
                    /// BPX.18.3.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
                    /// </summary>
                    public class NamespaceId : HL7Base<NamespaceId>
                    {

                        private const string _id = "BPX.18.3.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.18.3.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
                    /// </summary>
                    public class UniversalId : HL7Base<UniversalId>
                    {

                        private const string _id = "BPX.18.3.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.18.3.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
                    /// </summary>
                    public class UniversalIdType : HL7Base<UniversalIdType>
                    {

                        private const string _id = "BPX.18.3.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                }

                /// <summary>
                /// BPX.18.4 - This component is subject to site interpretation but generally describes the highest level physical designation of an institution, medical center or enterprise. It is the most general person location designation. Note When the HD data type is used in a given segment as a component of a field of another data type, User-defined Table 0300 - Namespace ID (referenced by the first sub-component of the HD component) may be redefined (given a different user-defined table number and name) by the technical committee responsible for that segment.
                /// </summary>
                public class Facility : HL7Base<Facility>
                {

                    private const string _id = "BPX.18.4";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                    /// <summary>
                    /// BPX.18.4.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
                    /// </summary>
                    public class NamespaceId : HL7Base<NamespaceId>
                    {

                        private const string _id = "BPX.18.4.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.18.4.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
                    /// </summary>
                    public class UniversalId : HL7Base<UniversalId>
                    {

                        private const string _id = "BPX.18.4.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.18.4.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
                    /// </summary>
                    public class UniversalIdType : HL7Base<UniversalIdType>
                    {

                        private const string _id = "BPX.18.4.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                }

                /// <summary>
                /// BPX.18.5 - This component specifies the code for the status or availability of the location. For example, it may convey bed status. Refer to User-defined Table 0306 - Location Status for suggested values.
                /// </summary>
                public class LocationStatus : HL7Base<LocationStatus>
                {

                    private const string _id = "BPX.18.5";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.18.6 - Person location type is the categorization of the persons location defined by facility, building, floor, point of care, room or bed. Although not a required field, when used, it may be the only populated field. It usually includes values such as nursing unit, department, clinic, SNF, physicians office. Refer to User-defined Table 0305 - Person location type for suggested values.
                /// </summary>
                public class PersonLocationType : HL7Base<PersonLocationType>
                {

                    private const string _id = "BPX.18.6";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.18.7 - This component specifies the code for the building where the person is located. After facility, it is the most general person location designation. Refer to User-defined Table 0307 - Building for suggested values.
                /// </summary>
                public class Building : HL7Base<Building>
                {

                    private const string _id = "BPX.18.7";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                    /// <summary>
                    /// BPX.18.7.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
                    /// </summary>
                    public class NamespaceId : HL7Base<NamespaceId>
                    {

                        private const string _id = "BPX.18.7.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.18.7.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
                    /// </summary>
                    public class UniversalId : HL7Base<UniversalId>
                    {

                        private const string _id = "BPX.18.7.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.18.7.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
                    /// </summary>
                    public class UniversalIdType : HL7Base<UniversalIdType>
                    {

                        private const string _id = "BPX.18.7.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                }

                /// <summary>
                /// BPX.18.8 - This component specifies the code for the floor where the person is located. After building, it is the most general person location designation. Refer to User-defined Table 0308 - Floor for suggested values.
                /// </summary>
                public class Floor : HL7Base<Floor>
                {

                    private const string _id = "BPX.18.8";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                    /// <summary>
                    /// BPX.18.8.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
                    /// </summary>
                    public class NamespaceId : HL7Base<NamespaceId>
                    {

                        private const string _id = "BPX.18.8.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.18.8.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
                    /// </summary>
                    public class UniversalId : HL7Base<UniversalId>
                    {

                        private const string _id = "BPX.18.8.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.18.8.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
                    /// </summary>
                    public class UniversalIdType : HL7Base<UniversalIdType>
                    {

                        private const string _id = "BPX.18.8.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                }

                /// <summary>
                /// BPX.18.9 - This component describes the location in free text.
                /// </summary>
                public class LocationDescription : HL7Base<LocationDescription>
                {

                    private const string _id = "BPX.18.9";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.18.10 - The unique identifier that represents the physical location as a whole without regard for the individual components. This accommodates sites that may have a different method of defining physical units or who may code at a less granular level. For example, point of care, room, and bed may be 1 indivisible code.
                /// </summary>
                public class ComprehensiveLocationIdentifier : HL7Base<ComprehensiveLocationIdentifier>
                {

                    private const string _id = "BPX.18.10";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                    /// <summary>
                    /// BPX.18.10.1 - The first component, entity identifier, is usually defined to be unique within the series of identifiers created by the assigning authority, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, "HD - hierarchic designator".
                    /// </summary>
                    public class EntityIdentifier : HL7Base<EntityIdentifier>
                    {

                        private const string _id = "BPX.18.10.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.18.10.2 - See Section 2.A.33.1, "Namespace ID (IS)" for definition. The component intentionally remains associated with the IS data type in v 2.7.The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363  Assigning Authority for suggested values.Note When the HD is used as a part of another data type, in this case as part of the EI data type, this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment. By site agreement, implementers may continue to use User-defined Table 0300  Namespace ID for the first component
                    /// </summary>
                    public class NamespaceId : HL7Base<NamespaceId>
                    {

                        private const string _id = "BPX.18.10.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.18.10.3 - See Section 2.A.33.2, "Universal ID (ST)" for definition.
                    /// </summary>
                    public class UniversalId : HL7Base<UniversalId>
                    {

                        private const string _id = "BPX.18.10.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.18.10.4 - Refer to HL7 Table 0301 - Universal ID Type for valid values. See Section 2.A.33.3, "Universal ID Type (ID)," for definition.
                    /// </summary>
                    public class UniversalIdType : HL7Base<UniversalIdType>
                    {

                        private const string _id = "BPX.18.10.4";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                }

                /// <summary>
                /// BPX.18.11 - The entity that creates the data for the individual physical location components. If populated, it should be the authority for all components populated. Refer to User-defined Table 0363  Assigning Authority for suggested values for the first sub-component of the HD component, namespace ID.This component makes it possible for codes to be differentiated when the field in which this data type is used repeats.Note When the HD data type is used in a given segment as a component of a field of another data type, User-defined Table 0300 - Namespace ID (referenced by the first sub-component of the HD component) may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.By site agreement, implementors may continue to use User-defined Table 0300  Namespace ID for the first sub-component.
                /// </summary>
                public class AssigningAuthorityForLocation : HL7Base<AssigningAuthorityForLocation>
                {

                    private const string _id = "BPX.18.11";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                    /// <summary>
                    /// BPX.18.11.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
                    /// </summary>
                    public class NamespaceId : HL7Base<NamespaceId>
                    {

                        private const string _id = "BPX.18.11.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.18.11.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
                    /// </summary>
                    public class UniversalId : HL7Base<UniversalId>
                    {

                        private const string _id = "BPX.18.11.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.18.11.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
                    /// </summary>
                    public class UniversalIdType : HL7Base<UniversalIdType>
                    {

                        private const string _id = "BPX.18.11.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                }

            }

            /// <summary>
            /// BPX.19 - This field contains the actual address of the location to which the blood product was actually dispensed.
            /// </summary>
            public class BpActualDispensedToAddress : HL7Base<BpActualDispensedToAddress>
            {

                private const string _id = "BPX.19";
                public override string Id
                {
                    get { return _id; }
                }

                private readonly bool[] _repeatableHierarchy = { false, true };
                public override bool[] RepeatableHierarchy
                {
                    get { return _repeatableHierarchy; }
                }

                /// <summary>
                /// BPX.19.1 - This component contains the house number, apartment number, street name, street direction, P.O. Box number, and similar address information. 
                /// </summary>
                public class StreetAddress : HL7Base<StreetAddress>
                {

                    private const string _id = "BPX.19.1";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                    /// <summary>
                    /// BPX.19.1.1 - This component specifies the street or mailing address of a person or institution. When referencing an institution, this first component is used to specify the institution name. When used in connection with a person, this component specifies the first line of the address.
                    /// </summary>
                    public class StreetOrMailingAddress : HL7Base<StreetOrMailingAddress>
                    {

                        private const string _id = "BPX.19.1.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.1.2 - 
                    /// </summary>
                    public class StreetName : HL7Base<StreetName>
                    {

                        private const string _id = "BPX.19.1.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.1.3 - 
                    /// </summary>
                    public class DwellingNumber : HL7Base<DwellingNumber>
                    {

                        private const string _id = "BPX.19.1.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                }

                /// <summary>
                /// BPX.19.2 - This component contains the second line of address. In US usage, it qualifies address. Examples Suite 555 or Fourth Floor. When referencing an institution, this component specifies the street address.
                /// </summary>
                public class OtherDesignation : HL7Base<OtherDesignation>
                {

                    private const string _id = "BPX.19.2";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.19.3 - This component specifies the city, or district or place where the addressee is located depending upon the national convention for formatting addresses for postal usage.
                /// </summary>
                public class City : HL7Base<City>
                {

                    private const string _id = "BPX.19.3";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.19.4 - This component specifies the state or province where the addressee is located. State or province should be represented by the official postal service codes for that country.
                /// </summary>
                public class StateOrProvince : HL7Base<StateOrProvince>
                {

                    private const string _id = "BPX.19.4";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.19.5 - This component specifies the zip or postal code where the addressee is located. Zip or postal codes should be represented by the official codes for that country. In the US, the zip code takes the form 99999-9999, while the Canadian postal code takes the form A9A9A9, and the Australian Postcode takes the form 9999.
                /// </summary>
                public class ZipOrPostalCode : HL7Base<ZipOrPostalCode>
                {

                    private const string _id = "BPX.19.5";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.19.6 - This component specifies the country where the addressee is located.  HL7 specifies that the 3-character (alphabetic) form of ISO 3166 be used for the country code. Refer to HL7 Table 0399  Country Code for valid values.
                /// </summary>
                public class Country : HL7Base<Country>
                {

                    private const string _id = "BPX.19.6";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.19.7 - This component specifies the kind or type of address. Refer to HL7 Table 0190 - Address Type for valid values.XAD.7 is required if there are multiple occurrences of XAD in a field.
                /// </summary>
                public class AddressType : HL7Base<AddressType>
                {

                    private const string _id = "BPX.19.7";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.19.8 - This component specifies any other geographic designation. It includes county, bioregion, SMSA, etc.
                /// </summary>
                public class OtherGeographicDesignation : HL7Base<OtherGeographicDesignation>
                {

                    private const string _id = "BPX.19.8";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.19.9 - A code that represents the county in which the specified address resides. User-defined Table 0289 - County/parish is used as the HL7 identifier for the user-defined table of values for this component. When this component is used to represent the county (or parish), component 8 other geographic designation should not duplicate it (i.e., the use of other geographic designation to represent the county is allowed only for the purpose of backward compatibility, and should be discouraged in this and future versions of HL7).Allowable values codes defined by government.
                /// </summary>
                public class CountyParishCode : HL7Base<CountyParishCode>
                {

                    private const string _id = "BPX.19.9";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                    /// <summary>
                    /// BPX.19.9.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
                    /// </summary>
                    public class Identifier : HL7Base<Identifier>
                    {

                        private const string _id = "BPX.19.9.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.9.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
                    /// </summary>
                    public class Text : HL7Base<Text>
                    {

                        private const string _id = "BPX.19.9.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.9.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
                    /// </summary>
                    public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
                    {

                        private const string _id = "BPX.19.9.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.9.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
                    /// </summary>
                    public class AlternateIdentifier : HL7Base<AlternateIdentifier>
                    {

                        private const string _id = "BPX.19.9.4";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.9.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
                    /// </summary>
                    public class AlternateText : HL7Base<AlternateText>
                    {

                        private const string _id = "BPX.19.9.5";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.9.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
                    {

                        private const string _id = "BPX.19.9.6";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.9.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
                    /// </summary>
                    public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
                    {

                        private const string _id = "BPX.19.9.7";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.9.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
                    {

                        private const string _id = "BPX.19.9.8";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.9.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
                    /// </summary>
                    public class OriginalText : HL7Base<OriginalText>
                    {

                        private const string _id = "BPX.19.9.9";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.9.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
                    /// </summary>
                    public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
                    {

                        private const string _id = "BPX.19.9.10";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.9.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
                    /// </summary>
                    public class SecondAlternateText : HL7Base<SecondAlternateText>
                    {

                        private const string _id = "BPX.19.9.11";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.9.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
                    {

                        private const string _id = "BPX.19.9.12";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.9.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
                    {

                        private const string _id = "BPX.19.9.13";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.9.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
                    /// </summary>
                    public class CodingSystemOid : HL7Base<CodingSystemOid>
                    {

                        private const string _id = "BPX.19.9.14";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.9.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class ValueSetOid : HL7Base<ValueSetOid>
                    {

                        private const string _id = "BPX.19.9.15";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.9.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
                    /// </summary>
                    public class ValueSetVersionId : HL7Base<ValueSetVersionId>
                    {

                        private const string _id = "BPX.19.9.16";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.9.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
                    /// </summary>
                    public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
                    {

                        private const string _id = "BPX.19.9.17";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.9.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
                    {

                        private const string _id = "BPX.19.9.18";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.9.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
                    /// </summary>
                    public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
                    {

                        private const string _id = "BPX.19.9.19";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.9.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
                    /// </summary>
                    public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
                    {

                        private const string _id = "BPX.19.9.20";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.9.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
                    {

                        private const string _id = "BPX.19.9.21";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.9.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
                    /// </summary>
                    public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
                    {

                        private const string _id = "BPX.19.9.22";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                }

                /// <summary>
                /// BPX.19.10 - A code that represents the census tract in which the specified address resides. User-defined Table 0288 - Census Tract is used as the HL7 identifier for the user-defined table of values for this component.Allowable Values codes defined by government.
                /// </summary>
                public class CensusTract : HL7Base<CensusTract>
                {

                    private const string _id = "BPX.19.10";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                    /// <summary>
                    /// BPX.19.10.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
                    /// </summary>
                    public class Identifier : HL7Base<Identifier>
                    {

                        private const string _id = "BPX.19.10.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.10.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
                    /// </summary>
                    public class Text : HL7Base<Text>
                    {

                        private const string _id = "BPX.19.10.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.10.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
                    /// </summary>
                    public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
                    {

                        private const string _id = "BPX.19.10.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.10.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
                    /// </summary>
                    public class AlternateIdentifier : HL7Base<AlternateIdentifier>
                    {

                        private const string _id = "BPX.19.10.4";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.10.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
                    /// </summary>
                    public class AlternateText : HL7Base<AlternateText>
                    {

                        private const string _id = "BPX.19.10.5";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.10.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
                    {

                        private const string _id = "BPX.19.10.6";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.10.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
                    /// </summary>
                    public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
                    {

                        private const string _id = "BPX.19.10.7";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.10.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
                    {

                        private const string _id = "BPX.19.10.8";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.10.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
                    /// </summary>
                    public class OriginalText : HL7Base<OriginalText>
                    {

                        private const string _id = "BPX.19.10.9";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.10.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
                    /// </summary>
                    public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
                    {

                        private const string _id = "BPX.19.10.10";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.10.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
                    /// </summary>
                    public class SecondAlternateText : HL7Base<SecondAlternateText>
                    {

                        private const string _id = "BPX.19.10.11";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.10.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
                    {

                        private const string _id = "BPX.19.10.12";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.10.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
                    {

                        private const string _id = "BPX.19.10.13";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.10.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
                    /// </summary>
                    public class CodingSystemOid : HL7Base<CodingSystemOid>
                    {

                        private const string _id = "BPX.19.10.14";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.10.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class ValueSetOid : HL7Base<ValueSetOid>
                    {

                        private const string _id = "BPX.19.10.15";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.10.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
                    /// </summary>
                    public class ValueSetVersionId : HL7Base<ValueSetVersionId>
                    {

                        private const string _id = "BPX.19.10.16";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.10.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
                    /// </summary>
                    public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
                    {

                        private const string _id = "BPX.19.10.17";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.10.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
                    {

                        private const string _id = "BPX.19.10.18";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.10.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
                    /// </summary>
                    public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
                    {

                        private const string _id = "BPX.19.10.19";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.10.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
                    /// </summary>
                    public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
                    {

                        private const string _id = "BPX.19.10.20";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.10.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
                    {

                        private const string _id = "BPX.19.10.21";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.10.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
                    /// </summary>
                    public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
                    {

                        private const string _id = "BPX.19.10.22";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                }

                /// <summary>
                /// BPX.19.11 - Different name/address types and representations of the same name/address should be described by repeating of this field, with different values of the name/address type and/or name/address representation component.Note Also note that this new component remains in "alphabetic" representation with each repetition of the fields using these data types. I.e. even though the address may be represented in an ideographic character set, this component will remain represented in an alphabetic character set.Refer to HL7 Table 0465  Name/address Representation for valid values.In general this component provides an indication of the representation provided by the data item. It does not necessarily specify the character sets used. Thus, even though the representation might provide an indication of what to expect, the sender is still free to encode the contents using whatever character set is desired. This component provides only hints for the receiver, so it can make choices regarding what it has been sent and what it is capable of displaying.
                /// </summary>
                public class AddressRepresentationCode : HL7Base<AddressRepresentationCode>
                {

                    private const string _id = "BPX.19.11";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.19.12 - Attention The XAD.12 component was retained for backward compatibility as of v2.5 and the detail was withdrawn and removed from the standard as of v2.7. Refer to 2.A.86.13, "Effective Date (DTM)" and 2.A.86.14, "Expiration Date (DTM)" components.
                /// </summary>
                public class AddressValidityRange : HL7Base<AddressValidityRange>
                {

                    private const string _id = "BPX.19.12";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.19.13 - The first date, if known, on which the address is valid and active for the owning entity.
                /// </summary>
                public class EffectiveDate : HL7Base<EffectiveDate>
                {

                    private const string _id = "BPX.19.13";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.19.14 - The last date, if known, on which the address is valid and active for the owning entity.
                /// </summary>
                public class ExpirationDate : HL7Base<ExpirationDate>
                {

                    private const string _id = "BPX.19.14";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.19.15 - This identifies why this address was marked as "ended".   Refer to User-defined Table 0616  Address Expiration Reason for valid values.
                /// </summary>
                public class ExpirationReason : HL7Base<ExpirationReason>
                {

                    private const string _id = "BPX.19.15";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                    /// <summary>
                    /// BPX.19.15.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
                    /// </summary>
                    public class Identifier : HL7Base<Identifier>
                    {

                        private const string _id = "BPX.19.15.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.15.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
                    /// </summary>
                    public class Text : HL7Base<Text>
                    {

                        private const string _id = "BPX.19.15.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.15.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
                    /// </summary>
                    public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
                    {

                        private const string _id = "BPX.19.15.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.15.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
                    /// </summary>
                    public class AlternateIdentifier : HL7Base<AlternateIdentifier>
                    {

                        private const string _id = "BPX.19.15.4";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.15.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
                    /// </summary>
                    public class AlternateText : HL7Base<AlternateText>
                    {

                        private const string _id = "BPX.19.15.5";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.15.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
                    {

                        private const string _id = "BPX.19.15.6";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.15.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
                    /// </summary>
                    public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
                    {

                        private const string _id = "BPX.19.15.7";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.15.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
                    {

                        private const string _id = "BPX.19.15.8";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.15.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
                    /// </summary>
                    public class OriginalText : HL7Base<OriginalText>
                    {

                        private const string _id = "BPX.19.15.9";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.15.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
                    /// </summary>
                    public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
                    {

                        private const string _id = "BPX.19.15.10";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.15.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
                    /// </summary>
                    public class SecondAlternateText : HL7Base<SecondAlternateText>
                    {

                        private const string _id = "BPX.19.15.11";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.15.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
                    {

                        private const string _id = "BPX.19.15.12";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.15.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
                    {

                        private const string _id = "BPX.19.15.13";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.15.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
                    /// </summary>
                    public class CodingSystemOid : HL7Base<CodingSystemOid>
                    {

                        private const string _id = "BPX.19.15.14";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.15.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class ValueSetOid : HL7Base<ValueSetOid>
                    {

                        private const string _id = "BPX.19.15.15";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.15.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
                    /// </summary>
                    public class ValueSetVersionId : HL7Base<ValueSetVersionId>
                    {

                        private const string _id = "BPX.19.15.16";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.15.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
                    /// </summary>
                    public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
                    {

                        private const string _id = "BPX.19.15.17";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.15.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
                    {

                        private const string _id = "BPX.19.15.18";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.15.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
                    /// </summary>
                    public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
                    {

                        private const string _id = "BPX.19.15.19";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.15.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
                    /// </summary>
                    public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
                    {

                        private const string _id = "BPX.19.15.20";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.15.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
                    {

                        private const string _id = "BPX.19.15.21";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.15.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
                    /// </summary>
                    public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
                    {

                        private const string _id = "BPX.19.15.22";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                }

                /// <summary>
                /// BPX.19.16 - If "Y" this indicates that the address is considered temporary.  Refer to HL7 Table 0136  Yes/No Indicator.
                /// </summary>
                public class TemporaryIndicator : HL7Base<TemporaryIndicator>
                {

                    private const string _id = "BPX.19.16";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.19.17 - If "Y", this indicates that it is not possible to contact the "owning" entity at this address. Refer to HL7 Table 0136  Yes/No Indicator.
                /// </summary>
                public class BadAddressIndicator : HL7Base<BadAddressIndicator>
                {

                    private const string _id = "BPX.19.17";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.19.18 - This indicates how the address is intended to be used.  Refer to User-defined Table 0617  Address Usage for valid values.
                /// </summary>
                public class AddressUsage : HL7Base<AddressUsage>
                {

                    private const string _id = "BPX.19.18";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.19.19 - Identifies the name of the person or organization that should appear as part of the address. This is also known as the "Care of" or "C/O" line.
                /// </summary>
                public class Addressee : HL7Base<Addressee>
                {

                    private const string _id = "BPX.19.19";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.19.20 - Descriptive information about the use of the address.Example "Do not ring bell."
                /// </summary>
                public class Comment : HL7Base<Comment>
                {

                    private const string _id = "BPX.19.20";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.19.21 - For an entity having multiple addresses, indicates which is the 'most preferred' (lowest number) to 'least preferred' (highest number).If the preference order is unique across all usages for a given type, then it indicates the preference across all usages, (e.g., first try my home address, then my business address). Otherwise, the preference order is assumed to only apply within a specific usage.Preference order numbers need not be sequential (i.e., four addresses with the priority orders of 10, 1, 5 and 15 are legitimate). The preference order numbers must be non-negative.
                /// </summary>
                public class PreferenceOrder : HL7Base<PreferenceOrder>
                {

                    private const string _id = "BPX.19.21";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.19.22 - Identifies that an address needs to be treated with special care or sensitivity.The specific set of codes and appropriate handling of such addresses will vary by jurisdiction and is subject to site-specific negotiation. For example, a provider address marked as 'unlisted' might not be printed in an internal address listing.  Refer to User-defined Table 0618  Protection Code for valid values.
                /// </summary>
                public class ProtectionCode : HL7Base<ProtectionCode>
                {

                    private const string _id = "BPX.19.22";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                    /// <summary>
                    /// BPX.19.22.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
                    /// </summary>
                    public class Identifier : HL7Base<Identifier>
                    {

                        private const string _id = "BPX.19.22.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.22.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
                    /// </summary>
                    public class Text : HL7Base<Text>
                    {

                        private const string _id = "BPX.19.22.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.22.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
                    /// </summary>
                    public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
                    {

                        private const string _id = "BPX.19.22.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.22.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
                    /// </summary>
                    public class AlternateIdentifier : HL7Base<AlternateIdentifier>
                    {

                        private const string _id = "BPX.19.22.4";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.22.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
                    /// </summary>
                    public class AlternateText : HL7Base<AlternateText>
                    {

                        private const string _id = "BPX.19.22.5";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.22.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
                    {

                        private const string _id = "BPX.19.22.6";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.22.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
                    /// </summary>
                    public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
                    {

                        private const string _id = "BPX.19.22.7";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.22.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
                    {

                        private const string _id = "BPX.19.22.8";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.22.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
                    /// </summary>
                    public class OriginalText : HL7Base<OriginalText>
                    {

                        private const string _id = "BPX.19.22.9";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.22.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
                    /// </summary>
                    public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
                    {

                        private const string _id = "BPX.19.22.10";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.22.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
                    /// </summary>
                    public class SecondAlternateText : HL7Base<SecondAlternateText>
                    {

                        private const string _id = "BPX.19.22.11";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.22.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
                    {

                        private const string _id = "BPX.19.22.12";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.22.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
                    {

                        private const string _id = "BPX.19.22.13";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.22.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
                    /// </summary>
                    public class CodingSystemOid : HL7Base<CodingSystemOid>
                    {

                        private const string _id = "BPX.19.22.14";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.22.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class ValueSetOid : HL7Base<ValueSetOid>
                    {

                        private const string _id = "BPX.19.22.15";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.22.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
                    /// </summary>
                    public class ValueSetVersionId : HL7Base<ValueSetVersionId>
                    {

                        private const string _id = "BPX.19.22.16";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.22.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
                    /// </summary>
                    public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
                    {

                        private const string _id = "BPX.19.22.17";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.22.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
                    {

                        private const string _id = "BPX.19.22.18";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.22.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
                    /// </summary>
                    public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
                    {

                        private const string _id = "BPX.19.22.19";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.22.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
                    /// </summary>
                    public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
                    {

                        private const string _id = "BPX.19.22.20";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.22.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
                    {

                        private const string _id = "BPX.19.22.21";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.22.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
                    /// </summary>
                    public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
                    {

                        private const string _id = "BPX.19.22.22";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                }

                /// <summary>
                /// BPX.19.23 - A unique identifier for the address.This component allows an address to be uniquely identified, and enables the linking of a single address to multiple people and contexts. For example, each member of a family living at the same location would share the same address, having the same identifier. A correction to the address of one family member could be automatically propagated to other members of the family.
                /// </summary>
                public class AddressIdentifier : HL7Base<AddressIdentifier>
                {

                    private const string _id = "BPX.19.23";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                    /// <summary>
                    /// BPX.19.23.1 - The first component, entity identifier, is usually defined to be unique within the series of identifiers created by the assigning authority, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, "HD - hierarchic designator".
                    /// </summary>
                    public class EntityIdentifier : HL7Base<EntityIdentifier>
                    {

                        private const string _id = "BPX.19.23.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.23.2 - See Section 2.A.33.1, "Namespace ID (IS)" for definition. The component intentionally remains associated with the IS data type in v 2.7.The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363  Assigning Authority for suggested values.Note When the HD is used as a part of another data type, in this case as part of the EI data type, this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment. By site agreement, implementers may continue to use User-defined Table 0300  Namespace ID for the first component
                    /// </summary>
                    public class NamespaceId : HL7Base<NamespaceId>
                    {

                        private const string _id = "BPX.19.23.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.23.3 - See Section 2.A.33.2, "Universal ID (ST)" for definition.
                    /// </summary>
                    public class UniversalId : HL7Base<UniversalId>
                    {

                        private const string _id = "BPX.19.23.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.19.23.4 - Refer to HL7 Table 0301 - Universal ID Type for valid values. See Section 2.A.33.3, "Universal ID Type (ID)," for definition.
                    /// </summary>
                    public class UniversalIdType : HL7Base<UniversalIdType>
                    {

                        private const string _id = "BPX.19.23.4";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                }

            }

            /// <summary>
            /// BPX.20 - This is the person who picked up and transported the blood component(s) or commercial product(s).  The code for the receiver is recorded as a XCN data type.  This field can be free text.   In this case, the receiver's name must be recorded as the second through fourth components of the field.
            /// </summary>
            public class BpDispensedToReceiver : HL7Base<BpDispensedToReceiver>
            {

                private const string _id = "BPX.20";
                public override string Id
                {
                    get { return _id; }
                }

                private readonly bool[] _repeatableHierarchy = { false, true };
                public override bool[] RepeatableHierarchy
                {
                    get { return _repeatableHierarchy; }
                }

                /// <summary>
                /// BPX.20.1 - This component carries the Person Identifier itself. XCN.1, in conjunction with XCN.9 uniquely identifies the entity/person. XCN.1 is required if XCN.2 is not populated. Both may be populated. 
                /// </summary>
                public class PersonIdentifier : HL7Base<PersonIdentifier>
                {

                    private const string _id = "BPX.20.1";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.20.2 - This component allows full specification of the surname of a person. Where appropriate, it differentiates the person's own surname from that of the person's partner or spouse, in cases where the person's name may contain elements from either name. It also permits messages to distinguish the surname prefix (such as "van" or "de") from the surname root. See section 2.A.30, "FN - family name".XCN.2 is required if XCN.1 is not populated. Both may be populated.
                /// </summary>
                public class FamilyName : HL7Base<FamilyName>
                {

                    private const string _id = "BPX.20.2";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                    /// <summary>
                    /// BPX.20.2.1 - The atomic element of the person's family name. In most Western usage, this is the person's last name.
                    /// </summary>
                    public class Surname : HL7Base<Surname>
                    {

                        private const string _id = "BPX.20.2.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.2.2 - Internationalization usage for Germanic languages. This component is optional. An example of a surname prefix is the "van" in "Ludwig van Beethoven". Since the surname prefix doesn't sort completely alphabetically, it is reasonable to specify it as a separate sub-component of the PN and extended PN data types (XPN and XCN).Note Subcomponents own surname prefix, own surname, surname prefix from partner/spouse and surname from partner/spouse decompose complex Germanic names such as Martha de Mum-van Beethoven. If these subcomponents are valued, the surname subcomponent should still be fully valued for backward compatibility, i.e., de Mum-van Beethoven&de&Mum&van&Beethoven.Also, for clarity, the last name prefix has been renamed to own surname prefix.
                    /// </summary>
                    public class OwnSurnamePrefix : HL7Base<OwnSurnamePrefix>
                    {

                        private const string _id = "BPX.20.2.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.2.3 - The portion of the surname (in most Western usage, the last name) that is derived from the person's own surname, as distinguished from any portion that is derived from the surname of the person's partner or spouse. This component is optional.If the person's surname has legally changed to become (or incorporate) the surname of the person's partner or spouse, this is the person's surname immediately prior to such change. Often this is the person's "maiden name".
                    /// </summary>
                    public class OwnSurname : HL7Base<OwnSurname>
                    {

                        private const string _id = "BPX.20.2.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.2.4 - Internationalization usage for Germanic languages. This component is optional. An example of a surname prefix is the van in "Ludwig van Beethoven". Since the surname prefix doesn't sort completely alphabetically, it is reasonable to specify it as a separate sub-component of the PN and extended PN data types (XPN and XCN). Note Subcomponents own surname prefix, own surname, surname prefix from partner/spouse and surname from partner/spouse decompose complex Germanic names such as Martha de Mum-van Beethoven. If these subcomponents are valued, the surname subcomponent should still be fully valued for backward compatibility, i.e., de Mum-van Beethoven&de&Mum&van&Beethoven.Also, for clarity, the last name prefix has been renamed to own surname prefix.
                    /// </summary>
                    public class SurnamePrefixFromPartnerSpouse : HL7Base<SurnamePrefixFromPartnerSpouse>
                    {

                        private const string _id = "BPX.20.2.4";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.2.5 - The portion of the person's surname (in most Western usage, the last name) that is derived from the surname of the person's partner or spouse, as distinguished from the part derived from the person's own surname. This component is optional.If no portion of the person's surname is derived from the surname of the person's partner or spouse, this component is not valued. Otherwise, if the surname of the partner or spouse has legally changed to become (or incorporate) the person's surname, this is the surname of the partner or spouse immediately prior to such change.
                    /// </summary>
                    public class SurnameFromPartnerSpouse : HL7Base<SurnameFromPartnerSpouse>
                    {

                        private const string _id = "BPX.20.2.5";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                }

                /// <summary>
                /// BPX.20.3 - First name.
                /// </summary>
                public class GivenName : HL7Base<GivenName>
                {

                    private const string _id = "BPX.20.3";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.20.4 - Multiple middle names may be included by separating them with spaces.
                /// </summary>
                public class SecondAndFurtherGivenNamesOrInitialsThereof : HL7Base<SecondAndFurtherGivenNamesOrInitialsThereof>
                {

                    private const string _id = "BPX.20.4";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.20.5 - Used to specify a name suffix (e.g., Jr. or III).
                /// </summary>
                public class SuffixegJrOrIii : HL7Base<SuffixegJrOrIii>
                {

                    private const string _id = "BPX.20.5";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.20.6 - Used to specify a name prefix (e.g., Dr.).
                /// </summary>
                public class PrefixegDr : HL7Base<PrefixegDr>
                {

                    private const string _id = "BPX.20.6";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.20.7 - Attention The XCN-7 component was deprecated as of v2.5 and the detail was withdrawn and removed from the standard as of v27.. Refer to XCN.21 Professional Suffix.
                /// </summary>
                public class DegreeegMd : HL7Base<DegreeegMd>
                {

                    private const string _id = "BPX.20.7";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.20.8 - Attention Retained for backwards compatibility only as of v 2.7. The reader is referred to XCN.9 instead.User-defined Table 0297  CN ID source is used as the HL7 identifier for the user-defined table of values for this component. Used to delineate the first component.
                /// </summary>
                public class SourceTable : HL7Base<SourceTable>
                {

                    private const string _id = "BPX.20.8";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                    /// <summary>
                    /// BPX.20.8.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
                    /// </summary>
                    public class Identifier : HL7Base<Identifier>
                    {

                        private const string _id = "BPX.20.8.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.8.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
                    /// </summary>
                    public class Text : HL7Base<Text>
                    {

                        private const string _id = "BPX.20.8.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.8.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
                    /// </summary>
                    public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
                    {

                        private const string _id = "BPX.20.8.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.8.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
                    /// </summary>
                    public class AlternateIdentifier : HL7Base<AlternateIdentifier>
                    {

                        private const string _id = "BPX.20.8.4";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.8.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
                    /// </summary>
                    public class AlternateText : HL7Base<AlternateText>
                    {

                        private const string _id = "BPX.20.8.5";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.8.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
                    {

                        private const string _id = "BPX.20.8.6";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.8.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
                    /// </summary>
                    public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
                    {

                        private const string _id = "BPX.20.8.7";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.8.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
                    {

                        private const string _id = "BPX.20.8.8";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.8.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
                    /// </summary>
                    public class OriginalText : HL7Base<OriginalText>
                    {

                        private const string _id = "BPX.20.8.9";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.8.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
                    /// </summary>
                    public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
                    {

                        private const string _id = "BPX.20.8.10";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.8.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
                    /// </summary>
                    public class SecondAlternateText : HL7Base<SecondAlternateText>
                    {

                        private const string _id = "BPX.20.8.11";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.8.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
                    {

                        private const string _id = "BPX.20.8.12";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.8.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
                    {

                        private const string _id = "BPX.20.8.13";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.8.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
                    /// </summary>
                    public class CodingSystemOid : HL7Base<CodingSystemOid>
                    {

                        private const string _id = "BPX.20.8.14";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.8.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class ValueSetOid : HL7Base<ValueSetOid>
                    {

                        private const string _id = "BPX.20.8.15";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.8.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
                    /// </summary>
                    public class ValueSetVersionId : HL7Base<ValueSetVersionId>
                    {

                        private const string _id = "BPX.20.8.16";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.8.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
                    /// </summary>
                    public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
                    {

                        private const string _id = "BPX.20.8.17";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.8.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
                    {

                        private const string _id = "BPX.20.8.18";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.8.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
                    /// </summary>
                    public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
                    {

                        private const string _id = "BPX.20.8.19";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.8.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
                    /// </summary>
                    public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
                    {

                        private const string _id = "BPX.20.8.20";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.8.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
                    {

                        private const string _id = "BPX.20.8.21";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.8.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
                    /// </summary>
                    public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
                    {

                        private const string _id = "BPX.20.8.22";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                }

                /// <summary>
                /// BPX.20.9 - The assigning authority is a unique identifier of the system (or organization or agency of department) that creates the data. User-defined Table 0363  Assigning Authority is used as the HL7 identifier for the user-defined table of values for the first sub-component of the HD component, namespace ID.As of v 2.7, the Assigning Authority is conditional. It is required if XCN.1 is populated and neither XCN.22 nor XCN.23 are populated. All 3 components may be populated. No assumptions can be safely made based on position or sequence. Best practice is to send an OID in this component when populated.The reader is referred to XCN.22 and XCN.23 if there is a need to transmit values with semantic meaning for an assigning jurisdiction or assigning department or agency in addition to, or instead of, an assigning authority. However, all 3 components may be valued.  If, in so doing, it is discovered that the values in XCN.22 and/or XCN.23 conflict with XCN.9, the user would look to the Message Profile or other implementation agreement for a statement as to which takes precedence.Note When the HD data type is used in a given segment as a component of a field of another data type, User-defined Table 0300 - Namespace ID (referenced by the first sub-component of the HD component) may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.By site agreement, implementors may continue to use User-defined Table 0300  Namespace ID for the first sub-component.
                /// </summary>
                public class AssigningAuthority : HL7Base<AssigningAuthority>
                {

                    private const string _id = "BPX.20.9";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                    /// <summary>
                    /// BPX.20.9.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
                    /// </summary>
                    public class NamespaceId : HL7Base<NamespaceId>
                    {

                        private const string _id = "BPX.20.9.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.9.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
                    /// </summary>
                    public class UniversalId : HL7Base<UniversalId>
                    {

                        private const string _id = "BPX.20.9.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.9.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
                    /// </summary>
                    public class UniversalIdType : HL7Base<UniversalIdType>
                    {

                        private const string _id = "BPX.20.9.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                }

                /// <summary>
                /// BPX.20.10 - A code that represents the type of name. Refer to HL7 Table 0200 - Name Type for valid values. See Section 2.A.89.7, "Name Type Code (ID)".As of v 2.7, XCN.10 is conditional. It is required if XCN.2 is populated.
                /// </summary>
                public class NameTypeCode : HL7Base<NameTypeCode>
                {

                    private const string _id = "BPX.20.10";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.20.11 - This component contains the digit, or digits, exclusive of the identifier in XCN.1, calculated by applying an algorithm to all or some of the digits in the number, which may be used to test validity of the non-check-digit identifier.
                /// </summary>
                public class IdentifierCheckDigit : HL7Base<IdentifierCheckDigit>
                {

                    private const string _id = "BPX.20.11";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.20.12 - Contains the code identifying the check digit scheme employed.Refer to HL7 Table 0061 - Check Digit Scheme for valid values.
                /// </summary>
                public class CheckDigitScheme : HL7Base<CheckDigitScheme>
                {

                    private const string _id = "BPX.20.12";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.20.13 - A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the assigning authority component. Refer to HL7 Table 0203 - Identifier Type for suggested values.As of v 2.7, XCN.13 is conditional. It is required if XCN.1 is populated.
                /// </summary>
                public class IdentifierTypeCode : HL7Base<IdentifierTypeCode>
                {

                    private const string _id = "BPX.20.13";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.20.14 - The place or location identifier where the identifier was first assigned to the person. This component is not an inherent part of the identifier but rather part of the history of the identifier as part of this data type, its existence is a convenience for certain intercommunicating systems.Note When the HD data type is used in a given segment as a component of a field of another data type, User-defined Table 0300 - Namespace ID (referenced by the first sub-component of the HD component) may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
                /// </summary>
                public class AssigningFacility : HL7Base<AssigningFacility>
                {

                    private const string _id = "BPX.20.14";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                    /// <summary>
                    /// BPX.20.14.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
                    /// </summary>
                    public class NamespaceId : HL7Base<NamespaceId>
                    {

                        private const string _id = "BPX.20.14.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.14.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
                    /// </summary>
                    public class UniversalId : HL7Base<UniversalId>
                    {

                        private const string _id = "BPX.20.14.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.14.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
                    /// </summary>
                    public class UniversalIdType : HL7Base<UniversalIdType>
                    {

                        private const string _id = "BPX.20.14.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                }

                /// <summary>
                /// BPX.20.15 - Different name/address types and representations of the same name/address should be described by repeating of this field, with different values of the name/address type and/or name/address representation component.Note This new component remains in alphabetic representation with each repetition of the field using these data types. I.e., even though the name may be represented in an ideographic character set, this component will remain represented in an alphabetic character set.Refer to HL7 Table 0465  Name/address Representation for valid values.In general this component provides an indication of the representation provided by the data item. It does not necessarily specify the character sets used. Thus, even though the representation might provide an indication of what to expect, the sender is still free to encode the contents using whatever character set is desired. This component provides only hints for the receiver, so it can make choices regarding what it has been sent and what it is capable of displaying.
                /// </summary>
                public class NameRepresentationCode : HL7Base<NameRepresentationCode>
                {

                    private const string _id = "BPX.20.15";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.20.16 - This component is used to designate the context in which a name is used. The main use case is in Australian healthcare for indigenous patients who prefer to use different names when attending different healthcare institutions. Another use case occurs in the US where health practitioners can be licensed under slightly different names and the reporting of the correct name is vital for administrative purposes. Refer to User-defined Table 0448  Name Context for suggested values.
                /// </summary>
                public class NameContext : HL7Base<NameContext>
                {

                    private const string _id = "BPX.20.16";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                    /// <summary>
                    /// BPX.20.16.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
                    /// </summary>
                    public class Identifier : HL7Base<Identifier>
                    {

                        private const string _id = "BPX.20.16.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.16.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
                    /// </summary>
                    public class Text : HL7Base<Text>
                    {

                        private const string _id = "BPX.20.16.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.16.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
                    /// </summary>
                    public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
                    {

                        private const string _id = "BPX.20.16.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.16.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
                    /// </summary>
                    public class AlternateIdentifier : HL7Base<AlternateIdentifier>
                    {

                        private const string _id = "BPX.20.16.4";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.16.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
                    /// </summary>
                    public class AlternateText : HL7Base<AlternateText>
                    {

                        private const string _id = "BPX.20.16.5";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.16.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
                    {

                        private const string _id = "BPX.20.16.6";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.16.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
                    /// </summary>
                    public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
                    {

                        private const string _id = "BPX.20.16.7";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.16.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
                    {

                        private const string _id = "BPX.20.16.8";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.16.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
                    /// </summary>
                    public class OriginalText : HL7Base<OriginalText>
                    {

                        private const string _id = "BPX.20.16.9";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.16.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
                    /// </summary>
                    public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
                    {

                        private const string _id = "BPX.20.16.10";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.16.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
                    /// </summary>
                    public class SecondAlternateText : HL7Base<SecondAlternateText>
                    {

                        private const string _id = "BPX.20.16.11";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.16.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
                    {

                        private const string _id = "BPX.20.16.12";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.16.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
                    {

                        private const string _id = "BPX.20.16.13";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.16.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
                    /// </summary>
                    public class CodingSystemOid : HL7Base<CodingSystemOid>
                    {

                        private const string _id = "BPX.20.16.14";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.16.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class ValueSetOid : HL7Base<ValueSetOid>
                    {

                        private const string _id = "BPX.20.16.15";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.16.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
                    /// </summary>
                    public class ValueSetVersionId : HL7Base<ValueSetVersionId>
                    {

                        private const string _id = "BPX.20.16.16";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.16.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
                    /// </summary>
                    public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
                    {

                        private const string _id = "BPX.20.16.17";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.16.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
                    {

                        private const string _id = "BPX.20.16.18";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.16.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
                    /// </summary>
                    public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
                    {

                        private const string _id = "BPX.20.16.19";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.16.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
                    /// </summary>
                    public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
                    {

                        private const string _id = "BPX.20.16.20";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.16.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
                    {

                        private const string _id = "BPX.20.16.21";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.16.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
                    /// </summary>
                    public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
                    {

                        private const string _id = "BPX.20.16.22";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                }

                /// <summary>
                /// BPX.20.17 - Attention The XCN.17 component was deprecated as of v2.5 and the detail was withdrawn and removed from the standard as of v 2.7. Refer to XCN.19 Effective Date and XCN.20 Expiration Date instead.This component contains the start and end date/times that define the period during which this name was valid.
                /// </summary>
                public class NameValidityRange : HL7Base<NameValidityRange>
                {

                    private const string _id = "BPX.20.17";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.20.18 - A code that represents the preferred display order of the components of this person name. Refer to HL7 Table 0444 - Name Assembly Order for valid values.
                /// </summary>
                public class NameAssemblyOrder : HL7Base<NameAssemblyOrder>
                {

                    private const string _id = "BPX.20.18";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.20.19 - The first date, if known, on which the person name is valid and active.
                /// </summary>
                public class EffectiveDate : HL7Base<EffectiveDate>
                {

                    private const string _id = "BPX.20.19";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.20.20 - The last date, if known, on which the person name is valid and active.
                /// </summary>
                public class ExpirationDate : HL7Base<ExpirationDate>
                {

                    private const string _id = "BPX.20.20";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.20.21 - Used to specify an abbreviation, or a string of abbreviations denoting qualifications that support the persons profession, (e.g., licenses, certificates, degrees, affiliations with professional societies, etc.). The Professional Suffix normally follows the Family Name when the Person Name is used for display purposes. Please note that this component is an unformatted string and is used for display purposes only. Detailed information regarding the contents of Professional Suffix is obtained using appropriate segments in Chapter 15, "Personnel Management".
                /// </summary>
                public class ProfessionalSuffix : HL7Base<ProfessionalSuffix>
                {

                    private const string _id = "BPX.20.21";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.20.22 - The geo-political body that assigned the identifier in XCN.1. As of v 2.7, the Assigning Jurisdiction is conditional. It is required if XCN.1 is populated and neither XCN.9 nor XCN.23 are populated. All 3 components may be populated. The reader is referred to XCN.9 if there is a need to transmit this information as an OID.
                /// </summary>
                public class AssigningJurisdiction : HL7Base<AssigningJurisdiction>
                {

                    private const string _id = "BPX.20.22";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                    /// <summary>
                    /// BPX.20.22.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
                    /// </summary>
                    public class Identifier : HL7Base<Identifier>
                    {

                        private const string _id = "BPX.20.22.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.22.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
                    /// </summary>
                    public class Text : HL7Base<Text>
                    {

                        private const string _id = "BPX.20.22.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.22.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
                    /// </summary>
                    public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
                    {

                        private const string _id = "BPX.20.22.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.22.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
                    /// </summary>
                    public class AlternateIdentifier : HL7Base<AlternateIdentifier>
                    {

                        private const string _id = "BPX.20.22.4";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.22.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
                    /// </summary>
                    public class AlternateText : HL7Base<AlternateText>
                    {

                        private const string _id = "BPX.20.22.5";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.22.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
                    {

                        private const string _id = "BPX.20.22.6";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.22.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
                    /// </summary>
                    public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
                    {

                        private const string _id = "BPX.20.22.7";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.22.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
                    {

                        private const string _id = "BPX.20.22.8";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.22.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
                    /// </summary>
                    public class OriginalText : HL7Base<OriginalText>
                    {

                        private const string _id = "BPX.20.22.9";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.22.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
                    /// </summary>
                    public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
                    {

                        private const string _id = "BPX.20.22.10";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.22.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
                    /// </summary>
                    public class SecondAlternateText : HL7Base<SecondAlternateText>
                    {

                        private const string _id = "BPX.20.22.11";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.22.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
                    {

                        private const string _id = "BPX.20.22.12";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.22.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
                    {

                        private const string _id = "BPX.20.22.13";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.22.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
                    /// </summary>
                    public class CodingSystemOid : HL7Base<CodingSystemOid>
                    {

                        private const string _id = "BPX.20.22.14";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.22.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class ValueSetOid : HL7Base<ValueSetOid>
                    {

                        private const string _id = "BPX.20.22.15";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.22.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
                    /// </summary>
                    public class ValueSetVersionId : HL7Base<ValueSetVersionId>
                    {

                        private const string _id = "BPX.20.22.16";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.22.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
                    /// </summary>
                    public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
                    {

                        private const string _id = "BPX.20.22.17";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.22.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
                    {

                        private const string _id = "BPX.20.22.18";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.22.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
                    /// </summary>
                    public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
                    {

                        private const string _id = "BPX.20.22.19";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.22.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
                    /// </summary>
                    public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
                    {

                        private const string _id = "BPX.20.22.20";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.22.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
                    {

                        private const string _id = "BPX.20.22.21";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.22.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
                    /// </summary>
                    public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
                    {

                        private const string _id = "BPX.20.22.22";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                }

                /// <summary>
                /// BPX.20.23 - The agency or department that assigned the identifier in XCN.1.As of v 2.7, the Assigning Jurisdiction is conditional. It is required if XCN.1 is populated and neither XCN.9 nor XCN.22 are populated. All 3 components may be populated. The reader is referred to XCN.9 if there is a need to transmit this information as an OID.
                /// </summary>
                public class AssigningAgencyOrDepartment : HL7Base<AssigningAgencyOrDepartment>
                {

                    private const string _id = "BPX.20.23";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                    /// <summary>
                    /// BPX.20.23.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
                    /// </summary>
                    public class Identifier : HL7Base<Identifier>
                    {

                        private const string _id = "BPX.20.23.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.23.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
                    /// </summary>
                    public class Text : HL7Base<Text>
                    {

                        private const string _id = "BPX.20.23.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.23.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
                    /// </summary>
                    public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
                    {

                        private const string _id = "BPX.20.23.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.23.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
                    /// </summary>
                    public class AlternateIdentifier : HL7Base<AlternateIdentifier>
                    {

                        private const string _id = "BPX.20.23.4";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.23.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
                    /// </summary>
                    public class AlternateText : HL7Base<AlternateText>
                    {

                        private const string _id = "BPX.20.23.5";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.23.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
                    {

                        private const string _id = "BPX.20.23.6";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.23.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
                    /// </summary>
                    public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
                    {

                        private const string _id = "BPX.20.23.7";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.23.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
                    {

                        private const string _id = "BPX.20.23.8";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.23.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
                    /// </summary>
                    public class OriginalText : HL7Base<OriginalText>
                    {

                        private const string _id = "BPX.20.23.9";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.23.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
                    /// </summary>
                    public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
                    {

                        private const string _id = "BPX.20.23.10";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.23.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
                    /// </summary>
                    public class SecondAlternateText : HL7Base<SecondAlternateText>
                    {

                        private const string _id = "BPX.20.23.11";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.23.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
                    {

                        private const string _id = "BPX.20.23.12";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.23.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
                    {

                        private const string _id = "BPX.20.23.13";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.23.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
                    /// </summary>
                    public class CodingSystemOid : HL7Base<CodingSystemOid>
                    {

                        private const string _id = "BPX.20.23.14";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.23.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class ValueSetOid : HL7Base<ValueSetOid>
                    {

                        private const string _id = "BPX.20.23.15";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.23.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
                    /// </summary>
                    public class ValueSetVersionId : HL7Base<ValueSetVersionId>
                    {

                        private const string _id = "BPX.20.23.16";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.23.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
                    /// </summary>
                    public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
                    {

                        private const string _id = "BPX.20.23.17";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.23.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
                    {

                        private const string _id = "BPX.20.23.18";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.23.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
                    /// </summary>
                    public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
                    {

                        private const string _id = "BPX.20.23.19";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.23.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
                    /// </summary>
                    public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
                    {

                        private const string _id = "BPX.20.23.20";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.23.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
                    {

                        private const string _id = "BPX.20.23.21";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.20.23.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
                    /// </summary>
                    public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
                    {

                        private const string _id = "BPX.20.23.22";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                }

                /// <summary>
                /// BPX.20.24 - This component is used to communicate a version code that may be assigned to the value given in XCN.1 Person Identifier.
                /// </summary>
                public class SecurityCheck : HL7Base<SecurityCheck>
                {

                    private const string _id = "BPX.20.24";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.20.25 - This component is used to transmit information intended to validate the veracity of the supplied identifier or the presenter of the identifier. For example, this component may be used to ensure that the presenter of a credit card is an authorized user of that card.Refer to HL7 Table 0904 - Security Check Scheme for valid values
                /// </summary>
                public class SecurityCheckScheme : HL7Base<SecurityCheckScheme>
                {

                    private const string _id = "BPX.20.25";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

            }

            /// <summary>
            /// BPX.21 - This field identifies the individual who is dispensing the blood component or commercial product.
            /// </summary>
            public class BpDispensingIndividual : HL7Base<BpDispensingIndividual>
            {

                private const string _id = "BPX.21";
                public override string Id
                {
                    get { return _id; }
                }

                private readonly bool[] _repeatableHierarchy = { false, true };
                public override bool[] RepeatableHierarchy
                {
                    get { return _repeatableHierarchy; }
                }

                /// <summary>
                /// BPX.21.1 - This component carries the Person Identifier itself. XCN.1, in conjunction with XCN.9 uniquely identifies the entity/person. XCN.1 is required if XCN.2 is not populated. Both may be populated. 
                /// </summary>
                public class PersonIdentifier : HL7Base<PersonIdentifier>
                {

                    private const string _id = "BPX.21.1";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.21.2 - This component allows full specification of the surname of a person. Where appropriate, it differentiates the person's own surname from that of the person's partner or spouse, in cases where the person's name may contain elements from either name. It also permits messages to distinguish the surname prefix (such as "van" or "de") from the surname root. See section 2.A.30, "FN - family name".XCN.2 is required if XCN.1 is not populated. Both may be populated.
                /// </summary>
                public class FamilyName : HL7Base<FamilyName>
                {

                    private const string _id = "BPX.21.2";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                    /// <summary>
                    /// BPX.21.2.1 - The atomic element of the person's family name. In most Western usage, this is the person's last name.
                    /// </summary>
                    public class Surname : HL7Base<Surname>
                    {

                        private const string _id = "BPX.21.2.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.2.2 - Internationalization usage for Germanic languages. This component is optional. An example of a surname prefix is the "van" in "Ludwig van Beethoven". Since the surname prefix doesn't sort completely alphabetically, it is reasonable to specify it as a separate sub-component of the PN and extended PN data types (XPN and XCN).Note Subcomponents own surname prefix, own surname, surname prefix from partner/spouse and surname from partner/spouse decompose complex Germanic names such as Martha de Mum-van Beethoven. If these subcomponents are valued, the surname subcomponent should still be fully valued for backward compatibility, i.e., de Mum-van Beethoven&de&Mum&van&Beethoven.Also, for clarity, the last name prefix has been renamed to own surname prefix.
                    /// </summary>
                    public class OwnSurnamePrefix : HL7Base<OwnSurnamePrefix>
                    {

                        private const string _id = "BPX.21.2.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.2.3 - The portion of the surname (in most Western usage, the last name) that is derived from the person's own surname, as distinguished from any portion that is derived from the surname of the person's partner or spouse. This component is optional.If the person's surname has legally changed to become (or incorporate) the surname of the person's partner or spouse, this is the person's surname immediately prior to such change. Often this is the person's "maiden name".
                    /// </summary>
                    public class OwnSurname : HL7Base<OwnSurname>
                    {

                        private const string _id = "BPX.21.2.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.2.4 - Internationalization usage for Germanic languages. This component is optional. An example of a surname prefix is the van in "Ludwig van Beethoven". Since the surname prefix doesn't sort completely alphabetically, it is reasonable to specify it as a separate sub-component of the PN and extended PN data types (XPN and XCN). Note Subcomponents own surname prefix, own surname, surname prefix from partner/spouse and surname from partner/spouse decompose complex Germanic names such as Martha de Mum-van Beethoven. If these subcomponents are valued, the surname subcomponent should still be fully valued for backward compatibility, i.e., de Mum-van Beethoven&de&Mum&van&Beethoven.Also, for clarity, the last name prefix has been renamed to own surname prefix.
                    /// </summary>
                    public class SurnamePrefixFromPartnerSpouse : HL7Base<SurnamePrefixFromPartnerSpouse>
                    {

                        private const string _id = "BPX.21.2.4";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.2.5 - The portion of the person's surname (in most Western usage, the last name) that is derived from the surname of the person's partner or spouse, as distinguished from the part derived from the person's own surname. This component is optional.If no portion of the person's surname is derived from the surname of the person's partner or spouse, this component is not valued. Otherwise, if the surname of the partner or spouse has legally changed to become (or incorporate) the person's surname, this is the surname of the partner or spouse immediately prior to such change.
                    /// </summary>
                    public class SurnameFromPartnerSpouse : HL7Base<SurnameFromPartnerSpouse>
                    {

                        private const string _id = "BPX.21.2.5";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                }

                /// <summary>
                /// BPX.21.3 - First name.
                /// </summary>
                public class GivenName : HL7Base<GivenName>
                {

                    private const string _id = "BPX.21.3";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.21.4 - Multiple middle names may be included by separating them with spaces.
                /// </summary>
                public class SecondAndFurtherGivenNamesOrInitialsThereof : HL7Base<SecondAndFurtherGivenNamesOrInitialsThereof>
                {

                    private const string _id = "BPX.21.4";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.21.5 - Used to specify a name suffix (e.g., Jr. or III).
                /// </summary>
                public class SuffixegJrOrIii : HL7Base<SuffixegJrOrIii>
                {

                    private const string _id = "BPX.21.5";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.21.6 - Used to specify a name prefix (e.g., Dr.).
                /// </summary>
                public class PrefixegDr : HL7Base<PrefixegDr>
                {

                    private const string _id = "BPX.21.6";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.21.7 - Attention The XCN-7 component was deprecated as of v2.5 and the detail was withdrawn and removed from the standard as of v27.. Refer to XCN.21 Professional Suffix.
                /// </summary>
                public class DegreeegMd : HL7Base<DegreeegMd>
                {

                    private const string _id = "BPX.21.7";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.21.8 - Attention Retained for backwards compatibility only as of v 2.7. The reader is referred to XCN.9 instead.User-defined Table 0297  CN ID source is used as the HL7 identifier for the user-defined table of values for this component. Used to delineate the first component.
                /// </summary>
                public class SourceTable : HL7Base<SourceTable>
                {

                    private const string _id = "BPX.21.8";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                    /// <summary>
                    /// BPX.21.8.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
                    /// </summary>
                    public class Identifier : HL7Base<Identifier>
                    {

                        private const string _id = "BPX.21.8.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.8.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
                    /// </summary>
                    public class Text : HL7Base<Text>
                    {

                        private const string _id = "BPX.21.8.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.8.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
                    /// </summary>
                    public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
                    {

                        private const string _id = "BPX.21.8.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.8.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
                    /// </summary>
                    public class AlternateIdentifier : HL7Base<AlternateIdentifier>
                    {

                        private const string _id = "BPX.21.8.4";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.8.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
                    /// </summary>
                    public class AlternateText : HL7Base<AlternateText>
                    {

                        private const string _id = "BPX.21.8.5";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.8.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
                    {

                        private const string _id = "BPX.21.8.6";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.8.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
                    /// </summary>
                    public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
                    {

                        private const string _id = "BPX.21.8.7";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.8.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
                    {

                        private const string _id = "BPX.21.8.8";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.8.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
                    /// </summary>
                    public class OriginalText : HL7Base<OriginalText>
                    {

                        private const string _id = "BPX.21.8.9";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.8.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
                    /// </summary>
                    public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
                    {

                        private const string _id = "BPX.21.8.10";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.8.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
                    /// </summary>
                    public class SecondAlternateText : HL7Base<SecondAlternateText>
                    {

                        private const string _id = "BPX.21.8.11";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.8.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
                    {

                        private const string _id = "BPX.21.8.12";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.8.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
                    {

                        private const string _id = "BPX.21.8.13";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.8.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
                    /// </summary>
                    public class CodingSystemOid : HL7Base<CodingSystemOid>
                    {

                        private const string _id = "BPX.21.8.14";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.8.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class ValueSetOid : HL7Base<ValueSetOid>
                    {

                        private const string _id = "BPX.21.8.15";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.8.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
                    /// </summary>
                    public class ValueSetVersionId : HL7Base<ValueSetVersionId>
                    {

                        private const string _id = "BPX.21.8.16";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.8.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
                    /// </summary>
                    public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
                    {

                        private const string _id = "BPX.21.8.17";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.8.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
                    {

                        private const string _id = "BPX.21.8.18";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.8.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
                    /// </summary>
                    public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
                    {

                        private const string _id = "BPX.21.8.19";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.8.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
                    /// </summary>
                    public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
                    {

                        private const string _id = "BPX.21.8.20";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.8.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
                    {

                        private const string _id = "BPX.21.8.21";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.8.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
                    /// </summary>
                    public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
                    {

                        private const string _id = "BPX.21.8.22";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                }

                /// <summary>
                /// BPX.21.9 - The assigning authority is a unique identifier of the system (or organization or agency of department) that creates the data. User-defined Table 0363  Assigning Authority is used as the HL7 identifier for the user-defined table of values for the first sub-component of the HD component, namespace ID.As of v 2.7, the Assigning Authority is conditional. It is required if XCN.1 is populated and neither XCN.22 nor XCN.23 are populated. All 3 components may be populated. No assumptions can be safely made based on position or sequence. Best practice is to send an OID in this component when populated.The reader is referred to XCN.22 and XCN.23 if there is a need to transmit values with semantic meaning for an assigning jurisdiction or assigning department or agency in addition to, or instead of, an assigning authority. However, all 3 components may be valued.  If, in so doing, it is discovered that the values in XCN.22 and/or XCN.23 conflict with XCN.9, the user would look to the Message Profile or other implementation agreement for a statement as to which takes precedence.Note When the HD data type is used in a given segment as a component of a field of another data type, User-defined Table 0300 - Namespace ID (referenced by the first sub-component of the HD component) may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.By site agreement, implementors may continue to use User-defined Table 0300  Namespace ID for the first sub-component.
                /// </summary>
                public class AssigningAuthority : HL7Base<AssigningAuthority>
                {

                    private const string _id = "BPX.21.9";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                    /// <summary>
                    /// BPX.21.9.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
                    /// </summary>
                    public class NamespaceId : HL7Base<NamespaceId>
                    {

                        private const string _id = "BPX.21.9.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.9.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
                    /// </summary>
                    public class UniversalId : HL7Base<UniversalId>
                    {

                        private const string _id = "BPX.21.9.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.9.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
                    /// </summary>
                    public class UniversalIdType : HL7Base<UniversalIdType>
                    {

                        private const string _id = "BPX.21.9.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                }

                /// <summary>
                /// BPX.21.10 - A code that represents the type of name. Refer to HL7 Table 0200 - Name Type for valid values. See Section 2.A.89.7, "Name Type Code (ID)".As of v 2.7, XCN.10 is conditional. It is required if XCN.2 is populated.
                /// </summary>
                public class NameTypeCode : HL7Base<NameTypeCode>
                {

                    private const string _id = "BPX.21.10";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.21.11 - This component contains the digit, or digits, exclusive of the identifier in XCN.1, calculated by applying an algorithm to all or some of the digits in the number, which may be used to test validity of the non-check-digit identifier.
                /// </summary>
                public class IdentifierCheckDigit : HL7Base<IdentifierCheckDigit>
                {

                    private const string _id = "BPX.21.11";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.21.12 - Contains the code identifying the check digit scheme employed.Refer to HL7 Table 0061 - Check Digit Scheme for valid values.
                /// </summary>
                public class CheckDigitScheme : HL7Base<CheckDigitScheme>
                {

                    private const string _id = "BPX.21.12";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.21.13 - A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the assigning authority component. Refer to HL7 Table 0203 - Identifier Type for suggested values.As of v 2.7, XCN.13 is conditional. It is required if XCN.1 is populated.
                /// </summary>
                public class IdentifierTypeCode : HL7Base<IdentifierTypeCode>
                {

                    private const string _id = "BPX.21.13";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.21.14 - The place or location identifier where the identifier was first assigned to the person. This component is not an inherent part of the identifier but rather part of the history of the identifier as part of this data type, its existence is a convenience for certain intercommunicating systems.Note When the HD data type is used in a given segment as a component of a field of another data type, User-defined Table 0300 - Namespace ID (referenced by the first sub-component of the HD component) may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
                /// </summary>
                public class AssigningFacility : HL7Base<AssigningFacility>
                {

                    private const string _id = "BPX.21.14";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                    /// <summary>
                    /// BPX.21.14.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
                    /// </summary>
                    public class NamespaceId : HL7Base<NamespaceId>
                    {

                        private const string _id = "BPX.21.14.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.14.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
                    /// </summary>
                    public class UniversalId : HL7Base<UniversalId>
                    {

                        private const string _id = "BPX.21.14.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.14.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
                    /// </summary>
                    public class UniversalIdType : HL7Base<UniversalIdType>
                    {

                        private const string _id = "BPX.21.14.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                }

                /// <summary>
                /// BPX.21.15 - Different name/address types and representations of the same name/address should be described by repeating of this field, with different values of the name/address type and/or name/address representation component.Note This new component remains in alphabetic representation with each repetition of the field using these data types. I.e., even though the name may be represented in an ideographic character set, this component will remain represented in an alphabetic character set.Refer to HL7 Table 0465  Name/address Representation for valid values.In general this component provides an indication of the representation provided by the data item. It does not necessarily specify the character sets used. Thus, even though the representation might provide an indication of what to expect, the sender is still free to encode the contents using whatever character set is desired. This component provides only hints for the receiver, so it can make choices regarding what it has been sent and what it is capable of displaying.
                /// </summary>
                public class NameRepresentationCode : HL7Base<NameRepresentationCode>
                {

                    private const string _id = "BPX.21.15";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.21.16 - This component is used to designate the context in which a name is used. The main use case is in Australian healthcare for indigenous patients who prefer to use different names when attending different healthcare institutions. Another use case occurs in the US where health practitioners can be licensed under slightly different names and the reporting of the correct name is vital for administrative purposes. Refer to User-defined Table 0448  Name Context for suggested values.
                /// </summary>
                public class NameContext : HL7Base<NameContext>
                {

                    private const string _id = "BPX.21.16";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                    /// <summary>
                    /// BPX.21.16.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
                    /// </summary>
                    public class Identifier : HL7Base<Identifier>
                    {

                        private const string _id = "BPX.21.16.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.16.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
                    /// </summary>
                    public class Text : HL7Base<Text>
                    {

                        private const string _id = "BPX.21.16.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.16.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
                    /// </summary>
                    public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
                    {

                        private const string _id = "BPX.21.16.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.16.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
                    /// </summary>
                    public class AlternateIdentifier : HL7Base<AlternateIdentifier>
                    {

                        private const string _id = "BPX.21.16.4";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.16.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
                    /// </summary>
                    public class AlternateText : HL7Base<AlternateText>
                    {

                        private const string _id = "BPX.21.16.5";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.16.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
                    {

                        private const string _id = "BPX.21.16.6";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.16.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
                    /// </summary>
                    public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
                    {

                        private const string _id = "BPX.21.16.7";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.16.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
                    {

                        private const string _id = "BPX.21.16.8";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.16.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
                    /// </summary>
                    public class OriginalText : HL7Base<OriginalText>
                    {

                        private const string _id = "BPX.21.16.9";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.16.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
                    /// </summary>
                    public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
                    {

                        private const string _id = "BPX.21.16.10";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.16.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
                    /// </summary>
                    public class SecondAlternateText : HL7Base<SecondAlternateText>
                    {

                        private const string _id = "BPX.21.16.11";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.16.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
                    {

                        private const string _id = "BPX.21.16.12";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.16.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
                    {

                        private const string _id = "BPX.21.16.13";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.16.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
                    /// </summary>
                    public class CodingSystemOid : HL7Base<CodingSystemOid>
                    {

                        private const string _id = "BPX.21.16.14";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.16.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class ValueSetOid : HL7Base<ValueSetOid>
                    {

                        private const string _id = "BPX.21.16.15";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.16.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
                    /// </summary>
                    public class ValueSetVersionId : HL7Base<ValueSetVersionId>
                    {

                        private const string _id = "BPX.21.16.16";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.16.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
                    /// </summary>
                    public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
                    {

                        private const string _id = "BPX.21.16.17";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.16.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
                    {

                        private const string _id = "BPX.21.16.18";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.16.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
                    /// </summary>
                    public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
                    {

                        private const string _id = "BPX.21.16.19";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.16.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
                    /// </summary>
                    public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
                    {

                        private const string _id = "BPX.21.16.20";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.16.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
                    {

                        private const string _id = "BPX.21.16.21";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.16.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
                    /// </summary>
                    public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
                    {

                        private const string _id = "BPX.21.16.22";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                }

                /// <summary>
                /// BPX.21.17 - Attention The XCN.17 component was deprecated as of v2.5 and the detail was withdrawn and removed from the standard as of v 2.7. Refer to XCN.19 Effective Date and XCN.20 Expiration Date instead.This component contains the start and end date/times that define the period during which this name was valid.
                /// </summary>
                public class NameValidityRange : HL7Base<NameValidityRange>
                {

                    private const string _id = "BPX.21.17";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.21.18 - A code that represents the preferred display order of the components of this person name. Refer to HL7 Table 0444 - Name Assembly Order for valid values.
                /// </summary>
                public class NameAssemblyOrder : HL7Base<NameAssemblyOrder>
                {

                    private const string _id = "BPX.21.18";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.21.19 - The first date, if known, on which the person name is valid and active.
                /// </summary>
                public class EffectiveDate : HL7Base<EffectiveDate>
                {

                    private const string _id = "BPX.21.19";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.21.20 - The last date, if known, on which the person name is valid and active.
                /// </summary>
                public class ExpirationDate : HL7Base<ExpirationDate>
                {

                    private const string _id = "BPX.21.20";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.21.21 - Used to specify an abbreviation, or a string of abbreviations denoting qualifications that support the persons profession, (e.g., licenses, certificates, degrees, affiliations with professional societies, etc.). The Professional Suffix normally follows the Family Name when the Person Name is used for display purposes. Please note that this component is an unformatted string and is used for display purposes only. Detailed information regarding the contents of Professional Suffix is obtained using appropriate segments in Chapter 15, "Personnel Management".
                /// </summary>
                public class ProfessionalSuffix : HL7Base<ProfessionalSuffix>
                {

                    private const string _id = "BPX.21.21";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.21.22 - The geo-political body that assigned the identifier in XCN.1. As of v 2.7, the Assigning Jurisdiction is conditional. It is required if XCN.1 is populated and neither XCN.9 nor XCN.23 are populated. All 3 components may be populated. The reader is referred to XCN.9 if there is a need to transmit this information as an OID.
                /// </summary>
                public class AssigningJurisdiction : HL7Base<AssigningJurisdiction>
                {

                    private const string _id = "BPX.21.22";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                    /// <summary>
                    /// BPX.21.22.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
                    /// </summary>
                    public class Identifier : HL7Base<Identifier>
                    {

                        private const string _id = "BPX.21.22.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.22.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
                    /// </summary>
                    public class Text : HL7Base<Text>
                    {

                        private const string _id = "BPX.21.22.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.22.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
                    /// </summary>
                    public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
                    {

                        private const string _id = "BPX.21.22.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.22.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
                    /// </summary>
                    public class AlternateIdentifier : HL7Base<AlternateIdentifier>
                    {

                        private const string _id = "BPX.21.22.4";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.22.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
                    /// </summary>
                    public class AlternateText : HL7Base<AlternateText>
                    {

                        private const string _id = "BPX.21.22.5";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.22.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
                    {

                        private const string _id = "BPX.21.22.6";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.22.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
                    /// </summary>
                    public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
                    {

                        private const string _id = "BPX.21.22.7";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.22.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
                    {

                        private const string _id = "BPX.21.22.8";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.22.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
                    /// </summary>
                    public class OriginalText : HL7Base<OriginalText>
                    {

                        private const string _id = "BPX.21.22.9";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.22.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
                    /// </summary>
                    public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
                    {

                        private const string _id = "BPX.21.22.10";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.22.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
                    /// </summary>
                    public class SecondAlternateText : HL7Base<SecondAlternateText>
                    {

                        private const string _id = "BPX.21.22.11";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.22.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
                    {

                        private const string _id = "BPX.21.22.12";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.22.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
                    {

                        private const string _id = "BPX.21.22.13";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.22.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
                    /// </summary>
                    public class CodingSystemOid : HL7Base<CodingSystemOid>
                    {

                        private const string _id = "BPX.21.22.14";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.22.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class ValueSetOid : HL7Base<ValueSetOid>
                    {

                        private const string _id = "BPX.21.22.15";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.22.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
                    /// </summary>
                    public class ValueSetVersionId : HL7Base<ValueSetVersionId>
                    {

                        private const string _id = "BPX.21.22.16";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.22.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
                    /// </summary>
                    public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
                    {

                        private const string _id = "BPX.21.22.17";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.22.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
                    {

                        private const string _id = "BPX.21.22.18";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.22.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
                    /// </summary>
                    public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
                    {

                        private const string _id = "BPX.21.22.19";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.22.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
                    /// </summary>
                    public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
                    {

                        private const string _id = "BPX.21.22.20";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.22.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
                    {

                        private const string _id = "BPX.21.22.21";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.22.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
                    /// </summary>
                    public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
                    {

                        private const string _id = "BPX.21.22.22";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                }

                /// <summary>
                /// BPX.21.23 - The agency or department that assigned the identifier in XCN.1.As of v 2.7, the Assigning Jurisdiction is conditional. It is required if XCN.1 is populated and neither XCN.9 nor XCN.22 are populated. All 3 components may be populated. The reader is referred to XCN.9 if there is a need to transmit this information as an OID.
                /// </summary>
                public class AssigningAgencyOrDepartment : HL7Base<AssigningAgencyOrDepartment>
                {

                    private const string _id = "BPX.21.23";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                    /// <summary>
                    /// BPX.21.23.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
                    /// </summary>
                    public class Identifier : HL7Base<Identifier>
                    {

                        private const string _id = "BPX.21.23.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.23.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
                    /// </summary>
                    public class Text : HL7Base<Text>
                    {

                        private const string _id = "BPX.21.23.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.23.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
                    /// </summary>
                    public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
                    {

                        private const string _id = "BPX.21.23.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.23.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
                    /// </summary>
                    public class AlternateIdentifier : HL7Base<AlternateIdentifier>
                    {

                        private const string _id = "BPX.21.23.4";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.23.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
                    /// </summary>
                    public class AlternateText : HL7Base<AlternateText>
                    {

                        private const string _id = "BPX.21.23.5";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.23.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
                    {

                        private const string _id = "BPX.21.23.6";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.23.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
                    /// </summary>
                    public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
                    {

                        private const string _id = "BPX.21.23.7";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.23.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
                    {

                        private const string _id = "BPX.21.23.8";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.23.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
                    /// </summary>
                    public class OriginalText : HL7Base<OriginalText>
                    {

                        private const string _id = "BPX.21.23.9";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.23.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
                    /// </summary>
                    public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
                    {

                        private const string _id = "BPX.21.23.10";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.23.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
                    /// </summary>
                    public class SecondAlternateText : HL7Base<SecondAlternateText>
                    {

                        private const string _id = "BPX.21.23.11";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.23.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
                    {

                        private const string _id = "BPX.21.23.12";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.23.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
                    {

                        private const string _id = "BPX.21.23.13";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.23.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
                    /// </summary>
                    public class CodingSystemOid : HL7Base<CodingSystemOid>
                    {

                        private const string _id = "BPX.21.23.14";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.23.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class ValueSetOid : HL7Base<ValueSetOid>
                    {

                        private const string _id = "BPX.21.23.15";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.23.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
                    /// </summary>
                    public class ValueSetVersionId : HL7Base<ValueSetVersionId>
                    {

                        private const string _id = "BPX.21.23.16";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.23.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
                    /// </summary>
                    public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
                    {

                        private const string _id = "BPX.21.23.17";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.23.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
                    {

                        private const string _id = "BPX.21.23.18";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.23.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
                    /// </summary>
                    public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
                    {

                        private const string _id = "BPX.21.23.19";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.23.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
                    /// </summary>
                    public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
                    {

                        private const string _id = "BPX.21.23.20";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.23.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
                    {

                        private const string _id = "BPX.21.23.21";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BPX.21.23.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
                    /// </summary>
                    public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
                    {

                        private const string _id = "BPX.21.23.22";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                }

                /// <summary>
                /// BPX.21.24 - This component is used to communicate a version code that may be assigned to the value given in XCN.1 Person Identifier.
                /// </summary>
                public class SecurityCheck : HL7Base<SecurityCheck>
                {

                    private const string _id = "BPX.21.24";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BPX.21.25 - This component is used to transmit information intended to validate the veracity of the supplied identifier or the presenter of the identifier. For example, this component may be used to ensure that the presenter of a credit card is an authorized user of that card.Refer to HL7 Table 0904 - Security Check Scheme for valid values
                /// </summary>
                public class SecurityCheckScheme : HL7Base<SecurityCheckScheme>
                {

                    private const string _id = "BPX.21.25";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

            }

        }
    }
}

