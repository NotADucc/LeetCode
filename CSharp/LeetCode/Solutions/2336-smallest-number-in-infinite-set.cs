using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2336 : IRunProgram
{
    public void Run()

    {
    }
}

public class SmallestInfiniteSet
{
    private PriorityQueue<int, int> _priorityQueue;
    private int _current;
    private HashSet<int> _set;

    public SmallestInfiniteSet()
    {
        _priorityQueue = new PriorityQueue<int, int>();
        _current = 1;
        _set = new HashSet<int>();
    }

    public int PopSmallest()
    {
        if (_priorityQueue.Count > 0)
        {
            int smallest = _priorityQueue.Dequeue();
            _set.Remove(smallest);
            return smallest;
        }

        return _current++;
    }

    public void AddBack(int num)
    {
        if (num < _current && _set.Add(num))
        {
            _priorityQueue.Enqueue(num, num);
        }
    }
}
