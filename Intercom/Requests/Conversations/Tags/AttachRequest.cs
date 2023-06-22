using Intercom.Abstractions;
using Intercom.Models;

namespace Intercom.Requests.Conversations.Tags
{
    /// <summary>
    /// You can tag a specific conversation.
    /// This will return a tag object for the tag that was added to the conversation..
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/attachtagtoconversation">Documentation</see>
    /// </summary>
    public class AddRequest : PayloadRequest
    {
        /// <summary>
        /// The unique identifier for the contact which is given by Intercom.
        /// </summary>
        public string Id { get; }
        /// <summary>
        /// The unique identifier for the tag which is given by Intercom.
        /// </summary>
        public string TagId { get; }

        public AddRequest(Conversation conversation, Tag tag)
        {
            Id = conversation.Id;
            TagId = tag.Id;
        }

        public AddRequest(string conversation, string tagId)
        {
            Id = conversation;
            TagId = tagId;
        }

        public override object Payload => new
        {
            id = TagId
        };

        public override string Uri => $"conversations/{Id}/tags";
    }
}
