using LeetCode.Solutions.Shared;
using System.Text;

namespace LeetCode.Solutions;

internal class Solution0179 : IRunProgram
{
    public void Run()
    {
        
    }

    public static string LargestNumber(int[] nums)
    {
        string[] temp = nums
            .Select(x => x.ToString())
            .ToArray();

        Array.Sort(temp, (x, y) => string.Compare(y + x, x + y));

        Console.WriteLine(string.Join(", ", temp));
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < temp.Length; i++)
        {
            sb.Append(temp[i]);
        }
        return sb.ToString();
    }
}
