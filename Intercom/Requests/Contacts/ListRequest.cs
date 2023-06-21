using Intercom.Abstractions;
using Intercom.Extensions;

namespace Intercom.Requests.Contacts
{
    public class ListRequest : PlainRequest
    {
        public override string Uri => $"contacts{this.ToQueryString()}";
    }
}
