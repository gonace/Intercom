using Intercom.Clients;
using Intercom.Constants;
using Intercom.Requests.Exports;
using System.Threading.Tasks;
using Xunit;

namespace Intercom.Tests.Clients
{
    public class ExportsClientTests
    {
        private readonly IExportsClient _exportsClient;

        public ExportsClientTests()
        {
            _exportsClient = new ExportsClient(Url.Production, "");
        }

        [Fact]
        public async Task ShouldBeAbleToRunRequest()
        {
            //var createRequest = new CreateRequest(1677628800, 1680307199);
            //var createResponse = await _exportsClient.CreateAsync(createRequest);

            //var getRequest = new GetRequest("");
            //var getResponse = await _exportsClient.GetAsync(getRequest);

            var downloadRequest = new DownloadRequest("");
            var downloadResponse = await _exportsClient.DownloadAsync(downloadRequest);

            //Assert.NotNull(createResponse);
            //Assert.NotNull(getResponse);
            Assert.NotNull(downloadResponse);
        }
    }
}
