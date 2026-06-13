using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    /// <summary>
    /// 283. Move Zeroes
    /// problem link: https://leetcode.com/problems/move-zeroes/description/
    /// </summary>
    public class MoveZeroes
    {
        public static void MoveZeroesToEnd(int[] nums)
        {
            int j = -1;
            
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    j = i;
                    break;
                }
            }

            if (j == -1)
                return;

            for(int i = j + 1; i < nums.Length;i++)
            {
                if (nums[i] != 0)
                {
                    Swap(nums, i, j);
                    j++;
                }
            }
        }

        public static void Swap(int[] nums, int firstIndex, int secondIndex)
        {
            int temp = nums[firstIndex];
            nums[firstIndex] = nums[secondIndex];
            nums[secondIndex] = temp;
        }
    }
}
