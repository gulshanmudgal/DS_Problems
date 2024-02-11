using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class UnionOfSortedArray
    {
        public static int[] Solve(int[] a, int[] b)
        {
            int i = 0;
            int j = 0;
            int size1 = a.Length;
            int size2 = b.Length;

            List<int> unionArray = new List<int>();

            while(i < size1 && j < size2)
            {
                if (a[i] < b[j])
                {   
                    if(unionArray.Count == 0)
                    {
                        unionArray.Add(a[i]);
                    }
                    else if (unionArray.Last() != a[i])
                    {
                        unionArray.Add(a[i]);
                    }
                    i++;
                }
                else
                {
                    if (unionArray.Count == 0)
                    {
                        unionArray.Add(b[j]);
                    }
                    else if (unionArray.Last() != b[j])
                    {
                        unionArray.Add(b[j]);
                    }
                    j++;
                }
            }

            while(i < size1)
            {
                if (unionArray.Last() != a[i])
                {
                    unionArray.Add(a[i]);
                }
                i++;
            }

            while (j < size2)
            {
                if (unionArray.Last() != b[j])
                {
                    unionArray.Add(b[j]);
                }
                j++;
            }

            return unionArray.ToArray();
        }
    }
}
