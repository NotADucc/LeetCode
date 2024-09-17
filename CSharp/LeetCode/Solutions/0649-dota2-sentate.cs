using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0649 : IRunProgram
{
    public void Run()
    {
        PredictPartyVictory("DDDRRRRR").Print();
    }

    public string PredictPartyVictory(string senate)
    {
        Queue<char> q = new Queue<char>();
        Queue<char> r = new Queue<char>();

        for (int i = 0; i < senate.Length; i++) q.Enqueue(senate[i]);

        while (q.Count > 1)
        {
            char s1 = r.Count == 0 ? q.Dequeue() : r.Dequeue();
            if (s1 == q.Peek())
            {
                while (q.Count > 0 && s1 == q.Peek())
                {
                    r.Enqueue(q.Dequeue());
                }
                if (q.Count > 0) q.Dequeue();
            }
            else
            {
                q.Dequeue();
            }
            q.Enqueue(s1);
        }
        return q.Peek() == 'R' ? "Radiant" : "Dire";
    }
}
