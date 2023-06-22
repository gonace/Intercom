using Intercom.Abstractions;

namespace Intercom.Requests.Companies
{
    /// <summary>
    /// You can fetch a single company.
    /// </summary>
    public class GetRequest : PlainRequest
    {
        /// <summary>
        /// The unique identifier for the company which is given by Intercom.
        /// </summary>
        public string Id { get; set; }

        public GetRequest(string id)
        {
            Id = id;
        }

        public override string Uri => $"companies/{Id}";
    }
}
