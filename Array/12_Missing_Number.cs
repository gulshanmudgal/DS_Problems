using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class MissingNumber
    {
        public static int GetMissingNumber(int[] input)
        {
            int count = input.Length;
            int flag = -1;
            bool found = false;

            for (int i = 0; i < count; i++)
            {
                found = false;
                for (int j = 0; j < count; j++)
                {
                    if (input[j] == i)
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    flag = i;
                    break;
                }
            }

            if (found)
            {
                flag = count;
            }

            return flag;
        }

        public static int GetMissingNumberBetter(int[] input)
        {
            int count = input.Length;
            long sum = (count * (count + 1)) / 2;
            long inputSum = GetArraySum(input);
            long missing = sum - inputSum;
            return missing == 0 ? count + 1 : (int)missing;
        }

        public static int GetMissingNumberOptimal(int[] input)
        {
            int xor1 = 0;
            int xor2 = 0;
            int n = input.Length;

            for(int i = 0; i < n; i++)
            {
                xor1 = input[i] ^ xor1;
                xor2 = (i+1) ^ xor2;
            }

            return xor1 ^ xor2;
        }

        private static long GetArraySum(int[] input)
        {
            long sum = 0;

            for(int i = 0; i < input.Length; i++)
            {
                sum = input[i] + sum;
            }

            return sum;
        }
    }
}