public class Solution {
    public int[] XorQueries(int[] arr, int[][] queries) {
        int n = arr.Length;
        
        int[] prefixXorArray = new int[n];
        
        prefixXorArray[0] = arr[0];
        
        for(int i = 1; i<n; i++){                               //O(n)
            prefixXorArray[i] = arr[i] ^ prefixXorArray[i-1];
        }
        
        int q = queries.Length;
        int[] ans = new int[q];
        
        for(int i = 0; i<q; i++){                               //O(q)
            ans[i] = prefixXorArray[queries[i][1]];
            if(queries[i][0] > 0){
                ans[i] = ans[i] ^ prefixXorArray[queries[i][0]-1];
            }
        }
        
        return ans;
        
        /*
            TC = O(n+q)
            SC = O(n+q)
        */
    }
}