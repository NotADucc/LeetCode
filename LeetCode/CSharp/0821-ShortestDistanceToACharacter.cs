using LeetCode.Shared;

namespace LeetCode.CSharp
{
    internal class Solution0821: IRunProgram
    {
        public void Run()
        {
            ShortestToChar("loveleetcode", 'e').Print();
        }
        public int[] ShortestToChar(string s, char c)
        {
            var output = new int[s.Length];

            int old_left = -1, left = -1;

            for (int current_char_index = 0; current_char_index < s.Length; current_char_index++)
            {
                //refresh left when current index is outside bounds of our window
                if (current_char_index > left)
                {
                    old_left = left;
                    left++;
                    //seek next bound
                    while (left < s.Length)
                    {
                        if (s[left] == c)
                        {
                            break;
                        }
                        left++;
                    }
                    //reset left since there are no more c's left
                    if (left == s.Length)
                    {
                        left = old_left;
                    }
                }

                int difference;
                if (old_left == -1)
                {
                    difference = left - current_char_index;
                }
                //only make a comparison if theres a distinct lefts
                else if (left != old_left)
                {
                    difference = Math.Min(left - current_char_index, current_char_index - old_left);
                }
                else
                {
                    difference = current_char_index - old_left;
                }

                output[current_char_index] = difference;
            }

            return output;
        }
    }
}
