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
    StringBuilder ans = new StringBuilder("");
    public void PreOrder(TreeNode root){
        ans.Append(root.val);
        if(root.left != null){    
            ans.Append('(');
            PreOrder(root.left);
            ans.Append(')');
        }               
        
        if(root.right != null){
            if(root.left == null){
                ans.Append("()");
            }
            ans.Append('(');
            PreOrder(root.right);  
            ans.Append(')');
        }
        
    }
    
    public string Tree2str(TreeNode root) {
        PreOrder(root);
        return ans.ToString();
    }
}