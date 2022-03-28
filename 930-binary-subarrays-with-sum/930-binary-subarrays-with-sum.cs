public class Solution {
    public int NumSubarraysWithSum(int[] nums, int goal) {
        int n = nums.Length;
        
        int count = 0;
        
        for(int i = 0; i<n; i++){
            int sum = 0;
            for(int j = i; j<n; j++){
                sum += nums[j];
                if(sum == goal){
                    count++;
                }else if(sum > goal){
                    break;
                }
            }
        }
        
        return count;
        
        /*
            TC = O(n^2)
            SC = O(1)
        */
    }
}