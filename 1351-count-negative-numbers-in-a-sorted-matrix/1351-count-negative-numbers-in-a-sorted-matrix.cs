public class Solution {
    public int CountNegatives(int[][] grid) {
        int count = 0;
        int n = grid.Length;
        int m = grid[0].Length;
        
        int i = 0;
        int j = m-1; //start from top right corner
        
        while(i < n && j >= 0){
            if(grid[i][j] < 0){
                count += n-i; //all elements in this column starting from current row are -ve
                j--;
            }else{
                i++;
            }
        }
        
        return count;
    }
}
