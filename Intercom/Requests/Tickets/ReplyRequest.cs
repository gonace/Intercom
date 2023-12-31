﻿using Intercom.Abstractions;
using Intercom.Models.Tickets;

namespace Intercom.Requests.Tickets
{
    /// <summary>
    /// You can create a new ticket reply.
    /// Only note is supported as a ticket reply type at the moment.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/post_tickets-ticket-id-reply">Documentation</see>
    /// </summary>
    public class ReplyRequest : PayloadRequest
    {
        /// <summary>
        /// The unique identifier for the ticket which is given by Intercom.
        /// </summary>
        public string Id { get; }
        /// <summary>
        /// The message body of the note, which may contain HTML.
        /// </summary>
        public string Body { get; set; }
        /// <summary>
        /// The type of the reply. Only note is supported at the moment.
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// The id of the admin who is making the note.
        /// </summary>
        public string AdminId { get; }

        public ReplyRequest(Part part, string adminId)
        {
            Body = part.Body;
            Type = part.PartType;
            AdminId = adminId;
        }

        public ReplyRequest(string id, string adminId)
        {
            Id = id;
            AdminId = adminId;
        }

        public override object Payload => new
        {
            body = Body,
            message_type = Type,
            admin_id = AdminId
        };

        public override string Uri => $"tickets/{Id}/reply";
    }
}
