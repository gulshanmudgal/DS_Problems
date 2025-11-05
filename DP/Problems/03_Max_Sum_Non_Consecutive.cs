namespace DP.Solutions
{
    public class NonConsecutiveMaxSum
    {
        public static int MaximumNonAdjacentSum(int[] nums)
        {
            return GetMaxSumRec(nums, nums.Length - 1);
        }

        public static int GetMaxSumRec(int[] nums, int index)
        {
            if (index == 0)
            {
                return nums[0];
            }

            if (index <= 0)
            {
                return 0;
            }

            int pick = nums[index] + GetMaxSumRec(nums, index - 2);
            int nonPick = GetMaxSumRec(nums, index - 1);

            return Math.Max(pick, nonPick);
        }
    }
}
