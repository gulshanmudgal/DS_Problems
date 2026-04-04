namespace DP.Solutions
{
    public class Climb_Stairs
    {
        public static int ClimbStairs(int n)
        {
            int[] dp = new int[n + 1];

            Array.Fill(dp, -1);

            dp[0] = 1;
            dp[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }

            return dp[n];
        }

        public static int ClimbStairs_UnOptimized(int n)
        {
            if(n <= 1)
            {
                return 1;
            }

            return ClimbStairs_UnOptimized(n - 1) + ClimbStairs_UnOptimized(n - 2);
        }

        public static int ClimbStairs_Memoization(int n)
        {
            int[] dp = new int[n + 1];
            Array.Fill(dp, -1);
            return ClimbStairs_MemoizationSol(n, dp);
        }

        private static int ClimbStairs_MemoizationSol(int n, int[] dp)
        {
            if (n <= 1)
            {
                return 1;
            }

            if (dp[n] != -1)
            {
                return dp[n];
            }

            dp[n] = ClimbStairs_MemoizationSol(n - 1, dp) + ClimbStairs_MemoizationSol(n - 2, dp);
            return dp[n];
        }

        public static int Climb_StairsDP(int n)
        {
            int[] dp = new int[n + 1];
            Array.Fill(dp, -1);

            dp[0] = 1;
            dp[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }

            return dp[n];
        }

        public static int Climb_StairsMemOpt(int n)
        {
            int prev2 = 1;
            int prev = 1;

            for (int i = 2; i <= n; i++)
            {
                int curr = prev2 + prev;
                prev2 = prev;
                prev = curr;
            }

            return prev;
        }
    }
}