using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0641 : IRunProgram
{
    public void Run()
    {

    }
    internal class MyCircularDeque
    {
        private LinkedList<int> lst = new LinkedList<int>();
        private int max = 0;
        public MyCircularDeque(int k)
        {
            max = k;
        }

        public bool InsertFront(int value)
        {
            if (IsFull()) return false;
            lst.AddFirst(value);
            return true;
        }

        public bool InsertLast(int value)
        {
            if (IsFull()) return false;
            lst.AddLast(value);
            return true;
        }

        public bool DeleteFront()
        {
            if (IsEmpty()) return false;
            lst.RemoveFirst();
            return true;
        }

        public bool DeleteLast()
        {
            if (IsEmpty()) return false;
            lst.RemoveLast();
            return true;
        }

        public int GetFront()
        {
            if (IsEmpty()) return -1;
            return lst.First!.Value;
        }

        public int GetRear()
        {
            if (IsEmpty()) return -1;
            return lst.Last!.Value;
        }

        public bool IsEmpty() => lst.Count == 0;

        public bool IsFull() => lst.Count >= max;
    }
}
