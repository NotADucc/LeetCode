using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

public class Solution1405 : IRunProgram
{
    public void Run()
    {

    }

    public string LongestDiverseString(int a, int b, int c) 
    {
        var queue = new PriorityQueue<(char, int), int>();
        (char l, int f) = ('\0', 0);
        if (a > 0) queue.Enqueue(('a', a), -a);    
        if (b > 0) queue.Enqueue(('b', b), -b);    
        if (c > 0) queue.Enqueue(('c', c), -c); 
        StringBuilder sb = new StringBuilder();
        while (queue.Count > 0)
        {
            (var letter, var freq) = queue.Dequeue();
            if (l != '\0')
            {
                queue.Enqueue((l, f), -f);
                (l, f) = ('\0', 0);
            }
            if (sb.Length >= 2 && sb[^1] == letter && sb[^2] == letter)
            {
                (l, f) = (letter, freq);
            }
            else
            {
                sb.Append(letter);
                freq--;
                if (freq > 0) queue.Enqueue((letter, freq), -freq);
            }
        }   

        return sb.ToString();
    }  
}
