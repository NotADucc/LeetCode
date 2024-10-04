using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2491 : IRunProgram
{
    public void Run()
    {

    }

    public long DividePlayers(int[] skill) 
    {
        Array.Sort(skill);
        int l = 0, r = skill.Length - 1;
        long output = 0;
        int lvl = skill[l] + skill[r];
        while(l < r)
        {
            if (skill[l] + skill[r] != lvl)
            {
                return -1;
            }
            output += skill[l] * skill[r];
            l++;
            r--;
        }
        return output;
    }
}
