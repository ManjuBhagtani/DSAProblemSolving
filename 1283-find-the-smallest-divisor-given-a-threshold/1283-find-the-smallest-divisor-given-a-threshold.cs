public class Solution {
    
    public bool check(int[] nums, int n, int threshold, int divisor){
        int divisionResult = 0;
        for(int i = 0; i<n; i++){
            divisionResult += (int)Math.Ceiling((decimal)nums[i]/divisor);
            if(divisionResult > threshold){
                return false;
            }
        }   
        return true;
    }
    
    public int SmallestDivisor(int[] nums, int threshold) {
        //if we divide all nos. by 1, sum of division results = sum(nums)
        //greatest no. which can be used as divisor = any no. >= max(nums) - all division results would be 1
        //smallest divisor which will yield division result as 1 = max(nums)
        //sum of all division results in this case = nums.Length
        //smallest value threshold can take = nums.Length
        //so, range where divisor can lie = [1, max(nums)]
        
        int n = nums.Length;
        int max = nums[0];
        for(int i = 1; i<n; i++){                       //O(n)
            max = Math.Max(nums[i], max);
        }
        
        int low = 1;
        int high = max;
        int ans = 1;
        while(low <= high){                             //O(log(max))
            int mid = low + (high-low)/2;
            
            //can division by mid yeild a result <= threshold?
            //if yes, then division by all nos. greater than mid will also yield result <= thresold
            //so, discard right half of search space
            if(check(nums, n, threshold, mid)){         //O(n)
                ans = mid;
                high = mid-1;
            }else{
                low = mid+1;
            }
        }
        
        return ans;
        
        /*
            TC = O(nlog(max))
            SC = O(1)
        */
    }
}