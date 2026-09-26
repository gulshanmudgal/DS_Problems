// Problem: Search Insert Position (LeetCode 35)
// Given a sorted array nums of n distinct elements and a target value,
// return the index if the target is found. If not, return the index where
// it would be inserted to keep the array sorted.
//
// Examples:
//   Input:  nums = [1, 3, 5, 6], target = 5   Output: 2
//           (target found at index 2)
//   Input:  nums = [1, 3, 5, 6], target = 2   Output: 1
//           (not found; 2 belongs between 1 and 3)
//   Input:  nums = [1, 3, 5, 6], target = 7   Output: 4
//           (not found; 7 belongs after the last element, so return n)
//   Input:  nums = [1, 3, 5, 6], target = 0   Output: 0
//           (not found; 0 belongs before the first element)
//
// Note: when the target is absent, the answer is exactly the lower bound —
// the first index i where nums[i] >= target. The early return for an exact
// match returns the same index the lower-bound search would converge to.
//
// Constraints: nums is sorted in ascending order with distinct values;
// must run in O(log n).

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