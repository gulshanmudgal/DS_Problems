using DP.Grids;
using DP.Solutions;

namespace DP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region FIBO
            Console.WriteLine("************************************** Fibonacci Series **************************************");
            var fiboResult = Fibo.GetFibo(6);
            Console.WriteLine(fiboResult);
            Console.WriteLine();
            #endregion

            #region Climbing Stairs
            Console.WriteLine("************************************** Climbing Stairs **************************************");
            // var stairsResult = Climb_Stairs.ClimbStairs(5);
            // var stairsResultUnoptimized = Climb_Stairs.ClimbStairs_UnOptimized(5);
            // var stairsResultMemoized = Climb_Stairs.ClimbStairs_Memoization(5);
            // Console.WriteLine(stairsResult);
            // Console.WriteLine(stairsResultUnoptimized);
            // Console.WriteLine(stairsResultMemoized);
            // Console.WriteLine(Climb_Stairs.Climb_StairsDP(5));
            Console.WriteLine(Climb_Stairs.Climb_StairsMemOpt(5));
            Console.WriteLine();
            #endregion

            #region Frog Jump
            Console.WriteLine("************************************** Frog Jump **************************************");
            int[] heights = new int[] { 2, 1, 3, 5, 4 };
            var minCost = Frog_Jump.FrogJump(5, heights);
            Console.WriteLine("Min Cost " + minCost);
            Console.WriteLine();
            #endregion

            #region Ninja Training
            Console.WriteLine("************************************** Ninja Training **************************************");
            int[][] points = new int[][]
            {
                new int[] {10, 50, 40},
                new int[] {20, 60, 70},
                new int[] {30, 90, 80}
            };
            var maxPoints = NinjaTrainingSolver.NinjaTraining(points);
            Console.WriteLine("Max Points " + maxPoints);
            Console.WriteLine();
            #endregion

            #region Max Sum of Non Conseutive Integers
            Console.WriteLine("************************************** Max Sum of Non Consecutive Integers **************************************");
            int[] nonConsIntsInput = new int[] { 10, 20, 30, 90, 40 };
            var nonConsIntsOutput = NonConsecutiveMaxSum.MaximumNonAdjacentSum(nonConsIntsInput);
            Console.WriteLine(nonConsIntsOutput);
            Console.WriteLine();
            #endregion

            #region Unique Paths
            Console.WriteLine("************************************** Unique Paths **************************************");
            var uniquePaths = UniquePaths.GetAllUniquePathsRec(3, 3);
            Console.WriteLine(uniquePaths);
            Console.WriteLine();

            var uniquePathsMemo = UniquePaths.GetAllUniquePathsMemo(3, 7);
            Console.WriteLine(uniquePathsMemo);
            Console.WriteLine();

            var uniquePathsTab = UniquePaths.GetAllUniquePathsTab(3, 7);
            Console.WriteLine(uniquePathsTab);
            Console.WriteLine();

            var uniquePathsTabOptimized = UniquePaths.GetAllUniquePathsOptimal(3, 7);
            Console.WriteLine(uniquePathsTabOptimized);
            Console.WriteLine();
            #endregion

            #region Min Path Sum
            Console.WriteLine("************************************** Min Path Sum **************************************");
            int[][] grid = new int[][]
            {
                new int[] {1, 3, 1},
                new int[] {1, 5, 1},
                new int[] {4, 2, 1}
            };

            int[][] grid2 = new int[][]
            {
                new int[] {1, 2, 3},
                new int[] {4, 5, 6}
            };
            var minPathSum = MinPathSum.CalcMinPathSum(grid2);
            Console.WriteLine(minPathSum);
            Console.WriteLine();
            #endregion
        }
    }
}
