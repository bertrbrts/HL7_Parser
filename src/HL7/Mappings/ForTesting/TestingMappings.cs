namespace HL7Parser
{
    public partial class Mappings
    {
        public class TestingNoRpt
        {
            public const string Id = "TST";

            public class Field : HL7Base<Field>
            {

                private const string _id = "TST.1";
                public override string Id
                {
                    get { return _id; }
                }

                private readonly bool[] _repeatableHierarchy = { false, false };
                public override bool[] RepeatableHierarchy
                {
                    get { return _repeatableHierarchy; }
                }

                public class Component : HL7Base<Component>
                {

                    private const string _id = "TST.1.1";
                    public override string Id
                    {
                        get { return _id; }
                    }

                    private readonly bool[] _repeatableHierarchy = { false, false, false };
                    public override bool[] RepeatableHierarchy
                    {
                        get { return _repeatableHierarchy; }
                    }


                    public class SubComponent : HL7Base<SubComponent>
                    {

                        private const string _id = "TST.1.1.1";
                        public override string Id
                        {
                            get { return _id; }
                        }

                        private readonly bool[] _repeatableHierarchy = { false, false, false, false };
                        public override bool[] RepeatableHierarchy
                        {
                            get { return _repeatableHierarchy; }
                        }
                    }
                }
            }
        }
    }
}