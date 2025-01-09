using System.Globalization;
using FluentAssertions;
using Solutions.P0300_0399.P0347_TopKFrequentElements;

namespace Tests.P0300_0399;

public class P0347TopKFrequentElementsTests
{
    [Theory]
    [InlineData(new[] { 1,1,1,2,2,3 }, 2, new[] { 1,2 })]
    public void TopKFrequentElements_Tests(int[] nums, int k, int[] expected)
    {
        // Act
        var result = P0347TopKFrequentElements.TopKFrequent(nums, k);
        
        // Assert
        result.Should().BeEquivalentTo(expected);
    }
}