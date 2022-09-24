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
    int sum = 0;
    public void SumEvenGrandparent(TreeNode root, TreeNode parent, TreeNode grandParent){
        if(root == null){
            return;
        }
        if(grandParent != null && grandParent.val%2 == 0){
            sum += root.val;
        }
        SumEvenGrandparent(root.left, root, parent);
        SumEvenGrandparent(root.right, root, parent);
    }
    public int SumEvenGrandparent(TreeNode root) {
        SumEvenGrandparent(root, null, null);
        return sum;
    }
}

/*
    TC = O(n)
    SC = O(h)
*/