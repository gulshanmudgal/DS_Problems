namespace Array
{
    public class MajorityElement2
    {
        public static IList<int> MajorityElements2Sol(int[] nums)
        {
            int n = nums.Length;
            int floor = n/3;

            IList<int> solution = new List<int>();
            Dictionary<int, int> numsCount = new Dictionary<int, int>();

            foreach(var num in nums)
            {
                if(numsCount.ContainsKey(num))
                {
                    numsCount[num] = numsCount[num] + 1;
                }
                else
                {
                    numsCount[num] = 1;
                }

                if(numsCount[num] == floor + 1)
                {
                    solution.Add(num);
                }
            }

            return solution;
        }
    }
}