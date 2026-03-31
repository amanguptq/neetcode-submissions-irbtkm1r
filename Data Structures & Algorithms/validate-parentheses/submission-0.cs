public class Solution {
    public bool IsValid(string s) {

        Stack<char> st= new Stack<char>();
        Dictionary<char, char> pt = new Dictionary<char, char>{
            {']','['},
            {')','('},
            {'}','{'}
        };

        foreach(var c in s)
        {
            if(pt.ContainsKey(c))
            {
                if(st.Count > 0 && st.Peek() == pt[c])
                {
                    st.Pop();
                }
                else
                {
                    return false;
                }
            }
            else
            {
                st.Push(c);
            }
        }

        return st.Count == 0;
        
    }
}
