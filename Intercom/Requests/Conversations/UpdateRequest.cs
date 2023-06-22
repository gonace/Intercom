using Intercom.Abstractions;
using Intercom.Models;
using System.Collections.Generic;

namespace Intercom.Requests.Conversations
{
    /// <summary>
    /// You can update an existing conversation.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/updateconversation">Documentation</see>
    /// </summary>
    public class UpdateRequest : PayloadRequest
    {
        /// <summary>
        /// The id of the conversation to target.
        /// </summary>
        public string Id { get; }
        /// <summary>
        /// Mark a conversation as read within Intercom.
        /// </summary>
        public bool Read { get; }
        /// <summary>
        /// An object containing the different custom attributes associated to the conversation as key-value pairs.
        /// For relationship attributes the value will be a list of custom object instance models.
        /// </summary>
        public Dictionary<string, object> Attributes { get; }

        public UpdateRequest(Conversation conversation)
        {
            Id = conversation.Id;
            Read = conversation.Read;
            Attributes = conversation.Attributes;
        }

        public UpdateRequest(string id)
        {
            Id = id;
        }

        public override object Payload => new
        {
            read = Read,
            custom_attributes = Attributes
        };

        public override string Uri => $"conversations/{Id}";
    }
}
