using Intercom.Abstractions;
using Intercom.Constants;
using Intercom.Requests.Contacts.Segments;
using Intercom.Responses.Contacts.Segments;
using System.Threading.Tasks;

namespace Intercom.Clients.Contacts
{
    public interface ISegmentsClient
    {
        ListResponse List(ListRequest request);
        Task<ListResponse> ListAsync(ListRequest request);
    }

    internal class SegmentsClient : BaseClient<SegmentsClient>, ISegmentsClient
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
    }
}
