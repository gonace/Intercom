using Intercom.Abstractions;

namespace Intercom.Requests.Conversations
{
    /// <summary>
    /// You can fetch the details of a single conversation.
    /// This will return a single Conversation model with all its conversation parts.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/retrieveconversation">Documentation</see>
    /// </summary>
    public class GetRequest : PlainRequest
    {
        /// <summary>
        /// The id of the conversation to target.
        /// </summary>
        public string Id { get; }

        public GetRequest(string id)
        {
            Id = id;
        }

        public override string Uri => $"conversations/{Id}";
    }
}
