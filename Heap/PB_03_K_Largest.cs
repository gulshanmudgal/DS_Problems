using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    internal class PB_03_K_Largest
    {
        /// <summary>
        /// GFG Link: https://practice.geeksforgeeks.org/problems/k-largest-elements4206/1?utm_source=gfg&utm_medium=article&utm_campaign=bottom_sticky_on_article
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int[] GetKLargest(int[] arr, int k)
        {
            // code here
            PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();

            foreach (var item in arr)
            {
                minHeap.Enqueue(item, item);

                if(minHeap.Count > k)
                {
                    minHeap.Dequeue();
                }
            }

            int[] result = new int[k];

            for(int i = 0; i < k; i++)
            {
                result[k - i - 1] = minHeap.Dequeue();
            }

            return result;
        }
    }
}
