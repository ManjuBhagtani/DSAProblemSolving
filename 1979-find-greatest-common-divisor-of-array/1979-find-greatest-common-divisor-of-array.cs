public class Solution {
    
    public int gcd(int a, int b){
        if(a == 0){
            return b;
        }
        return gcd(b%a, a);
    }
    public int FindGCD(int[] nums) {
        int max = nums[0];
        int min = nums[0];
        int n = nums.Length;
        for(int i = 1; i<n; i++){
            max = Math.Max(nums[i], max);
            min = Math.Min(nums[i], min);
        }
        
        return gcd(max, min);
        
        /*
            TC = O(n) + O(log max)
            SC = O(log max) 
        */
    }
}