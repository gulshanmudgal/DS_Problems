namespace BinarySearch
{
    public class InsertPosition
    {
        public static int Solution(int[] nums, int target)
        {
            int low = 0;
            int high = nums.Length;

            while(low < high)
            {
                int mid = low + (high - low)/2;
                if(nums[mid] == target)
                {
                    return mid;
                }
                else if(nums[mid] < target)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid;
                }
            }
            return low;
        }
    }
}