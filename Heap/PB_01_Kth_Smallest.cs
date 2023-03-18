using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    internal class PB_01_Kth_Smallest
    {
        /// <summary>
        /// Function will return the Kth smallest number in a given array.
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="kth index"></param>
        /// <returns></returns>
        public static int getSmallestNumber(int[] numbers, int k)
        {
            PriorityQueue<int, int> maxHeap = new PriorityQueue<int, int>();

            foreach (var number in numbers)
            {
                maxHeap.Enqueue(number, Int32.MaxValue - number); // to make the PQ a Max Heap setting the priority to minimum for largest number

                if(maxHeap.Count > k)
                {
                    maxHeap.Dequeue();
                }
            }

            return maxHeap.Peek();
        }
    }
}
