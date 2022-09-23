public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        int n = nums.Length;
        int[] ans = new int[n];
        
        for(int i = 0; i<n; i++){
            for(int j = 0; j<n; j++){
                if(i != j){
                    if(nums[j] < nums[i]){
                        ans[i] += 1;                       
                    }
                }
            }
        }
        
        return ans;
        
        /*
            TC = O(n^2)
            SC = O(n)
        */
    }
}