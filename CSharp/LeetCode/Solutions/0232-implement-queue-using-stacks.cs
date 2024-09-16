using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0232 : IRunProgram
{
    public void Run()
    {

    }
}

public class MyQueue
{
    Stack<int> q1 = new Stack<int>();
    Stack<int> q2 = new Stack<int>();
    public MyQueue() { }

    public void Push(int x)
    {
        q1.Push(x);
    }

    public int Pop()
    {
        if (q2.Count > 0)
        {
            return q2.Pop();
        }
        else
        {
            while (q1.Count > 0)
            {
                q2.Push(q1.Pop());
            }
        }

        return q2.Pop();
    }

    public int Peek()
    {
        if (q2.Count > 0)
        {
            return q2.Peek();
        }
        else
        {
            while (q1.Count > 0)
            {
                q2.Push(q1.Pop());
            }
        }

        return q2.Peek();
    }

    public bool Empty()
    {
        return q1.Count == 0 && q2.Count == 0;
    }
}
