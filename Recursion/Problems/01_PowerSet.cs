class PowerSetSolution {
    public static List<List<int>> PowerSet(List<int> nums)
    {
        if(nums == null)
        {
            return new List<List<int>>();
        }
        return PowerSet(nums, 0, new List<int>(), new List<List<int>>());
    }

    private static List<List<int>> PowerSet(List<int> nums, int n, List<int> subseq, List<List<int>> sol)
    {
        if(n == nums.Count)
        {
            sol.Add(new List<int>(subseq));
            return sol;
        }

        //Pick case
        if(n != nums.Count)
        {
            subseq.Add(nums[n]);
        }
        PowerSet(nums, n+1, subseq, sol);

        // backtrack
        subseq.RemoveAt(subseq.Count - 1);

        // not pick
        PowerSet(nums, n+1, subseq, sol);

        return sol;
    }
}