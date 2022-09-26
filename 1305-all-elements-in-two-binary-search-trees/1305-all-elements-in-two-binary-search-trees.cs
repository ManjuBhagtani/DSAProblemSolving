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
    
    public void Inorder(TreeNode root, IList<int> inorder){
        if(root == null){
            return;
        }
        Inorder(root.left, inorder);
        inorder.Add(root.val);
        Inorder(root.right, inorder);
    }
    public IList<int> GetAllElements(TreeNode root1, TreeNode root2) {
        IList<int> inorder1 = new List<int>();
        IList<int> inorder2 = new List<int>();
        Inorder(root1, inorder1);
        Inorder(root2, inorder2);
        
        int n1 = inorder1.Count;
        int n2 = inorder2.Count;
        
        IList<int> ans = new List<int>(n1+n2);
        
        int p1 = 0;
        int p2 = 0;
        
        while(p1 < n1 && p2 < n2){
            if(inorder1[p1] < inorder2[p2]){
                ans.Add(inorder1[p1]);
                p1++;
            }else{
                ans.Add(inorder2[p2]);
                p2++;
            }
        }
        while(p1 < n1){
            ans.Add(inorder1[p1]);
            p1++;
        }
        while(p2 < n2){
            ans.Add(inorder2[p2]);
            p2++;
        }
        return ans;
    }
}

/*
    TC = O(n+m)
    SC = O(n+m)
*/