using Intercom.Abstractions;
using Intercom.Constants;
using Intercom.Requests.Events;
using Intercom.Responses.Events;
using System.Threading.Tasks;

namespace Intercom.Clients
{
    public interface IEventsClient
    {
        ListResponse List(ListRequest request);
        Task<ListResponse> ListAsync(ListRequest request);
        void Create(CreateRequest request);
        Task CreateAsync(CreateRequest request);
        void Summaries(SummariesRequest request);
        Task SummariesAsync(SummariesRequest request);
    }

    public class EventsClient : BaseClient<EventsClient>, IEventsClient
    {
        public EventsClient(Url url, string bearerToken, Version version)
            : base(url, bearerToken, version)
        {
        }

        public EventsClient(Url url, string bearerToken)
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

        public void Create(CreateRequest request)
        {
            Post<CreateRequest>(request);
        }

        public async Task CreateAsync(CreateRequest request)
        {
            await PostAsync<CreateRequest>(request);
        }

        public void Summaries(SummariesRequest request)
        {
            Post<SummariesRequest>(request);
        }

        public async Task SummariesAsync(SummariesRequest request)
        {
            await PostAsync<SummariesRequest>(request);
        }
    }
}
