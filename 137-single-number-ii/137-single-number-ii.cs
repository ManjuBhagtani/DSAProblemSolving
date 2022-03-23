public class Solution {
    
    public bool checkBit(int n, int i){
        if(((n>>i)&1) == 1){
            return true;
        }
        return false;
    }
    
    public int SingleNumber(int[] nums) {
        int n = nums.Length;
        int ans = 0;
        
        for(int i = 0; i<32; i++){
            int count = 0;
            for(int j = 0; j<n; j++){
                if(checkBit(nums[j], i)){
                    count++;
                }
            }
            
            if(count%3 != 0){
                ans = ans | (1<<i);
            }
        }
        
        return ans;
        
        /*
            TC = O(log maxValueTheDatatypeCanStore * N)
            SC = O(1)
        */
    }
}