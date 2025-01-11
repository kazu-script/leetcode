namespace Solutions.P0100_0199.P0128_LongestConsecutiveSequence;

public static class P0128LongestConsecutiveSequence
{
    public static int LongestConsecutive(int[] nums)
    {
        HashSet<int> hashSet = new(nums);
        int longestSize = 0;

        foreach (var number in hashSet)
        {
            if (hashSet.Contains(number - 1) is false)
            {
                int size = 1;

                while (hashSet.Contains(number + size))
                {
                    size++;
                }

                longestSize = Math.Max(size, longestSize);
            }
        }

        return longestSize;
    }
}