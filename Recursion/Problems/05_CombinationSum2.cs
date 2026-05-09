public class CombinationSumOptimisedSolution
{
    public static List<List<int>> CombinationSum(int[] candidates, int target)
    {
        Array.Sort(candidates);
        var result = new List<List<int>>();
        Backtrack(candidates, target, 0, new List<int>(), result);
        return result;
    }

    private static void Backtrack(int[] candidates, int target, int startIndex, List<int> current, List<List<int>> result)
    {
        if (target == 0)
        {
            result.Add(new List<int>(current));
            return;
        }

        for (int i = startIndex; i < candidates.Length; i++)
        {
            if (candidates[i] > target)
            {
                break;
            }

            current.Add(candidates[i]);
            Backtrack(candidates, target - candidates[i], i, current, result);
            current.RemoveAt(current.Count - 1);
        }
    }
}