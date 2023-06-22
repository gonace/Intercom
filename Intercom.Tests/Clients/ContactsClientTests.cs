using Intercom.Clients;
using Intercom.Constants;
using Intercom.Requests.Contacts;
using Xunit;

namespace Intercom.Tests.Clients
{
    public class ContactsClientTests
    {
        private readonly IContactsClient _contactsClient;

        public ContactsClientTests()
        {
            _contactsClient = new ContactsClient(Url.Production, "");
        }

        [Fact]
        public void ShouldBeAbleToRunRequest()
        {
            var request = new ListRequest
            {
                PerPage = 10,
                Page = 2
            };

            var response = _contactsClient.List(request);

            Assert.NotNull(response);
        }
    }
}
