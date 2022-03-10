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
    
    public IList<int> PostorderTraversal(TreeNode root) {
        List<int> postOrder = new List<int>();
        
        Stack<TreeNode> stack1 = new Stack<TreeNode>();
        Stack<TreeNode> stack2 = new Stack<TreeNode>();
        
        TreeNode curr = root;
        
        if(root == null){
            return postOrder;
        }
        
        stack1.Push(curr);
        
        while(stack1.Count > 0){
            curr = stack1.Pop();
            stack2.Push(curr);
            if(curr.left != null )stack1.Push(curr.left);
            if(curr.right != null)stack1.Push(curr.right);        
        }
        
        
        while(stack2.Count > 0){
            TreeNode popped = stack2.Pop();
            postOrder.Add(popped.val);
        }
        
        return postOrder;
        
        /*
            TC = O(N)
            SC = O(N)
        */
    }
}