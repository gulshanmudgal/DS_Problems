// Problem: Floor and Ceil in a Sorted Array
// Given a sorted array nums of n elements and a target value x, find the
// floor and ceil of x:
//   - Floor: the largest element in nums that is <= x.
//   - Ceil:  the smallest element in nums that is >= x.
// Return them as a pair {floor, ceil}. If the floor does not exist
// (x is smaller than every element) or the ceil does not exist
// (x is larger than every element), use -1 for that entry.
//
// Examples:
//   Input:  nums = [3, 4, 4, 7, 8, 10], x = 5   Output: {4, 7}
//           (4 is the largest <= 5; 7 is the smallest >= 5)
//   Input:  nums = [3, 4, 4, 7, 8, 10], x = 8   Output: {8, 8}
//           (x is present, so it is both its own floor and ceil)
//   Input:  nums = [3, 4, 4, 7, 8, 10], x = 2   Output: {-1, 3}
//           (nothing is <= 2, so no floor)
//   Input:  nums = [3, 4, 4, 7, 8, 10], x = 12  Output: {10, -1}
//           (nothing is >= 12, so no ceil)
//
// Note: both answers fall out of a single lower-bound search. If ind is
// the first index with nums[ind] >= x, then ceil = nums[ind] (or -1 when
// ind == n), and floor is either nums[ind] itself (when nums[ind] == x)
// or nums[ind - 1] (or -1 when ind == 0).
//
// Constraints: nums is sorted in non-decreasing order; must run in O(log n).

using System;

namespace BinarySearch
{
    public class FloorAndCeil
    {
        public int[] Solution(int[] nums, int x)
        {
            int n = nums.Length;

            // lower_bound: first index i where nums[i] >= x.
            // Predicate P(i) = nums[i] >= x is monotonic (false...false true...true)
            // on a sorted array, so binary search applies. Half-open [low, high).
            int low = 0, high = n;
            while (low < high)
            {
                int mid = low + (high - low) / 2;
                if (nums[mid] >= x) high = mid;   // candidate, keep it, search left
                else low = mid + 1;               // discard mid and everything left
            }

            // low is the boundary: [0, low) < x, [low, n) >= x.

            // Ceil = smallest element >= x.
            int ceil = (low < n) ? nums[low] : -1;

            // Floor = largest element <= x.
            int floor;
            if (low < n && nums[low] == x)
            {
                floor = nums[low];          // x itself is present -> it is the floor
            }
            else if (low > 0)
            {
                floor = nums[low - 1];      // last element strictly < x
            }
            else
            {
                floor = -1;                  // every element > x
            }

            return new int[2] { floor, ceil };
        }
    }
}