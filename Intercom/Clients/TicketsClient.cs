using Intercom.Abstractions;
using Intercom.Constants;
using Intercom.Models;
using Intercom.Models.Tickets;
using Intercom.Requests.Tickets;
using System.Threading.Tasks;

namespace Intercom.Clients
{
    public interface ITicketsClient
    {
        Ticket Get(GetRequest request);
        Task<Ticket> GetAsync(GetRequest request);
        Ticket Create(CreateRequest request);
        Task<Ticket> CreateAsync(CreateRequest request);
        Ticket Update(UpdateRequest request);
        Task<Ticket> UpdateAsync(UpdateRequest request);
        Part Reply(ReplyRequest request);
        Task<Part> ReplyAsync(ReplyRequest request);

        Tickets.IAttributesClient Attributes { get; }
        Tickets.ITypesClient Types { get; }
    }

    public class TicketsClient : BaseClient<TicketsClient>, ITicketsClient
    {
        public TicketsClient(Url url, string bearerToken, Version version)
            : base(url, bearerToken, version)
        {
            Attributes = new Tickets.AttributesClient(url, bearerToken, version);
            Types = new Tickets.TypesClient(url, bearerToken, version);
        }

        public TicketsClient(Url url, string bearerToken)
            : base(url, bearerToken, Version.Latest)
        {
            Attributes = new Tickets.AttributesClient(url, bearerToken);
            Types = new Tickets.TypesClient(url, bearerToken);
        }

        public Ticket Get(GetRequest request)
        {
            return Get<Ticket>(request);
        }

        public async Task<Ticket> GetAsync(GetRequest request)
        {
            return await GetAsync<Ticket>(request);
        }

        public Ticket Create(CreateRequest request)
        {
            return Post<Ticket, CreateRequest>(request);
        }

        public async Task<Ticket> CreateAsync(CreateRequest request)
        {
            return await PostAsync<Ticket, CreateRequest>(request);
        }

        public Ticket Update(UpdateRequest request)
        {
            return Put<Ticket, UpdateRequest>(request);
        }

        public async Task<Ticket> UpdateAsync(UpdateRequest request)
        {
            return await PutAsync<Ticket, UpdateRequest>(request);
        }

        public Part Reply(ReplyRequest request)
        {
            return Post<Part, ReplyRequest>(request);
        }

        public async Task<Part> ReplyAsync(ReplyRequest request)
        {
            return await PostAsync<Part, CreateRequest>(request);
        }

        public Tickets.IAttributesClient Attributes { get; }
        public Tickets.ITypesClient Types { get; }
    }
}
