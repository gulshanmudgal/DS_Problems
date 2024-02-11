using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class MatrixSpiralTraversal
    {
        public static IList<int> SpiralOrder(int[][] matrix)
        {
            IList<int> traversal = new List<int>();

            int top = 0;
            int left = 0;
            int right = matrix[0].Length - 1;
            int bottom = matrix.Length - 1;

            while (top <= bottom & left <= right)
            {
                for(int i = left; i <= right; i++)
                {
                    traversal.Add(matrix[top][i]);
                }
                top++;

                for(int j = top; j <= bottom; j++)
                {
                    traversal.Add(matrix[j][right]);
                }
                right--;
                 
                for(int i = right; i >= left && top <= bottom; i--)
                {
                    traversal.Add(matrix[bottom][i]);
                }
                bottom--;

                for(int j = bottom; j >= top && left <= right; j--)
                {
                    traversal.Add(matrix[j][left]);
                }
                left++;
            }

            return traversal;
        }
    }
}
