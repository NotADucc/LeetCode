using LeetCode.Shared;

namespace LeetCode.CSharp
{
    internal class Solution0171 : IRunProgram
    {
        public void Run()
        {
            TitleToNumber("A").Print();
            TitleToNumber("AB").Print();
            TitleToNumber("ZZ").Print();
            TitleToNumber("ZZA").Print();
        }
        public int TitleToNumber(string columnTitle)
        {
            int output = 0;

            for (int i = columnTitle.Length - 1; i >= 0; i--)
            {
                output += (Math.Max(((int)Math.Pow(26, (columnTitle.Length - 1 - i))), 1)) * TransformChToInt(columnTitle[i]);
            }

            return output;
        }

        private int TransformChToInt(char ch) => ch - 64;
    }
}
