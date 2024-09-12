using LeetCode.Shared;

namespace LeetCode._2Medium
{
    public class ContainerWithMostWater : IRunProgram
    {
        private record Input(int[] Data, int Result);
        public void Run()
        {
            Input[] inputs = new Input[]
            {
                new Input(new int[]{ 1,8,6,2,5,4,8,3,7}, 49)
                ,new Input(new int[]{ 1,1}, 1)
                ,new Input(new int[]{ 1,8,6,2,5,4,8,3,8}, 56)
                ,new Input(new int[]{ 2,3,4,5,18,17,6}, 17)
            };

            foreach (var item in inputs)
            {
                Console.WriteLine(MaxArea(item.Data));
                Console.WriteLine(item.Result);
                Console.WriteLine();
            }
        }

        public int MaxArea(int[] height)
        {
            //TODO
            return 0;
        }

        //TLE
        public int MaxAreaBrute(int[] height)
        {
            int v = 0;
            int l = height.Length;

            for (int i = 0; i < l; i++)
            {
                for (int j = i + 1; j < l; j++)
                {
                    int smallerPillar = Math.Min(height[i], height[j]);
                    v = Math.Max(smallerPillar * (j - i), v);
                }
            }

            return v;
        }
    }
}
