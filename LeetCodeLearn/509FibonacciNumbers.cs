namespace LeetCodeLearn
{
    /// <summary>
    /// 斐波那契数
    /// </summary>
    public class _509FibonacciNumbers
    {
        //用备忘录DP table 来储存已计算的状态
        public static int Fib(int n)
        {
            if (n == 0) return 0;
            int[] dp = new int[n];
            dp[0] = dp[1] = 1;

            for (int i = 2; i < n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }

            return dp[n - 1];
        }

        //只存储之前的两个状态,状态压缩
        public static int BestFib(int n)
        {
            if (n == 2 || n == 1)
            {
                return 1;
            }

            int prev = 1, curr = 1;
            for (int i = 3; i <= n; i++)
            {
                int sum = prev + curr;
                prev = curr;
                curr = sum;
            }
            return curr;
        }
    }
}
