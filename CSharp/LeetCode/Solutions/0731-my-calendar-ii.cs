using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0731 : IRunProgram
{
    public void Run()
    {
        
    }
    internal class MyCalendarTwo
    {
        private List<(int, int)> book = new List<(int, int)>(1001);
        public MyCalendarTwo() { }

        public bool Book(int start, int end)
        {
            bool Compare(int s1, int s2, int e1, int e2) => (s1 < s2 && e1 > s2) || (s1 < e2 && e1 >= e2) || (s1 >= s2 && e1 <= e2);
            for (int i = 0; i < book.Count; i++)
            {
                (int s1, int e1) = book[i];
                if (Compare(start, s1, end, e1))
                {
                    for (int j = i + 1; j < book.Count; j++)
                    {
                        (int s2, int e2) = book[j];
                        if (Compare(s1, s2, e1, e2) && Compare(start, s2, end, e2))
                        {
                            return false;
                        }
                    }
                }
            }

            book.Add((start, end));
            return true;
        }
    }
}
