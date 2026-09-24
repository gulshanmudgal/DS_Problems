namespace BinarySearch
{
    class SearchSortedRotatedArray
    {
        public static int Search(int[] nums, int k)
        {
            int pivot = GetPivotPoint(nums);
            int startIndex = 0;
            int endIndex = nums.Length - 1;

            // pivot == -1: array fully sorted, search the whole range as-is
            if(pivot != -1)
            {
                if(nums[0] > k)
                {
                    startIndex = pivot + 1;
                }
                else
                {
                    endIndex = pivot;
                }
            }

            return FindIndex(nums, startIndex, endIndex, k);
        }

        public static int GetPivotPoint(int[] nums)
        {
            int length = nums.Length;
            int low = 0;
            int high = length - 1;

            while(low < high)
            {
                int mid = low + (high - low + 1)/2;
                if(nums[mid] > nums[0])
                {
                    low = mid;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return (low < length - 1 && nums[low] > nums[low + 1]) ? low : -1;
        }

        private static int FindIndex(int[] nums, int startIndex, int endIndex, int target)
        {
            int low = startIndex;
            int high = endIndex;

            while(low <= high)
            {
                int mid = low + (high - low) / 2;
                if(nums[mid] == target)
                {
                    return mid;
                }

                if(nums[mid] > target)
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
