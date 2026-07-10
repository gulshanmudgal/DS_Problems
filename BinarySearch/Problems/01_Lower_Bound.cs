namespace BinarySearch
{
    public class LowerBound
    {
        public static int FindLowerBound(int[] nums, int x)
        {
            int low = 0;
            int high = nums.Length;

            while (low < high)
            {
                int mid = low + (high - low) / 2;

                if (nums[mid] >= x)
                {
                    high = mid;
                }
                else
                {
                    low = mid + 1;
                }
            }

            return low;
        }
    }
}