namespace Sorting
{
    /// <summary>
    /// Bubble Sort - The simplest sorting algorithm.
    ///
    /// IDEA:
    ///   Repeatedly step through the list, compare adjacent elements and
    ///   swap them if they are in the wrong order. After each full pass the
    ///   largest unsorted element "bubbles up" to its correct position at
    ///   the end, just like bubbles rising to the surface of water.
    ///
    /// KEY OPTIMISATIONS:
    ///   1. After pass i, the last i elements are already in place, so the
    ///      inner loop can shrink by i each time.
    ///   2. If a full pass makes NO swaps, the array is already sorted and
    ///      we can stop early. This gives Bubble Sort an O(n) best case on
    ///      already-sorted data.
    ///
    /// COMPLEXITY:
    ///   - Time : Worst/Average O(n^2), Best O(n) [already sorted]
    ///   - Space: O(1)  - in-place
    ///   - Stable: Yes  (equal keys keep their relative order)
    /// </summary>
    public class BubbleSort
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;

            // Outer loop: we need at most n-1 passes.
            for (int i = 0; i < n - 1; i++)
            {
                bool swapped = false;

                // Inner loop: compare adjacent elements.
                // The last i elements are already sorted, skip them.
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(arr, j, j + 1);
                        swapped = true;
                    }
                }

                // Early exit - if nothing swapped this pass, we're done.
                if (!swapped) break;
            }
        }

        private static void Swap(int[] arr, int a, int b)
        {
            (arr[a], arr[b]) = (arr[b], arr[a]);
        }
    }
}
