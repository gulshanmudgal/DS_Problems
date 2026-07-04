namespace Sorting
{
    /// <summary>
    /// Insertion Sort - Build the sorted array one element at a time.
    ///
    /// IDEA:
    ///   Think of how you sort playing cards in your hand: you pick up the
    ///   next card and slide it leftwards into its correct spot among the
    ///   already-sorted cards.
    ///
    ///   The left portion [0..i-1] is always sorted. Take arr[i], and shift
    ///   every element in [0..i-1] that is greater than it one position to
    ///   the right, then drop arr[i] into the opened gap.
    ///
    /// NOTE:
    ///   Insertion Sort shines on nearly-sorted data - it does very little
    ///   work because the inner while-loop barely runs. This is why it's
    ///   often used as the base case inside hybrid algorithms (TimSort,
    ///   IntroSort) for small subarrays.
    ///
    /// COMPLEXITY:
    ///   - Time : Worst/Average O(n^2), Best O(n) [already sorted]
    ///   - Space: O(1)  - in-place
    ///   - Stable: Yes
    /// </summary>
    public class InsertionSort
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;

            // Start from index 1: a single-element array is already sorted.
            for (int i = 1; i < n; i++)
            {
                int current = arr[i];
                int j = i - 1;

                // Shift elements of the sorted prefix that are greater
                // than 'current' one position to the right.
                while (j >= 0 && arr[j] > current)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                // Drop 'current' into the gap we just opened.
                arr[j + 1] = current;
            }
        }
    }
}
