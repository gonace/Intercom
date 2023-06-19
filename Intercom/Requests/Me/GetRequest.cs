using Intercom.Attributes;

namespace Intercom.Requests.Me
{
    public class GetRequest : PlainRequest
    {
        public override string Uri => "me";
    }
}
