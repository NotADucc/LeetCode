class Solution {
    public boolean containsNearbyDuplicate(int[] nums, int k) {
        // key : num
        // value last index
        HashMap<Integer, Integer> map = new HashMap<>();

        for (int i = 0; i < nums.length; i++) {
            int num = nums[i];
            if (map.containsKey(num) && i - map.get(num) <= k) {
                return true;
            }
            map.put(num, i);
        }

        return false;
    }
}


// sliding window
class Solution {
    public boolean containsNearbyDuplicate(int[] nums, int k) {
        // key : num
        // value last index
        HashMap<Integer, Integer> map = new HashMap<>();
        int l = 0, r = 0;
        while (r < nums.length) {
            if (r - l > k) map.remove(nums[l++]);
            if (map.containsKey(nums[r])) return true;
            map.put(nums[r], r++);
        }

        return false;
    }
}