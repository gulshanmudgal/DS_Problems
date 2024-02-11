using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    /// <summary>
    /// 200. Number of Islands: https://leetcode.com/problems/number-of-islands/
    /// Given an m x n 2D binary grid grid which represents a map of '1's (land) and '0's (water), return the number of islands.
    /// </summary>
    internal class PB_2
    {
        public static int NumIslands(char[][] grid)
        {
            int rowSize = grid.Length;
            int colSize = grid[0].Length;

            int[,] visited = new int[rowSize, colSize];
            Queue<(int rowIndex, int colIndex)> queue = new Queue<(int rowIndex, int colIndex)>();

            for(int i = 0; i < rowSize; i++)
            {
                for(int j = 0; i < colSize; j++)
                {
                    if (grid[i][j] == '1' && visited[i, j] != 0)
                    {
                        queue.Enqueue((i, j));
                        visited[i, j] = 1;
                    }
                }
            }
            return 0;
        }

        public static void BFS(char[][] grid, int rowIndex, int colIndex, int[ , ] visited)
        {
            Queue<(int rowIndex, int colIndex)> queue = new Queue<(int rowIndex, int colIndex)>();
            if (visited[rowIndex, colIndex] != 1)
            {
                queue.Enqueue((rowIndex, colIndex));
                visited[rowIndex, colIndex] = 1;

                while(queue.Count > 0 )
                {
                    var currentIndex = queue.Dequeue();
                    rowIndex = currentIndex.rowIndex;
                    colIndex = currentIndex.colIndex;

                    for(int delRow = -1; delRow <= 1; delRow++)
                    {
                        for(int delCol = -1; delCol <= 1; delCol++)
                        {
                            if (isValidIndex(grid.Length, grid[0].Length, rowIndex + delRow, colIndex + delCol) && visited[rowIndex, colIndex] != 1)
                            {
                                queue.Enqueue((rowIndex + delRow, colIndex + delCol));
                                visited[rowIndex + delRow, colIndex + delCol] = 1;
                            }
                        }
                    }
                }
            }
        }

        public static bool isValidIndex(int rowSize, int colSize, int rowIndex, int colIndex)
        {
            return rowIndex >= 0 && rowIndex < rowSize && colIndex >= 0 && colIndex < colSize;
        }
    }
}
