impl Solution 
{
    pub fn minimum_steps(s: String) -> i64 
    {
        let bytes = s.as_bytes();
        let mut left = 0;
        let mut right = s.len() - 1;
        let mut swaps = 0;

        while left < right
        {
            if bytes[left] == 48
            {
                left += 1;
            }
            else
            {
                if bytes[right] == 48
                {
                    swaps += (right - left) as i64;
                    left += 1;
                }
                right -= 1;
            }
        }

        swaps
    }
}