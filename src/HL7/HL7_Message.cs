using Google.Apis.Auth.OAuth2;
using Google.Apis.CloudHealthcare.v1;
using Google.Apis.CloudHealthcare.v1.Data;
using Google.Apis.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using messageResource = Google.Apis.CloudHealthcare.v1.ProjectsResource.LocationsResource.DatasetsResource.Hl7V2StoresResource.MessagesResource;

namespace care.ai.cloud.functions.src.HL7
{
    public class HL7_Message : IHL7_Message
    {
        private static IClientService _service;

        /// <summary>
        /// ETag.
        /// </summary>
        public virtual string ETag { get; set; }
        /// <summary>
        /// Segments List.
        /// </summary>
        [JsonProperty("segments")]
        public virtual IList<Segment> Segments { get; set; }

        /// <summary>
        /// HL7_Message Constructor
        /// </summary>
        /// <param name="service">IClientService service</param>
        public HL7_Message(IClientService service)
        {
            _service = service;
        }

        /// <summary>
        /// IHL7_Message Factory Method.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public IHL7_Message Factory(string message)
        {
            try
            {          
                _service = new CloudHealthcareService(new BaseClientService.Initializer() { HttpClientInitializer = GoogleCredential.GetApplicationDefault() });

                // Create GET Request.
                messageResource.GetRequest hl7Resource =
                    new messageResource.GetRequest(_service, message)
                    {
                        //  ViewEnum.FULL retrieves all data from the GET request.  BASIC only retrieves the name of the object.
                        View = messageResource.GetRequest.ViewEnum.FULL
                    };

                // Execute the GET Request.
                Message result = hl7Resource.Execute();
                var msg = result.SchematizedData;

                // Create JSON string from the parsed data.
                string jsonResult = JsonConvert.SerializeObject(result.ParsedData);

                // Deserialize JSON string into object.
                HL7_Message hl7_message = JsonConvert.DeserializeObject<HL7_Message>(jsonResult);

                return hl7_message;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving HL7 Message: {ex.Message} " + ex.InnerException?.Message ?? string.Empty);
            }
        }

        /// <summary>
        /// Get the Value of specific Field/Component/SubCpomponent, throws error if field/component index is not valid
        /// </summary>
        /// <param name="strValueFormat">Field/Component position in format SEGMENTNAME.FieldIndex.ComponentIndex.SubComponentIndex example PID.5.2</param>
        /// <returns>Value of specified field/component/subcomponent</returns>
        public string GetValue(string strValueFormat)
        {
            if (string.IsNullOrEmpty(strValueFormat)) return null;

            string segmentName = string.Empty;
            string componentId = string.Empty;
            string strValue = string.Empty;

            try
            {
                var splitString = strValueFormat.Split('.', 2);
                segmentName = splitString[0];
                componentId = splitString[1];
            }
            catch (Exception ex)
            {
                throw new Exception($"Request format is not valid: {strValueFormat} - expected format \"segmentname.componentid[.subcomponentid]\" where subcomponentid is optional. Example \"MSH.8.1\" : {ex.Message}");
            }

            if (Segments.Any(x => x.SegmentId == segmentName))
            {
                var segment = Segments.First(x => x.SegmentId == segmentName);
                try
                {

                    if (segment.Fields.TryGetValue(componentId, out strValue))
                    {
                        return strValue;
                    }


                    else if (componentId.Contains("["))
                    {
                        int indexerCount = componentId.Count(x => x == '[');
                        var components = componentId.Split(".");
                        string[] comp2 = new string[0];
                        string[] comp3 = new string[0];

                        var index = components[0].IndexOf("[");
                        var index2 = components[0].IndexOf("]");
                        var tmpcomp = components[0].Remove(index, index2 - index + 1);
                        var comp1 = new string[] { components[0], tmpcomp };
                        if (components.Length >= 2)
                        {
                            index = components[1].IndexOf("[");
                            index2 = components[1].IndexOf("]");
                            tmpcomp = components[1].Remove(index, index2 - index + 1);
                            comp2 = new string[] { components[0], tmpcomp };
                        }
                        if (components.Length >= 3)
                        {
                            index = components[2].IndexOf("[");
                            index2 = components[2].IndexOf("]");
                            tmpcomp = components[2].Remove(index, index2 - index + 1);
                            comp3 = new string[] { components[0], tmpcomp };
                        }

                        for (int i = 0; i < 2; i++)
                        {
                            if (components.Length >= 2)
                            {
                                for (int j = 0; j < 2; j++)
                                {
                                    if (components.Length >= 3)
                                    {
                                        for (int k = 0; k < 2; k++)
                                        {
                                            if (segment.Fields.TryGetValue($"{comp1[i]}.{comp2[j]}.{comp3[k]}", out strValue))
                                            {
                                                return strValue;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (segment.Fields.TryGetValue($"{comp1[i]}.{comp2[j]}", out strValue))
                                        {
                                            return strValue;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                if (segment.Fields.TryGetValue($"{comp1[i]}", out strValue))
                                {
                                    return strValue;
                                }
                            }
                        }

                        /*var index = componentId.IndexOf("[");
                        while (index != -1)
                        {
                            var index2 = componentId.IndexOf("]");
                            componentId = componentId.Remove(index, index2 - index + 1);   
                            index = componentId.IndexOf("[");
                        }
                        if (segment.Fields.TryGetValue(componentId, out strValue))
                        {
                            return strValue;
                        }*/
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Field not available - " + strValueFormat + " Error: " + ex.Message);
                }
            }

            return null;
        }
    }
}