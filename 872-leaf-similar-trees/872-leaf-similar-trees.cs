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
    List<int> leafSequence = new List<int>();
    bool flag = true;
    bool leafSimilar = true;
    public void inorder(TreeNode root){
        if(root == null || !leafSimilar){
            return;
        }
        inorder(root.left);
        inorder(root.right);
        if(root.left == null && root.right == null){
            if(flag){
                leafSequence.Add(root.val);
            }else{
                if(leafSequence.Count > 0 && leafSequence[0] == root.val){
                    leafSequence.RemoveAt(0);
                }else{
                    leafSimilar = false;
                }
            }
        }
    }
    public bool LeafSimilar(TreeNode root1, TreeNode root2) {
        inorder(root1);
        flag = false;
        inorder(root2);
        if(leafSequence.Count == 0 && leafSimilar){
            return true;
        }
        return false;
    }
}

/*
    TC = O(n+m)
    SC = O(n) for storing leaf sequence +
         Max(h1,h2)
*/