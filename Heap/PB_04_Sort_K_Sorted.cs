using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    internal class PB_04_Sort_K_Sorted
    {
        /// <summary>
        /// Nearly sorted/ Sort K sorted array
        /// GFG Link: https://practice.geeksforgeeks.org/problems/nearly-sorted-1587115620/1
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int[] GetNearlySorted(int[] arr, int k)
        {
            int numCount = arr.Length;
            int[] result = new int[numCount];
            int index = 0;

            PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();

            foreach (var num in arr)
            {
                minHeap.Enqueue(num, num);

                if(minHeap.Count > k)
                {
                    result[index++] = minHeap.Dequeue();
                }
            }

            for(int i = 0; i < k; i++)
            {
                result[index++] = minHeap.Dequeue();
            }

            return result;
        }
    }
}
