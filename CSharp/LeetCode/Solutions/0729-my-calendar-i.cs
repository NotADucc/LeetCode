using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions
{
    internal class Solution0729 : IRunProgram
    {
        public void Run()
        {

        }
        public class MyCalendar
        {
            private PriorityQueue<(int, int), int> book = new PriorityQueue<(int, int), int>();
            public MyCalendar()
            {

            }

            public bool Book(int start, int end)
            {
                bool can_add = true;
                List<(int, int)> temp = new List<(int, int)>();
                while (book.Count > 0)
                {
                    (int booked_start, int booked_end) = book.Peek();
                    if (booked_start >= end)
                    {
                        break;
                    }

                    if (
                        (start < booked_start && end >= booked_start)
                    || (start < booked_end && end >= booked_end)
                    || (start >= booked_start && end <= booked_end)
                    )
                    {
                        can_add = false;
                        break;
                    }
                    temp.Add(book.Dequeue());
                }

                for (int i = 0; i < temp.Count; i++)
                {
                    book.Enqueue((temp[i].Item1, temp[i].Item2), temp[i].Item1);
                }

                if (can_add) book.Enqueue((start, end), start);
                return can_add;
            }
        }
    }
}
