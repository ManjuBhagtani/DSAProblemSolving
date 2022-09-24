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
    
    public TreeNode ConstructMaximumBinaryTree(int[] nums, int start, int end){
        if(start> end){
            return null;
        }
        int max = nums[start];
        int maxIndex = start;
        for(int i = start+1; i<=end; i++){
            if(nums[i] > max){
                max = nums[i];
                maxIndex = i;
            }
        }
        TreeNode root = new TreeNode(max);
        root.left = ConstructMaximumBinaryTree(nums, start, maxIndex-1);
        root.right = ConstructMaximumBinaryTree(nums, maxIndex+1, end);
        
        return root;
    }
    public TreeNode ConstructMaximumBinaryTree(int[] nums) {

        return ConstructMaximumBinaryTree(nums, 0, nums.Length-1);
    }
}

/*
    TC = O()
*/