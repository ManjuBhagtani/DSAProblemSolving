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
    public TreeNode InsertIntoBST(TreeNode root, int val) {
        TreeNode newNode = new TreeNode(val);
        if(root == null){
            root = newNode;
            return root;
        }
        TreeNode temp = root;
        while(true){
            if(val < temp.val){
                if(temp.left == null){
                    temp.left = newNode;
                    break;
                }
                temp = temp.left;
            }else{
                if(temp.right == null){
                    temp.right = newNode;
                    break;
                }
                temp = temp.right;
            }
        }
        
        return root;
    }
}

/*
    TC = O(height) -> can be as bad as O(n) if tree is skewed
    SC = O(1)
*/