using Intercom.Attributes;

namespace Intercom.Requests.Companies
{
    public class ListRequest : PlainRequest
    {
        public override string Uri => "companies/list";
    }
}
