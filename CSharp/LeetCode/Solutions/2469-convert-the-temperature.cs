using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2469 : IRunProgram
{
    public void Run()
    {
        ConvertTemperature(36.5).Print();
    }
    public double[] ConvertTemperature(double celsius)
    {
        return new double[] { celsius + 273.15, (celsius * 1.8 + 32) };
    }
}
