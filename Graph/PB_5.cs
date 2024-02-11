using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    /// <summary>
    /// 542. 01 Matrix: https://leetcode.com/problems/01-matrix/
    /// </summary>
    internal class PB_5
    {
        public static int[][] UpdateMatrix(int[][] mat)
        {
            int rowSize = mat.Length;
            int colSize = mat[0].Length;

            int[][] visited = new int[rowSize][];
            int[][] distance = new int[rowSize][];
            Queue<((int rowIndex, int colIndex) position, int distance)> bfsQueue = new Queue<((int rowIndex, int colIndex), int distance)>();

            for(int i = 0; i < rowSize; i++)
            {
                visited[i] = new int[colSize];
                distance[i] = new int[colSize];
                for (int j = 0; j < colSize; j++)
                {
                    if (mat[i][j] == 0)
                    {
                        bfsQueue.Enqueue(((i, j), 0));
                        visited[i][j] = 1;
                    }
                    else
                    {
                        visited[i][j] = 0;
                    }
                }
            }

            int[] delRow = new int[4] { 0, -1, 0, 1 };
            int[] delCol = new int[4] { -1, 0, 1, 0 };

            while(bfsQueue.Count > 0)
            {
                var node = bfsQueue.Dequeue();
                int row = node.position.rowIndex;
                int col = node.position.colIndex;
                int steps = node.distance;

                distance[row][col] = steps;

                for(int i = 0; i < 4; i++)
                {
                    int nRow = row + delRow[i];
                    int nCol = col + delCol[i];

                    if(isValidIndex(rowSize, colSize, nRow, nCol) && visited[nRow][nCol] == 0)
                    {
                        visited[nRow][nCol] = 1;
                        bfsQueue.Enqueue(((nRow, nCol), steps + 1));
                    }
                }
            }

            return distance;
        }

        public static bool isValidIndex(int rowSize, int colSize, int rowIndex, int colIndex)
        {
            return rowIndex >= 0 && rowIndex < rowSize && colIndex >= 0 && colIndex < colSize;
        }
    }
}
