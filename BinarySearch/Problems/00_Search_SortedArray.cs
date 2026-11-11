namespace BinarySearch
{
    // Question: Given an integer array sorted in ascending order containing distinct values and a target, 
    // return the target’s index, or -1 if it is absent.
    public class SearchSortedArray
    {
        public static int Search(int[] nums, int target)
        {
            int low = 0;
            int high = nums.Length - 1;

            while (low <= high)
            {
                int mid = low + (high - low)/2;
                int midValue = nums[mid];
                if (midValue == target)
                {
                    return mid;
                }

                if (midValue > target)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }

            return -1;
        }
    }
}
