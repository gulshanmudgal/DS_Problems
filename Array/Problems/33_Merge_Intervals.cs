namespace Array
{
    public class MergeIntervals
    {
        public static int[][] Merge(int[][] intervals) {

            SortIntervals(intervals);
            List<List<int>> solution = new List<List<int>>();

            int start = intervals[0][0];
            int end = intervals[0][1];
            solution.Add(new List<int> { start, end });
            for(int i = 1; i < intervals.Length; i++)
            {
                if(intervals[i][0] <= end)
                {
                    end = Math.Max(end, intervals[i][1]);
                    solution[solution.Count - 1][1] = end;
                }
                else
                {
                    start = intervals[i][0];
                    end = intervals[i][1];
                    solution.Add(new List<int> {start, end});
                }
            }

            int[][] arraySol = new int[solution.Count][];
            for (int i = 0; i < solution.Count; i++)
            {
                arraySol[i] = solution[i].ToArray();
            }

            return arraySol;
        }

        private static void SortIntervals(int[][] intervals)
        {
            if (intervals == null || intervals.Length <= 1)
            {
                return;
            }

            System.Array.Sort(intervals, (a, b) =>
            {
                int firstCompare = a[0].CompareTo(b[0]);
                if (firstCompare != 0)
                {
                    return firstCompare;
                }

                return a[1].CompareTo(b[1]);
            });
        }
    }
}