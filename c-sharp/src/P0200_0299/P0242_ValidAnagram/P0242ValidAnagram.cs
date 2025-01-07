namespace Solutions.P0200_0299.P0242_ValidAnagram;

public static class P0242ValidAnagram
{
    private const int NLetters = 26;
    
    /// <summary>
    /// Determines if one string is an anagram of another.
    /// </summary>
    /// <param name="s">The first string to be analyzed.</param>
    /// <param name="t">The second string to be compared against the first.</param>
    /// <returns>
    /// Returns <c>true</c> if string <c>t</c> is an anagram of string <c>s</c>;
    /// otherwise, returns <c>false</c>.
    /// Note: An anagram is a word or phrase that is made by rearranging the letters of another,
    /// typically using all the original letters exactly once.
    /// </returns>
    public static bool IsAnagram(string s, string t)
    {
        var counterS = CountLetters(s);
        var counterT = CountLetters(t);

        for (var i = 0; i < NLetters; i++)
        {
            if (counterS[i] != counterT[i])
            {
                return false;
            }
        }

        return true;
    }
    
    /// <summary>
    /// Determines if one string is an anagram of another.
    /// </summary>
    /// <param name="s">The first string to be analyzed.</param>
    /// <param name="t">The second string to be compared against the first.</param>
    /// <returns>
    /// Returns <c>true</c> if string <c>t</c> is an anagram of string <c>s</c>;
    /// otherwise, returns <c>false</c>.
    /// Note: An anagram is a word or phrase that is made by rearranging the letters of another,
    /// typically using all the original letters exactly once.
    /// </returns>
    public static bool IsAnagram_InPlace(string s, string t)
    {
        var counter = CountLetters(s);
        SubtractLetters(counter, t);

        for (var i = 0; i < NLetters; i++)
        {
            if (counter[i] != 0)
            {
                return false;
            }
        }

        return true;
    }
    
    /// <summary>
    /// Counts the frequency of each lowercase English letter in the provided string.
    /// </summary>
    /// <param name="s">The string from which to count letter frequencies.</param>
    /// <returns>
    /// An array of integers where each index corresponds to a letter in the English alphabet
    /// (index 0 for 'a', index 1 for 'b', ..., index 25 for 'z') and the value at each index
    /// represents the count of that letter in the input string <c>s</c>.
    /// </returns>
    /// <remarks>
    /// This method assumes that the input string contains only lowercase English letters (a-z).
    /// It uses a fixed-size integer array where the length is 26, corresponding to the number
    /// of letters in the English alphabet.
    /// </remarks>
    private static int[] CountLetters(string s)
    {
        int[] counter = new int[NLetters];

        foreach (var letter in s)
        {
            counter[letter - 'a']++;
        }
        
        return counter;
    }

    /// <summary>
    /// Modifies the provided counter array by decrementing the count of each letter in the given string.
    /// </summary>
    /// <param name="counter">An array representing the frequency count of letters where each index corresponds to a letter ('a' to 'z') and the value at each index represents the count of that letter. This array is modified in place.</param>
    /// <param name="s">The string whose letters will be used to decrement their respective counts in the counter.</param>
    /// <returns>
    /// The modified <c>counter</c> array with updated frequencies after subtracting the counts of letters found in <c>s</c>.
    /// </returns>
    /// <remarks>
    /// This method directly modifies the input <c>counter</c> array. Each letter in the input string <c>s</c> decreases the corresponding index in the <c>counter</c> by one.
    /// It assumes that both the input string contains only lowercase English letters.
    /// </remarks>
    private static int[] SubtractLetters(int[] counter, string s)
    {
        foreach (var letter in s)
        {
            counter[letter - 'a']--;
        }
        
        return counter;
    }
}