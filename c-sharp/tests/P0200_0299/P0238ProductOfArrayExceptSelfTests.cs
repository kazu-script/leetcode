using FluentAssertions;
using Solutions.P0200_0299.P0238_ProductOfArrayExceptSelf;

namespace Tests.P0200_0299;

public class P0238ProductOfArrayExceptSelfTests
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 4 }, new[] { 24, 12, 8, 6 })]
    [InlineData(new[] { -1, 1, 0, -3, 3 }, new[] { 0, 0, 9, 0, 0 })]
    [InlineData(new[] { 0, 0 }, new[] { 0, 0 })]
    [InlineData(new[] { 1, 0 }, new[] { 0, 1 })]
    [InlineData(new[] { 10, 0 }, new[] { 0, 10 })]
    [InlineData(new[] { 1, 1 }, new[] { 1, 1 })]
    [InlineData(new[] { -1, 2, 3 }, new[] { 6, -3, -2 })]
    [InlineData(new[] { -1, -2, -3 }, new[] { 6, 3, 2 })]
    public void ProductOfArrayExceptSelf_Tests(int[] nums, int[] expected)
    {
        // Act
        var result = P0238ProductOfArrayExceptSelf.ProductExceptSelf(nums);
        
        // Assert
        result.Should().BeEquivalentTo(expected);
    }
}