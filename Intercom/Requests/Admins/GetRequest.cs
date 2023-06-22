using Intercom.Abstractions;

namespace Intercom.Requests.Admins
{
    /// <summary>
    /// You can retrieve the details of a single admin.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/retrieveadmin">Documentation</see>
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
