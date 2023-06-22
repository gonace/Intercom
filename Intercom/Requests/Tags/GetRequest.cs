using Intercom.Abstractions;

namespace Intercom.Requests.Tags
{
    /// <summary>
    /// You can fetch the details of tags that are on the workspace by their id.
    /// This will return a tag object.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/findtag">Documentation</see>
    /// </summary>
    public class GetRequest : PlainRequest
    {
        /// <summary>
        /// The unique identifier of a given tag
        /// </summary>
        public string Id { get; }

        public GetRequest(string id)
        {
            Id = id;
        }

        public override string Uri => $"tags/{Id}";
    }
}
