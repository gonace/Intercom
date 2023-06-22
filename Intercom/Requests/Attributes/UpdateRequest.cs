using Intercom.Abstractions;
using Intercom.Models;

namespace Intercom.Requests.Attributes
{
    /// <summary>
    /// You can update a data attribute.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/updatedataattribute">Documentation</see>
    /// </summary>
    public class UpdateRequest : PayloadRequest
    {
        /// <summary>
        /// The data attribute id
        /// </summary>
        public string Id { get; }
        /// <summary>
        /// Whether the attribute is to be archived or not.
        /// </summary>
        public bool Archived { get; set; }
        /// <summary>
        /// The readable description you see in the UI
        /// for the attribute.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// To create list attributes.
        /// Provide a set of hashes with value as the key
        /// of the options you want to make. data_type must be string.
        /// </summary>
        public string[] Options { get; set; }

        public UpdateRequest(Attribute attribute)
        {
            Id = attribute.Id;
            Archived = attribute.Archived;
            Description = attribute.Description;
            Options = attribute.Options;
        }

        public UpdateRequest(string id)
        {
            Id = id;
        }

        public override object Payload => new
        {
            archived = Archived,
            description = Description,
            options = Options
        };

        public override string Uri => $"data_attributes/{Id}]";
    }
}
