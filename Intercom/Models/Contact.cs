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

        [JsonProperty("has_hard_bounced")]
        public bool? HasHardBounced { get; set; }
        [JsonProperty("marked_email_as_spam")]
        public bool? MarkedEmailAsSpam { get; set; }
        [JsonProperty("unsubscribed_from_emails")]
        public bool? UnsubscribedFromEmails { get; set; }
        [JsonProperty("custom_attributes")]
        public Dictionary<string, object> Attributes { get; set; }
        [JsonProperty("os")]
        public string Os { get; set; }

        #region Browser
        [JsonProperty("browser")]
        public string Browser { get; set; }
        [JsonProperty("browser_version")]
        public string BrowserVersion { get; set; }
        [JsonProperty("browser_language")]
        public string BrowserLanguage { get; set; }
        #endregion

        #region Android
        [JsonProperty("android_app_name")]
        public string AndroidAppName { get; set; }
        [JsonProperty("android_app_version")]
        public string AndroidAppVersion { get; set; }
        [JsonProperty("android_device")]
        public string AndroidDevice { get; set; }
        [JsonProperty("android_os_version")]
        public string AndroidOsVersion { get; set; }
        [JsonProperty("android_sdk_version")]
        public string AndroidSdkVersion { get; set; }
        [JsonProperty("android_last_seen_at")]
        public string AndroidLastSeenAt { get; set; }
        #endregion

        #region iOS
        [JsonProperty("ios_app_name")]
        public string IosAppName { get; set; }
        [JsonProperty("ios_app_version")]
        public string IosAppVersion { get; set; }
        [JsonProperty("ios_device")]
        public string IosDevice { get; set; }
        [JsonProperty("ios_os_version")]
        public string IosOsVersion { get; set; }
        [JsonProperty("ios_sdk_version")]
        public string IosSdkVersion { get; set; }
        [JsonProperty("ios_last_seen_at")]
        public string IosLastSeenAt { get; set; }
        #endregion

        [JsonProperty("avatar")]
        public Avatar Avatar { get; set; }
        [JsonProperty("location_data")]
        public Location Location { get; set; }

        [JsonConverter(typeof(CompaniesConverter))]
        [JsonProperty("companies")]
        public IEnumerable<Company> Companies { get; set; }
        [JsonConverter(typeof(NotesConverter))]
        [JsonProperty("notes")]
        public IEnumerable<Note> Notes { get; set; }
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
