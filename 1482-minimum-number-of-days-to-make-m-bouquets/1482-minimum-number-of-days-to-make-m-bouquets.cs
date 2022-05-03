public class Solution {
    public bool check(int[] bloomDay, int n, int bouquetsNeeded, int k, int mid, int flowersNeeded){
        int flowersBloomed = 0;
        int count = 0;
        for(int i = 0; i<n; i++){
            if(bloomDay[i] <= mid){ //flower has bloomed till midth day
                flowersBloomed++;
                if(flowersBloomed == k){
                    count++; //no. of bouquets ready
                    flowersBloomed = 0;
                }
            }else{
                flowersBloomed = 0;
            }
        }

        if(count >= bouquetsNeeded){
            return true;
        }
        return false;
    }
    
    public int MinDays(int[] bloomDay, int m, int k) {
        int n = bloomDay.Length;
        int flowersNeeded = m*k;
        if(flowersNeeded > n){
            return -1;
        }
        
        //suppose all flowers have bloomed on day1
        //then I can make all bouquets on day1
        //so, min no. of days required = 1
        //max no. of days required = max bloom day
        //range of no. of days in which all bouquets can be made = [1,max(bloomDay)]
        
        int max = bloomDay[0];
        
        for(int i = 1; i<n; i++){                   //O(n)
            max = Math.Max(bloomDay[i], max);
        }
        int low = 1;
        int high = max;
        
        int ans = -1;
        
        while(low <= high){                         //O(logn)
            int mid = low + (high-low)/2;
            
            //till mid no. of days, can we make m bouquets, each containing k continuous flowers?
            //check if on midth day, we have >= m*k continuous flowers bloomed
            //if the reqd no. of flowers have bloomed till midth day, 
            //then they have bloomed till mid+1th day, mid+2th day... maxth day. Discard right part of search space
            if(check(bloomDay, n, m, k, mid, flowersNeeded)){ //O(n)
                ans = mid;
                high = mid-1;
            }else{
                low = mid+1;
            }
        }
        
        return ans;
        
        /*
            TC = O(n + nlog(max(bloomDay))) = O(nlog(max(bloomDay)))
            SC = O(1)
        */
    }
}
