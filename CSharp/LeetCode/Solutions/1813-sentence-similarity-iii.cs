using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution1813 : IRunProgram
{
    public void Run()
    {
        
    }
    public bool AreSentencesSimilar(string sentence1, string sentence2)
    {
        var split1 = sentence1.Split(" ");
        var split2 = sentence2.Split(" ");

        int count = Math.Min(split1.Length, split2.Length);
        int len = count;

        int l = 0, r = 1;
        while (l < len && split1[l] == split2[l])
        {
            l++;
            count--;
        }

        while (r <= len - l && split1[^r] == split2[^r])
        {
            r++;
            count--;
        }

        return count == 0;
    }
}
