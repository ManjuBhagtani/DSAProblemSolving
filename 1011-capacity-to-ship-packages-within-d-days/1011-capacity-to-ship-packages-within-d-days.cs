public class Solution {
    
    public bool check(int[] weights, int n, int mid, int days){ //O(n)
        int sum = 0;
        int count = 1;
        for(int i = 0; i<n; i++){
            sum += weights[i];
            if(sum > mid){
                count++;
                sum = weights[i];
                if(count > days){
                    return false;
                }
            }
        }

        return true;
    }
    
    public int ShipWithinDays(int[] weights, int days) {
        //if we have only 1 day, all packages need to be loaded on the same day
        //so, capacity of ship must be sum(weights)
        //if we have days = no. of packages, then 1 package can be shipped on each day
        //capacity of ship must be max(weights)
        //range in which the capacity of ship must lie = [max(weights), sum(weights)]
        
        int n = weights.Length;
        int max = weights[0];
        int sum = weights[0];
        
        for(int i = 1; i<n; i++){               //O(n)
            max = Math.Max(weights[i], max);
            sum += weights[i];
        }
        
        int low = max;
        int high = sum;
        int ans = -1;
        while(low <= high){                     //O(log(sum-max))
            int mid = low + (high-low)/2;
            //check if total weight = mid can be shipped in days
            if(check(weights, n, mid, days)){ //if all packages can be shipped in days, then they can be shipped in no. of days > days, so discard right part of search space
                ans = mid;     
                high = mid-1;
            }else{ //if the packages cannot be shipped in mid no. of days, they cannot be shipped in < mid no. of days, so discard left part of search space
                low = mid+1;
            }
        }
        
        return ans;
        
        /*
            TC = O(n) + O(n*log(sum-max)) = O(n*log(sum-max))
            SC = O(1)
        */
    }
}