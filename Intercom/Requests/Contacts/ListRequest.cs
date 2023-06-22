using Intercom.Abstractions;

namespace Intercom.Requests.Contacts
{
    /// <summary>
    /// You can fetch a list of all contacts.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/listcontacts">Documentation</see>
    /// </summary>
    public class ListRequest : PlainRequest
    {
        public override string Uri => "contacts";
    }
}
