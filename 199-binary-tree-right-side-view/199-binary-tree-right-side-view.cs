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
    public IList<int> RightSideView(TreeNode root) {
        IList<int> ans = new List<int>();
        
        if(root == null){
            return ans;
        }
        
        Queue<TreeNode> q = new Queue<TreeNode>();       
        q.Enqueue(root);
        
        while(q.Count > 0){
            int sz = q.Count;
            for(int i = 1; i<=sz; i++){
                TreeNode first = q.Dequeue();
                if(i == sz){
                    ans.Add(first.val);
                }
                if(first.left != null){
                    q.Enqueue(first.left);
                }
                if(first.right != null){
                    q.Enqueue(first.right);
                }                
            }
        }
        
        return ans;
        
        /*
            TC = O(n)
            SC = O(n)
        */
    }
}