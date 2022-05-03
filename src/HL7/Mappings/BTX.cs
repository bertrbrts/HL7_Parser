using Newtonsoft.Json;
namespace HL7Parser
{
    public partial class Mappings
    {
        /// <summary>
        /// The BP prefix in the element name indicates that the attribute pertains to any type of blood product. A blood product is defined as any type of blood component or commercially prepared blood product that is prepared and dispensed from the transfusion service.The BC prefix in the element name indicates that the attribute pertains only to blood components. A blood component is defined as any part or all of a whole blood donation. For example, from one whole blood donation, the unit of whole blood can be fractionated into red blood cells, plasma and platelets with each component contained in separate bags. These types of blood products are always assigned a unique donation identification number as well as a product code that indicates the type of component contained in the bag.The CP prefix in the element name indicates that the attribute pertains only to Commercial Products. A commercial product is defined as a commercially manufactured product, such as blood derivatives (Rh Immune Globulin, Factor VIII Concentrate or Blood Recipient Sets or Filters). These types of products are tracked by manufacturer and lot number and are not necessarily assigned a unique donation number.
        /// </summary>
        public class BTX
        {

            public const string Id = "BTX";

            /// <summary>
            /// BTX.1 - This field contains the sequence number for the BTX segment under the related BPO segment.  For the first product transfusion/disposition transmitted, the sequence number shall be 1 for the second product transfusion/disposition, it shall be 2 and so on.
            /// </summary>
            public class SetIdBtx : HL7Base<SetIdBtx>
            {

                private const string _id = "BTX.1";
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
            /// BTX.2 - The donation ID is the unique identification number assigned to a blood donation. The Donation ID depends upon the bar code labeling system used for the component.  There are currently two blood component labeling standards ABC CODABAR and ISBT 128.  The preferred labeling system is ISBT 128.  If using ISBT 128, the Donation ID is an internationally unique identifier consisting of the following 13 charactersCountry Code & Collection Facility - 5 charactersDonation Year - 2 charactersSerial Number - 6 charactersThis is required for blood components and is not applicable for commercial product messages.
            /// </summary>
            public class BcDonationId : HL7Base<BcDonationId>
            {

                private const string _id = "BTX.2";
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
                /// BTX.2.1 - The first component, entity identifier, is usually defined to be unique within the series of identifiers created by the assigning authority, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, "HD - hierarchic designator".
                /// </summary>
                public class EntityIdentifier : HL7Base<EntityIdentifier>
                {

                    private const string _id = "BTX.2.1";
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
                /// BTX.2.2 - See Section 2.A.33.1, "Namespace ID (IS)" for definition. The component intentionally remains associated with the IS data type in v 2.7.The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363  Assigning Authority for suggested values.Note When the HD is used as a part of another data type, in this case as part of the EI data type, this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment. By site agreement, implementers may continue to use User-defined Table 0300  Namespace ID for the first component
                /// </summary>
                public class NamespaceId : HL7Base<NamespaceId>
                {

                    private const string _id = "BTX.2.2";
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
                /// BTX.2.3 - See Section 2.A.33.2, "Universal ID (ST)" for definition.
                /// </summary>
                public class UniversalId : HL7Base<UniversalId>
                {

                    private const string _id = "BTX.2.3";
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
                /// BTX.2.4 - Refer to HL7 Table 0301 - Universal ID Type for valid values. See Section 2.A.33.3, "Universal ID Type (ID)," for definition.
                /// </summary>
                public class UniversalIdType : HL7Base<UniversalIdType>
                {

                    private const string _id = "BTX.2.4";
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
            /// BTX.3 - The Blood Component field includes an identifier and description of the specific blood component.The identifier consists of a numeric or alphanumeric product code that represents the type of blood component. The coding system will be determined by the bar code labeling system on the particular component of blood.  The preferred coding system is ISBT 128.If using ISBT 128 labeling standard, the product code will consist of an 8-character alphanumeric code, starting with an alpha character and including the component class, donation type/intended use and division indicator.If using CODABAR product labeling standard, the product code is a 5-digit number.This field is required for blood components and is not applicable for commercial product messages.
            /// </summary>
            public class BcComponent : HL7Base<BcComponent>
            {

                private const string _id = "BTX.3";
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
                /// BTX.3.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CNE.2. Different coding schemes will have different elements here.Usage Note The identifier is required and must be a valid code.
                /// </summary>
                public class Identifier : HL7Base<Identifier>
                {

                    private const string _id = "BTX.3.1";
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
                /// BTX.3.2 - The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression. This is the corresponding text assigned by the coding system to the identifier.Usage Note Text description of code is optional but its use should be encouraged since it makes messages easier to review for accuracy, especially during interface testing and debugging.
                /// </summary>
                public class Text : HL7Base<Text>
                {

