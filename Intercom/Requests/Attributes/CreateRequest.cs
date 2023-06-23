using Intercom.Abstractions;
using Intercom.Constants.Attributes;
using Intercom.Models;

namespace Intercom.Requests.Attributes
{
    /// <summary>
    /// You can create a data attributes for a contact or a company.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/createdataattribute">Documentation</see>
    /// </summary>
    public class CreateRequest : PayloadRequest
    {
        /// <summary>
        /// The name of the data attribute.
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// The model that the data attribute belongs to.
        /// </summary>
        public Constants.Attributes.Model Model { get; }
        /// <summary>
        /// The type of data stored for this attribute.
        /// </summary>
        public DataType DataType { get; }
        /// <summary>
        /// The readable description you see in the UI for the attribute.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// To create list attributes. Provide a set of hashes with value
        /// as the key of the options you want to make. data_type must
        /// be string.
        /// </summary>
        public string[] Options { get; set; }

        public CreateRequest(Attribute attribute, Constants.Attributes.Model model, DataType dataType)
        {
            Name = attribute.Name;
            Model = model;
            DataType = dataType;
            Description = attribute.Description;
            Options = attribute.Options;
        }

        public CreateRequest(string name, Constants.Attributes.Model model, DataType dataType)
        {
            Name = name;
            Model = model;
            DataType = dataType;
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
