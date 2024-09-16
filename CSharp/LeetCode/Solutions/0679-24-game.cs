using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0679 : IRunProgram
{
    public void Run()
    {
        JudgePoint24([4, 1, 8, 7]).Print();
        JudgePoint24([1, 2, 1, 2]).Print();
    }
    public bool JudgePoint24(int[] cards)
    {
        bool found = false;
        Helper(ref found, cards.ToList(), 0);
        return found;
    }

    const int TARGET = 24;
    private void Helper(ref bool found, List<int> cards, double curr)
    {
        if (cards.Count == 0 && Math.Round(curr, MidpointRounding.AwayFromZero) == TARGET)
        {
            found = true;
        }
        else
        {
            if (found) return;
            for (int i = 0; i < cards.Count; i++)
            {
                int card_val = cards[i];
                cards.Remove(card_val);

                Helper(ref found, cards, curr + card_val);
                Helper(ref found, cards, curr - card_val);
                if (curr != 0)
                {
                    Helper(ref found, cards, curr / card_val);
                    Helper(ref found, cards, curr * card_val);
                    Helper(ref found, cards, card_val / curr);
                }

                if (i < cards.Count)
                {
                    int next_card_val = cards[i];

                    cards.Remove(next_card_val);

                    Helper(ref found, cards, curr * (card_val + next_card_val));
                    if (card_val - next_card_val != 0)
                    {
                        Helper(ref found, cards, curr / (card_val - next_card_val));
                        Helper(ref found, cards, curr * (card_val - next_card_val));
                        Helper(ref found, cards, (card_val - next_card_val) / curr);
                    }

                    cards.Insert(i, next_card_val);
                }

                cards.Insert(i, card_val);
            }
        }
    }
}
