using Newtonsoft.Json;
namespace HL7Parser
{
    public partial class Mappings
    {
        /// <summary>
        /// The BLG segment is used to provide billing information, on the ordered service, to the filling application.
        /// </summary>
        public class BLG
        {

            public const string Id = "BLG";

            /// <summary>
            /// BLG.1 - This field specifies when to charge for the ordered service. Refer to HL7 Table 0100  Invocation event for valid values.
            /// </summary>
            public class WhenToCharge : HL7Base<WhenToCharge>
            {

                private const string _id = "BLG.1";
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
                /// BLG.1.1 - Specifies the code for the event precipitating/triggering the charge activity. Refer to HL7 Table 0100 - Invocation event for valid values.
                /// </summary>
                public class InvocationEvent : HL7Base<InvocationEvent>
                {

                    private const string _id = "BLG.1.1";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BLG.1.2 - The second component is used to express the exact time to charge for the ordered service it is used only when the CCD.1 value is T. When used, it is expressed as a DTM data type.
                /// </summary>
                public class DateTime : HL7Base<DateTime>
                {

                    private const string _id = "BLG.1.2";
                    public override string Id
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
            /// BLG.2 - This field identifies someone or something other than the patient to be billed for this service. It is used in conjunction with BLG-3-account ID. Refer to HL7 Table 0122  Charge Type for valid values.
            /// </summary>
            public class ChargeType : HL7Base<ChargeType>
            {

                private const string _id = "BLG.2";
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
            /// BLG.3 - This field identifies the account to be billed. It is used in conjunction with BLG-2-charge type. Refer to HL7 table 0061  Check digit scheme in Chapter 2.
            /// </summary>
            public class AccountId : HL7Base<AccountId>
            {

                private const string _id = "BLG.3";
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
                /// BLG.3.1 - The value of the identifier itself.
                /// </summary>
                public class IdNumber : HL7Base<IdNumber>
                {

                    private const string _id = "BLG.3.1";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BLG.3.2 - A digit, or digits, exclusive of the identifier in CX.1, calculated by applying an algorithm to all or some of the digits in the number, which may be used to test validity of the non-check-digit identifier.
                /// </summary>
                public class IdentifierCheckDigit : HL7Base<IdentifierCheckDigit>
                {

                    private const string _id = "BLG.3.2";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BLG.3.3 - Contains the code identifying the check digit scheme employed.Refer to HL7 Table 0061 - Check Digit Scheme for valid values.Note The check digit and code identifying check digit scheme are null if ID is alphanumeric.
                /// </summary>
                public class CheckDigitScheme : HL7Base<CheckDigitScheme>
                {

                    private const string _id = "BLG.3.3";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BLG.3.4 - The assigning authority is a unique name of the system (or organization or agency or department) that creates the data. As of v2.7, CX.4 Assigning Authority is required if neither CX.9 nor CX.10 are populated. Best practice is to always send an OID in the Assigning Authority componentRefer to User-defined Table 0363 - Assigning Authority for suggested values.The reader is referred to the CX.9 and the CX.10 if there is a need to transmit values with semantic meaning for an assigning jurisdiction or assigning department or agency in addition to, or instead of, an assigning authority. However, all 3 components may be valued. If, in so doing, it is discovered that the values in CX.9 and/or CX.10 conflict with CX.4, the user would look to the Message Profile or other implementation agreement for a statement as to which takes precedence.Note When the HD data type is used in a given segment as a component of a field of another data type, User-defined Table 0300 - Namespace ID (referenced by the first sub-component of the HD component) may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.By site agreement, implementers may continue to use User-defined Table 0300  Namespace ID for the first sub-component.
                /// </summary>
                public class AssigningAuthority : HL7Base<AssigningAuthority>
                {

                    private const string _id = "BLG.3.4";
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
                    /// BLG.3.4.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
                    /// </summary>
                    public class NamespaceId : HL7Base<NamespaceId>
                    {

                        private const string _id = "BLG.3.4.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BLG.3.4.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
                    /// </summary>
                    public class UniversalId : HL7Base<UniversalId>
                    {

                        private const string _id = "BLG.3.4.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BLG.3.4.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
                    /// </summary>
                    public class UniversalIdType : HL7Base<UniversalIdType>
                    {

                        private const string _id = "BLG.3.4.3";
                        public override string Id
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
                /// BLG.3.5 - A code corresponding to the type of identifier. As of v2.7, CX.5 Identifier Type Code is required. Refer to HL7 Table 0203  Identifier Type for suggested values.
                /// </summary>
                public class IdentifierTypeCode : HL7Base<IdentifierTypeCode>
                {

