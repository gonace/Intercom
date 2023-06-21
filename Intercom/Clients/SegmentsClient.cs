using Intercom.Abstractions;
using Intercom.Models;
using Intercom.Requests.Segments;
using Intercom.Responses.Segments;
using System.Threading.Tasks;

namespace Intercom.Clients
{
    public interface ISegmentsClient
    {
        ListResponse List(ListRequest request);
        Task<ListResponse> ListAsync(ListRequest request);
        Segment Get(GetRequest request);
        Task<Segment> GetAsync(GetRequest request);
    }

    public class SegmentsClient : BaseClient<SegmentsClient>, ISegmentsClient
    {
        public SegmentsClient(string baseUri, string bearerToken, System.Version apiVersion)
            : base(baseUri, bearerToken, apiVersion)
        {
        }

        public SegmentsClient(string baseUri, string bearerToken)
            : base(baseUri, bearerToken, Constants.Version.Latest)
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

        public Segment Get(GetRequest request)
        {
            return Get<Segment>(request);
        }

        public async Task<Segment> GetAsync(GetRequest request)
        {
            return await GetAsync<Segment>(request);
        }
    }
}
