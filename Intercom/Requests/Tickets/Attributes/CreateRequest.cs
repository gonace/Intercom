using Intercom.Abstractions;
using Intercom.Constants.Attributes;
using Intercom.Models.Tickets;

namespace Intercom.Requests.Tickets.Attributes
{
    /// <summary>
    /// You can create a new attribute for a ticket type.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/createtickettypeattribute">Documentation</see>
    /// </summary>
    public class CreateRequest : PayloadRequest
    {
        /// <summary>
        /// The unique identifier for the ticket type which is given by Intercom.
        /// </summary>
        public string Id { get; }
        /// <summary>
        /// The name of the ticket type attribute.
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// The description of the attribute presented to the teammate or contact.
        /// </summary>
        public string Description { get; }
        /// <summary>
        /// The data type of the attribute.
        /// </summary>
        public DataType DataType { get; }
        /// <summary>
        /// Whether the attribute is required to be filled in when teammates are creating the ticket in Inbox.
        /// </summary>
        public bool? RequiredToCreate { get; set; }
        /// <summary>
        /// Whether the attribute is required to be filled in when contacts are creating the ticket in Messenger.
        /// </summary>
        public bool? RequiredToCreateForContacts { get; set; }
        /// <summary>
        /// Whether the attribute is visible to teammates when creating a ticket in Inbox.
        /// </summary>
        public bool? VisibleOnCreate { get; set; }
        /// <summary>
        /// Whether the attribute is visible to contacts when creating a ticket in Messenger.
        /// </summary>
        public bool? VisibleToContacts { get; set; }
        /// <summary>
        /// Whether the attribute allows multiple lines of text (only applicable to string attributes).
        /// </summary>
        public bool? Multiline { get; set; }
        /// <summary>
        /// A comma delimited list of items for the attribute value (only applicable to list attributes).
        /// </summary>
        public string ListItems { get; set; }
        /// <summary>
        /// Whether the attribute allows multiple files to be attached to it (only applicable to file attributes).
        /// </summary>
        public bool? AllowMultipleValues { get; set; }

        public CreateRequest(Attribute attribute)
        {
            Id = attribute.Id;
            Name = attribute.Name;
            Description = attribute.Description;
            RequiredToCreate = attribute.RequiredToCreate;
            RequiredToCreateForContacts = attribute.RequiredToCreateForContacts;
            VisibleOnCreate = attribute.VisibleOnCreate;
            VisibleToContacts = attribute.VisibleToContacts;
        }

        public CreateRequest(string id, string name, string description, DataType dataType)
        {
            Id = id;
            Name = name;
            Description = description;
            DataType = dataType;
        }

        public override object Payload => new
        {
            name = Name,
            description = Description,
            dataType = DataType,
            required_to_create = RequiredToCreate,
            required_to_create_for_contacts = RequiredToCreateForContacts,
            visible_on_create = VisibleOnCreate,
            visible_to_contacts = VisibleToContacts,
            multiline = Multiline,
            list_items = ListItems,
            allow_multiple_values = AllowMultipleValues,
        };

        public override string Uri => $"ticket_types/{Id}/attributes";
    }
}
