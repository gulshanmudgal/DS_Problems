using static System.Net.Mime.MediaTypeNames;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Reverse Array
            int[] reverseArrayInput = { 1, 2, 3, 4, 5, 6, 7 };
            Reverse_Array.ReverseArray(reverseArrayInput);
            Console.WriteLine("********************************** Printing output for reversing an array **********************************");
            PrintArray(reverseArrayInput);
            Console.WriteLine();
            #endregion

            #region Left Rotate an Array by one
            int[] rotateByOneInput = { 1, 2, 3, 4, 5, 6, 7 };
            LeftRotateByOne.Rotate(rotateByOneInput);
            Console.WriteLine("********************************** Printing output for Left Rotate an array by one **********************************");
            PrintArray(rotateByOneInput);
            Console.WriteLine();
            #endregion

            #region Left Rotate an Array by K
            int[] leftRotateByKInput = { 1, 2, 3, 4, 5, 6, 7 };
            LeftRotateByK.Rotate(leftRotateByKInput, 3);
            Console.WriteLine("********************************** Printing output for Left Rotate an array by K **********************************");
            PrintArray(leftRotateByKInput);
            Console.WriteLine();
            #endregion

            #region Right Rotate an Array by K
            int[] rightRotateByKInput = { 1, 2, 3, 4, 5, 6, 7 };
            RightRotateByK.Rotate(rightRotateByKInput, 3);
            Console.WriteLine("********************************** Printing output for Right Rotate an array by K **********************************");
            PrintArray(rightRotateByKInput);
            Console.WriteLine();
            #endregion

            #region Move Zeroes
            int[] moveZeroesInput = [0, 1, 0, 3, 12];
            Console.WriteLine("********************************** Printing output for Move Zeroes of an array **********************************");
            MoveZeroes.MoveZeroesToEnd(moveZeroesInput);
            PrintArray(moveZeroesInput);
            Console.WriteLine();
            #endregion

            #region Union of Sorted Arrays
            int[] input1 = { 1, 5, 6, 6, 7, 8, 8, 8, 9, 10 };
            int[] input2 = { 2, 5, 5, 8, 9, 11, 11, 15 };

            var answer = UnionOfSortedArray.Solve(input1, input2);
            Console.WriteLine("********************************** Printing Union of two sorted arrays **********************************");
            PrintArray(answer);
            Console.WriteLine();
            #endregion

            #region Intersection of two Sorted Array
            int[] nums1 = [1, 2, 2, 1];
            int[] nums2 = [2, 2];
            int[] solution = IntersectionOfSortedArray.Intersection(nums1, nums2);
            Console.WriteLine("********************************** Printing Intersection of two sorted arrays **********************************");
            PrintArray(solution);
            #endregion

            #region Missing Number
            int[] missingNumberInput = new int[] { 3, 0, 1 };
            int result = MissingNumber.GetMissingNumber(missingNumberInput);
            Console.WriteLine("********************************** Printing missing number in an array **********************************");
            Console.WriteLine(result);
            Console.WriteLine(MissingNumber.GetMissingNumberBetter(missingNumberInput));
            Console.WriteLine(MissingNumber.GetMissingNumberOptimal(missingNumberInput));
            Console.WriteLine();
            #endregion

            #region
            #endregion

            #region Two Sum
            int[] nums = [2, 7, 11, 15];
            int target = 9;

            var twoSumResult = TwoSum.TwoSumBetter(nums, target);
            PrintArray(twoSumResult);
            Console.WriteLine();
            #endregion

            #region Next Permutation
            Console.WriteLine("********************************** Printing Next Permutation **********************************");
            int[] nextPerutationInput = [5, 2, 4, 3, 1];
            NextPermutation.GetNextPermutation(nextPerutationInput);
            PrintArray(nextPerutationInput);
            Console.WriteLine();
            #endregion

            #region Longest Xonsecutive Sequence
            Console.WriteLine("**********************************Printing Longest Consecutive Length **********************************");
            // int[] longestSubsequenceInput = [0, 3, 7, 2, 5, 8, 4, 6, 0, 1];
            int[] longestSubsequenceInput = [2, 6, 1, 9, 4, 5, 3];
            int lcslength = LongestConsecutiveSequence.LongestConsecutive(longestSubsequenceInput);
            Console.WriteLine($"Length of longest consecutive sequence {lcslength}");
            Console.WriteLine();
            #endregion

            #region Rotate matrix by 90
            Console.WriteLine("**********************************Printing 90 degree Rotated Matrix **********************************");
            int[][] rotateMatrixInput = [[1, 2, 3],[4, 5, 6],[7, 8, 9]];
            RotateMatrixBy90.Rotate(rotateMatrixInput);
            PrintMatrix(rotateMatrixInput);
            Console.WriteLine();
            #endregion

            #region Spiral Traversal of Matrix
            Console.WriteLine("**********************************Printing Spiral Traversal of Matrix **********************************");
            // int[][] spiralTraversalMatrixInput = [[1, 2, 3, 4], [5, 6, 7, 8], [9, 10, 11, 12], [13, 14, 15, 16], [17, 18, 19, 20]];
            int[][] spiralTraversalMatrixInput = [[1, 2, 3, 4], [5, 6, 7, 8], [9, 10, 11, 12]];
            IList<int> spiralOrder = MatrixSpiralTraversal.SpiralOrder(spiralTraversalMatrixInput);
            PrintList(spiralOrder);
            Console.WriteLine();
            #endregion

            #region Pascal Triangle
            Console.WriteLine("**********************************Printing Pascal Triangle Variations **********************************");
            IList<int> pascalRow = PascalTriangle.GenerateRow(1);
            PrintList(pascalRow); 
            Console.WriteLine();
            pascalRow = PascalTriangle.GenerateRow(2);
            PrintList(pascalRow);
            Console.WriteLine();
            pascalRow = PascalTriangle.GenerateRow(3);
            PrintList(pascalRow);
            Console.WriteLine();
            pascalRow = PascalTriangle.GenerateRow(4);
            PrintList(pascalRow);
            Console.WriteLine();
            pascalRow = PascalTriangle.GenerateRow(5);
            PrintList(pascalRow);
            Console.WriteLine();
            pascalRow = PascalTriangle.GenerateRow(6);
            PrintList(pascalRow);
            Console.WriteLine();

            IList<IList<int>> pascalTriangle = PascalTriangle.Generate(6);
            PrintNestedList(pascalTriangle);
            Console.WriteLine();
            #endregion

            #region Three Sum
            int[] threeSumInput = [1, -1, -1, 0];
            var threeSumResult = ThreeSum.GetThreeSum(threeSumInput);
            PrintNestedList(threeSumResult);
            Console.WriteLine();
            #endregion

            #region Four Sum
            // int[] fourSumInput = [-1, 0, -5, -2, -2, -4, 0, 1, -2];
            int[] fourSumInput = [1000000000, 1000000000, 1000000000, 1000000000];
            var fourSumResult = FourSum.GetFourSum(fourSumInput, -294967296);
            PrintNestedList(fourSumResult);
            Console.WriteLine();
            #endregion
        }

        private static void PrintArray(int[] nums)
        {
            foreach (int i in nums)
            {
                Console.Write(i + "\t"); 
            }

            Console.WriteLine();
        }

        private static void PrintMatrix(int[][] matrix)
        {
            int n = matrix.Length;
            int m = matrix[0].Length;

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i][j] + "\t");
                }

                Console.WriteLine();
            }
        }

        private static void PrintList(IList<int> list)
        {
            foreach (var item in list)
            {
                Console.Write(item + "\t");
            }
        }

        private static void PrintNestedList(IList<IList<int>> nestedList)
        {
            foreach (var list in nestedList)
            {
                foreach (var item in list)
                {
                    Console.Write(item + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
