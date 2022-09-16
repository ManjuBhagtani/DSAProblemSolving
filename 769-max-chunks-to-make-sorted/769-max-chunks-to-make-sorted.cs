public class Solution {
    public int MaxChunksToSorted(int[] arr) {
        int n = arr.Length;
        
        int chunks = 0;
        int maxEle = 0;
        
        for(int i = 0; i<n; i++){
            maxEle = Math.Max(maxEle, arr[i]);
            if(maxEle == i){
                chunks++;
            }
        }
        
        return chunks;
    }
}

/*
    TC = O(n)
    SC = O(1)
*/