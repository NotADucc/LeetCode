﻿using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution1472 : IRunProgram
{
    public void Run()
    {

    }
}
public class BrowserHistory
{

    Stack<string> history = new Stack<string>();
    Stack<string> future = new Stack<string>();
    string current = "";
    public BrowserHistory(string homepage)
    {
        current = homepage;
    }

    public void Visit(string url)
    {
        history.Push(current);
        future.Clear();
        current = url;
    }

    public string Back(int steps)
    {
        for (int i = 0; i < steps; i++)
        {
            if (history.Count <= 0)
            {
                break;
            }
            future.Push(current);
            current = history.Pop();
        }
        return current;
    }

    public string Forward(int steps)
    {
        for (int i = 0; i < steps; i++)
        {
            if (future.Count <= 0)
            {
                break;
            }
            history.Push(current);
            current = future.Pop();
        }
        return current;
    }
}
