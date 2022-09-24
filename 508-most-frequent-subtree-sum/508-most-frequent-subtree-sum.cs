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
    Dictionary<int, int> sumFreq = new Dictionary<int, int>(); //Key = sum value, Value = frequency of sum
    int maxFreq = 0;
    
    public int FindFrequencyOfEachSum(TreeNode root){
        if(root == null){
            return 0;
        }
        int L = FindFrequencyOfEachSum(root.left);
        int R = FindFrequencyOfEachSum(root.right);
        int sum = L + R + root.val;
        if(sumFreq.ContainsKey(sum)){
            sumFreq[sum]++;
        }else{
            sumFreq.Add(sum, 1);
        }
        maxFreq = Math.Max(sumFreq[sum], maxFreq);
        
        return sum;
    }
    public int[] FindMostFrequentSum(){
        List<int> ansList = new List<int>();
        foreach(KeyValuePair<int, int> entry in sumFreq){
            if(entry.Value == maxFreq){
                ansList.Add(entry.Key);
            }
        }
        
        return ansList.ToArray();
    }
    public int[] FindFrequentTreeSum(TreeNode root) {
        FindFrequencyOfEachSum(root);
        return FindMostFrequentSum();
    }
}

/*
    TC = O(n)
    SC = O(n+h)
       = O(n)
*/