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