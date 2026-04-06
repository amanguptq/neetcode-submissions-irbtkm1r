/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public int GoodNodes(TreeNode root) {
        return DFS(root, root.val);
        
    }

    private int DFS(TreeNode n, int maxVal)
    {
        if(n== null)
        {
            return 0;
        }
        int res = 0;

        if(n.val>=maxVal)
        {
            res+=1;
        }
        maxVal = Math.Max(maxVal, n.val);
        res+= DFS(n.left,maxVal);
        res+=DFS(n.right, maxVal);

        return res;
    }
}
