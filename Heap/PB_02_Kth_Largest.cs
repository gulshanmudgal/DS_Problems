using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    internal class PB_02_Kth_Largest
    {
        /// <summary>
        /// Function will return the Kth smallest number in a given array.
        /// Leetcode link: https://leetcode.com/problems/kth-largest-element-in-an-array/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int FindKthLargest(int[] nums, int k)
        {
            PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();

            foreach (int number in nums)
            {
                minHeap.Enqueue(number, number);

                if(minHeap.Count > k)
                {
                    minHeap.Dequeue();
                }
            }

            return minHeap.Peek();
        }
    }
}
