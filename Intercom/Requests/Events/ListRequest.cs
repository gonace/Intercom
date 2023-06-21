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
        private string Email { get; set; }
        [QueryStringProperty("intercom_user_id")]
        public string IntercomUserId { get; set; }
        [QueryStringProperty("user_id")]
        public string UserId { get; set; }

        public ListRequest(string type)
        {
            Type = type;
        }

        public override string Uri => $"events{this.ToQueryString()}";
    }
}
