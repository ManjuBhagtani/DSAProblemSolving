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
    public bool EvaluateTree(TreeNode root) {
        if(root.left == null && root.right == null){
            if(root.val == 1)
                return true;
            else
                return false;
        }
        bool L = EvaluateTree(root.left);
        bool R = EvaluateTree(root.right);
        if(root.val == 2){
            return L || R;
        }else{
            return L && R;
        }
    }
}

/*
    TC = O(n)
    SC = O(h)
*/