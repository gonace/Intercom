using Intercom.Abstractions;
using Intercom.Attributes;
using Intercom.Extensions;

namespace Intercom.Requests.Attributes
{
    /// <summary>
    /// You can fetch a list of all data attributes belonging to a workspace for
    /// contacts, companies or conversations.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/lisdataattributes">Documentation</see>
    /// </summary>
    public class ListRequest : PlainRequest
    {
        [QueryStringProperty("model")]
        public Constants.Attributes.Model Model { get; set; } = null;
        [QueryStringProperty("model")]
        public bool? IncludeArchived { get; set; } = null;

        public override string Uri => $"data_attributes{this.ToQueryString()}";
    }
}
