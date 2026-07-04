using System.Runtime.InteropServices.Marshalling;

namespace Sorting
{
    /// <summary>
    /// Merge Sort - A divide-and-conquer sorting algorithm.
    ///
    /// IDEA:
    ///   Recursively split the array into two halves until each subarray
    ///   contains a single element (which is trivially sorted), then merge
    ///   the sorted halves back together. The real work happens in the
    ///   merge step, which combines two already-sorted runs into one.
    ///
    /// KEY POINTS:
    ///   1. A single temp[] buffer is allocated once at the top level and
    ///      reused by every merge call - this avoids repeated allocations
    ///      on each recursive call.
    ///   2. The merge comparison uses &lt;= so that on a tie the element
    ///      from the LEFT half is taken first, keeping equal keys in their
    ///      original relative order (stability).
    ///   3. Mid is computed as left + (right - left) / 2 to avoid integer
    ///      overflow on very large indices.
    ///
    /// COMPLEXITY:
    ///   - Time : O(n log n) in all cases (best, average, worst)
    ///   - Space: O(n) for the temp buffer
    ///   - Stable: Yes (equal keys keep their relative order)
    /// </summary>
    public class MergeSort
    {
        public static void Sort(int[] arr)
        {
            if(arr == null || arr.Length <= 1)
            {
                return;
            }
            var count = arr.Length;
            // Allocate the shared temp buffer once and reuse it for all merges.
            Sort(arr, new int[count], 0, count - 1);
        }

        private static void Sort(int[] arr, int[] temp, int left, int right)
        {
            // Base case: a range of 0 or 1 elements is already sorted.
            if(left >= right)
            {
                return;
            }

            int mid = left + (right - left)/2;

            // Sort the left half  [left, mid]
            // Sort the right half [mid+1, right]
            Sort(arr, temp, left, mid);
            Sort(arr, temp, mid+1, right);

            // Combine the two sorted halves.
            Merge(arr, temp, left, mid, right);
        }

        private static void Merge(int[] arr, int[] temp, int left, int mid, int right)
        {
            int i = left;     // write position into temp[]
            int j = left;     // read cursor for left half  [left, mid]
            int k = mid + 1;  // read cursor for right half [mid+1, right]

            // Compare the front of each half and copy the smaller element to temp[].
            while(j <= mid && k <= right)
            {
                if(arr[j] <= arr[k])
                {
                    temp[i] = arr[j];
                    j++;
                    i++;
                }
                else
                {
                    temp[i] = arr[k];
                    i++;
                    k++;
                }
            }

            // Copy any leftover elements from the right half.
            while(k <= right)
            {
                temp[i] = arr[k];
                i++;
                k++;
            }

            // Copy any leftover elements from the left half.
            while(j <= mid)
            {
                temp[i] = arr[j];
                i++;
                j++;
            }

            // Copy the merged run back into the original array.
            for(int index = left; index <= right; index++)
            {
                arr[index] = temp[index];
            }
        }
    }
}