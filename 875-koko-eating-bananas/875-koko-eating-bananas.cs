public class Solution {
    
    public bool check(int[] piles, int n, int h, long mid){ //O(n)
        int actualHoursTaken = 0;
        for(int i = 0; i<n; i++){
            actualHoursTaken += (int)Math.Ceiling((decimal)piles[i]/mid);
            if(actualHoursTaken > h){
                return false;
            }
        }    
        return true;
    }
    
    public int MinEatingSpeed(int[] piles, int h) {
        //if h = 1, Koko has to eat all bananas in 1 hr
        //so, k = sum(piles)
        //if h = sum(piles), then Koko can eat 1 banana in 1 hr
        //so Koko should eat bananas in the range [1, sum(piles)]
        
        int n = piles.Length;
        long sum = (long)piles[0];
        for(int i = 1; i<n; i++){               //O(n)
            sum += piles[i];
        }
        
        long low = 1;
        long high = sum;
        long ans = -1;                          //O(log(sum))
        while(low <= high){
            long mid = low + (high-low)/2;
            
            //can Koko eat mid no. of bananas each hour in h hours and finish all?
            if(check(piles, n, h, mid)){ //if Koko can finish all bananas in mid hours, she can finish in > mid hours. Discard right half;
                ans = mid;
                high = mid-1;
            }else{
                low = mid+1;
            }
        }
        
        return (int)ans;
        
        /*
            TC = O(nlog(sum(piles)))
            SC = O(1)
        */
    }
}
