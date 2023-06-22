using Intercom.Abstractions;
using Intercom.Models;

namespace Intercom.Requests.Visitors
{
    /// <summary>
    /// You can delete a single visitor.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/deletevisitor">Documentation</see>
    /// </summary>
    public class DeleteRequest : PlainRequest
    {
        /// <summary>
        /// Id provided by Intercom.
        /// </summary>
        public string Id { get; }

        public DeleteRequest(Visitor visitor)
        {
            Id = visitor.Id;
        }

        public DeleteRequest(string id)
        {
            Id = id;
        }

        public override string Uri => $"visitors/{Id}";
    }
}
