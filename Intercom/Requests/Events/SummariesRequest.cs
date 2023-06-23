using Intercom.Abstractions;
using Newtonsoft.Json;

namespace Intercom.Requests.Events
{
    /// <summary>
    /// Create event summaries for a user. Event summaries are used to track the number of
    /// times an event has occurred, the first time it occurred and the last time it occurred.
    /// </summary>
    public class SummariesRequest : PayloadRequest
    {
        /// <summary>
        /// Your identifier for the user.
        /// </summary>
        public string UserId { get; }
        /// <summary>
        /// A list of event summaries for the user. Each event summary should contain the event name,
        /// the time the event occurred, and the number of times the event occurred.
        ///
        /// The event name should be a past tense 'verb-noun' combination, to improve readability,
        /// for example updated-plan.
        /// </summary>
        public Summaries Summaries { get; }

        public SummariesRequest(string userId, Summaries summaries)
        {
            UserId = userId;
            Summaries = summaries;
        }

        public override object Payload => new
        {
            user_id = UserId,
            event_summaries = new
            {
                event_name = Summaries.EventName,
                count = Summaries.Count,
                first = Summaries.First,
                last = Summaries.Last
            }
        };

        public override string Uri => "events/summaries";
    }

    public class Summaries
    {
        /// <summary>
        /// The name of the event that occurred. A good event name is typically a past tense
        /// 'verb-noun' combination, to improve readability, for example updated-plan.
        /// </summary>
        [JsonProperty("event_name")]
        public string EventName { get; set; }
        /// <summary>
        /// The number of times the event occurred.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        /// <summary>
        /// The first time the event was sent.
        /// </summary>
        [JsonProperty("first")]
        public long First { get; set; }
        /// <summary>
        /// The last time the event was sent
        /// </summary>
        [JsonProperty("last")]
        public long Last { get; set; }
    }
}
