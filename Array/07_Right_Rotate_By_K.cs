using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class RightRotateByK
    {
        public static void Rotate(int[] nums, int k)
        {
            var count = nums.Length;
            k = k % count;
            ReverseArray(nums, (count - k), count - 1);
            ReverseArray(nums, 0, count - k - 1);
            ReverseArray(nums, 0, count - 1);
        }

        public static void ReverseArray(int[] nums, int startIndex, int endIndex)
        {
            for (; startIndex <= endIndex; startIndex++, endIndex--)
            {
                var temp = nums[startIndex];
                nums[startIndex] = nums[endIndex];
                nums[endIndex] = temp;
            }
        }
    }
}
