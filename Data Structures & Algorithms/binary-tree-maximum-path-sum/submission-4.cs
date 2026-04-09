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
    int maxSum = int.MinValue;
    public int MaxPathSum(TreeNode root) {
        Sum(root);
        return maxSum;
    }

    public int Sum(TreeNode n)
    {
        if(n == null)
        {
            return 0;
        }
        int leftGain = Math.Max(Sum(n.left),0);
        int rightGain = Math.Max(Sum(n.right),0);

        int sum = n.val + leftGain +rightGain;
        maxSum = Math.Max(maxSum, sum);
        return n.val + Math.Max(rightGain, leftGain);

        
    }

}
