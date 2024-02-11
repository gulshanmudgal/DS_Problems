using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class TwoSum
    {
        public static int[] TwoSumBetter(int[] nums, int target)
        {
            Dictionary<int, int> numsMap = new Dictionary<int, int>();
            int count = nums.Length;

            for (int i = 0; i < count; i++)
            {
                int localTarget = target - nums[i];
                if (numsMap.ContainsKey(localTarget))
                {
                    return new int[] { numsMap[localTarget], i };
                }
                else if (!numsMap.ContainsKey(nums[i]))
                {
                    numsMap.Add(nums[i], i);
                }
            }

            return new int[] { };
        }
    }
}
