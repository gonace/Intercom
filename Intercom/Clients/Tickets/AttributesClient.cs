using Intercom.Abstractions;
using Intercom.Models.Tickets;
using Intercom.Requests.Tickets.Attributes;
using System.Threading.Tasks;

namespace Intercom.Clients.Tickets
{
    public interface IAttributesClient
    {
        Attribute Create(CreateRequest request);
        Task<Attribute> CreateAsync(CreateRequest request);
        Attribute Update(UpdateRequest request);
        Task<Attribute> UpdateAsync(UpdateRequest request);
    }

    internal class AttributesClient : BaseClient<AttributesClient>, IAttributesClient
    {
        public AttributesClient(string baseUri, string bearerToken, System.Version apiVersion)
            : base(baseUri, bearerToken, apiVersion)
        {
        }

        public AttributesClient(string baseUri, string bearerToken)
            : base(baseUri, bearerToken, Constants.Version.Latest)
        {
        }
    }
}
