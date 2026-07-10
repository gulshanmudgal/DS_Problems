namespace BinarySearch
{
    public class SearchSortedArray
    {
        public static int Search(int[] nums, int target)
        {
            int low = 0;
            int high = nums.Length - 1;

            while (low <= high)
            {
                int mid = GetMidIndex(low, high);
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

        private static int GetMidIndex(int low, int high)
        {
            return (low + high) / 2;
        }
    }
}