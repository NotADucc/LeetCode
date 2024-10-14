class Solution {
    public long maxKelements(int[] nums, int k) {
        PriorityQueue<Integer> queue = new PriorityQueue<>();
        for (int num : nums) {
            queue.add(-num);
        }

        long output = 0L;
        for (; k > 0; k--) {
            int val = queue.poll();
            output += -val;
            queue.add((int)Math.floor(val * 1.0 / 3));
        }

        return output;
    }
}