                    private const string _id = "BLG.3.5";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BLG.3.6 - The place or location identifier where the identifier was first assigned to the patient. This component is not an inherent part of the identifier but rather part of the history of the identifier as part of this data type, its existence is a convenience for certain intercommunicating systems.Note When the HD data type is used in a given segment as a component of a field of another data type, User-defined Table 0300 - Namespace ID (referenced by the first sub-component of the HD component), may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
                /// </summary>
                public class AssigningFacility : HL7Base<AssigningFacility>
                {

                    private const string _id = "BLG.3.6";
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
                    /// BLG.3.6.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
                    /// </summary>
                    public class NamespaceId : HL7Base<NamespaceId>
                    {

                        private const string _id = "BLG.3.6.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BLG.3.6.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
                    /// </summary>
                    public class UniversalId : HL7Base<UniversalId>
                    {

                        private const string _id = "BLG.3.6.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BLG.3.6.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
                    /// </summary>
                    public class UniversalIdType : HL7Base<UniversalIdType>
                    {

                        private const string _id = "BLG.3.6.3";
                        public override string Id
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
                /// BLG.3.7 - The first date, if known, on which the identifier is valid and active.
                /// </summary>
                public class EffectiveDate : HL7Base<EffectiveDate>
                {

                    private const string _id = "BLG.3.7";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BLG.3.8 - The last date, if known, on which the identifier is valid and active.
                /// </summary>
                public class ExpirationDate : HL7Base<ExpirationDate>
                {

                    private const string _id = "BLG.3.8";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BLG.3.9 - The geo-political body that assigned the identifier in component 1. As of v2.7, Assigning Jurisdiction is required if neither CX.4 nor CX.10 are populated.  - Refer to HL7 Table 0399  Country Code for valid values if the administrative unit under whose jurisdiction the identifier was issued is a country. - Refer to User-Defined Table 0347  State/Province for suggested values if the administrative unit under whose jurisdiction the identifier was issued is a state or province. This table is country specific. In the US, postal codes may be used. - Refer to User-defined Table 0289 County/Parish for suggested values if the administrative unit under whose jurisdiction the identifier was issued is a county or parish.The reader is referred to the CX.4 if there is a need to transmit this information as an OID.
                /// </summary>
                public class AssigningJurisdiction : HL7Base<AssigningJurisdiction>
                {

                    private const string _id = "BLG.3.9";
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
                    /// BLG.3.9.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
                    /// </summary>
                    public class Identifier : HL7Base<Identifier>
                    {

                        private const string _id = "BLG.3.9.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BLG.3.9.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
                    /// </summary>
                    public class Text : HL7Base<Text>
                    {

