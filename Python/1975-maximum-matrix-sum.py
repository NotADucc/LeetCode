class Solution:
    def maxMatrixSum(self, matrix: List[List[int]]) -> int:
        odd_neg = False 
        smallest_magnitude = float("inf") 

        res = 0
        for row in matrix:
            for num in row:
                magnitude = num
                if num < 0:
                    magnitude *= -1
                    odd_neg = not odd_neg

                if smallest_magnitude > magnitude:
                    smallest_magnitude = magnitude
                res += magnitude
                    
        if odd_neg:
            res -= 2 * smallest_magnitude
        
        return res