using Newtonsoft.Json;
namespace HL7Parser
{
    public partial class Mappings
    {
        /// <summary>
        /// The AFF segment adds detailed information regarding professional affiliations with which the staff member identified by the STF segment is/was associated.  
        /// </summary>
        public class AFF
        {

            public const string Id = "AFF";

            /// <summary>
            /// AFF.1 - This field contains the number that identifies this transaction.  For the first occurrence of the segment, the sequence number shall be one for the second occurrence, the sequence number shall be two etc.
            /// </summary>
            public class SetIdAff : HL7Base<SetIdAff>
            {

                private const string _id = "AFF.1";
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
            /// AFF.2 - This field contains the official name of the association promoting specific professional interests with which the staff member is affiliated.
            /// </summary>
            public class ProfessionalOrganization : HL7Base<ProfessionalOrganization>
            {

                private const string _id = "AFF.2";
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
                /// AFF.2.1 - The name of the specified organization.
                /// </summary>
                public class OrganizationName : HL7Base<OrganizationName>
                {

                    private const string _id = "AFF.2.1";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// AFF.2.2 - A code that represents the type of name i.e., legal name, display name. Refer to User-defined Table 0204 - Organizational Name Type for suggested values.
                /// </summary>
                public class OrganizationNameTypeCode : HL7Base<OrganizationNameTypeCode>
                {

                    private const string _id = "AFF.2.2";
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
                    /// AFF.2.2.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
                    /// </summary>
                    public class Identifier : HL7Base<Identifier>
                    {

                        private const string _id = "AFF.2.2.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.2.2.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
                    /// </summary>
                    public class Text : HL7Base<Text>
                    {

