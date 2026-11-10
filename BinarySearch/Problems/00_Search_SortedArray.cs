namespace BinarySearch
{
    // Question: Given a sorted integer array that may contains only distinct integers and a target,
    // return the index of the target's first occurrence, or -1 if it is absent.
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
