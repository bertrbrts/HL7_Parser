using care.ai.cloud.functions;
using CloudNative.CloudEvents;
using Google.Cloud.PubSub.V1;
using pubsub = Google.Events.Protobuf.Cloud.PubSub.V1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.Extensions.Logging;

namespace CloudFunctionsTest
{
    /// <summary>
    /// To run these tests properly, you must have your credentials for gCloud set properly. The easiest way to do this is to have the env variable for GOOGLE_APPLICATION_CREDENTIALS
    /// pointed to the json key. 
    /// </summary>
    [TestClass]
    public class processHL7MessageTests : TestingBase
    {

        private const string _hl7Message = @"projects/onboarding-playground-32819/locations/us-east4/datasets/EpicHL7DS/hl7V2Stores/hl7v2Msgs/messages/xhImWV2sbYj3waAhALHokeZxqAVgLEKfE58EWCv49Sg=";

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
                var data = new pubsub.MessagePublishedData { Message = new pubsub.PubsubMessage { TextData = hl7 } };
                var cloudEvent = new CloudEvent
                {
                    Type = pubsub.MessagePublishedData.MessagePublishedCloudEventType,
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

        /// <summary>
        /// Tests pulling a subscription from gcloud. The longer the wait time the more messages that will be returned from the async method. 
        /// This isn't really testing our code. It is just testing connectivity. 
        /// </summary>
        /// <param name="projectID">The gcloud project we are using. </param>
        /// <param name="subscription">This has to be a valid subscription for this to work. To create a subsription (gcloud pubsub subscriptions create NUNIT --topic=hl7_receiver_1)</param>
        /// <param name="delay">How long to wait for the StartAsync method to return. </param>
        /// <returnsTask></returns>

        [TestMethod]
        [DataRow("onboarding-playground-32819", "NUNIT", 5000)]
        public async Task SubscriberPullAsyncTest(string projectID, string subscription, int delay)
        {
            bool acknowledge = false;

            SubscriptionName subscriptionName = SubscriptionName.FromProjectSubscription(projectID, subscription);
            SubscriberClient subscriber = await SubscriberClient.CreateAsync(subscriptionName);

            int messageCount = 0;
            Task startTask = subscriber.StartAsync((PubsubMessage message, CancellationToken cancel) =>
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

    }
}