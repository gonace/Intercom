using Intercom.Abstractions;

namespace Intercom.Requests.Tickets
{
    /// <summary>
    /// You can fetch the details of a single ticket.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/get_tickets-id">Documentation</see>
    /// </summary>
    public class GetRequest : PlainRequest
    {
        /// <summary>
        /// The unique identifier for the ticket which is given by Intercom.
        /// </summary>
        public string Id { get; }

        public GetRequest(string id)
        {
            Id = id;
        }

        public override string Uri => $"tickets/{Id}";
    }
}
