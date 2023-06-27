using Intercom.Abstractions;
using Intercom.Constants;
using Intercom.Models;
using Intercom.Requests.Exports;
using System.Threading.Tasks;

namespace Intercom.Clients
{
    public interface IExportsClient
    {
        Export Get(GetRequest request);
        Task<Export> GetAsync(GetRequest request);
        Export Create(CreateRequest request);
        Task<Export> CreateAsync(CreateRequest request);
        Export Cancel(CancelRequest request);
        Task<Export> CancelAsync(CancelRequest request);
        byte[] Download(DownloadRequest request);
        Task<byte[]> DownloadAsync(DownloadRequest request);
    }

    public class ExportsClient : BaseClient<ExportsClient>, IExportsClient
    {
        public ExportsClient(Url url, string bearerToken, Version version)
            : base(url, bearerToken, version)
        {
        }

        public ExportsClient(Url url, string bearerToken)
            : base(url, bearerToken, Version.Latest)
        {
        }

        public Export Get(GetRequest request)
        {
            return Get<Export>(request);
        }

        public async Task<Export> GetAsync(GetRequest request)
        {
            return await GetAsync<Export>(request);
        }

        public Export Create(CreateRequest request)
        {
            return Post<Export, CreateRequest>(request);
        }

        public async Task<Export> CreateAsync(CreateRequest request)
        {
            return await PostAsync<Export, CreateRequest>(request);
        }

        public Export Cancel(CancelRequest request)
        {
            return Post<Export>(request);
        }

        public async Task<Export> CancelAsync(CancelRequest request)
        {
            return await PostAsync<Export>(request);
        }

        public byte[] Download(DownloadRequest request)
        {
            return Get(request);
        }

        public async Task<byte[]> DownloadAsync(DownloadRequest request)
        {
            return await GetAsync(request);
        }
    }
}
