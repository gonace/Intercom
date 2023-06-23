using Intercom.Abstractions;
using Intercom.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Intercom.Requests.Events
{
    /// <summary>
    /// You will need an Access Token that has write permissions to send Events.
    /// Once you have a key you can submit events via POST to the Events resource, which is
    /// located at https://api.intercom.io/events, or you can send events using one of the
    /// client libraries.
    ///
    /// When working with the HTTP API directly a client should send the event with a
    /// Content-Type of application/json.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/createdataevent">Documentation</see>
    /// </summary>
    public class CreateRequest : PayloadRequest
    {
        /// <summary>
        /// The name of the event that occurred. This is presented to your App's admins when filtering and creating
        /// segments - a good event name is typically a past tense 'verb-noun' combination, to improve readability,
        /// for example updated-plan.
        /// </summary>
        [JsonProperty("event_name")]
        public string EventName { get; }
        /// <summary>
        /// The time the event occurred as a UTC Unix timestamp.
        /// </summary>
        [JsonProperty("created_at")]
        public long? CreatedAt { get; }
        /// <summary>
        /// Your identifier for the user.
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; }
        /// <summary>
        /// Your identifier for a lead or a user.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; }
        /// <summary>
        /// An email address for your user. An email should only be used where your application uses email to
        /// uniquely identify users.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }
        /// <summary>
        /// Optional metadata about the event.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, object> Metadata { get; set; }

        public CreateRequest(Event @event)
        {
            EventName = @event.EventName;
            CreatedAt = @event.CreatedAt;
            UserId = @event.UserId;
            Id = @event.Id;
            Email = @event.Email;
            Metadata = @event.Metadata;
        }

        public override object Payload => new
        {
            event_name = EventName,
            created_at = CreatedAt,
            user_id = UserId,
            id = Id,
            email = Email,
            metadata = Metadata
        };

        public override string Uri => "events";
    }
}
