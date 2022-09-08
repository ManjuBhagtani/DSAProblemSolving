public class Solution {
    int n;
    int m;
    
    int[] dx = {-1, 0, 1, 0};
    int[] dy = {0, 1, 0, -1};
    
    public int explore(int r, int c, int[][] grid){
        int count = 0;
        
        for(int i = 0; i<4; i++){
            int row = r + dx[i];
            int col = c + dy[i];
            if(row < 0 || row >= n || col < 0 || col >= m){
                count += 1;
                continue;
            }else if(grid[row][col] == 0){
                count += 1;
            }
        }
        
        return count;
    }
    public int IslandPerimeter(int[][] grid) {
        n = grid.Length;
        m = grid[0].Length;
            
        int ans = 0;
        
        for(int i = 0; i<n; i++){
            for(int j = 0; j < m; j++){
                if(grid[i][j] == 1){
                    ans += explore(i, j, grid);
                }
            }
        }
        
        return ans;
    }
}

/*
    TC = O(nm)
    SC = O(1)
*/