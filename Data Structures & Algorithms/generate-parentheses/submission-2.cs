public class Solution {  
public List<string> GenerateParenthesis(int n) {
    List<string> res = new List<string>();
    StringBuilder s = new StringBuilder();
        Backtrack(res, s, n, n);
    return res;
}

private void Backtrack(List<string> res, StringBuilder sb, int open, int close)
{
    if (open == 0 && close == 0)
    {
        res.Add(sb.ToString());
        return;
    }

    if (open > 0)
    {
        sb.Append("(");
        Backtrack(res, sb, open - 1, close);
        sb.Length--; // backtrack
    }

    if (close > open)
    {
        sb.Append(")");
        Backtrack(res, sb, open, close - 1);
        sb.Length--; // backtrack
    }
}
}
