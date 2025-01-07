using FluentAssertions;
using Solutions.P0200_0299.P0217_ContainsDuplicate;

namespace Tests.P0200_0299;

public class P0217ContainsDuplicateTests
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 1 }, true)]
    [InlineData(new[] { 1, 2, 3, 4 }, false)]
    [InlineData(new[] { 1,1,1,3,3,4,3,2,4,2 }, true)]
    [InlineData(new[] { 1 }, false)]
    [InlineData(new int[] { }, false)]
    public void ContainsDuplicates_Loop(int[] nums, bool expected)
    {
        // Act
        var result = P0217ContainsDuplicate.ContainsDuplicate(nums);
        
        // Assert
        result.Should().Be(expected);
    }
    
    [Theory]
    [InlineData(new[] { 1, 2, 3, 1 }, true)]
    [InlineData(new[] { 1, 2, 3, 4 }, false)]
    [InlineData(new[] { 1,1,1,3,3,4,3,2,4,2 }, true)]
    [InlineData(new[] { 1 }, false)]
    [InlineData(new int[] { }, false)]
    public void ContainsDuplicates_Linq(int[] nums, bool expected)
    {
        // Act
        var result = P0217ContainsDuplicate.ContainsDuplicate_Linq(nums);
        
        // Assert
        result.Should().Be(expected);
    }
}