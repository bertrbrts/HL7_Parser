using HL7Parser.HL7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HL7Parser
{

    public abstract class HL7Base<T> where T : HL7Base<T>
    {
        public abstract string Id { get; }
        public abstract bool[] RepeatableHierarchy { get; }
        public bool Repeatable { get { return (RepeatableHierarchy?.Last()) ?? false; } }
        public static string GetValue(IHL7_Message message, int? fieldIndex = null, int? componentIndex = null, int? subcomponentIndex = null)

        {
            //create an instance of the base class to retrieve its id
            var instance = (T)Activator.CreateInstance(typeof(T));

            //split the id
            var comps = instance.Id.Split(".");

            //convert index values to strings and store in an array to match position of paired component - if no value provided but field is repeatable use 0, GetValue will handle transforming this to no value if only a single field is available
            var compIndexers = new string[] {   null,
                                                fieldIndex != null ? fieldIndex.ToString() : (instance.RepeatableHierarchy.Length >= 2 && instance.RepeatableHierarchy[1]) ? "0" : null,
                                                componentIndex != null ? componentIndex.ToString() : (instance.RepeatableHierarchy.Length >= 3 && instance.RepeatableHierarchy[2]) ? "0" : null,
                                                subcomponentIndex != null ? subcomponentIndex.ToString() : (instance.RepeatableHierarchy.Length >= 4 && instance.RepeatableHierarchy[3]) ? "0" : null };

            //add indicies where provided
            for (int i = 1; i < comps.Length; i++)
            {
                if (!string.IsNullOrEmpty(compIndexers[i]))
                {
                    comps[i] = $"{comps[i]}[{compIndexers[i]}]";
                }
            }

            //reform the id with updated components
            var IdToUse = string.Join(".", comps);

            //
            return message.GetValue(IdToUse);
        }
    }
}
