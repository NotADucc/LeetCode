using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0729 : IRunProgram
{
    public void Run()
    {

    }
    internal class MyCalendar
    {
        private List<(int, int)> book = new List<(int, int)>(1001);
        public MyCalendar()
        {

        }

        public bool Book(int start, int end)
        {
            bool can_add = true;
            for (int i = 0; i < book.Count; i++)
            {
                (int booked_start, int booked_end) = book[i];
                if (
                    (start < booked_start && end > booked_start)
                || (start < booked_end && end >= booked_end)
                || (start >= booked_start && end <= booked_end)
                )
                {
                    can_add = false;
                    break;
                }
            }

            if (can_add) book.Add((start, end));
            return can_add;
        }
    }

}
