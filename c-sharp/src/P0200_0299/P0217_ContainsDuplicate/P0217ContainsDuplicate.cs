namespace Solutions.P0200_0299.P0217_ContainsDuplicate;

public static class P0217ContainsDuplicate
{
    /// <summary>
    /// Checks if the given array contains any duplicate values using a HashSet to track seen numbers.
    /// Returns <c>true</c> if any value appears at least twice; otherwise, <c>false</c>.
    /// This method uses a loop to check each number.
    /// </summary>
    /// <param name="nums">An array of integers to check for duplicates.</param>
    /// <returns>
    /// <c>true</c> if any integer value appears at least twice in the array;
    /// <c>false</c> if all elements are unique.
    /// </returns>
    public static bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> hashSet = [];
        foreach (var number in nums)
        {
            if (hashSet.Add(number) is false)
            {
                return true;
            }
        }
        return false;
    }
    
    /// <summary>
    /// Checks if the given array contains any duplicate values using a HashSet to track seen numbers.
    /// Returns <c>true</c> if any value appears at least twice; otherwise, <c>false</c>.
    /// This method utilizes LINQ for a more functional approach.
    /// </summary>
    /// <param name="nums">An array of integers to check for duplicates.</param>
    /// <returns>
    /// <c>true</c> if any integer value appears at least twice in the array;
    /// <c>false</c> if all elements are unique.
    /// </returns>
    public static bool ContainsDuplicate_Linq(int[] nums)
    {
        HashSet<int> hashSet = [];
        return nums.Any(number => hashSet.Add(number) is false);
    }
}