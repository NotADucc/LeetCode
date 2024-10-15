/**
 * @param {string} s
 * @return {number}
 */
var minimumSteps = function(s) {
    let left = 0, right = s.length - 1, swaps = 0;
    while (left < right)
    {
        if (s[left] === '0')
        {
            left++;
        }
        else
        {
            if (s[right] === '0')
            {
                swaps += right - left;
                left++;
            }
            right--;
        }
    }
    return swaps;
};