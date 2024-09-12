using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution2037 : IRunProgram
    {
        public void Run()
        {
            MinMovesToSeat([3, 1, 5], [2, 7, 4]).Print();
        }
        public int MinMovesToSeat(int[] seats, int[] students)
        {
            Array.Sort(seats);
            Array.Sort(students);
            int moves = 0;
            for (int i = 0; i < seats.Length; i++)
            {
                moves += Math.Abs(seats[i] - students[i]);
            }
            return moves;
        }
    }
}
