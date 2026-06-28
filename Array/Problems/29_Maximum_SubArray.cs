namespace Array
{
    public class MaximumSubArray
    {
        public static int MaximumSubArraySol(int[] nums)
        {
            int maxi = nums[0];
            int localMaxi = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                int currNumber = nums[i];
                localMaxi = Math.Max(currNumber, localMaxi + currNumber);
                maxi = Math.Max(maxi, localMaxi);
            }

            return maxi;
        }

        public static (int start, int end) MaximumSubArraySolWithIndex(int[] nums)
        {
            int maxi = nums[0];
            int localMaxi = nums[0];

            int start = 0;
            int end = 0;
            int tempStart = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                int currNumber = nums[i];
                if(currNumber > localMaxi + currNumber)
                {
                    tempStart = i;
                    localMaxi = currNumber;
                }
                else
                {
                    localMaxi = localMaxi + currNumber;
                }

                if(maxi < localMaxi)
                {
                    maxi = localMaxi;
                    start = tempStart;
                    end = i;
                }
            }

            return (start, end);
        }
    }
}