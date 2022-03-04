using care.ai.cloud.functions;
using care.ai.cloud.functions.hl7;
using care.ai.cloud.functions.src.HL7;
using care.ai.cloud.functions.src.PatientData;
using care.ai.cloud.functions.src.Services;
using care.ai.cloud.functions.src.Services.PatientEvent;
using care.ai.cloud.functions.src.TenantData;
using CloudNative.CloudEvents;
using Google.Apis.CloudHealthcare.v1;
using Google.Apis.CloudHealthcare.v1.Data;
using Google.Apis.Services;
using Google.Cloud.PubSub.V1;
using Google.Events.Protobuf.Cloud.PubSub.V1;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using pubsub = Google.Events.Protobuf.Cloud.PubSub.V1;

namespace CloudFunctionsTest
{
    /// <summary>
    /// To run these tests properly, you must have your credentials for gCloud set properly. The easiest way to do this is to have the env variable for GOOGLE_APPLICATION_CREDENTIALS
    /// pointed to the json key. 
    /// </summary>
    [TestClass]
    public class processHL7MessageTests : TestingBase
    {     
        private const string _hl7Message = @"projects/development-cloud-services/locations/us-east4/datasets/HL7Msgs/hl7V2Stores/EpicHL7Msgs/messages/j2dpgIJJQ-Yg02h38T95jH6rNmGnXKscdOR5DAi2nn0=";

        /// <summary>
        /// This tests await ExecuteCloudEventRequestAsync(cloudEvent); by creating an instance of processHL7Message
        /// then calling the proper method.
        /// </summary>
        /// <param name="hl7"></param>
        /// <param name="expectedresults">How many message ids should be returned. </param>
        /// <returns>Task</returns>
        [TestMethod]
        [DataRow(_hl7Message, 2)]
        public async Task HandleAsyncTest(string hl7, int expectedresults)
        {
            try
            {
                var data = new MessagePublishedData { Message = new pubsub.PubsubMessage { TextData = hl7 } };
                var cloudEvent = new CloudEvent
                {
                    Type = MessagePublishedData.MessagePublishedCloudEventType,
                    Source = new Uri("//pubsub.googleapis.com", UriKind.RelativeOrAbsolute),
                    Id = Guid.NewGuid().ToString(),
                    Time = DateTimeOffset.UtcNow,
                    Data = data
                };

                var loggerfactory = new LoggerFactory();
                var logger = loggerfactory.CreateLogger<processHL7Message>();

                processHL7Message message = new processHL7Message(logger);

                await message.HandleAsync(cloudEvent, data, new CancellationToken());
                Assert.IsTrue(message.MessageIDs.Count == expectedresults);
            }
            catch (Exception ex)
            {
                HandleAssertFail(ex);
            }
        }

        [TestMethod]
        [DataRow(_hl7Message, 10)]
        public async Task HL7_LoadTest(string hl7, int messageCount)
        {
            try
            {
                IHost host = CreateHost();
                var data = new MessagePublishedData { Message = new pubsub.PubsubMessage { TextData = hl7 } };
                IPatientEventService patientEventService = ActivatorUtilities.CreateInstance<PatientEventService>(host.Services);
                IHL7_Message message = patientEventService.HL7_Message.Factory(data?.Message.TextData);
                IPatientEvent patientEvent = await patientEventService.PatientEvent.FactoryAsync(message);
                string fname = patientEvent.EventData.Patient.Name.First;

                int patientMRN = Convert.ToInt32(patientEvent.EventData.Patient.Mrn);

                string patientEventJSON = string.Empty;
                List<string> messageIDs = new List<string>();

                for (int i = 0; i < messageCount; i++)
                {
                    patientEvent.EventId = Guid.NewGuid().ToString();
                    patientEvent.EventData.Patient.PatientId = 
                        patientEvent.EventData.Patient.Mrn = (patientMRN + i).ToString();

                    patientEvent.EventData.Patient.Name.First = $"{fname}_{i}";

                    patientEventJSON = await Task.Run(() => JsonConvert.SerializeObject(patientEvent));
                    messageIDs.AddRange(await patientEventService.PublisherService.PublishAsync(patientEventJSON));
                }

                Assert.AreEqual(messageIDs.Count, messageCount);
            }
            catch (Exception ex)
            {
                HandleAssertFail(ex);
            }
        }

        /// <summary>
        /// Tests pulling a subscription from gcloud. The longer the wait time the more messages that will be returned from the async method. 
        /// This isn't really testing our code. It is just testing connectivity. 
        /// </summary>
        /// <param name="projectID">The gcloud project we are using. </param>
        /// <param name="subscription">This has to be a valid subscription for this to work. To create a subsription (gcloud pubsub subscriptions create NUNIT --topic=hl7_receiver_1)</param>
        /// <param name="delay">How long to wait for the StartAsync method to return. </param>
        /// <returnsTask></returns>

