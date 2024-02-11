using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class IntersectionOfSortedArray
    {
        public static int[] Intersection(int[] nums1, int[] nums2)
        {
            int i = 0;
            int j = 0;
            int size1 = nums1.Length;
            int size2 = nums2.Length;

            List<int> solution = new List<int>();

            while(i < size1 && j < size2)
            {
                if (nums1[i] == nums2[j])
                {
                    solution.Add(nums1[i]);
                    i++;
                    j++;
                }
                else if (nums1[i] > nums2[j])
                {
                    j++;
                }
                else
                {
                    i++;
                }
            }

            return solution.ToArray();
        }
    }
}
