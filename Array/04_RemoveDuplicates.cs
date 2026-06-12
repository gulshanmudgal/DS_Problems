public class RemoveDuplicatesSolution {
    public static int removeDuplicates(List<int> nums) {
        if (nums == null || nums.Count == 0)
            return 0;

        List<int> uniques = new List<int>();
        uniques.Add(nums[0]);

        for (int i = 1; i < nums.Count; i++)
        {
            if (nums[i] != uniques[uniques.Count - 1])
            {
                uniques.Add(nums[i]);
            }
        }

        foreach (var item in uniques)
        {
            Console.WriteLine(item);
        }

        return uniques.Count;
    }
}
