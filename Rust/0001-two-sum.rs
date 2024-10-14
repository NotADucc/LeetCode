impl Solution {
    pub fn two_sum(nums: Vec<i32>, target: i32) -> Vec<i32> 
    {
        use std::collections::HashMap;
        let mut cache : HashMap<i32, i32> = HashMap::with_capacity(nums.len());
        
        for (i, num) in nums.iter().enumerate()
        {
            match cache.get(num)
            {
                Some(&i2) => return vec![i2, i as i32],
                None => cache.insert(target - num, i as i32),
            };
        }

        vec![]
    }
}