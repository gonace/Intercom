using Intercom.Abstractions;

namespace Intercom.Requests.Segments
{
    /// <summary>
    /// You can fetch the details of a single segment.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/retrievesegment">Documentation</see>
    /// </summary>
    public class GetRequest : PlainRequest
    {
        /// <summary>
        /// The unique identified of a given segment.
        /// </summary>
        public string Id { get; }

        public GetRequest(string id)
        {
            Id = id;
        }

        public override string Uri => $"segments/{Id}";
    }
}
