using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0841 : IRunProgram
{
    public void Run()
    {
        
    }

    public bool CanVisitAllRooms(IList<IList<int>> rooms)
    {
        var visited = new bool[rooms.Count];
        var q = new Queue<int>();

        visited[0] = true;
        q.Enqueue(0);

        while (q.Count > 0)
        {
            int curr = q.Dequeue();
            foreach (int room in rooms[curr])
            {
                if (!visited[room])
                {
                    visited[room] = true;
                    q.Enqueue(room);
                }
            }
        }

        return visited.All(x => x);
    }
}
