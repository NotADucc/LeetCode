class Solution {
    public int lengthOfLongestSubstring(String s) {
		List<Character> arr = new ArrayList<>();
		int output = 0;
		for(int right = 0; right < s.length(); right++) {
			if(arr.contains(s.charAt(right))) { 
				int index = arr.indexOf(s.charAt(right));
				arr.remove(index);
				if(index > 0)
					arr.subList(0, index).clear();
			}
			arr.add(s.charAt(right));
			output = Math.max(output, arr.size());
		}
		return output;
    }
}
