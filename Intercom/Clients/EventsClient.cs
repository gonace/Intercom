using Intercom.Abstractions;
using Intercom.Requests.Events;
using Intercom.Responses.Events;
using System.Threading.Tasks;

namespace Intercom.Clients
{
    public interface IEventsClient
    {
        ListResponse List(ListRequest request);
        Task<ListResponse> ListAsync(ListRequest request);
    }

    public class EventsClient : BaseClient<EventsClient>, IEventsClient
    {
        public EventsClient(string baseUri, string bearerToken, System.Version apiVersion)
            : base(baseUri, bearerToken, apiVersion)
        {
        }

        public EventsClient(string baseUri, string bearerToken)
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
    }
}
