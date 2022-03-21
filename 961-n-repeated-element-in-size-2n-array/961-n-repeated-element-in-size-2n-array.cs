public class Solution {
    public int RepeatedNTimes(int[] nums) {
        int n = nums.Length;
        
        HashSet<int> hs = new HashSet<int>(n/2);
        
        for(int i = 0; i<n; i++){
            if(hs.Contains(nums[i])){
                return nums[i];
            }else{
                hs.Add(nums[i]);
            }
        }
        
        return -1;
        
        /*
            TC = O(n)
            SC = O(n)
        */
    }
}