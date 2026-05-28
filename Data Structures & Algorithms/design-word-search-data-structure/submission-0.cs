public class TrieNode
{
    public Dictionary<char, TrieNode> children = new Dictionary<char, TrieNode>();
    public bool endOfWord = false;
}

public class WordDictionary
{
    private TrieNode root;

    public WordDictionary()
    {
        root = new TrieNode();
    }

    public void AddWord(string word)
    {
        TrieNode curr = root;

        foreach (char c in word)
        {
            if (!curr.children.ContainsKey(c))
            {
                curr.children[c] = new TrieNode();
            }

            curr = curr.children[c];
        }

        curr.endOfWord = true;
    }

    public bool Search(string word)
    {
        return DFS(word, 0, root);
    }

    private bool DFS(string word, int index, TrieNode node)
    {
        if (index == word.Length)
        {
            return node.endOfWord;
        }

        char c = word[index];

        if (c == '.')
        {
            foreach (var child in node.children.Values)
            {
                if (DFS(word, index + 1, child))
                {
                    return true;
                }
            }

            return false;
        }

        if (!node.children.ContainsKey(c))
        {
            return false;
        }

        return DFS(word, index + 1, node.children[c]);
    }
}