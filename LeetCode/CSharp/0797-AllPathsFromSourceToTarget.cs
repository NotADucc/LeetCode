using LeetCode.Shared;

namespace LeetCode.CSharp
{
    internal class Solution0797: IRunProgram
    {
        public void Run()
        {
            AllPathsSourceTarget([[1, 2], [3], [3], []]).Print();
            AllPathsSourceTarget([[4, 3, 1], [3, 2, 4], [3], [4], []]).Print();
        }
        public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
        {
            var output = new List<IList<int>>();

            Helper(graph, output, [0], 0, graph.Length - 1);

            return output;
        }

        private void Helper(int[][] graph, List<IList<int>> output, List<int> curr, int last_node, int target)
        {
            if (last_node == target)
            {
                output.Add(new List<int>(curr));
            }
            else
            {
                for (int j = 0; j < graph[last_node].Length; j++)
                {
                    curr.Add(graph[last_node][j]);
                    Helper(graph, output, curr, graph[last_node][j], target);
                    curr.RemoveAt(curr.Count - 1);
                }
            }
        }
    }
}
