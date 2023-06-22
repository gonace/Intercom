using Intercom.Abstractions;

namespace Intercom.Requests.Admins
{
    /// <summary>
    /// You can retrieve the details of a single admin.
    /// </summary>
    public class GetRequest : PlainRequest
    {
        /// <summary>
        /// The unique identifier of a given admin
        /// </summary>
        public string Id { get; }

        public GetRequest(string id)
        {
            Id = id;
        }

        public override string Uri => $"admins/{Id}";
    }
}
