using Intercom.Abstractions;

namespace Intercom.Requests.Conversations
{
    /// <summary>
    /// You can fetch a list of all conversations.
    /// You can optionally request the result page size and the cursor to start after to fetch the result.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/listconversations">Documentation</see>
    /// </summary>
    public class ListRequest : PlainRequest
    {
        public override string Uri => $"conversations";
    }
}
