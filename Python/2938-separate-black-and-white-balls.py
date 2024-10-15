class Solution:
    def minimumSteps(self, s: str) -> int:
        left, right, swaps = 0, len(s) - 1, 0
        
        while left < right :
            if s[left] == '0' :
                left += 1
            else :
                if s[right] == '0' :
                    swaps += right - left
                    left += 1
                right -= 1
        
        return swaps
