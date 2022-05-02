public class Solution {
    public int countGreaterThanEqualToMid(int[] nums, int n, int mid){
        int count = 0;
        for(int i = 0; i<n; i++){ //O(n)
            if(nums[i] >= mid){
                count++;
            }
        }
        return count;
    }
    
    public int SpecialArray(int[] nums) {
        //there can be minimum 0 nos. greater than or equal to x
        //there can be maximum 100 nos. greater than or equal to x
        //so, x can lie between [0, 100]
        int n = nums.Length;
        //Array.Sort(nums);
        int low = 0;
        int high = 100;
        
        while(low <= high){ //O(log100)
            int mid = low + (high-low)/2;
            int count = countGreaterThanEqualToMid(nums, n, mid);
            if(count == mid){ //mid is the special no.
                return mid;
            }else if(count < mid){
                high = mid-1;
            }else{
                low = mid+1;
            }
        }
        
        return -1;
        
        /*
            TC = O(nlog100)
            SC = O(1)
        */
    }
}