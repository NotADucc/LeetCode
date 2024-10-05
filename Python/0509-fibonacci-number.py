class Solution:
    def fib(self, n: int) -> int:
        dp = [0] * (n + 1)
        return self.rec(n, dp)

    def rec(self, n: int, dp: List[int]):
        if n == 0 :
            return 0
        elif n == 1 :
            return 1
        elif dp[n - 1] == 0 :
            dp[n - 1] = self.rec(n - 1, dp) + self.rec(n - 2, dp)
            
        return dp[n - 1]