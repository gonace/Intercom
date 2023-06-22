using Intercom.Abstractions;

namespace Intercom.Requests.Visitors
{
    /// <summary>
    /// You can fetch the details of a single visitor.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/retrievevisitor">Documentation</see>
    /// </summary>
    public class GetRequest : PlainRequest
    {
        /// <summary>
        /// Id provided by Intercom.
        /// </summary>
        public string Id { get; }

        public GetRequest(string id)
        {
            Id = id;
        }

        public override string Uri => $"visitors/{Id}";
    }
}
