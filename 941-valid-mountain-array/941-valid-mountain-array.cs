public class Solution {
    public bool ValidMountainArray(int[] arr) {
        
        int n = arr.Length;
        
        int peekIndex = -1;
        
        //traverse from L to R as long as current eleemnt-previous element > 0
        for(int i = 1; i<n; i++){
            if(arr[i] - arr[i-1] < 0){
                peekIndex = i-1; ////the point where curr-prev <= 0 is the peek point
                break;
            }else if(arr[i] - arr[i-1] == 0){
                return false;   
            }
        }
        if(peekIndex <= 0){ //edge case: nothing beyond/before peek element
            return false;
        }
        
        //start traversing again from L to R, previous element-current eleemnt>0
        for(int i = peekIndex+1; i<n; i++){
            if(arr[i] - arr[i-1] >= 0){
                return false;
            }
        }
        
        return true;
        
        /*
            TC = O(N)
            SC = O(1)
        */
    }
}
//plane, valley, peek