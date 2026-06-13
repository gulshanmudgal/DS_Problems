using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class ArrayLeaders
    {
        public List<int> leaders(int[] nums)
        {
            List<int> result = new List<int>();
            int count = nums.Length;
            int max = Int32.MinValue;

            for(int i = count - 1; i >=0; i--)
            {
                if (nums[i] > max)
                {
                    result.Add(nums[i]);
                    max = nums[i];
                }
            }
            result.Reverse();
            return result;
        }
    }
}
