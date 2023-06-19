using Intercom.Clients;
using Intercom.Constants;
using Intercom.Models;
using Intercom.Requests.Companies;
using System.Collections.Generic;
using Xunit;

namespace Intercom.Tests.Clients
{
    public class CompaniesClientTests
    {
        private readonly ICompaniesClient _companiesClient;

        public CompaniesClientTests()
        {
            _companiesClient = new CompaniesClient(Url.Production, "");
        }

        [Fact]
        public void ShouldBeAbleToRunRequest()
        {
            var company = new Company
            {
                Name = "Obscured",
                CompanyId = "Obscured_1",
                Plan = new Plan
                {
                    Name = "Enterprise"
                },
                Size = 10,
                Attributes = new Dictionary<string, object>
                {
                    {"foo", "bar"},
                    {"bar", "foo"}
                }
            };
            var request = new UpsertRequest(company);

            var response = _companiesClient.Upsert(request);

            Assert.NotNull(response);
        }
    }
}
