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
    public int DeepestLeavesSum(TreeNode root) {
        //BFS
        
        Queue<Tuple<TreeNode, int>> q = new Queue<Tuple<TreeNode, int>>();
        //TreeNode = any node, int to store its distance from root
        
        q.Enqueue(new Tuple<TreeNode, int>(root, 0));
        int maxDist = 0;
        
        int sum = root.val;
        
        while(q.Count > 0){
            Tuple<TreeNode, int> front = q.Dequeue();
            
            TreeNode node = front.Item1;
            int dist = front.Item2;
            
            if(node.left != null){
                q.Enqueue(new Tuple<TreeNode, int>(node.left, dist+1));
                if(dist+1 > maxDist){
                    maxDist = dist+1;
                    sum = node.left.val;
                }else if(dist+1 == maxDist){
                    sum += node.left.val;
                }
            }
            if(node.right != null){
                q.Enqueue(new Tuple<TreeNode, int>(node.right, dist+1));
                if(dist+1 > maxDist){
                    maxDist = dist+1;
                    sum = node.right.val;
                }else if(dist+1 == maxDist){
                    sum += node.right.val;
                }
            }
        }
        
        return sum;
    }
}

/*
    TC = O(V+E)
    SC = O(V)
*/