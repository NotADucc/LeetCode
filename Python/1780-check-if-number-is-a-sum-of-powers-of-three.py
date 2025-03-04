class Solution:
    def checkPowersOfThree(self, n: int) -> bool:
        pwr = 1_162_261_467
        while pwr > 0 :
            if n >= pwr :
                n -= pwr
            pwr //= 3
        return n == 0
        