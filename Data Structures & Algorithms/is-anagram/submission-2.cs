public class Solution {
    public bool IsAnagram(string s, string t) {

if(s.Length!=t.Length)
return false;

var count=new int[26];


foreach(var i in s)
{
    count[i-'a']++;
}

foreach(var j in t)
{
    count[j-'a']--;
}

foreach(var k in count)
{
    if(k>0)
    {
        return false;
    }
}

return true;


    }
}
