using Intercom.Constants;
using Intercom.Exceptions;
using Xunit;

namespace Intercom.Tests
{
    public class IntercomTests
    {
        [Fact]
        public void ShouldConfigureIntercom()
        {
            // Run
            Intercom.Configure(Url.Production, "");

            // Assert
            Assert.True(Intercom.Configured);
            Assert.NotNull(Intercom.Admins);
            Assert.NotNull(Intercom.Articles);
            Assert.NotNull(Intercom.Attributes);
            Assert.NotNull(Intercom.Companies);
            Assert.NotNull(Intercom.Contacts);
            Assert.NotNull(Intercom.Conversations);
            Assert.NotNull(Intercom.Events);
            Assert.NotNull(Intercom.Exports);
            Assert.NotNull(Intercom.Me);
            Assert.NotNull(Intercom.Messages);
            Assert.NotNull(Intercom.News);
            Assert.NotNull(Intercom.Notes);
            Assert.NotNull(Intercom.Segments);
            Assert.NotNull(Intercom.Subscriptions);
            Assert.NotNull(Intercom.Switch);
            Assert.NotNull(Intercom.Tags);
            Assert.NotNull(Intercom.Teams);
            Assert.NotNull(Intercom.Tickets);
            Assert.NotNull(Intercom.Visitors);
        }

        [Fact]
        public void ShouldThrowExceptionIfNotConfigured()
        {
            Intercom.Dispose();

            // Assert
            Assert.False(Intercom.Configured);
            Assert.Throws<NotConfiguredException>(() => Intercom.Admins);
            Assert.Throws<NotConfiguredException>(() => Intercom.Articles);
            Assert.Throws<NotConfiguredException>(() => Intercom.Attributes);
            Assert.Throws<NotConfiguredException>(() => Intercom.Companies);
            Assert.Throws<NotConfiguredException>(() => Intercom.Contacts);
            Assert.Throws<NotConfiguredException>(() => Intercom.Conversations);
            Assert.Throws<NotConfiguredException>(() => Intercom.Events);
            Assert.Throws<NotConfiguredException>(() => Intercom.Exports);
            Assert.Throws<NotConfiguredException>(() => Intercom.Me);
            Assert.Throws<NotConfiguredException>(() => Intercom.Messages);
            Assert.Throws<NotConfiguredException>(() => Intercom.News);
            Assert.Throws<NotConfiguredException>(() => Intercom.Notes);
            Assert.Throws<NotConfiguredException>(() => Intercom.Segments);
            Assert.Throws<NotConfiguredException>(() => Intercom.Subscriptions);
            Assert.Throws<NotConfiguredException>(() => Intercom.Switch);
            Assert.Throws<NotConfiguredException>(() => Intercom.Tags);
            Assert.Throws<NotConfiguredException>(() => Intercom.Teams);
            Assert.Throws<NotConfiguredException>(() => Intercom.Tickets);
            Assert.Throws<NotConfiguredException>(() => Intercom.Visitors);
        }
    }
}
