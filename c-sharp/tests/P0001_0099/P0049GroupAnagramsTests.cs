using FluentAssertions;
using Solutions.P0001_0099.P0049_GroupAnagrams;

namespace Tests.P0001_0099;

public class P0049GroupAnagramsTests
{
    [Theory]
    [InlineData(new[] { "eat", "tea", "tan", "ate", "nat", "bat" }, new object[]
    {
        new[] { "bat" },
        new[] { "nat", "tan" },
        new[] { "ate", "eat", "tea" }
    })]
    public void GroupAnagrams_Tests(string[] strs, object[] expectedAux)
    {
        // Arrange
        IList<IList<string>> expected = expectedAux
            .Select(array => (IList<string>)((string[])array).ToList())
            .ToList();
        
        // Act
        var result = P0049GroupAnagrams.GroupAnagrams(strs);
        
        // Assert
        result.Should().BeEquivalentTo(expected);
    }
}