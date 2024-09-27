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
        public MyCalendarTwo()
        {

        }

        public bool Book(int start, int end)
        {
            List<(int, int)> temp = new List<(int, int)>();
            for (int i = 0; i < book.Count; i++)
            {
                (int booked_start, int booked_end) = book[i];
                if (
                    (start < booked_start && end > booked_start)
                || (start < booked_end && end >= booked_end)
                || (start >= booked_start && end <= booked_end)
                )
                {
                    temp.Add((booked_start, booked_end));
                    if (temp.Count > 1)
                    {
                        for (int j = 0; j < temp.Count; j++)
                        {
                            (int s1, int e1) = temp[j];
                            for (int k = j + 1; k < temp.Count; k++)
                            {
                                (int s2, int e2) = temp[k];
                                if (
                                    (s1 < s2 && e1 > s2)
                                || (s1 < e2 && e1 >= e2)
                                || (s1 >= s2 && e1 <= e2)
                                )
                                {
                                    return false;
                                }
                            }
                        }
                    }
                }
            }

            book.Add((start, end));
            return true;
        }
    }

}
