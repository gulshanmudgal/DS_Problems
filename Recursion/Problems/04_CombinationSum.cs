public class CombinationSumSolution
{
    public static List<List<int>> CombinationSum(int[] candidates, int target)
    {
        return CombinationSum(candidates.ToList(), target, new List<List<int>>(), new List<int>(), 0);
    }

    public static List<List<int>> CombinationSum(List<int> candidates, int target, List<List<int>> solution, List<int> subsequence, int index)
    {
        if(target == 0)
        {
            solution.Add(new List<int>(subsequence));
            return solution;
        }
        if(index >= candidates.Count || target < 0)
        {
            return solution;
        }

        // pick
        subsequence.Add(candidates[index]);
        CombinationSum(candidates, target - candidates[index], solution, subsequence, index);

        // backtrack
        subsequence.RemoveAt(subsequence.Count - 1);

        // not pick
        CombinationSum(candidates, target, solution, subsequence, index + 1);

        return solution;
    }
}