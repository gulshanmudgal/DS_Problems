using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class RotateMatrixBy90
    {
        public static void Rotate(int[][] matrix)
        {
            MatrixTranspose(matrix);
            ReverseMatrixRows(matrix);
        }

        private static void MatrixTranspose(int[][] matrix)
        {
            int n = matrix.Length;
            int m = matrix[0].Length;

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }
        }

        private static void ReverseMatrixRows(int[][] matrix)
        {
            int n = matrix.Length;

            for(int i = 0; i < n; i++)
            {
                System.Array.Reverse(matrix[i]);
            }
        }
    }
}
