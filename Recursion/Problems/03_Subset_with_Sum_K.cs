class CheckSubsequenceSumSolution {
    public static bool CheckSubsequenceSum(List<int> nums, int target)
    {
        return CheckSubsequenceSum(nums, 0, new List<int>(), 0, target);
    }

    private static bool CheckSubsequenceSum(List<int> nums, int n, List<int> subseq, int count, int target)
    {
        if(n == nums.Count)
        {
            if(count == target)
            {
                return true;
            }

            return false;
        }

        //Pick case
        if(n != nums.Count)
        {
            subseq.Add(nums[n]);
        }
        if(CheckSubsequenceSum(nums, n+1, subseq, count + nums[n], target))
            return true;

        // backtrack
        subseq.RemoveAt(subseq.Count - 1);

        // not pick
        if(CheckSubsequenceSum(nums, n+1, subseq, count, target))
            return true;

        return false;
    }
}