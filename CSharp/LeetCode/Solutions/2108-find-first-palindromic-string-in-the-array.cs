using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2108 : IRunProgram
{
    public void Run()
    {
        FirstPalindrome(["abc", "car", "ada", "racecar", "cool"]).Print();
    }

    public string FirstPalindrome(string[] words)
    {
        return words.FirstOrDefault(x => x.Equals(new string(x.Reverse().ToArray()))) ?? string.Empty;
    }
}
