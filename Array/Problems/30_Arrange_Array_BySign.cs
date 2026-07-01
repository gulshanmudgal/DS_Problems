namespace Array
{
    public class ArrangeArrayBySign
    {
        public static int[] ArrangeArrayBySignSol(int[] nums)
        {
            List<int> positives = new List<int>();
            List<int> negatives = new List<int>();

            foreach(var num in nums)
            {
                if(num > 0)
                {
                    positives.Add(num);
                }
                else
                {
                    negatives.Add(num);
                }
            }


            int[] arrangedNums = new int[nums.Length];
            int i = 0;

            if(positives.Count > negatives.Count)
            {
                for(i = 0; i < negatives.Count; i++)
                {
                    arrangedNums[2*i] = positives[i];
                    arrangedNums[2*i + 1] = negatives[i];
                }

                for(int j = 2*i; j < nums.Length; j++)
                {
                    arrangedNums[j] = positives[i];
                    i++;
                }
            }
            else
            {
                for(i = 0; i < positives.Count; i++)
                {
                    arrangedNums[2*i] = positives[i];
                    arrangedNums[2*i + 1] = negatives[i];
                }

                for(int j = 2*i; j < nums.Length; j++)
                {
                    arrangedNums[j] = negatives[i];
                    i++;
                }
            }

            return arrangedNums;
        }
    }
}