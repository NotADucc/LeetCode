using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution2423 : IRunProgram
{
    public void Run()
    {
        EqualFrequency("abcc").Print();
    }
    public bool EqualFrequency(string word)
    {
        var span = word.AsSpan();
        Span<int> arr = stackalloc int[26];
        var set = new HashSet<int>();
        foreach (var ch in span)
        {
            int index = ch - 'a';
            set.Add(index);
            arr[index]++;
        }

        arr.Sort();
        arr = arr.Slice(arr.Length - set.Count);

        if (arr.Length == 1)
        {
            return true;
        }
        if (arr[^1] == 1 && arr[0] == 1)
        {
            return true;
        }
        if (arr.Length == 2)
        {
            return arr[^1] - arr[0] == 1 || arr[0] == 1;
        }

        int lowest_count = 1;

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[0] == arr[i])
            {
                lowest_count++;
            }
            else
            {
                break;
            }
        }

        if (lowest_count == 1)
        {
            return arr[0] == 1 && arr[^1] - arr[1] == 0;
        }

        return arr.Length - lowest_count == 1 && arr[^1] - arr[0] == 1;
    }
}
