using LeetCode.Shared;
using System.Reflection.Metadata.Ecma335;

namespace LeetCode._1Easy
{
    /*
    Runtime: 22ms 62.88%
    Memory: 26.68MB 84.09%
    */
    internal class MaxAchievableNumber : IRunProgram
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
