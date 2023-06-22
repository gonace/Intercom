using Intercom.Abstractions;

namespace Intercom.Requests.Admins
{
    /// <summary>
    /// You can fetch a list of admins for a given workspace.
    /// </summary>
    public class ListRequest : PlainRequest
    {
        public override string Uri => "admins";
    }
}
