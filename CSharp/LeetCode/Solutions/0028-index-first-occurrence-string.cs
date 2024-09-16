using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

public class Solution0028 : IRunProgram
{
    public void Run()
    {
        StrStr("sadbutsad", "sad").Print();
        StrStr("leetcode", "leeto").Print();
        StrStr("a", "a").Print();
    }

    public static int StrStrCheese(string haystack, string needle)
    {
        //cheese
        return haystack.IndexOf(needle);
    }

    public static int StrStr(string haystack, string needle)
    {
        for (int i = 0; i < haystack.Length; i++)
        {
            if (i + needle.Length > haystack.Length)
            {
                break;
            }

            for (int j = 0; j < needle.Length; j++)
            {
                if (haystack[i + j] != needle[j]) 
                {
                    break;
                }
                if (j == needle.Length - 1)
                {
                    return i;
                }
            }
        }

        return -1;
    }
}
