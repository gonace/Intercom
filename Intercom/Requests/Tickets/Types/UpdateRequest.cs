using Intercom.Abstractions;
using Intercom.Models.Tickets;

namespace Intercom.Requests.Tickets.Types
{
    /// <summary>
    /// You can update a ticket type.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/put_ticket-types-id">Documentation</see>
    /// </summary>
    public class UpdateRequest : PayloadRequest
    {
        /// <summary>
        /// The unique identifier for the ticket type which is given by Intercom.
        /// </summary>
        public string Id { get; }
        /// <summary>
        /// The name of the ticket type.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The description of the ticket type.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The icon of the ticket type.
        /// </summary>
        public string Icon { get; set; }
        /// <summary>
        /// The archived status of the ticket type.
        /// </summary>
        public bool Archived { get; set; }
        /// <summary>
        /// Whether the tickets associated with this ticket type are intended for internal use only or will be shared with customers. This is currently a limited attribute.
        /// </summary>
        public bool IsInternal { get; set; }

        public UpdateRequest(Type type)
        {
            Id = type.Id;
            Name = type.Name;
            Description = type.Description;
            Icon = type.Icon;
            Archived = type.Archived;
        }

        public UpdateRequest(string id)
        {
            Id = id;
        }

        public override object Payload => new
        {
            name = Name,
            description = Description,
            icon = Icon,
            archived = Archived,
            is_internal = IsInternal
        };

        public override string Uri => $"ticket_types/{Id}";
    }
}
