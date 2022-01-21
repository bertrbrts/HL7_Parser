using Newtonsoft.Json;
namespace care.ai.cloud.functions.hl7
{
	public partial class Mappings {
		/// <summary>
		/// The UB1 segment contains data specific to the United States. Only billing/claims fields that do not exist in other HL7 defined segments appear in this segment. The codes listed as examples are not an exhaustive or current list.Attention UB1-2 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.
		/// </summary>
		public class UB1 {

			 public const string Id = "UB1";

						/// <summary>
			/// UB1.1 - Attention UB1-1 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.
			/// </summary>
			public class SetIdUb1 : HL7Base<SetIdUb1>
			{

				private const string _id = "UB1.1";
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
			/// UB1.2 - Attention UB1-2 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.
			/// </summary>
			public class BloodDeductible : HL7Base<BloodDeductible>
			{

				private const string _id = "UB1.2";
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
			/// UB1.3 - Attention UB1-3 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.
			/// </summary>
			public class BloodFurnishedpints : HL7Base<BloodFurnishedpints>
			{

				private const string _id = "UB1.3";
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
			/// UB1.4 - Attention UB1-4 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.
			/// </summary>
			public class BloodReplacedpints : HL7Base<BloodReplacedpints>
			{

				private const string _id = "UB1.4";
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
			/// UB1.5 - Attention UB1-5 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.
			/// </summary>
			public class BloodNotReplacedpints : HL7Base<BloodNotReplacedpints>
			{

				private const string _id = "UB1.5";
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
			/// UB1.6 - Attention UB1-6 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.
			/// </summary>
			public class CoinsuranceDays : HL7Base<CoinsuranceDays>
			{

				private const string _id = "UB1.6";
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
			/// UB1.7 - Attention UB1-7 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.
			/// </summary>
			public class ConditionCode : HL7Base<ConditionCode>
			{

				private const string _id = "UB1.7";
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
			/// UB1.8 - Attention UB1-8 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.
			/// </summary>
			public class CoveredDays : HL7Base<CoveredDays>
			{

				private const string _id = "UB1.8";
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
			/// UB1.9 - Attention UB1-9 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.
			/// </summary>
			public class NonCoveredDays : HL7Base<NonCoveredDays>
			{

				private const string _id = "UB1.9";
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
			/// UB1.10 - Attention UB1-10 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.
			/// </summary>
			public class ValueAmountCode : HL7Base<ValueAmountCode>
			{

				private const string _id = "UB1.10";
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
			/// UB1.11 - Attention UB1-11 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.
			/// </summary>
			public class NumberOfGraceDays : HL7Base<NumberOfGraceDays>
			{

				private const string _id = "UB1.11";
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
			/// UB1.12 - Attention UB1-12 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.
			/// </summary>
			public class SpecialProgramIndicator : HL7Base<SpecialProgramIndicator>
			{

				private const string _id = "UB1.12";
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
			/// UB1.13 - Attention UB1-13 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.
			/// </summary>
			public class PsroUrApprovalIndicator : HL7Base<PsroUrApprovalIndicator>
			{

				private const string _id = "UB1.13";
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
			/// UB1.14 - Attention UB1-14 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.
			/// </summary>
			public class PsroUrApprovedStayfm : HL7Base<PsroUrApprovedStayfm>
			{

				private const string _id = "UB1.14";
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
			/// UB1.15 - Attention UB1-15 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.
			/// </summary>
			public class PsroUrApprovedStayto : HL7Base<PsroUrApprovedStayto>
			{

				private const string _id = "UB1.15";
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
			/// UB1.16 - Attention UB1-16 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.
			/// </summary>
			public class Occurrence : HL7Base<Occurrence>
			{

				private const string _id = "UB1.16";
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
			/// UB1.17 - Attention UB1-17 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.
			/// </summary>
			public class OccurrenceSpan : HL7Base<OccurrenceSpan>
			{

				private const string _id = "UB1.17";
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
			/// UB1.18 - Attention UB1-18 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.
			/// </summary>
			public class OccurSpanStartDate : HL7Base<OccurSpanStartDate>
			{

				private const string _id = "UB1.18";
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
			/// UB1.19 - Attention UB1-19 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.
			/// </summary>
			public class OccurSpanEndDate : HL7Base<OccurSpanEndDate>
			{

				private const string _id = "UB1.19";
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
			/// UB1.20 - Attention UB1-20 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.
			/// </summary>
			public class Ub82Locator2 : HL7Base<Ub82Locator2>
			{

				private const string _id = "UB1.20";
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
			/// UB1.21 - Attention UB1-21 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.
			/// </summary>
			public class Ub82Locator9 : HL7Base<Ub82Locator9>
			{

				private const string _id = "UB1.21";
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
			/// UB1.22 - Attention UB1-22 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.
			/// </summary>
			public class Ub82Locator27 : HL7Base<Ub82Locator27>
			{

				private const string _id = "UB1.22";
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
			/// UB1.23 - Attention UB1-23 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.
			/// </summary>
			public class Ub82Locator45 : HL7Base<Ub82Locator45>
			{

				private const string _id = "UB1.23";
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

