using LeetCode.Shared;

namespace LeetCode.CSharp
{
    internal class Solution1833 : IRunProgram
    {
        public void Run()
        {
            // TODO: cheese
            MaxIceCream([1, 3, 2, 4, 1], 7).Print();
        }

        public int MaxIceCream(int[] costs, int coins)
        {
            Array.Sort(costs);
            int total = 0;
            foreach (var a in costs)
            {
                if (a > coins)
                {
                    return total;
                }
                coins -= a;
                total++;
            }
            return total;
        }
    }
}
