using Intercom.Abstractions;
using Intercom.Models.Tickets;

namespace Intercom.Requests.Tickets.Attributes
{
    /// <summary>
    /// You can update an existing attribute for a ticket type.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/createtickettypeattribute">Documentation</see>
    /// </summary>
    public class UpdateRequest : PayloadRequest
    {
        /// <summary>
        /// The unique identifier for the ticket type which is given by Intercom.
        /// </summary>
        public string Id { get; }
        /// <summary>
        /// The unique identifier for the ticket type attribute which is given by Intercom.
        /// </summary>
        public string AttributeId { get; }
        /// <summary>
        /// The name of the ticket type attribute.
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// The description of the attribute presented to the teammate or contact.
        /// </summary>
        public string Description { get; }

        public UpdateRequest(Attribute attribute, string id)
        {
            Id = id;
            AttributeId = attribute.Id;
            Name = attribute.Name;
            Description = attribute.Description;
        }

        public override object Payload => new
        {
            name = Name,
            description = Description,
        };

        public override string Uri => $"ticket_types/{Id}/attributes/{AttributeId}";
    }
}
