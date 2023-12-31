﻿using Intercom.Abstractions;
using Intercom.Constants;
using Intercom.Models;
using Intercom.Requests.Admins;
using Intercom.Responses.Admins;
using System.Threading.Tasks;

namespace Intercom.Clients
{
    public interface IAdminsClient
    {
        ListResponse List(ListRequest request);
        Task<ListResponse> ListAsync(ListRequest request);
        Admin Get(GetRequest request);
        Task<Admin> GetAsync(GetRequest request);
        Admin Patch(SetToAwayRequest request);
        Task<Admin> PatchAsync(SetToAwayRequest request);
    }

    public class AdminsClient : BaseClient<AdminsClient>, IAdminsClient
    {
        public AdminsClient(Url url, string bearerToken, Version version)
            : base(url, bearerToken, version)
        {
        }

        public AdminsClient(Url url, string bearerToken)
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

        public Admin Get(GetRequest request)
        {
            return Get<Admin>(request);
        }

        public async Task<Admin> GetAsync(GetRequest request)
        {
            return await GetAsync<Admin>(request);
        }

        public Admin Patch(SetToAwayRequest request)
        {
            return Put<Admin, SetToAwayRequest>(request);
        }

        public async Task<Admin> PatchAsync(SetToAwayRequest request)
        {
            return await PutAsync<Admin, SetToAwayRequest>(request);
        }
    }
}
