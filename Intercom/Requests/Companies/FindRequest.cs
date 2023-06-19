using Intercom.Attributes;
using Intercom.Extensions;

namespace Intercom.Requests.Companies
{
    public class FindRequest : PlainRequest
    {
        [QueryStringProperty("company_id")]
        public string CompanyId { get; set; }
        [QueryStringProperty("name")]
        public string Name { get; set; }

        public override string Uri => $"companies{this.ToQueryString()}";
    }
}
