using Intercom.Attributes;
using Intercom.Extensions;

namespace Intercom.Requests.Contacts
{
    public class FindRequest : PayloadRequest
    {
        public override object Payload { get; }
        public override string Uri => $"contacts{this.ToQueryString()}";
    }
}
