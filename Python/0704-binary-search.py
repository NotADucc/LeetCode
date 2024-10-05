class Solution:
    def search(self, nums: List[int], target: int) -> int:
        l, r = 0, len(nums) - 1
        while l <= r :
            mid = (l + r) // 2
            if nums[mid] < target :
                l = mid + 1
            elif nums[mid] > target :
                r = mid - 1
            else :
                return mid

        return -1
        
class Solution:
    def search(self, nums: List[int], target: int) -> int:
        return self.rec(nums, target, 0, (len(nums) - 1) // 2, len(nums) - 1)
    def rec(self, nums: List[int], target: int, l : int, mid : int, r : int) -> int:
        if l >= r :
            return l if nums[l] == target else -1
        
        if nums[mid] < target :
            return self.rec(nums, target, mid + 1, (mid + 1 + r) // 2, r)
        else :
            return self.rec(nums, target, l, (mid + l) // 2, mid)
