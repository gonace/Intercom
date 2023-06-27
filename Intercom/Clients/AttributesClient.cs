using Intercom.Abstractions;
using Intercom.Constants;
using Intercom.Models;
using Intercom.Requests.Attributes;
using Intercom.Responses.Attributes;
using System.Threading.Tasks;

namespace Intercom.Clients
{
    public interface IAttributesClient
    {
        ListResponse List(ListRequest request);
        Task<ListResponse> ListAsync(ListRequest request);
        Attribute Create(CreateRequest request);
        Task<Attribute> CreateAsync(CreateRequest request);
        Attribute Update(UpdateRequest request);
        Task<Attribute> UpdateAsync(UpdateRequest request);
    }

    public class AttributesClient : BaseClient<AttributesClient>, IAttributesClient
    {
        public AttributesClient(Url url, string bearerToken, Version version)
            : base(url, bearerToken, version)
        {
        }

        public AttributesClient(Url url, string bearerToken)
            : base(url, bearerToken, Version.Latest)
        {
        }

        public ListResponse List(ListRequest request)
        {
            return Get<ListResponse>(request);
        }

        public async Task<ListResponse> ListAsync(ListRequest request)
        {
            return await GetAsync<ListResponse>(request);
        }

        public Attribute Create(CreateRequest request)
        {
            return Post<Attribute, CreateRequest>(request);
        }

        public async Task<Attribute> CreateAsync(CreateRequest request)
        {
            return await PostAsync<Attribute, CreateRequest>(request);
        }

        public Attribute Update(UpdateRequest request)
        {
            return Put<Attribute, UpdateRequest>(request);
        }

        public async Task<Attribute> UpdateAsync(UpdateRequest request)
        {
            return await PutAsync<Attribute, UpdateRequest>(request);
        }
    }
}
