using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    internal class PB_08_Closeset_Points
    {
        /// <summary>
        /// 973. K Closest Points to Origin
        /// Leetcode Link: https://leetcode.com/problems/k-closest-points-to-origin/
        /// </summary>
        /// <param name="points"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int[][] KClosest(int[][] points, int k)
        {
            int[][] results = new int[k][];
            PriorityQueue<(int x, int y), int> maxHeap = new PriorityQueue<(int x, int y), int> ();

            foreach (var point in points)
            {
                int distance = point[0] * point[0] + point[1] * point[1];
                maxHeap.Enqueue((point[0], point[1]), Int32.MaxValue - distance);

                if(maxHeap.Count > k)
                {
                    maxHeap.Dequeue();
                }
            }

            int count = maxHeap.Count;

            for(int i = 0; i < count; i++)
            {
                var point = maxHeap.Dequeue();
                results[i] = new int[2];
                results[i][0] = point.x;
                results[i][1] = point.y;
            }

            return results;
        }
    }
}
