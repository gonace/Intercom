using Intercom.Abstractions;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Intercom.Models.Tickets
{
    public class Type : Model
    {
        /// <summary>
        /// The id of the workspace that the ticket type belongs to.
        /// </summary>
        [JsonProperty("workspace_id")]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// The name of the ticket type.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// The description of the ticket type.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
        /// <summary>
        /// The icon of the ticket type.
        /// </summary>
        [JsonProperty("icon")]
        public string Icon { get; set; }
        /// <summary>
        /// Whether the ticket type is archived or not.
        /// </summary>
        [JsonProperty("archived")]
        public bool Archived { get; set; }

        /// <summary>
        /// A list of attributes associated with a given ticket type.
        /// </summary>
        [JsonProperty("ticket_type_attributes")]
        public Dictionary<string, object> Attributes { get; set; }

        /// <summary>
        /// The date and time the ticket type was created.
        /// </summary>
        [JsonProperty("created_at")]
        public long? CreatedAt { get; set; }
        /// <summary>
        /// The date and time the ticket type was last updated.
        /// </summary>
        [JsonProperty("updated_at")]
        public long? UpdatedAt { get; set; }
    }
}
