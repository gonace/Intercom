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
            const string expected = "?name=Jane%20Doe&age=18&wage=25400.99&working=true&starts_at=6%2F1%2F2019%208%3A00%3A00%20AM";
            var actual = new Model().ToQueryString();

            Assert.Equal(expected, actual);
        }

        [Fact]
        [UseCulture("sv-SE")]
        public void ShouldConvertObjectToQueryStringSvSe()
        {
            const string expected = "?name=Jane%20Doe&age=18&wage=25400%2C99&working=true&starts_at=2019-06-01%2008%3A00%3A00";
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
            [QueryStringProperty("working", true)]
            public bool IsWorking => true;
            [QueryStringProperty("starts_at")]
            public DateTime StartsAt => DateTime.Parse("2019-06-01T08:00:00");
        }
    }
}
