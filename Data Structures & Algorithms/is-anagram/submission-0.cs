public class Solution {
    public bool IsAnagram(string s, string t) {

          if (s.Length != t.Length) {
            return false;
        }
        HashSet<char> FirstString = new HashSet<char>();

        foreach(char a in s)
            {FirstString.Add(a);}

        foreach(char b in t)
        {
            if(!FirstString.Contains(b))
            {
                return false;
            }


        }
        return true;

    }
}
