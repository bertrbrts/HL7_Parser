using Google.Events.Protobuf.Cloud.PubSub.V1;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace care.ai.cloud.functions.src.Services.PatientEvent
{
    interface IPatientEventService
    {
        Task<List<string>> ExecuteAsync(MessagePublishedData data);
    }
}