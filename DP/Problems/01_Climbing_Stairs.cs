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
    }
}