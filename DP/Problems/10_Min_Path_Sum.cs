namespace DP.Grids;

public class MinPathSum
{
    private static int getMinPathSum(int m, int n, int[][] grid, int[][] dp)
    {
        if (m == 0 && n == 0)
        {
            return grid[0][0];
        }

        if (m < 0 || n < 0)
        {
            return Int16.MaxValue;
        }

        if (dp[m][n] != -1)
        {
            return dp[m][n];
        }

        int up = Int16.MaxValue;
        int left = Int16.MaxValue;

        if (m > 0)
        {
            up = grid[m][n] + getMinPathSum(m - 1, n, grid, dp);
        }

        if (n > 0)
        {
            left = grid[m][n] + getMinPathSum(m, n - 1, grid, dp);
        }

        return dp[m][n] = Math.Min(up, left);
    }

    public static int CalcMinPathSum(int[][] grid)
    {
        int rowSize = grid.Length;
        int colSize = grid[0].Length;
        int[][] dp = new int[rowSize][];

        for (int i = 0; i < rowSize; i++)
        {
            dp[i] = new int[colSize];
            Array.Fill(dp[i], -1);
        }

        return getMinPathSum(grid.Length - 1, grid[0].Length - 1, grid, dp);
    }
}