using Intercom.Abstractions;

namespace Intercom.Requests.Segments
{
    public class ListRequest : PlainRequest
    {
        public override string Uri => "segments";
    }
}
