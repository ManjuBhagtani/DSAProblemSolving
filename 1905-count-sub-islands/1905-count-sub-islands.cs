public class Solution {
    int n;
    int m;
    
    int[] dx = {-1, 0, 1, 0};
    int[] dy = {0, 1, 0, -1};
    bool result;
    
    public int CountSubIslands(int[][] grid1, int[][] grid2) {
        n = grid1.Length;
        m = grid1[0].Length;
        
        int count = 0;
        
        for(int i = 0; i<n; i++){
            for(int j = 0; j<m; j++){
                result = true;
                if(grid2[i][j] == 1){
                    isSubIsland(i, j, grid1, grid2);
                    if(result){
                        count++;
                    }
                }
            }
        }
        
        return count;
    }
    
    public void isSubIsland(int i, int j, int[][] grid1, int[][] grid2){ //dfs
        
        if(grid1[i][j] != 1){
            result = false;
        }
        
        grid2[i][j] = -1;
        
        for(int k = 0; k<4; k++){
            int newI = i + dx[k];
            int newJ = j + dy[k];
            
            if(newI >= 0 && newI < n && newJ >= 0 && newJ < m && grid2[newI][newJ] == 1){
                isSubIsland(newI, newJ, grid1, grid2);
            }
        }
    }
}

/*
    TC = O(V+E) = O(nm + 2nm) = O(nm)
    SC = O(V) = O(nm) for recursion call stack
*/