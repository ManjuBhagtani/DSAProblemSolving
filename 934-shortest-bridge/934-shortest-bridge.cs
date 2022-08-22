public class Solution {
    public bool isValid(int x, int y, int[][] grid, bool[,] visited, int n, int m){
        if(x >= 0 && x < n && y >= 0 && y < m && !visited[x,y] && grid[x][y] == 1){
            return true;
        }
        return false;
    }
    
    public bool isValid2(int x, int y, bool[,] visited, int n, int m){
        if(x >= 0 && x < n && y >= 0 && y < m && !visited[x,y]){
            return true;
        }
        return false;
    }
    
    public void dfs(int x, int y, int[][] grid, bool[,] visited, int n, int m, Queue<Tuple<int, int>> q, int[] dx, int[] dy){
        visited[x,y] = true;
        q.Enqueue(new Tuple<int, int>(x, y));
        
        for(int  i = 0; i<4; i++){
            int newI = x + dx[i];
            int newJ = y + dy[i];

            if(isValid(newI, newJ, grid, visited, n, m)){ //land and not visited
                dfs(newI, newJ, grid, visited, n, m, q, dx, dy);
            }
        }
    }
    public int ShortestBridge(int[][] grid) {
        //Do DFS on 1st island, put all the cells of first island in queue
        //Do BFS, and find the second island
        
        int n = grid.Length;
        int m = grid[0].Length;
        
        bool[, ] visited = new bool[n,m];
        Queue<Tuple<int, int>> q = new Queue<Tuple<int, int>>();
        
        int[] dx = {-1, 0, 1, 0};
        int[] dy = {0, 1, 0, -1};
        
        bool flag = true;
        
        for(int i = 0; i<n; i++){
            for(int j = 0; j<m; j++){
                if(grid[i][j] == 1 && flag){ //land
                    dfs(i, j, grid, visited, n, m, q, dx, dy);
                    flag = false;
                }
            }
        }
        
        int[,] dist = new int[n,m];
        
        //bfs
        while(q.Count > 0){
            Tuple<int, int> front = q.Dequeue();
            
            for(int i = 0; i<4; i++){
                int newI = front.Item1 + dx[i];
                int newJ = front.Item2 + dy[i];
                
                if(isValid2(newI, newJ, visited, n, m)){
                    if(grid[newI][newJ] == 1){ //found another island
                        return dist[front.Item1, front.Item2];
                    }else{
                        q.Enqueue(new Tuple<int, int>(newI, newJ));
                        visited[newI, newJ] = true;
                        dist[newI, newJ] = dist[front.Item1, front.Item2] + 1;
                    }
                }
            }
        }
        
        return 0;
    }
}

/*
    TC = O(V+E) = O(nm)
    SC = O(V+E) = O(nm)
*/