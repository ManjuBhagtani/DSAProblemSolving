public class Solution {
    
    public void flipRow(int[][] grid, int rowNumber, int cols){
        for(int i = 0; i<cols; i++){
            grid[rowNumber][i] = 1-grid[rowNumber][i];
        }    
    }
    
    public int MatrixScore(int[][] grid) {
        //for every row, check if the first bit is 0
        //if yes, then flip the row
        //so. in every row, the first bit should be 1.
        //why? ex. if a row is 0111, then if we flip, it'll be 1000. prev value = 7 and new val = 8. Weight of first bit > weight of all other bits combined
        //for every column, check the no. of 0s and 1s
        //if no. of 0s > no of 1s, flip the column
        
        int rows = grid.Length;
        int cols = grid[0].Length;
        
        
        for(int i = 0; i<rows; i++){        //O(n*m)
            if(grid[i][0] == 0){
                flipRow(grid, i, cols);
            }           
        }
        
        int ans = 0;
        
        int power = 1;
        
        for(int j = cols-1; j>0; j--){          //O(n*m)   
            int zerosInCol = 0;
            for(int i = 0; i<rows; i++){
                if(grid[i][j] == 0){
                    zerosInCol++;
                }
            }
            ans += (power * Math.Max(zerosInCol, rows-zerosInCol));
            power *= 2;
        }
        
        ans += power*rows;
        
        return ans;
        
        /*
            TC = O(n*m)
            SC = O(1)
        */
    }
}