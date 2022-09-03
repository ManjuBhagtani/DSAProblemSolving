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
    public int GoodNodes(TreeNode root) {
        int goodNodes = 1; //root
        
        Queue<Tuple<TreeNode, int>> q = new Queue<Tuple<TreeNode, int>>();
        //TreeNode = any node
        //int to store the max node value seen along the path to that node
        
        q.Enqueue(new Tuple<TreeNode, int>(root, root.val));
        
        while(q.Count > 0){
            Tuple<TreeNode, int> front = q.Dequeue();
            TreeNode node = front.Item1;
            int maxSoFar = front.Item2;
            
            if(node.left != null){
                if(node.left.val >= maxSoFar){
                    goodNodes++;
                }
                q.Enqueue(new Tuple<TreeNode, int>(node.left, Math.Max(maxSoFar, node.left.val)));                 }
            if(node.right != null){
                if(node.right.val >= maxSoFar){
                    goodNodes++;
                }
                q.Enqueue(new Tuple<TreeNode, int>(node.right, Math.Max(maxSoFar, node.right.val)));
            }
        }
        
        return goodNodes++;
    }
}

/*
    TC = O(V+E)
    SC = O(V);
*/