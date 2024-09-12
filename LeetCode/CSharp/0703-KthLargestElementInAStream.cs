using LeetCode.Shared;

namespace LeetCode.CSharp
{
    internal class Solution0703: IRunProgram
    {
        public void Run()
        {
            
        }
    }
    public class KthLargest
    {
        private PriorityQueue<int, int> _prio;
        private int _k;
        public KthLargest(int k, int[] nums)
        {
            _prio = new PriorityQueue<int, int>();
            _k = k;

            foreach (int i in nums) { Add(i); }
        }

        public int Add(int val)
        {
            if (_prio.Count < _k)
            {
                _prio.Enqueue(val, val);
            }
            else if (val > _prio.Peek())
            {
                _prio.Dequeue();
                _prio.Enqueue(val, val);
            }

            return _prio.Peek();
        }
    }
}
