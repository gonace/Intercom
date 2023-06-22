using Intercom.Abstractions;
using Intercom.Models;
using System.Collections.Generic;

namespace Intercom.Requests.Tickets
{
    /// <summary>
    /// You can update a ticket.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/put_tickets-id">Documentation</see>
    /// </summary>
    public class UpdateRequest : PayloadRequest
    {
        /// <summary>
        /// The unique identifier for the ticket which is given by Intercom.
        /// </summary>
        public string Id { get; }
        /// <summary>
        /// The attributes set on the ticket.
        /// </summary>
        public Dictionary<string, object> Attributes { get; }
        /// <summary>
        /// The state of the ticket.
        /// </summary>
        public string State { get; }
        /// <summary>
        /// The ID of the admin performing the action.
        /// </summary>
        public string AdminId { get; }
        /// <summary>
        /// The ID of the admin or team to which the ticket is assigned. Set this 0 to unassign it.
        /// </summary>
        public string AssigneeId { get; }

        public UpdateRequest(Visitor visitor, string state, string adminId, string assigneeId)
        {
            Id = visitor.Id;
            Attributes = visitor.Attributes;
            State = State;
            AdminId = adminId;
            AssigneeId = assigneeId;
        }

        public UpdateRequest(string id, Dictionary<string, object> attributes, string state, string adminId, string assigneeId)
        {
            Id = id;
            Attributes = attributes;
            State = state;
            AdminId = adminId;
            AssigneeId = assigneeId;
        }

        public override object Payload => new
        {
            ticket_attributes = Attributes,
            state = State,
            assignment = new
            {
                admin_id = AdminId,
                assignee_id = AssigneeId
            }
        };

        public override string Uri => $"tickets/{Id}";
    }
}
