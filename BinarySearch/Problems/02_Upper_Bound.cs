namespace BinarySearch
{
    public class UpperBound
    {
        public static int FindUpperBound(int[] nums, int x)
        {
            int low = 0;
            int high = nums.Length;

            while (low < high)
            {
                int mid = low + (high - low) / 2;

                if (nums[mid] > x)
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