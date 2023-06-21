using Intercom.Abstractions;
using Intercom.Constants.Attributes;
using Attribute = Intercom.Models.Attribute;
using Model = Intercom.Constants.Attributes.Model;

namespace Intercom.Requests.Attributes
{
    public class CreateRequest : PayloadRequest
    {
        public string Name { get; set; }
        public Model Model { get; set; }
        public DataType DataType { get; set; }
        public string Description { get; set; }
        public string[] Options { get; set; }

        public CreateRequest(Attribute attribute)
        {
            Name = attribute.Name;
            Model = new Model(attribute.Model);
            DataType = new DataType(attribute.DataType);
            Description = attribute.Description;
            Options = attribute.Options;
        }

        public CreateRequest(string name, Model model, DataType dateType, string description, string[] options)
        {
            Name = name;
            Model = model;
            DataType = dateType;
            Description = description;
            Options = options;
        }

        public override object Payload => new
        {
            name = Name,
            model = Model.ToString(),
            data_type = DataType.ToString(),
            description = Description,
            options = Options
        };

        public override string Uri => "data_attributes";
    }
}
