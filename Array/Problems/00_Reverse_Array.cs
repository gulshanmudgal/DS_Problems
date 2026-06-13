using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Reverse_Array
    {
        public static void ReverseArray(int[] nums)
        {
            int startIndex = 0;
            int endIndex = nums.Length - 1;

            for (; startIndex <= endIndex; startIndex++, endIndex--)
            {
                var temp = nums[startIndex];
                nums[startIndex] = nums[endIndex];
                nums[endIndex] = temp;
            }
        }
    }
}
