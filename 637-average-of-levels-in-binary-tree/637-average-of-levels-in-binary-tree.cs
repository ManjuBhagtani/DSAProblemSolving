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
    public IList<double> AverageOfLevels(TreeNode root) {
        IList<double> ans = new List<double>();
        if(root == null){
            return ans;
        }
        
        Queue<TreeNode> q = new Queue<TreeNode>();
        
        q.Enqueue(root);
        
        while(q.Count > 0){
            int sz = q.Count;
            double sum = 0;
            for(int i = 1; i<=sz; i++){
                TreeNode first = q.Dequeue();
                sum += first.val;
                if(first.left != null){
                    q.Enqueue(first.left);
                }
                if(first.right != null){
                    q.Enqueue(first.right);
                }
            }
            sum /= sz;
            
            ans.Add(sum);
        }
        return ans;
    }
}