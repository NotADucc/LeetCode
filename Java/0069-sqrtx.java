class Solution {
    public int mySqrt(int x) {
        int left = 0, right = x;

        while (left <= right) {
            int mid = left + ((right - left) >> 1);
            if ((long)mid*mid <= (long)x) {
                left = mid+1;
            }
            else if ((long)mid*mid > (long)x) {
                right = mid-1;
            }
        }

        return left - 1;
    }
}
