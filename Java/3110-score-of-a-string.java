class Solution {
    public int scoreOfString(String s) {
        int output = 0;

        for (int i = 0; i < s.length() - 1; i++) {
            output += Math.abs(s.charAt(i) - s.charAt(i + 1));
        }

        return output;
    }
}