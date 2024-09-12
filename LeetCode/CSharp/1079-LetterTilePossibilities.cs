using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution1079: IRunProgram
{
    public void Run()
    {
        NumTilePossibilities("AAB").Print();
    }

    public int NumTilePossibilities(string tiles)
    {
        int output = 0;
        Helper(ref output, new string(tiles.OrderBy(c => c).ToArray()), 0);
        return output;
    }

    private unsafe void Helper(ref int output, ReadOnlySpan<char> tiles, int index)
    {
        for (int i = 0; i < tiles.Length; i++)
        {
            if (i > 0 && tiles[i] == tiles[i - 1])
            {
                continue;
            }
            output++;
            Helper(ref output, [.. tiles[..i], .. tiles[(i + 1)..]], i + 1);
        }
    }
}
