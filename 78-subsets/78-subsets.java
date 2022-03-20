class Solution {
    
    public boolean checkBit(int n, int i){
        if(((n>>i)&1) == 1){
            return true;
        }
        return false;
    }
    
    public List<List<Integer>> subsets(int[] nums) {
        int n = nums.length;
        int noOfSubsets = 1<<n;
        
        List<List<Integer>> ans = new ArrayList<List<Integer>>(noOfSubsets);
        
        for(int i = 0; i<noOfSubsets; i++){
            List<Integer> subset = new ArrayList<Integer>();
            for(int j = 0; j<n; j++){
                if(checkBit(i, j)){
                    subset.add(nums[j]);
                }
            }
            ans.add(subset);
        }
        
        return ans;
        
        /*
            TC = O(2^n * n)
        */
    }
}
