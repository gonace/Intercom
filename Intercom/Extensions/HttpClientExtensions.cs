using Intercom.Constants;
using System.Net.Http;

namespace Intercom.Extensions
{
    public static class HttpClientExtensions
    {
        public static void AddVersionHeader(this HttpClient httpClient, string version)
        {
            httpClient.DefaultRequestHeaders.Add(HttpHeaders.IntercomVersion, version);
        }
    }
}
