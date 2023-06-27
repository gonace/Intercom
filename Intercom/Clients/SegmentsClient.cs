using Intercom.Abstractions;
using Intercom.Constants;
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
        public SegmentsClient(Url url, string bearerToken, Version version)
            : base(url, bearerToken, version)
        {
        }

        public SegmentsClient(Url url, string bearerToken)
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
