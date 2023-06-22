using Intercom.Abstractions;

namespace Intercom.Requests.Tags
{
    /// <summary>
    /// You can fetch a list of all tags for a given workspace.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/listtags">Documentation</see>
    /// </summary>
    public class ListRequest : PlainRequest
    {
        public override string Uri => "tags";
    }
}
