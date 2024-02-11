using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashing
{
    internal static class PB_1
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] results = new int[2];
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if(keyValuePairs.ContainsKey(target - nums[i]))
                {
                    results[0] = keyValuePairs[(target - nums[i])];
                    results[1] = nums[i];

                    return results;
                }
                else
                {
                    keyValuePairs.Add(nums[i], i);
                }
            }

            return results;
        }
    }
}
