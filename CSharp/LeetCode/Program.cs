using LeetCode.Shared;
using LeetCode.Solutions;
using System.Text;

namespace LeetCode;

public class Program
{
    public static void Main()
    {
        //BenchmarkRunner.Run<Benchmark0093>();
        //Runner.RunLeetCodeSolution<Solution0539>();

        var files_dir = Directory.GetFiles(@"D:\Snogramming\LeetCode\CSharp\LeetCode\Solutions");
        var files_renamed = new List<string>();
        foreach (var file in files_dir)
        {
            var dir = Path.GetDirectoryName(file);
            var filename = Path.GetFileName(file);
            StringBuilder sb = new StringBuilder(filename[..6].ToLower());
            for (int i = 6; i < filename.Length; i++)
            {
                if (char.IsUpper(filename[i]))
                {
                    sb.Append('-');
                    sb.Append(char.ToLower(filename[i]));
                }
                else
                {
                    sb.Append(filename[i]);
                }
            }
            System.IO.File.Move(file, Path.Combine(dir, sb.ToString()));
            //files_renamed.Add(Path.Combine(dir, sb.ToString()));
        }

        Console.ReadLine();
    }
}
