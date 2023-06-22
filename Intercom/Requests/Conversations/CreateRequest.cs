using Intercom.Abstractions;
using Intercom.Models.Shared;

namespace Intercom.Requests.Conversations
{
    public class CreateRequest : PayloadRequest
    {
        public From From { get; }
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
                type = From.Type,
                id = From.Id
            },
            body = Body
        };

        public override string Uri => "conversations";
    }
}
