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
    public TreeNode InvertTree(TreeNode root) {

        if(root == null)
        {
            return null;
        }

        var temp = root.left;
        root.left = (root.right!=null)?InvertTree(root.right):null;
        root.right = (temp!=null)?InvertTree(temp):null;
        return root;
        
    }
}
