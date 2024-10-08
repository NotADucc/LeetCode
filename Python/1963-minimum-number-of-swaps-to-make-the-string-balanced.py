class Solution:
    def minSwaps(self, s: str) -> int:
        output, count = 0, 0
        for ch in s :
            if ch == '[' :
                count += 1
            else :
                if count <= 0 :
                    count += 1
                    output += 1
                else :
                    count -= 1
        return output