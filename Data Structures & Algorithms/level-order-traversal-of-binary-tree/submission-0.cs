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
    public List<List<int>> LevelOrder(TreeNode root) {
        if(root==null)
        {
        return new List<List<int>>();
        }
        Queue<TreeNode> q = new Queue<TreeNode>();
        List<List<int>> res = new List<List<int>>();
        q.Enqueue(root);
        int currlevel = 0;


        while(q.Count!=0)
        {
            var len = q.Count;
            res.Add(new List<int>());

            for(int i=0;i<len;i++)
            {
            var temp = q.Dequeue();
            res[currlevel].Add(temp.val);
            if(temp.left!=null)
            {
                q.Enqueue(temp.left);
            }
            if(temp.right!=null)
            {
                q.Enqueue(temp.right);
            }
            }
            currlevel++;

        }
        return res;
    }
}
