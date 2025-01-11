namespace Solutions.P0200_0299.P0238_ProductOfArrayExceptSelf;

public static class P0238ProductOfArrayExceptSelf
{
    public static int[] ProductExceptSelf(int[] nums)
    {
        var leftProducts = CalculateLeftProducts(nums);
        return MultiplyRightProducts(nums, leftProducts);
    }

    private static int[] CalculateLeftProducts(int[] nums)
    {
        var leftProducts = new int[nums.Length];
        leftProducts[0] = 1;

        for (var i = 1; i < nums.Length; i++)
        {
            leftProducts[i] = leftProducts[i - 1] * nums[i - 1];
        }

        return leftProducts;
    }

    private static int[] MultiplyRightProducts(int[] nums, int[] leftProducts)
    {
        int lastIndex = nums.Length - 1;
        int rightProduct = 1;

        for (int i = lastIndex - 1; i >= 0; i--)
        {
            rightProduct *= nums[i+1];
            leftProducts[i] *= rightProduct;
        }

        return leftProducts;
    }
}