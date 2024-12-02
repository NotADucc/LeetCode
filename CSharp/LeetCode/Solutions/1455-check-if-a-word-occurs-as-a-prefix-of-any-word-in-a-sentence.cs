using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution1455 : IRunProgram
{
	public void Run()
	{

	}

	public int IsPrefixOfWord(string sentence, string searchWord) 
	{
		var split = sentence.Split(" ");
		for (int i = 0; i < split.Length; i++)
		{
			if (split[i].StartsWith(searchWord))
			{
				return i + 1;
			}
		}

		return -1;        
	}
}
