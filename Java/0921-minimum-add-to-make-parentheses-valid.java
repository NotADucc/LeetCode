class Solution {
    public int minAddToMakeValid(String s) {
        int open = 0, closed = 0;

		for (var ch : s.toCharArray()) {
            if (ch == '(') {
                open++;
            }
            else {
                if (open <= 0) {
                    closed++;
                }
                else {
                    open--;
                }
            }
        }

        return open + closed;
    }
}