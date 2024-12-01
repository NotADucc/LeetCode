using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution1346 : IRunProgram
{
    public void Run()
    {
        
    }

    public bool CheckIfExist(int[] arr)
    {
        var set = new HashSet<int>();
        foreach (int num in arr)
        {
            int dbl = num << 1;
            int hlf = num >> 1;
            if (set.Contains(dbl) || ((num & 1) == 0 && set.Contains(hlf)))
            {
                return true;
            }
            set.Add(num);
        }
        return false;
    }
}
