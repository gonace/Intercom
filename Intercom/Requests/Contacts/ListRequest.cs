using Intercom.Abstractions;

namespace Intercom.Requests.Contacts
{
    public class ListRequest : PlainRequest
    {
        public override string Uri => "contacts";
    }
}
