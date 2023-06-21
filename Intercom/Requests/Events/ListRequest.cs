using Intercom.Abstractions;
using Intercom.Attributes;
using Intercom.Extensions;

namespace Intercom.Requests.Events
{
    public class ListRequest : PlainRequest
    {
        [QueryStringProperty("type")]
        public string Type { get; }

        [QueryStringProperty("email")]
        private string Email { get; }
        [QueryStringProperty("intercom_user_id")]
        public string IntercomUserId { get; }
        [QueryStringProperty("user_id")]
        public string UserId { get; }

        public ListRequest(string type, string email, string userId, string intercomUserId)
        {
            Type = type;
            Email = email;
            UserId = userId;
            IntercomUserId = intercomUserId;
        }

        public override string Uri => $"events{this.ToQueryString()}";
    }
}
