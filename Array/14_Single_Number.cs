using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class SingleNumber
    {
        public static int GetSingleNumberOptimal(int[] nums)
        {
            int xor = 0;
            int numsCount = nums.Length;

            for (int i = 0; i < numsCount; i++)
            {
                xor = xor ^ nums[i];
            }

            return xor;
        }
    }
}
