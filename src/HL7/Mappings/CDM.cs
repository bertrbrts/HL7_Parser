using Newtonsoft.Json;
namespace HL7Parser
{
    public partial class Mappings
    {
        /// <summary>
        /// The CDM segment contains the fields for identifying anything which is charged to patient accounts, including procedures, services, supplies.  It is intended to be used to maintain a list of valid chargeable utilization items.  Its purpose is to keep billing codes synchronized between HIS, Patient Accounting, and other departmental systems.  It is not intended to completely support materials management, inventory, or complex pricing structures for which additional complex fields would be required.  Given an identifying charge code, the associated fields in the charge description master file will provide basic pricing and billing data.  All the additional information necessary for patient accounting systems to do billing and claims is not intended to be included in this segment those should be part of insurance or billing profile tables.  The CDM segment contains the fields which, for one chargeable item, remain the same across facilities, departments, and patient types.  The following PRC segment contains the fields which, for the same chargeable item, vary depending upon facility or department or patient type.
        /// </summary>
        public class CDM
        {

            public const string Id = "CDM";

            /// <summary>
            /// CDM.1 - The key field of the entry.  Must match MFE-4 - Primary Key Value - MFE.  This field contains the code assigned by the institution for the purpose of uniquely identifying the thing that can be charged.  For example, this field would be used to uniquely identify a procedure, item, or test for charging purposes.  Probably the same set of values as used in FT1-7- Transaction Code in financial messages (refer to User-defined Table 0132 - Transaction Code in Chapter 2C, Code Tables, for suggested values).  See Chapter 7 for discussion of the universal service ID.  
            /// </summary>
            public class PrimaryKeyValueCdm : HL7Base<PrimaryKeyValueCdm>
            {

                private const string _id = "CDM.1";
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
                /// CDM.1.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
                /// </summary>
                public class Identifier : HL7Base<Identifier>
                {

                    private const string _id = "CDM.1.1";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// CDM.1.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
                /// </summary>
                public class Text : HL7Base<Text>
                {

