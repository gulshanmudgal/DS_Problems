// Problem: Upper Bound
// Given a sorted array nums of n elements and a target value x, find the
// upper bound of x. The upper bound is the smallest index ind such that
// nums[ind] > x. If no such index exists (x is greater than or equal to all
// elements), return n.
//
// Examples:
//   Input:  nums = [1, 2, 2, 3], x = 2   Output: 3
//           (index 1 and 2 are equal to x, skip past them)
//   Input:  nums = [3, 5, 8, 15, 19], x = 9   Output: 3
//   Input:  nums = [3, 5, 8, 15, 19], x = 3   Output: 1
//   Input:  nums = [3, 5, 8, 15, 19], x = 19  Output: 5
//           (x equals the last element, so nothing is > x; return n)
//
// Note: unlike lower bound, the condition is strict (> x), so equal
// elements are excluded from the answer.
//
// Constraints: nums is sorted in non-decreasing order.

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