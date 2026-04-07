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
    public int KthSmallest(TreeNode root, int k) {

        List<int> sorted = new List<int>();
        Inorder(root, ref sorted);
        return sorted[k-1]!=null? sorted[k-1]: 0;
    }

    private void  Inorder(TreeNode n, ref List<int> s)
    {
        if(n == null)
        {
            return;
        }

        Inorder(n.left, ref s);
        s.Add(n.val);
        Inorder(n.right, ref s);

    }
}
