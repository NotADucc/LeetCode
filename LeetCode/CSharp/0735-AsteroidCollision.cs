using LeetCode.CSharp.Shared;
using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution0735: IRunProgram
    {
        public void Run()
        {
            AsteroidCollision([5, 10, -5]).Print();
            AsteroidCollision([8, -8]).Print();
        }
        public int[] AsteroidCollision(int[] asteroids)
        {
            Stack<int> stack = new Stack<int>();
            foreach (int asteroid in asteroids)
            {
                if (asteroid < 0)
                {
                    bool addAst = true;
                    while (stack.Count > 0)
                    {
                        if (stack.Peek() < 0) { break; }
                        int prev = stack.Pop();
                        int difference = prev + asteroid;
                        if (difference > 0)
                        {
                            addAst = false;
                            stack.Push(prev);
                            break;
                        }
                        else if (difference == 0)
                        {
                            addAst = false;
                            break;
                        }
                    }
                    if (addAst)
                    {
                        stack.Push(asteroid);
                    }
                }
                else
                {
                    stack.Push(asteroid);
                }
            }
            return stack.Reverse().ToArray();
        }
    }
}
