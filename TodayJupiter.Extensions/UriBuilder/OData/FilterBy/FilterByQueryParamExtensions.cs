using System;

namespace TodayJupiter.Extensions.UriBuilder.OData.FilterBy
{
    public static partial class FilterByQueryParamExtensions
    {
        public static System.UriBuilder FilterByQueryParam(this System.UriBuilder input,string filterBy, string filterValue)
        {
            if (string.IsNullOrWhiteSpace(filterBy))
            {
                throw new ArgumentNullException(nameof(filterBy), "FilterBy value cannot be null or empty.");
            }

            if (string.IsNullOrWhiteSpace(filterValue))
            {
                throw new ArgumentNullException(nameof(filterValue), "FilterValue value cannot be null or empty.");
            }
            var query = $"$filter={filterBy} eq {filterValue}";
            input.Query = query;
            return input;
        }
    }
}