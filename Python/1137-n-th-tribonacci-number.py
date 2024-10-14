class Solution:
    def tribonacci(self, n: int) -> int:
        mem = [0] * (n + 1)
        return self.rec(n, mem)
    def rec(self, n, mem) :
        if n <= 0 :
            return 0
        elif n <= 2 :
            return 1
        elif mem[n - 1] == 0 :
            mem[n - 1] = self.rec(n - 3, mem) +  self.rec(n - 2, mem) +  self.rec(n - 1, mem)
        return mem[n - 1]
        