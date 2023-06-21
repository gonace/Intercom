using Intercom.Abstractions;
using Attribute = Intercom.Models.Attribute;

namespace Intercom.Requests.Attributes
{
    public class CreateRequest : PayloadRequest
    {
        public Attribute Attribute { get; }

        public CreateRequest(Attribute attribute)
        {
            Attribute = attribute;
        }

        public override object Payload => new
        {
            name = Attribute.Name,
            model = Attribute.Model,
            data_type = Attribute.DataType,
            description = Attribute.Description,
            options = Attribute.Options
        };

        public override string Uri => "data_attributes";
    }
}
