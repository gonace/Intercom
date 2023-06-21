using Intercom.Abstractions;
using Intercom.Models.Notes;
using Intercom.Models.Shared;
using Newtonsoft.Json;

namespace Intercom.Models
{
    /// <summary>
    /// Notes allow you to annotate and comment on your contacts.
    ///
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/the-contact-model">Documentation</see>
    /// </summary>
    public class Note : Model
    {
        [JsonProperty("body")]
        public string Body { get; set; }
        /// <summary>
        /// Admins are teammate accounts that have access to a workspace.
        /// </summary>
        public Author Author { get; set; }
        /// <summary>
        /// Represents the contact that the note was created about.
        /// </summary>
        public Reference User { get; set; }

        /// <summary>1
        ///	The time the note was created.
        /// </summary>
        [JsonProperty("created_at")]
        public long? CreatedAt { get; set; }
    }
}
