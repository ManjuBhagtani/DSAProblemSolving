/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class Solution {
    public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target) {
        if(original == target){
            return cloned;
        }
        if(original == null){
            return null;
        }
        TreeNode L = GetTargetCopy(original.left, cloned.left, target);
        //TreeNode R = null;
        if(L == null){
            return GetTargetCopy(original.right, cloned.right, target);
        }else{
            return L;
        }
    }
}

/*
    TC = O(n)
    SC = O(h)
*/