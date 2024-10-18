class Solution {
    public int countMaxOrSubsets(int[] nums) {
        Output output = new Output();
        backtrack(output, nums, 0, 0);
        return output.count;
    }
    private void backtrack(Output output, int[] nums, int current, int index) {
        if (current >= output.value) {
            if (current > output.value) {
                output.value = current;
                output.count = 1;
            }
            else {
                output.count++;
            }
        }
        for (int i = index; i < nums.length; i++) {
            backtrack(output, nums, current | nums[i], i + 1);
        }
    }
    private class Output
    {
        public int value = 0;
        public int count = 0;
    }
}