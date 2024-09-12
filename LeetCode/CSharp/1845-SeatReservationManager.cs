using LeetCode.Shared;

namespace LeetCode.CSharp
{
    internal class Solution1845 : IRunProgram
    {
        public void Run()
        {

        }
    }

    public class SeatManager
    {
        private PriorityQueue<int, int> _seats = new PriorityQueue<int, int>();
        public SeatManager(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                _seats.Enqueue(i, i);
            }
        }

        public int Reserve()
        {
            return _seats.Dequeue();
        }

        public void Unreserve(int nr)
        {
            _seats.Enqueue(nr, nr);
        }
    }
}
