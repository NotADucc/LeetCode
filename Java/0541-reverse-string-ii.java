class Solution {
    public String reverseStr(String s, int k) {
        int k_2 = k << 1;
        char[] arr = s.toCharArray();
        for (int i = 0; i < s.length(); i += k_2) {
            int l = i, r = Math.min(l + k - 1, s.length() - 1);
            while (l < r) {
                arr[l] ^= arr[r];
                arr[r] ^= arr[l];
                arr[l] ^= arr[r];
                l++;
                r--;
            }
        }

        return new String(arr);
    }
}