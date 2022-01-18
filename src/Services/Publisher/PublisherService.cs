using Google.Cloud.PubSub.V1;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace care.ai.cloud.functions.src.Services
{
    public class PublisherService : IPublisherService
    {
        private readonly IConfiguration _config;

        public const string PublishingService = "PublishingService:Publishers";

        public PublisherService(IConfiguration config)
        {
            _config = config;
        }

        public async Task<string> PublishAsync(string data)
        {
            try
            {
                List<string> messageIDs = new List<string>();

                var publisher = _config.GetSection(PublishingService).Get<Publisher[]>().ToList();

                foreach (var p in publisher)
                {
                    TopicName topicName = TopicName.FromProjectTopic(p.ProjectID, p.TopicID);
                    PublisherClient pubClient = PublisherClient.Create(topicName);
                    messageIDs.Add(await pubClient.PublishAsync(data));
                }

                return "Publish Successful";
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}