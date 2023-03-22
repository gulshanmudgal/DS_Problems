using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    internal class PB_05_K_Closest
    {
        public static IList<int> FindClosestElements(int[] arr, int k, int x)
        {
            IList<int> result = new List<int>();
            PriorityQueue<int, int> maxHeap = new PriorityQueue<int, int>();

            foreach (var number in arr)
            {
                maxHeap.Enqueue(number, (Int32.MaxValue - Math.Abs(x - number)));

                if(maxHeap.Count > k)
                {
                    maxHeap.Dequeue();
                }
            }

            int count = maxHeap.Count;

            for(int i = 0; i < count; i++)
            {
                result.Add(maxHeap.Dequeue());
            }

            return result;
        }
    }
}
