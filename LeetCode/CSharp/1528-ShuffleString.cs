using LeetCode.Shared;

namespace LeetCode.CSharp
{
    internal class Solution1528 : IRunProgram
    {
        public void Run()
        {
            RestoreString("codeleet", [4, 5, 6, 7, 0, 2, 1, 3]).Print();
        }
        public string RestoreString(string s, int[] indices)
        {

            var arr = new char[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                int val = indices[i];

                arr[val] = s[i];
            }

            return new string(arr);
        }
    }
}
