using Intercom.Abstractions;
using Intercom.Models;

namespace Intercom.Requests.Contacts.Subscriptions
{
    /// <summary>
    /// You can fetch a list of subscription types that are attached to a contact.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/listsubscriptionsforacontact">Documentation</see>
    /// </summary>
    public class ListRequest : PlainRequest
    {
        /// <summary>
        /// The unique identifier for the contact which is given by Intercom.
        /// </summary>
        public string Id { get; }

        public ListRequest(Contact contact)
        {
            Id = contact.Id;
        }

        public ListRequest(string id)
        {
            Id = id;
        }

        public override string Uri => $"contacts/{Id}/subscriptions";
    }
}
