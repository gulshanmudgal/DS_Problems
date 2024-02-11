using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    internal class PB_09_Minimum_Cost
    {
        public static long MinCost(long[] arr)
        {
            long minCost = 0;
            PriorityQueue<long, long> minHeap = new PriorityQueue<long, long>();

            foreach (var number in arr)
            {
                minHeap.Enqueue(number, number);
            }

            while (minHeap.Count >= 2)
            {
                long cost1 = minHeap.Dequeue();
                long cost2 = minHeap.Dequeue();

                long newRopeCost = cost1 + cost2;
                minHeap.Enqueue(newRopeCost, newRopeCost);

                minCost = minCost + newRopeCost;
            }

            return minCost;
        }
    }
}
