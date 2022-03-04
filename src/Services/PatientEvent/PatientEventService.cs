using care.ai.cloud.functions.src.HL7;
using care.ai.cloud.functions.src.PatientData;
using Google.Events.Protobuf.Cloud.PubSub.V1;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace care.ai.cloud.functions.src.Services.PatientEvent
{
    /// <summary>
    /// Patient Event Service.
    /// </summary>
    public class PatientEventService : IPatientEventService
    {     
        private readonly ILogger _logger;

        public IHL7_Message HL7_Message { get; set; }
        public IPatientEvent PatientEvent { get; set; }
        public IPublisherService PublisherService { get; set; }

        public string PatientEventJSON = string.Empty;

        /// <summary>
        /// PatientEventService Constructor.
        /// </summary>
        /// <param name="hL7_Message">IHL7_Message object.</param>
        /// <param name="patientEvent">IPatientEvent object.</param>
        /// <param name="publisherService">IPublisherService object.</param>
        public PatientEventService(ILogger<PatientEventService> logger, IHL7_Message hL7_Message, IPatientEvent patientEvent, IPublisherService publisherService)
        {
            _logger = logger;                   

            HL7_Message = hL7_Message;
            PatientEvent = patientEvent;
            PublisherService = publisherService;
        }

        /// <summary>
        /// Execute Service Action.
        /// </summary>
        /// <param name="data">MessagePublishedData object.</param>
        /// <returns>Task<List<string>></returns>
        public async Task<List<string>> ExecuteAsync(MessagePublishedData data)
        {
            try
            {
                IHL7_Message message = HL7_Message.Factory(data?.Message.TextData);
                IPatientEvent patientEvent = await PatientEvent.FactoryAsync(message);
                PatientEventJSON = await Task.Run(() => JsonConvert.SerializeObject(patientEvent));

                return await PublisherService.PublishAsync(PatientEventJSON);
            }
            catch (Exception ex)
            {
                string exResult = $"PatientEventService > Exception:{ex.Message} | InnerException: {ex.InnerException?.Message ?? "null"} | StackTrace: {ex.StackTrace?.ToString()}";
                _logger.LogInformation(exResult);
                throw new Exception(exResult);
            }

        }
    }
}