using Intercom.Abstractions;

namespace Intercom.Requests.Attributes
{
    public class ListRequest : PlainRequest
    {
        public override string Uri => "data_attributes";
    }
}
