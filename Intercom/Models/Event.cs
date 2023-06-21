using Intercom.Abstractions;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Intercom.Models
{
    /// <summary>
    /// Events are how you can submit user activity to Intercom.
    /// Once you're sending Intercom event data, you can filter your user base with those events and create
    /// Auto Messages to send whenever an event occurs.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/the-data-event-model">Documentation</see>
    /// </summary>
    public class Event : Model
    {
        /// <summary>
        /// Your identifier for the user.
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
        /// <summary>
        /// The Intercom identifier for the user.
        /// </summary>
        [JsonProperty("intercom_user_id")]
        public string IntercomUserId { get; set; }

        /// <summary>
        /// The name of the event that occurred. This is presented to your App's admins when filtering and creating segments - a good
        /// event name is typically a past tense 'verb-noun' combination, to improve readability, for example updated-plan.
        /// </summary>
        [JsonProperty("event_name")]
        public string EventName { get; set; }
        /// <summary>
        /// An email address for your user. An email should only be used where your application uses email to uniquely identify users.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }
        /// <summary>
        /// Optional metadata about the event.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// The time the event occurred as a UTC Unix timestamp.
        /// </summary>
        [JsonProperty("created_at")]
        public long? CreatedAt { get; set; }
    }
}
