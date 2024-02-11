using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    /// <summary>
    /// 547. Number of Provinces: https://leetcode.com/problems/number-of-provinces/description/
    /// </summary>
    internal class PB_1
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="isConnected"></param>
        /// <returns></returns>
        public static int FindCircleNum(int[][] isConnected)
        {
            int count = 0;
            Dictionary<int, HashSet<int>> adjList = new Dictionary<int, HashSet<int>>();
            GetAdjacencyList(isConnected, adjList);
            HashSet<int> visited = new HashSet<int>();

            foreach (var item in adjList)
            {
                if(!visited.Contains(item.Key))
                {
                    count++;
                    DFS(adjList, item.Key, visited);
                }
            }

            return count;
        }

        private static void GetAdjacencyList(int[][] isConnected, Dictionary<int, HashSet<int>> adjcacencyList)
        {
            int vertexCount = isConnected.Length;

            for(int i = 0; i < vertexCount; i++)
            {
                adjcacencyList.Add(i, new HashSet<int>());
                for(int j = 0; j < vertexCount; j++)
                {
                    if (isConnected[i][j] == 1)
                    {
                        adjcacencyList[i].Add(j);
                    }
                }
            }
        }

        private static void DFS(Dictionary<int, HashSet<int>> adj, int start, HashSet<int> visited)
        {
            if(!visited.Contains(start))
            {
                visited.Add(start);
                foreach (var vertex in adj[start])
                {
                    DFS(adj, vertex, visited);
                }
            }
            
        }
    }
}
