using Intercom.Abstractions;
using Intercom.Models.Tickets;

namespace Intercom.Requests.Tickets.Types
{
    /// <summary>
    /// You can create a new ticket type.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/post_ticket-types">Documentation</see>
    /// </summary>
    public class CreateRequest : PayloadRequest
    {
        /// <summary>
        /// The name of the ticket type.
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// The description of the ticket type.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The icon of the ticket type.
        /// </summary>
        public string Icon { get; set; }
        /// <summary>
        /// Whether the tickets associated with this ticket type are intended for internal use only or will be shared with customers. This is currently a limited attribute.
        /// </summary>
        public bool IsInternal { get; set; }

        public CreateRequest(Type type)
        {
            Name = type.Name;
            Description = type.Description;
            Icon = type.Icon;
        }

        public CreateRequest(string name)
        {
            Name = name;
        }

        public override object Payload => new
        {
            name = Name,
            description = Description,
            icon = Icon,
            is_internal = IsInternal
        };

        public override string Uri => "ticket_types";
    }
}
