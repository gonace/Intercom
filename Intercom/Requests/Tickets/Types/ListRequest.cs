using Intercom.Abstractions;

namespace Intercom.Requests.Tickets.Types
{
    /// <summary>
    /// You can get a list of all ticket types for a workspace.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/get_ticket-types">Documentation</see>
    /// </summary>
    public class ListRequest : PlainRequest
    {
        public override string Uri => $"ticket_types";
    }
}
