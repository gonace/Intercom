using Intercom.Abstractions;
using Intercom.Models;

namespace Intercom.Requests.Visitors
{
    /// <summary>
    /// You can merge a Visitor to a Contact of role type lead or user.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/convertvisitor">Documentation</see>
    /// </summary>
    public class ConvertUserRequest : PayloadRequest
    {
        /// <summary>
        /// Represents the role of the Contact model. Accepts lead or user.
        /// </summary>
        public string Type { get; }
        /// <summary>
        /// The unique identifier for the contact which is given by Intercom.
        /// </summary>
        public string Id { get; }
        /// <summary>
        /// A unique identifier for the contact which is given to Intercom,
        /// which will be represented as external_id.
        /// </summary>
        public string UserId { get; }
        /// <summary>
        /// The contact's email, retained by default if one is present.
        /// </summary>
        public string Email { get; }

        public ConvertUserRequest(Visitor visitor)
        {
            Type = visitor.Type;
            Id = visitor.Id;
            UserId = visitor.UserId;
            Email = visitor.Email;
        }

        public ConvertUserRequest(string type, string id, string userId, string email)
        {
            Type = type;
            Id = id;
            UserId = userId;
            Email = email;
        }

        public override object Payload => new
        {
            type = Type,
            user = new
            {
                id = Id,
                userId = UserId,
                email = Email
            }
        };

        public override string Uri => "visitors/convert";
    }
}
