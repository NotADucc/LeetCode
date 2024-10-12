using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution1603 : IRunProgram
{
    public void Run()
    {

    }

    public class ParkingSystem
    {
        private int[] spaces;

        public ParkingSystem(int big, int medium, int small)
        {
            spaces = [big, medium, small];
        }

        public bool AddCar(int carType)
        {
            if (spaces[carType - 1] <= 0) return false;
            spaces[carType - 1] -= 1;
            return true;
        }
    }
}