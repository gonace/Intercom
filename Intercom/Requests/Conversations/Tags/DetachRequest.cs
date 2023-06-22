using Intercom.Abstractions;
using Intercom.Models;

namespace Intercom.Requests.Conversations.Tags
{
    /// <summary>
    /// You can remove tag from a specific conversation.
    /// This will return a tag object for the tag that was removed from the conversation.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/detachtagfromconversation">Documentation</see>
    /// </summary>
    public class DetachRequest : PlainRequest
    {
        /// <summary>
        /// The unique identifier for the contact which is given by Intercom.
        /// </summary>
        public string Id { get; }
        /// <summary>
        /// The unique identifier for the tag which is given by Intercom.
        /// </summary>
        public string TagId { get; }

        public DetachRequest(Conversation conversation, Tag tag)
        {
            Id = conversation.Id;
            TagId = tag.Id;
        }

        public DetachRequest(string id, string tagId)
        {
            Id = id;
            TagId = tagId;
        }

        public override string Uri => $"conversations/{Id}/tags/{TagId}";
    }
}
