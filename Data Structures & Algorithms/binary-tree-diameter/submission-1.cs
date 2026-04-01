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
    public int DiameterOfBinaryTree(TreeNode root) {

        var res = 0;
        DFS(root, ref res);
        return res;
    }

    public int DFS(TreeNode node, ref int res)
    {
        if(node==null)
        return 0;

        int left = DFS(node.left, ref res);
        int right = DFS(node.right, ref res);
        res = Math.Max(res, left+right);
        return 1 + Math.Max(left, right);        
    }
}
