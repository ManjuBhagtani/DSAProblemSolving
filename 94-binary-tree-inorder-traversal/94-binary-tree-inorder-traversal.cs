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
    public IList<int> InorderTraversal(TreeNode root) {
        List<int> inorder = new List<int>();
        Stack<TreeNode> stack = new Stack<TreeNode>();
        
        TreeNode curr = root;
        
        while(curr != null || stack.Count > 0){
            while(curr != null){
                stack.Push(curr);
                curr = curr.left;
            }
            
            TreeNode peek = stack.Peek();
            stack.Pop();
            inorder.Add(peek.val);
            
            curr = peek.right;
        }
        
        return inorder;
        /*
            TC = O(n)
            SC = O(log n) if tree is balanced
               = O(n) if tree is left skewed
               = O(1) if tree is right skewed
        */
    }
}