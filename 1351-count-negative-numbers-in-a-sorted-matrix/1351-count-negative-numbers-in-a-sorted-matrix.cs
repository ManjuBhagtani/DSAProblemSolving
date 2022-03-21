public class Solution {
    public int CountNegatives(int[][] grid) {
//         int count = 0;
//         int n = grid.Length;
//         int m = grid[0].Length;
        
//         int i = 0;
//         int j = m-1; //start from top right corner
        
//         while(i < n && j >= 0){
//             if(grid[i][j] < 0){
//                 count += n-i; //all elements in this column starting from current row are -ve
//                 j--;
//             }else{
//                 i++;
//             }
//         }
        
//         return count;
        
        /*
            TC = O(n+m)
            SC = O(1)
        */
        
        /*-----------Approach 2 - Binary Search----------------------*/
        int m = grid.Length;
        int n = grid[0].Length;
        int count = 0;
        for(int i = 0; i<m; i++){
            int start = 0;
            int end = n-1;
            int ans = n;
            
            while(start <= end){
                int mid = (end-start)/2 + start;
                if(grid[i][mid] < 0){
                    ans = mid;
                    end = mid-1;
                }else{
                    start = mid+1;
                }
            }
            
            count += n-ans;
        }
        
        return count;
        
        /*
            TC = O(mlogn) - we are applying binary search(logn) on each row(m rows)
            SC = O(1)
            Binary search approach doesn't take advantage of sortedness of columns
            If the no. of rows(m) is huge, then mlogn > n+m
        */
    }
}
