using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class LeftRotateByOne
    {
        public static void Rotate(int[] nums)
        {
            int count = nums.Count();
            int temp = nums[0];

            for(int i = 1; i < nums.Length; i++)
            {
                nums[i - 1] = nums[i];
            }

            nums[count-1] = temp;
        }
    }
}
