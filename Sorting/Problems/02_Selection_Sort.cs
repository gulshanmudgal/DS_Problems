namespace Sorting
{
    /// <summary>
    /// Selection Sort - Pick the minimum, place it at the front.
    ///
    /// IDEA:
    ///   Divide the array into a sorted prefix (left) and an unsorted
    ///   suffix (right). In each pass, scan the unsorted suffix to find
    ///   the minimum element, then swap it with the first element of the
    ///   suffix. This grows the sorted prefix by one element per pass.
    ///
    ///   Pass 1: find min in [0..n-1] -> put at index 0
    ///   Pass 2: find min in [1..n-1] -> put at index 1
    ///   ... and so on.
    ///
    /// NOTE:
    ///   Unlike Bubble Sort, Selection Sort does the minimum number of
    ///   swaps (at most n-1), which is useful when writes are expensive.
    ///   It does NOT benefit from early-exit-even sorted data takes O(n^2)
    ///   because we still scan the whole suffix each pass.
    ///
    /// COMPLEXITY:
    ///   - Time : O(n^2) in ALL cases (best, average, worst)
    ///   - Space: O(1)  - in-place
    ///   - Stable: No (swapping can cross over equal elements)
    /// </summary>
    public class SelectionSort
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                // Assume the first element of the suffix is the minimum.
                int minIndex = i;

                // Scan the rest of the suffix for a smaller element.
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Place the found minimum at its correct position.
                // Skip the swap if minIndex is already i (small optimisation).
                if (minIndex != i)
                {
                    Swap(arr, i, minIndex);
                }
            }
        }

        private static void Swap(int[] arr, int a, int b)
        {
            (arr[a], arr[b]) = (arr[b], arr[a]);
        }
    }
}
