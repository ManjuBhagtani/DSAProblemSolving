public class Solution {
    public int BusyStudent(int[] startTime, int[] endTime, int queryTime) {
        int n = startTime.Length;
        int count = 0;
        for(int i = 0; i<n; i++){
            if(queryTime >= startTime[i] && queryTime <= endTime[i]){
                count++;
            }    
        }
        
        return count;
        
        /*
            TC = O(n)
            SC = O(1)
        */
    }
}