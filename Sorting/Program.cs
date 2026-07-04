namespace Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Bubble Sort
            int[] bubbleInput = { 64, 25, 12, 22, 11 };
            Console.WriteLine("********************************** Printing output for Bubble Sort **********************************");
            Console.Write("Before: ");
            PrintArray(bubbleInput);
            Console.Write("After : ");
            PrintArray(bubbleInput);
            Console.WriteLine();
            #endregion

            #region Selection Sort
            int[] selectionInput = { 29, 10, 14, 37, 13, 10 };
            Console.WriteLine("********************************** Printing output for Selection Sort **********************************");
            Console.Write("Before: ");
            PrintArray(selectionInput);
            SelectionSort.Sort(selectionInput);
            Console.Write("After : ");
            PrintArray(selectionInput);
            Console.WriteLine();
            #endregion

            #region Insertion Sort
            int[] insertionInput = { 12, 11, 13, 5, 6 };
            Console.WriteLine("********************************** Printing output for Insertion Sort **********************************");
            Console.Write("Before: ");
            PrintArray(insertionInput);
            InsertionSort.Sort(insertionInput);
            Console.Write("After : ");
            PrintArray(insertionInput);
            Console.WriteLine();
            #endregion

            #region Already-sorted edge case (early exit demonstration)
            int[] sortedInput = { 1, 2, 3, 4, 5 };
            Console.WriteLine("********************************** Early-exit on already-sorted data **********************************");
            Console.Write("Before: ");
            PrintArray(sortedInput);
            BubbleSort.Sort(sortedInput);   // Should finish in a single pass (O(n) best case)
            Console.Write("After : ");
            PrintArray(sortedInput);
            Console.WriteLine();
            #endregion

            #region Merge Sort
            Console.WriteLine("********************************** Printing output for Merge Sort **********************************");
            int[][] mergeCases = {
                new[]{3,1,2},
                new[]{5,4,3,2,1},
                new[]{1,2,3,4,5},
                new[]{4,2,4,1,2},
                new[]{9,3,9,3,9},
                new[]{42},
                new[]{7,7,7,7},
            };
            foreach (var input in mergeCases)
            {
                var copy = (int[])input.Clone();
                MergeSort.Sort(copy);
                bool sorted = IsSorted(copy);
                Console.WriteLine($"{Br(input)} -> {Br(copy)}  sorted={sorted}");
            }
            Console.WriteLine();
            #endregion
        }

        static void PrintArray(int[] arr)
        {
            Console.WriteLine(string.Join(", ", arr));
        }

        static string Br(int[] arr) => "[" + string.Join(",", arr) + "]";

        static bool IsSorted(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
                if (arr[i - 1] > arr[i]) return false;
            return true;
        }
    }
}
