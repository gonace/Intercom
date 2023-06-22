using Intercom.Abstractions;

namespace Intercom.Requests.Admins
{
    /// <summary>
    /// You can fetch a list of admins for a given workspace.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/listadmins">Documentation</see>
    /// </summary>
    public class ListRequest : PlainRequest
    {
        public override string Uri => "admins";
    }
}
