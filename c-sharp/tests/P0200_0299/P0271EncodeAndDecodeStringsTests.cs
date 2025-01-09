using FluentAssertions;
using Solutions.P0200_0299.P0271_EncodeAndDecodeStrings;

namespace Tests.P0200_0299;

public class P0271EncodeAndDecodeStringsTests
{
    [Fact]
    public void EncodeAndDecodeStrings_Test1()
    {
        // Arrange
        List<string> strs = ["neet", "code", "love", "you"];

        // Act
        var encodedString = P0271EncodeAndDecodeStrings.Encode(strs);
        var decodedList = P0271EncodeAndDecodeStrings.Decode(encodedString);
        
        // Assert
        decodedList.Should().BeEquivalentTo(strs);
    }
    
    [Fact]
    public void EncodeAndDecodeStrings_Test2()
    {
        // Arrange
        List<string> strs = [""];

        // Act
        var encodedString = P0271EncodeAndDecodeStrings.Encode(strs);
        var decodedList = P0271EncodeAndDecodeStrings.Decode(encodedString);
        
        // Assert
        decodedList.Should().BeEquivalentTo(strs);
    }
}