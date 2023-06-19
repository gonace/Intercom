using Intercom.Attributes;
using Intercom.Extensions;
using Intercom.Tests.Helpers;
using System;
using Xunit;

namespace Intercom.Tests.Extensions
{
    public class ObjectExtensionsTests
    {
        [Fact]
        [UseCulture("en-US")]
        public void ShouldConvertObjectToQueryStringForCultureEnUs()
        {
            const string expected = "?name=Jane Doe&age=18&wage=25400.99&working=true&startedat=6/1/2019 8:00:00 AM";
            var actual = new Model().ToQueryString();

            Assert.Equal(expected, actual);
        }

        [Fact]
        [UseCulture("sv-SE")]
        public void ShouldConvertObjectToQueryStringSvSe()
        {
            const string expected = "?name=Jane Doe&age=18&wage=25400,99&working=true&startedat=2019-06-01 08:00:00";
            var actual = new Model().ToQueryString();

            Assert.Equal(expected, actual);
        }

        private class Model
        {
            [QueryStringProperty]
            public string Name => "Jane Doe";
            [QueryStringProperty]
            public int Age => 18;
            [QueryStringProperty("wage")]
            public decimal Salary => new decimal(25400.99);
            [QueryStringProperty("working")]
            public bool IsWorking => true;
            [QueryStringProperty]
            public DateTime StartedAt => DateTime.Parse("2019-06-01T08:00:00");
        }
    }
}
