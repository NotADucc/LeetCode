using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;
internal class Solution1931 : IRunProgram
{
    public void Run()
    {
        //ColorTheGrid(1, 1).Print();
        //ColorTheGrid(2, 1).Print();
        ColorTheGrid(5, 3).Print();
    }

    public int ColorTheGrid(int m, int n)
    {
        return (int)(rec(m, n) % 1_000_000_007);
    }
    private long rec(int m, int n)
    {
        Dictionary<string, long> memo = [];
        int[,] grid = new int[m, n];

        long inner(int mm, int nn, int visited)
        {
            var key = $"{mm}:{nn}";
            if (memo.TryGetValue(key, out long value))
                return value;

            if (visited == grid.Length)
            {
                memo[key] = 1;
                return 1;
            }

            if (mm < 0 || mm >= m || nn < 0 || nn >= n || grid[mm, nn] != 0)
                return 0;

            long add = 0;

            for (int i = 1; i < 4; i++)
            {
                int min_mm = Math.Max(mm - 1, 0);
                int max_mm = Math.Min(mm + 2, m);

                int min_nn = Math.Max(nn - 1, 0);
                int max_nn = Math.Min(nn + 2, n);

                bool can_place = true;

                //Console.WriteLine(key);

                for (int j = min_mm; j < max_mm; j++)
                {
                    for (int k = min_nn; k < max_nn; k++)
                    {
                        //Console.WriteLine($"{j} | {k}");
                        if (grid[j, k] == i)
                        {
                            can_place = false;
                            break;
                        }
                    }
                    if (!can_place) break;
                }
                //Console.WriteLine();

                if (can_place)
                {
                    grid[mm, nn] = i;
                    add += inner(mm - 1, nn, visited + 1);
                    add += inner(mm + 1, nn, visited + 1);

                    add += inner(mm, nn - 1, visited + 1);
                    add += inner(mm, nn + 1, visited + 1);
                    grid[mm, nn] = 0;
                }
            }

            memo[key] = add;
            return add;
        }
        
        return inner(0, 0, 0);
    }
}
