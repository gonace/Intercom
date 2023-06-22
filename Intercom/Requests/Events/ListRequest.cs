using Intercom.Abstractions;
using Intercom.Attributes;
using Intercom.Extensions;

namespace Intercom.Requests.Events
{
    /// <summary>
    /// The events belonging to a customer can be listed by sending a GET
    /// request to https://api.intercom.io/events with a user or lead
    /// identifier along with a type parameter.
    /// The identifier parameter can be one of user_id, email or intercom_user_id.
    /// The type parameter value must be user.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/lisdataevents">Documentation</see>
    /// </summary>
    public class ListRequest : PlainRequest
    {
        /// <summary>
        /// The value must be user.
        /// </summary>
        [QueryStringProperty("type")]
        public string Type { get; }

        [QueryStringProperty("email")]
        private string Email { get; set; }
        [QueryStringProperty("intercom_user_id")]
        public string IntercomUserId { get; set; }
        [QueryStringProperty("user_id")]
        public string UserId { get; set; }
        /// <summary>
        /// Summary flag.
        /// </summary>
        [QueryStringProperty("summary")]
        public bool Summary { get; set; }

        public ListRequest(string type)
        {
            Type = type;
        }

        public override string Uri => $"events{this.ToQueryString()}";
    }
}
