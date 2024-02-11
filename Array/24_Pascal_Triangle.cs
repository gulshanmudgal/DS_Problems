using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class PascalTriangle
    {
        public static IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> pascalTriangle = new List<IList<int>>();

            for(int i = 1; i <= numRows; i++)
            {
                IList<int> pascalRow = new List<int>();

                pascalRow = GenerateRow(i);
                pascalTriangle.Add(pascalRow);
            }

            return pascalTriangle;
        }

        public static int GeneratepascalColumn(int row, int col)
        {
            int ans = 1;

            return ans;
        }

        public static IList<int> GenerateRow(int rowNumber)
        {
            IList<int> pascalRow = new List<int>();

            int ans = 1;

            pascalRow.Add(ans);

            for(int i = 1; i < rowNumber; i++)
            {
                ans = (ans * (rowNumber - i)) / i;

                pascalRow.Add(ans);
            }

            return pascalRow;
        }
    }
}
