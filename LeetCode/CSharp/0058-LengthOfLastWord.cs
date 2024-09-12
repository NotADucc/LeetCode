using LeetCode.Shared;

namespace LeetCode.CSharp
{
    public class Solution0058 : IRunProgram
    {
        public void Run()
        {
            LengthOfLastWord("Hello World").Print();
            LengthOfLastWord("   fly me   to   the moon  ").Print();
        }

        public int LengthOfLastWord(string s)
        {
            s = s.Trim();
            string[] arr = s.Split(" ");
            return arr[^1].Length;
        }
    }
}