                        private const string _id = "BLG.3.9.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BLG.3.9.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
                    /// </summary>
                    public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
                    {

                        private const string _id = "BLG.3.9.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BLG.3.9.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
                    /// </summary>
                    public class AlternateIdentifier : HL7Base<AlternateIdentifier>
                    {

                        private const string _id = "BLG.3.9.4";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BLG.3.9.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
                    /// </summary>
                    public class AlternateText : HL7Base<AlternateText>
                    {

                        private const string _id = "BLG.3.9.5";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BLG.3.9.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
                    {

                        private const string _id = "BLG.3.9.6";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BLG.3.9.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
                    /// </summary>
                    public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
                    {

                        private const string _id = "BLG.3.9.7";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BLG.3.9.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
                    {

                        private const string _id = "BLG.3.9.8";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BLG.3.9.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
                    /// </summary>
                    public class OriginalText : HL7Base<OriginalText>
                    {

                        private const string _id = "BLG.3.9.9";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BLG.3.9.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
                    /// </summary>
                    public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
                    {

                        private const string _id = "BLG.3.9.10";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BLG.3.9.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
                    /// </summary>
                    public class SecondAlternateText : HL7Base<SecondAlternateText>
                    {

                        private const string _id = "BLG.3.9.11";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BLG.3.9.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
                    {

                        private const string _id = "BLG.3.9.12";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BLG.3.9.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
                    {

                        private const string _id = "BLG.3.9.13";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BLG.3.9.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
                    /// </summary>
                    public class CodingSystemOid : HL7Base<CodingSystemOid>
                    {

                        private const string _id = "BLG.3.9.14";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BLG.3.9.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class ValueSetOid : HL7Base<ValueSetOid>
                    {

                        private const string _id = "BLG.3.9.15";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BLG.3.9.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
                    /// </summary>
                    public class ValueSetVersionId : HL7Base<ValueSetVersionId>
                    {

                        private const string _id = "BLG.3.9.16";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BLG.3.9.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
                    /// </summary>
                    public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
                    {

                        private const string _id = "BLG.3.9.17";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BLG.3.9.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
                    {

                        private const string _id = "BLG.3.9.18";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BLG.3.9.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
                    /// </summary>
                    public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
                    {

                        private const string _id = "BLG.3.9.19";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BLG.3.9.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
                    /// </summary>
                    public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
                    {

                        private const string _id = "BLG.3.9.20";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BLG.3.9.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
                    {

                        private const string _id = "BLG.3.9.21";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BLG.3.9.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
                    /// </summary>
                    public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
                    {

                        private const string _id = "BLG.3.9.22";
                        public override string Id
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
                /// BLG.3.10 - The agency or department that assigned the identifier in component 1. As of v2.7, Assigning Agency or Department is required if neither CX.4 nor CX.9 are populated.Refer to User-defined Table 0530  Organizations, agency, department for suggested values if the administrative unit under whose jurisdiction the identifier was issued is an organization, agency or department. This is populated with site-specific assigning authorities. It also should contain national or international codes when CX.5 Identifier Type Code may be assigned by more than one authority within a governmental or organizational unit. For example, a federal government may have 2 departments that assign a military identifier, its Veterans Affairs department and its Department of Defense. It is not recommended to include values for entities such as Social Security Administration (SSA), Immigration and Naturalization Service (INS), Center for Medicare and Medicaid Services (CMS) because they are included in the identifier type table. In these cases the name of the country plus the identifier type yields the correct interpretation of the identifier in component 1. Likewise, entries like department of motor vehicles (DMV) and licensing boards are not recommended for inclusion because the combination of state and identifier type yields the correct interpretation of the identifier in component 1. This approach is not to be confused with the detailed information provided in the Chapter 15 segments that have provision for specifying the precise granting body and issuing body information needed in personnel management messages.Example 1 Identifier plus Visa yields a unique identifier.Example 2 identifier plus state plus DLN yields a unique drivers license number.Example 3 identifier plus country plus INS yields a unique immigration number.The reader is referred to the CX.4, if there is a need to transmit this information as an OID.
                /// </summary>
                public class AssigningAgencyOrDepartment : HL7Base<AssigningAgencyOrDepartment>
                {

                    private const string _id = "BLG.3.10";
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
                    /// BLG.3.10.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
                    /// </summary>
                    public class Identifier : HL7Base<Identifier>
                    {

                        private const string _id = "BLG.3.10.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BLG.3.10.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
                    /// </summary>
                    public class Text : HL7Base<Text>
                    {

                        private const string _id = "BLG.3.10.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BLG.3.10.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
                    /// </summary>
                    public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
                    {

                        private const string _id = "BLG.3.10.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BLG.3.10.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
                    /// </summary>
                    public class AlternateIdentifier : HL7Base<AlternateIdentifier>
                    {

                        private const string _id = "BLG.3.10.4";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BLG.3.10.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
                    /// </summary>
                    public class AlternateText : HL7Base<AlternateText>
                    {

                        private const string _id = "BLG.3.10.5";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BLG.3.10.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
                    {

                        private const string _id = "BLG.3.10.6";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BLG.3.10.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
                    /// </summary>
                    public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
                    {

                        private const string _id = "BLG.3.10.7";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BLG.3.10.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
                    {

                        private const string _id = "BLG.3.10.8";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BLG.3.10.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
                    /// </summary>
                    public class OriginalText : HL7Base<OriginalText>
                    {

                        private const string _id = "BLG.3.10.9";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BLG.3.10.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
                    /// </summary>
                    public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
                    {

                        private const string _id = "BLG.3.10.10";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BLG.3.10.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
                    /// </summary>
                    public class SecondAlternateText : HL7Base<SecondAlternateText>
                    {

                        private const string _id = "BLG.3.10.11";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BLG.3.10.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
                    {

                        private const string _id = "BLG.3.10.12";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BLG.3.10.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
                    {

                        private const string _id = "BLG.3.10.13";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BLG.3.10.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
                    /// </summary>
                    public class CodingSystemOid : HL7Base<CodingSystemOid>
                    {

                        private const string _id = "BLG.3.10.14";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BLG.3.10.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class ValueSetOid : HL7Base<ValueSetOid>
                    {

                        private const string _id = "BLG.3.10.15";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BLG.3.10.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
                    /// </summary>
                    public class ValueSetVersionId : HL7Base<ValueSetVersionId>
                    {

                        private const string _id = "BLG.3.10.16";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BLG.3.10.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
                    /// </summary>
                    public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
                    {

                        private const string _id = "BLG.3.10.17";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BLG.3.10.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
                    {

                        private const string _id = "BLG.3.10.18";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BLG.3.10.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
                    /// </summary>
                    public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
                    {

                        private const string _id = "BLG.3.10.19";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BLG.3.10.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
                    /// </summary>
                    public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
                    {

                        private const string _id = "BLG.3.10.20";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BLG.3.10.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
                    {

                        private const string _id = "BLG.3.10.21";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, true, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// BLG.3.10.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
                    /// </summary>
                    public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
                    {

                        private const string _id = "BLG.3.10.22";
                        public override string Id
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
                /// BLG.3.11 - This component is used to communicate a version code that may be assigned to the value given in CX.1 ID.
                /// </summary>
                public class SecurityCheck : HL7Base<SecurityCheck>
                {

                    private const string _id = "BLG.3.11";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BLG.3.12 - This component is used to transmit information intended to validate the veracity of the supplied identifier or the presenter of the identifier. For example, this component may be used to ensure that the presenter of a credit card is an authorized user of that card.Refer to HL7 Table 0904 - Security Check Scheme for valid values.
                /// </summary>
                public class SecurityCheckScheme : HL7Base<SecurityCheckScheme>
                {

                    private const string _id = "BLG.3.12";
                    public override string Id
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
            /// BLG.4 - This field explains the choice of and provides the clinical rationale for the selected charge type identified in BLG-2. Refer to User-defined Table 0475  Charge Type Reason for suggested values.
            /// </summary>
            public class ChargeTypeReason : HL7Base<ChargeTypeReason>
            {

                private const string _id = "BLG.4";
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
                /// BLG.4.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
                /// </summary>
                public class Identifier : HL7Base<Identifier>
                {

                    private const string _id = "BLG.4.1";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BLG.4.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
                /// </summary>
                public class Text : HL7Base<Text>
                {

                    private const string _id = "BLG.4.2";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BLG.4.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
                /// </summary>
                public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
                {

                    private const string _id = "BLG.4.3";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BLG.4.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
                /// </summary>
                public class AlternateIdentifier : HL7Base<AlternateIdentifier>
                {

                    private const string _id = "BLG.4.4";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BLG.4.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
                /// </summary>
                public class AlternateText : HL7Base<AlternateText>
                {

                    private const string _id = "BLG.4.5";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BLG.4.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
                /// </summary>
                public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
                {

                    private const string _id = "BLG.4.6";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BLG.4.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
                /// </summary>
                public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
                {

                    private const string _id = "BLG.4.7";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BLG.4.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
                /// </summary>
                public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
                {

                    private const string _id = "BLG.4.8";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BLG.4.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
                /// </summary>
                public class OriginalText : HL7Base<OriginalText>
                {

                    private const string _id = "BLG.4.9";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BLG.4.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
                /// </summary>
                public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
                {

                    private const string _id = "BLG.4.10";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BLG.4.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
                /// </summary>
                public class SecondAlternateText : HL7Base<SecondAlternateText>
                {

                    private const string _id = "BLG.4.11";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BLG.4.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
                /// </summary>
                public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
                {

                    private const string _id = "BLG.4.12";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BLG.4.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
                /// </summary>
                public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
                {

                    private const string _id = "BLG.4.13";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BLG.4.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
                /// </summary>
                public class CodingSystemOid : HL7Base<CodingSystemOid>
                {

                    private const string _id = "BLG.4.14";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BLG.4.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class ValueSetOid : HL7Base<ValueSetOid>
                {

                    private const string _id = "BLG.4.15";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BLG.4.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
                /// </summary>
                public class ValueSetVersionId : HL7Base<ValueSetVersionId>
                {

                    private const string _id = "BLG.4.16";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BLG.4.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
                /// </summary>
                public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
                {

                    private const string _id = "BLG.4.17";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BLG.4.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
                {

                    private const string _id = "BLG.4.18";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BLG.4.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
                /// </summary>
                public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
                {

                    private const string _id = "BLG.4.19";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BLG.4.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
                /// </summary>
                public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
                {

                    private const string _id = "BLG.4.20";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BLG.4.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
                {

                    private const string _id = "BLG.4.21";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// BLG.4.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
                /// </summary>
                public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
                {

                    private const string _id = "BLG.4.22";
                    public override string Id
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

