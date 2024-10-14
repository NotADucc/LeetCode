class Solution {
    public int minSwaps(String s) {
        int open = 0, swaps = 0;
        for (var ch : s.toCharArray()) {
            if (ch == '[') {
                open++;
            }
            else {
                if (open <= 0) {
                    swaps++;
                    open++;
                }
                else {
                    open--;
                }
            }
        }
        return swaps;
    }
}