using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    /// <summary>
    /// 130. Surrounded Regions: https://leetcode.com/problems/surrounded-regions/
    /// </summary>
    internal class PB_6
    {
        static char ZERO = 'O';

        public static void Solve(char[][] board)
        {
            int rowSize = board.Length;
            int colSize = board[0].Length;

            int[][] visited = new int[rowSize][];
            for(int i = 0; i < rowSize; i++)
            {
                visited[i] = new int[colSize];
            }

            for(int i = 0; i < rowSize; i++)
            {
                for(int j = 0; j < colSize; j++)
                {
                    if((i == 0 || i == rowSize - 1) && (j == 0 || j == colSize -1) && board[i][j] == ZERO)
                    {

                    }
                }
            }
        }
    }
}
