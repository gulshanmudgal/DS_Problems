using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class ThreeSum
    {
        public static IList<IList<int>> GetThreeSum(int[] nums)
        {
            System.Array.Sort(nums);

            IList<IList<int>> result = new List<IList<int>>();

            for(int i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }

                int j = i + 1;
                int k = nums.Length - 1;

                while(j < k)
                {
                    int sum = nums[i] + nums[j] + nums[k];

                    if(sum < 0)
                    {
                        j++;
                    } else if(sum > 0)
                    {
                        k--;
                    }
                    else
                    {
                        IList<int> single = new List<int>() { nums[i], nums[j], nums[k] };
                        result.Add(single);
                        j++;
                        k--;

                        while (j < k && nums[j] == nums[j -1])
                        {
                            j++;
                        }

                        while(j < k && nums[k] == nums[k + 1])
                        {
                            k--;
                        }
                    }
                }
            }

            return result;
        }
    }
}
