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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        IList<IList<int>> ans = new List<IList<int>>();
        
        if(root == null){
            return ans;
        }
        
        Queue<TreeNode> q = new Queue<TreeNode>();
        
        q.Enqueue(root);
        
        while(q.Count > 0){
            int sz = q.Count;
            IList<int> level = new List<int>();
            for(int i = 1; i<=sz; i++){
                TreeNode first = q.Dequeue();
                level.Add(first.val);
                if(first.left != null){
                    q.Enqueue(first.left);
                }
                if(first.right != null){
                    q.Enqueue(first.right);
                }
            }  
            ans.Add(level);
        }
        
        return ans;
        
        /*
            TC = O(N)
            SC = O(N)
        */
    }
}