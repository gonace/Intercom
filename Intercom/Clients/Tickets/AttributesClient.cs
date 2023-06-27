using Intercom.Abstractions;
using Intercom.Constants;
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
        public AttributesClient(Url url, string bearerToken, Version version)
            : base(url, bearerToken, version)
        {
        }

        public AttributesClient(Url url, string bearerToken)
            : base(url, bearerToken, Version.Latest)
        {
        }

        public Attribute Create(CreateRequest request)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Attribute> CreateAsync(CreateRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Attribute Update(UpdateRequest request)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Attribute> UpdateAsync(UpdateRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}
