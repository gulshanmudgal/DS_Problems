using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class FourSum
    {
        public static IList<IList<int>> GetFourSum(int[] nums, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();

            System.Array.Sort(nums);

            for(int i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }

                for(int j = i + 1; j < nums.Length; j++)
                {
                    if(j > i + 1 && nums[j] == nums[j - 1])
                    {
                        continue;
                    }

                    int k = j + 1;
                    int l = nums.Length - 1;

                    while (k < l)
                    {
                        long sum = (long)nums[i] + (long)nums[j] + (long)nums[k] + (long)nums[l];

                        if (sum == target)
                        {
                            IList<int> temp = new List<int>() { nums[i], nums[j], nums[k], nums[l] };
                            result.Add(temp);

                            k++;
                            l--;

                            while (k < l && nums[k] == nums[k - 1])
                            {
                                k++;
                            }

                            while(l > k && nums[l] == nums[l + 1])
                            {
                                l--;
                            }
                        }
                        else if (sum < target)
                        {
                            k++;
                        }
                        else
                        {
                            l--;
                        }
                    }
                }
            }

            return result;
        }
    }
}
