using Intercom.Abstractions;
using Intercom.Models;
using System.Collections.Generic;

namespace Intercom.Requests.Tickets
{
    /// <summary>
    /// You can create a new ticket.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/post_tickets">Documentation</see>
    /// </summary>
    public class CreateRequest : PayloadRequest
    {
        /// <summary>
        /// The ID of the type of ticket you want to create.
        /// </summary>
        public string TypeId { get; }
        /// <summary>
        /// The list of contacts (users or leads) affected by this ticket.
        /// Currently only one is allowed.
        /// </summary>
        public IEnumerable<Contact> Contacts { get; set; }
        /// <summary>
        /// The attributes set on the ticket.
        ///
        /// When setting the default title and description attributes, the attribute keys that should be used are _default_title_ and
        /// _default_description_. When setting ticket type attributes of the list attribute type, the key should be the attribute
        /// name and the value of the attribute should be the list item id, obtainable by listing the ticket type.
        ///
        /// For example, if the ticket type has an attribute called priority of type list, the key should be priority and the value
        /// of the attribute should be the guid of the list item (e.g. de1825a0-0164-4070-8ca6-13e22462fa7e).
        /// </summary>
        public Dictionary<string, object> Attributes { get; set; }

        public CreateRequest(Ticket ticket)
        {
            TypeId = ticket.TicketType.Id;
            Contacts = ticket.Contacts.Items;
            Attributes = ticket.Attributes;
        }

        public CreateRequest(string typeId)
        {
            TypeId = typeId;
        }

        public override object Payload => new
        {
            ticket_type_id = TypeId,
            contacts = Contacts,
            ticket_attributes = Attributes
        };

        public override string Uri => "tickets";
    }
}
