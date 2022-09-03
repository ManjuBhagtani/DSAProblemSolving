public class Solution {
    
    public bool isValid(int x, int y, int n, int m, bool[,] visited, int[][] grid){
        if(x >= 0 && x < n && y >= 0 && y < m && !visited[x, y] && grid[x][y] == 1){
            return true;
        }
        return false;
    }
    
    public int dfs(int[][] grid, int x, int y, bool[,] visited, int area, int[] dx, int[] dy, int n, int m){
        visited[x, y] = true;
        area = 1;
        
        for(int i = 0; i<4; i++){
            int newX = x + dx[i];
            int newY = y + dy[i];
            
            if(isValid(newX, newY, n, m, visited, grid)){
                area += dfs(grid, newX, newY, visited, 0, dx, dy, n, m);
            }
        }
        
        return area;
    }
    
    public int dfsHelper(int[][] grid){
        int n = grid.Length;
        int m = grid[0].Length;
        
        bool[,] visited = new bool[n,m];
        int maxArea = 0;
        
        int[] dx = {-1, 0, 1, 0};
        int[] dy = {0, 1, 0, -1};
        
        for(int i = 0; i<n; i++){
            for(int j = 0; j<m; j++){
                if(!visited[i, j] && grid[i][j] == 1){
                    int area = dfs(grid, i, j, visited, 0, dx, dy, n, m);
                    maxArea = Math.Max(maxArea, area);
                }
            }
        }
        
        return maxArea;
    }
    
    public int MaxAreaOfIsland(int[][] grid) {
        
        return dfsHelper(grid);
        
    }
}

/*
    TC = O(V+E) = O(nm+2nm) = O(nm)
    SC = O(V) = O(nm)
*/