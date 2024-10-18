class Solution:
    def __init__(self):
        self.value = 0
        self.count = 0

    def countMaxOrSubsets(self, nums: List[int]) -> int:
        self.backtrack(nums, 0, 0)
        return self.count

    def backtrack(self, nums, current, index):
        if current >= self.value:
            if current > self.value:
                self.value = current
                self.count = 1
            else:
                self.count += 1
        for i in range(index, len(nums)):
            self.backtrack(nums, current | nums[i], i + 1)
