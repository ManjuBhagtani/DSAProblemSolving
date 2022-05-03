public class Solution {
    public bool check(int[] position, int n, int balls, int dist){
        int lastPos = position[0]; //placed at 1st position
        int ballsPlaced = 1;

        for(int i = 1; i<n; i++){
            if(position[i]-lastPos >= dist){
                ballsPlaced++;
                lastPos = position[i];
                if(ballsPlaced >= balls){
                    return true;
                }
            }
        }
        
        return false;
    }
    
    public int MaxDistance(int[] position, int m) {
        //we have to maximize the minimum magnetic force
        //if only 2 balls, then maximum distance = max(position)-min(position)
        //if no. of baskets = no. of balls, then each ball will go to 1 basket
       //minimum distance = 1
        //range of reqd force = [1, max-min]
        
        Array.Sort(position);                       //O(nlogn)
        int n = position.Length;
        
        int low = 1;
        int high = position[n-1] - position[0];
        int ans = -1;
        while(low <= high){                         //O(log(range))
            int mid = low + (high-low)/2;
            
            //can we have >= mid distance(force) between any two baskets
            if(check(position, n, m, mid)){         //O(n)
                ans = mid;
                low = mid+1;
            }else{
                high = mid-1;
            }
        }
        
        return ans;
        
        /*
            TC = O(nlogn + nlog(range)) = O(nlog(range))
            SC = O(1)
            
        */
    }
}