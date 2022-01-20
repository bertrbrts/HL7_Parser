using Google.Cloud.PubSub.V1;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace care.ai.cloud.functions.src.Services
{
    /// <summary>
    /// Publisher Service.
    /// </summary>
    public class PublisherService : IPublisherService
    {
        private readonly IConfiguration _config;

        /// <summary>
        /// Publisher Service Constructor.
        /// </summary>
        /// <param name="config">IConfiguration object.</param>
        public PublisherService(IConfiguration config)
        {
            _config = config;
        }

        /// <summary>
        /// Publisher Service Publish Action.
        /// </summary>
        /// <param name="data">data to publish.</param>
        /// <returns>Task<List<string>></returns>
        public async Task<List<string>> PublishAsync(string data)
        {
            try
            {
                List<string> messageIDs = new List<string>();

                var publisher = _config.GetSection("PublishingService:Publishers").Get<Publisher[]>().ToList();

                foreach (var p in publisher)
                {
                    TopicName topicName = TopicName.FromProjectTopic(p.ProjectID, p.TopicID);
                    PublisherClient pubClient = PublisherClient.Create(topicName);
                    messageIDs.Add(await pubClient.PublishAsync(data));
                }

                return messageIDs;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}