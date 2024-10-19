class Solution {
    public char findKthBit(int n, int k) {
        StringBuilder sb = new StringBuilder("0");
        while (sb.length() <= k) {
            int len = sb.length();
            char[] arr = new char[len + 1];
            arr[0] = '1';
            for (int i = 0; i < len; i++) {
                char inverted = sb.charAt(i) == '0' ? '1' : '0';
                arr[len - i] = inverted;
            }
            sb.append(arr);
        }
        return sb.charAt(k - 1);
    }
}