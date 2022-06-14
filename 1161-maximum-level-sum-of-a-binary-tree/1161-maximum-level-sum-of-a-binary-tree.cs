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
    public int MaxLevelSum(TreeNode root) {
        Queue<TreeNode> q = new Queue<TreeNode>();
        int maxSum = int.MinValue;
        int currentLevel = 0;
        int levelWithMaxSum = 0;
        
        q.Enqueue(root);
        
        while(q.Count > 0){
            int sz = q.Count;
            int sum = 0;
            currentLevel++;
            for(int i = 1; i<=sz; i++){
                TreeNode first = q.Dequeue();
                sum += first.val;
                if(first.left != null){
                    q.Enqueue(first.left);
                }
                if(first.right != null){
                    q.Enqueue(first.right);
                }
            }
            if(sum > maxSum){
                maxSum = sum;
                levelWithMaxSum = currentLevel;
            }
        }
        
        return levelWithMaxSum;
        
        /*
            TC = O(n)
            SC = O(n)
        */
    }
}