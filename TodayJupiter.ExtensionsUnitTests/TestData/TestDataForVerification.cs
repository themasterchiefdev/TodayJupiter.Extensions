using System.Collections;
using System.Collections.Generic;

namespace TodayJupiter.ExtensionsUnitTests.TestData
{
    /// <summary>
    ///     This class setups up string test data
    /// </summary>
    public class TestDataForVerification : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { "" };
            yield return new object[] {  " " };
            yield return new object[] {string.Empty };
            yield return new object[] { null };
        }

      
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}