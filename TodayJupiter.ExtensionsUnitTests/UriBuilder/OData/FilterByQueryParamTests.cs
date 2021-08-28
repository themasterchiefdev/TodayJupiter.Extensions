using System;
using FluentAssertions;
using TodayJupiter.Extensions.UriBuilder.OData;
using TodayJupiter.ExtensionsUnitTests.TestData;
using Xunit;

namespace TodayJupiter.ExtensionsUnitTests.UriBuilder.OData
{
    public class FilterByQueryParamTests
    {
        [Theory]
        [InlineData("https://localhost.com/api", "name","abc", "https://localhost.com/api?$filter=name eq abc")]
        [InlineData("https://localhost.com/api", "firstname","bbc", "https://localhost.com/api?$filter=firstname eq bbc")]
        public void ReturnsExpectedResultGivenValue(string Url,string filterByValue,string filterValue,string expected)
        {
            var actual = new System.UriBuilder(Url).FilterByQueryParam(filterByValue,filterValue);
            actual.Uri.ToString().Should().BeEquivalentTo(expected);
        }
        [Theory]
        [ClassData(typeof(TestDataForVerification))]
        public void ThrowsAnExceptionGivenNullFilterByValueIsNullOrEmpty(string filterByValue)
        {
           Action act=() => new System.UriBuilder("https://localhost.com/api").FilterByQueryParam(filterByValue, "aac");
           act.Should().Throw<ArgumentNullException>();
        }

        [Theory]
        [ClassData(typeof(TestDataForVerification))]
        public void ThrowsAnExceptionGivenNullFilterValueIsNullOrEmpty(string filterValue)
        {
            Action act = () => new System.UriBuilder("https://localhost.com/api").FilterByQueryParam("filterByValue", filterValue);
            act.Should().Throw<ArgumentNullException>();
        }
    }
}