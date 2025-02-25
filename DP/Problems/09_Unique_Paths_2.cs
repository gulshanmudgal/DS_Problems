using System.Net.Http.Headers;

namespace DP.Grids;

/// <summary>
/// https://leetcode.com/problems/unique-paths-ii/description/
/// </summary>
public class UniquePaths2
{
    public static int UniquePathsWithObstacles(int[][] obstacleGrid)
    {
        int m = obstacleGrid.Length;
        int n = obstacleGrid[0].Length;

        int[,] dp = new int[m, n];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                dp[i, j] = -1;
            }
        }

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (obstacleGrid[i][j] == 1 || dp[i, j] == 0)
                {
                    dp[i, j] = 0;
                }
                else if (i == 0 && j == 0)
                {
                    dp[i, j] = 1;
                }
                else
                {
                    int up = 0, left = 0;
                    if (i > 0)
                    {
                        up = dp[i - 1, j];
                    }

                    if (j > 0)
                    {
                        left = dp[i, j - 1];
                    }

                    dp[i, j] = up + left;
                }
            }
        }

        return dp[m - 1, n - 1];
    }
}