using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution2349 : IRunProgram
{
    public void Run()
    {

    }

    public class NumberContainers
    {
        //key: idx, val: val
        private readonly Dictionary<int, int> loc = [];
        //key: val, val: idxs
        private readonly Dictionary<int, SortedList<int, int>> indices = [];
        public NumberContainers() { }

        public void Change(int index, int number)
        {
            if (loc.TryGetValue(index, out int curr_num))
            {
                indices[curr_num].Remove(index);
            }

            if (!indices.ContainsKey(number))
                indices[number] = new SortedList<int, int>();
            loc[index] = number;
            indices[number].Add(index, index);
        }

        public int Find(int number)
        {
            if (indices.TryGetValue(number, out var vals) && vals.Count != 0)
            {
                return vals.Values[0];
            }
            return -1;
        }
    }
}
