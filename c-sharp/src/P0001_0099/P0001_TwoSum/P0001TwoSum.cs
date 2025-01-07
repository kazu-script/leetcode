namespace Solutions.P0001_0099.P0001_TwoSum;

public static class P0001TwoSum
{
    /// <summary>
    /// Finds two indices such that the numbers at these indices in the array add up to a specified target.
    /// </summary>
    /// <param name="nums">An array of integers where the method searches for two numbers which add up to the target.</param>
    /// <param name="target">The integer value that the two numbers from the <c>nums</c> array need to add up to.</param>
    /// <returns>
    /// An array of two integers representing the indices of the two numbers in the <c>nums</c> array that add up to <c>target</c>.
    /// </returns>
    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> previousElementsPositions = new ();

        for (var i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (previousElementsPositions.TryGetValue(complement, out var complementIndex))
            {
                return [complementIndex, i];
            }

            previousElementsPositions[nums[i]] = i;
        }

        return [];
    }
}