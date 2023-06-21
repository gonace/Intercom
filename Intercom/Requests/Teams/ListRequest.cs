using Intercom.Abstractions;

namespace Intercom.Requests.Teams
{
    public class ListRequest : PlainRequest
    {
        public override string Uri => "teams";
    }
}
