using Intercom.Abstractions;

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
        public override string Uri => "data_attributes";
    }
}
