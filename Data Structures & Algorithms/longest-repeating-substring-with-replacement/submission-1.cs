public class Solution {
    public int CharacterReplacement(string s, int k) {

        int left=0, right =0, currentlength = 0, maxlength = 0;
        char currentChar;

        for(right=0; right<s.Length; right++){
            
            currentChar=s[left];

            if(currentChar == s[right])
            {
                currentlength=currentlength+1;
            }
            else
            {
                if(k>0)
                {
                    currentlength=currentlength+1;      
                    k--;
                }
                
            }

            if(maxlength < currentlength)
            {
                maxlength = currentlength;
            }
        }

        return maxlength;
        
    }
}
