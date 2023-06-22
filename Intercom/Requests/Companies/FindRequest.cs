using Intercom.Abstractions;
using Intercom.Attributes;
using Intercom.Extensions;

namespace Intercom.Requests.Companies
{
    /// <summary>
    /// You can fetch a company by either passing in company_id or name as a query parameter.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/retrieveacompanybyid">Documentation</see>
    /// </summary>
    public class FindRequest : PlainRequest
    {
        /// <summary>
        /// The company_id of the company to filter by.
        /// </summary>
        [QueryStringProperty("company_id")]
        private string CompanyId { get; set; }
        /// <summary>
        /// The name of the company to filter by.
        /// </summary>
        [QueryStringProperty("name")]
        private string Name { get; set; }

        public override string Uri => $"companies{this.ToQueryString()}";
    }
}
