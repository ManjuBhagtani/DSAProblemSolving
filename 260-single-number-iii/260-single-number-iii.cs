public class Solution {
   
    public int[] SingleNumber(int[] nums) {
        int n = nums.Length;

        int xorAll = 0;
        for(int i = 0; i<n; i++){
            xorAll ^= nums[i];
        }

        int setBit = xorAll & -xorAll;

        int[] ans = new int[2];

        for(int i = 0; i<n; i++){
            if((nums[i] & setBit) > 0){
                ans[0] ^= nums[i];
            }else{
                ans[1] ^= nums[i];
            }
        } 
        
        return ans;    
        
        /*
            TC = O(n)
            SC = O(1)
        */
    }
}