using Google.Events.Protobuf.Cloud.PubSub.V1;
using System.Threading.Tasks;

namespace care.ai.cloud.functions.src.Services.PatientEvent
{
    interface IPatientEventService
    {
        Task ExecuteAsync(MessagePublishedData data);
    }
}