using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2337 : IRunProgram
{
    public void Run()
    {
        
    }

    public bool CanChange(string start, string target)
    {
        if (start.Length == 1)
            return start.Equals(target);

        int idx_s = 0, idx_t = 0;

        while (idx_t < target.Length && idx_s < start.Length)
        {
            if (target[idx_t] == 'L')
            {
                while (idx_s < start.Length && start[idx_s] != 'L')
                {
                    if (start[idx_s++] == 'R') return false;
                }
                if (idx_s < idx_t) return false;
                idx_s++;
            }
            else if (target[idx_t] == 'R')
            {
                while (idx_s < start.Length && start[idx_s] != 'R')
                {
                    if (start[idx_s++] == 'L' || idx_s > idx_t) return false;
                }
                if (idx_s > idx_t) return false;
                idx_s++;
            }
            idx_t++;
        }

        for (; idx_s < start.Length; idx_s++)
            if (start[idx_s] != '_') return false;

        for (; idx_t < target.Length; idx_t++)
            if (target[idx_t] != '_') return false;

        return true;
    }
}
