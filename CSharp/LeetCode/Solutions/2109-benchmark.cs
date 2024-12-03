using BenchmarkDotNet.Attributes;
using LeetCode.Solutions.Benchmark;
using System.Text;

namespace LeetCode.Solutions
{
    public class Benchmark2109 : BenchmarkAttributes
    {
        string input;
        int[] spaces;

        Solution2109 proj = null;

        [GlobalSetup]
        public void Setup()
        {
            proj = new Solution2109();
            input = "LeetcodeHelpsMeLearn";
            spaces = [8, 13, 15];
        }

        [Benchmark(Baseline = true)]
        public string SpacesArr()
        {
            return proj.AddSpaces(input, spaces);
        }

        [Benchmark]
        public string Naive()
        {
            return AddSpaces(input, spaces);
        }

        public string AddSpaces(string s, int[] spaces)
        {
            StringBuilder sb = new StringBuilder(s.Length + spaces.Length);
            int space_idx = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (space_idx < spaces.Length && spaces[space_idx] == i)
                {
                    sb.Append(' ');
                    space_idx++;
                }
                sb.Append(s[i]);
            }

            return sb.ToString();
        }
    }
}
