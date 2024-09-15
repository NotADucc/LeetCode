namespace LeetCode.Shared;

internal class Runner
{
    public static void RunLeetCodeSolution<T>() where T : IRunProgram, new()
    { 
        T program = new T();
        program.Run();
    }
}
