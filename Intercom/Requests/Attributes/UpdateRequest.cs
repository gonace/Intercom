using Intercom.Abstractions;
using Intercom.Models;

namespace Intercom.Requests.Attributes
{
    public class UpdateRequest : PayloadRequest
    {
        public Attribute Attribute { get; set; }

        public UpdateRequest(Attribute attribute)
        {
            Attribute = attribute;
        }

        public override object Payload => new
        {
            archived = Attribute.Archived,
            description = Attribute.Description,
            options = Attribute.Options
        };

        public override string Uri => $"data_attributes/{Attribute.Id}]";
    }
}
