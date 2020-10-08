namespace LeetCodeLearn
{
    /// <summary>
    /// 斐波那契数
    /// </summary>
    public class _509FibonacciNumbers
    {
        public static int Fib(int N)
        {
            int[] dp = new int[N];
            dp[0] = dp[1] = 1;

            for (int i = 2; i < N; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }

            return dp[N-1];
        }
    }
}
