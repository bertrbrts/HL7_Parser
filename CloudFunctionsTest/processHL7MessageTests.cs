using care.ai.cloud.functions;
using care.ai.cloud.functions.hl7;
using care.ai.cloud.functions.src.HL7;
using CloudNative.CloudEvents;
using Google.Apis.CloudHealthcare.v1.Data;
using Google.Cloud.Functions.Testing;
using Google.Events.Protobuf.Cloud.PubSub.V1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CloudFunctionsTest
{
    [TestClass]
    public class processHL7MessageTests : FunctionTestBase<processHL7Message>
    {
        
        private const string _hl7Message = @"projects/onboarding-playground-32819/locations/us-east4/datasets/EpicHL7DS/hl7V2Stores/hl7v2Msgs/messages/xhImWV2sbYj3waAhALHokeZxqAVgLEKfE58EWCv49Sg=";

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

        [TestMethod]
        public async Task MessageGetValue()
        {
            HL7_Message message = new HL7_Message(null);
            message.Segments = new List<Segment>();


            Segment seg = new Segment();
            seg.SegmentId = "TST";
            seg.Fields = new Dictionary<string, string>();


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
           /* seg.Fields.Add("13.15.14", "Test A");
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
            seg.Fields.Add("1.1.1", "Test B");*/

        }


    }
}