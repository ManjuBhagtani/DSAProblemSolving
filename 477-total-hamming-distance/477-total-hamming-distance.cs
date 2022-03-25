public class Solution {
    
    public bool checkBit(int n, int i){
        if(((n>>i)&1) == 1){
            return true;
        }
        return false;
    }
    public int TotalHammingDistance(int[] nums) {
        int hammingDist = 0;
        
        int n = nums.Length;
        
        for(int i = 0; i<32; i++){
            int setBits = 0;
            for(int j = 0; j<n; j++){
                if(checkBit(nums[j], i)){
                    setBits++;
                }
            }
            hammingDist += (n-setBits)*setBits;
        }
        
        return hammingDist;
        
        /*
            TC = O(log maxNoThatCanFitInDatatype * N)
            SC = O(1)
        */
    }
}