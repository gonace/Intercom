using Intercom.Abstractions;

namespace Intercom.Requests.Tags
{
    public class ListRequest : PlainRequest
    {
        public override string Uri => "tags";
    }
}
