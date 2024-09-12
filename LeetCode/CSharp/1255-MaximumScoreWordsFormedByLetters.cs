using LeetCode.Shared;

namespace LeetCode.CSharp
{
    internal class Solution1255 : IRunProgram
    {
        public void Run()
        {
            MaxScoreWords(["dog", "cat", "dad", "good"], ['a', 'a', 'c', 'd', 'd', 'd', 'g', 'o', 'o'], [1, 0, 9, 5, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0]).Print();
        }
        public int MaxScoreWords(string[] words, char[] letters, int[] score)
        {
            Span<int> let = stackalloc int[26];

            foreach (var ch in letters)
            {
                let[ToDigit(ch)]++;
            }

            int output = 0;

            Helper(ref output, let, score, words, 0);

            return output;
        }

        private static int ToDigit(char ch) => ch - 'a';
        private void Helper(ref int output, Span<int> letters, int[] values, string[] words, int score, int index = 0)
        {
            if (words.Length == index)
            {
                output = Math.Max(output, score);
            }
            else
            {
                for (int i = index; i < words.Length; i++)
                {
                    int temp_score = score;
                    bool succes = true;
                    Span<int> temp_letters = stackalloc int[26];
                    letters.CopyTo(temp_letters);

                    for (int j = 0; j < words[i].Length; j++)
                    {
                        int ch_i = ToDigit(words[i][j]);
                        if (letters[ch_i] > 0)
                        {
                            letters[ch_i]--;
                            score += values[ch_i];
                        }
                        else
                        {
                            succes = false;
                            break;
                        }
                    }

                    if (succes)
                    {
                        Helper(ref output, letters, values, words, score, i + 1);
                    }
                    else
                    {
                        Helper(ref output, temp_letters, values, words, temp_score, i + 1);
                    }

                    temp_letters.CopyTo(letters);
                    score = temp_score;
                }
            }
        }
    }
}
