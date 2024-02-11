using System;
using System.Collections.Generic;

namespace HydroelectricProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = 4, m = 4;
            //string[] flow = new string[] { "..##", ".#.#", "#...", "##.." };
            //int[,] cost = new int[,] { { 4, 6, 5, 3 }, { 5, 2, 5, 1 }, { 5, 5, 3, 9 }, { 9, 5, 5, 4 } };

            int n = 5, m = 5;
            string[] flow = new string[] { "...##", ".#.##",".....", "##.#.", "##..." };
            int[,] cost = new int[,] { { 8, 1, 1, 1, 1 }, {1,1,1,1,1 }, { 1,1,5,1,1 }, { 1,1,1,1,1 }, { 1,1,1,1,9} };

            Console.WriteLine(BuildDam(n, m, flow, cost));
        }

        static int BuildDam(int N, int M, string[] flow, int[,] cost)
        {
            int[,] dp = new int[N, M];

            for (int i = N - 1; i >= 0; i--)
            {
                for (int j = M - 1; j >= 0; j--)
                {
                    if (flow[i][j] == '#')
                    {
                        dp[i, j] = int.MaxValue;
                    }
                    else
                    {
                        int val = int.MaxValue;

                        if (i + 1 < N)
                        {
                            val = Math.Min(val, dp[i + 1, j]);
                        }

                        if (j + 1 < M)
                        {
                            val = Math.Min(val, dp[i, j + 1]);
                        }

                        dp[i, j] = val == int.MaxValue ? cost[i, j] : val + cost[i, j];
                    }
                }
            }

            return dp[0, 0];
        }
    }
}
