using Intercom.Abstractions;
using Intercom.Requests.Conversations.Shared;

namespace Intercom.Requests.Conversations
{
    /// <summary>
    /// You can create a conversation that has been initiated by a contact (ie. user or lead).
    /// The conversation can be an in-app message only.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/createconversation">Documentation</see>
    /// </summary>
    public class CreateRequest : PayloadRequest
    {
        public From From { get; }
        /// <summary>
        /// The content of the message.
        /// HTML is not supported.
        /// </summary>
        public string Body { get; }

        public CreateRequest(From from, string body)
        {
            From = from;
            Body = body;
        }

        public override object Payload => new
        {
            from = new
            {
                type = From.Type.ToString(),
                id = From.Id
            },
            body = Body
        };

        public override string Uri => "conversations";
    }
}
