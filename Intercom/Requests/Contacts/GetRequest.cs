using Intercom.Abstractions;

namespace Intercom.Requests.Contacts
{
    /// <summary>
    /// You can fetch the details of a single contact.
    /// <br/><br/>
    /// <see href="https://developers.intercom.com/intercom-api-reference/reference/showcontact">Documentation</see>
    /// </summary>
    public class GetRequest : PlainRequest
    {
        public string Id { get; set; }

        public GetRequest(string id)
        {
            Id = id;
        }

        public override string Uri => $"contacts/{Id}";
    }
}
