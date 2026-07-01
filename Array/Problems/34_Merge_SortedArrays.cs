namespace Array
{
    public class MergerSortedArrays
    {
        public static void Merge(IList<int> nums1, int m, IList<int> nums2, int n)
        {
            // m = nums1.Count;
            // n = nums2.Count;

            int left = m - 1;
            int right = 0;

            while(left >= 0 && right < n)
            {
                if(nums1[left] > nums2[right])
                {
                    swapArrayIndexes(nums1, left, nums2, right);
                    left--;
                    right++;
                }
                else
                {
                    break;
                }
            }

            SortIList(nums1);
            SortIList(nums2);
        }

        public static void SortIList(IList<int> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                int current = list[i];
                int j = i - 1;

                while (j >= 0 && list[j] > current)
                {
                    list[j + 1] = list[j];
                    j--;
                }

                list[j + 1] = current;
            }
        }

        public static void swapArrayIndexes(IList<int> nums1, int leftIndex, IList<int> nums2, int rightIndex)
        {
            int temp = nums1[leftIndex];
            nums1[leftIndex] = nums2[rightIndex];
            nums2[rightIndex] = temp;
        }
    }
}