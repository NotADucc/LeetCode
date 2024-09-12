using LeetCode.Shared;

namespace LeetCode.CSharp
{
    internal class Solution0017 : IRunProgram
    {
        public void Run()
        {
            LetterCombinations("23").Print();  
            LetterCombinations("").Print();  
            LetterCombinations("2").Print();  
        }

        private string[] _digits = ["abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"];
        public IList<string> LetterCombinations(string digits)
        {
            if (digits.Length == 0) { return []; }
            List<string> output = new List<string>();
            Helper(output, string.Empty, digits, 0);
            return output;
        }
        private void Helper(List<string> input, string temp, string digits, int index)
        {
            if (index >= digits.Length)
            {
                input.Add(temp);
            }
            else
            {
                int i = digits[index] - '2';
                foreach (var item in _digits[i])
                {
                    Helper(input, $"{temp}{item}", digits, index + 1);
                }
            }
        }
    }
}
