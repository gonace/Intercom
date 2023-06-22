using Intercom.Abstractions;
using Intercom.Models;

namespace Intercom.Requests.Tags
{
    /// <summary>
    /// You can delete the details of tags that are on the workspace by passing in the id.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/deletetag">Documentation</see>
    /// </summary>
    public class DeleteRequest : PlainRequest
    {
        /// <summary>
        /// The unique identifier of a given tag.
        /// </summary>
        public string Id { get; }

        public DeleteRequest(Tag tag)
        {
            Id = tag.Id;
        }

        public DeleteRequest(string id)
        {
            Id = id;
        }

        public override string Uri => $"tags/{Id}";
    }
}
