using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0884 : IRunProgram
{
    public void Run()
    {
        UncommonFromSentences("this apple is sweet", "this apple is sour").Print();
    }

    public string[] UncommonFromSentences(ReadOnlySpan<char> s1, ReadOnlySpan<char> s2)
    {
        // key is word
        // value is freq
        var output = new Dictionary<string, int>();

        for (int i = 0; i < s1.Length; i++)
        {
            var len = s1.Slice(i).IndexOf(' ');
            len = len == -1 ? s1.Length - i : len;
            var s1_slice = s1.Slice(i, len).ToString();
            if (!output.TryAdd(s1_slice, 1)) output[s1_slice]++;
            i += len;
        }

        for (int i = 0; i < s2.Length; i++)
        {
            var len = s2.Slice(i).IndexOf(' ');
            len = len == -1 ? s2.Length - i : len;
            var s2_slice = s2.Slice(i, len).ToString();
            if (!output.TryAdd(s2_slice, 1)) output[s2_slice]++;
            i += len;
        }

        List<string> result = new List<string>();
        foreach (var kvp in output) if (kvp.Value == 1) result.Add(kvp.Key);

        return result.ToArray();
    }
}
