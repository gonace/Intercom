using Intercom.Abstractions;
using Intercom.Constants.Messages;
using Intercom.Models;

namespace Intercom.Requests.Messages
{
    /// <summary>
    /// You can create a message that has been initiated by an admin.
    /// The conversation can be either an in-app message or an email.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/createmessage">Documentation</see>
    /// </summary>
    public class CreateRequest : PayloadRequest
    {
        /// <summary>
        /// The kind of message being created. Values: in_app or email.
        /// </summary>
        public Type Type { get; }
        /// <summary>
        /// The title of the email.
        /// </summary>
        public string Subject { get; }
        /// <summary>
        /// The content of the message. HTML and plaintext are supported.
        /// </summary>
        public string Body { get; }
        /// <summary>
        /// The style of the outgoing message. Possible values plain or personal.
        /// </summary>
        public Template Template { get; }
        /// <summary>
        /// The sender of the message.
        /// If not provided, the default sender will be used.
        /// </summary>
        public Shared.From From { get; }
        /// <summary>
        /// The sender of the message.
        /// If not provided, the default sender will be used.
        /// </summary>
        public Shared.To To { get; }
        /// <summary>
        /// Whether a conversation should be opened in the inbox for the message
        /// without the contact replying. Defaults to false if not provided.
        /// </summary>
        public bool? CreateConversationWithoutContactReply { get; set; } = null;

        public CreateRequest(Message message, Type type, Template template, Shared.From from, Shared.To to)
        {
            Type = type;
            Subject = message.Subject;
            Body = message.Body;
            Template = template;
            From = from;
            To = to;
        }

        public CreateRequest(Type type, string subject, string body, Template template, Shared.From from, Shared.To to)
        {
            Type = type;
            Subject = subject;
            Body = body;
            Template = template;
            From = from;
            To = to;
        }

        public override object Payload => new
        {
            message_type = Type,
            subject = Subject,
            body = Body,
            template = Template,
            from = new
            {
                type = From.Type.ToString(),
                id = From.Id
            },
            to = new
            {
                type = To.Type.ToString(),
                id = To.Id
            },
            create_conversation_without_contact_reply = CreateConversationWithoutContactReply
        };

        public override string Uri => "messages";
    }
}
