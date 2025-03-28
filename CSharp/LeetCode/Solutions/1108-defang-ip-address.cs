﻿using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution1108 : IRunProgram
{
    public void Run()
    {
        DefangIPaddr("1.1.1.1").Print();
        DefangIPaddr("255.100.50.0").Print();
    }
    public string DefangIPaddrCheese(string address)
    {
        return address.Replace(".", "[.]");
    }
    public string DefangIPaddr(string address)
    {
        int l = address.Length;
        int j = 0;
        Span<char> output = stackalloc char[l + 6];
        for (int i = 0; i < l; i++, j++)
        {
            if (address[i].Equals('.'))
            {
                output[j++] = '[';
                output[j++] = '.';
                output[j] = ']';
                continue;
            }
            output[j] = address[i];
        }
        return output.ToString();
    }
}
