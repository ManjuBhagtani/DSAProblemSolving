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
    int n = 0;
    int ans = -1;
    public void Inorder(TreeNode root, int k){
        if(n > k){
            return;
        }
        if(root == null){
            return;
        }
        Inorder(root.left, k);
        n++;
        if(n == k){
            ans = root.val;
            return;
        }
        Inorder(root.right, k);
    }
    public int KthSmallest(TreeNode root, int k) {
        Inorder(root, k);
        
        return ans;
    }
}

/*
    TC = O(k)
    SC = O(h)
*/