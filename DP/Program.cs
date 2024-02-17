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
            var stairsResult = Climb_Stairs.ClimbStairs(5);
            Console.WriteLine(stairsResult);
            Console.WriteLine();
            #endregion

            #region Frog Jump
            Console.WriteLine("************************************** Frog Jump **************************************");
            int[] heights = new int[] { 10, 20, 30, 10 };
            var minCost = Frog_Jump.FrogJump(4, heights);
            Console.WriteLine("Min Cost " + minCost);
            Console.WriteLine();
            #endregion
        }
    }
}
