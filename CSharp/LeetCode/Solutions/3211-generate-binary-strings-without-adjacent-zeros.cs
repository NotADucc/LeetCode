using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;
internal class Solution3211 : IRunProgram
{
    public void Run()
    {
        ValidStrings(3).Print();
    }

    public IList<string> ValidStrings(int n)
    {
        HashSet<string> ans = new HashSet<string>();
        
        r(ans, new int[n], 0);

        return ans.ToList();
    }

    private void r(HashSet<string> ans, int[] curr, int idx) 
    {
        if (idx == curr.Length)
        {
            ans.Add(string.Join("", curr));
            return;
        }

        curr[idx] = 1;
        r(ans, curr, idx + 1);
        if (idx == 0 || curr[idx - 1] == 1)
        { 
            curr[idx] = 0;
            r(ans, curr, idx + 1);
        }
    }
}
