class Solution:
    def reverseStr(self, s: str, k: int) -> str:
        k_2 = k << 1
        arr = list(s)
        for i in range(0, len(s), k_2) :
            l, r = i, min(i + k - 1, len(s) - 1)
            while l < r :
                arr[l], arr[r] = arr[r], arr[l]
                l += 1
                r -= 1
        return ''.join(arr)
                    