                    private const string _id = "BTX.3.2";
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
                /// BTX.3.3 - The third component contains the code for the name of the coding system from which the value in CNE.1 is obtained. Refer to HL7 Table 0396 - Coding Systems in Chapter 2C, Code Tables, for valid values. Each coding system is assigned a unique identifier.As of v2.7 this component is required when CNE.1 is populated and CNE.14 is not populated. Both CNE.3 and CNE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CNE.3 and/or CNE.14 the Coding System component or the Coding System OID for the tuple.The combination of the identifier and name of coding system represent a unique concept for a data item.Some organizations that publish code sets author more than one. The coding system, then, to be unique, is a concatenation of the name of the coding authority organization and the name of its code set or table. When an HL7 table is used for a CNE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. Similarly, ISO tables will be named ISOnnnn, where nnnn is the ISO table number.Usage Note The following statement is retained for backward compatibility as of v2.7. Best practice would recommend that this component always be populated. However, if the field narrative explicitly states "Refer to HL7 Table nnnn for valid values, and, if the sending and receiving systems are HL7 compliant, the coding system would be known from the standard.  This would be similar to a field with an ID data type, except that there is a second triplet in which to express an alternate code.
                /// </summary>
                public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
                {

                    private const string _id = "BTX.3.3";
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
                /// BTX.3.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CNE.1 Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
                /// </summary>
                public class AlternateIdentifier : HL7Base<AlternateIdentifier>
                {

                    private const string _id = "BTX.3.4";
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
                /// BTX.3.5 - The descriptive or textual name of the alternate identifier. Analogous to CNE.2 Text. Usage Notes If present, CNE.5 obeys the same rules of use and interpretation as described for CNE.2. 
                /// </summary>
                public class AlternateText : HL7Base<AlternateText>
                {

                    private const string _id = "BTX.3.5";
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
                /// BTX.3.6 - Identifies the coding scheme being used in the alternate identifier component.  Analogous to  CNE.3 Name of Coding System.  Refer to HL7 Table 0396 - Coding Systems in Chapter 2C, Code Tables, for valid values.As of v2.7 this component is required when CNE.4 is populated and CNE.17 is not populated. Both CNE.6 and CNE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CNE.6 and/or CNE.17, the "Coding System" component or the "Coding System OID", for the tuple.Usage Notes If present, CNE.6 obeys the same rules of use and interpretation as described for CNE.3.
                /// </summary>
                public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
                {

                    private const string _id = "BTX.3.6";
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
                /// BTX.3.7 - The version ID for the coding system identified by CNE.3. It belongs conceptually to components 1-3 and appears here only for reasons of backward compatibility.Usage Note If the coding system is any system other than an "HL7 coding system," version ID must be valued with an actual version ID. If the coding system is "HL7 coding system," version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. Text description of code is optional but its use should be encouraged since it makes messages easier to review for accuracy, especially during interface testing and debugging.
                /// </summary>
                public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
                {

                    private const string _id = "BTX.3.7";
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
                /// BTX.3.8 - The version ID for the coding system identified by CNE.6.  It belongs conceptually to the group of Alternate components (see note 2.A.1) and appears here only for reasons of backward compatibility. Analogous to CNE.7 Coding System Version ID.Usage Notes If present, CNE.8 obeys the same rules of use and interpretation as described for CNE.7.
                /// </summary>
                public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
                {

                    private const string _id = "BTX.3.8";
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
                /// BTX.3.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
                /// </summary>
                public class OriginalText : HL7Base<OriginalText>
                {

                    private const string _id = "BTX.3.9";
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
                /// BTX.3.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CN-1 Identifier.
                /// </summary>
                public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
                {

                    private const string _id = "BTX.3.10";
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
                /// BTX.3.11 - The descriptive or textual name of the Second Alternate Identifier. Analogous to CNE.2 Text.
                /// </summary>
                public class SecondAlternateText : HL7Base<SecondAlternateText>
                {

                    private const string _id = "BTX.3.11";
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
                /// BTX.3.12 - Identifies the coding scheme being used in the Second Alternate Identifier component. Analogous to CNE.3 Name of Coding System.  Refer to HL7 Table 0396 - Coding Systems in Chapter 2C, Code Tables, for valid values.As of v2.7 this component is required when CNE.10 is populated and CNE.20 is not populated. Both CNE.12 and CNE.20 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CNE.12 and/or CNE.20, the "Coding System" component or the "Coding System OID", for the tuple.
                /// </summary>
                public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
                {

                    private const string _id = "BTX.3.12";
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
                /// BTX.3.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CNE.7 Coding System Version ID.
                /// </summary>
                public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
                {

                    private const string _id = "BTX.3.13";
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
                /// BTX.3.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CNE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CNE.1 is populated and CNE.3 is not populated. Both CNE.3 and CNE.14 may be populated.
                /// </summary>
                public class CodingSystemOid : HL7Base<CodingSystemOid>
                {

                    private const string _id = "BTX.3.14";
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
                /// BTX.3.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CNE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class ValueSetOid : HL7Base<ValueSetOid>
                {

                    private const string _id = "BTX.3.15";
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
                /// BTX.3.16 - This component carries the version for the value set identified by CNE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CNE.15 is populated.
                /// </summary>
                public class ValueSetVersionId : HL7Base<ValueSetVersionId>
                {

                    private const string _id = "BTX.3.16";
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
                /// BTX.3.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CNE.6. Analogous to CNE.14 OID for Coding System. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CNE.4 is populated and CNE.6 is not populated. Both CNE.6 and CNE.17 may be populated.
                /// </summary>
                public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
                {

                    private const string _id = "BTX.3.17";
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
                /// BTX.3.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CNE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
                {

                    private const string _id = "BTX.3.18";
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
                /// BTX.3.19 - This component carries the version for the value set identified by CNE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CNE.18 is populated.
                /// </summary>
                public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
                {

                    private const string _id = "BTX.3.19";
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
                /// BTX.3.20 - This component contains the ISO Object Identifier (OID) from which the value in CNE.12 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined numbers, the OID registered in the HL7 OID registry should be used. This component is required when CNE.4 is populated and neither CNE.6 nor CNE.18 is populated. In short either the CNE.6 or the CNE.14 or CNE.17 must be populated when CNE.4 is populated.
                /// </summary>
                public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
                {

                    private const string _id = "BTX.3.20";
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
                /// BTX.3.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CNE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
                {

                    private const string _id = "BTX.3.21";
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
                /// BTX.3.22 - This component carries the version for the value set identified by CNE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CNE.21 is populated.
                /// </summary>
                public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
                {

                    private const string _id = "BTX.3.22";
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
            /// BTX.4 - This field indicates the ABO/Rh blood group of the blood component. The preferred values for the blood group are the specified values in Table 3A - Encodation of ABO/Rh Blood Group in the ISBT 128 Application Specification.This field is required for blood components and certain commercial products (such as solvent detergent plasma).
            /// </summary>
            public class BcBloodGroup : HL7Base<BcBloodGroup>
            {

                private const string _id = "BTX.4";
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
                /// BTX.4.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CNE.2. Different coding schemes will have different elements here.Usage Note The identifier is required and must be a valid code.
                /// </summary>
                public class Identifier : HL7Base<Identifier>
                {

                    private const string _id = "BTX.4.1";
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
                /// BTX.4.2 - The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression. This is the corresponding text assigned by the coding system to the identifier.Usage Note Text description of code is optional but its use should be encouraged since it makes messages easier to review for accuracy, especially during interface testing and debugging.
                /// </summary>
                public class Text : HL7Base<Text>
                {

                    private const string _id = "BTX.4.2";
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
                /// BTX.4.3 - The third component contains the code for the name of the coding system from which the value in CNE.1 is obtained. Refer to HL7 Table 0396 - Coding Systems in Chapter 2C, Code Tables, for valid values. Each coding system is assigned a unique identifier.As of v2.7 this component is required when CNE.1 is populated and CNE.14 is not populated. Both CNE.3 and CNE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CNE.3 and/or CNE.14 the Coding System component or the Coding System OID for the tuple.The combination of the identifier and name of coding system represent a unique concept for a data item.Some organizations that publish code sets author more than one. The coding system, then, to be unique, is a concatenation of the name of the coding authority organization and the name of its code set or table. When an HL7 table is used for a CNE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. Similarly, ISO tables will be named ISOnnnn, where nnnn is the ISO table number.Usage Note The following statement is retained for backward compatibility as of v2.7. Best practice would recommend that this component always be populated. However, if the field narrative explicitly states "Refer to HL7 Table nnnn for valid values, and, if the sending and receiving systems are HL7 compliant, the coding system would be known from the standard.  This would be similar to a field with an ID data type, except that there is a second triplet in which to express an alternate code.
                /// </summary>
                public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
                {

                    private const string _id = "BTX.4.3";
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
                /// BTX.4.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CNE.1 Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
                /// </summary>
                public class AlternateIdentifier : HL7Base<AlternateIdentifier>
                {

                    private const string _id = "BTX.4.4";
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
                /// BTX.4.5 - The descriptive or textual name of the alternate identifier. Analogous to CNE.2 Text. Usage Notes If present, CNE.5 obeys the same rules of use and interpretation as described for CNE.2. 
                /// </summary>
                public class AlternateText : HL7Base<AlternateText>
                {

                    private const string _id = "BTX.4.5";
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
                /// BTX.4.6 - Identifies the coding scheme being used in the alternate identifier component.  Analogous to  CNE.3 Name of Coding System.  Refer to HL7 Table 0396 - Coding Systems in Chapter 2C, Code Tables, for valid values.As of v2.7 this component is required when CNE.4 is populated and CNE.17 is not populated. Both CNE.6 and CNE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CNE.6 and/or CNE.17, the "Coding System" component or the "Coding System OID", for the tuple.Usage Notes If present, CNE.6 obeys the same rules of use and interpretation as described for CNE.3.
                /// </summary>
                public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
                {

                    private const string _id = "BTX.4.6";
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
                /// BTX.4.7 - The version ID for the coding system identified by CNE.3. It belongs conceptually to components 1-3 and appears here only for reasons of backward compatibility.Usage Note If the coding system is any system other than an "HL7 coding system," version ID must be valued with an actual version ID. If the coding system is "HL7 coding system," version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. Text description of code is optional but its use should be encouraged since it makes messages easier to review for accuracy, especially during interface testing and debugging.
                /// </summary>
                public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
                {

                    private const string _id = "BTX.4.7";
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
                /// BTX.4.8 - The version ID for the coding system identified by CNE.6.  It belongs conceptually to the group of Alternate components (see note 2.A.1) and appears here only for reasons of backward compatibility. Analogous to CNE.7 Coding System Version ID.Usage Notes If present, CNE.8 obeys the same rules of use and interpretation as described for CNE.7.
                /// </summary>
                public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
                {

                    private const string _id = "BTX.4.8";
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
                /// BTX.4.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
                /// </summary>
                public class OriginalText : HL7Base<OriginalText>
                {

                    private const string _id = "BTX.4.9";
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
                /// BTX.4.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CN-1 Identifier.
                /// </summary>
                public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
                {

                    private const string _id = "BTX.4.10";
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
                /// BTX.4.11 - The descriptive or textual name of the Second Alternate Identifier. Analogous to CNE.2 Text.
                /// </summary>
                public class SecondAlternateText : HL7Base<SecondAlternateText>
                {

                    private const string _id = "BTX.4.11";
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
                /// BTX.4.12 - Identifies the coding scheme being used in the Second Alternate Identifier component. Analogous to CNE.3 Name of Coding System.  Refer to HL7 Table 0396 - Coding Systems in Chapter 2C, Code Tables, for valid values.As of v2.7 this component is required when CNE.10 is populated and CNE.20 is not populated. Both CNE.12 and CNE.20 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CNE.12 and/or CNE.20, the "Coding System" component or the "Coding System OID", for the tuple.
                /// </summary>
                public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
                {

                    private const string _id = "BTX.4.12";
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
                /// BTX.4.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CNE.7 Coding System Version ID.
                /// </summary>
                public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
                {

                    private const string _id = "BTX.4.13";
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
                /// BTX.4.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CNE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CNE.1 is populated and CNE.3 is not populated. Both CNE.3 and CNE.14 may be populated.
                /// </summary>
                public class CodingSystemOid : HL7Base<CodingSystemOid>
                {

                    private const string _id = "BTX.4.14";
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
                /// BTX.4.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CNE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class ValueSetOid : HL7Base<ValueSetOid>
                {

                    private const string _id = "BTX.4.15";
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
                /// BTX.4.16 - This component carries the version for the value set identified by CNE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CNE.15 is populated.
                /// </summary>
                public class ValueSetVersionId : HL7Base<ValueSetVersionId>
                {

                    private const string _id = "BTX.4.16";
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
                /// BTX.4.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CNE.6. Analogous to CNE.14 OID for Coding System. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CNE.4 is populated and CNE.6 is not populated. Both CNE.6 and CNE.17 may be populated.
                /// </summary>
                public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
                {

                    private const string _id = "BTX.4.17";
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
                /// BTX.4.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CNE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
                {

                    private const string _id = "BTX.4.18";
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
                /// BTX.4.19 - This component carries the version for the value set identified by CNE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CNE.18 is populated.
                /// </summary>
                public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
                {

                    private const string _id = "BTX.4.19";
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
                /// BTX.4.20 - This component contains the ISO Object Identifier (OID) from which the value in CNE.12 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined numbers, the OID registered in the HL7 OID registry should be used. This component is required when CNE.4 is populated and neither CNE.6 nor CNE.18 is populated. In short either the CNE.6 or the CNE.14 or CNE.17 must be populated when CNE.4 is populated.
                /// </summary>
                public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
                {

                    private const string _id = "BTX.4.20";
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
                /// BTX.4.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CNE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
                {

                    private const string _id = "BTX.4.21";
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
                /// BTX.4.22 - This component carries the version for the value set identified by CNE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CNE.21 is populated.
                /// </summary>
                public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
                {

                    private const string _id = "BTX.4.22";
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
            /// BTX.5 - This field contains the code and/or text to identify a commercial product.  Examples of commercial products are blood derivatives such as Rh Immune Globulin and Factor VIII concentrate, Leukoreduction filters, and blood administration sets.Either code and/or text may be absent.  However, the code is always placed in the first component position and any free text in the second component.  Thus, free text without a code must be preceded by a component delimiter.  Free text can be utilized if no update is to occur.  Refer to User-Defined Table 0512 - Commercial Product for suggested values.This field is required for commercial blood products and is not applicable to blood component messages.
            /// </summary>
            public class CpCommercialProduct : HL7Base<CpCommercialProduct>
            {

                private const string _id = "BTX.5";
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
                /// BTX.5.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
                /// </summary>
                public class Identifier : HL7Base<Identifier>
                {

                    private const string _id = "BTX.5.1";
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
                /// BTX.5.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
                /// </summary>
                public class Text : HL7Base<Text>
                {

                    private const string _id = "BTX.5.2";
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
                /// BTX.5.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
                /// </summary>
                public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
                {

                    private const string _id = "BTX.5.3";
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
                /// BTX.5.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
                /// </summary>
                public class AlternateIdentifier : HL7Base<AlternateIdentifier>
                {

                    private const string _id = "BTX.5.4";
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
                /// BTX.5.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
                /// </summary>
                public class AlternateText : HL7Base<AlternateText>
                {

                    private const string _id = "BTX.5.5";
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
                /// BTX.5.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
                /// </summary>
                public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
                {

                    private const string _id = "BTX.5.6";
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
                /// BTX.5.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
                /// </summary>
                public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
                {

                    private const string _id = "BTX.5.7";
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
                /// BTX.5.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
                /// </summary>
                public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
                {

                    private const string _id = "BTX.5.8";
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
                /// BTX.5.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
                /// </summary>
                public class OriginalText : HL7Base<OriginalText>
                {

                    private const string _id = "BTX.5.9";
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
                /// BTX.5.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
                /// </summary>
                public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
                {

                    private const string _id = "BTX.5.10";
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
                /// BTX.5.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
                /// </summary>
                public class SecondAlternateText : HL7Base<SecondAlternateText>
                {

                    private const string _id = "BTX.5.11";
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
                /// BTX.5.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
                /// </summary>
                public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
                {

                    private const string _id = "BTX.5.12";
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
                /// BTX.5.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
                /// </summary>
                public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
                {

                    private const string _id = "BTX.5.13";
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
                /// BTX.5.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
                /// </summary>
                public class CodingSystemOid : HL7Base<CodingSystemOid>
                {

                    private const string _id = "BTX.5.14";
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
                /// BTX.5.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class ValueSetOid : HL7Base<ValueSetOid>
                {

                    private const string _id = "BTX.5.15";
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
                /// BTX.5.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
                /// </summary>
                public class ValueSetVersionId : HL7Base<ValueSetVersionId>
                {

                    private const string _id = "BTX.5.16";
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
                /// BTX.5.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
                /// </summary>
                public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
                {

                    private const string _id = "BTX.5.17";
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
                /// BTX.5.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
                {

                    private const string _id = "BTX.5.18";
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
                /// BTX.5.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
                /// </summary>
                public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
                {

                    private const string _id = "BTX.5.19";
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
                /// BTX.5.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
                /// </summary>
                public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
                {

                    private const string _id = "BTX.5.20";
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
                /// BTX.5.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
                {

                    private const string _id = "BTX.5.21";
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
                /// BTX.5.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
                /// </summary>
                public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
                {

                    private const string _id = "BTX.5.22";
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
            /// BTX.6 - This field identifies the manufacturer of the commercial product.  The manufacturer may not be the same as the supplier of the commercial product.This field is required for commercial blood products and is not applicable for blood component messages.
            /// </summary>
            public class CpManufacturer : HL7Base<CpManufacturer>
            {

                private const string _id = "BTX.6";
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
                /// BTX.6.1 - The name of the specified organization.
                /// </summary>
                public class OrganizationName : HL7Base<OrganizationName>
                {

                    private const string _id = "BTX.6.1";
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
                /// BTX.6.2 - A code that represents the type of name i.e., legal name, display name. Refer to User-defined Table 0204 - Organizational Name Type for suggested values.
                /// </summary>
                public class OrganizationNameTypeCode : HL7Base<OrganizationNameTypeCode>
                {

                    private const string _id = "BTX.6.2";
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
                    /// BTX.6.2.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
                    /// </summary>
                    public class Identifier : HL7Base<Identifier>
                    {

                        private const string _id = "BTX.6.2.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.6.2.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
                    /// </summary>
                    public class Text : HL7Base<Text>
                    {

                        private const string _id = "BTX.6.2.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.6.2.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
                    /// </summary>
                    public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
                    {

                        private const string _id = "BTX.6.2.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.6.2.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
                    /// </summary>
                    public class AlternateIdentifier : HL7Base<AlternateIdentifier>
                    {

                        private const string _id = "BTX.6.2.4";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.6.2.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
                    /// </summary>
                    public class AlternateText : HL7Base<AlternateText>
                    {

                        private const string _id = "BTX.6.2.5";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.6.2.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
                    {

                        private const string _id = "BTX.6.2.6";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.6.2.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
                    /// </summary>
                    public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
                    {

                        private const string _id = "BTX.6.2.7";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.6.2.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
                    {

                        private const string _id = "BTX.6.2.8";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.6.2.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
                    /// </summary>
                    public class OriginalText : HL7Base<OriginalText>
                    {

                        private const string _id = "BTX.6.2.9";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.6.2.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
                    /// </summary>
                    public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
                    {

                        private const string _id = "BTX.6.2.10";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.6.2.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
                    /// </summary>
                    public class SecondAlternateText : HL7Base<SecondAlternateText>
                    {

                        private const string _id = "BTX.6.2.11";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.6.2.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
                    {

                        private const string _id = "BTX.6.2.12";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.6.2.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
                    {

                        private const string _id = "BTX.6.2.13";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.6.2.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
                    /// </summary>
                    public class CodingSystemOid : HL7Base<CodingSystemOid>
                    {

                        private const string _id = "BTX.6.2.14";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.6.2.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class ValueSetOid : HL7Base<ValueSetOid>
                    {

                        private const string _id = "BTX.6.2.15";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.6.2.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
                    /// </summary>
                    public class ValueSetVersionId : HL7Base<ValueSetVersionId>
                    {

                        private const string _id = "BTX.6.2.16";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.6.2.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
                    /// </summary>
                    public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
                    {

                        private const string _id = "BTX.6.2.17";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.6.2.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
                    {

                        private const string _id = "BTX.6.2.18";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.6.2.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
                    /// </summary>
                    public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
                    {

                        private const string _id = "BTX.6.2.19";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.6.2.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
                    /// </summary>
                    public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
                    {

                        private const string _id = "BTX.6.2.20";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.6.2.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
                    {

                        private const string _id = "BTX.6.2.21";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.6.2.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
                    /// </summary>
                    public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
                    {

                        private const string _id = "BTX.6.2.22";
                        public override string Id
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
                /// BTX.6.3 - Attention The XON.3 component was deprecated as of v 2.5 and the detail was withdrawn and removed from the standard as of v 2.7. Refer to XON.10 Organization Identifier.
                /// </summary>
                public class IdNumber : HL7Base<IdNumber>
                {

                    private const string _id = "BTX.6.3";
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
                /// BTX.6.4 - Attention The XON.4 component was deprecated as of v 2.5 and the detail was withdrawn and removed from the standard as of v 2.7.
                /// </summary>
                public class IdentifierCheckDigit : HL7Base<IdentifierCheckDigit>
                {

                    private const string _id = "BTX.6.4";
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
                /// BTX.6.5 - Attention The XON.5 component was deprecated as of v 2.5 and the detail was withdrawn and removed from the standard as of v 2.7.
                /// </summary>
                public class CheckDigitScheme : HL7Base<CheckDigitScheme>
                {

                    private const string _id = "BTX.6.5";
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
                /// BTX.6.6 - The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Assigning authorities are unique across a given HL7 implementation. Refer to User-defined Table 0363 - Assigning Authority for suggested values. Note When the HD data type is used in a given segment as a component of a field of another data type, User-defined Table 0300 - Namespace ID (referenced by the first sub-component of the HD component) may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.By site agreement, implementers may continue to use User-defined Table 0300  Namespace ID for the first sub-component.
                /// </summary>
                public class AssigningAuthority : HL7Base<AssigningAuthority>
                {

                    private const string _id = "BTX.6.6";
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
                    /// BTX.6.6.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
                    /// </summary>
                    public class NamespaceId : HL7Base<NamespaceId>
                    {

                        private const string _id = "BTX.6.6.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.6.6.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
                    /// </summary>
                    public class UniversalId : HL7Base<UniversalId>
                    {

                        private const string _id = "BTX.6.6.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.6.6.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
                    /// </summary>
                    public class UniversalIdType : HL7Base<UniversalIdType>
                    {

                        private const string _id = "BTX.6.6.3";
                        public override string Id
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
                /// BTX.6.7 - A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the "Assigning authority" component. Refer to HL7 Table 0203 - Identifier Type for suggested values.
                /// </summary>
                public class IdentifierTypeCode : HL7Base<IdentifierTypeCode>
                {

                    private const string _id = "BTX.6.7";
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
                /// BTX.6.8 - The place or location identifier where the identifier was first assigned to the person. This component is not an inherent part of the identifier but rather part of the history of the identifier as part of this data type, its existence is a convenience for certain intercommunicating systems.Note When the HD data type is used in a given segment as a component of a field of another data type, User-defined Table 0300 - Namespace ID (referenced by the first sub-component of the HD component) may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
                /// </summary>
                public class AssigningFacility : HL7Base<AssigningFacility>
                {

                    private const string _id = "BTX.6.8";
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
                    /// BTX.6.8.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
                    /// </summary>
                    public class NamespaceId : HL7Base<NamespaceId>
                    {

                        private const string _id = "BTX.6.8.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.6.8.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
                    /// </summary>
                    public class UniversalId : HL7Base<UniversalId>
                    {

                        private const string _id = "BTX.6.8.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.6.8.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
                    /// </summary>
                    public class UniversalIdType : HL7Base<UniversalIdType>
                    {

                        private const string _id = "BTX.6.8.3";
                        public override string Id
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
                /// BTX.6.9 - Different name/address types and representations of the same name/address should be described by repeating of this field, with different values of the name/address type and/or name/address representation component.Note This new component remains in alphabetic representation with each repetition of the field using these data types, i.e. even though the name may be represented in an ideographic character set, this component will remain represented in an alphabetic character set.Refer to HL7 Table 0465  Name/address Representation Code for valid values.In general this component provides an indication of the representation provided by the data item. It does not necessarily specify the character sets used. Thus, even though the representation might provide an indication of what to expect, the sender is still free to encode the contents using whatever character set is desired. This component provides only hints for the receiver, so it can make choices regarding what it has been sent and what it is capable of displaying.
                /// </summary>
                public class NameRepresentationCode : HL7Base<NameRepresentationCode>
                {

                    private const string _id = "BTX.6.9";
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
                /// BTX.6.10 - This component contains the sequence of characters (the code) that uniquely identifies the item being referenced by XON.1 Organization Name. This component replaces XON.3 ID Number as of v 2.5.Note The check digit and code identifying check digit scheme are null if Organization identifier is alphanumeric.
                /// </summary>
                public class OrganizationIdentifier : HL7Base<OrganizationIdentifier>
                {

                    private const string _id = "BTX.6.10";
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
            /// BTX.7 - This field identifies the lot number for blood derivatives or commercially supplied items used as accessories to transfusion.This field is required for commercial blood products and is not applicable for blood component messages.
            /// </summary>
            public class CpLotNumber : HL7Base<CpLotNumber>
            {

                private const string _id = "BTX.7";
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
                /// BTX.7.1 - The first component, entity identifier, is usually defined to be unique within the series of identifiers created by the assigning authority, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, "HD - hierarchic designator".
                /// </summary>
                public class EntityIdentifier : HL7Base<EntityIdentifier>
                {

                    private const string _id = "BTX.7.1";
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
                /// BTX.7.2 - See Section 2.A.33.1, "Namespace ID (IS)" for definition. The component intentionally remains associated with the IS data type in v 2.7.The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363  Assigning Authority for suggested values.Note When the HD is used as a part of another data type, in this case as part of the EI data type, this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment. By site agreement, implementers may continue to use User-defined Table 0300  Namespace ID for the first component
                /// </summary>
                public class NamespaceId : HL7Base<NamespaceId>
                {

                    private const string _id = "BTX.7.2";
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
                /// BTX.7.3 - See Section 2.A.33.2, "Universal ID (ST)" for definition.
                /// </summary>
                public class UniversalId : HL7Base<UniversalId>
                {

                    private const string _id = "BTX.7.3";
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
                /// BTX.7.4 - Refer to HL7 Table 0301 - Universal ID Type for valid values. See Section 2.A.33.3, "Universal ID Type (ID)," for definition.
                /// </summary>
                public class UniversalIdType : HL7Base<UniversalIdType>
                {

                    private const string _id = "BTX.7.4";
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
            /// BTX.8 - This field indicates the number of blood components or commercial products to which the message refers.
            /// </summary>
            public class BpQuantity : HL7Base<BpQuantity>
            {

                private const string _id = "BTX.8";
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
            /// BTX.9 - This field contains the amount (volume) associated with each blood component or commercial product.  When included in this segment, it may be used to indicate the volume of the blood component or product that was actually transfused.
            /// </summary>
            public class BpAmount : HL7Base<BpAmount>
            {

                private const string _id = "BTX.9";
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
            /// BTX.10 - This field contains the units of measure for the blood component or commercial product  amount. (See Chapter 7 for more details about reporting units.)  This specifies the units of measure for volume of a blood component (i.e., 50 ml) or the units of measure or dosage of a commercial product (i.e., 910 I.U. - International Units - of Factor VIII Concentrate).
            /// </summary>
            public class BpUnits : HL7Base<BpUnits>
            {

                private const string _id = "BTX.10";
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
                /// BTX.10.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
                /// </summary>
                public class Identifier : HL7Base<Identifier>
                {

                    private const string _id = "BTX.10.1";
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
                /// BTX.10.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
                /// </summary>
                public class Text : HL7Base<Text>
                {

                    private const string _id = "BTX.10.2";
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
                /// BTX.10.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
                /// </summary>
                public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
                {

                    private const string _id = "BTX.10.3";
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
                /// BTX.10.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
                /// </summary>
                public class AlternateIdentifier : HL7Base<AlternateIdentifier>
                {

                    private const string _id = "BTX.10.4";
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
                /// BTX.10.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
                /// </summary>
                public class AlternateText : HL7Base<AlternateText>
                {

                    private const string _id = "BTX.10.5";
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
                /// BTX.10.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
                /// </summary>
                public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
                {

                    private const string _id = "BTX.10.6";
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
                /// BTX.10.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
                /// </summary>
                public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
                {

                    private const string _id = "BTX.10.7";
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
                /// BTX.10.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
                /// </summary>
                public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
                {

                    private const string _id = "BTX.10.8";
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
                /// BTX.10.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
                /// </summary>
                public class OriginalText : HL7Base<OriginalText>
                {

                    private const string _id = "BTX.10.9";
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
                /// BTX.10.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
                /// </summary>
                public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
                {

                    private const string _id = "BTX.10.10";
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
                /// BTX.10.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
                /// </summary>
                public class SecondAlternateText : HL7Base<SecondAlternateText>
                {

                    private const string _id = "BTX.10.11";
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
                /// BTX.10.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
                /// </summary>
                public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
                {

                    private const string _id = "BTX.10.12";
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
                /// BTX.10.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
                /// </summary>
                public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
                {

                    private const string _id = "BTX.10.13";
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
                /// BTX.10.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
                /// </summary>
                public class CodingSystemOid : HL7Base<CodingSystemOid>
                {

                    private const string _id = "BTX.10.14";
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
                /// BTX.10.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class ValueSetOid : HL7Base<ValueSetOid>
                {

                    private const string _id = "BTX.10.15";
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
                /// BTX.10.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
                /// </summary>
                public class ValueSetVersionId : HL7Base<ValueSetVersionId>
                {

                    private const string _id = "BTX.10.16";
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
                /// BTX.10.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
                /// </summary>
                public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
                {

                    private const string _id = "BTX.10.17";
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
                /// BTX.10.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
                {

                    private const string _id = "BTX.10.18";
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
                /// BTX.10.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
                /// </summary>
                public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
                {

                    private const string _id = "BTX.10.19";
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
                /// BTX.10.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
                /// </summary>
                public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
                {

                    private const string _id = "BTX.10.20";
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
                /// BTX.10.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
                {

                    private const string _id = "BTX.10.21";
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
                /// BTX.10.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
                /// </summary>
                public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
                {

                    private const string _id = "BTX.10.22";
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
            /// BTX.11 - This field indicates the current status of the specified blood product as indicated by the placer.  For example, the placer may return the blood product to the transfusion service unused because an IV could not be started. The blood component may have been entered, but the line was clogged and could not be used, in which case the component must be wasted.  A final status would indicate that the product has actually been "transfused."  Refer to HL7 Table 0513 - Blood Product Transfusion/Disposition Status for suggested values.
            /// </summary>
            public class BpTransfusionDispositionStatus : HL7Base<BpTransfusionDispositionStatus>
            {

                private const string _id = "BTX.11";
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
                /// BTX.11.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
                /// </summary>
                public class Identifier : HL7Base<Identifier>
                {

                    private const string _id = "BTX.11.1";
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
                /// BTX.11.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
                /// </summary>
                public class Text : HL7Base<Text>
                {

                    private const string _id = "BTX.11.2";
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
                /// BTX.11.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
                /// </summary>
                public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
                {

                    private const string _id = "BTX.11.3";
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
                /// BTX.11.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
                /// </summary>
                public class AlternateIdentifier : HL7Base<AlternateIdentifier>
                {

                    private const string _id = "BTX.11.4";
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
                /// BTX.11.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
                /// </summary>
                public class AlternateText : HL7Base<AlternateText>
                {

                    private const string _id = "BTX.11.5";
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
                /// BTX.11.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
                /// </summary>
                public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
                {

                    private const string _id = "BTX.11.6";
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
                /// BTX.11.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
                /// </summary>
                public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
                {

                    private const string _id = "BTX.11.7";
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
                /// BTX.11.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
                /// </summary>
                public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
                {

                    private const string _id = "BTX.11.8";
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
                /// BTX.11.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
                /// </summary>
                public class OriginalText : HL7Base<OriginalText>
                {

                    private const string _id = "BTX.11.9";
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
                /// BTX.11.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
                /// </summary>
                public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
                {

                    private const string _id = "BTX.11.10";
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
                /// BTX.11.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
                /// </summary>
                public class SecondAlternateText : HL7Base<SecondAlternateText>
                {

                    private const string _id = "BTX.11.11";
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
                /// BTX.11.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
                /// </summary>
                public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
                {

                    private const string _id = "BTX.11.12";
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
                /// BTX.11.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
                /// </summary>
                public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
                {

                    private const string _id = "BTX.11.13";
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
                /// BTX.11.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
                /// </summary>
                public class CodingSystemOid : HL7Base<CodingSystemOid>
                {

                    private const string _id = "BTX.11.14";
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
                /// BTX.11.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class ValueSetOid : HL7Base<ValueSetOid>
                {

                    private const string _id = "BTX.11.15";
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
                /// BTX.11.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
                /// </summary>
                public class ValueSetVersionId : HL7Base<ValueSetVersionId>
                {

                    private const string _id = "BTX.11.16";
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
                /// BTX.11.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
                /// </summary>
                public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
                {

                    private const string _id = "BTX.11.17";
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
                /// BTX.11.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
                {

                    private const string _id = "BTX.11.18";
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
                /// BTX.11.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
                /// </summary>
                public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
                {

                    private const string _id = "BTX.11.19";
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
                /// BTX.11.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
                /// </summary>
                public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
                {

                    private const string _id = "BTX.11.20";
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
                /// BTX.11.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
                {

                    private const string _id = "BTX.11.21";
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
                /// BTX.11.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
                /// </summary>
                public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
                {

                    private const string _id = "BTX.11.22";
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
            /// BTX.12 - The most commonly used message status values in a BTX will be preliminary and final.  A status is considered preliminary until a blood product has reached a final disposition for the patient.  For example, when the product is first cross-matched and a status message is sent, it would be considered preliminary.  When the product is dispensed to the patient, that status would also be considered preliminary.  However, once the product is transfused, the status would be considered final.  The status of a blood product (BTX-11) can continue to change and the previous result should be overwritten until it reaches a final status (BTX-12). Refer to HL7 Table 0511 - BP Observation Status Codes Interpretation for valid entries.
            /// </summary>
            public class BpMessageStatus : HL7Base<BpMessageStatus>
            {

                private const string _id = "BTX.12";
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
            /// BTX.13 - This field indicates the date and time that the status of the blood component was changed.  For example, if the blood component had a status of "TX" (Transfused), the date and time in this field would indicate the date and time the component was transfused by the placer system.
            /// </summary>
            public class BpDateTimeOfStatus : HL7Base<BpDateTimeOfStatus>
            {

                private const string _id = "BTX.13";
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
            /// BTX.14 - This field contains the identity of the individual who administers the transfusion of the blood product.   If the code is sent as a local code, it should be unique and unambiguous.  This field can be free text to permit capture without table update.   In this case, the administrator's name must be recorded as the second through fourth components of the field.
            /// </summary>
            public class BpTransfusionAdministrator : HL7Base<BpTransfusionAdministrator>
            {

                private const string _id = "BTX.14";
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
                /// BTX.14.1 - This component carries the Person Identifier itself. XCN.1, in conjunction with XCN.9 uniquely identifies the entity/person. XCN.1 is required if XCN.2 is not populated. Both may be populated. 
                /// </summary>
                public class PersonIdentifier : HL7Base<PersonIdentifier>
                {

                    private const string _id = "BTX.14.1";
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
                /// BTX.14.2 - This component allows full specification of the surname of a person. Where appropriate, it differentiates the person's own surname from that of the person's partner or spouse, in cases where the person's name may contain elements from either name. It also permits messages to distinguish the surname prefix (such as "van" or "de") from the surname root. See section 2.A.30, "FN - family name".XCN.2 is required if XCN.1 is not populated. Both may be populated.
                /// </summary>
                public class FamilyName : HL7Base<FamilyName>
                {

                    private const string _id = "BTX.14.2";
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
                    /// BTX.14.2.1 - The atomic element of the person's family name. In most Western usage, this is the person's last name.
                    /// </summary>
                    public class Surname : HL7Base<Surname>
                    {

                        private const string _id = "BTX.14.2.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.2.2 - Internationalization usage for Germanic languages. This component is optional. An example of a surname prefix is the "van" in "Ludwig van Beethoven". Since the surname prefix doesn't sort completely alphabetically, it is reasonable to specify it as a separate sub-component of the PN and extended PN data types (XPN and XCN).Note Subcomponents own surname prefix, own surname, surname prefix from partner/spouse and surname from partner/spouse decompose complex Germanic names such as Martha de Mum-van Beethoven. If these subcomponents are valued, the surname subcomponent should still be fully valued for backward compatibility, i.e., de Mum-van Beethoven&de&Mum&van&Beethoven.Also, for clarity, the last name prefix has been renamed to own surname prefix.
                    /// </summary>
                    public class OwnSurnamePrefix : HL7Base<OwnSurnamePrefix>
                    {

                        private const string _id = "BTX.14.2.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.2.3 - The portion of the surname (in most Western usage, the last name) that is derived from the person's own surname, as distinguished from any portion that is derived from the surname of the person's partner or spouse. This component is optional.If the person's surname has legally changed to become (or incorporate) the surname of the person's partner or spouse, this is the person's surname immediately prior to such change. Often this is the person's "maiden name".
                    /// </summary>
                    public class OwnSurname : HL7Base<OwnSurname>
                    {

                        private const string _id = "BTX.14.2.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.2.4 - Internationalization usage for Germanic languages. This component is optional. An example of a surname prefix is the van in "Ludwig van Beethoven". Since the surname prefix doesn't sort completely alphabetically, it is reasonable to specify it as a separate sub-component of the PN and extended PN data types (XPN and XCN). Note Subcomponents own surname prefix, own surname, surname prefix from partner/spouse and surname from partner/spouse decompose complex Germanic names such as Martha de Mum-van Beethoven. If these subcomponents are valued, the surname subcomponent should still be fully valued for backward compatibility, i.e., de Mum-van Beethoven&de&Mum&van&Beethoven.Also, for clarity, the last name prefix has been renamed to own surname prefix.
                    /// </summary>
                    public class SurnamePrefixFromPartnerSpouse : HL7Base<SurnamePrefixFromPartnerSpouse>
                    {

                        private const string _id = "BTX.14.2.4";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.2.5 - The portion of the person's surname (in most Western usage, the last name) that is derived from the surname of the person's partner or spouse, as distinguished from the part derived from the person's own surname. This component is optional.If no portion of the person's surname is derived from the surname of the person's partner or spouse, this component is not valued. Otherwise, if the surname of the partner or spouse has legally changed to become (or incorporate) the person's surname, this is the surname of the partner or spouse immediately prior to such change.
                    /// </summary>
                    public class SurnameFromPartnerSpouse : HL7Base<SurnameFromPartnerSpouse>
                    {

                        private const string _id = "BTX.14.2.5";
                        public override string Id
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
                /// BTX.14.3 - First name.
                /// </summary>
                public class GivenName : HL7Base<GivenName>
                {

                    private const string _id = "BTX.14.3";
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
                /// BTX.14.4 - Multiple middle names may be included by separating them with spaces.
                /// </summary>
                public class SecondAndFurtherGivenNamesOrInitialsThereof : HL7Base<SecondAndFurtherGivenNamesOrInitialsThereof>
                {

                    private const string _id = "BTX.14.4";
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
                /// BTX.14.5 - Used to specify a name suffix (e.g., Jr. or III).
                /// </summary>
                public class SuffixegJrOrIii : HL7Base<SuffixegJrOrIii>
                {

                    private const string _id = "BTX.14.5";
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
                /// BTX.14.6 - Used to specify a name prefix (e.g., Dr.).
                /// </summary>
                public class PrefixegDr : HL7Base<PrefixegDr>
                {

                    private const string _id = "BTX.14.6";
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
                /// BTX.14.7 - Attention The XCN-7 component was deprecated as of v2.5 and the detail was withdrawn and removed from the standard as of v27.. Refer to XCN.21 Professional Suffix.
                /// </summary>
                public class DegreeegMd : HL7Base<DegreeegMd>
                {

                    private const string _id = "BTX.14.7";
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
                /// BTX.14.8 - Attention Retained for backwards compatibility only as of v 2.7. The reader is referred to XCN.9 instead.User-defined Table 0297  CN ID source is used as the HL7 identifier for the user-defined table of values for this component. Used to delineate the first component.
                /// </summary>
                public class SourceTable : HL7Base<SourceTable>
                {

                    private const string _id = "BTX.14.8";
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
                    /// BTX.14.8.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
                    /// </summary>
                    public class Identifier : HL7Base<Identifier>
                    {

                        private const string _id = "BTX.14.8.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.8.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
                    /// </summary>
                    public class Text : HL7Base<Text>
                    {

                        private const string _id = "BTX.14.8.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.8.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
                    /// </summary>
                    public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
                    {

                        private const string _id = "BTX.14.8.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.8.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
                    /// </summary>
                    public class AlternateIdentifier : HL7Base<AlternateIdentifier>
                    {

                        private const string _id = "BTX.14.8.4";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.8.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
                    /// </summary>
                    public class AlternateText : HL7Base<AlternateText>
                    {

                        private const string _id = "BTX.14.8.5";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.8.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
                    {

                        private const string _id = "BTX.14.8.6";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.8.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
                    /// </summary>
                    public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
                    {

                        private const string _id = "BTX.14.8.7";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.8.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
                    {

                        private const string _id = "BTX.14.8.8";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.8.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
                    /// </summary>
                    public class OriginalText : HL7Base<OriginalText>
                    {

                        private const string _id = "BTX.14.8.9";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.8.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
                    /// </summary>
                    public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
                    {

                        private const string _id = "BTX.14.8.10";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.8.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
                    /// </summary>
                    public class SecondAlternateText : HL7Base<SecondAlternateText>
                    {

                        private const string _id = "BTX.14.8.11";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.8.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
                    {

                        private const string _id = "BTX.14.8.12";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.8.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
                    {

                        private const string _id = "BTX.14.8.13";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.8.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
                    /// </summary>
                    public class CodingSystemOid : HL7Base<CodingSystemOid>
                    {

                        private const string _id = "BTX.14.8.14";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.8.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class ValueSetOid : HL7Base<ValueSetOid>
                    {

                        private const string _id = "BTX.14.8.15";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.8.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
                    /// </summary>
                    public class ValueSetVersionId : HL7Base<ValueSetVersionId>
                    {

                        private const string _id = "BTX.14.8.16";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.8.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
                    /// </summary>
                    public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
                    {

                        private const string _id = "BTX.14.8.17";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.8.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
                    {

                        private const string _id = "BTX.14.8.18";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.8.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
                    /// </summary>
                    public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
                    {

                        private const string _id = "BTX.14.8.19";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.8.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
                    /// </summary>
                    public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
                    {

                        private const string _id = "BTX.14.8.20";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.8.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
                    {

                        private const string _id = "BTX.14.8.21";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.8.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
                    /// </summary>
                    public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
                    {

                        private const string _id = "BTX.14.8.22";
                        public override string Id
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
                /// BTX.14.9 - The assigning authority is a unique identifier of the system (or organization or agency of department) that creates the data. User-defined Table 0363  Assigning Authority is used as the HL7 identifier for the user-defined table of values for the first sub-component of the HD component, namespace ID.As of v 2.7, the Assigning Authority is conditional. It is required if XCN.1 is populated and neither XCN.22 nor XCN.23 are populated. All 3 components may be populated. No assumptions can be safely made based on position or sequence. Best practice is to send an OID in this component when populated.The reader is referred to XCN.22 and XCN.23 if there is a need to transmit values with semantic meaning for an assigning jurisdiction or assigning department or agency in addition to, or instead of, an assigning authority. However, all 3 components may be valued.  If, in so doing, it is discovered that the values in XCN.22 and/or XCN.23 conflict with XCN.9, the user would look to the Message Profile or other implementation agreement for a statement as to which takes precedence.Note When the HD data type is used in a given segment as a component of a field of another data type, User-defined Table 0300 - Namespace ID (referenced by the first sub-component of the HD component) may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.By site agreement, implementors may continue to use User-defined Table 0300  Namespace ID for the first sub-component.
                /// </summary>
                public class AssigningAuthority : HL7Base<AssigningAuthority>
                {

                    private const string _id = "BTX.14.9";
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
                    /// BTX.14.9.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
                    /// </summary>
                    public class NamespaceId : HL7Base<NamespaceId>
                    {

                        private const string _id = "BTX.14.9.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.9.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
                    /// </summary>
                    public class UniversalId : HL7Base<UniversalId>
                    {

                        private const string _id = "BTX.14.9.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.9.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
                    /// </summary>
                    public class UniversalIdType : HL7Base<UniversalIdType>
                    {

                        private const string _id = "BTX.14.9.3";
                        public override string Id
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
                /// BTX.14.10 - A code that represents the type of name. Refer to HL7 Table 0200 - Name Type for valid values. See Section 2.A.89.7, "Name Type Code (ID)".As of v 2.7, XCN.10 is conditional. It is required if XCN.2 is populated.
                /// </summary>
                public class NameTypeCode : HL7Base<NameTypeCode>
                {

                    private const string _id = "BTX.14.10";
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
                /// BTX.14.11 - This component contains the digit, or digits, exclusive of the identifier in XCN.1, calculated by applying an algorithm to all or some of the digits in the number, which may be used to test validity of the non-check-digit identifier.
                /// </summary>
                public class IdentifierCheckDigit : HL7Base<IdentifierCheckDigit>
                {

                    private const string _id = "BTX.14.11";
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
                /// BTX.14.12 - Contains the code identifying the check digit scheme employed.Refer to HL7 Table 0061 - Check Digit Scheme for valid values.
                /// </summary>
                public class CheckDigitScheme : HL7Base<CheckDigitScheme>
                {

                    private const string _id = "BTX.14.12";
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
                /// BTX.14.13 - A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the assigning authority component. Refer to HL7 Table 0203 - Identifier Type for suggested values.As of v 2.7, XCN.13 is conditional. It is required if XCN.1 is populated.
                /// </summary>
                public class IdentifierTypeCode : HL7Base<IdentifierTypeCode>
                {

                    private const string _id = "BTX.14.13";
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
                /// BTX.14.14 - The place or location identifier where the identifier was first assigned to the person. This component is not an inherent part of the identifier but rather part of the history of the identifier as part of this data type, its existence is a convenience for certain intercommunicating systems.Note When the HD data type is used in a given segment as a component of a field of another data type, User-defined Table 0300 - Namespace ID (referenced by the first sub-component of the HD component) may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
                /// </summary>
                public class AssigningFacility : HL7Base<AssigningFacility>
                {

                    private const string _id = "BTX.14.14";
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
                    /// BTX.14.14.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
                    /// </summary>
                    public class NamespaceId : HL7Base<NamespaceId>
                    {

                        private const string _id = "BTX.14.14.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.14.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
                    /// </summary>
                    public class UniversalId : HL7Base<UniversalId>
                    {

                        private const string _id = "BTX.14.14.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.14.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
                    /// </summary>
                    public class UniversalIdType : HL7Base<UniversalIdType>
                    {

                        private const string _id = "BTX.14.14.3";
                        public override string Id
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
                /// BTX.14.15 - Different name/address types and representations of the same name/address should be described by repeating of this field, with different values of the name/address type and/or name/address representation component.Note This new component remains in alphabetic representation with each repetition of the field using these data types. I.e., even though the name may be represented in an ideographic character set, this component will remain represented in an alphabetic character set.Refer to HL7 Table 0465  Name/address Representation for valid values.In general this component provides an indication of the representation provided by the data item. It does not necessarily specify the character sets used. Thus, even though the representation might provide an indication of what to expect, the sender is still free to encode the contents using whatever character set is desired. This component provides only hints for the receiver, so it can make choices regarding what it has been sent and what it is capable of displaying.
                /// </summary>
                public class NameRepresentationCode : HL7Base<NameRepresentationCode>
                {

                    private const string _id = "BTX.14.15";
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
                /// BTX.14.16 - This component is used to designate the context in which a name is used. The main use case is in Australian healthcare for indigenous patients who prefer to use different names when attending different healthcare institutions. Another use case occurs in the US where health practitioners can be licensed under slightly different names and the reporting of the correct name is vital for administrative purposes. Refer to User-defined Table 0448  Name Context for suggested values.
                /// </summary>
                public class NameContext : HL7Base<NameContext>
                {

                    private const string _id = "BTX.14.16";
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
                    /// BTX.14.16.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
                    /// </summary>
                    public class Identifier : HL7Base<Identifier>
                    {

                        private const string _id = "BTX.14.16.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.16.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
                    /// </summary>
                    public class Text : HL7Base<Text>
                    {

                        private const string _id = "BTX.14.16.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.16.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
                    /// </summary>
                    public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
                    {

                        private const string _id = "BTX.14.16.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.16.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
                    /// </summary>
                    public class AlternateIdentifier : HL7Base<AlternateIdentifier>
                    {

                        private const string _id = "BTX.14.16.4";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.16.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
                    /// </summary>
                    public class AlternateText : HL7Base<AlternateText>
                    {

                        private const string _id = "BTX.14.16.5";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.16.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
                    {

                        private const string _id = "BTX.14.16.6";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.16.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
                    /// </summary>
                    public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
                    {

                        private const string _id = "BTX.14.16.7";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.16.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
                    {

                        private const string _id = "BTX.14.16.8";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.16.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
                    /// </summary>
                    public class OriginalText : HL7Base<OriginalText>
                    {

                        private const string _id = "BTX.14.16.9";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.16.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
                    /// </summary>
                    public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
                    {

                        private const string _id = "BTX.14.16.10";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.16.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
                    /// </summary>
                    public class SecondAlternateText : HL7Base<SecondAlternateText>
                    {

                        private const string _id = "BTX.14.16.11";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.16.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
                    {

                        private const string _id = "BTX.14.16.12";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.16.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
                    {

                        private const string _id = "BTX.14.16.13";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.16.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
                    /// </summary>
                    public class CodingSystemOid : HL7Base<CodingSystemOid>
                    {

                        private const string _id = "BTX.14.16.14";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.16.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class ValueSetOid : HL7Base<ValueSetOid>
                    {

                        private const string _id = "BTX.14.16.15";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.16.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
                    /// </summary>
                    public class ValueSetVersionId : HL7Base<ValueSetVersionId>
                    {

                        private const string _id = "BTX.14.16.16";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.16.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
                    /// </summary>
                    public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
                    {

                        private const string _id = "BTX.14.16.17";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.16.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
                    {

                        private const string _id = "BTX.14.16.18";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.16.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
                    /// </summary>
                    public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
                    {

                        private const string _id = "BTX.14.16.19";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.16.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
                    /// </summary>
                    public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
                    {

                        private const string _id = "BTX.14.16.20";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.16.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
                    {

                        private const string _id = "BTX.14.16.21";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.16.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
                    /// </summary>
                    public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
                    {

                        private const string _id = "BTX.14.16.22";
                        public override string Id
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
                /// BTX.14.17 - Attention The XCN.17 component was deprecated as of v2.5 and the detail was withdrawn and removed from the standard as of v 2.7. Refer to XCN.19 Effective Date and XCN.20 Expiration Date instead.This component contains the start and end date/times that define the period during which this name was valid.
                /// </summary>
                public class NameValidityRange : HL7Base<NameValidityRange>
                {

                    private const string _id = "BTX.14.17";
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
                /// BTX.14.18 - A code that represents the preferred display order of the components of this person name. Refer to HL7 Table 0444 - Name Assembly Order for valid values.
                /// </summary>
                public class NameAssemblyOrder : HL7Base<NameAssemblyOrder>
                {

                    private const string _id = "BTX.14.18";
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
                /// BTX.14.19 - The first date, if known, on which the person name is valid and active.
                /// </summary>
                public class EffectiveDate : HL7Base<EffectiveDate>
                {

                    private const string _id = "BTX.14.19";
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
                /// BTX.14.20 - The last date, if known, on which the person name is valid and active.
                /// </summary>
                public class ExpirationDate : HL7Base<ExpirationDate>
                {

                    private const string _id = "BTX.14.20";
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
                /// BTX.14.21 - Used to specify an abbreviation, or a string of abbreviations denoting qualifications that support the persons profession, (e.g., licenses, certificates, degrees, affiliations with professional societies, etc.). The Professional Suffix normally follows the Family Name when the Person Name is used for display purposes. Please note that this component is an unformatted string and is used for display purposes only. Detailed information regarding the contents of Professional Suffix is obtained using appropriate segments in Chapter 15, "Personnel Management".
                /// </summary>
                public class ProfessionalSuffix : HL7Base<ProfessionalSuffix>
                {

                    private const string _id = "BTX.14.21";
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
                /// BTX.14.22 - The geo-political body that assigned the identifier in XCN.1. As of v 2.7, the Assigning Jurisdiction is conditional. It is required if XCN.1 is populated and neither XCN.9 nor XCN.23 are populated. All 3 components may be populated. The reader is referred to XCN.9 if there is a need to transmit this information as an OID.
                /// </summary>
                public class AssigningJurisdiction : HL7Base<AssigningJurisdiction>
                {

                    private const string _id = "BTX.14.22";
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
                    /// BTX.14.22.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
                    /// </summary>
                    public class Identifier : HL7Base<Identifier>
                    {

                        private const string _id = "BTX.14.22.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.22.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
                    /// </summary>
                    public class Text : HL7Base<Text>
                    {

                        private const string _id = "BTX.14.22.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.22.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
                    /// </summary>
                    public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
                    {

                        private const string _id = "BTX.14.22.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.22.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
                    /// </summary>
                    public class AlternateIdentifier : HL7Base<AlternateIdentifier>
                    {

                        private const string _id = "BTX.14.22.4";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.22.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
                    /// </summary>
                    public class AlternateText : HL7Base<AlternateText>
                    {

                        private const string _id = "BTX.14.22.5";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.22.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
                    {

                        private const string _id = "BTX.14.22.6";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.22.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
                    /// </summary>
                    public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
                    {

                        private const string _id = "BTX.14.22.7";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.22.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
                    {

                        private const string _id = "BTX.14.22.8";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.22.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
                    /// </summary>
                    public class OriginalText : HL7Base<OriginalText>
                    {

                        private const string _id = "BTX.14.22.9";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.22.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
                    /// </summary>
                    public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
                    {

                        private const string _id = "BTX.14.22.10";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.22.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
                    /// </summary>
                    public class SecondAlternateText : HL7Base<SecondAlternateText>
                    {

                        private const string _id = "BTX.14.22.11";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.22.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
                    {

                        private const string _id = "BTX.14.22.12";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.22.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
                    {

                        private const string _id = "BTX.14.22.13";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.22.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
                    /// </summary>
                    public class CodingSystemOid : HL7Base<CodingSystemOid>
                    {

                        private const string _id = "BTX.14.22.14";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.22.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class ValueSetOid : HL7Base<ValueSetOid>
                    {

                        private const string _id = "BTX.14.22.15";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.22.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
                    /// </summary>
                    public class ValueSetVersionId : HL7Base<ValueSetVersionId>
                    {

                        private const string _id = "BTX.14.22.16";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.22.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
                    /// </summary>
                    public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
                    {

                        private const string _id = "BTX.14.22.17";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.22.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
                    {

                        private const string _id = "BTX.14.22.18";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.22.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
                    /// </summary>
                    public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
                    {

                        private const string _id = "BTX.14.22.19";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.22.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
                    /// </summary>
                    public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
                    {

                        private const string _id = "BTX.14.22.20";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.22.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
                    {

                        private const string _id = "BTX.14.22.21";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.22.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
                    /// </summary>
                    public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
                    {

                        private const string _id = "BTX.14.22.22";
                        public override string Id
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
                /// BTX.14.23 - The agency or department that assigned the identifier in XCN.1.As of v 2.7, the Assigning Jurisdiction is conditional. It is required if XCN.1 is populated and neither XCN.9 nor XCN.22 are populated. All 3 components may be populated. The reader is referred to XCN.9 if there is a need to transmit this information as an OID.
                /// </summary>
                public class AssigningAgencyOrDepartment : HL7Base<AssigningAgencyOrDepartment>
                {

                    private const string _id = "BTX.14.23";
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
                    /// BTX.14.23.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
                    /// </summary>
                    public class Identifier : HL7Base<Identifier>
                    {

                        private const string _id = "BTX.14.23.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.23.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
                    /// </summary>
                    public class Text : HL7Base<Text>
                    {

                        private const string _id = "BTX.14.23.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.23.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
                    /// </summary>
                    public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
                    {

                        private const string _id = "BTX.14.23.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.23.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
                    /// </summary>
                    public class AlternateIdentifier : HL7Base<AlternateIdentifier>
                    {

                        private const string _id = "BTX.14.23.4";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.23.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
                    /// </summary>
                    public class AlternateText : HL7Base<AlternateText>
                    {

                        private const string _id = "BTX.14.23.5";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.23.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
                    {

                        private const string _id = "BTX.14.23.6";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.23.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
                    /// </summary>
                    public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
                    {

                        private const string _id = "BTX.14.23.7";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.23.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
                    {

                        private const string _id = "BTX.14.23.8";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.23.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
                    /// </summary>
                    public class OriginalText : HL7Base<OriginalText>
                    {

                        private const string _id = "BTX.14.23.9";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.23.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
                    /// </summary>
                    public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
                    {

                        private const string _id = "BTX.14.23.10";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.23.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
                    /// </summary>
                    public class SecondAlternateText : HL7Base<SecondAlternateText>
                    {

                        private const string _id = "BTX.14.23.11";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.23.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
                    {

                        private const string _id = "BTX.14.23.12";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.23.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
                    {

                        private const string _id = "BTX.14.23.13";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.23.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
                    /// </summary>
                    public class CodingSystemOid : HL7Base<CodingSystemOid>
                    {

                        private const string _id = "BTX.14.23.14";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.23.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class ValueSetOid : HL7Base<ValueSetOid>
                    {

                        private const string _id = "BTX.14.23.15";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.23.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
                    /// </summary>
                    public class ValueSetVersionId : HL7Base<ValueSetVersionId>
                    {

                        private const string _id = "BTX.14.23.16";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.23.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
                    /// </summary>
                    public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
                    {

                        private const string _id = "BTX.14.23.17";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.23.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
                    {

                        private const string _id = "BTX.14.23.18";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.23.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
                    /// </summary>
                    public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
                    {

                        private const string _id = "BTX.14.23.19";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.23.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
                    /// </summary>
                    public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
                    {

                        private const string _id = "BTX.14.23.20";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.23.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
                    {

                        private const string _id = "BTX.14.23.21";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.14.23.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
                    /// </summary>
                    public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
                    {

                        private const string _id = "BTX.14.23.22";
                        public override string Id
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
                /// BTX.14.24 - This component is used to communicate a version code that may be assigned to the value given in XCN.1 Person Identifier.
                /// </summary>
                public class SecurityCheck : HL7Base<SecurityCheck>
                {

                    private const string _id = "BTX.14.24";
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
                /// BTX.14.25 - This component is used to transmit information intended to validate the veracity of the supplied identifier or the presenter of the identifier. For example, this component may be used to ensure that the presenter of a credit card is an authorized user of that card.Refer to HL7 Table 0904 - Security Check Scheme for valid values
                /// </summary>
                public class SecurityCheckScheme : HL7Base<SecurityCheckScheme>
                {

                    private const string _id = "BTX.14.25";
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
            /// BTX.15 - This field contains the identity of the individual who assists in the identification of the patient and verification of the product information prior to transfusion of the blood product.  If the ID Number is sent as a local code, it should be unique and unambiguous.  This field can be free text to permit capture without table update.   In this case, the verifier's name must be recorded as the second through fourth components of the field.
            /// </summary>
            public class BpTransfusionVerifier : HL7Base<BpTransfusionVerifier>
            {

                private const string _id = "BTX.15";
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
                /// BTX.15.1 - This component carries the Person Identifier itself. XCN.1, in conjunction with XCN.9 uniquely identifies the entity/person. XCN.1 is required if XCN.2 is not populated. Both may be populated. 
                /// </summary>
                public class PersonIdentifier : HL7Base<PersonIdentifier>
                {

                    private const string _id = "BTX.15.1";
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
                /// BTX.15.2 - This component allows full specification of the surname of a person. Where appropriate, it differentiates the person's own surname from that of the person's partner or spouse, in cases where the person's name may contain elements from either name. It also permits messages to distinguish the surname prefix (such as "van" or "de") from the surname root. See section 2.A.30, "FN - family name".XCN.2 is required if XCN.1 is not populated. Both may be populated.
                /// </summary>
                public class FamilyName : HL7Base<FamilyName>
                {

                    private const string _id = "BTX.15.2";
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
                    /// BTX.15.2.1 - The atomic element of the person's family name. In most Western usage, this is the person's last name.
                    /// </summary>
                    public class Surname : HL7Base<Surname>
                    {

                        private const string _id = "BTX.15.2.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.2.2 - Internationalization usage for Germanic languages. This component is optional. An example of a surname prefix is the "van" in "Ludwig van Beethoven". Since the surname prefix doesn't sort completely alphabetically, it is reasonable to specify it as a separate sub-component of the PN and extended PN data types (XPN and XCN).Note Subcomponents own surname prefix, own surname, surname prefix from partner/spouse and surname from partner/spouse decompose complex Germanic names such as Martha de Mum-van Beethoven. If these subcomponents are valued, the surname subcomponent should still be fully valued for backward compatibility, i.e., de Mum-van Beethoven&de&Mum&van&Beethoven.Also, for clarity, the last name prefix has been renamed to own surname prefix.
                    /// </summary>
                    public class OwnSurnamePrefix : HL7Base<OwnSurnamePrefix>
                    {

                        private const string _id = "BTX.15.2.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.2.3 - The portion of the surname (in most Western usage, the last name) that is derived from the person's own surname, as distinguished from any portion that is derived from the surname of the person's partner or spouse. This component is optional.If the person's surname has legally changed to become (or incorporate) the surname of the person's partner or spouse, this is the person's surname immediately prior to such change. Often this is the person's "maiden name".
                    /// </summary>
                    public class OwnSurname : HL7Base<OwnSurname>
                    {

                        private const string _id = "BTX.15.2.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.2.4 - Internationalization usage for Germanic languages. This component is optional. An example of a surname prefix is the van in "Ludwig van Beethoven". Since the surname prefix doesn't sort completely alphabetically, it is reasonable to specify it as a separate sub-component of the PN and extended PN data types (XPN and XCN). Note Subcomponents own surname prefix, own surname, surname prefix from partner/spouse and surname from partner/spouse decompose complex Germanic names such as Martha de Mum-van Beethoven. If these subcomponents are valued, the surname subcomponent should still be fully valued for backward compatibility, i.e., de Mum-van Beethoven&de&Mum&van&Beethoven.Also, for clarity, the last name prefix has been renamed to own surname prefix.
                    /// </summary>
                    public class SurnamePrefixFromPartnerSpouse : HL7Base<SurnamePrefixFromPartnerSpouse>
                    {

                        private const string _id = "BTX.15.2.4";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.2.5 - The portion of the person's surname (in most Western usage, the last name) that is derived from the surname of the person's partner or spouse, as distinguished from the part derived from the person's own surname. This component is optional.If no portion of the person's surname is derived from the surname of the person's partner or spouse, this component is not valued. Otherwise, if the surname of the partner or spouse has legally changed to become (or incorporate) the person's surname, this is the surname of the partner or spouse immediately prior to such change.
                    /// </summary>
                    public class SurnameFromPartnerSpouse : HL7Base<SurnameFromPartnerSpouse>
                    {

                        private const string _id = "BTX.15.2.5";
                        public override string Id
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
                /// BTX.15.3 - First name.
                /// </summary>
                public class GivenName : HL7Base<GivenName>
                {

                    private const string _id = "BTX.15.3";
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
                /// BTX.15.4 - Multiple middle names may be included by separating them with spaces.
                /// </summary>
                public class SecondAndFurtherGivenNamesOrInitialsThereof : HL7Base<SecondAndFurtherGivenNamesOrInitialsThereof>
                {

                    private const string _id = "BTX.15.4";
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
                /// BTX.15.5 - Used to specify a name suffix (e.g., Jr. or III).
                /// </summary>
                public class SuffixegJrOrIii : HL7Base<SuffixegJrOrIii>
                {

                    private const string _id = "BTX.15.5";
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
                /// BTX.15.6 - Used to specify a name prefix (e.g., Dr.).
                /// </summary>
                public class PrefixegDr : HL7Base<PrefixegDr>
                {

                    private const string _id = "BTX.15.6";
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
                /// BTX.15.7 - Attention The XCN-7 component was deprecated as of v2.5 and the detail was withdrawn and removed from the standard as of v27.. Refer to XCN.21 Professional Suffix.
                /// </summary>
                public class DegreeegMd : HL7Base<DegreeegMd>
                {

                    private const string _id = "BTX.15.7";
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
                /// BTX.15.8 - Attention Retained for backwards compatibility only as of v 2.7. The reader is referred to XCN.9 instead.User-defined Table 0297  CN ID source is used as the HL7 identifier for the user-defined table of values for this component. Used to delineate the first component.
                /// </summary>
                public class SourceTable : HL7Base<SourceTable>
                {

                    private const string _id = "BTX.15.8";
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
                    /// BTX.15.8.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
                    /// </summary>
                    public class Identifier : HL7Base<Identifier>
                    {

                        private const string _id = "BTX.15.8.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.8.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
                    /// </summary>
                    public class Text : HL7Base<Text>
                    {

                        private const string _id = "BTX.15.8.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.8.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
                    /// </summary>
                    public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
                    {

                        private const string _id = "BTX.15.8.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.8.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
                    /// </summary>
                    public class AlternateIdentifier : HL7Base<AlternateIdentifier>
                    {

                        private const string _id = "BTX.15.8.4";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.8.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
                    /// </summary>
                    public class AlternateText : HL7Base<AlternateText>
                    {

                        private const string _id = "BTX.15.8.5";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.8.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
                    {

                        private const string _id = "BTX.15.8.6";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.8.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
                    /// </summary>
                    public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
                    {

                        private const string _id = "BTX.15.8.7";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.8.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
                    {

                        private const string _id = "BTX.15.8.8";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.8.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
                    /// </summary>
                    public class OriginalText : HL7Base<OriginalText>
                    {

                        private const string _id = "BTX.15.8.9";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.8.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
                    /// </summary>
                    public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
                    {

                        private const string _id = "BTX.15.8.10";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.8.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
                    /// </summary>
                    public class SecondAlternateText : HL7Base<SecondAlternateText>
                    {

                        private const string _id = "BTX.15.8.11";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.8.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
                    {

                        private const string _id = "BTX.15.8.12";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.8.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
                    {

                        private const string _id = "BTX.15.8.13";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.8.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
                    /// </summary>
                    public class CodingSystemOid : HL7Base<CodingSystemOid>
                    {

                        private const string _id = "BTX.15.8.14";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.8.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class ValueSetOid : HL7Base<ValueSetOid>
                    {

                        private const string _id = "BTX.15.8.15";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.8.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
                    /// </summary>
                    public class ValueSetVersionId : HL7Base<ValueSetVersionId>
                    {

                        private const string _id = "BTX.15.8.16";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.8.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
                    /// </summary>
                    public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
                    {

                        private const string _id = "BTX.15.8.17";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.8.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
                    {

                        private const string _id = "BTX.15.8.18";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.8.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
                    /// </summary>
                    public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
                    {

                        private const string _id = "BTX.15.8.19";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.8.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
                    /// </summary>
                    public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
                    {

                        private const string _id = "BTX.15.8.20";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.8.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
                    {

                        private const string _id = "BTX.15.8.21";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.8.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
                    /// </summary>
                    public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
                    {

                        private const string _id = "BTX.15.8.22";
                        public override string Id
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
                /// BTX.15.9 - The assigning authority is a unique identifier of the system (or organization or agency of department) that creates the data. User-defined Table 0363  Assigning Authority is used as the HL7 identifier for the user-defined table of values for the first sub-component of the HD component, namespace ID.As of v 2.7, the Assigning Authority is conditional. It is required if XCN.1 is populated and neither XCN.22 nor XCN.23 are populated. All 3 components may be populated. No assumptions can be safely made based on position or sequence. Best practice is to send an OID in this component when populated.The reader is referred to XCN.22 and XCN.23 if there is a need to transmit values with semantic meaning for an assigning jurisdiction or assigning department or agency in addition to, or instead of, an assigning authority. However, all 3 components may be valued.  If, in so doing, it is discovered that the values in XCN.22 and/or XCN.23 conflict with XCN.9, the user would look to the Message Profile or other implementation agreement for a statement as to which takes precedence.Note When the HD data type is used in a given segment as a component of a field of another data type, User-defined Table 0300 - Namespace ID (referenced by the first sub-component of the HD component) may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.By site agreement, implementors may continue to use User-defined Table 0300  Namespace ID for the first sub-component.
                /// </summary>
                public class AssigningAuthority : HL7Base<AssigningAuthority>
                {

                    private const string _id = "BTX.15.9";
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
                    /// BTX.15.9.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
                    /// </summary>
                    public class NamespaceId : HL7Base<NamespaceId>
                    {

                        private const string _id = "BTX.15.9.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.9.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
                    /// </summary>
                    public class UniversalId : HL7Base<UniversalId>
                    {

                        private const string _id = "BTX.15.9.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.9.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
                    /// </summary>
                    public class UniversalIdType : HL7Base<UniversalIdType>
                    {

                        private const string _id = "BTX.15.9.3";
                        public override string Id
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
                /// BTX.15.10 - A code that represents the type of name. Refer to HL7 Table 0200 - Name Type for valid values. See Section 2.A.89.7, "Name Type Code (ID)".As of v 2.7, XCN.10 is conditional. It is required if XCN.2 is populated.
                /// </summary>
                public class NameTypeCode : HL7Base<NameTypeCode>
                {

                    private const string _id = "BTX.15.10";
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
                /// BTX.15.11 - This component contains the digit, or digits, exclusive of the identifier in XCN.1, calculated by applying an algorithm to all or some of the digits in the number, which may be used to test validity of the non-check-digit identifier.
                /// </summary>
                public class IdentifierCheckDigit : HL7Base<IdentifierCheckDigit>
                {

                    private const string _id = "BTX.15.11";
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
                /// BTX.15.12 - Contains the code identifying the check digit scheme employed.Refer to HL7 Table 0061 - Check Digit Scheme for valid values.
                /// </summary>
                public class CheckDigitScheme : HL7Base<CheckDigitScheme>
                {

                    private const string _id = "BTX.15.12";
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
                /// BTX.15.13 - A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the assigning authority component. Refer to HL7 Table 0203 - Identifier Type for suggested values.As of v 2.7, XCN.13 is conditional. It is required if XCN.1 is populated.
                /// </summary>
                public class IdentifierTypeCode : HL7Base<IdentifierTypeCode>
                {

                    private const string _id = "BTX.15.13";
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
                /// BTX.15.14 - The place or location identifier where the identifier was first assigned to the person. This component is not an inherent part of the identifier but rather part of the history of the identifier as part of this data type, its existence is a convenience for certain intercommunicating systems.Note When the HD data type is used in a given segment as a component of a field of another data type, User-defined Table 0300 - Namespace ID (referenced by the first sub-component of the HD component) may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
                /// </summary>
                public class AssigningFacility : HL7Base<AssigningFacility>
                {

                    private const string _id = "BTX.15.14";
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
                    /// BTX.15.14.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
                    /// </summary>
                    public class NamespaceId : HL7Base<NamespaceId>
                    {

                        private const string _id = "BTX.15.14.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.14.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
                    /// </summary>
                    public class UniversalId : HL7Base<UniversalId>
                    {

                        private const string _id = "BTX.15.14.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.14.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
                    /// </summary>
                    public class UniversalIdType : HL7Base<UniversalIdType>
                    {

                        private const string _id = "BTX.15.14.3";
                        public override string Id
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
                /// BTX.15.15 - Different name/address types and representations of the same name/address should be described by repeating of this field, with different values of the name/address type and/or name/address representation component.Note This new component remains in alphabetic representation with each repetition of the field using these data types. I.e., even though the name may be represented in an ideographic character set, this component will remain represented in an alphabetic character set.Refer to HL7 Table 0465  Name/address Representation for valid values.In general this component provides an indication of the representation provided by the data item. It does not necessarily specify the character sets used. Thus, even though the representation might provide an indication of what to expect, the sender is still free to encode the contents using whatever character set is desired. This component provides only hints for the receiver, so it can make choices regarding what it has been sent and what it is capable of displaying.
                /// </summary>
                public class NameRepresentationCode : HL7Base<NameRepresentationCode>
                {

                    private const string _id = "BTX.15.15";
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
                /// BTX.15.16 - This component is used to designate the context in which a name is used. The main use case is in Australian healthcare for indigenous patients who prefer to use different names when attending different healthcare institutions. Another use case occurs in the US where health practitioners can be licensed under slightly different names and the reporting of the correct name is vital for administrative purposes. Refer to User-defined Table 0448  Name Context for suggested values.
                /// </summary>
                public class NameContext : HL7Base<NameContext>
                {

                    private const string _id = "BTX.15.16";
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
                    /// BTX.15.16.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
                    /// </summary>
                    public class Identifier : HL7Base<Identifier>
                    {

                        private const string _id = "BTX.15.16.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.16.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
                    /// </summary>
                    public class Text : HL7Base<Text>
                    {

                        private const string _id = "BTX.15.16.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.16.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
                    /// </summary>
                    public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
                    {

                        private const string _id = "BTX.15.16.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.16.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
                    /// </summary>
                    public class AlternateIdentifier : HL7Base<AlternateIdentifier>
                    {

                        private const string _id = "BTX.15.16.4";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.16.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
                    /// </summary>
                    public class AlternateText : HL7Base<AlternateText>
                    {

                        private const string _id = "BTX.15.16.5";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.16.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
                    {

                        private const string _id = "BTX.15.16.6";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.16.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
                    /// </summary>
                    public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
                    {

                        private const string _id = "BTX.15.16.7";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.16.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
                    {

                        private const string _id = "BTX.15.16.8";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.16.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
                    /// </summary>
                    public class OriginalText : HL7Base<OriginalText>
                    {

                        private const string _id = "BTX.15.16.9";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.16.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
                    /// </summary>
                    public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
                    {

                        private const string _id = "BTX.15.16.10";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.16.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
                    /// </summary>
                    public class SecondAlternateText : HL7Base<SecondAlternateText>
                    {

                        private const string _id = "BTX.15.16.11";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.16.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
                    {

                        private const string _id = "BTX.15.16.12";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.16.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
                    {

                        private const string _id = "BTX.15.16.13";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.16.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
                    /// </summary>
                    public class CodingSystemOid : HL7Base<CodingSystemOid>
                    {

                        private const string _id = "BTX.15.16.14";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.16.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class ValueSetOid : HL7Base<ValueSetOid>
                    {

                        private const string _id = "BTX.15.16.15";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.16.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
                    /// </summary>
                    public class ValueSetVersionId : HL7Base<ValueSetVersionId>
                    {

                        private const string _id = "BTX.15.16.16";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.16.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
                    /// </summary>
                    public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
                    {

                        private const string _id = "BTX.15.16.17";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.16.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
                    {

                        private const string _id = "BTX.15.16.18";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.16.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
                    /// </summary>
                    public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
                    {

                        private const string _id = "BTX.15.16.19";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.16.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
                    /// </summary>
                    public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
                    {

                        private const string _id = "BTX.15.16.20";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.16.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
                    {

                        private const string _id = "BTX.15.16.21";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.16.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
                    /// </summary>
                    public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
                    {

                        private const string _id = "BTX.15.16.22";
                        public override string Id
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
                /// BTX.15.17 - Attention The XCN.17 component was deprecated as of v2.5 and the detail was withdrawn and removed from the standard as of v 2.7. Refer to XCN.19 Effective Date and XCN.20 Expiration Date instead.This component contains the start and end date/times that define the period during which this name was valid.
                /// </summary>
                public class NameValidityRange : HL7Base<NameValidityRange>
                {

                    private const string _id = "BTX.15.17";
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
                /// BTX.15.18 - A code that represents the preferred display order of the components of this person name. Refer to HL7 Table 0444 - Name Assembly Order for valid values.
                /// </summary>
                public class NameAssemblyOrder : HL7Base<NameAssemblyOrder>
                {

                    private const string _id = "BTX.15.18";
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
                /// BTX.15.19 - The first date, if known, on which the person name is valid and active.
                /// </summary>
                public class EffectiveDate : HL7Base<EffectiveDate>
                {

                    private const string _id = "BTX.15.19";
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
                /// BTX.15.20 - The last date, if known, on which the person name is valid and active.
                /// </summary>
                public class ExpirationDate : HL7Base<ExpirationDate>
                {

                    private const string _id = "BTX.15.20";
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
                /// BTX.15.21 - Used to specify an abbreviation, or a string of abbreviations denoting qualifications that support the persons profession, (e.g., licenses, certificates, degrees, affiliations with professional societies, etc.). The Professional Suffix normally follows the Family Name when the Person Name is used for display purposes. Please note that this component is an unformatted string and is used for display purposes only. Detailed information regarding the contents of Professional Suffix is obtained using appropriate segments in Chapter 15, "Personnel Management".
                /// </summary>
                public class ProfessionalSuffix : HL7Base<ProfessionalSuffix>
                {

                    private const string _id = "BTX.15.21";
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
                /// BTX.15.22 - The geo-political body that assigned the identifier in XCN.1. As of v 2.7, the Assigning Jurisdiction is conditional. It is required if XCN.1 is populated and neither XCN.9 nor XCN.23 are populated. All 3 components may be populated. The reader is referred to XCN.9 if there is a need to transmit this information as an OID.
                /// </summary>
                public class AssigningJurisdiction : HL7Base<AssigningJurisdiction>
                {

                    private const string _id = "BTX.15.22";
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
                    /// BTX.15.22.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
                    /// </summary>
                    public class Identifier : HL7Base<Identifier>
                    {

                        private const string _id = "BTX.15.22.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.22.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
                    /// </summary>
                    public class Text : HL7Base<Text>
                    {

                        private const string _id = "BTX.15.22.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.22.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
                    /// </summary>
                    public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
                    {

                        private const string _id = "BTX.15.22.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.22.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
                    /// </summary>
                    public class AlternateIdentifier : HL7Base<AlternateIdentifier>
                    {

                        private const string _id = "BTX.15.22.4";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.22.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
                    /// </summary>
                    public class AlternateText : HL7Base<AlternateText>
                    {

                        private const string _id = "BTX.15.22.5";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.22.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
                    {

                        private const string _id = "BTX.15.22.6";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.22.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
                    /// </summary>
                    public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
                    {

                        private const string _id = "BTX.15.22.7";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.22.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
                    {

                        private const string _id = "BTX.15.22.8";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.22.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
                    /// </summary>
                    public class OriginalText : HL7Base<OriginalText>
                    {

                        private const string _id = "BTX.15.22.9";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.22.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
                    /// </summary>
                    public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
                    {

                        private const string _id = "BTX.15.22.10";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.22.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
                    /// </summary>
                    public class SecondAlternateText : HL7Base<SecondAlternateText>
                    {

                        private const string _id = "BTX.15.22.11";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.22.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
                    {

                        private const string _id = "BTX.15.22.12";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.22.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
                    {

                        private const string _id = "BTX.15.22.13";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.22.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
                    /// </summary>
                    public class CodingSystemOid : HL7Base<CodingSystemOid>
                    {

                        private const string _id = "BTX.15.22.14";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.22.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class ValueSetOid : HL7Base<ValueSetOid>
                    {

                        private const string _id = "BTX.15.22.15";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.22.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
                    /// </summary>
                    public class ValueSetVersionId : HL7Base<ValueSetVersionId>
                    {

                        private const string _id = "BTX.15.22.16";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.22.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
                    /// </summary>
                    public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
                    {

                        private const string _id = "BTX.15.22.17";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.22.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
                    {

                        private const string _id = "BTX.15.22.18";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.22.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
                    /// </summary>
                    public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
                    {

                        private const string _id = "BTX.15.22.19";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.22.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
                    /// </summary>
                    public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
                    {

                        private const string _id = "BTX.15.22.20";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.22.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
                    {

                        private const string _id = "BTX.15.22.21";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.22.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
                    /// </summary>
                    public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
                    {

                        private const string _id = "BTX.15.22.22";
                        public override string Id
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
                /// BTX.15.23 - The agency or department that assigned the identifier in XCN.1.As of v 2.7, the Assigning Jurisdiction is conditional. It is required if XCN.1 is populated and neither XCN.9 nor XCN.22 are populated. All 3 components may be populated. The reader is referred to XCN.9 if there is a need to transmit this information as an OID.
                /// </summary>
                public class AssigningAgencyOrDepartment : HL7Base<AssigningAgencyOrDepartment>
                {

                    private const string _id = "BTX.15.23";
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
                    /// BTX.15.23.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
                    /// </summary>
                    public class Identifier : HL7Base<Identifier>
                    {

                        private const string _id = "BTX.15.23.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.23.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
                    /// </summary>
                    public class Text : HL7Base<Text>
                    {

                        private const string _id = "BTX.15.23.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.23.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
                    /// </summary>
                    public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
                    {

                        private const string _id = "BTX.15.23.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.23.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
                    /// </summary>
                    public class AlternateIdentifier : HL7Base<AlternateIdentifier>
                    {

                        private const string _id = "BTX.15.23.4";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.23.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
                    /// </summary>
                    public class AlternateText : HL7Base<AlternateText>
                    {

                        private const string _id = "BTX.15.23.5";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.23.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
                    {

                        private const string _id = "BTX.15.23.6";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.23.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
                    /// </summary>
                    public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
                    {

                        private const string _id = "BTX.15.23.7";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.23.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
                    {

                        private const string _id = "BTX.15.23.8";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.23.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
                    /// </summary>
                    public class OriginalText : HL7Base<OriginalText>
                    {

                        private const string _id = "BTX.15.23.9";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.23.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
                    /// </summary>
                    public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
                    {

                        private const string _id = "BTX.15.23.10";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.23.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
                    /// </summary>
                    public class SecondAlternateText : HL7Base<SecondAlternateText>
                    {

                        private const string _id = "BTX.15.23.11";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.23.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
                    {

                        private const string _id = "BTX.15.23.12";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.23.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
                    {

                        private const string _id = "BTX.15.23.13";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.23.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
                    /// </summary>
                    public class CodingSystemOid : HL7Base<CodingSystemOid>
                    {

                        private const string _id = "BTX.15.23.14";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.23.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class ValueSetOid : HL7Base<ValueSetOid>
                    {

                        private const string _id = "BTX.15.23.15";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.23.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
                    /// </summary>
                    public class ValueSetVersionId : HL7Base<ValueSetVersionId>
                    {

                        private const string _id = "BTX.15.23.16";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.23.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
                    /// </summary>
                    public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
                    {

                        private const string _id = "BTX.15.23.17";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.23.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
                    {

                        private const string _id = "BTX.15.23.18";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.23.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
                    /// </summary>
                    public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
                    {

                        private const string _id = "BTX.15.23.19";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.23.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
                    /// </summary>
                    public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
                    {

                        private const string _id = "BTX.15.23.20";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.23.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
                    {

                        private const string _id = "BTX.15.23.21";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BTX.15.23.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
                    /// </summary>
                    public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
                    {

                        private const string _id = "BTX.15.23.22";
                        public override string Id
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
                /// BTX.15.24 - This component is used to communicate a version code that may be assigned to the value given in XCN.1 Person Identifier.
                /// </summary>
                public class SecurityCheck : HL7Base<SecurityCheck>
                {

                    private const string _id = "BTX.15.24";
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
                /// BTX.15.25 - This component is used to transmit information intended to validate the veracity of the supplied identifier or the presenter of the identifier. For example, this component may be used to ensure that the presenter of a credit card is an authorized user of that card.Refer to HL7 Table 0904 - Security Check Scheme for valid values
                /// </summary>
                public class SecurityCheckScheme : HL7Base<SecurityCheckScheme>
                {

                    private const string _id = "BTX.15.25";
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
            /// BTX.16 - This field indicates the date and time that the administrator started the transfusion of the blood component or commercial product.
            /// </summary>
            public class BpTransfusionStartDateTimeOfStatus : HL7Base<BpTransfusionStartDateTimeOfStatus>
            {

                private const string _id = "BTX.16";
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
            /// BTX.17 - This field indicates the date and time that the transfusion of the blood component or commercial product was completed or stopped.
            /// </summary>
            public class BpTransfusionEndDateTimeOfStatus : HL7Base<BpTransfusionEndDateTimeOfStatus>
            {

                private const string _id = "BTX.17";
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
            /// BTX.18 - This field contains the type of adverse reaction that the recipient of the blood product experienced.  Refer to User-Defined Table 0514 - Transfusion Adverse Reaction for suggested values.
            /// </summary>
            public class BpAdverseReactionType : HL7Base<BpAdverseReactionType>
            {

                private const string _id = "BTX.18";
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
                /// BTX.18.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
                /// </summary>
                public class Identifier : HL7Base<Identifier>
                {

                    private const string _id = "BTX.18.1";
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
                /// BTX.18.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
                /// </summary>
                public class Text : HL7Base<Text>
                {

                    private const string _id = "BTX.18.2";
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
                /// BTX.18.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
                /// </summary>
                public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
                {

                    private const string _id = "BTX.18.3";
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
                /// BTX.18.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
                /// </summary>
                public class AlternateIdentifier : HL7Base<AlternateIdentifier>
                {

                    private const string _id = "BTX.18.4";
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
                /// BTX.18.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
                /// </summary>
                public class AlternateText : HL7Base<AlternateText>
                {

                    private const string _id = "BTX.18.5";
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
                /// BTX.18.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
                /// </summary>
                public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
                {

                    private const string _id = "BTX.18.6";
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
                /// BTX.18.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
                /// </summary>
                public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
                {

                    private const string _id = "BTX.18.7";
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
                /// BTX.18.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
                /// </summary>
                public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
                {

                    private const string _id = "BTX.18.8";
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
                /// BTX.18.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
                /// </summary>
                public class OriginalText : HL7Base<OriginalText>
                {

                    private const string _id = "BTX.18.9";
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
                /// BTX.18.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
                /// </summary>
                public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
                {

                    private const string _id = "BTX.18.10";
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
                /// BTX.18.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
                /// </summary>
                public class SecondAlternateText : HL7Base<SecondAlternateText>
                {

                    private const string _id = "BTX.18.11";
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
                /// BTX.18.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
                /// </summary>
                public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
                {

                    private const string _id = "BTX.18.12";
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
                /// BTX.18.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
                /// </summary>
                public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
                {

                    private const string _id = "BTX.18.13";
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
                /// BTX.18.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
                /// </summary>
                public class CodingSystemOid : HL7Base<CodingSystemOid>
                {

                    private const string _id = "BTX.18.14";
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
                /// BTX.18.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class ValueSetOid : HL7Base<ValueSetOid>
                {

                    private const string _id = "BTX.18.15";
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
                /// BTX.18.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
                /// </summary>
                public class ValueSetVersionId : HL7Base<ValueSetVersionId>
                {

                    private const string _id = "BTX.18.16";
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
                /// BTX.18.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
                /// </summary>
                public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
                {

                    private const string _id = "BTX.18.17";
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
                /// BTX.18.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
                {

                    private const string _id = "BTX.18.18";
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
                /// BTX.18.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
                /// </summary>
                public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
                {

                    private const string _id = "BTX.18.19";
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
                /// BTX.18.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
                /// </summary>
                public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
                {

                    private const string _id = "BTX.18.20";
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
                /// BTX.18.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
                {

                    private const string _id = "BTX.18.21";
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
                /// BTX.18.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
                /// </summary>
                public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
                {

                    private const string _id = "BTX.18.22";
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
            /// BTX.19 - This field contains the reason that the transfusion of the blood product was interrupted.   Refer to User-Defined Table 0515 - Transfusion Interrupted Reason for suggested values.
            /// </summary>
            public class BpTransfusionInterruptedReason : HL7Base<BpTransfusionInterruptedReason>
            {

                private const string _id = "BTX.19";
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
                /// BTX.19.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
                /// </summary>
                public class Identifier : HL7Base<Identifier>
                {

                    private const string _id = "BTX.19.1";
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
                /// BTX.19.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
                /// </summary>
                public class Text : HL7Base<Text>
                {

                    private const string _id = "BTX.19.2";
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
                /// BTX.19.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
                /// </summary>
                public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
                {

                    private const string _id = "BTX.19.3";
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
                /// BTX.19.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
                /// </summary>
                public class AlternateIdentifier : HL7Base<AlternateIdentifier>
                {

                    private const string _id = "BTX.19.4";
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
                /// BTX.19.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
                /// </summary>
                public class AlternateText : HL7Base<AlternateText>
                {

                    private const string _id = "BTX.19.5";
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
                /// BTX.19.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
                /// </summary>
                public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
                {

                    private const string _id = "BTX.19.6";
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
                /// BTX.19.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
                /// </summary>
                public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
                {

                    private const string _id = "BTX.19.7";
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
                /// BTX.19.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
                /// </summary>
                public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
                {

                    private const string _id = "BTX.19.8";
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
                /// BTX.19.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
                /// </summary>
                public class OriginalText : HL7Base<OriginalText>
                {

                    private const string _id = "BTX.19.9";
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
                /// BTX.19.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
                /// </summary>
                public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
                {

                    private const string _id = "BTX.19.10";
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
                /// BTX.19.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
                /// </summary>
                public class SecondAlternateText : HL7Base<SecondAlternateText>
                {

                    private const string _id = "BTX.19.11";
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
                /// BTX.19.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
                /// </summary>
                public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
                {

                    private const string _id = "BTX.19.12";
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
                /// BTX.19.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
                /// </summary>
                public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
                {

                    private const string _id = "BTX.19.13";
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
                /// BTX.19.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
                /// </summary>
                public class CodingSystemOid : HL7Base<CodingSystemOid>
                {

                    private const string _id = "BTX.19.14";
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
                /// BTX.19.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class ValueSetOid : HL7Base<ValueSetOid>
                {

                    private const string _id = "BTX.19.15";
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
                /// BTX.19.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
                /// </summary>
                public class ValueSetVersionId : HL7Base<ValueSetVersionId>
                {

                    private const string _id = "BTX.19.16";
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
                /// BTX.19.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
                /// </summary>
                public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
                {

                    private const string _id = "BTX.19.17";
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
                /// BTX.19.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
                {

                    private const string _id = "BTX.19.18";
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
                /// BTX.19.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
                /// </summary>
                public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
                {

                    private const string _id = "BTX.19.19";
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
                /// BTX.19.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
                /// </summary>
                public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
                {

                    private const string _id = "BTX.19.20";
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
                /// BTX.19.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
                {

                    private const string _id = "BTX.19.21";
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
                /// BTX.19.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
                /// </summary>
                public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
                {

                    private const string _id = "BTX.19.22";
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
            /// BTX.20 - This field is a unique system-generated number assigned to the blood product to which the message is referring.  Each time the status is updated, the new message should replace the previous message if the Blood Product Unique ID is the same.  If the Blood Product Unique ID is different, it indicates that the status applies to a different blood product.
            /// </summary>
            public class BPUniqueID : HL7Base<BPUniqueID>
            {

                private const string _id = "BTX.20";
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
                /// BTX.20.1 - The first component, entity identifier, is usually defined to be unique within the series of identifiers created by the assigning authority, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, "HD - hierarchic designator".
                /// </summary>
                public class EntityIdentifier : HL7Base<EntityIdentifier>
                {

                    private const string _id = "BTX.20.1";
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
                /// BTX.20.2 - See Section 2.A.33.1, "Namespace ID (IS)" for definition. The component intentionally remains associated with the IS data type in v 2.7.The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363  Assigning Authority for suggested values.Note When the HD is used as a part of another data type, in this case as part of the EI data type, this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment. By site agreement, implementers may continue to use User-defined Table 0300  Namespace ID for the first component
                /// </summary>
                public class NamespaceId : HL7Base<NamespaceId>
                {

                    private const string _id = "BTX.20.2";
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
                /// BTX.20.3 - See Section 2.A.33.2, "Universal ID (ST)" for definition.
                /// </summary>
                public class UniversalId : HL7Base<UniversalId>
                {

                    private const string _id = "BTX.20.3";
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
                /// BTX.20.4 - Refer to HL7 Table 0301 - Universal ID Type for valid values. See Section 2.A.33.3, "Universal ID Type (ID)," for definition.
                /// </summary>
                public class UniversalIdType : HL7Base<UniversalIdType>
                {

                    private const string _id = "BTX.20.4";
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

