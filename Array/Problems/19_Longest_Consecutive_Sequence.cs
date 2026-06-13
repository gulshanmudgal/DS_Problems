using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class LongestConsecutiveSequence
    {
        public static int LongestConsecutive(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            System.Array.Sort(nums);

            int curr = nums[0];
            int max_subsequence_length = 1;
            int curr_subseq_length = 1;

            for(int i = 1; i < nums.Length; i++)
            {
                if (nums[i] - curr == 1)
                {
                    curr = nums[i];
                    curr_subseq_length++;
                }
                else if(nums[i] - curr != 0)
                {
                    max_subsequence_length = Math.Max(max_subsequence_length, curr_subseq_length);
                    curr_subseq_length = 1;
                    curr = nums[i];
                }
            }

            if(curr_subseq_length != 1)
            {
                max_subsequence_length = Math.Max(max_subsequence_length, curr_subseq_length);
            }

            return max_subsequence_length;
        }
    }
}
