public class TrieNode{
    public Dictionary<char, TrieNode> children = new Dictionary<char, TrieNode>();
    public bool isEnd = false;
}

public class Solution {
    TrieNode root = new TrieNode();
private HashSet<string> res = new HashSet<string>();
    private bool[,] visit;
    public List<string> FindWords(char[][] board, string[] words) {

        foreach(var w in words)
{
    var curr = root;

    foreach(char c in w)
    {
        if(!curr.children.ContainsKey(c))
        {
            curr.children[c] = new TrieNode();
        }

        curr = curr.children[c];
    }

    curr.isEnd = true;
}

      int ROWS = board.Length, COLS = board[0].Length;
        visit = new bool[ROWS, COLS];

        for (int r = 0; r < ROWS; r++) {
            for (int c = 0; c < COLS; c++) {
                Dfs(board, r, c, root, "");
            }
        }
        return new List<string>(res);

    }

     private void Dfs(char[][] board, int r, int c, TrieNode node, string word) {
        int ROWS = board.Length, COLS = board[0].Length;
        if (r < 0 || c < 0 || r >= ROWS ||
            c >= COLS || visit[r, c] ||
            !node.children.ContainsKey(board[r][c])) {
            return;
        }

        visit[r, c] = true;
        node = node.children[board[r][c]];
        word += board[r][c];
        if (node.isEnd) {
            res.Add(word);
        }

        Dfs(board, r + 1, c, node, word);
        Dfs(board, r - 1, c, node, word);
        Dfs(board, r, c + 1, node, word);
        Dfs(board, r, c - 1, node, word);

        visit[r, c] = false;
    }
}
