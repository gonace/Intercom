using Intercom.Abstractions;
using Intercom.Constants;
using Intercom.Models;
using Intercom.Requests.Visitors;
using System.Threading.Tasks;

namespace Intercom.Clients
{
    public interface IVisitorsClient
    {
        Visitor Get(GetRequest request);
        Task<Visitor> GetAsync(GetRequest request);
        Visitor Update(UpdateRequest request);
        Task<Visitor> UpdateAsync(UpdateRequest request);
        Visitor Delete(DeleteRequest request);
        Task<Visitor> DeleteAsync(DeleteRequest request);

        Visitor Convert(ConvertUserRequest request);
        Task<Visitor> ConvertAsync(ConvertUserRequest request);
        Visitor Convert(ConvertVisitorRequest request);
        Task<Visitor> ConvertAsync(ConvertVisitorRequest request);
    }

    public class VisitorsClient : BaseClient<VisitorsClient>, IVisitorsClient
    {
        public VisitorsClient(Url url, string bearerToken, Version version)
            : base(url, bearerToken, version)
        {
        }

        public VisitorsClient(Url url, string bearerToken)
            : base(url, bearerToken, Version.Latest)
        {
        }

        public Visitor Get(GetRequest request)
        {
            return Get<Visitor>(request);
        }

        public async Task<Visitor> GetAsync(GetRequest request)
        {
            return await GetAsync<Visitor>(request);
        }

        public Visitor Update(UpdateRequest request)
        {
            return Put<Visitor, UpdateRequest>(request);
        }

        public async Task<Visitor> UpdateAsync(UpdateRequest request)
        {
            return await PutAsync<Visitor, UpdateRequest>(request);
        }

        public Visitor Delete(DeleteRequest request)
        {
            return Delete<Visitor>(request);
        }

        public async Task<Visitor> DeleteAsync(DeleteRequest request)
        {
            return await DeleteAsync<Visitor>(request);
        }

        public Visitor Convert(ConvertUserRequest request)
        {
            return Post<Visitor, ConvertUserRequest>(request);
        }

        public async Task<Visitor> ConvertAsync(ConvertUserRequest request)
        {
            return await PostAsync<Visitor, ConvertUserRequest>(request);
        }

        public Visitor Convert(ConvertVisitorRequest request)
        {
            return Post<Visitor, ConvertVisitorRequest>(request);
        }

        public async Task<Visitor> ConvertAsync(ConvertVisitorRequest request)
        {
            return Delete<Visitor, ConvertVisitorRequest>(request);
        }
    }
}
