using LeetCode.Shared;

namespace LeetCode.CSharp
{
    internal class Solution1801 : IRunProgram
    {
        public void Run()
        {
            GetNumberOfBacklogOrders([[10, 5, 0], [15, 2, 1], [25, 1, 1], [30, 4, 0]]).Print();
        }

        public int GetNumberOfBacklogOrders(int[][] orders)
        {
            var buy = new PriorityQueue<(int p, int q), int>(Comparer<int>.Create((x, y) => y - x));
            var sell = new PriorityQueue<(int p, int q), int>();

            for (int i = 0; i < orders.Length; i++)
            {
                if (orders[i][2] == 0)
                {
                    while (sell.Count > 0 && sell.Peek().p <= orders[i][0])
                    {
                        (int p, int q) = sell.Dequeue();

                        if (q >= orders[i][1])
                        {
                            q -= orders[i][1];
                            orders[i][1] = 0;
                            if (q > 0)
                            {
                                sell.Enqueue((p, q), p);
                            }
                            break;
                        }
                        else
                        {
                            orders[i][1] -= q;
                        }
                    }

                    if (orders[i][1] > 0)
                    {
                        buy.Enqueue((orders[i][0], orders[i][1]), orders[i][0]);
                    }
                }
                else
                {
                    while (buy.Count > 0 && buy.Peek().p >= orders[i][0])
                    {
                        (int p, int q) = buy.Dequeue();

                        if (q >= orders[i][1])
                        {
                            q -= orders[i][1];
                            orders[i][1] = 0;
                            if (q > 0)
                            {
                                buy.Enqueue((p, q), p);
                            }
                            break;
                        }
                        else
                        {
                            orders[i][1] -= q;
                        }
                    }

                    if (orders[i][1] > 0)
                    {
                        sell.Enqueue((orders[i][0], orders[i][1]), orders[i][0]);
                    }
                }
            }

            int output = 0;

            while (buy.Count > 0)
            {
                output += buy.Dequeue().q;
                output %= 1_000_000_007;
            }

            while (sell.Count > 0)
            {
                output += sell.Dequeue().q;
                output %= 1_000_000_007;
            }

            return output;
        }
    }
}
