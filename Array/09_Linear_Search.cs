using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class LinearSearch
    {
        public static int Search(int[] nums, int search)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == search)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