        [TestMethod]
        [DataRow("development-cloud-services", "NUNIT", 5000)]
        public async Task SubscriberPullAsyncTest(string projectID, string subscription, int delay)
        {
            bool acknowledge = false;

            SubscriptionName subscriptionName = SubscriptionName.FromProjectSubscription(projectID, subscription);
            SubscriberClient subscriber = await SubscriberClient.CreateAsync(subscriptionName);

            int messageCount = 0;
            Task startTask = subscriber.StartAsync((Google.Cloud.PubSub.V1.PubsubMessage message, CancellationToken cancel) =>
            {
                string text = System.Text.Encoding.UTF8.GetString(message.Data.ToArray());
                Console.WriteLine($"Message {message.MessageId}: {text}");
                Interlocked.Increment(ref messageCount);
                return Task.FromResult(acknowledge ? SubscriberClient.Reply.Ack : SubscriberClient.Reply.Nack);
            });

            await Task.Delay(delay);
            await subscriber.StopAsync(CancellationToken.None);

            try
            {
                Assert.IsTrue(messageCount > 0);
            }
            catch (Exception ex)
            {
                HandleAssertFail(ex);
            }
            await startTask;
        }

        [TestMethod]
        public void MessageGetValue()
        {
            HL7_Message message = new HL7_Message(null, null)
            {
                Segments = new List<Segment>()
            };


            Segment seg = new Segment
            {
                SegmentId = "TST",
                Fields = new Dictionary<string, string>()
            };


            seg.Fields.Add("1.1.1", "Test A");
            seg.Fields.Add("1.1.1[0]", "Test B");
            seg.Fields.Add("1.1[0].1", "Test C");
            seg.Fields.Add("1.1[0].1[0]", "Test D");
            seg.Fields.Add("1[0].1.1", "Test E");
            seg.Fields.Add("1[0].1.1[0]", "Test F");
            seg.Fields.Add("1[0].1[0].1", "Test G");
            seg.Fields.Add("1[0].1[0].1[0]", "Test H");

            seg.Fields.Add("1.1.1[1]", "Test I");
            seg.Fields.Add("1.1[1].1", "Test J");
            seg.Fields.Add("1.1[1].1[1]", "Test K");
            seg.Fields.Add("1[1].1.1", "Test L");
            seg.Fields.Add("1[1].1.1[1]", "Test M");
            seg.Fields.Add("1[1].1[1].1", "Test N");
            seg.Fields.Add("1[1].1[1].1[1]", "Test O");

            seg.Fields.Add("1.1.1[2]", "Test P");
            seg.Fields.Add("1.1[2].1", "Test Q");
            seg.Fields.Add("1.1[2].1[2]", "Test R");
            seg.Fields.Add("1[2].1.1", "Test S");
            seg.Fields.Add("1[2].1.1[2]", "Test T");
            seg.Fields.Add("1[2].1[2].1", "Test U");
            seg.Fields.Add("1[2].1[2].1[2]", "Test V");


            message.Segments.Add(seg);

            Mappings.PID.PatientName.GivenName.GetValue(message);

            //FFTT repeatability so param 3 and 4 will always generate a [0] index regardless of if a value is given or not
            var result = Mappings.TestingNoRpt.Field.Component.SubComponent.GetValue(message);               // 1 1 1
            Assert.AreEqual("Test A", result);
            result = Mappings.TestingNoRpt.Field.Component.SubComponent.GetValue(message, null, null, 0);    // 1 1 0
            Assert.AreEqual("Test B", result);
            result = Mappings.TestingNoRpt.Field.Component.SubComponent.GetValue(message, null, 0);          // 1 0 1
            Assert.AreEqual("Test C", result);
            result = Mappings.TestingNoRpt.Field.Component.SubComponent.GetValue(message, null, 0, 0);       // 1 0 0
            Assert.AreEqual("Test D", result);
            result = Mappings.TestingNoRpt.Field.Component.SubComponent.GetValue(message, 0);                // 0 1 1
            Assert.AreEqual("Test E", result);
            result = Mappings.TestingNoRpt.Field.Component.SubComponent.GetValue(message, 0, null, 0);       // 0 1 0
            Assert.AreEqual("Test F", result);
            result = Mappings.TestingNoRpt.Field.Component.SubComponent.GetValue(message, 0, 0, null);       // 0 0 1
            Assert.AreEqual("Test G", result);
            result = Mappings.TestingNoRpt.Field.Component.SubComponent.GetValue(message, 0, 0, 0);          // 0 0 0
            Assert.AreEqual("Test H", result);

            result = Mappings.TestingNoRpt.Field.Component.SubComponent.GetValue(message, null, null, 1);    // 1 1 0
            Assert.AreEqual("Test I", result);
            result = Mappings.TestingNoRpt.Field.Component.SubComponent.GetValue(message, null, 1);          // 1 0 1
            Assert.AreEqual("Test J", result);
            result = Mappings.TestingNoRpt.Field.Component.SubComponent.GetValue(message, null, 1, 1);       // 1 0 0
            Assert.AreEqual("Test K", result);
            result = Mappings.TestingNoRpt.Field.Component.SubComponent.GetValue(message, 1);                // 0 1 1
            Assert.AreEqual("Test L", result);
            result = Mappings.TestingNoRpt.Field.Component.SubComponent.GetValue(message, 1, null, 1);       // 0 1 0
            Assert.AreEqual("Test M", result);
            result = Mappings.TestingNoRpt.Field.Component.SubComponent.GetValue(message, 1, 1, null);       // 0 0 1
            Assert.AreEqual("Test N", result);
            result = Mappings.TestingNoRpt.Field.Component.SubComponent.GetValue(message, 1, 1, 1);          // 0 0 0
            Assert.AreEqual("Test O", result);

            result = Mappings.TestingNoRpt.Field.Component.SubComponent.GetValue(message, null, null, 2);    // 1 1 0
            Assert.AreEqual("Test P", result);
            result = Mappings.TestingNoRpt.Field.Component.SubComponent.GetValue(message, null, 2);          // 1 0 1
            Assert.AreEqual("Test Q", result);
            result = Mappings.TestingNoRpt.Field.Component.SubComponent.GetValue(message, null, 2, 2);       // 1 0 0
            Assert.AreEqual("Test R", result);
            result = Mappings.TestingNoRpt.Field.Component.SubComponent.GetValue(message, 2);                // 0 1 1
            Assert.AreEqual("Test S", result);
            result = Mappings.TestingNoRpt.Field.Component.SubComponent.GetValue(message, 2, null, 2);       // 0 1 0
            Assert.AreEqual("Test T", result);
            result = Mappings.TestingNoRpt.Field.Component.SubComponent.GetValue(message, 2, 2, null);       // 0 0 1
            Assert.AreEqual("Test U", result);
            result = Mappings.TestingNoRpt.Field.Component.SubComponent.GetValue(message, 2, 2, 2);          // 0 0 0
            Assert.AreEqual("Test V", result);


            //add failure checks - ex more indicies provided than are available for field
            seg.Fields.Add("13.15.14", "Test A");
            seg.Fields.Add("13.15.14[0]", "Test B");
            seg.Fields.Add("13.15[0].14", "Test C");
            seg.Fields.Add("13.15[0].14[0]", "Test D");
            seg.Fields.Add("13[0].15.14", "Test E");
            seg.Fields.Add("13[0].15.14[0]", "Test F");
            seg.Fields.Add("13[0].15[0].14", "Test G");
            seg.Fields.Add("13[0].15[0].14[0]", "Test H");

            seg.Fields.Add("13.15.14[1]", "Test I");
            seg.Fields.Add("13.15[1].14", "Test J");
            seg.Fields.Add("13.15[1].14[1]", "Test K");
            seg.Fields.Add("13[1].15.14", "Test L");
            seg.Fields.Add("13[1].15.14[1]", "Test M");
            seg.Fields.Add("13[1].15[1].14", "Test N");
            seg.Fields.Add("13[1].15[1].14[1]", "Test O");

            seg.Fields.Add("13.15.14[2]", "Test P");
            seg.Fields.Add("13.15[2].14", "Test Q");
            seg.Fields.Add("13.15[2].14[2]", "Test R");
            seg.Fields.Add("13[2].15.14", "Test S");
            seg.Fields.Add("13[2].15.14[2]", "Test T");
            seg.Fields.Add("13[2].15[2].14", "Test U");
            seg.Fields.Add("13[2].15[2].14[2]", "Test V");

            seg = new Segment();
            seg.SegmentId = "TST";
            seg.Fields = new Dictionary<string, string>(); ;
            seg.Fields.Add("1", "Test A");
            seg.Fields.Add("1.1", "Test B");
            seg.Fields.Add("1.1.1", "Test B");
        }

        private static IHost CreateHost()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration((context, builder) =>
                {
                    // Get Environment Config.  Set To NULL to debug with production values.
                    string env = Environment.GetEnvironmentVariable("DOTNET_ENVIRONMENT") ??
                        Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyConfigurationAttribute>().Configuration;

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
                    services.AddTransient<IPoc, PointOfCare>();
                    services.AddTransient<ITenant, Tenant>();
                })
                .Build();
        }
    }
}