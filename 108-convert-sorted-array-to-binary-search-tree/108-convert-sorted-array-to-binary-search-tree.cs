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
    public TreeNode constructTree(int[] nums, int start, int end){
        if(start > end){
            return null;
        }
        int mid = start + (end-start)/2;
        TreeNode root = new TreeNode(nums[mid]);
        root.left = constructTree(nums, start, mid-1);
        root.right = constructTree(nums, mid+1, end);
        
        return root;
    }
    public TreeNode SortedArrayToBST(int[] nums) {
        return constructTree(nums, 0, nums.Length-1);
    }
}

/*
    TC = O(n)
    SC = O(log n base 2)
*/