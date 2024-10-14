class Solution:
    def minAddToMakeValid(self, s: str) -> int:
        open, extra = 0, 0
        for ch in s :
            if ch == '(' :
                open += 1
            else :
                if open <= 0 :
                    extra += 1
                else :
                    open -= 1
        return open + extra