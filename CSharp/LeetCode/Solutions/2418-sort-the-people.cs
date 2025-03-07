﻿using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2418 : IRunProgram
{
    public void Run()
    {
        SortPeople(["Mary", "John", "Emma"], [180, 165, 170]).Print();
    }
    public string[] SortPeople(string[] names, int[] heights)
    {
        int i = 0;
        Dictionary<int, int> dctHeights = heights.ToDictionary(x => x, _ => i++);
        Array.Sort(heights);

        var output = new string[names.Length];
        for (i = 0; i < heights.Length; i++)
        {
            output[i] = names[dctHeights[heights[^(i + 1)]]];
        }
        return output;
    }
}
