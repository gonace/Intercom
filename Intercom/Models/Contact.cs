using Intercom.Abstractions;
using Intercom.Converters;
using Intercom.Models.Contacts;
using Intercom.Models.Shared;
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
        /// <summary>
        /// The Intercom defined code of the workspace the company is associated to.
        /// </summary>
        [JsonProperty("app_id")]
        public string AppId { get; set; }
        [JsonProperty("external_id")]
        public string ExternalId { get; set; }
        /// <summary>
        /// The id of an admin that has been assigned account ownership of the contact.
        /// </summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }
        /// <summary>
        /// The id of the workspace which the contact belongs to.
        /// </summary>
        [JsonProperty("workspace_id")]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// The contacts name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// The contacts email.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }
        /// <summary>
        /// The contacts phone.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }
        /// <summary>
        /// The contacts phone number normalized to the E164 format
        /// </summary>
        [JsonProperty("formatted_phone")]
        public string FormattedPhone { get; set; }
        /// <summary>
        /// The role of the contact.
        /// </summary>
        [JsonProperty("role")]
        public string Role { get; set; }
        /// <summary>
        /// A preferred language setting for the contact, used by the Intercom Messenger even if their browser settings change.
        /// </summary>
        [JsonProperty("language_override")]
        public string LanguageOverride { get; set; }

        /// <summary>
        /// Whether the contact has had an email sent to them hard bounce.
        /// </summary>
        [JsonProperty("has_hard_bounced")]
        public bool? HasHardBounced { get; set; }
        /// <summary>
        /// Whether the contact has marked an email sent to them as spam.
        /// </summary>
        [JsonProperty("marked_email_as_spam")]
        public bool? MarkedEmailAsSpam { get; set; }
        /// <summary>
        /// Whether the contact is unsubscribed from emails.
        /// </summary>
        [JsonProperty("unsubscribed_from_emails")]
        public bool? UnsubscribedFromEmails { get; set; }
        /// <summary>
        /// The custom attributes which are set for the contact.
        /// </summary>
        [JsonProperty("custom_attributes")]
        public Dictionary<string, object> Attributes { get; set; }
        /// <summary>
        /// The operating system which the contact is using.
        /// </summary>
        [JsonProperty("os")]
        public string Os { get; set; }

        #region Browser
        /// <summary>
        /// The name of the browser which the contact is using.
        /// </summary>
        [JsonProperty("browser")]
        public string Browser { get; set; }
        /// <summary>
        /// The version of the browser which the contact is using.
        /// </summary>
        [JsonProperty("browser_version")]
        public string BrowserVersion { get; set; }
        /// <summary>
        /// The language set by the browser which the contact is using.
        /// </summary>
        [JsonProperty("browser_language")]
        public string BrowserLanguage { get; set; }
        #endregion

        #region Android
        /// <summary>
        /// The name of the Android app which the contact is using.
        /// </summary>
        [JsonProperty("android_app_name")]
        public string AndroidAppName { get; set; }
        /// <summary>
        /// The version of the Android app which the contact is using.
        /// </summary>
        [JsonProperty("android_app_version")]
        public string AndroidAppVersion { get; set; }
        /// <summary>
        /// The Android device which the contact is using.
        /// </summary>
        [JsonProperty("android_device")]
        public string AndroidDevice { get; set; }
        /// <summary>
        /// The version of the Android OS which the contact is using.
        /// </summary>
        [JsonProperty("android_os_version")]
        public string AndroidOsVersion { get; set; }
        /// <summary>
        /// The version of the Android SDK which the contact is using.
        /// </summary>
        [JsonProperty("android_sdk_version")]
        public string AndroidSdkVersion { get; set; }
        /// <summary>
        /// 	(UNIX timestamp) The time when the contact was last seen on an Android device.
        /// </summary>
        [JsonProperty("android_last_seen_at")]
        public string AndroidLastSeenAt { get; set; }
        #endregion

        #region iOS
        /// <summary>
        /// The name of the iOS app which the contact is using.
        /// </summary>
        [JsonProperty("ios_app_name")]
        public string IosAppName { get; set; }
        /// <summary>
        /// The version of the iOS app which the contact is using.
        /// </summary>
        [JsonProperty("ios_app_version")]
        public string IosAppVersion { get; set; }
        /// <summary>
        /// The iOS device which the contact is using.
        /// </summary>
        [JsonProperty("ios_device")]
        public string IosDevice { get; set; }
        /// <summary>
        /// The version of iOS which the contact is using.
        /// </summary>
        [JsonProperty("ios_os_version")]
        public string IosOsVersion { get; set; }
        /// <summary>
        /// The version of the iOS SDK which the contact is using.
        /// </summary>
        [JsonProperty("ios_sdk_version")]
        public string IosSdkVersion { get; set; }
        /// <summary>
        /// (UNIX timestamp) The last time the contact used the iOS app.
        /// </summary>
        [JsonProperty("ios_last_seen_at")]
        public string IosLastSeenAt { get; set; }
        #endregion

        [JsonProperty("avatar")]
        public Avatar Avatar { get; set; }
        /// <summary>
        /// An object containing location meta data about a Intercom contact.
        /// </summary>
        [JsonProperty("location_data")]
        public Location Location { get; set; }

        /// <summary>
        /// An object containing companies meta data about the companies that a contact has.
        /// </summary>
        [JsonProperty("companies")]
        public CompaniesMetadata Companies { get; set; }
        /// <summary>
        /// An object containing notes meta data about the notes that a contact has.
        /// </summary>
        [JsonProperty("notes")]
        public NotesMetadata Notes { get; set; }
        /// <summary>
        /// An object containing tags meta data about the tags that a contact has.
        /// </summary>
        [JsonProperty("tags")]
        public TagsMetadata Tags { get; set; }
        /// <summary>
        /// An object containing social profiles that a contact has.
        /// </summary>
        [JsonConverter(typeof(SocialProfilesConverter))]
        [JsonProperty("social_profiles")]
        public IEnumerable<SocialProfiles> SocialProfiles { get; set; }

        /// <summary>
        /// (UNIX timestamp) The time when the contact was last messaged.
        /// </summary>
        [JsonProperty("last_contacted_at")]
        public long? LastContactedAt { get; set; }
        /// <summary>
        /// (UNIX timestamp) The time when the contact last clicked a link in an email.
        /// </summary>
        [JsonProperty("last_email_clicked_at")]
        public long? LastEmailClickedAt { get; set; }
        /// <summary>
        /// (UNIX timestamp) The time when the contact last opened an email.
        /// </summary>
        [JsonProperty("last_email_opened_at")]
        public long? LastEmailOpenedAt { get; set; }
        [JsonProperty("last_request_at")]
        public long? LastRequestAt { get; set; }
        /// <summary>
        /// (UNIX timestamp) The time when the contact last messaged in.
        /// </summary>
        [JsonProperty("last_replied_at")]
        public long? LastRepliedAt { get; set; }
        /// <summary>
        /// (UNIX timestamp) The time when the contact was last seen (either where the Intercom Messenger
        /// was installed or when specified manually).
        /// </summary>
        [JsonProperty("last_seen_at")]
        public long? LastSeenAt { get; set; }
        /// <summary>
        /// (UNIX timestamp) The time specified for when a contact signed up.
        /// </summary>
        [JsonProperty("signed_up_at")]
        public long? SignedUpdAt { get; set; }
        /// <summary>
        /// (UNIX timestamp) The time when the contact was created.
        /// </summary>
        [JsonProperty("created_at")]
        public long? CreatedAt { get; set; }
        /// <summary>
        /// (UNIX timestamp) The time when the contact was last updated.
        /// </summary>
        [JsonProperty("updated_at")]
        public long? UpdatedAt { get; set; }
    }
}
