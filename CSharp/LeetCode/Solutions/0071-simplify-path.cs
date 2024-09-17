using LeetCode.Solutions.Shared;
using System.Text;

namespace LeetCode.Solutions;

internal class Solution0071 : IRunProgram
{
    public void Run()
    {

    }

    public string SimplifyPath(ReadOnlySpan<char> path)
    {
        Stack<string> stack = new Stack<string>();

        for (int i = 0; i < path.Length; i++)
        {
            if (path[i] == '/') continue;
            if (path[i] == '.')
            {
                if (i + 1 >= path.Length || path[i + 1] == '/')
                {
                    i++;
                    continue;
                }
                else if ((i + 2 < path.Length && path[i + 1] == '.' && path[i + 2] == '/') || (i + 2 >= path.Length && path[i + 1] == '.'))
                {
                    if (stack.Count > 0) stack.Pop();
                    i += 2;
                    continue;
                }
            }
            i += AddToStack(path, i, stack);
        }

        StringBuilder sb = new StringBuilder();
        while (stack.Count > 0) sb.Insert(0, $"/{stack.Pop()}");
        return sb.Length == 0 ? "/" : sb.ToString();
    }

    private int AddToStack(ReadOnlySpan<char> path, int start, Stack<string> stack)
    {
        int next = path.Slice(start).IndexOf('/');
        next = next == -1 ? path.Length - start : next;
        stack.Push(path.Slice(start, next).ToString());

        return next;
    }
}
