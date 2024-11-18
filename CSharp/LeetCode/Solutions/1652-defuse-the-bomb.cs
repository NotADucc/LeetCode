using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution1652 : IRunProgram
{
    public void Run()
    {
        
    }

    public int[] Decrypt(int[] code, int k) 
    {
        var res = new int[code.Length];
        if (k == 0) return res;
        int l = 1;
        if (k < 0)
        {
            l = code.Length + k;
            k *= -1;
        }
        int r = l;
        for (int j = 1; j <= k; j++)
            res[0] += code[r++];

        for (int i = 1; i < code.Length; i++)
        {
            res[i] += res[i - 1];
            res[i] -= code[l++ % code.Length];
            res[i] += code[r++ % code.Length];
        }   

        return res;     
    }
}
