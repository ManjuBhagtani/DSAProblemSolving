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
    public TreeNode SearchBST(TreeNode root, int val) {
        TreeNode temp = root;
        
        while(temp != null){
            if(temp.val == val){
                return temp;
            }
            if(temp.val > val){
                temp = temp.left;
            }else{
                temp = temp.right;
            }
        }
        
        return null;
    }
}

/*
    TC = O(log n) if tree is balanced
       = O(n) if the tree is skewed
    SC = O(1)
*/