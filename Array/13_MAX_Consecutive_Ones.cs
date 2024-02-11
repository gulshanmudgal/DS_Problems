using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class MaxConsecutiveOnes
    {
        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            int maxCount = 0;
            int count = 0;
            int numsCount = nums.Length;

            for(int i = 0; i < numsCount; i++)
            {
                if (nums[i] == 1)
                {
                    count++;
                    maxCount = Math.Max(maxCount, count);
                }
                else
                {
                    count = 0;
                }
            }

            return maxCount;
        }
    }
}
