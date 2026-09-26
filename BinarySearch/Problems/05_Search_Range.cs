// Problem: Find First and Last Position of Element in Sorted Array (LeetCode 34)
// Given a sorted array nums of n elements (may contain duplicates) and a
// target value, return the starting and ending position of target as a
// pair {first, last}. If target is not found, return {-1, -1}.
//
// Examples:
//   Input:  nums = [5, 7, 7, 8, 8, 10], target = 8   Output: {3, 4}
//   Input:  nums = [5, 7, 7, 8, 8, 10], target = 6   Output: {-1, -1}
//   Input:  nums = [], target = 0                    Output: {-1, -1}
//   Input:  nums = [2, 2], target = 2                Output: {0, 1}
//
// Note: this is one lower-bound search and one upper-bound search.
// GetLow finds the first index i where nums[i] >= target (the left
// boundary of the equal block); GetHigh finds the last index i where
// nums[i] <= target (the right boundary — the mirror image of lower
// bound, searching for the last true instead of the first true).
// Two details differ from the lower-bound skeleton:
//   - GetHigh uses the upper mid (low + (high - low + 1) / 2) because its
//     true-branch moves low up to mid; with a lower mid, low could stay
//     stuck forever when high == low + 1.
//   - Both searches verify nums[low] == target at the end, because the
//     boundary position alone doesn't prove the target actually exists.
//
// Constraints: nums is sorted in non-decreasing order; must run in O(log n).

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