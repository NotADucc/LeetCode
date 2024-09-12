using LeetCode.Shared;

namespace LeetCode.CSharp
{
    internal class Solution2079 : IRunProgram
    {
        public void Run()
        {
            WateringPlants([2, 2, 3, 3], 5).Print();
        }

        public int WateringPlants(int[] plants, int capacity)
        {
            int currentWater = capacity;
            int currentSteps = 0;

            for (int i = 0; i < plants.Length; i++)
            {
                int plant = plants[i];
                currentSteps++;

                if (currentWater >= plant)
                {
                    currentWater -= plant;
                    continue;
                }

                currentSteps += (Math.Max(i, 1) * 2);
                currentWater = capacity - plant;
            }

            return currentSteps;
        }
    }
}
