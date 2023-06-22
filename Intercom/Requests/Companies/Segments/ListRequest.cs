using Intercom.Abstractions;
using Intercom.Models;

namespace Intercom.Requests.Companies.Segments
{
    /// <summary>
    /// You can fetch a list of all segments that belong to a company.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/listattachedsegmentsforcompanies">Documentation</see>
    /// </summary>
    public class ListRequest : PlainRequest
    {
        /// <summary>
        /// The unique identifier for the company which is given by Intercom.
        /// </summary>
        public string Id { get; }

        public ListRequest(Company company)
        {
            Id = company.Id;
        }

        public ListRequest(string id)
        {
            Id = id;
        }

        public override string Uri => $"companies/{Id}/segments";
    }
}
