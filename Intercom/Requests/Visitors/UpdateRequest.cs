using Intercom.Abstractions;
using Intercom.Models;
using System.Collections.Generic;

namespace Intercom.Requests.Visitors
{
    /// <summary>
    /// Sending a PUT request to /visitors will result in an update of an existing Visitor.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/updatevisitor">Documentation</see>
    /// </summary>
    public class UpdateRequest : PayloadRequest
    {
        /// <summary>
        /// A unique identified for the visitor which is given by Intercom.
        /// </summary>
        public string Id { get; }
        /// <summary>
        /// A unique identified for the visitor which is given by you.
        /// </summary>
        public string UserId { get; }
        /// <summary>
        /// The visitor's name.
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// The custom attributes which are set for the visitor.
        /// </summary>
        public Dictionary<string, object> Attributes { get; set; }

        public UpdateRequest(Visitor visitor)
        {
            Id = visitor.Id;
            UserId = visitor.UserId;
            Name = visitor.Name;
            Attributes = visitor.Attributes;
        }

        public UpdateRequest(string userId, string name, Dictionary<string, object> attributes)
        {
            UserId = userId;
            Name = name;
            Attributes = attributes;
        }

        public override object Payload => new
        {
            id = Id,
            user_id = UserId,
            name = Name,
            custom_attributes = Attributes
        };

        public override string Uri => "visitors";
    }
}
