namespace DP.Grids;

/// <summary>
/// https://leetcode.com/problems/unique-paths/description/
/// </summary>
public class UniquePaths
{
    private static int GetUniquePathsRec(int m, int n)
    {
        if (m == 0 && n == 0)
        {
            return 1;
        }

        if (m < 0 || n < 0)
        {
            return 0;
        }

        var up = GetUniquePathsRec(m - 1, n);
        var left = GetUniquePathsRec(m, n - 1);

        return up + left;
    }

    public static int GetAllUniquePathsRec(int m, int n)
    {
        return GetUniquePathsRec(m - 1, n - 1);
    }

    private static int GetUniquePathsMemo(int m, int n, int[,] memo)
    {
        if (m == 0 && n == 0)
        {
            return 1;
        }

        if (m < 0 || n < 0)
        {
            return 0;
        }

        if (memo[m, n] != -1)
        {
            return memo[m, n];
        }

        var up = GetUniquePathsMemo(m - 1, n, memo);
        var left = GetUniquePathsMemo(m, n - 1, memo);

        return memo[m, n] = up + left;
    }

    public static int GetAllUniquePathsMemo(int m, int n)
    {
        int[,] memo = new int[m, n];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                memo[i, j] = -1;
            }
        }

        return GetUniquePathsMemo(m - 1, n - 1, memo);
    }

    public static int GetAllUniquePathsTab(int m, int n)
    {
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
                if (i == 0 && j == 0)
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

    public static int GetAllUniquePathsOptimal(int m, int n)
    {
        int[] prev = new int[n];

        for (int i = 0; i < m; i++)
        {
            int[] curr = new int[n];

            for (int j = 0; j < n; j++)
            {
                if (i == 0 && j == 0)
                {
                    curr[j] = 1;
                }
                else
                {
                    int up = 0, left = 0;
                    if (i > 0)
                    {
                        up = prev[j];
                    }

                    if (j > 0)
                    {
                        left = curr[j - 1];
                    }

                    curr[j] = up + left;
                }
            }

            prev = curr;
        }
        return prev[n - 1];
    }
}