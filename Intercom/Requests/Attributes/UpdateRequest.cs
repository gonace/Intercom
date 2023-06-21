using Intercom.Abstractions;
using Intercom.Models;

namespace Intercom.Requests.Attributes
{
    public class UpdateRequest : PayloadRequest
    {
        public string Id { get; set; }

        public bool Archived { get; set; }
        public string Description { get; set; }
        public string[] Options { get; set; }

        public UpdateRequest(string id, bool archived, string description, string[] options)
        {
            Id = id;

            Archived = archived;
            Description = description;
            Options = options;
        }

        public UpdateRequest(Attribute attribute)
        {
            Id = attribute.Id;
            Archived = attribute.Archived;
            Description = attribute.Description;
            Options = attribute.Options;
        }

        public override object Payload => new
        {
            description = Description,
            options = Options
        };

        public override string Uri => $"data_attributes/{Id}]";
    }
}
