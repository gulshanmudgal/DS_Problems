// Problem: Lower Bound
// Given a sorted array nums of n elements and a target value x, find the
// lower bound of x. The lower bound is the smallest index ind such that
// nums[ind] >= x. If no such index exists (x is greater than all elements),
// return n.
//
// Examples:
//   Input:  nums = [1, 2, 2, 3], x = 2   Output: 1
//   Input:  nums = [3, 5, 8, 15, 19], x = 9   Output: 3
//   Input:  nums = [3, 5, 8, 15, 19], x = 3   Output: 0
//   Input:  nums = [3, 5, 8, 15, 19], x = 20  Output: 5
//           (x is greater than every element, so no index satisfies
//            nums[ind] >= x; return n = 5, one past the last index)
//
// Constraints: nums is sorted in non-decreasing order.

namespace BinarySearch
{
    public class LowerBound
    {
        public static int FindLowerBound(int[] nums, int x)
        {
            int low = 0;
            int high = nums.Length;

            while (low < high)
            {
                int mid = low + (high - low) / 2;

                if (nums[mid] >= x)
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