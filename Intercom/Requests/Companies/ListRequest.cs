using Intercom.Abstractions;

namespace Intercom.Requests.Companies
{
    /// <summary>
    /// You can list companies.
    /// The company list is sorted by the last_request_at field and by default is ordered
    /// descending, most recently requested first.
    ///
    /// Note that the API does not include companies who have no associated users in list responses.
    /// </summary>
    public class ListRequest : PlainRequest
    {
        public override string Uri => "companies/list";
    }
}
