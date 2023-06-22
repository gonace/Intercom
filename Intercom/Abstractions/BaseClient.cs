using Intercom.Exceptions;
using Intercom.Extensions;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Intercom.Abstractions
{
    public abstract class BaseClient<T>
    {
        private readonly Uri _baseUri;
        private readonly string _bearerToken;
        private readonly string _apiVersion;

        protected BaseClient(string baseUri, string bearerToken, Version apiVersion)
        {
            _baseUri = new Uri(baseUri);

            _bearerToken = bearerToken;
            _apiVersion = apiVersion.ToString(2);
        }

        public TReturn Get<TReturn>(PlainRequest req) =>
            Task.Run(() => GetAsync<TReturn>(req)).Result;

        public async Task<TReturn> GetAsync<TReturn>(PlainRequest req)
        {
            using (var apiClient = GetBaseHttpClient())
            {
                var request = apiClient.GetAsync(req.Uri);
                return await PerformRequestAsync<TReturn>(request);
            }
        }

        public TReturn Get<TReturn, TRequest>(PayloadRequest req) =>
            Task.Run(() => GetAsync<TReturn, TRequest>(req)).Result;

        public async Task<TReturn> GetAsync<TReturn, TRequest>(PayloadRequest req)
        {
            using (var apiClient = GetBaseHttpClient())
            {
                var message = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri(req.Uri),
                    Content = new StringContent(Serialize(req.Payload), Encoding.UTF8, "application/json")
                };
                var request = apiClient.SendAsync(message);
                return await PerformRequestAsync<TReturn>(request);
            }
        }


        public TReturn Post<TReturn>(PlainRequest req) =>
            Task.Run(() => PostAsync<TReturn>(req)).Result;

        public async Task<TReturn> PostAsync<TReturn>(PlainRequest req)
        {
            using (var apiClient = GetBaseHttpClient())
            {
                var request = apiClient.PostAsync(req.Uri, null);
                return await PerformRequestAsync<TReturn>(request);
            }
        }

        public void Post<TRequest>(PayloadRequest req) =>
            Task.Run(() => PostAsync<TRequest>(req));

        public async Task PostAsync<TRequest>(PayloadRequest req)
        {
            using (var apiClient = GetBaseHttpClient())
            {
                var request = apiClient.PostAsync(req.Uri, new StringContent(Serialize(req.Payload), Encoding.UTF8, "application/json"));
                await PerformRequestAsync(request);
            }
        }

        public TReturn Post<TReturn, TRequest>(PayloadRequest req) =>
            Task.Run(() => PostAsync<TReturn, TRequest>(req)).Result;

        public async Task<TReturn> PostAsync<TReturn, TRequest>(PayloadRequest req)
        {
            using (var apiClient = GetBaseHttpClient())
            {
                var request = apiClient.PostAsync(req.Uri, new StringContent(Serialize(req.Payload), Encoding.UTF8, "application/json"));
                return await PerformRequestAsync<TReturn>(request);
            }
        }


        public void Put<TRequest>(PayloadRequest req) =>
            Task.Run(() => PutAsync<TRequest>(req));

        public async Task PutAsync<TRequest>(PayloadRequest req)
        {
            using (var apiClient = GetBaseHttpClient())
            {
                var request = apiClient.PutAsync(req.Uri, new StringContent(Serialize(req.Payload), Encoding.UTF8, "application/json"));
                await PerformRequestAsync(request);
            }
        }

        public TReturn Put<TReturn, TRequest>(PayloadRequest req) =>
            Task.Run(() => PutAsync<TReturn, TRequest>(req)).Result;

        public async Task<TReturn> PutAsync<TReturn, TRequest>(PayloadRequest req)
        {
            using (var apiClient = GetBaseHttpClient())
            {
                var request = apiClient.PutAsync(req.Uri, new StringContent(Serialize(req.Payload), Encoding.UTF8, "application/json"));
                return await PerformRequestAsync<TReturn>(request);
            }
        }


        public void Delete(PlainRequest req) =>
            Task.Run(() => DeleteAsync(req));

        public async Task DeleteAsync(PlainRequest req)
        {
            using (var apiClient = GetBaseHttpClient())
            {
                var request = apiClient.DeleteAsync(req.Uri);
                await PerformRequestAsync(request);
            }
        }

        public TReturn Delete<TReturn>(PlainRequest req) =>
            Task.Run(() => DeleteAsync<TReturn>(req)).Result;

        public async Task<TReturn> DeleteAsync<TReturn>(PlainRequest req)
        {
            using (var apiClient = GetBaseHttpClient())
            {
                var request = apiClient.DeleteAsync(req.Uri);
                return await PerformRequestAsync<TReturn>(request);
            }
        }



        protected async Task<TReturn> PerformRequestAsync<TReturn>(Task<HttpResponseMessage> request)
        {
            var response = await request;

            if (response.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<TReturn>(await response.Content.ReadAsStringAsync());

            var details = response.Content != null ? JsonConvert.DeserializeObject<dynamic>(await response.Content.ReadAsStringAsync()) : null;
            throw new ClientException<T>(details?.Title, details?.Status, details);
        }

        protected async Task PerformRequestAsync(Task<HttpResponseMessage> request)
        {
            var response = await request;

            if (response.IsSuccessStatusCode)
                return;

            var details = response.Content != null ? JsonConvert.DeserializeObject<dynamic>(await response.Content.ReadAsStringAsync()) : null;
            throw new ClientException<T>(details?.Title, details?.Status, details);
        }

        private HttpClient GetBaseHttpClient()
        {
            var apiClient = new HttpClient
            {
                BaseAddress = _baseUri
            };

            apiClient.DefaultRequestHeaders.Accept.Clear();
            apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            apiClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _bearerToken);
            apiClient.AddVersionHeader(_apiVersion);

            return apiClient;
        }

        private string Serialize(object obj)
        {
            return JsonConvert.SerializeObject(obj, Formatting.None, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });
        }
    }
}