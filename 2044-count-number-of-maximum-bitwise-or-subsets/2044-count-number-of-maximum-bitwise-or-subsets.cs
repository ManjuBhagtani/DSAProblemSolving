public class Solution {
    public bool checkBit(int n, int i){
        if(((n>>i)&1) == 1){
            return true;
        }    
        return false;
    }
    
    public int CountMaxOrSubsets(int[] nums) {
        int n = nums.Length;
        int numOfSubsets = 1<<n;
        
        int maxOr = 0;
        int numOfSubsetsWithMaxOr = 0;
        
        //Generate all subsets
        for(int i = 0; i<numOfSubsets; i++){
            int orOfCurrentSubset = 0;
            for(int j = 0; j<32; j++){
                if(checkBit(i, j)){ //if the jth bit in i is set, include the OR of jth no. in the subset
                    orOfCurrentSubset |= nums[j];
                }
            }
            
            if(orOfCurrentSubset > maxOr){
                maxOr = orOfCurrentSubset;
                numOfSubsetsWithMaxOr = 1;
            }else if(orOfCurrentSubset == maxOr){
                numOfSubsetsWithMaxOr++;
            }
        }
        
        return numOfSubsetsWithMaxOr;
    }
}