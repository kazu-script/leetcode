using FluentAssertions;
using Solutions.P0100_0199.P0128_LongestConsecutiveSequence;

namespace Tests.P0100_0199;

public class P0128LongestConsecutiveSequenceTests
{
    [Theory]
    [InlineData(new[] { 100, 4, 200, 1, 3, 2 }, 4)]
    [InlineData(new[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 }, 9)]
    [InlineData(new[] { 1 }, 1)]
    [InlineData(new int[] { }, 0)]
    public void LongestConsecutiveSequence_Tests(int[] nums, int expected)
    {
        // Act
        var result = P0128LongestConsecutiveSequence.LongestConsecutive(nums);
        
        // Assert
        result.Should().Be(expected);
    }
}