                    private const string _id = "CDM.1.2";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// CDM.1.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
                /// </summary>
                public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
                {

                    private const string _id = "CDM.1.3";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// CDM.1.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
                /// </summary>
                public class AlternateIdentifier : HL7Base<AlternateIdentifier>
                {

                    private const string _id = "CDM.1.4";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// CDM.1.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
                /// </summary>
                public class AlternateText : HL7Base<AlternateText>
                {

                    private const string _id = "CDM.1.5";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// CDM.1.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
                /// </summary>
                public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
                {

                    private const string _id = "CDM.1.6";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// CDM.1.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
                /// </summary>
                public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
                {

                    private const string _id = "CDM.1.7";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// CDM.1.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
                /// </summary>
                public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
                {

                    private const string _id = "CDM.1.8";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// CDM.1.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
                /// </summary>
                public class OriginalText : HL7Base<OriginalText>
                {

                    private const string _id = "CDM.1.9";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// CDM.1.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
                /// </summary>
                public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
                {

                    private const string _id = "CDM.1.10";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// CDM.1.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
                /// </summary>
                public class SecondAlternateText : HL7Base<SecondAlternateText>
                {

                    private const string _id = "CDM.1.11";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// CDM.1.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
                /// </summary>
                public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
                {

                    private const string _id = "CDM.1.12";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// CDM.1.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
                /// </summary>
                public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
                {

                    private const string _id = "CDM.1.13";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// CDM.1.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
                /// </summary>
                public class CodingSystemOid : HL7Base<CodingSystemOid>
                {

                    private const string _id = "CDM.1.14";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// CDM.1.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class ValueSetOid : HL7Base<ValueSetOid>
                {

                    private const string _id = "CDM.1.15";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// CDM.1.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
                /// </summary>
                public class ValueSetVersionId : HL7Base<ValueSetVersionId>
                {

                    private const string _id = "CDM.1.16";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// CDM.1.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
                /// </summary>
                public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
                {

                    private const string _id = "CDM.1.17";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// CDM.1.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
                {

                    private const string _id = "CDM.1.18";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// CDM.1.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
                /// </summary>
                public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
                {

                    private const string _id = "CDM.1.19";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// CDM.1.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
                /// </summary>
                public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
                {

                    private const string _id = "CDM.1.20";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// CDM.1.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
                {

                    private const string _id = "CDM.1.21";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// CDM.1.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
                /// </summary>
                public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
                {

                    private const string _id = "CDM.1.22";
                    public override string Id
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
            /// CDM.2 - This field contains an alternative charge code.  For example, points to another charge description master entry in cases where one code supersedes or overrides another code.  Repeating field allows for different codes used by different systems which should be handled as if they were the same for example, the general ledger code may differ from the billing code.  Or, in a multi-facility environment which does facility-specific pricing, there may be more than one of these master file entries for one charge description, each with a different facility.  Refer to User-defined Table 0132 - Transaction Code in Chapter 2C, Code Tables, for suggested values.
            /// </summary>
            public class ChargeCodeAlias : HL7Base<ChargeCodeAlias>
            {

                private const string _id = "CDM.2";
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
                /// CDM.2.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
                /// </summary>
                public class Identifier : HL7Base<Identifier>
                {

                    private const string _id = "CDM.2.1";
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
                /// CDM.2.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
                /// </summary>
                public class Text : HL7Base<Text>
                {

                    private const string _id = "CDM.2.2";
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
                /// CDM.2.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
                /// </summary>
                public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
                {

                    private const string _id = "CDM.2.3";
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
                /// CDM.2.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
                /// </summary>
                public class AlternateIdentifier : HL7Base<AlternateIdentifier>
                {

                    private const string _id = "CDM.2.4";
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
                /// CDM.2.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
                /// </summary>
                public class AlternateText : HL7Base<AlternateText>
                {

                    private const string _id = "CDM.2.5";
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
                /// CDM.2.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
                /// </summary>
                public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
                {

                    private const string _id = "CDM.2.6";
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
                /// CDM.2.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
                /// </summary>
                public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
                {

                    private const string _id = "CDM.2.7";
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
                /// CDM.2.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
                /// </summary>
                public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
                {

                    private const string _id = "CDM.2.8";
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
                /// CDM.2.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
                /// </summary>
                public class OriginalText : HL7Base<OriginalText>
                {

                    private const string _id = "CDM.2.9";
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
                /// CDM.2.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
                /// </summary>
                public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
                {

                    private const string _id = "CDM.2.10";
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
                /// CDM.2.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
                /// </summary>
                public class SecondAlternateText : HL7Base<SecondAlternateText>
                {

                    private const string _id = "CDM.2.11";
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
                /// CDM.2.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
                /// </summary>
                public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
                {

                    private const string _id = "CDM.2.12";
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
                /// CDM.2.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
                /// </summary>
                public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
                {

                    private const string _id = "CDM.2.13";
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
                /// CDM.2.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
                /// </summary>
                public class CodingSystemOid : HL7Base<CodingSystemOid>
                {

                    private const string _id = "CDM.2.14";
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
                /// CDM.2.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class ValueSetOid : HL7Base<ValueSetOid>
                {

                    private const string _id = "CDM.2.15";
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
                /// CDM.2.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
                /// </summary>
                public class ValueSetVersionId : HL7Base<ValueSetVersionId>
                {

                    private const string _id = "CDM.2.16";
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
                /// CDM.2.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
                /// </summary>
                public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
                {

                    private const string _id = "CDM.2.17";
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
                /// CDM.2.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
                {

                    private const string _id = "CDM.2.18";
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
                /// CDM.2.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
                /// </summary>
                public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
                {

                    private const string _id = "CDM.2.19";
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
                /// CDM.2.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
                /// </summary>
                public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
                {

                    private const string _id = "CDM.2.20";
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
                /// CDM.2.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
                {

                    private const string _id = "CDM.2.21";
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
                /// CDM.2.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
                /// </summary>
                public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
                {

                    private const string _id = "CDM.2.22";
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
            /// CDM.3 - This field contains the text abbreviations or code that is associated with this CDM entry.
            /// </summary>
            public class ChargeDescriptionShort : HL7Base<ChargeDescriptionShort>
            {

                private const string _id = "CDM.3";
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
            /// CDM.4 - This field contains the full text description of this CDM entry.
            /// </summary>
            public class ChargeDescriptionLong : HL7Base<ChargeDescriptionLong>
            {

                private const string _id = "CDM.4";
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
            /// CDM.5 - This field indicates whether this CDM entry's description can be overridden.  Refer to User-defined Table 0268 - Override in Chapter 2C, Code Tables, for suggested values.
            /// </summary>
            public class DescriptionOverrideIndicator : HL7Base<DescriptionOverrideIndicator>
            {

                private const string _id = "CDM.5";
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
                /// CDM.5.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
                /// </summary>
                public class Identifier : HL7Base<Identifier>
                {

                    private const string _id = "CDM.5.1";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// CDM.5.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
                /// </summary>
                public class Text : HL7Base<Text>
                {

                    private const string _id = "CDM.5.2";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// CDM.5.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
                /// </summary>
                public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
                {

                    private const string _id = "CDM.5.3";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// CDM.5.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
                /// </summary>
                public class AlternateIdentifier : HL7Base<AlternateIdentifier>
                {

                    private const string _id = "CDM.5.4";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// CDM.5.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
                /// </summary>
                public class AlternateText : HL7Base<AlternateText>
                {

                    private const string _id = "CDM.5.5";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// CDM.5.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
                /// </summary>
                public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
                {

                    private const string _id = "CDM.5.6";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// CDM.5.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
                /// </summary>
                public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
                {

                    private const string _id = "CDM.5.7";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// CDM.5.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
                /// </summary>
                public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
                {

                    private const string _id = "CDM.5.8";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// CDM.5.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
                /// </summary>
                public class OriginalText : HL7Base<OriginalText>
                {

                    private const string _id = "CDM.5.9";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// CDM.5.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
                /// </summary>
                public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
                {

                    private const string _id = "CDM.5.10";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// CDM.5.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
                /// </summary>
                public class SecondAlternateText : HL7Base<SecondAlternateText>
                {

                    private const string _id = "CDM.5.11";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// CDM.5.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
                /// </summary>
                public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
                {

                    private const string _id = "CDM.5.12";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// CDM.5.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
                /// </summary>
                public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
                {

                    private const string _id = "CDM.5.13";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// CDM.5.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
                /// </summary>
                public class CodingSystemOid : HL7Base<CodingSystemOid>
                {

                    private const string _id = "CDM.5.14";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// CDM.5.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class ValueSetOid : HL7Base<ValueSetOid>
                {

                    private const string _id = "CDM.5.15";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// CDM.5.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
                /// </summary>
                public class ValueSetVersionId : HL7Base<ValueSetVersionId>
                {

                    private const string _id = "CDM.5.16";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// CDM.5.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
                /// </summary>
                public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
                {

                    private const string _id = "CDM.5.17";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// CDM.5.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
                {

                    private const string _id = "CDM.5.18";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// CDM.5.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
                /// </summary>
                public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
                {

                    private const string _id = "CDM.5.19";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// CDM.5.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
                /// </summary>
                public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
                {

                    private const string _id = "CDM.5.20";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// CDM.5.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
                {

                    private const string _id = "CDM.5.21";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, true, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                }

                /// <summary>
                /// CDM.5.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
                /// </summary>
                public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
                {

                    private const string _id = "CDM.5.22";
                    public override string Id
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
            /// CDM.6 - This field contains the repeating occurrences for a list of other CDM entry charge codes identifying the other charges which should be generated from this CDM entry.  Refer to User-defined Table 0132 - Transaction Code in Chapter 2C, Code Tables, for suggested values. If non-null, posting a charge to this CDM entry should result in posting the charges identified here.  These are sometimes called "linked items."In the case of "chained" charges where the "lead" charge must be included in the exploded charges, the "lead" charge should be included in the list of exploding charges.  If the price of this parent charge is included in the message, then it overrides the sum of the exploded charges prices.
            /// </summary>
            public class ExplodingCharges : HL7Base<ExplodingCharges>
            {

                private const string _id = "CDM.6";
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
                /// CDM.6.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
                /// </summary>
                public class Identifier : HL7Base<Identifier>
                {

                    private const string _id = "CDM.6.1";
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
                /// CDM.6.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
                /// </summary>
                public class Text : HL7Base<Text>
                {

                    private const string _id = "CDM.6.2";
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
                /// CDM.6.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
                /// </summary>
                public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
                {

                    private const string _id = "CDM.6.3";
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
                /// CDM.6.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
                /// </summary>
                public class AlternateIdentifier : HL7Base<AlternateIdentifier>
                {

                    private const string _id = "CDM.6.4";
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
                /// CDM.6.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
                /// </summary>
                public class AlternateText : HL7Base<AlternateText>
                {

                    private const string _id = "CDM.6.5";
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
                /// CDM.6.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
                /// </summary>
                public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
                {

                    private const string _id = "CDM.6.6";
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
                /// CDM.6.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
                /// </summary>
                public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
                {

                    private const string _id = "CDM.6.7";
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
                /// CDM.6.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
                /// </summary>
                public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
                {

                    private const string _id = "CDM.6.8";
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
                /// CDM.6.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
                /// </summary>
                public class OriginalText : HL7Base<OriginalText>
                {

                    private const string _id = "CDM.6.9";
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
                /// CDM.6.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
                /// </summary>
                public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
                {

                    private const string _id = "CDM.6.10";
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
                /// CDM.6.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
                /// </summary>
                public class SecondAlternateText : HL7Base<SecondAlternateText>
                {

                    private const string _id = "CDM.6.11";
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
                /// CDM.6.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
                /// </summary>
                public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
                {

                    private const string _id = "CDM.6.12";
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
                /// CDM.6.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
                /// </summary>
                public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
                {

                    private const string _id = "CDM.6.13";
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
                /// CDM.6.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
                /// </summary>
                public class CodingSystemOid : HL7Base<CodingSystemOid>
                {

                    private const string _id = "CDM.6.14";
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
                /// CDM.6.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class ValueSetOid : HL7Base<ValueSetOid>
                {

                    private const string _id = "CDM.6.15";
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
                /// CDM.6.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
                /// </summary>
                public class ValueSetVersionId : HL7Base<ValueSetVersionId>
                {

                    private const string _id = "CDM.6.16";
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
                /// CDM.6.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
                /// </summary>
                public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
                {

                    private const string _id = "CDM.6.17";
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
                /// CDM.6.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
                {

                    private const string _id = "CDM.6.18";
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
                /// CDM.6.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
                /// </summary>
                public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
                {

                    private const string _id = "CDM.6.19";
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
                /// CDM.6.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
                /// </summary>
                public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
                {

                    private const string _id = "CDM.6.20";
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
                /// CDM.6.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
                {

                    private const string _id = "CDM.6.21";
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
                /// CDM.6.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
                /// </summary>
                public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
                {

                    private const string _id = "CDM.6.22";
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
            /// CDM.7 - This field contains the procedure code for procedure, if any, associated with this charge description.  Repeating field allows for different procedure coding systems such as CPT4, ICD9.  Coded entry made up of code plus coding schema.  Refer to Externally-defined Table 0088 - Procedure Code in Chapter 2C, Code Tables, for suggested values.
            /// </summary>
            public class ProcedureCode : HL7Base<ProcedureCode>
            {

                private const string _id = "CDM.7";
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
                /// CDM.7.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CNE.2. Different coding schemes will have different elements here.Usage Note The identifier is required and must be a valid code.
                /// </summary>
                public class Identifier : HL7Base<Identifier>
                {

                    private const string _id = "CDM.7.1";
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
                /// CDM.7.2 - The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression. This is the corresponding text assigned by the coding system to the identifier.Usage Note Text description of code is optional but its use should be encouraged since it makes messages easier to review for accuracy, especially during interface testing and debugging.
                /// </summary>
                public class Text : HL7Base<Text>
                {

                    private const string _id = "CDM.7.2";
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
                /// CDM.7.3 - The third component contains the code for the name of the coding system from which the value in CNE.1 is obtained. Refer to HL7 Table 0396 - Coding Systems in Chapter 2C, Code Tables, for valid values. Each coding system is assigned a unique identifier.As of v2.7 this component is required when CNE.1 is populated and CNE.14 is not populated. Both CNE.3 and CNE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CNE.3 and/or CNE.14 the Coding System component or the Coding System OID for the tuple.The combination of the identifier and name of coding system represent a unique concept for a data item.Some organizations that publish code sets author more than one. The coding system, then, to be unique, is a concatenation of the name of the coding authority organization and the name of its code set or table. When an HL7 table is used for a CNE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. Similarly, ISO tables will be named ISOnnnn, where nnnn is the ISO table number.Usage Note The following statement is retained for backward compatibility as of v2.7. Best practice would recommend that this component always be populated. However, if the field narrative explicitly states "Refer to HL7 Table nnnn for valid values, and, if the sending and receiving systems are HL7 compliant, the coding system would be known from the standard.  This would be similar to a field with an ID data type, except that there is a second triplet in which to express an alternate code.
                /// </summary>
                public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
                {

                    private const string _id = "CDM.7.3";
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
                /// CDM.7.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CNE.1 Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
                /// </summary>
                public class AlternateIdentifier : HL7Base<AlternateIdentifier>
                {

                    private const string _id = "CDM.7.4";
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
                /// CDM.7.5 - The descriptive or textual name of the alternate identifier. Analogous to CNE.2 Text. Usage Notes If present, CNE.5 obeys the same rules of use and interpretation as described for CNE.2. 
                /// </summary>
                public class AlternateText : HL7Base<AlternateText>
                {

                    private const string _id = "CDM.7.5";
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
                /// CDM.7.6 - Identifies the coding scheme being used in the alternate identifier component.  Analogous to  CNE.3 Name of Coding System.  Refer to HL7 Table 0396 - Coding Systems in Chapter 2C, Code Tables, for valid values.As of v2.7 this component is required when CNE.4 is populated and CNE.17 is not populated. Both CNE.6 and CNE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CNE.6 and/or CNE.17, the "Coding System" component or the "Coding System OID", for the tuple.Usage Notes If present, CNE.6 obeys the same rules of use and interpretation as described for CNE.3.
                /// </summary>
                public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
                {

                    private const string _id = "CDM.7.6";
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
                /// CDM.7.7 - The version ID for the coding system identified by CNE.3. It belongs conceptually to components 1-3 and appears here only for reasons of backward compatibility.Usage Note If the coding system is any system other than an "HL7 coding system," version ID must be valued with an actual version ID. If the coding system is "HL7 coding system," version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. Text description of code is optional but its use should be encouraged since it makes messages easier to review for accuracy, especially during interface testing and debugging.
                /// </summary>
                public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
                {

                    private const string _id = "CDM.7.7";
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
                /// CDM.7.8 - The version ID for the coding system identified by CNE.6.  It belongs conceptually to the group of Alternate components (see note 2.A.1) and appears here only for reasons of backward compatibility. Analogous to CNE.7 Coding System Version ID.Usage Notes If present, CNE.8 obeys the same rules of use and interpretation as described for CNE.7.
                /// </summary>
                public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
                {

                    private const string _id = "CDM.7.8";
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
                /// CDM.7.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
                /// </summary>
                public class OriginalText : HL7Base<OriginalText>
                {

                    private const string _id = "CDM.7.9";
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
                /// CDM.7.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CN-1 Identifier.
                /// </summary>
                public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
                {

                    private const string _id = "CDM.7.10";
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
                /// CDM.7.11 - The descriptive or textual name of the Second Alternate Identifier. Analogous to CNE.2 Text.
                /// </summary>
                public class SecondAlternateText : HL7Base<SecondAlternateText>
                {

                    private const string _id = "CDM.7.11";
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
                /// CDM.7.12 - Identifies the coding scheme being used in the Second Alternate Identifier component. Analogous to CNE.3 Name of Coding System.  Refer to HL7 Table 0396 - Coding Systems in Chapter 2C, Code Tables, for valid values.As of v2.7 this component is required when CNE.10 is populated and CNE.20 is not populated. Both CNE.12 and CNE.20 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CNE.12 and/or CNE.20, the "Coding System" component or the "Coding System OID", for the tuple.
                /// </summary>
                public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
                {

                    private const string _id = "CDM.7.12";
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
                /// CDM.7.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CNE.7 Coding System Version ID.
                /// </summary>
                public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
                {

                    private const string _id = "CDM.7.13";
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
                /// CDM.7.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CNE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CNE.1 is populated and CNE.3 is not populated. Both CNE.3 and CNE.14 may be populated.
                /// </summary>
                public class CodingSystemOid : HL7Base<CodingSystemOid>
                {

                    private const string _id = "CDM.7.14";
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
                /// CDM.7.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CNE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class ValueSetOid : HL7Base<ValueSetOid>
                {

                    private const string _id = "CDM.7.15";
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
                /// CDM.7.16 - This component carries the version for the value set identified by CNE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CNE.15 is populated.
                /// </summary>
                public class ValueSetVersionId : HL7Base<ValueSetVersionId>
                {

                    private const string _id = "CDM.7.16";
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
                /// CDM.7.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CNE.6. Analogous to CNE.14 OID for Coding System. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CNE.4 is populated and CNE.6 is not populated. Both CNE.6 and CNE.17 may be populated.
                /// </summary>
                public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
                {

                    private const string _id = "CDM.7.17";
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
                /// CDM.7.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CNE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
                {

                    private const string _id = "CDM.7.18";
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
                /// CDM.7.19 - This component carries the version for the value set identified by CNE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CNE.18 is populated.
                /// </summary>
                public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
                {

                    private const string _id = "CDM.7.19";
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
                /// CDM.7.20 - This component contains the ISO Object Identifier (OID) from which the value in CNE.12 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined numbers, the OID registered in the HL7 OID registry should be used. This component is required when CNE.4 is populated and neither CNE.6 nor CNE.18 is populated. In short either the CNE.6 or the CNE.14 or CNE.17 must be populated when CNE.4 is populated.
                /// </summary>
                public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
                {

                    private const string _id = "CDM.7.20";
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
                /// CDM.7.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CNE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
                {

                    private const string _id = "CDM.7.21";
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
                /// CDM.7.22 - This component carries the version for the value set identified by CNE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CNE.21 is populated.
                /// </summary>
                public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
                {

                    private const string _id = "CDM.7.22";
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
            /// CDM.8 - This field indicates whether this is a usable CDM entry.  Refer to HL7 Table 0183 - Active/Inactive in Chapter 2C, Code Tables, for valid values.
            /// </summary>
            public class ActiveInactiveFlag : HL7Base<ActiveInactiveFlag>
            {

                private const string _id = "CDM.8";
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
            /// CDM.9 - This optional field contains an identifying stock number, if any, which might be used, for example, as a cross reference for materials management. Refer to User-defined Table 0463 - Inventory number in Chapter 2C, Code Tables, for suggested values.
            /// </summary>
            public class InventoryNumber : HL7Base<InventoryNumber>
            {

                private const string _id = "CDM.9";
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
                /// CDM.9.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
                /// </summary>
                public class Identifier : HL7Base<Identifier>
                {

                    private const string _id = "CDM.9.1";
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
                /// CDM.9.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
                /// </summary>
                public class Text : HL7Base<Text>
                {

                    private const string _id = "CDM.9.2";
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
                /// CDM.9.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
                /// </summary>
                public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
                {

                    private const string _id = "CDM.9.3";
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
                /// CDM.9.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
                /// </summary>
                public class AlternateIdentifier : HL7Base<AlternateIdentifier>
                {

                    private const string _id = "CDM.9.4";
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
                /// CDM.9.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
                /// </summary>
                public class AlternateText : HL7Base<AlternateText>
                {

                    private const string _id = "CDM.9.5";
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
                /// CDM.9.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
                /// </summary>
                public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
                {

                    private const string _id = "CDM.9.6";
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
                /// CDM.9.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
                /// </summary>
                public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
                {

                    private const string _id = "CDM.9.7";
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
                /// CDM.9.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
                /// </summary>
                public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
                {

                    private const string _id = "CDM.9.8";
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
                /// CDM.9.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
                /// </summary>
                public class OriginalText : HL7Base<OriginalText>
                {

                    private const string _id = "CDM.9.9";
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
                /// CDM.9.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
                /// </summary>
                public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
                {

                    private const string _id = "CDM.9.10";
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
                /// CDM.9.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
                /// </summary>
                public class SecondAlternateText : HL7Base<SecondAlternateText>
                {

                    private const string _id = "CDM.9.11";
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
                /// CDM.9.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
                /// </summary>
                public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
                {

                    private const string _id = "CDM.9.12";
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
                /// CDM.9.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
                /// </summary>
                public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
                {

                    private const string _id = "CDM.9.13";
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
                /// CDM.9.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
                /// </summary>
                public class CodingSystemOid : HL7Base<CodingSystemOid>
                {

                    private const string _id = "CDM.9.14";
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
                /// CDM.9.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class ValueSetOid : HL7Base<ValueSetOid>
                {

                    private const string _id = "CDM.9.15";
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
                /// CDM.9.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
                /// </summary>
                public class ValueSetVersionId : HL7Base<ValueSetVersionId>
                {

                    private const string _id = "CDM.9.16";
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
                /// CDM.9.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
                /// </summary>
                public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
                {

                    private const string _id = "CDM.9.17";
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
                /// CDM.9.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
                {

                    private const string _id = "CDM.9.18";
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
                /// CDM.9.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
                /// </summary>
                public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
                {

                    private const string _id = "CDM.9.19";
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
                /// CDM.9.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
                /// </summary>
                public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
                {

                    private const string _id = "CDM.9.20";
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
                /// CDM.9.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                /// </summary>
                public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
                {

                    private const string _id = "CDM.9.21";
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
                /// CDM.9.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
                /// </summary>
                public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
                {

                    private const string _id = "CDM.9.22";
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
            /// CDM.10 - This field contains the Relative Value Unit (RVU) minutes and ATS, a factor related to CPT4 coding and to pricing structure for physical billing.
            /// </summary>
            public class ResourceLoad : HL7Base<ResourceLoad>
            {

                private const string _id = "CDM.10";
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
            /// CDM.11 - This field contains any contract number pertaining to this chargeable item for example, supplier contract or service contract.
            /// </summary>
            public class ContractNumber : HL7Base<ContractNumber>
            {

                private const string _id = "CDM.11";
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
                /// CDM.11.1 - The value of the identifier itself.
                /// </summary>
                public class IdNumber : HL7Base<IdNumber>
                {

                    private const string _id = "CDM.11.1";
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
                /// CDM.11.2 - A digit, or digits, exclusive of the identifier in CX.1, calculated by applying an algorithm to all or some of the digits in the number, which may be used to test validity of the non-check-digit identifier.
                /// </summary>
                public class IdentifierCheckDigit : HL7Base<IdentifierCheckDigit>
                {

                    private const string _id = "CDM.11.2";
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
                /// CDM.11.3 - Contains the code identifying the check digit scheme employed.Refer to HL7 Table 0061 - Check Digit Scheme for valid values.Note The check digit and code identifying check digit scheme are null if ID is alphanumeric.
                /// </summary>
                public class CheckDigitScheme : HL7Base<CheckDigitScheme>
                {

                    private const string _id = "CDM.11.3";
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
                /// CDM.11.4 - The assigning authority is a unique name of the system (or organization or agency or department) that creates the data. As of v2.7, CX.4 Assigning Authority is required if neither CX.9 nor CX.10 are populated. Best practice is to always send an OID in the Assigning Authority componentRefer to User-defined Table 0363 - Assigning Authority for suggested values.The reader is referred to the CX.9 and the CX.10 if there is a need to transmit values with semantic meaning for an assigning jurisdiction or assigning department or agency in addition to, or instead of, an assigning authority. However, all 3 components may be valued. If, in so doing, it is discovered that the values in CX.9 and/or CX.10 conflict with CX.4, the user would look to the Message Profile or other implementation agreement for a statement as to which takes precedence.Note When the HD data type is used in a given segment as a component of a field of another data type, User-defined Table 0300 - Namespace ID (referenced by the first sub-component of the HD component) may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.By site agreement, implementers may continue to use User-defined Table 0300  Namespace ID for the first sub-component.
                /// </summary>
                public class AssigningAuthority : HL7Base<AssigningAuthority>
                {

                    private const string _id = "CDM.11.4";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, false, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                    /// <summary>
                    /// CDM.11.4.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
                    /// </summary>
                    public class NamespaceId : HL7Base<NamespaceId>
                    {

                        private const string _id = "CDM.11.4.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.11.4.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
                    /// </summary>
                    public class UniversalId : HL7Base<UniversalId>
                    {

                        private const string _id = "CDM.11.4.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.11.4.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
                    /// </summary>
                    public class UniversalIdType : HL7Base<UniversalIdType>
                    {

                        private const string _id = "CDM.11.4.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                }

                /// <summary>
                /// CDM.11.5 - A code corresponding to the type of identifier. As of v2.7, CX.5 Identifier Type Code is required. Refer to HL7 Table 0203  Identifier Type for suggested values.
                /// </summary>
                public class IdentifierTypeCode : HL7Base<IdentifierTypeCode>
                {

                    private const string _id = "CDM.11.5";
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
                /// CDM.11.6 - The place or location identifier where the identifier was first assigned to the patient. This component is not an inherent part of the identifier but rather part of the history of the identifier as part of this data type, its existence is a convenience for certain intercommunicating systems.Note When the HD data type is used in a given segment as a component of a field of another data type, User-defined Table 0300 - Namespace ID (referenced by the first sub-component of the HD component), may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
                /// </summary>
                public class AssigningFacility : HL7Base<AssigningFacility>
                {

                    private const string _id = "CDM.11.6";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, false, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                    /// <summary>
                    /// CDM.11.6.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
                    /// </summary>
                    public class NamespaceId : HL7Base<NamespaceId>
                    {

                        private const string _id = "CDM.11.6.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.11.6.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
                    /// </summary>
                    public class UniversalId : HL7Base<UniversalId>
                    {

                        private const string _id = "CDM.11.6.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.11.6.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
                    /// </summary>
                    public class UniversalIdType : HL7Base<UniversalIdType>
                    {

                        private const string _id = "CDM.11.6.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                }

                /// <summary>
                /// CDM.11.7 - The first date, if known, on which the identifier is valid and active.
                /// </summary>
                public class EffectiveDate : HL7Base<EffectiveDate>
                {

                    private const string _id = "CDM.11.7";
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
                /// CDM.11.8 - The last date, if known, on which the identifier is valid and active.
                /// </summary>
                public class ExpirationDate : HL7Base<ExpirationDate>
                {

                    private const string _id = "CDM.11.8";
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
                /// CDM.11.9 - The geo-political body that assigned the identifier in component 1. As of v2.7, Assigning Jurisdiction is required if neither CX.4 nor CX.10 are populated.  - Refer to HL7 Table 0399  Country Code for valid values if the administrative unit under whose jurisdiction the identifier was issued is a country. - Refer to User-Defined Table 0347  State/Province for suggested values if the administrative unit under whose jurisdiction the identifier was issued is a state or province. This table is country specific. In the US, postal codes may be used. - Refer to User-defined Table 0289 County/Parish for suggested values if the administrative unit under whose jurisdiction the identifier was issued is a county or parish.The reader is referred to the CX.4 if there is a need to transmit this information as an OID.
                /// </summary>
                public class AssigningJurisdiction : HL7Base<AssigningJurisdiction>
                {

                    private const string _id = "CDM.11.9";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, false, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                    /// <summary>
                    /// CDM.11.9.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
                    /// </summary>
                    public class Identifier : HL7Base<Identifier>
                    {

                        private const string _id = "CDM.11.9.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.11.9.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
                    /// </summary>
                    public class Text : HL7Base<Text>
                    {

                        private const string _id = "CDM.11.9.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.11.9.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
                    /// </summary>
                    public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
                    {

                        private const string _id = "CDM.11.9.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.11.9.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
                    /// </summary>
                    public class AlternateIdentifier : HL7Base<AlternateIdentifier>
                    {

                        private const string _id = "CDM.11.9.4";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.11.9.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
                    /// </summary>
                    public class AlternateText : HL7Base<AlternateText>
                    {

                        private const string _id = "CDM.11.9.5";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.11.9.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
                    {

                        private const string _id = "CDM.11.9.6";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.11.9.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
                    /// </summary>
                    public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
                    {

                        private const string _id = "CDM.11.9.7";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.11.9.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
                    {

                        private const string _id = "CDM.11.9.8";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.11.9.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
                    /// </summary>
                    public class OriginalText : HL7Base<OriginalText>
                    {

                        private const string _id = "CDM.11.9.9";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.11.9.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
                    /// </summary>
                    public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
                    {

                        private const string _id = "CDM.11.9.10";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.11.9.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
                    /// </summary>
                    public class SecondAlternateText : HL7Base<SecondAlternateText>
                    {

                        private const string _id = "CDM.11.9.11";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.11.9.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
                    {

                        private const string _id = "CDM.11.9.12";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.11.9.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
                    {

                        private const string _id = "CDM.11.9.13";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.11.9.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
                    /// </summary>
                    public class CodingSystemOid : HL7Base<CodingSystemOid>
                    {

                        private const string _id = "CDM.11.9.14";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.11.9.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class ValueSetOid : HL7Base<ValueSetOid>
                    {

                        private const string _id = "CDM.11.9.15";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.11.9.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
                    /// </summary>
                    public class ValueSetVersionId : HL7Base<ValueSetVersionId>
                    {

                        private const string _id = "CDM.11.9.16";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.11.9.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
                    /// </summary>
                    public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
                    {

                        private const string _id = "CDM.11.9.17";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.11.9.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
                    {

                        private const string _id = "CDM.11.9.18";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.11.9.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
                    /// </summary>
                    public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
                    {

                        private const string _id = "CDM.11.9.19";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.11.9.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
                    /// </summary>
                    public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
                    {

                        private const string _id = "CDM.11.9.20";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.11.9.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
                    {

                        private const string _id = "CDM.11.9.21";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.11.9.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
                    /// </summary>
                    public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
                    {

                        private const string _id = "CDM.11.9.22";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                }

                /// <summary>
                /// CDM.11.10 - The agency or department that assigned the identifier in component 1. As of v2.7, Assigning Agency or Department is required if neither CX.4 nor CX.9 are populated.Refer to User-defined Table 0530  Organizations, agency, department for suggested values if the administrative unit under whose jurisdiction the identifier was issued is an organization, agency or department. This is populated with site-specific assigning authorities. It also should contain national or international codes when CX.5 Identifier Type Code may be assigned by more than one authority within a governmental or organizational unit. For example, a federal government may have 2 departments that assign a military identifier, its Veterans Affairs department and its Department of Defense. It is not recommended to include values for entities such as Social Security Administration (SSA), Immigration and Naturalization Service (INS), Center for Medicare and Medicaid Services (CMS) because they are included in the identifier type table. In these cases the name of the country plus the identifier type yields the correct interpretation of the identifier in component 1. Likewise, entries like department of motor vehicles (DMV) and licensing boards are not recommended for inclusion because the combination of state and identifier type yields the correct interpretation of the identifier in component 1. This approach is not to be confused with the detailed information provided in the Chapter 15 segments that have provision for specifying the precise granting body and issuing body information needed in personnel management messages.Example 1 Identifier plus Visa yields a unique identifier.Example 2 identifier plus state plus DLN yields a unique drivers license number.Example 3 identifier plus country plus INS yields a unique immigration number.The reader is referred to the CX.4, if there is a need to transmit this information as an OID.
                /// </summary>
                public class AssigningAgencyOrDepartment : HL7Base<AssigningAgencyOrDepartment>
                {

                    private const string _id = "CDM.11.10";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, false, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                    /// <summary>
                    /// CDM.11.10.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
                    /// </summary>
                    public class Identifier : HL7Base<Identifier>
                    {

                        private const string _id = "CDM.11.10.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.11.10.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
                    /// </summary>
                    public class Text : HL7Base<Text>
                    {

                        private const string _id = "CDM.11.10.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.11.10.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
                    /// </summary>
                    public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
                    {

                        private const string _id = "CDM.11.10.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.11.10.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
                    /// </summary>
                    public class AlternateIdentifier : HL7Base<AlternateIdentifier>
                    {

                        private const string _id = "CDM.11.10.4";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.11.10.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
                    /// </summary>
                    public class AlternateText : HL7Base<AlternateText>
                    {

                        private const string _id = "CDM.11.10.5";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.11.10.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
                    {

                        private const string _id = "CDM.11.10.6";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.11.10.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
                    /// </summary>
                    public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
                    {

                        private const string _id = "CDM.11.10.7";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.11.10.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
                    {

                        private const string _id = "CDM.11.10.8";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.11.10.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
                    /// </summary>
                    public class OriginalText : HL7Base<OriginalText>
                    {

                        private const string _id = "CDM.11.10.9";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.11.10.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
                    /// </summary>
                    public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
                    {

                        private const string _id = "CDM.11.10.10";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.11.10.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
                    /// </summary>
                    public class SecondAlternateText : HL7Base<SecondAlternateText>
                    {

                        private const string _id = "CDM.11.10.11";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.11.10.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
                    {

                        private const string _id = "CDM.11.10.12";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.11.10.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
                    {

                        private const string _id = "CDM.11.10.13";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.11.10.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
                    /// </summary>
                    public class CodingSystemOid : HL7Base<CodingSystemOid>
                    {

                        private const string _id = "CDM.11.10.14";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.11.10.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class ValueSetOid : HL7Base<ValueSetOid>
                    {

                        private const string _id = "CDM.11.10.15";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.11.10.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
                    /// </summary>
                    public class ValueSetVersionId : HL7Base<ValueSetVersionId>
                    {

                        private const string _id = "CDM.11.10.16";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.11.10.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
                    /// </summary>
                    public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
                    {

                        private const string _id = "CDM.11.10.17";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.11.10.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
                    {

                        private const string _id = "CDM.11.10.18";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.11.10.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
                    /// </summary>
                    public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
                    {

                        private const string _id = "CDM.11.10.19";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.11.10.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
                    /// </summary>
                    public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
                    {

                        private const string _id = "CDM.11.10.20";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.11.10.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
                    {

                        private const string _id = "CDM.11.10.21";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.11.10.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
                    /// </summary>
                    public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
                    {

                        private const string _id = "CDM.11.10.22";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                }

                /// <summary>
                /// CDM.11.11 - This component is used to communicate a version code that may be assigned to the value given in CX.1 ID.
                /// </summary>
                public class SecurityCheck : HL7Base<SecurityCheck>
                {

                    private const string _id = "CDM.11.11";
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
                /// CDM.11.12 - This component is used to transmit information intended to validate the veracity of the supplied identifier or the presenter of the identifier. For example, this component may be used to ensure that the presenter of a credit card is an authorized user of that card.Refer to HL7 Table 0904 - Security Check Scheme for valid values.
                /// </summary>
                public class SecurityCheckScheme : HL7Base<SecurityCheckScheme>
                {

                    private const string _id = "CDM.11.12";
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
            /// CDM.12 - This field contains the organization with which there is a contractual arrangement for providing the service or material used for this chargeable item.  
            /// </summary>
            public class ContractOrganization : HL7Base<ContractOrganization>
            {

                private const string _id = "CDM.12";
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
                /// CDM.12.1 - The name of the specified organization.
                /// </summary>
                public class OrganizationName : HL7Base<OrganizationName>
                {

                    private const string _id = "CDM.12.1";
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
                /// CDM.12.2 - A code that represents the type of name i.e., legal name, display name. Refer to User-defined Table 0204 - Organizational Name Type for suggested values.
                /// </summary>
                public class OrganizationNameTypeCode : HL7Base<OrganizationNameTypeCode>
                {

                    private const string _id = "CDM.12.2";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, false, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                    /// <summary>
                    /// CDM.12.2.1 - The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.In the context of Data Missing, described above in the Usage Note, refer to HL7 Table 0353  CWE Statuses for valid values.
                    /// </summary>
                    public class Identifier : HL7Base<Identifier>
                    {

                        private const string _id = "CDM.12.2.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.12.2.2 - The second component contains the descriptive or textual name of the identifier, e.g., "myocardial infarction" or "X-ray impression".
                    /// </summary>
                    public class Text : HL7Base<Text>
                    {

                        private const string _id = "CDM.12.2.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.12.2.3 - The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the "Coding System" component or the "Coding System OID" for the tuple.Refer to HL7 Table 0396  Coding System in Chapter 2C, section "Coding System Table" for valid values. Refer to section 2.A.8.3, "Name of Coding System (ID)" for a discussion of coding system conventions.
                    /// </summary>
                    public class NameOfCodingSystem : HL7Base<NameOfCodingSystem>
                    {

                        private const string _id = "CDM.12.2.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.12.2.4 - A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. Usage Notes The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.
                    /// </summary>
                    public class AlternateIdentifier : HL7Base<AlternateIdentifier>
                    {

                        private const string _id = "CDM.12.2.4";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.12.2.5 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.
                    /// </summary>
                    public class AlternateText : HL7Base<AlternateText>
                    {

                        private const string _id = "CDM.12.2.5";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.12.2.6 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfAlternateCodingSystem : HL7Base<NameOfAlternateCodingSystem>
                    {

                        private const string _id = "CDM.12.2.6";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.12.2.7 - This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. 
                    /// </summary>
                    public class CodingSystemVersionId : HL7Base<CodingSystemVersionId>
                    {

                        private const string _id = "CDM.12.2.7";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.12.2.8 - This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class AlternateCodingSystemVersionId : HL7Base<AlternateCodingSystemVersionId>
                    {

                        private const string _id = "CDM.12.2.8";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.12.2.9 - The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.
                    /// </summary>
                    public class OriginalText : HL7Base<OriginalText>
                    {

                        private const string _id = "CDM.12.2.9";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.12.2.10 - A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. 
                    /// </summary>
                    public class SecondAlternateIdentifier : HL7Base<SecondAlternateIdentifier>
                    {

                        private const string _id = "CDM.12.2.10";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.12.2.11 - The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction
                    /// </summary>
                    public class SecondAlternateText : HL7Base<SecondAlternateText>
                    {

                        private const string _id = "CDM.12.2.11";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.12.2.12 - Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the "Coding System" component or the "Coding System OID", for the tuple.
                    /// </summary>
                    public class NameOfSecondAlternateCodingSystem : HL7Base<NameOfSecondAlternateCodingSystem>
                    {

                        private const string _id = "CDM.12.2.12";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.12.2.13 - This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.
                    /// </summary>
                    public class SecondAlternateCodingSystemVersionId : HL7Base<SecondAlternateCodingSystemVersionId>
                    {

                        private const string _id = "CDM.12.2.13";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.12.2.14 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.
                    /// </summary>
                    public class CodingSystemOid : HL7Base<CodingSystemOid>
                    {

                        private const string _id = "CDM.12.2.14";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.12.2.15 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class ValueSetOid : HL7Base<ValueSetOid>
                    {

                        private const string _id = "CDM.12.2.15";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.12.2.16 - This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.15 is populated.
                    /// </summary>
                    public class ValueSetVersionId : HL7Base<ValueSetVersionId>
                    {

                        private const string _id = "CDM.12.2.16";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.12.2.17 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.
                    /// </summary>
                    public class AlternateCodingSystemOid : HL7Base<AlternateCodingSystemOid>
                    {

                        private const string _id = "CDM.12.2.17";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.12.2.18 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class AlternateValueSetOid : HL7Base<AlternateValueSetOid>
                    {

                        private const string _id = "CDM.12.2.18";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.12.2.19 - This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.18 is populated.
                    /// </summary>
                    public class AlternateValueSetVersionId : HL7Base<AlternateValueSetVersionId>
                    {

                        private const string _id = "CDM.12.2.19";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.12.2.20 - This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.
                    /// </summary>
                    public class SecondAlternateCodingSystemOid : HL7Base<SecondAlternateCodingSystemOid>
                    {

                        private const string _id = "CDM.12.2.20";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.12.2.21 - This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  "####" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.
                    /// </summary>
                    public class SecondAlternateValueSetOid : HL7Base<SecondAlternateValueSetOid>
                    {

                        private const string _id = "CDM.12.2.21";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.12.2.22 - This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.Value set version ID is required if CWE.21 is populated.
                    /// </summary>
                    public class SecondAlternateValueSetVersionId : HL7Base<SecondAlternateValueSetVersionId>
                    {

                        private const string _id = "CDM.12.2.22";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                }

                /// <summary>
                /// CDM.12.3 - Attention The XON.3 component was deprecated as of v 2.5 and the detail was withdrawn and removed from the standard as of v 2.7. Refer to XON.10 Organization Identifier.
                /// </summary>
                public class IdNumber : HL7Base<IdNumber>
                {

                    private const string _id = "CDM.12.3";
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
                /// CDM.12.4 - Attention The XON.4 component was deprecated as of v 2.5 and the detail was withdrawn and removed from the standard as of v 2.7.
                /// </summary>
                public class IdentifierCheckDigit : HL7Base<IdentifierCheckDigit>
                {

                    private const string _id = "CDM.12.4";
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
                /// CDM.12.5 - Attention The XON.5 component was deprecated as of v 2.5 and the detail was withdrawn and removed from the standard as of v 2.7.
                /// </summary>
                public class CheckDigitScheme : HL7Base<CheckDigitScheme>
                {

                    private const string _id = "CDM.12.5";
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
                /// CDM.12.6 - The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Assigning authorities are unique across a given HL7 implementation. Refer to User-defined Table 0363 - Assigning Authority for suggested values. Note When the HD data type is used in a given segment as a component of a field of another data type, User-defined Table 0300 - Namespace ID (referenced by the first sub-component of the HD component) may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.By site agreement, implementers may continue to use User-defined Table 0300  Namespace ID for the first sub-component.
                /// </summary>
                public class AssigningAuthority : HL7Base<AssigningAuthority>
                {

                    private const string _id = "CDM.12.6";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, false, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                    /// <summary>
                    /// CDM.12.6.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
                    /// </summary>
                    public class NamespaceId : HL7Base<NamespaceId>
                    {

                        private const string _id = "CDM.12.6.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.12.6.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
                    /// </summary>
                    public class UniversalId : HL7Base<UniversalId>
                    {

                        private const string _id = "CDM.12.6.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.12.6.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
                    /// </summary>
                    public class UniversalIdType : HL7Base<UniversalIdType>
                    {

                        private const string _id = "CDM.12.6.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                }

                /// <summary>
                /// CDM.12.7 - A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the "Assigning authority" component. Refer to HL7 Table 0203 - Identifier Type for suggested values.
                /// </summary>
                public class IdentifierTypeCode : HL7Base<IdentifierTypeCode>
                {

                    private const string _id = "CDM.12.7";
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
                /// CDM.12.8 - The place or location identifier where the identifier was first assigned to the person. This component is not an inherent part of the identifier but rather part of the history of the identifier as part of this data type, its existence is a convenience for certain intercommunicating systems.Note When the HD data type is used in a given segment as a component of a field of another data type, User-defined Table 0300 - Namespace ID (referenced by the first sub-component of the HD component) may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
                /// </summary>
                public class AssigningFacility : HL7Base<AssigningFacility>
                {

                    private const string _id = "CDM.12.8";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, false, true };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }

                    /// <summary>
                    /// CDM.12.8.1 - The local coded item for the entity. The component intentionally remains associated with the IS data type in v 2.7.User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. Note When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.
                    /// </summary>
                    public class NamespaceId : HL7Base<NamespaceId>
                    {

                        private const string _id = "CDM.12.8.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.12.8.2 - The HDs second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).
                    /// </summary>
                    public class UniversalId : HL7Base<UniversalId>
                    {

                        private const string _id = "CDM.12.8.2";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                    /// <summary>
                    /// CDM.12.8.3 - The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.
                    /// </summary>
                    public class UniversalIdType : HL7Base<UniversalIdType>
                    {

                        private const string _id = "CDM.12.8.3";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, true, true };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }

                    }

                }

                /// <summary>
                /// CDM.12.9 - Different name/address types and representations of the same name/address should be described by repeating of this field, with different values of the name/address type and/or name/address representation component.Note This new component remains in alphabetic representation with each repetition of the field using these data types, i.e. even though the name may be represented in an ideographic character set, this component will remain represented in an alphabetic character set.Refer to HL7 Table 0465  Name/address Representation Code for valid values.In general this component provides an indication of the representation provided by the data item. It does not necessarily specify the character sets used. Thus, even though the representation might provide an indication of what to expect, the sender is still free to encode the contents using whatever character set is desired. This component provides only hints for the receiver, so it can make choices regarding what it has been sent and what it is capable of displaying.
                /// </summary>
                public class NameRepresentationCode : HL7Base<NameRepresentationCode>
                {

                    private const string _id = "CDM.12.9";
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
                /// CDM.12.10 - This component contains the sequence of characters (the code) that uniquely identifies the item being referenced by XON.1 Organization Name. This component replaces XON.3 ID Number as of v 2.5.Note The check digit and code identifying check digit scheme are null if Organization identifier is alphanumeric.
                /// </summary>
                public class OrganizationIdentifier : HL7Base<OrganizationIdentifier>
                {

                    private const string _id = "CDM.12.10";
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
            /// CDM.13 - This field contains a room fee indicator.  Refer to HL7 Table 0136 - Yes/no Indicator in Chapter 2C, Code Tables, for valid values.Y - this is a component of the room feesN - this is any other chargeable item other than room fees
            /// </summary>
            public class RoomFeeIndicator : HL7Base<RoomFeeIndicator>
            {

                private const string _id = "CDM.13";
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

