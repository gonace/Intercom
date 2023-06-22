using Intercom.Abstractions;
using Newtonsoft.Json;

namespace Intercom.Models.Tickets
{
    public class Attribute : Model
    {
        /// <summary>
        /// The id of the workspace that the ticket type attribute belongs to.
        /// </summary>
        [JsonProperty("workspace_id")]
        public string WorkspaceId { get; set; }
        /// <summary>
        /// The id of the ticket type that the attribute belongs to.
        /// </summary>
        [JsonProperty("ticket_type_id")]
        public int TicketTypeId { get; set; }

        /// <summary>
        /// The name of the ticket type attribute.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// The description of the ticket type attribute.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
        /// <summary>
        /// The type of the data attribute (allowed values: "string list integer decimal boolean datetime files").
        /// </summary>
        [JsonProperty("data_type")]
        public string DataType { get; set; }
        //TODO: Fix this
        /// <summary>
        /// Input options for the attribute.
        /// </summary>
        [JsonProperty("input_options")]
        public object InputOptions { get; set; }
        /// <summary>
        /// The order of the attribute against other attributes.
        /// </summary>
        [JsonProperty("order")]
        public int Order { get; set; }
        /// <summary>
        /// Whether the attribute is required or not for teammates.
        /// </summary>
        [JsonProperty("required_to_create")]
        public bool RequiredToCreate { get; set; }
        /// <summary>
        /// Whether the attribute is required or not for contacts.
        /// </summary>
        [JsonProperty("required_to_create_for_contacts")]
        public bool RequiredToCreateForContacts { get; set; }
        /// <summary>
        /// Whether the attribute is visible or not to teammates.
        /// </summary>
        [JsonProperty("visible_on_create")]
        public bool VisibleOnCreate { get; set; }
        /// <summary>
        /// Whether the attribute is visible or not to contacts.
        /// </summary>
        [JsonProperty("visible_to_contacts")]
        public bool VisibleToContacts { get; set; }
        /// <summary>
        /// Whether the attribute is built in or not.
        /// </summary>
        [JsonProperty("default")]
        public bool Default { get; set; }
        /// <summary>
        /// Whether the ticket type attribute is archived or not.
        /// </summary>
        [JsonProperty("archived")]
        public bool Archived { get; set; }

        /// <summary>
        /// The date and time the ticket type attribute was created.
        /// </summary>
        [JsonProperty("created_at")]
        public long? CreatedAt { get; set; }
        /// <summary>
        /// The date and time the ticket type attribute was last updated.
        /// </summary>
        [JsonProperty("updated_at")]
        public long? UpdatedAt { get; set; }
    }
}
