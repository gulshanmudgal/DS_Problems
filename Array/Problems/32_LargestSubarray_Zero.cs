namespace Array
{
    public class LargestSubArrayWithSumZero
    {
        public static int LargestSubArrayWithSumZeroSol(int[] nums)
        {
            int maxLength = 0;
            int sum = 0;
            Dictionary<int, int> kvTracker = new Dictionary<int, int>();
            kvTracker.Add(0, -1);
            
            for(int i = 0; i < nums.Length; i++)
            {
                sum = sum + nums[i];
                if(kvTracker.ContainsKey(sum))
                {
                    var length = i - kvTracker[sum];
                    maxLength = Math.Max(maxLength, length);
                }
                else
                {
                    kvTracker.Add(sum, i);
                }
            }

            return maxLength;
        }
    }
}