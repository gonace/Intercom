using Intercom.Abstractions;

namespace Intercom.Requests.Admins
{
    public class ListRequest : PlainRequest
    {
        public override string Uri => "admins";
    }
}
