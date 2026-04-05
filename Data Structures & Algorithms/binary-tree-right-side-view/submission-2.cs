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
    public List<int> RightSideView(TreeNode root) {
          if(root==null)
        {
            return new List<int>();
        }

        IList<IList<int>> res = new List<IList<int>>();
        List<int> resu = new List<int>();
        Queue<TreeNode> q= new Queue<TreeNode>();
        q.Enqueue(root);
        int currLevel = 0;

        while(q.Count>0)
        {
            var len = q.Count;
            res.Add(new List<int>());
            for(int i =0; i<len; i++)
            {
                var temp = q.Dequeue();
                res[currLevel].Add(temp.val);

                if(temp.left!=null)
                {
                    q.Enqueue(temp.left);
                }

                if(temp.right!=null)
                {
                    q.Enqueue(temp.right);
                }
            }
            resu.Add(res[currLevel][res[currLevel].Count-1]);

            currLevel++;
        }

        // foreach(var i in res)
        // {
        //     var len = i.Count;
        //     resu.Add(i[len-1]);
        // }

        return resu;


        
    }
}
