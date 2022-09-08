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
public class FindElements {
    HashSet<int> hs;
    public FindElements(TreeNode root) {
        hs = new HashSet<int>();
        constructTree(root, 0);
    }
    
    public bool Find(int target) { //O(1)
        return hs.Contains(target);
    }
    
    public void constructTree(TreeNode root, int val){ //O(n)
        if(root == null){
            return;
        }
        //root.val = val; //without constructing tree
        hs.Add(val);
        constructTree(root.left, 2*val + 1);
        constructTree(root.right, 2*val + 2);
    }
}

/**
 * Your FindElements object will be instantiated and called as such:
 * FindElements obj = new FindElements(root);
 * bool param_1 = obj.Find(target);
 */

/*
    TC = O(n) = no. of nodes
    SC = O(n) for hashset
*/