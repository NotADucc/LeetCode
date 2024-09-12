using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Shared
{
    internal class Runner
    {
        public static void RunLeetCodeSolution<T>() where T : IRunProgram, new()
        { 
            T program = new T();
            program.Run();
        }
    }
}
