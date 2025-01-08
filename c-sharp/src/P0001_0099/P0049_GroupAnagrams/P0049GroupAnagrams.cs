using Solutions.P0200_0299.P0242_ValidAnagram;

namespace Solutions.P0001_0099.P0049_GroupAnagrams;

public static class P0049GroupAnagrams
{
    private const int NLetters = 26;
    
    public static IList<IList<string>> GroupAnagrams(string[] strs)
    {
        // Key => Word letters counter hash code
        // Value => List of anagrams
        Dictionary<int, IList<string>> anagramGroups = new();

        foreach (var word in strs)
        {
            var counter = CountLetters(word);
            var counterHashCode = GetArrayHashCode(counter);

            if (anagramGroups.TryGetValue(counterHashCode, out var group))
            {
                group.Add(word);
            }
            else
            {
                anagramGroups.Add(counterHashCode, [word]);
            }
        }

        return anagramGroups.Values.ToList();
    }
    
    private static int[] CountLetters(string s)
    {
        int[] counter = new int[NLetters];

        foreach (var letter in s)
        {
            counter[letter - 'a']++;
        }
        
        return counter;
    }

    private static int GetArrayHashCode(int[] array)
    {
        var hash = new HashCode();
        
        foreach (var element in array)
        {
            hash.Add(element);
        }

        return hash.ToHashCode();
    }
}