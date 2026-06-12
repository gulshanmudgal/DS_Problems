public class PalindromePartitioningSolution
{
    public static IList<IList<string>> Partition(string s)
    {
        IList<IList<string>> result = new List<IList<string>>();
        Solve(s, result, new List<string>(), 0);
        return result;
    }

    public static bool Solve(string s, IList<IList<string>> result, List<string> subResult, int startIndex)
    {
        if (startIndex == s.Length - 1)
        {
            result.Add(new List<string>(subResult));
            return true;
        }

        for(int i = startIndex; i < s.Length; i++)
        {
            if(CanPartition(s, startIndex, startIndex + i))
            {
                subResult.Add(s.Substring(startIndex, startIndex + i + 1));
                Solve(s, result, subResult, startIndex + 1);
                subResult.RemoveAt(subResult.Count - 1);
            }
        }

        return false;
    }

    private static bool CanPartition(string s, int startIndex, int endIndex)
    {
        return IsPalindrome(s.Substring(0, startIndex + endIndex + 1));
    }

    public static bool IsPalindrome(string s)
    {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            if (s[left] != s[right])
                return false;

            left++;
            right--;
        }

        return true;
    }

}