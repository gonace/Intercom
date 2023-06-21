using Intercom.Abstractions;

namespace Intercom.Requests.Me
{
    public class GetRequest : PlainRequest
    {
        public override string Uri => "me";
    }
}
