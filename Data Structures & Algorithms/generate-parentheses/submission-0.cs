public class Solution {  
public List<string> GenerateParenthesis(int n) {
    List<string> res = new List<string>();
    Backtrack(res, "", n, n);
    return res;
}

private void Backtrack(List<string> res, string current, int open, int close)
{
    // base case
    if (open == 0 && close == 0)
    {
        res.Add(current);
        return;
    }

    // add '('
    if (open > 0)
    {
        Backtrack(res, current + "(", open - 1, close);
    }

    // add ')'
    if (close > open)
    {
        Backtrack(res, current + ")", open, close - 1);
    }
}
}
