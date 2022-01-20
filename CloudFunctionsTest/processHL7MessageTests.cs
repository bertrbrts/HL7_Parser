using care.ai.cloud.functions;
using CloudNative.CloudEvents;
using Google.Cloud.Functions.Testing;
using Google.Events.Protobuf.Cloud.PubSub.V1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

namespace CloudFunctionsTest
{
    [TestClass]
    public class processHL7MessageTests : FunctionTestBase<processHL7Message>
    {
        
        private const string _hl7Message = @"projects/onboarding-playground-32819/locations/us-east4/datasets/EpicHL7DS/hl7V2Stores/hl7v2Msgs/messages/ijjUhCjDGQqm8z-6kDWXJcvfelNQi2bFbzv7rnNEJxs=";

        [TestMethod]
        public async Task HandleAsyncTest()
        {
            try
            {
                var data = new MessagePublishedData { Message = new PubsubMessage { TextData = _hl7Message } };
                var cloudEvent = new CloudEvent
                {
                    Type = MessagePublishedData.MessagePublishedCloudEventType,
                    Source = new Uri("//pubsub.googleapis.com", UriKind.RelativeOrAbsolute),
                    Id = Guid.NewGuid().ToString(),
                    Time = DateTimeOffset.UtcNow,
                    Data = data
                };

                await ExecuteCloudEventRequestAsync(cloudEvent);
                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);               
            }
        }
    }
}