                        private const string _id = "AFF.2.2.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.2.2.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
                    /// </summary>
                    public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
                    {

                        private const string _id = "AFF.2.2.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.2.2.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
                    /// </summary>
                    public class AlternateIdentifier : HL7Base<AlternateIdentifier>
                    {

                        private const string _id = "AFF.2.2.4";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.2.2.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
                    /// </summary>
                    public class AlternateText : HL7Base<AlternateText>
                    {

                        private const string _id = "AFF.2.2.5";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.2.2.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
                    {

                        private const string _id = "AFF.2.2.6";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.2.2.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
                    /// </summary>
                    public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
                    {

                        private const string _id = "AFF.2.2.7";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.2.2.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
                    {

                        private const string _id = "AFF.2.2.8";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.2.2.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
                    /// </summary>
                    public class OriginalText : HL7Base<OriginalText>
                    {

                        private const string _id = "AFF.2.2.9";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.2.2.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
                    /// </summary>
                    public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
                    {

                        private const string _id = "AFF.2.2.10";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.2.2.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
                    /// </summary>
                    public class SecondAlternateText : HL7Base<SecondAlternateText>
                    {

                        private const string _id = "AFF.2.2.11";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.2.2.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
                    {

                        private const string _id = "AFF.2.2.12";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.2.2.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
                    {

                        private const string _id = "AFF.2.2.13";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.2.2.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
                    /// </summary>
                    public class CodingSystemOid : HL7Base<CodingSystemOid>
                    {

                        private const string _id = "AFF.2.2.14";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.2.2.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class ValueSetOid : HL7Base<ValueSetOid>
                    {

                        private const string _id = "AFF.2.2.15";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.2.2.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
                    /// </summary>
                    public class ValueSetVersionId : HL7Base<ValueSetVersionId>
                    {

                        private const string _id = "AFF.2.2.16";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.2.2.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
                    /// </summary>
                    public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
                    {

                        private const string _id = "AFF.2.2.17";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.2.2.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
                    {

                        private const string _id = "AFF.2.2.18";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.2.2.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
                    /// </summary>
                    public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
                    {

                        private const string _id = "AFF.2.2.19";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.2.2.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
                    /// </summary>
                    public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
                    {

                        private const string _id = "AFF.2.2.20";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.2.2.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
                    {

                        private const string _id = "AFF.2.2.21";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.2.2.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
                    /// </summary>
                    public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
                    {

                        private const string _id = "AFF.2.2.22";
                        public override string Id
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
                /// AFF.2.3 - Attention The XON.3 component was deprecated as of v 2.5 and the detail was withdrawn and removed from the standard as of v 2.7. Refer to XON.10 Organization Identifier.
                /// </summary>
                public class IdNumber : HL7Base<IdNumber>
                {

                    private const string _id = "AFF.2.3";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// AFF.2.4 - Attention The XON.4 component was deprecated as of v 2.5 and the detail was withdrawn and removed from the standard as of v 2.7.
                /// </summary>
                public class IdentifierCheckDigit : HL7Base<IdentifierCheckDigit>
                {

                    private const string _id = "AFF.2.4";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// AFF.2.5 - Attention The XON.5 component was deprecated as of v 2.5 and the detail was withdrawn and removed from the standard as of v 2.7.
                /// </summary>
                public class CheckDigitScheme : HL7Base<CheckDigitScheme>
                {

                    private const string _id = "AFF.2.5";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// AFF.2.6 - The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Assigning authorities are unique across a given HL7 implementation. Refer to User-defined Table 0363 - Assigning Authority for suggested values. Note When the HD data type is used in a given segment as a component of a field of another data type, User-defined Table 0300 - Namespace ID (referenced by the first sub-component of the HD component) may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.By site agreement, implementers may continue to use User-defined Table 0300  Namespace ID for the first sub-component.
                /// </summary>
                public class AssigningAuthority : HL7Base<AssigningAuthority>
                {

                    private const string _id = "AFF.2.6";
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
                    /// AFF.2.6.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
                    /// </summary>
                    public class NamespaceId : HL7Base<NamespaceId>
                    {

                        private const string _id = "AFF.2.6.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.2.6.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
                    /// </summary>
                    public class UniversalId : HL7Base<UniversalId>
                    {

                        private const string _id = "AFF.2.6.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.2.6.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
                    /// </summary>
                    public class UniversalIdType : HL7Base<UniversalIdType>
                    {

                        private const string _id = "AFF.2.6.3";
                        public override string Id
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
                /// AFF.2.7 - A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the "Assigning authority" component. Refer to HL7 Table 0203 - Identifier Type for suggested values.
                /// </summary>
                public class IdentifierTypeCode : HL7Base<IdentifierTypeCode>
                {

                    private const string _id = "AFF.2.7";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// AFF.2.8 - The place or location identifier where the identifier was first assigned to the person. This component is not an inherent part of the identifier but rather part of the history of the identifier as part of this data type, its existence is a convenience for certain intercommunicating systems.Note When the HD data type is used in a given segment as a component of a field of another data type, User-defined Table 0300 - Namespace ID (referenced by the first sub-component of the HD component) may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
                /// </summary>
                public class AssigningFacility : HL7Base<AssigningFacility>
                {

                    private const string _id = "AFF.2.8";
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
                    /// AFF.2.8.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
                    /// </summary>
                    public class NamespaceId : HL7Base<NamespaceId>
                    {

                        private const string _id = "AFF.2.8.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.2.8.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
                    /// </summary>
                    public class UniversalId : HL7Base<UniversalId>
                    {

                        private const string _id = "AFF.2.8.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.2.8.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
                    /// </summary>
                    public class UniversalIdType : HL7Base<UniversalIdType>
                    {

                        private const string _id = "AFF.2.8.3";
                        public override string Id
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
                /// AFF.2.9 - Different name/address types and representations of the same name/address should be described by repeating of this field, with different values of the name/address type and/or name/address representation component.Note This new component remains in alphabetic representation with each repetition of the field using these data types, i.e. even though the name may be represented in an ideographic character set, this component will remain represented in an alphabetic character set.Refer to HL7 Table 0465  Name/address Representation Code for valid values.In general this component provides an indication of the representation provided by the data item. It does not necessarily specify the character sets used. Thus, even though the representation might provide an indication of what to expect, the sender is still free to encode the contents using whatever character set is desired. This component provides only hints for the receiver, so it can make choices regarding what it has been sent and what it is capable of displaying.
                /// </summary>
                public class NameRepresentationCode : HL7Base<NameRepresentationCode>
                {

                    private const string _id = "AFF.2.9";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// AFF.2.10 - This component contains the sequence of characters (the code) that uniquely identifies the item being referenced by XON.1 Organization Name. This component replaces XON.3 ID Number as of v 2.5.Note The check digit and code identifying check digit scheme are null if Organization identifier is alphanumeric.
                /// </summary>
                public class OrganizationIdentifier : HL7Base<OrganizationIdentifier>
                {

                    private const string _id = "AFF.2.10";
                    public override string Id
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
            /// AFF.3 - This field contains the postal address of the professional organization with which the Staff Member is associated.
            /// </summary>
            public class ProfessionalOrganizationAddress : HL7Base<ProfessionalOrganizationAddress>
            {

                private const string _id = "AFF.3";
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
                /// AFF.3.1 - This component contains the house number, apartment number, street name, street direction, P.O. Box number, and similar address information. 
                /// </summary>
                public class StreetAddress : HL7Base<StreetAddress>
                {

                    private const string _id = "AFF.3.1";
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
                    /// AFF.3.1.1 - This component specifies the street or mailing address of a person or institution. When referencing an institution, this first component is used to specify the institution name. When used in connection with a person, this component specifies the first line of the address.
                    /// </summary>
                    public class StreetOrMailingAddress : HL7Base<StreetOrMailingAddress>
                    {

                        private const string _id = "AFF.3.1.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.1.2 - 
                    /// </summary>
                    public class StreetName : HL7Base<StreetName>
                    {

                        private const string _id = "AFF.3.1.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.1.3 - 
                    /// </summary>
                    public class DwellingNumber : HL7Base<DwellingNumber>
                    {

                        private const string _id = "AFF.3.1.3";
                        public override string Id
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
                /// AFF.3.2 - This component contains the second line of address. In US usage, it qualifies address. Examples Suite 555 or Fourth Floor. When referencing an institution, this component specifies the street address.
                /// </summary>
                public class OtherDesignation : HL7Base<OtherDesignation>
                {

                    private const string _id = "AFF.3.2";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// AFF.3.3 - This component specifies the city, or district or place where the addressee is located depending upon the national convention for formatting addresses for postal usage.
                /// </summary>
                public class City : HL7Base<City>
                {

                    private const string _id = "AFF.3.3";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// AFF.3.4 - This component specifies the state or province where the addressee is located. State or province should be represented by the official postal service codes for that country.
                /// </summary>
                public class StateOrProvince : HL7Base<StateOrProvince>
                {

                    private const string _id = "AFF.3.4";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// AFF.3.5 - This component specifies the zip or postal code where the addressee is located. Zip or postal codes should be represented by the official codes for that country. In the US, the zip code takes the form 99999-9999, while the Canadian postal code takes the form A9A9A9, and the Australian Postcode takes the form 9999.
                /// </summary>
                public class ZipOrPostalCode : HL7Base<ZipOrPostalCode>
                {

                    private const string _id = "AFF.3.5";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// AFF.3.6 - This component specifies the country where the addressee is located.  HL7 specifies that the 3-character (alphabetic) form of ISO 3166 be used for the country code. Refer to HL7 Table 0399  Country Code for valid values.
                /// </summary>
                public class Country : HL7Base<Country>
                {

                    private const string _id = "AFF.3.6";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// AFF.3.7 - This component specifies the kind or type of address. Refer to HL7 Table 0190 - Address Type for valid values.XAD.7 is required if there are multiple occurrences of XAD in a field.
                /// </summary>
                public class AddressType : HL7Base<AddressType>
                {

                    private const string _id = "AFF.3.7";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// AFF.3.8 - This component specifies any other geographic designation. It includes county, bioregion, SMSA, etc.
                /// </summary>
                public class OtherGeographicDesignation : HL7Base<OtherGeographicDesignation>
                {

                    private const string _id = "AFF.3.8";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// AFF.3.9 - A code that represents the county in which the specified address resides. User-defined Table 0289 - County/parish is used as the HL7 identifier for the user-defined table of values for this component. When this component is used to represent the county (or parish), component 8 other geographic designation should not duplicate it (i.e., the use of other geographic designation to represent the county is allowed only for the purpose of backward compatibility, and should be discouraged in this and future versions of HL7).Allowable values codes defined by government.
                /// </summary>
                public class CountyParishCode : HL7Base<CountyParishCode>
                {

                    private const string _id = "AFF.3.9";
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
                    /// AFF.3.9.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
                    /// </summary>
                    public class Identifier : HL7Base<Identifier>
                    {

                        private const string _id = "AFF.3.9.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.9.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
                    /// </summary>
                    public class Text : HL7Base<Text>
                    {

                        private const string _id = "AFF.3.9.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.9.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
                    /// </summary>
                    public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
                    {

                        private const string _id = "AFF.3.9.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.9.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
                    /// </summary>
                    public class AlternateIdentifier : HL7Base<AlternateIdentifier>
                    {

                        private const string _id = "AFF.3.9.4";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.9.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
                    /// </summary>
                    public class AlternateText : HL7Base<AlternateText>
                    {

                        private const string _id = "AFF.3.9.5";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.9.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
                    {

                        private const string _id = "AFF.3.9.6";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.9.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
                    /// </summary>
                    public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
                    {

                        private const string _id = "AFF.3.9.7";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.9.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
                    {

                        private const string _id = "AFF.3.9.8";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.9.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
                    /// </summary>
                    public class OriginalText : HL7Base<OriginalText>
                    {

                        private const string _id = "AFF.3.9.9";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.9.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
                    /// </summary>
                    public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
                    {

                        private const string _id = "AFF.3.9.10";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.9.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
                    /// </summary>
                    public class SecondAlternateText : HL7Base<SecondAlternateText>
                    {

                        private const string _id = "AFF.3.9.11";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.9.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
                    {

                        private const string _id = "AFF.3.9.12";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.9.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
                    {

                        private const string _id = "AFF.3.9.13";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.9.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
                    /// </summary>
                    public class CodingSystemOid : HL7Base<CodingSystemOid>
                    {

                        private const string _id = "AFF.3.9.14";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.9.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class ValueSetOid : HL7Base<ValueSetOid>
                    {

                        private const string _id = "AFF.3.9.15";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.9.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
                    /// </summary>
                    public class ValueSetVersionId : HL7Base<ValueSetVersionId>
                    {

                        private const string _id = "AFF.3.9.16";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.9.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
                    /// </summary>
                    public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
                    {

                        private const string _id = "AFF.3.9.17";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.9.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
                    {

                        private const string _id = "AFF.3.9.18";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.9.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
                    /// </summary>
                    public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
                    {

                        private const string _id = "AFF.3.9.19";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.9.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
                    /// </summary>
                    public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
                    {

                        private const string _id = "AFF.3.9.20";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.9.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
                    {

                        private const string _id = "AFF.3.9.21";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.9.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
                    /// </summary>
                    public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
                    {

                        private const string _id = "AFF.3.9.22";
                        public override string Id
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
                /// AFF.3.10 - A code that represents the census tract in which the specified address resides. User-defined Table 0288 - Census Tract is used as the HL7 identifier for the user-defined table of values for this component.Allowable Values codes defined by government.
                /// </summary>
                public class CensusTract : HL7Base<CensusTract>
                {

                    private const string _id = "AFF.3.10";
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
                    /// AFF.3.10.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
                    /// </summary>
                    public class Identifier : HL7Base<Identifier>
                    {

                        private const string _id = "AFF.3.10.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.10.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
                    /// </summary>
                    public class Text : HL7Base<Text>
                    {

                        private const string _id = "AFF.3.10.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.10.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
                    /// </summary>
                    public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
                    {

                        private const string _id = "AFF.3.10.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.10.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
                    /// </summary>
                    public class AlternateIdentifier : HL7Base<AlternateIdentifier>
                    {

                        private const string _id = "AFF.3.10.4";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.10.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
                    /// </summary>
                    public class AlternateText : HL7Base<AlternateText>
                    {

                        private const string _id = "AFF.3.10.5";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.10.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
                    {

                        private const string _id = "AFF.3.10.6";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.10.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
                    /// </summary>
                    public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
                    {

                        private const string _id = "AFF.3.10.7";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.10.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
                    {

                        private const string _id = "AFF.3.10.8";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.10.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
                    /// </summary>
                    public class OriginalText : HL7Base<OriginalText>
                    {

                        private const string _id = "AFF.3.10.9";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.10.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
                    /// </summary>
                    public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
                    {

                        private const string _id = "AFF.3.10.10";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.10.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
                    /// </summary>
                    public class SecondAlternateText : HL7Base<SecondAlternateText>
                    {

                        private const string _id = "AFF.3.10.11";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.10.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
                    {

                        private const string _id = "AFF.3.10.12";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.10.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
                    {

                        private const string _id = "AFF.3.10.13";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.10.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
                    /// </summary>
                    public class CodingSystemOid : HL7Base<CodingSystemOid>
                    {

                        private const string _id = "AFF.3.10.14";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.10.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class ValueSetOid : HL7Base<ValueSetOid>
                    {

                        private const string _id = "AFF.3.10.15";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.10.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
                    /// </summary>
                    public class ValueSetVersionId : HL7Base<ValueSetVersionId>
                    {

                        private const string _id = "AFF.3.10.16";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.10.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
                    /// </summary>
                    public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
                    {

                        private const string _id = "AFF.3.10.17";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.10.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
                    {

                        private const string _id = "AFF.3.10.18";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.10.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
                    /// </summary>
                    public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
                    {

                        private const string _id = "AFF.3.10.19";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.10.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
                    /// </summary>
                    public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
                    {

                        private const string _id = "AFF.3.10.20";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.10.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
                    {

                        private const string _id = "AFF.3.10.21";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.10.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
                    /// </summary>
                    public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
                    {

                        private const string _id = "AFF.3.10.22";
                        public override string Id
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
                /// AFF.3.11 - Different name/address types and representations of the same name/address should be described by repeating of this field, with different values of the name/address type and/or name/address representation component.Note Also note that this new component remains in "alphabetic" representation with each repetition of the fields using these data types. I.e. even though the address may be represented in an ideographic character set, this component will remain represented in an alphabetic character set.Refer to HL7 Table 0465  Name/address Representation for valid values.In general this component provides an indication of the representation provided by the data item. It does not necessarily specify the character sets used. Thus, even though the representation might provide an indication of what to expect, the sender is still free to encode the contents using whatever character set is desired. This component provides only hints for the receiver, so it can make choices regarding what it has been sent and what it is capable of displaying.
                /// </summary>
                public class AddressRepresentationCode : HL7Base<AddressRepresentationCode>
                {

                    private const string _id = "AFF.3.11";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// AFF.3.12 - Attention The XAD.12 component was retained for backward compatibility as of v2.5 and the detail was withdrawn and removed from the standard as of v2.7. Refer to 2.A.86.13, "Effective Date (DTM)" and 2.A.86.14, "Expiration Date (DTM)" components.
                /// </summary>
                public class AddressValidityRange : HL7Base<AddressValidityRange>
                {

                    private const string _id = "AFF.3.12";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// AFF.3.13 - The first date, if known, on which the address is valid and active for the owning entity.
                /// </summary>
                public class EffectiveDate : HL7Base<EffectiveDate>
                {

                    private const string _id = "AFF.3.13";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// AFF.3.14 - The last date, if known, on which the address is valid and active for the owning entity.
                /// </summary>
                public class ExpirationDate : HL7Base<ExpirationDate>
                {

                    private const string _id = "AFF.3.14";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// AFF.3.15 - This identifies why this address was marked as "ended".   Refer to User-defined Table 0616  Address Expiration Reason for valid values.
                /// </summary>
                public class ExpirationReason : HL7Base<ExpirationReason>
                {

                    private const string _id = "AFF.3.15";
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
                    /// AFF.3.15.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
                    /// </summary>
                    public class Identifier : HL7Base<Identifier>
                    {

                        private const string _id = "AFF.3.15.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.15.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
                    /// </summary>
                    public class Text : HL7Base<Text>
                    {

                        private const string _id = "AFF.3.15.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.15.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
                    /// </summary>
                    public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
                    {

                        private const string _id = "AFF.3.15.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.15.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
                    /// </summary>
                    public class AlternateIdentifier : HL7Base<AlternateIdentifier>
                    {

                        private const string _id = "AFF.3.15.4";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.15.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
                    /// </summary>
                    public class AlternateText : HL7Base<AlternateText>
                    {

                        private const string _id = "AFF.3.15.5";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.15.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
                    {

                        private const string _id = "AFF.3.15.6";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.15.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
                    /// </summary>
                    public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
                    {

                        private const string _id = "AFF.3.15.7";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.15.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
                    {

                        private const string _id = "AFF.3.15.8";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.15.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
                    /// </summary>
                    public class OriginalText : HL7Base<OriginalText>
                    {

                        private const string _id = "AFF.3.15.9";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.15.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
                    /// </summary>
                    public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
                    {

                        private const string _id = "AFF.3.15.10";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.15.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
                    /// </summary>
                    public class SecondAlternateText : HL7Base<SecondAlternateText>
                    {

                        private const string _id = "AFF.3.15.11";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.15.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
                    {

                        private const string _id = "AFF.3.15.12";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.15.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
                    {

                        private const string _id = "AFF.3.15.13";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.15.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
                    /// </summary>
                    public class CodingSystemOid : HL7Base<CodingSystemOid>
                    {

                        private const string _id = "AFF.3.15.14";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.15.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class ValueSetOid : HL7Base<ValueSetOid>
                    {

                        private const string _id = "AFF.3.15.15";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.15.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
                    /// </summary>
                    public class ValueSetVersionId : HL7Base<ValueSetVersionId>
                    {

                        private const string _id = "AFF.3.15.16";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.15.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
                    /// </summary>
                    public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
                    {

                        private const string _id = "AFF.3.15.17";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.15.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
                    {

                        private const string _id = "AFF.3.15.18";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.15.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
                    /// </summary>
                    public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
                    {

                        private const string _id = "AFF.3.15.19";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.15.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
                    /// </summary>
                    public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
                    {

                        private const string _id = "AFF.3.15.20";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.15.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
                    {

                        private const string _id = "AFF.3.15.21";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.15.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
                    /// </summary>
                    public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
                    {

                        private const string _id = "AFF.3.15.22";
                        public override string Id
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
                /// AFF.3.16 - If "Y" this indicates that the address is considered temporary.  Refer to HL7 Table 0136  Yes/No Indicator.
                /// </summary>
                public class TemporaryIndicator : HL7Base<TemporaryIndicator>
                {

                    private const string _id = "AFF.3.16";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// AFF.3.17 - If "Y", this indicates that it is not possible to contact the "owning" entity at this address. Refer to HL7 Table 0136  Yes/No Indicator.
                /// </summary>
                public class BadAddressIndicator : HL7Base<BadAddressIndicator>
                {

                    private const string _id = "AFF.3.17";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// AFF.3.18 - This indicates how the address is intended to be used.  Refer to User-defined Table 0617  Address Usage for valid values.
                /// </summary>
                public class AddressUsage : HL7Base<AddressUsage>
                {

                    private const string _id = "AFF.3.18";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// AFF.3.19 - Identifies the name of the person or organization that should appear as part of the address. This is also known as the "Care of" or "C/O" line.
                /// </summary>
                public class Addressee : HL7Base<Addressee>
                {

                    private const string _id = "AFF.3.19";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// AFF.3.20 - Descriptive information about the use of the address.Example "Do not ring bell."
                /// </summary>
                public class Comment : HL7Base<Comment>
                {

                    private const string _id = "AFF.3.20";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// AFF.3.21 - For an entity having multiple addresses, indicates which is the 'most preferred' (lowest number) to 'least preferred' (highest number).If the preference order is unique across all usages for a given type, then it indicates the preference across all usages, (e.g., first try my home address, then my business address). Otherwise, the preference order is assumed to only apply within a specific usage.Preference order numbers need not be sequential (i.e., four addresses with the priority orders of 10, 1, 5 and 15 are legitimate). The preference order numbers must be non-negative.
                /// </summary>
                public class PreferenceOrder : HL7Base<PreferenceOrder>
                {

                    private const string _id = "AFF.3.21";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// AFF.3.22 - Identifies that an address needs to be treated with special care or sensitivity.The specific set of codes and appropriate handling of such addresses will vary by jurisdiction and is subject to site-specific negotiation. For example, a provider address marked as 'unlisted' might not be printed in an internal address listing.  Refer to User-defined Table 0618  Protection Code for valid values.
                /// </summary>
                public class ProtectionCode : HL7Base<ProtectionCode>
                {

                    private const string _id = "AFF.3.22";
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
                    /// AFF.3.22.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
                    /// </summary>
                    public class Identifier : HL7Base<Identifier>
                    {

                        private const string _id = "AFF.3.22.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.22.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
                    /// </summary>
                    public class Text : HL7Base<Text>
                    {

                        private const string _id = "AFF.3.22.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.22.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
                    /// </summary>
                    public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
                    {

                        private const string _id = "AFF.3.22.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.22.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
                    /// </summary>
                    public class AlternateIdentifier : HL7Base<AlternateIdentifier>
                    {

                        private const string _id = "AFF.3.22.4";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.22.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
                    /// </summary>
                    public class AlternateText : HL7Base<AlternateText>
                    {

                        private const string _id = "AFF.3.22.5";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.22.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
                    {

                        private const string _id = "AFF.3.22.6";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.22.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
                    /// </summary>
                    public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
                    {

                        private const string _id = "AFF.3.22.7";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.22.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
                    {

                        private const string _id = "AFF.3.22.8";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.22.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
                    /// </summary>
                    public class OriginalText : HL7Base<OriginalText>
                    {

                        private const string _id = "AFF.3.22.9";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.22.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
                    /// </summary>
                    public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
                    {

                        private const string _id = "AFF.3.22.10";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.22.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
                    /// </summary>
                    public class SecondAlternateText : HL7Base<SecondAlternateText>
                    {

                        private const string _id = "AFF.3.22.11";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.22.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
                    {

                        private const string _id = "AFF.3.22.12";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.22.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
                    {

                        private const string _id = "AFF.3.22.13";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.22.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
                    /// </summary>
                    public class CodingSystemOid : HL7Base<CodingSystemOid>
                    {

                        private const string _id = "AFF.3.22.14";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.22.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class ValueSetOid : HL7Base<ValueSetOid>
                    {

                        private const string _id = "AFF.3.22.15";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.22.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
                    /// </summary>
                    public class ValueSetVersionId : HL7Base<ValueSetVersionId>
                    {

                        private const string _id = "AFF.3.22.16";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.22.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
                    /// </summary>
                    public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
                    {

                        private const string _id = "AFF.3.22.17";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.22.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
                    {

                        private const string _id = "AFF.3.22.18";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.22.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
                    /// </summary>
                    public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
                    {

                        private const string _id = "AFF.3.22.19";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.22.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
                    /// </summary>
                    public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
                    {

                        private const string _id = "AFF.3.22.20";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.22.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
                    {

                        private const string _id = "AFF.3.22.21";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.22.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
                    /// </summary>
                    public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
                    {

                        private const string _id = "AFF.3.22.22";
                        public override string Id
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
                /// AFF.3.23 - A unique identifier for the address.This component allows an address to be uniquely identified, and enables the linking of a single address to multiple people and contexts. For example, each member of a family living at the same location would share the same address, having the same identifier. A correction to the address of one family member could be automatically propagated to other members of the family.
                /// </summary>
                public class AddressIdentifier : HL7Base<AddressIdentifier>
                {

                    private const string _id = "AFF.3.23";
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
                    /// AFF.3.23.1 - The first component, entity identifier, is usually defined to be unique within the series of identifiers created by the assigning authority, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, "HD - hierarchic designator".
                    /// </summary>
                    public class EntityIdentifier : HL7Base<EntityIdentifier>
                    {

                        private const string _id = "AFF.3.23.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.23.2 - See Section 2.A.33.1, "Namespace ID (IS)" for definition. The component intentionally remains associated with the IS data type in v 2.7.The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363  Assigning Authority for suggested values.Note When the HD is used as a part of another data type, in this case as part of the EI data type, this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment. By site agreement, implementers may continue to use User-defined Table 0300  Namespace ID for the first component
                    /// </summary>
                    public class NamespaceId : HL7Base<NamespaceId>
                    {

                        private const string _id = "AFF.3.23.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.23.3 - See Section 2.A.33.2, "Universal ID (ST)" for definition.
                    /// </summary>
                    public class UniversalId : HL7Base<UniversalId>
                    {

                        private const string _id = "AFF.3.23.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// AFF.3.23.4 - Refer to HL7 Table 0301 - Universal ID Type for valid values. See Section 2.A.33.3, "Universal ID Type (ID)," for definition.
                    /// </summary>
                    public class UniversalIdType : HL7Base<UniversalIdType>
                    {

                        private const string _id = "AFF.3.23.4";
                        public override string Id
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
            /// AFF.4 - This field contains the period the staff member started and ended membership in the professional organization.
            /// </summary>
            public class ProfessionalOrganizationAffiliationDateRange : HL7Base<ProfessionalOrganizationAffiliationDateRange>
            {

                private const string _id = "AFF.4";
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
                /// AFF.4.1 - The first component contains the earliest date/time (time stamp) in the specified range.
                /// </summary>
                public class RangeStartDateTime : HL7Base<RangeStartDateTime>
                {

                    private const string _id = "AFF.4.1";
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
                /// AFF.4.2 - The second component contains the latest date/time in the specified range. Note that the DTM (time stamp) data type allows the specification of precision.
                /// </summary>
                public class RangeEndDateTime : HL7Base<RangeEndDateTime>
                {

                    private const string _id = "AFF.4.2";
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
            /// AFF.5 - This field contains miscellaneous additional information related to the staff member's membership in the professional organization.
            /// </summary>
            public class ProfessionalAffiliationAdditionalInformation : HL7Base<ProfessionalAffiliationAdditionalInformation>
            {

                private const string _id = "AFF.5";
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

        }
    }
}

