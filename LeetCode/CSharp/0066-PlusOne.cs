using LeetCode.Shared;

namespace LeetCode.CSharp
{
    public class Solution0066 : IRunProgram
    {
        public void Run()
        {
            PlusOne([1, 2, 3]).Print();
            PlusOne([5, 9, 9]).Print();
            PlusOne([9, 9, 9]).Print();
        }

        public int[] PlusOne(int[] digits)
        {
            int plusOne = 1;
            for (int i = 1; i <= digits.Count(); i++)
            {
                int buffer = digits[^i] + plusOne;
                if (buffer < 10)
                {
                    digits[^i] = buffer;
                    plusOne = 0;
                    break;
                }
                plusOne = 1;
                digits[^i] = 0;
            }
            if (plusOne == 1)
            {
                int[] test = new int[digits.Count() + 1];
                test[0] = 1;
                for (int i = 0; i < digits.Count(); i++)
                {
                    test[i + 1] = digits[i];
                }
                digits = test;
            }
            return digits;
        }
    }
}
