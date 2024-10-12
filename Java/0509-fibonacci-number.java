class Solution {
    public int fib(int n) {
        int[] mem = new int[n];
        return rec(n, mem);
    }
    private int rec(int n, int[] mem) {
        if (n <= 0) {
            return 0;
        }
        else if (n <= 2) {
            return 1;
        }
        else if (mem[n - 1] == 0) {
            mem[n - 1] = rec(n - 2, mem) + rec(n - 1, mem);
        }
        return mem[n - 1];
    }
}