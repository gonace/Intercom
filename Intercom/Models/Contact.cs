using Intercom.Abstractions;
using Intercom.Converters;
using Intercom.Models.Embedded;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Intercom.Models
{
    /// <summary>
    /// Our Contacts API is a central place to gather all information and take
    /// actions on your contacts (ie. users and leads), such as fetching, searching,
    /// creating, updating, and deleting.
    ///
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/the-contact-model">Documentation</see>
    /// </summary>
    public class Contact : Model
    {
        [JsonProperty("app_id")]
        public string AppId { get; set; }
        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }
        [JsonProperty("user_id")]
        public string UserId { get; set; }
        [JsonProperty("workspace_id")]
        public string WorkspaceId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("phone")]
        public string Phone { get; set; }
        [JsonProperty("formatted_phone")]
        public string FormattedPhone { get; set; }
        [JsonProperty("pseudonym")]
        public string Pseudonym { get; set; }
        [JsonProperty("role")]
        public string Role { get; set; }
        [JsonProperty("anonymous")]
        public bool? Anonymous { get; set; }
        [JsonProperty("session_count")]
        public int? SessionCount { get; set; }
        [JsonProperty("language_override")]
        public string LanguageOverride { get; set; }

        [JsonProperty("marked_email_as_spam")]
        public bool? MarkedEmailAsSpam { get; set; }
        [JsonProperty("has_hard_bounced")]
        public bool? HasHardBounced { get; set; }
        [JsonProperty("unsubscribed_from_emails")]
        public bool? UnsubscribedFromEmails { get; set; }
        [JsonProperty("custom_attributes")]
        public Dictionary<string, object> Attributes { get; set; }

        [JsonProperty("avatar")]
        public Avatar Avatar { get; set; }
        [JsonProperty("location_data")]
        public Location Location { get; set; }

        [JsonConverter(typeof(CompaniesConverter))]
        [JsonProperty("companies")]
        public IEnumerable<Company> Companies { get; set; }
        [JsonConverter(typeof(SegmentsConverter))]
        [JsonProperty("segments")]
        public IEnumerable<Segment> Segments { get; set; }
        [JsonConverter(typeof(TagsConverter))]
        [JsonProperty("tags")]
        public IEnumerable<Tag> Tags { get; set; }


        [JsonProperty("last_contacted_at")]
        public long? LastContactedAt { get; set; }
        [JsonProperty("last_email_clicked_at")]
        public long? LastEmailClickedAt { get; set; }
        [JsonProperty("last_email_opened_at")]
        public long? LastEmailOpenedAt { get; set; }
        [JsonProperty("last_request_at")]
        public long? LastRequestAt { get; set; }
        [JsonProperty("last_replied_at")]
        public long? LastRepliedAt { get; set; }
        [JsonProperty("last_seen_at")]
        public long? LastSeenAt { get; set; }
        [JsonProperty("signed_up_at")]
        public long? RegisteredAt { get; set; }
        [JsonProperty("remote_created_at")]
        public long? RemoteCreatedAt { get; set; }
        [JsonProperty("created_at")]
        public long? CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public long? UpdatedAt { get; set; }
    }
}
