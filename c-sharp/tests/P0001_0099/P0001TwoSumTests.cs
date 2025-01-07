using FluentAssertions;
using Solutions.P0001_0099.P0001_TwoSum;

namespace Tests.P0001_0099;

public class P0001TwoSumTests
{
    [Theory]
    [InlineData(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
    [InlineData(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
    [InlineData(new[] { 3, 3 }, 6, new[] { 0, 1 })]
    public void TwoSumTest(int[] nums, int target, int[] expected)
    {
        // Act
        var result = P0001TwoSum.TwoSum(nums, target);
        
        // Assert
        result.Should().BeEquivalentTo(expected);
    }
}