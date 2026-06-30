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

        /// <summary>
        /// Boyer-Moore Majority Voting extension for ⌊n/3⌋.
        /// At most 2 elements can appear more than n/3 times, so we track 2 candidates.
        /// Time: O(n), Space: O(1).
        /// </summary>
        public static IList<int> MajorityElements2SolMooresVotingApprch(int[] nums)
        {
            int candidate1 = int.MinValue;
            int candidate2 = int.MinValue;
            int count1 = 0;
            int count2 = 0;
            int n = nums.Length;
            int threshold = n / 3;

            // Phase 1: Find up to two potential candidates.
            foreach (int num in nums)
            {
                if (num == candidate1)
                {
                    count1++;
                }
                else if (num == candidate2)
                {
                    count2++;
                }
                else if (count1 == 0)
                {
                    candidate1 = num;
                    count1 = 1;
                }
                else if (count2 == 0)
                {
                    candidate2 = num;
                    count2 = 1;
                }
                else
                {
                    count1--;
                    count2--;
                }
            }

            // Phase 2: Verify the candidates actually exceed n/3.
            count1 = 0;
            count2 = 0;
            foreach (int num in nums)
            {
                if (num == candidate1) count1++;
                else if (num == candidate2) count2++;
            }

            IList<int> result = new List<int>();
            if (count1 > threshold) result.Add(candidate1);
            if (count2 > threshold) result.Add(candidate2);

            return result;
        }
    }
}
