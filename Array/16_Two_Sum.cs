using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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

        public static int[] TwoSumSol(int[] nums, int target)
        {
            var seen = new Dictionary<int, int>();

            for(int i = 0; i < nums.Length; i++)
            {
                int x = nums[i];
                int need = target - x;

                if(seen.TryGetValue(need, out int j))
                {
                    return new int[2] {i, j};
                }

                if(!seen.ContainsKey(x))
                {
                    seen[x] = i;
                }
            }

            return [];
        }

        public static int[] TwoSumSol2P(int[] nums, int target)
        {
            int n = nums.Length;
            var pairs = new (int value, int index)[n];

            for(int i = 0; i < n; i++)
            {
                pairs[i] = (nums[i], i);
            }

            System.Array.Sort(pairs, (a, b) => a.value.CompareTo(b.value));

            int left = 0;
            int right = n - 1;

            while(left < right)
            {
                int sum = pairs[left].value + pairs[right].value;
                if(sum == target)
                {
                    return new int[2] {left, right};
                }

                if(sum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return [];
        }
    }
}
