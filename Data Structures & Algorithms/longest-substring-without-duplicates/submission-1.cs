public class Solution {
    public int LengthOfLongestSubstring(string s) {
       
        HashSet<char> input = new HashSet<char>();
        int left = 0;
        int right = 0;
        int currentLength = 0; int maxLength=0;

        for (right = 0; right < s.Length; right++)
        {
            while(input.Contains(s[right]))
            {
                input.Remove(s[left]);
                left=left+1;
            }
            input.Add(s[right]);
            
            currentLength = right - left + 1;
            if(currentLength>maxLength)
            {
                maxLength = currentLength;
            }

        }

        return maxLength;
    }
}