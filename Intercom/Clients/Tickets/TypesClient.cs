using Intercom.Abstractions;
using Intercom.Models.Tickets;
using Intercom.Requests.Tickets.Types;
using Intercom.Responses.Tickets.Types;
using System.Threading.Tasks;

namespace Intercom.Clients.Tickets
{
    public interface ITypesClient
    {
        ListResponse Find(ListRequest request);
        Task<ListResponse> FindAsync(ListRequest request);
        Type Get(GetRequest request);
        Task<Type> GetAsync(GetRequest request);
        Type Create(CreateRequest request);
        Task<Type> CreateAsync(CreateRequest request);
        Type Update(UpdateRequest request);
        Task<Type> UpdateAsync(UpdateRequest request);
    }

    internal class TypesClient : BaseClient<TypesClient>, ITypesClient
    {
        public TypesClient(string baseUri, string bearerToken, System.Version apiVersion)
            : base(baseUri, bearerToken, apiVersion)
        {
        }

        public TypesClient(string baseUri, string bearerToken)
            : base(baseUri, bearerToken, Constants.Version.Latest)
        {
        }

        public ListResponse Find(ListRequest request)
        {
            return Get<ListResponse>(request);
        }

        public async Task<ListResponse> FindAsync(ListRequest request)
        {
            return await GetAsync<ListResponse>(request);
        }

        public Type Get(GetRequest request)
        {
            return Get<Type>(request);
        }

        public async Task<Type> GetAsync(GetRequest request)
        {
            return await GetAsync<Type>(request);
        }

        public Type Create(CreateRequest request)
        {
            return Post<Type, CreateRequest>(request);
        }

        public async Task<Type> CreateAsync(CreateRequest request)
        {
            return await PostAsync<Type, CreateRequest>(request);
        }

        public Type Update(UpdateRequest request)
        {
            return Put<Type, UpdateRequest>(request);
        }

        public async Task<Type> UpdateAsync(UpdateRequest request)
        {
            return await PutAsync<Type, UpdateRequest>(request);
        }
    }
}
