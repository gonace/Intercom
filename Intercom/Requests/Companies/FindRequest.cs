using Intercom.Abstractions;
using Intercom.Attributes;
using Intercom.Extensions;

namespace Intercom.Requests.Companies
{
    public class FindRequest : PlainRequest
    {
        [QueryStringProperty("name")]
        private string Name { get; set; }
        [QueryStringProperty("company_id")]
        private string CompanyId { get; set; }

        public override string Uri => $"companies{this.ToQueryString()}";
    }
}
