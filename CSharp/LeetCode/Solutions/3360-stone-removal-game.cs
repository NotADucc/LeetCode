using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution3360 : IRunProgram
{
	public void Run()
	{

	}

	public bool CanAliceWin(int n)
	{
		for (int i = 10; i > 0; i--)
		{
			n -= i;
			if (n < 0)
			{
				return (i & 1) == 1;
			}
		}

		return false;
	}
}
