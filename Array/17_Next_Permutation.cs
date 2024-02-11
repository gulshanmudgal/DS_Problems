using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class NextPermutation
    {
        public static void GetNextPermutation(int[] nums)
        {
            int index = GetLongestPrefixIndex(nums);

            if(index == -1)
            {
                Reverse(nums);
                return;
            }

            int indexToSwapWith = GetNextBiggerIndex(nums, index);
            int temp = nums[indexToSwapWith];
            nums[indexToSwapWith] = nums[index];
            nums[index] = temp;
            ReverseArrayFrom(nums, index + 1);
        }

        private static int GetLongestPrefixIndex(int[] nums)
        {
            int index = -1;

            for(int i = nums.Length - 2; i >= 0; i--)
            {
                if (nums[i] < nums[i + 1])
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        private static void Reverse(int[] nums)
        {
            int count = nums.Length;

            for(int i = 0; i < count/2; i++)
            {
                int temp = nums[i];
                nums[i] = nums[count - i - 1];
                nums[count - i - 1] = temp;
            }
        }

        private static void ReverseArrayFrom(int[] nums, int startIndex)
        {
            int count = nums.Length;

            // int numbersToReverse = (count - startIndex) / 2;
            int numbersToReverse = (count - startIndex);
            System.Array.Reverse(nums, startIndex, numbersToReverse);
            //int reversedCount = 0;
            //for(int i = 0; reversedCount < numbersToReverse; i++)
            //{
            //    int temp = nums[i + startIndex];
            //    nums[i+startIndex] = nums[count - i - 1];
            //    nums[count - i - 1] = temp;
            //    reversedCount++;
            //}
            Console.WriteLine();
        }

        private static int GetNextBiggerIndex(int[] nums, int index)
        {
            int result = -1;
            for(int i = nums.Length - 1; i > index; i--)
            {
                if (nums[i] > nums[index])
                {
                    result = i;
                    break;
                }
            }

            return result;
        }
    }
}
