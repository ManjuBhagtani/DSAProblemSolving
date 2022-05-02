public class Solution {
    
    public bool check(int[] nums, int n, int k, int mid){ //O(n)
        int sum = 0;
        
        //check if the first subarray of size= mid 
        for(int i = 0; i<mid; i++){
            sum += nums[i];
        }
        if(mid-sum <= k){
            return true;
        }
        //else check rest of the subarrays of size mid
        for(int i = mid; i<n; i++){
            sum  = sum - nums[i-mid] + nums[i];
            if(mid-sum<=k){
                return true;
            }
        }
        
        return false;
    }
    
    public int LongestOnes(int[] nums, int k) {
        //the array nums might contain 0 1s. Then we can flip k 0s to get k 1s
        //or it can contain all 1s
        //maximum no. of consecutive 1s can lie between 1 and n
        
        int n = nums.Length;
        int low = k;
        int high = n;
        int ans = 0;
        while(low <= high){                     //O(logn)
            int mid = low + (high-low)/2;
            //check if a subarray of size mid with all 1s is possible
            if(check(nums, n, k, mid)){
                ans = mid; //if subarray of size mid can have all 1s, a subarray of smaller size can also have all 1s. So, discard left half
                low = mid+1;
            }else{
                high = mid-1;
            }
        }
        
        return ans;
        
        /*
            TC = O(nlogn)
            SC = O(1)
        */
    }
}