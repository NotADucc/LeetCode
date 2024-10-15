class Solution {
    public long minimumSteps(String s) {
        int left = 0, right = s.length() - 1;
        long swaps = 0;

        while (left < right) {
            char chL = s.charAt(left);
            if (chL == '0') {
                left++;
            }
            else {
                char chR = s.charAt(right);
                if (chR == '0') {
                    swaps += right - left;
                    left++;
                }
                right--;
            }
        }

        return swaps;
    }
}