﻿using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution1603 : IRunProgram
{
    public void Run()
    {

    }
}
public class ParkingSystem
{
    private int[] spces = new int[] { 0, 0, 0 };

    public ParkingSystem(int big, int medium, int small)
    {
        spces[0] = big;
        spces[1] = medium;
        spces[2] = small;
    }

    public bool AddCar(int carType)
    {
        if (spces[carType - 1] <= 0)
        {
            return false;
        }
        spces[carType - 1] -= 1;
        return true;
    }
}