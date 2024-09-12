using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution0190 : IRunProgram
{
    public void Run()
    {
        reverseBits(0b_00000010100101000001111010011100).Print();
    }
    public uint reverseBits(uint n)
    {
        string base2N = Convert.ToString(n, 2);
        Span<char> output = stackalloc char[32];
        for (int i = 0; i < 32; i++)
        {
            if (base2N.Length > i)
            {
                output[i] = base2N[^(i + 1)];
                continue;
            }
            output[i] = '0';
        }

        return Convert.ToUInt32(output.ToString(), 2);
    }
}
