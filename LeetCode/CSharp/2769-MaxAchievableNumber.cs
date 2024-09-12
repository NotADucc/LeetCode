using LeetCode.Shared;


namespace LeetCode.CSharp
{
    internal class Solution2769 : IRunProgram
    {
        private record Input(int Num, int T, int Max);
        public void Run()
        {
            Input[] inputs = new Input[]
            {
                new Input(4, 1, 6)
                ,new Input(3, 2, 7)
            };

            foreach (var input in inputs)
            {
                Console.WriteLine(TheMaximumAchievableX(input.Num, input.T));
                Console.WriteLine(input.Max);
                Console.WriteLine();
            }
        }

        public int TheMaximumAchievableX(int num, int t)
        {
            return num + t * 2;
        }
    }
}
