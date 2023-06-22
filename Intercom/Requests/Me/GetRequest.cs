using Intercom.Abstractions;

namespace Intercom.Requests.Me
{
    /// <summary>
    /// You can view the currently authorized admin along with the embedded app object (a "workspace" in legacy terminology).
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/identifyadmin">Documentation</see>
    /// </summary>
    public class GetRequest : PlainRequest
    {
        public override string Uri => "me";
    }
}
