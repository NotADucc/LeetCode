using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution0155 : IRunProgram
{
    public void Run()
    {
        
    }
}
public class MinStack
{
    Stack<(int, int)> stack = new Stack<(int, int)>();
    public MinStack()
    {

    }

    public void Push(int val)
    {
        int min = stack.Count > 0 && stack.Peek().Item2 < val ? stack.Peek().Item2 : val;
        stack.Push((val, min));
    }

    public void Pop()
    {
        stack.Pop();
    }

    public int Top()
    {
        return stack.Peek().Item1;
    }

    public int GetMin()
    {
        return stack.Peek().Item2;
    }
}
