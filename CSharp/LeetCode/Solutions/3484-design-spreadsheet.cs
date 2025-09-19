using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;
internal class Solution3484 : IRunProgram
{
    public void Run()
    {
        Spreadsheet spreadsheet = new(3);
        spreadsheet.GetValue("=5+7");
    }

    private class Spreadsheet
    {
        private readonly Dictionary<string, int> dct = [];
        public Spreadsheet(int rows) { }

        public void SetCell(string cell, int value)
        {
            // apparently you don't need checks to see 
            // if rows constraint gets violated or not
            if (!dct.TryAdd(cell, value))
                dct[cell] = value;
        }

        public void ResetCell(string cell)
        {
            if (!dct.TryAdd(cell, 0))
                dct[cell] = 0;
        }

        public int GetValue(string formula)
        {
            var split = formula
                .Substring(1)
                .Split('+');

            if (!dct.TryGetValue(split[0], out var n1))
                int.TryParse(split[0], out n1);

            if (!dct.TryGetValue(split[1], out var n2))
                int.TryParse(split[1], out n2);

            return n1 + n2;
        }
    }
}
