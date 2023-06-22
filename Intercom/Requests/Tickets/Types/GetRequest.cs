using Intercom.Abstractions;

namespace Intercom.Requests.Tickets.Types
{
    /// <summary>
    /// You can fetch the details of a single ticket type.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/get_ticket-types-id">Documentation</see>
    /// </summary>
    public class GetRequest : PlainRequest
    {
        /// <summary>
        /// The unique identifier for the ticket type which is given by Intercom.
        /// </summary>
        public string Id { get; set; }

        public GetRequest(string id)
        {
            Id = id;
        }

        public override string Uri => $"ticket_types/{Id}";
    }
}
