public class Solution {
    public int MaxSubArray(int[] nums) {
        //Kadane's algorithm
        int ans = int.MinValue;
        int sum = 0;
        int n = nums.Length;
        
        for(int i = 0; i<n; i++){
            sum += nums[i];
            ans = Math.Max(ans, sum);
            if(sum < 0){
                sum = 0;
            }
        }
        
        return ans;
        
        /*
            TC = O(n)
            SC = O(1)
        */
    }
}