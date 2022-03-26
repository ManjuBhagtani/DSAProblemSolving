public class Solution {
    public bool checkBit(int n, int i){
        if(((n>>i)&1) == 1){
            return true;
        }
        return false;
    }
    
    public int[] GetMaximumXor(int[] nums, int maximumBit) {
        int n = nums.Length;
        int[] ans = new int[n];
        
        int xorAll = 0;
        
        for(int i = 0; i<n; i++){
            xorAll ^= nums[i];
        }
        
        int nMinus1 = n-1;
        
        for(int j = 0; j<n; j++){
            int k = 0;
            for(int i = 0; i<maximumBit ; i++){
                if(!checkBit(xorAll, i)){
                    k |= (1<<i);
                }                
            }
            xorAll ^= k;
            ans[j] = k;
            xorAll ^= k ^ nums[nMinus1-j];         
        }
        
        return ans;
        
        /*
            TC = O(n) for xoring all + O(n*maximumBit)
               = O(n*maximumBit)
            SC = O(n)
        */
    }
}