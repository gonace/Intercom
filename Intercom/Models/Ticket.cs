using Intercom.Abstractions;
using Intercom.Models.Tickets;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Intercom.Models
{
    /// <summary>
    /// Tickets are how you can capture complex requests, allowing you to collaborate
    /// and keep track of progress until a resolution is reached.
    ///
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/the-ticket-model">Documentation</see>
    /// </summary>
    public class Ticket : Model
    {
        /// <summary>
        /// The state the ticket is currently in.
        /// </summary>
        [JsonProperty("ticket_state")]
        public string TicketState { get; set; }
        /// <summary>
        /// A ticket type, used to define the data fields to be captured in a ticket.
        /// </summary>
        [JsonProperty("ticket_type")]
        public Type TicketType { get; set; }
        /// <summary>
        /// The list of contacts (users or leads) affected by a ticket.
        /// </summary>
        [JsonProperty("contacts")]
        public Tickets.Contacts Contacts { get; set; }
        /// <summary>
        /// The id representing the admin assigned to the ticket.
        /// </summary>
        [JsonProperty("admin_assignee_id")]
        public string AdminAssigneeId { get; set; }
        /// <summary>
        /// The id representing the team assigned to the ticket.
        /// </summary>
        [JsonProperty("team_assignee_id")]
        public string TeamAssigneeId { get; set; }

        /// <summary>
        /// An object containing the different attributes associated to the ticket as key-value pairs.
        /// For the default title and description attributes, the keys are _default_title_ and _default_description_.
        /// </summary>
        [JsonProperty("ticket_attributes")]
        public Dictionary<string, object> Attributes { get; set; }

        /// <summary>
        /// The time the ticket was created.
        /// </summary>
        [JsonProperty("created_at")]
        public long? CreatedAt { get; set; }
        /// <summary>
        /// The last time the ticket was updated.
        /// </summary>
        [JsonProperty("updated_at")]
        public long? UpdatedAt { get; set; }
    }
}
