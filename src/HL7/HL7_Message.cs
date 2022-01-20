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
        [JsonProperty("segments")]
        public virtual IList<Segment> Segments { get; set; }
        public virtual string ETag { get; set; }
        private static IClientService _service;
        public HL7_Message(IClientService service)
        {
            _service = service;
        }
        public IHL7_Message Create(string message)
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