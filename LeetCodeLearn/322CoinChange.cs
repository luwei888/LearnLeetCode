using System;

namespace LeetCodeLearn
{
    public class _322CoinChange
    {
        public static float CoinChange(int[] coins, float amount)
        {
            float Dp(float n)
            {
                if (n == 0)
                {
                    return 0;
                }
                if (n <= 0)
                {
                    return -1;
                }

                float res = float.MaxValue;
                foreach (int coin in coins)
                {
                    float subproblem = Dp(n - coin);
                    if (subproblem == -1)
                    {
                        continue;
                    }
                    res = Math.Min(res, 1 + subproblem);
                }
                return res != float.MaxValue ? res : -1;
            }
            return Dp(amount);
        }
    }
}
