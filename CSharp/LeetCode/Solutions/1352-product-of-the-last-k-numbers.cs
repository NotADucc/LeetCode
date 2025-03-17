using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution1352 : IRunProgram
{
    public void Run()
    {

    }
    public class ProductOfNumbers
    {
        private List<int> lst = [];
        public ProductOfNumbers() { }
        // prefix tree idea
        public void Add(int num)
        {
            lst.Add(num);
        }

        public int GetProduct(int k)
        {
            int res = lst[lst.Count - 1];
            for (int i = 2; i <= k; i++)
            {
                res *= lst[lst.Count - i];
            }
            return res;
        }
    }
}
