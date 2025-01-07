using FluentAssertions;
using Solutions.P0200_0299.P0242_ValidAnagram;
using Xunit.Abstractions;

namespace Tests.P0200_0299;

public class P0242ValidAnagramTests
{
    [Theory]
    [InlineData("anagram", "nagaram", true)]
    [InlineData("rat", "car", false)]
    [InlineData("a", "a", true)]
    public void IsAnagram_Tests(string s, string t, bool expected)
    {
        //Act
        var result = P0242ValidAnagram.IsAnagram(s, t);
        
        // Assert
        result.Should().Be(expected);
    }
    
    [Theory]
    [InlineData("anagram", "nagaram", true)]
    [InlineData("rat", "car", false)]
    [InlineData("a", "a", true)]
    public void IsAnagram_InPlace_Tests(string s, string t, bool expected)
    {
        //Act
        var result = P0242ValidAnagram.IsAnagram_InPlace(s, t);
        
        // Assert
        result.Should().Be(expected);
    }
}