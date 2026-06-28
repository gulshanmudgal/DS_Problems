namespace Array
{
    public class MajorityElement
    {
        public static int MajorityElementSolHash(int[] nums)
        {
            var counts = new Dictionary<int,int>();
            int threshold = (nums.Length/2);

            foreach(var num in nums)
            {
                if(counts.TryGetValue(num, out int val))
                {
                    val++;
                    counts[num] = val;
                }
                else
                {
                    counts[num] = 1;
                }

                if(counts[num] > threshold)
                {
                    return num;
                }
            }
            return -1;
        }

        /// <summary>
        /// This is a problem for solving majority element problem using the Moore's Voting algo
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int MajorityElementSolMooresVotingApprch(int[] nums)
        {
            int candidate = Int16.MinValue;
            int candidateCount = 0;
            int count = nums.Length;
            int threshold = count / 2;

            for(int i = 0; i < count; i++)
            {
                if(candidateCount == 0)
                {
                    candidate = nums[i];
                    candidateCount++;
                }
                else if(nums[i] != candidate)
                {
                    candidateCount--;
                }
                else
                {
                    candidateCount++;
                }
            }

            if(candidateCount > 0)
            {
                int potentialCount = 0;
                foreach(var num in nums)
                {
                    if(num == candidate)
                    {
                        potentialCount++;
                    }
                }

                if(potentialCount > threshold)
                    return candidate;
            }

            return -1;
        }
    }
}