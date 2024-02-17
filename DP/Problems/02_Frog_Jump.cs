namespace DP.Solutions
{
    public class Frog_Jump
    {
        public static int FrogJump(int n, int[] heights)
        {
            // Write your code here..
            // return Solution(n - 1, heights);

            // return OptimalSolution(n, heights);

            return SpaceOptimalSolution(n, heights);
        }

        private static int Solution(int index, int[] heights)
        {
            if (index == 0)
            {
                return 0;
            }

            int left = Solution(index - 1, heights) + Math.Abs(heights[index] - heights[index - 1]);
            int right = Int16.MaxValue;

            if (index > 1)
            {
                right = Solution(index - 2, heights) + Math.Abs(heights[index] - heights[index - 2]);
            }

            return Math.Min(left, right);
        }

        private static int OptimalSolution(int n, int[] heights)
        {
            int[] dp = new int[n + 1];
            Array.Fill(dp, -1);

            dp[0] = 0;

            for (int i = 1; i < n; i++)
            {
                int left = dp[i - 1] + Math.Abs(heights[i] - heights[i - 1]);

                int right = Int16.MaxValue;

                if (i > 1)
                {
                    right = dp[i - 2] + Math.Abs(heights[i] - heights[i - 2]);
                }

                dp[i] = Math.Min(left, right);
            }

            return dp[n - 1];
        }

        private static int SpaceOptimalSolution(int n, int[] heights)
        {
            int prev = 0;
            int prev2 = 0;

            for (int i = 1; i < n; i++)
            {
                int left = prev + Math.Abs(heights[i] - heights[i - 1]);
                int right = Int16.MaxValue;

                if (i > 1)
                {
                    right = prev2 + Math.Abs(heights[i] - heights[i - 2]);
                }

                int curr = Math.Min(left, right);
                prev2 = prev;
                prev = curr;
            }

            return prev;
        }
    }
}
