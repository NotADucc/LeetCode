using LeetCode.Shared;

namespace LeetCode.CSharp
{
    internal class Solution2582 : IRunProgram
    {
        public void Run()
        {
            PassThePillow(2, 90).Print();
        }

        public int PassThePillow(int n, int time)
        {
            int new_n = n - 1;
            int full_passes = time / new_n;

            return IsEven(full_passes)
                ? (time % (new_n * 2)) + 1
                : n - (time % new_n);
        }

        private bool IsEven(int input) => (input & 1) == 0;
    }
}
