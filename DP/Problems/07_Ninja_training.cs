using System.Net.Http.Headers;

namespace DP.Grids;

public class NinjaTrainingSolver
{
    /// <summary>
    /// https://www.codingninjas.com/codestudio/problems/ninja-s-training_3621003
    /// This is the memoization approach
    /// </summary>
    /// <param name="points"></param>
    /// <param name="n"></param>
    /// <param name="lastTask"></param>
    /// <param name="dp"></param>
    /// <returns></returns>
    public static int GetMaxPoints(int[][] points, int n, int lastTask, int[][] dp)
    {
        if(n == 0)
        {
            int maxPoints = 0;
            for(int task = 0; task < 3; task++)
            {
                if(task != lastTask)
                {
                    maxPoints = Math.Max(maxPoints, points[0][task]);
                }
            }

            return dp[0][lastTask] =  maxPoints;
        }

        if(dp[n][lastTask] != -1)
        {
            return dp[n][lastTask];
        }

        int finalMaxPoints = 0;
        for(int task = 0; task < 3; task++)
        {
            if(task != lastTask)
            {
                int point = points[n][task] + GetMaxPoints(points, n - 1, task, dp);
                finalMaxPoints = Math.Max(finalMaxPoints, point);
            }
        }
        return dp[n][lastTask] = finalMaxPoints;
    }


    public static int GetMaxPointsTabulation(int[][] points, int n)
    {
        int[][] dp = new int[n][];
        for(int i = 0; i < n; i++)
        {
            dp[i] = new int[4];
        }

        dp[0][0] = Math.Max(points[0][1], points[0][2]);
        dp[0][1] = Math.Max(points[0][0], points[0][2]);
        dp[0][2] = Math.Max(points[0][0], points[0][1]);
        dp[0][3] = Math.Max(points[0][0], Math.Max(points[0][1], points[0][2]));

        for(int day = 1; day < n; day++)
        {
            for(int last = 0; last < 4; last++)
            {
                dp[day][last] = 0;
                for(int task = 0; task < 3; task++)
                {
                    if(task != last)
                    {
                        int point = points[day][task] + dp[day - 1][last];
                        dp[day][last] = Math.Max(dp[day][last], point);
                    }
                }
            }
        }

        return dp[n - 1][3];
    }

    public static int GetMaxPointsTabulationSpaceOpt(int[][] points, int n)
    {
        int[] dp = new int[4];

        dp[0] = Math.Max(dp[1], dp[2]);
        dp[1] = Math.Max(dp[0], dp[2]);
        dp[2] = Math.Max(dp[0], dp[1]);
        dp[3] = Math.Max(dp[0], Math.Max(dp[1], dp[2]));

        for(int day = 1; day < n; day++)
        {
            for(int last = 0; last < 4; last++)
            {
                int[] temp = new int[4];
                for(int task = 0; task < 3; task++)
                {
                    int point = points[day][task] + dp[last];
                    temp[last] = Math.Max(point, temp[last]);
                }

                dp = temp;
            }
        }

        return dp[3];
    }


    /// <summary>
    /// This is the main function to solve the Ninja Training problem
    /// </summary>
    /// <param name="matrix"></param>
    /// <returns></returns>
    public static int NinjaTraining(int[][] matrix)
    {
        int[][] dp = new int[matrix.Length][];

        for(int i = 0; i < matrix.Length; i++)
        {
            dp[i] = new int[4];
            for(int j = 0; j < 4; j++)
            {
                dp[i][j] = -1;
            }
        }

        // return GetMaxPoints(matrix, matrix.Length - 1, 3, dp);

        return GetMaxPointsTabulation(matrix, matrix.Length);
    }
}