using LeetCode.Shared;

namespace LeetCode.CSharp
{
    internal class Solution0014 : IRunProgram
    {
        public void Run()
        {
            LongestCommonPrefix(["flower", "flow", "flight"]).Print();
            LongestCommonPrefix(["dog", "racecar", "car"]).Print();
        }

        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 1)
            {
                return strs[0];
            }
            var n = strs.Min().Length;
            if (n == 0)
            {
                return "";
            }
            var nn = 1;
            while (nn <= n)
            {
                var test = strs.Any(x => !x[..nn].Equals(strs.Min()[..nn]));
                if (test)
                {
                    nn--;
                    return strs.Min()[..nn];
                }
                nn++;
            }
            nn--;
            return strs.Min()[..nn];
        }
    }
}
