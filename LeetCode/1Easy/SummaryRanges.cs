using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._1Easy
{
    internal class SummaryRanges : IRunProgram
    {
        private record Input(int[] Data, List<string> Result);
        public void Run()
        {
            Input[] inputs = new Input[]
            {
                new Input(new int[]{ 0 }, new List<string>(){ "0" })
                ,new Input(new int[]{ 0,1,2,4,5,7 }, new List<string>(){ "0->2", "4->5", "7" })
                ,new Input(new int[]{ 0,2,3,4,6,8,9 }, new List<string>(){ "0", "2->4", "6", "8->9" })
                ,new Input(new int[]{ 0,2,3,4,6,8,9,11 }, new List<string>(){ "0", "2->4", "6", "8->9", "11" })
                ,new Input(new int[]{  }, new List<string>(){  })
            };

            foreach (var input in inputs)
            {
                Method(input.Data).Print();
                input.Result.Print();
                Console.WriteLine();
            }
        }

        public List<string> Method(int[] nums)
        {
            List<string> output = new List<string>();

            if (nums.Length == 0)
            {
                return output;
            }

            int start = nums[0];
            int offset = 0;


            for (int i = 0; i < nums.Length; i++, offset++)
            {
                if (start + offset == nums[i])
                {
                    continue;
                }

                string temp = offset == 1 ? start.ToString() : $"{start}->{start + offset - 1}";
                output.Add(temp);

                start = nums[i];
                offset = 0;
            }

            string temp2 = offset == 1 ? start.ToString() : $"{start}->{start + offset - 1}";
            output.Add(temp2);

            return output;
        }
    }
}
