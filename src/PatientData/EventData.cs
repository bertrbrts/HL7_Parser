using care.ai.cloud.functions.src.HL7;
using Newtonsoft.Json;

namespace care.ai.cloud.functions.src.PatientData
{
    /// <summary>
    /// Patient Event Data.
    /// </summary>
    public partial class EventData : IEventData
    {
        private readonly IPatient _patient;

        /// <summary>
        /// IPatient Object.
        /// </summary>
        [JsonProperty("patient")]
        public IPatient Patient { get; set; }

        /// <summary>
        /// Patient Event Data Default Constructor.
        /// </summary>
        public EventData() { }
        /// <summary>
        /// Patient Event Data Constructor.
        /// </summary>
        /// <param name="patient">IPatient object.</param>
        public EventData(IPatient patient)
        {
            _patient = patient;
        }

        /// <summary>
        /// Event Data Factory.
        /// </summary>
        /// <param name="message">IHL7_Message object.</param>
        /// <returns>IEventData object.</returns>
        public IEventData Factory(IHL7_Message message)
        {
            return new EventData
            {
                Patient = _patient.Factory(message)
            };
        }
    }
}