public class Solution {
    public List<string> LetterCombinations(string digits) {

        if(digits=="")
        {
            return new List<string>();
        }
       Dictionary<string, List<string>> chars = new Dictionary<string, List<string>>()
        {
            {"2",new List<string>{"a","b","c"}},
            {"3",new List<string>{"d","e","f"}},
            {"4",new List<string>{"g","h","i"}},
            {"5",new List<string>{"j","k","l"}},
            {"6",new List<string>{"m","n","o"}},
            {"7",new List<string>{"p","q","r","s"}},
            {"8",new List<string>{"t","u","v"}},
            {"9",new List<string>{"w","x","y","z"}}
        };
        List<List<string>> lists = new List<List<string>>();
        foreach(var s in digits)
        {
            lists.Add(chars[s.ToString()]);
        }
        List<string> res = new List<string>();
        StringBuilder sb = new StringBuilder();
        Dfs(lists,0, res, sb);
        return res;
    }

    void Dfs( List<List<string>> digits,int start,List<string> res,StringBuilder sb){

        if(sb.Length == digits.Count)
        {
            res.Add(new string(sb.ToString()));
            return;
        }

        for(int i = start; i<digits.Count;i++)
        {
            foreach(var s in digits[i])
            {
                sb.Append(s);
                Dfs(digits,i+1, res, sb);
                sb.Length--;
            }
        }



    }
}
