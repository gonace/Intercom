using Intercom.Abstractions;

namespace Intercom.Requests.Companies
{
    /// <summary>
    /// You can delete a single company.
    /// </summary>
    public class DeleteRequest : PlainRequest
    {
        /// <summary>
        /// The unique identifier for the company which is given by Intercom.
        /// </summary>
        public string Id { get; set; }

        public DeleteRequest(string id)
        {
            Id = id;
        }

        public override string Uri => $"companies/{Id}";
    }
}
