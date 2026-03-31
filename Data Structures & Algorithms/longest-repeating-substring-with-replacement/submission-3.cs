public class Solution {
    public int CharacterReplacement(string s, int k) {

        Dictionary<char, int> o= new Dictionary<char,int>();
        int res=0,maxf=0, l=0;

        for(int r=0; r<s.Length; r++)
        {
            if(o.ContainsKey(s[r]))
            {
                o[s[r]]++;
            }
            else
            {
                o[s[r]] = 1;
            }

            maxf = Math.Max(maxf, o[s[r]]);

            while(((r-l+1)-maxf)>k)
            {
               o[s[l]]--;
               l++; 
            }

            res = Math.Max(res, r-l+1);
        }
    return res;
          
    }
}
