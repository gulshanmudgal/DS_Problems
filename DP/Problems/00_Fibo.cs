namespace DP.Solutions
{
    public class Fibo
    {
        public static int GetFibo(int n)
        {
            int[] dp = new int[n + 1];
            Array.Fill(dp, -1);

            return GetFiboOptimized(n);
            // return GetFibo(n, dp);
        }

        private static int GetFibo(int n, int[] dp)
        {
            if (n <= 1)
            {
                return n;
            }

            if (dp[n] != -1)
            {
                return dp[n];
            }

            return dp[n] = GetFibo(n - 1, dp) + GetFibo(n - 2, dp);
        }

        private static int GetFiboOptimized(int n)
        {
            int prev1 = 1;
            int prev2 = 0;

            int curr = prev1 + prev2;

            for (int i = 2; i <= n; i++)
            {
                curr = prev1 + prev2;
                prev2 = prev1;
                prev1 = curr;
            }

            return curr;
        }
    }
}

