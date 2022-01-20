using care.ai.cloud.functions.src.HL7;
using care.ai.cloud.functions.src.PatientData;
using care.ai.cloud.functions.src.Services;
using care.ai.cloud.functions.src.Services.PatientEvent;
using care.ai.cloud.functions.src.TenantData;
using CloudNative.CloudEvents;
using Google.Apis.CloudHealthcare.v1;
using Google.Apis.Services;
using Google.Cloud.Functions.Framework;
using Google.Events.Protobuf.Cloud.PubSub.V1;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace care.ai.cloud.functions
{
    public class processHL7Message : ICloudEventFunction<MessagePublishedData>
    {
        private readonly ILogger _logger;

        public MessagePublishedData _data;
        public processHL7Message(ILogger<processHL7Message> logger)
        {
            _logger = logger;
        }

        public Task HandleAsync(CloudEvent cloudEvent, MessagePublishedData data, CancellationToken cancellationToken)
        {
            _data = data;
            _logger.LogInformation($"HL7 Message Received: {_data.Message?.TextData}");

            try
            {
                IHost host = CreateHost();
                IPatientEventService patientEventService = ActivatorUtilities.CreateInstance<PatientEventService>(host.Services);
                Task.Run(async () => await patientEventService.ExecuteAsync(data)).Wait();
            }
            catch (Exception ex)
            {
                _logger.LogInformation($"Exception:{ex.Message} | InnerException: {ex.InnerException?.Message ?? "null"} | StackTrace: {ex.StackTrace?.ToString()}");
                throw;
            }

            return Task.CompletedTask;
        }

        private static IHost CreateHost()
        {
            return Host.CreateDefaultBuilder()                
                .ConfigureAppConfiguration((context, builder) =>
                {
                    // Get Environment Config
                    string env = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyConfigurationAttribute>().Configuration;
                    builder.SetBasePath(Directory.GetCurrentDirectory() + @"/AppSettings/")
                        .AddJsonFile($"appsettings.json", optional: false, reloadOnChange: true)
                        .AddJsonFile($"appsettings.{env}.json", optional: true);
                })
                .ConfigureServices((context, services) =>
                {
                    services.AddSingleton<IClientService, CloudHealthcareService>();
                    services.AddSingleton<IHL7_Message, HL7_Message>();
                    services.AddSingleton<IPatientEvent, PatientEvent>();
                    services.AddTransient<IPublisherService, PublisherService>();
                    services.AddTransient<IAddress, Address>();
                    services.AddTransient<IEvent, Event>();
                    services.AddTransient<IEventData, EventData>();
                    services.AddTransient<IName, Name>();
                    services.AddTransient<IPatient, Patient>();
                    services.AddTransient<IPoc, Poc>();
                    services.AddTransient<ITenant, Tenant>();
                })
                .Build();
        }
    }
}