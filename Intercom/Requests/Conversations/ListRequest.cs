using Intercom.Abstractions;

namespace Intercom.Requests.Conversations
{
    public class ListRequest : PlainRequest
    {
        public override string Uri => "conversations";
    }
}
