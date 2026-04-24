public class CountSubsequenceWithTargetSumSolution {
    public static int CountSubsequenceWithTargetSum(int[] nums, int k) {
        if (nums == null) 
            return 0;
        
        return CountSubsequenceWithTargetSum(nums, 0, k, 0);
    }

    private static int CountSubsequenceWithTargetSum(int[] nums, int index, int target, int currSum)
    {
        if (index == nums.Length)
        {
            return currSum == target ? 1 : 0;
        }

        // Pick
        int include = CountSubsequenceWithTargetSum(nums, index + 1, target, currSum + nums[index]);

        // Not Pick
        int exclude = CountSubsequenceWithTargetSum(nums, index + 1, target, currSum);

        return include + exclude;
    }
}
