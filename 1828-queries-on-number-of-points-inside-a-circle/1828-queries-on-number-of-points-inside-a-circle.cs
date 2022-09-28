public class Solution {
    public int[] CountPoints(int[][] points, int[][] queries) {
        int n = points.Length;
        
        int q = queries.Length;
        int[] ans = new int[q];
        
        for(int i = 0; i<q; i++){
            int cx = queries[i][0];
            int cy = queries[i][1];
            int radius = queries[i][2];
            
            int radiusSquare = radius*radius;
            
            for(int j = 0; j<n; j++){
                int px = points[j][0];
                int py = points[j][1];
                
                long distanceFromCenter = (long)((cx-px)*(cx-px))+((cy-py)*(cy-py));
                if(distanceFromCenter <= radiusSquare){
                   ans[i]++; 
                }
            }
        }
        
        return ans;
    }
}

/*
    TC = O(n*q)
    SC = O(1)
*/