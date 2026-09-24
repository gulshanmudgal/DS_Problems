namespace BinarySearch
{
    public class SearchRange
    {
        public static int[] Solution(int[] nums, int target)
        {
            int low = -1;
            int high = -1;

            low = GetLow(nums, target);
            if(low != -1)
            {
                high = GetHigh(nums, target);
            }

            return new int[2] {low, high};
        }

        public static int GetLow(int[] nums, int target)
        {
            int low = 0;
            int high = nums.Length - 1;

            while(low < high)
            {
                int mid = low + (high - low)/2;
                if(nums[mid] >= target)
                {
                    high = mid;
                }
                else
                {
                    low = mid + 1;
                }
            }

            return low >= nums.Length ? -1 : nums[low] == target ? low : -1;
        }

        public static int GetHigh(int[] nums, int target)
        {
            int low = 0;
            int high = nums.Length - 1;

            while(low < high)
            {
                int mid = low + (high - low + 1)/2;
                if(nums[mid] <= target)
                {
                    low = mid;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return low >= nums.Length ? -1 : nums[low] == target ? low : -1;
        }
    }
}